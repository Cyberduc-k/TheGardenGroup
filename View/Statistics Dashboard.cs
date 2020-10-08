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
    public partial class Tickets_Dashboard : Form
    {
        private IServiceProvider provider;

        public Tickets_Dashboard(IServiceProvider provider)
        {
            this.provider = provider;

            InitializeComponent();
        }

        private void Tickets_Dashboard_Load(object sender, EventArgs e)
        {
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

            lbl_AmountOfActiveTickets.Text = ticketService.Count().ToString();
        }
    }
}
