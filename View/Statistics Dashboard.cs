using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;

namespace View
{
    public partial class Statistics_Dashboard : Form
    {
        private IServiceProvider provider;

        public Statistics_Dashboard(IServiceProvider provider)
        {
            this.provider = provider;

            InitializeComponent();
        }

        private void Tickets_Dashboard_Load(object sender, EventArgs e)
        {
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

            Tickets_Dashboard_GenInfo(ticketService);
        }

        private void Tickets_Dashboard_GenInfo(ITicketService ticketService)
        {
            //Use the count function to get the amount of active tickets
            lbl_AmountOfActiveTickets.Text = ticketService.Count().ToString();

            //Calculate the amount of tickets that need immediate attention
            IEnumerable<Ticket> tickets = ticketService.GetAll();
            int AmountOfImmediateAttentionTickets = 0;

            foreach (Ticket ticket in tickets)
            {
                if ((DateTime.Now - ticket.DateOfIssueing).TotalDays > ticket.DaysToSolve)
                {
                    AmountOfImmediateAttentionTickets++;
                }
            }
            lbl_AmountOfImmediateAttentionTickets.Text = AmountOfImmediateAttentionTickets.ToString();
        }

        private void Btn_TicketList_Click(object sender, EventArgs e)
        {
            Tickets_Dashboard dashboard = new Tickets_Dashboard(provider);

            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = Location;
            Close();
            dashboard.Show();
        }

        private void Btn_UserList_Click(object sender, EventArgs e)
        {
            User_Dashboard dashboard = new User_Dashboard(provider);

            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = Location;
            Close();
            dashboard.Show();
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

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {
            Tickets_Dashboard tickets = Application.OpenForms.OfType<Tickets_Dashboard>().FirstOrDefault();

            if (tickets == null)
            {
                tickets = new Tickets_Dashboard(provider);
            }
            
            tickets.StartPosition = FormStartPosition.Manual;
            tickets.Location = Location;
            tickets.Show();
            tickets.Activate();
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

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Edit_User editUser = new Edit_User(provider, LoggedInUser.Instance.User);

            Hide();
            editUser.StartPosition = FormStartPosition.Manual;
            editUser.Location = Location;
            editUser.ShowDialog();
            Show();
        }
    }
}
