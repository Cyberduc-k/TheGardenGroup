using System;
using Service;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Resolve_Ticket : Form
    {
        private IServiceProvider provider;
        private Ticket ticket;

        public Resolve_Ticket(Ticket ticket, IServiceProvider provider)
        {
            if (ticket.Id == null) 
            {
                ErrorHandler.Instance.HandleError("The ID cant be null", "Cant be null", new ArgumentNullException());
                return;
            }

            this.provider = provider;
            this.ticket = ticket;

            InitializeComponent();

            ResolveTicket_lblTicketID.Text = ticket.Id;
            ResolveTicket_lblSubject.Text = ticket.Subject;
            ResolveTicket_lblStatus.Text = ticket.Solved.ToString().ToUpper();
            ResolveTicket_lblDescription.Text = ticket.Description;

            //ResolveTicket_lblName.Text = ticket.Client.Name;
            //ResolveTicket_lblMail.Text = ticket.Client.Email;

            ResolveTicket_lblCategory.Text = ticket.Category.ToString();
            ResolveTicket_lblPriority.Text = ticket.Priority.ToString();
            ResolveTicket_lblDeadline.Text = ticket.DaysToSolve.ToString();
            ResolveTicket_lblDate.Text = ticket.DateOfIssueing.ToString("dd-MM-yyyy");
        }

        private void ResolveTicket_btnResolve_Click(object sender, EventArgs e)
        {
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

            ticket.Solution = ResolveTicket_txtAreaSolution.Text;
            ticket.Solved = true;

            ticketService.Update(ticket);
        }

        private void ResolveTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
