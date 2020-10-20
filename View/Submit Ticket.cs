using Model;
using System;
using System.Linq;
using System.Windows.Forms;
using Service;

namespace View
{
    public partial class Submit_Ticket : Form
    {
        private IServiceProvider provider;

        private bool subjectError = true;
        private bool deadlineError = true;
        private bool descriptionError = true;

        public Submit_Ticket(IServiceProvider provider)
        {
            this.provider = provider;

            InitializeComponent();

            SubmitTicket_comboCategory.SelectedIndex = 0;
        }

        private void SubmitTicket_btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = SubmitTicket_txtSubject.Text;

                Enum.TryParse(SubmitTicket_comboCategory.SelectedItem.ToString(), out Category category);

                Priority priority;
                if (SubmitTicket_rBtnLowPriority.Checked)
                    priority = Priority.Low;
                else if (SubmitTicket_rBtnMediumPriority.Checked)
                    priority = Priority.Medium;
                else
                    priority = Priority.High;
                    
                int deadline = int.Parse(SubmitTicket_txtDeadline.Text);
                string description = SubmitTicket_txtAreaDescription.Text;

                Ticket ticket = new Ticket(subject, category, priority, deadline, description, LoggedInUser.Instance.User, DateTime.Now);
                ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

                ticketService.Add(ticket);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while adding your ticket, try again please.", "Try again", ex);
            }

            Close();
        }

        private void SubmitTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitTicket_txtSubject_TextChanged(object sender, EventArgs e)
        {
            if (SubmitTicket_txtSubject.Text == "")
            {
                subjectError = true;
                SubmitTicket_lblSubject.Show();
            }
            else
            {
                subjectError = false;
                SubmitTicket_lblSubject.Hide();
            }

            SubmitTicket_btnSubmit.Enabled = !(subjectError || deadlineError || descriptionError);
        }

        private void SubmitTicket_txtDeadline_TextChanged(object sender, EventArgs e)
        {
            if (SubmitTicket_txtDeadline.Text == "" || !int.TryParse(SubmitTicket_txtDeadline.Text, out _))
            {
                deadlineError = true;
                SubmitTicket_lblDeadline.Show();
            }
            else
            {
                deadlineError = false;
                SubmitTicket_lblDeadline.Hide();
            }

            SubmitTicket_btnSubmit.Enabled = !(subjectError || deadlineError || descriptionError);
        }

        private void SubmitTicket_txtAreaDescription_TextChanged(object sender, EventArgs e)
        {
            if (SubmitTicket_txtAreaDescription.Text == "")
            {
                descriptionError = true;
                SubmitTicket_lblDescription.Show();
            }
            else
            {
                descriptionError = false;
                SubmitTicket_lblDescription.Hide();
            }

            SubmitTicket_btnSubmit.Enabled = !(subjectError || deadlineError || descriptionError);
        }
    }
}