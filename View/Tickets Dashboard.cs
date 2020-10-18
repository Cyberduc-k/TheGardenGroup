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
            IEnumerable<Ticket> tickets = ticketService.GetAll();

            //Make sure the logged in user is an employee
            Category preferredCategory = Category.Computers; //TODO: Remove
            try
            {
                preferredCategory = ((Employee)LoggedInUser.Instance.User).Expertise;           
            }
            catch (Exception e)
            {
                ErrorHandler.Instance.HandleError("You are not logged in as an employee", "Wrong user type", e);
            }

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
    }
}
