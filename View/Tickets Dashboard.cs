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
                ch_DaysToSolve,
                ch_Category,
                ch_Subject,
                ch_Priority,
                ch_Status
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
                btn_ReviewTicket.Show();
                FillListViewCustomer(ticketService.GetAllBy(ticket => ticket.ClientId == LoggedInUser.Instance.User.Id));
            }
            else
            {
                try
                {
                    FillListViewEmployee(ticketService.GetAll());
                }
                catch (Exception e)
                {
                    ErrorHandler.Instance.HandleError("Something went wrong while trying to show all tickets, for now they are not available.", "Cant show tickets", e);
                }
            }
        }

        //Fill in the listview
        void FillListViewEmployee(IEnumerable<Ticket> tickets)
        {
            int nextIndex = 0;
            foreach (Ticket ticket in tickets)
            {
                //Only the id is stored in the db, so the user has to be added again.
                ticket.Client = userService.GetSingle(ticket.ClientId);

                ListViewItem li = new ListViewItem(ticket.DateOfIssueing.ToString("dd-MM-yyyy"));

                li.SubItems.Add(ticket.DaysToSolve.ToString());
                li.SubItems.Add(ticket.Category.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.Priority.ToString());

                string status;
                if (ticket.Solved)
                    status = "Solved";
                else
                    status = "Unsolved";

                li.SubItems.Add(status);
                li.Tag = ticket;

                //Tickets that reached the time limit
                if ((DateTime.Now - ticket.DateOfIssueing).TotalDays > ticket.DaysToSolve && !ticket.Solved)
                {
                    li.BackColor = Color.FromArgb(194, 95, 95);
                    li.ForeColor = Color.White;

                    //Insert the ticket after the previous preferred ticket
                    lv_Tickets.Items.Insert(nextIndex, li);
                    nextIndex++;
                }
                //Preffered category
                else if (ticket.Category == ((Employee)LoggedInUser.Instance.User).Expertise && !ticket.Solved)
                {
                    li.BackColor = Color.FromArgb(95, 194, 129);
                    li.ForeColor = Color.White;

                    //Insert the ticket after the previous preferred ticket
                    lv_Tickets.Items.Insert(nextIndex, li);
                    nextIndex++;
                }
                else
                    lv_Tickets.Items.Add(li);
            }
        }

        void FillListViewCustomer(IEnumerable<Ticket> tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                //Only the id is stored in the db, so the user has to be added again.
                ticket.Client = userService.GetSingle(ticket.ClientId);

                ListViewItem li = new ListViewItem(ticket.DateOfIssueing.ToString("dd-MM-yyyy"));

                li.SubItems.Add(ticket.DaysToSolve.ToString());
                li.SubItems.Add(ticket.Category.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.Priority.ToString());

                string status;
                if (ticket.Solved)
                    status = "Solved";
                else
                    status = "Unsolved";

                li.SubItems.Add(status);
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
            login.RestoreLogin();
            login.Activate();
        }

        private void lbl_FAqMenu_Click(object sender, EventArgs e)
        {
            FAQForm faq = Application.OpenForms.OfType<FAQForm>().FirstOrDefault();

            if (faq == null)
            {
                faq = new FAQForm(provider);
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
            View_Ticket viewTicket = new View_Ticket(selectedTicket);

            viewTicket.StartPosition = FormStartPosition.Manual;
            viewTicket.Location = Location;
            Hide();
            viewTicket.ShowDialog();
            Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Edit_User editUser = new Edit_User(provider, LoggedInUser.Instance.User);

            Hide();
            editUser.StartPosition = FormStartPosition.Manual;
            editUser.Location = Location;
            editUser.ShowDialog();
            Show();
        }

        private void btn_ReviewTicket_Click(object sender, EventArgs e)
        {
            Review_Ticket reviewTicket = new Review_Ticket(selectedTicket, provider);

            reviewTicket.StartPosition = FormStartPosition.Manual;
            reviewTicket.Location = Location;
            Hide();
            reviewTicket.ShowDialog();
            Show();
        }
    }
}