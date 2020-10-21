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
using Service;
using Model;

namespace View
{
    public partial class Review_Ticket : Form
    {
        private IServiceProvider provider;
        private Ticket ticket;

        public Review_Ticket(Ticket ticket, IServiceProvider provider)
        {
            if (ticket.Id == null)
            {
                ErrorHandler.Instance.HandleError("The ID cant be null", "Cant be null", new ArgumentNullException());
                return;
            }

            InitializeComponent();
            this.provider = provider;
            this.ticket = ticket;

            try
            {
                User handler = provider.GetService<IUserService>().GetSingle(ticket.HandlerId);

                lbl_TicketId.Text = "Ticket: " + this.ticket.Id;
                lbl_Name.Text = handler.Alias;
                lbl_Email.Text = handler.Email;
                txtBox_Solution.Text = ticket.Solution;
                input_ReviewScore.Value = ticket.ReviewScore;
                input_Review.Text = ticket.Review;
            } catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("This ticket has no handler.", "Try again", ex);
                Close();
            }
        }

        private void EditTicket_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditTicket_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ITicketService ticketService = provider.GetService<ITicketService>();

                ticket.Review = input_Review.Text;
                ticket.ReviewScore = (byte)input_ReviewScore.Value;

                ticketService.Update(ticket);

                UpdateReviewSCore(ticketService);
            } catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while reviewing your ticket, try again please.", "Try again", ex);
            }
        }

        // update the ticket Handler's review score by taking the average of all his handled tickets.
        private void UpdateReviewSCore(ITicketService ticketService)
        {
            IUserService userService = provider.GetService<IUserService>();
            Employee handler = (Employee)userService.GetSingle(ticket.HandlerId);
            IEnumerable<Ticket> tickets = ticketService.GetAllBy(tckt => tckt.HandlerId == ticket.HandlerId && tckt.ReviewScore != 0);
            int totalScore = tickets.Sum(tckt => tckt.ReviewScore);

            totalScore /= tickets.Count();

            handler.ReviewScore = (byte)totalScore;
            userService.Update(handler);
        }
    }
}
