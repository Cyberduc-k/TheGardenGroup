using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace View
{
    public partial class Edit_Ticket : Form
    {
        private IServiceProvider provider;
        private Ticket ticket;

        public Edit_Ticket(Ticket ticket, IServiceProvider provider)
        {
            if (ticket.Id == null)
            {
                ErrorHandler.Instance.HandleError("The ID cant be null", "Cant be null", new ArgumentNullException());
                return;
            }

            this.provider = provider;
            this.ticket = ticket;

            InitializeComponent();

            if (LoggedInUser.Instance.User is Customer && ticket.Solved)
            {
                pnl_EditTicketEmployee.Top = 92;
                lbl_Review.Show();
                lbl_Score.Show();
                input_ReviewScore.Show();
                input_Review.Show();
                input_ReviewScore.Value = ticket.ReviewScore == 0 ? 5 : ticket.ReviewScore;
                input_Review.Text = ticket.Review;
            }

            EditTicket_lblTicketID.Text = "Ticket: " + this.ticket.Id;
            EditTicket_lblTicketSubject.Text = this.ticket.Subject;
            EditTicket_lblTicketCategory.Text = this.ticket.Category.ToString();
            EditTicket_lblTicketPriority.Text = this.ticket.Priority.ToString();
            EditTicket_lblTicketDeadline.Text = this.ticket.DaysToSolve.ToString() + " days";
            EditTicket_lblTicketDescription.Text = this.ticket.Description;
            EditTicket_lblName.Text = this.ticket.Client.Alias;
            EditTicket_lblMail.Text = this.ticket.Client.Email;

            FillCategoryCombobox();
        }

        private void FillCategoryCombobox()
        {
            EditTicket_cmbCategory.Items.Clear();

            //Loop through all Categories
            foreach(Category category in Enum.GetValues(typeof(Category))) {
                EditTicket_cmbCategory.Items.Add(category);
            }
        }

        private void EditTicket_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ITicketService ticketService = provider.GetService<ITicketService>();

                if (EditTicket_txtSubject.Text != "")
                {
                    ticket.Subject = EditTicket_txtSubject.Text;
                }

                if (EditTicket_cmbCategory.SelectedItem != null)
                {
                    ticket.Category = (Category)EditTicket_cmbCategory.SelectedItem;
                }

                if (EditTicket_rBtnHighPriority.Checked || EditTicket_rBtnMediumPriority.Checked ||
                    EditTicket_rBtnLowPriority.Checked)
                {
                    Enum.TryParse(ActiveForm.Controls.OfType<RadioButton>()
                                             .FirstOrDefault(r => r.Checked).Tag.ToString(), out Priority priority);
                    ticket.Priority = priority;
                }

                if (EditTicket_txtDeadline.Text != "")
                {
                    ticket.DaysToSolve = int.Parse(EditTicket_txtDeadline.Text);
                }

                if (EditTicket_txtAreaDescription.Text != "")
                {
                    ticket.Description = EditTicket_txtAreaDescription.Text;
                }

                if (input_Review.Text.Length > 0)
                {
                    ticket.Review = input_Review.Text;
                }

                byte oldReviewScore = ticket.ReviewScore;

                ticket.ReviewScore = (byte)input_ReviewScore.Value;

                ticketService.Update(ticket);

                if (ticket.HandlerId != null && oldReviewScore != ticket.ReviewScore)
                {
                    UpdateReviewSCore(ticketService);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while editing your ticket, try again please.", "Try again", ex);

            }
            finally
            {
                EditTicket_txtAreaDescription.Clear();
                EditTicket_txtDeadline.Clear();
                EditTicket_txtSubject.Clear();

                Close();
            }
        }

        private void UpdateReviewSCore(ITicketService ticketService)
        {
            IUserService userService = provider.GetService<IUserService>();
            Employee handler = (Employee)userService.GetSingle(ticket.HandlerId);
            IEnumerable<Ticket> tickets = ticketService.GetAllBy(tckt => tckt.HandlerId == ticket.HandlerId);
            int totalScore = tickets.Sum(tckt => tckt.ReviewScore);

            totalScore /= tickets.Count();

            handler.ReviewScore = (byte)totalScore;
            userService.Update(handler);
        }

        private void EditTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
