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
            IEnumerable<Ticket> tickets = ticketService.GetAll();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket.DateOfIssueing.ToShortDateString());

                li.SubItems.Add(ticket.Category.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.Priority.ToString());
                li.Tag = ticket;

                lv_Tickets.Items.Add(li);
            }
        }

    }
}
