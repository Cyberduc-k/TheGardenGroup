using System;
using Service;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Resolve_Ticket : Form
    {
        private IServiceProvider provider;
        private ITicketService ticketService;
        private Ticket ticket;

        public Resolve_Ticket(Ticket ticket, IServiceProvider provider)
        {
            //Make sure the ticket can be viewed
            if (ticket.Id == null) 
            {
                ErrorHandler.Instance.HandleError("The ID cant be null, so for now you cant resolve this ticket.", "Cant be null", new ArgumentNullException());
                Close();
            }

            this.ticket = ticket;
            this.provider = provider;

            InitializeComponent();

            //Show all info of the ticket
            ResolveTicket_lblTicketID.Text = "Ticket #" + ticket.Id;
            ResolveTicket_lblSubject.Text = ticket.Subject;
            ResolveTicket_lblStatus.Text = ticket.Solved.ToString().ToUpper();
            ResolveTicket_lblDescription.Text = ticket.Description;

            ResolveTicket_lblName.Text = ticket.Client.Alias;
            ResolveTicket_lblMail.Text = ticket.Client.Email;

            ResolveTicket_lblCategory.Text = ticket.Category.ToString();
            ResolveTicket_lblPriority.Text = ticket.Priority.ToString();
            ResolveTicket_lblDeadline.Text = ticket.DaysToSolve.ToString();
            ResolveTicket_lblDate.Text = ticket.DateOfIssueing.ToString("dd-MM-yyyy");

            ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;
        }

        #region OnClicks
        private void ResolveTicket_btnResolve_Click(object sender, EventArgs e)
        {
            try
            {
                ticket.Solution = ResolveTicket_txtAreaSolution.Text;
                ticket.Solved = true;
                ticket.Handler = LoggedInUser.Instance.User;
                ticket.HandlerId = LoggedInUser.Instance.User.Id;

                ticketService.Update(ticket);

                Employee user = (Employee)LoggedInUser.Instance.User;
                user.TicketsSolved++;

                //Update the solved tickets of the user
                (provider.GetService(typeof(IUserService)) as IUserService).Update(user);

                MessageBox.Show("The ticket has successfully been resolved", "Resolved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while trying to solve the ticket, try again please.", "Cant solve ticket", ex);
            }

            Close();
        }

        private void ResolveTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region InputValidation
        //Make sure a solution is provided
        private void ResolveTicket_txtAreaSolution_TextChanged(object sender, EventArgs e)
        {
            ResolveTicket_btnResolve.Enabled = ResolveTicket_txtAreaSolution.Text.Length > 0;
        }
        #endregion
    }
}