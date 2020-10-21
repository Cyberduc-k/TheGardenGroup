using System;
using Service;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class View_Ticket : Form
    {
        public View_Ticket(Ticket ticket)
        {
            //Make sure the ticket can be viewed
            if (ticket.Id == null) 
            {
                ErrorHandler.Instance.HandleError("The ID cant be null, so the ticket cant be viewed", "Cant be null", new ArgumentNullException());
                Close();
            }

            InitializeComponent();

            //Show all info of the ticket
            ViewTicket_lblTicketID.Text = "Ticket #" + ticket.Id;
            ViewTicket_lblSubject.Text = ticket.Subject;
            ViewTicket_lblDescription.Text = ticket.Description;

            ViewTicket_lblName.Text = ticket.Client.Alias;
            ViewTicket_lblMail.Text = ticket.Client.Email;

            ViewTicket_lblCategory.Text = ticket.Category.ToString();
            ViewTicket_lblPriority.Text = ticket.Priority.ToString();
            ViewTicket_lblDeadline.Text = ticket.DaysToSolve.ToString();
            ViewTicket_lblDate.Text = ticket.DateOfIssueing.ToString("dd-MM-yyyy");

            //Set the status of the ticket
            if (ticket.Solved)
            {
                ViewTicket_lblStatus.Text = "Solved";
                ViewTicket_txtAreaSolution.Text = ticket.Solution;
            }
            else
            {
                ViewTicket_lblStatus.Text = "Unsolved";
                ViewTicket_txtAreaSolution.Text = "There is no solution given yet";
            }

            if (ticket.ReviewScore != 0)
            {
                txtAreaReview.Text = ticket.Review;
                lbl_ReviewScore.Text = $"{ticket.ReviewScore} / 10";
            } else
            {
                txtAreaReview.Text = "This ticket has not been reviewed yet";
            }
        }

        #region OnClicks
        private void ViewTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}