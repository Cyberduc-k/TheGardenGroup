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
        private IUserService userService;
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
            userService = provider.GetService<IUserService>();

            //Check if the logged in user is an employee or a customer and give the according amount of information to fill in the listview
            if (LoggedInUser.Instance.User is Customer)
            {
                lbl_Statistics.Hide();
                lbl_Users.Hide();
                lbl_Tickets.Left = 95;
                current_stripe.Left = 95;
                lbl_FAqMenu.Left = 180;
                TicketsDashboard_btnResolve.Hide();
                btn_SubmitTicket.Show();
                TicketsDashboard_btnViewTicket.Show();
                FillListViewCustomer(ticketService.GetAllBy(ticket => ticket.ClientId == LoggedInUser.Instance.User.Id));
            }
            else
            {
                try
                {
                    Category preferredCategory = ((Employee)LoggedInUser.Instance.User).Expertise;
                    FillListViewEmployee(ticketService.GetAll(), preferredCategory);
                }
                catch (Exception e)
                {
                    ErrorHandler.Instance.HandleError("Something went wrong with knowing which kind of account you are using. Please log in as a customer or an employee.", "Unknown user type", e);
                }
            }
        }

        //Fill in the listview
        void FillListViewEmployee(IEnumerable<Ticket> tickets, Category preferredCategory)
        {
            foreach (Ticket ticket in tickets)
            {
                ticket.Client = userService.GetSingle(ticket.ClientId);

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

        void FillListViewCustomer(IEnumerable<Ticket> tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                ticket.Client = userService.GetSingle(ticket.ClientId);

                ListViewItem li = new ListViewItem(ticket.DateOfIssueing.ToShortDateString());

                li.SubItems.Add(ticket.Category.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.Priority.ToString());
                li.Tag = ticket;

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

            editTicket.StartPosition = FormStartPosition.Manual;
            editTicket.Location = Location;
            Hide();
            editTicket.ShowDialog();
            Show();

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
            {
                TicketsDashboard_btnResolve.Enabled = false;
                TicketsDashboard_btnViewTicket.Enabled = false;
            }
            else
            {
                selectedTicket = (Ticket)lv_Tickets.SelectedItems[0].Tag;
                TicketsDashboard_btnResolve.Enabled = true;
                TicketsDashboard_btnViewTicket.Enabled = true;
            }
        }

        private void TicketsDashboard_btnResolve_Click(object sender, EventArgs e)
        {
            Resolve_Ticket resolveForm = new Resolve_Ticket(selectedTicket, provider);

            resolveForm.StartPosition = FormStartPosition.Manual;
            resolveForm.Location = Location;
            Hide();
            resolveForm.ShowDialog();
            Show();
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (login == null)
            {
                login = new Login(provider);
            }

            login.StartPosition = FormStartPosition.Manual;
            login.Location = Location;
            login.Show();
            login.Activate();
            Close();
        }

        private void lbl_FAqMenu_Click(object sender, EventArgs e)
        {
            FAQForm faq = Application.OpenForms.OfType<FAQForm>().FirstOrDefault();

            if (faq == null)
            {
                faq = new FAQForm(provider);
                faq.FormClosed += (_1, _2) => Close();
            }

            faq.StartPosition = FormStartPosition.Manual;
            faq.Location = Location;
            faq.Show();
            faq.Activate();
            Hide();
        }

        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            Submit_Ticket submit = new Submit_Ticket(provider);

            submit.StartPosition = FormStartPosition.Manual;
            submit.Location = Location;
            Hide();
            submit.ShowDialog();
            Show();

            FillTickets();
        }

        private void TicketsDashboard_btnViewTicket_Click(object sender, EventArgs e)
        {
            View_Ticket viewTicket = new View_Ticket(selectedTicket, provider);

            viewTicket.StartPosition = FormStartPosition.Manual;
            viewTicket.Location = Location;
            Hide();
            viewTicket.ShowDialog();
            Show();
        }
    }
}