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

namespace View
{
    public partial class Resolve_Ticket : Form
    {
        public Resolve_Ticket(Ticket ticket)
        {
            InitializeComponent();

            ResolveTicket_lblTicketID.Text = ticket.Id;
            ResolveTicket_lblSubject.Text = ticket.Subject;
            ResolveTicket_lblStatus.Text = ticket.Solved.ToString().ToUpper();

            ResolveTicket_lblName.Text = ticket.Client.Name;
            ResolveTicket_lblMail.Text = ticket.Client.Email;

            ResolveTicket_lblCategory.Text = ticket.Category.ToString();
            ResolveTicket_lblPriority.Text = ticket.Priority.ToString();
            ResolveTicket_lblDeadline.Text = ticket.DaysToSolve.ToString();
            ResolveTicket_lblDate.Text = ticket.DateOfIssueing.ToString("dd-MM-yyyy");
        }

        private void ResolveTicket_btnResolve_Click(object sender, EventArgs e)
        {

        }

        private void ResolveTicket_btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
