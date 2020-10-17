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
            Hide();
            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = Location;
            dashboard.ShowDialog();
            Show();
            this.Close();
        }

        private void Btn_UserList_Click(object sender, EventArgs e)
        {
            User_Dashboard dashboard = new User_Dashboard(provider);
            Hide();
            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = Location;
            dashboard.ShowDialog();
            Show();
            this.Close();
        }
    }
}
