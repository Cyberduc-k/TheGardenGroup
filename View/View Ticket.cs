using System;
using Service;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class View_Ticket : Form
    {
        public View_Ticket(Ticket ticket, IServiceProvider provider)
        {
            if (ticket.Id == null) 
            {
                ErrorHandler.Instance.HandleError("The ID cant be null", "Cant be null", new ArgumentNullException());
                return;
            }

            InitializeComponent();

            ViewTicket_lblTicketID.Text = "Ticket # " + ticket.Id;
            ViewTicket_lblSubject.Text = ticket.Subject;
            ViewTicket_lblDescription.Text = ticket.Description;

            ViewTicket_lblName.Text = ticket.Client.Name;
            ViewTicket_lblMail.Text = ticket.Client.Email;

            ViewTicket_lblCategory.Text = ticket.Category.ToString();
            ViewTicket_lblPriority.Text = ticket.Priority.ToString();
            ViewTicket_lblDeadline.Text = ticket.DaysToSolve.ToString();
            ViewTicket_lblDate.Text = ticket.DateOfIssueing.ToString("dd-MM-yyyy");

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
        }

        private void ViewTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
