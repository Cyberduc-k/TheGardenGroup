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

            lbl_AmountOfActiveTickets.Text = ticketService.Count().ToString();
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
            login.Show();
            login.Activate();
            Close();
        }

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {
            Tickets_Dashboard tickets = Application.OpenForms.OfType<Tickets_Dashboard>().FirstOrDefault();

            if (tickets == null)
            {
                tickets = new Tickets_Dashboard(provider);
                tickets.FormClosed += (_1, _2) => Close();
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
