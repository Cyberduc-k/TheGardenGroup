using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public partial class Tickets_Dashboard : Form
    {
        private IServiceProvider provider;
        private Ticket selectedTicket;

        public Tickets_Dashboard(IServiceProvider provider)
        {
            this.provider = provider;
            InitializeComponent();
            FillTickets();
        }

        private void FillTickets()
        {
            lv_Tickets.Clear();
            lv_Tickets.Columns.AddRange(new ColumnHeader[] {
                ch_DateOfIssueing,
                ch_Category,
                ch_Subject,
                ch_Priority
            });


            ITicketService ticketService = provider.GetService<ITicketService>();

            Category preferredCategory = Category.Computers; //TODO: Remove        Wat is standard voor customer tho?

            //Check if the logged in user is an employee or a customer and give the according amount of information to fill in the listview
            if (LoggedInUser.Instance.User is Customer)
            {
                //Hier gaat iets mis aaaah
                //FillListView(ticketService.GetAllBy(ticket => ticket.Client.Id == LoggedInUser.Instance.User.Id), preferredCategory);
            }
            else
            {
                try
                {
                    preferredCategory = ((Employee)LoggedInUser.Instance.User).Expertise;
                    FillListView(ticketService.GetAll(), preferredCategory);
                }
                catch (Exception e)
                {
                    ErrorHandler.Instance.HandleError("Something went wrong with knowing which kind of account you are using. Please log in as a customer or an employee.", "Unknown user type", e);
                }
            }
        }

        //Fill in the listview
        void FillListView(IEnumerable<Ticket> tickets, Category preferredCategory)
        {
            foreach (Ticket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket.DateOfIssueing.ToShortDateString());

                li.SubItems.Add(ticket.Category.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.Priority.ToString());
                li.Tag = ticket;

                if (ticket.Category == preferredCategory)
                {
                    li.BackColor = Color.FromArgb(95, 194, 129);
                    li.ForeColor = Color.White;
                    lv_Tickets.Items.Insert(0, li);
                }
                else
                    lv_Tickets.Items.Add(li);
            }
        }

        private void btn_editTicket_Click(object sender, EventArgs e)
        {
            if (lv_Tickets.SelectedItems ==  null)
            {
                ErrorHandler.Instance.HandleError("Ticket can't be null. Please select a ticket to edit", "Can't be null", new ArgumentNullException());
                return;
            }

            Edit_Ticket editTicket = new Edit_Ticket(selectedTicket, provider);
            editTicket.ShowDialog();

            FillTickets();
        }

        private void btn_deleteTicket_Click(object sender, EventArgs e)
        {
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;
            ticketService.Delete(selectedTicket);

            FillTickets();
        }

        private void lv_Tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Tickets.SelectedItems.Count <= 0)
                TicketsDashboard_btnResolve.Enabled = false;
            else
            {
                selectedTicket = (Ticket)lv_Tickets.SelectedItems[0].Tag;
                TicketsDashboard_btnResolve.Enabled = true;
            }
        }

        private void TicketsDashboard_btnResolve_Click(object sender, EventArgs e)
        {
            Resolve_Ticket resolveForm = new Resolve_Ticket(selectedTicket, provider);
            resolveForm.Show();
        }

        private void lbl_Statistics_Click(object sender, EventArgs e)
        {
            Statistics_Dashboard stats = Application.OpenForms.OfType<Statistics_Dashboard>().FirstOrDefault();

            if (stats == null)
            {
                stats = new Statistics_Dashboard(provider);
                stats.FormClosed += (_1, _2) => Close();
            }

            stats.StartPosition = FormStartPosition.Manual;
            stats.Location = Location;
            stats.Show();
            stats.Activate();
            Hide();
        }

        private void lbl_Users_Click(object sender, EventArgs e)
        {
            User_Dashboard users = Application.OpenForms.OfType<User_Dashboard>().FirstOrDefault();

            if (users == null)
            {
                users = new User_Dashboard(provider);
                users.FormClosed += (_1, _2) => Close();
            }

            users.StartPosition = FormStartPosition.Manual;
            users.Location = Location;
            users.Show();
            users.Activate();
            Hide();
        }
    }
}
