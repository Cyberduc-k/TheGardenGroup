using Model;
using System;
using System.Linq;
using System.Windows.Forms;
using Service;
using System.Collections.Generic;

namespace View
{
    public partial class Submit_Ticket : Form
    {
        private IServiceProvider provider;

        //Bools to track if all inputs are correct
        private bool subjectError = true;
        private bool deadlineError = true;
        private bool descriptionError = true;

        public Submit_Ticket(IServiceProvider provider)
        {
            this.provider = provider;

            InitializeComponent();
            ActivityMeasurement();

            //Loop through all Categories
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                SubmitTicket_comboCategory.Items.Add(category);
            }

            //Select the last Category available, should be "Other"
            SubmitTicket_comboCategory.SelectedIndex = Enum.GetValues(typeof(Category)).Length - 1;
        }

        public void ActivityMeasurement()
        {
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;
            IEnumerable<Ticket> tickets = ticketService.GetAll();

            //Calculate the amount of tickets that need immediate attention, get the amount of active tickets and add up all the DaysToSolve of the active tickets
            int AmountOfImmediateAttentionTickets = 0;
            int AmountOfActiveTickets = 0;
            int DaysToSolveTotal = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Solved != true)
                {
                    AmountOfActiveTickets++;
                    DaysToSolveTotal += ticket.DaysToSolve;

                    if ((DateTime.Now - ticket.DateOfIssueing).TotalDays > ticket.DaysToSolve)
                    {
                        AmountOfImmediateAttentionTickets++;
                    }
                }
            }

            //This will make a score based on how much active tickets and immediate attention tickets there are
            //It will also take into account what the average DaysToSolve of all the active tickets is and will add some score if this is low
            //But this will only be in effect if the amount of tickets is greater or equal to 5
            // | active ticket = 1 | immediate attention ticket = 2 | Average DaysToSolve <= 4 = 2, Average DaysToSolve <= 3 = 4, Average DaysToSolve <= 2 = 8 |
            int TotalActivityScore = AmountOfActiveTickets + AmountOfImmediateAttentionTickets;

            if (AmountOfActiveTickets >= 5)
            {
                if (DaysToSolveTotal / AmountOfActiveTickets <= 4)
                    TotalActivityScore += 2;
                else if (DaysToSolveTotal / AmountOfActiveTickets <= 3)
                    TotalActivityScore += 4;
                else if (DaysToSolveTotal / AmountOfActiveTickets <= 2)
                    TotalActivityScore += 8;
            }
            
            //Edit the activity label based on the score
            if (TotalActivityScore <= 8)
            {
                lbl_Activity.Text = "Low";
                lbl_Warning.Hide();
            }
            else if (TotalActivityScore >= 30)
            {
                lbl_Activity.Text = "High";
            }
            else
            {
                lbl_Activity.Text = "Medium";
                lbl_Warning.Hide();
            }
            
        }

        #region OnClicks
        //Submit new ticket
        private void SubmitTicket_btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert all inputs to data
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
                IUserService userService = provider.GetService(typeof(IUserService)) as IUserService;

                //Store that the user submitted a new ticket
                Customer user = (Customer)LoggedInUser.Instance.User;
                user.Tickets++;
                userService.Update(user);

                //Submit the new ticket
                ticketService.Add(ticket);
               
                MessageBox.Show("Your ticket has successfully been added", "Ticket added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while adding your ticket, try to create a new ticket please.", "Try again", ex);
            }

            Close();
        }

        private void SubmitTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region InputValidation
        //Make sure a subject is given
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

        //Make sure the deadline is valid
        private void SubmitTicket_txtDeadline_TextChanged(object sender, EventArgs e)
        {
            int deadline;
            if (SubmitTicket_txtDeadline.Text == "" || !int.TryParse(SubmitTicket_txtDeadline.Text, out deadline) 
                                                    || deadline < 1 || deadline > 7)
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

        //Make sure a description is given
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
        #endregion
    }
}