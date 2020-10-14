﻿using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            EditTicket_lblTicketID.Text = "Ticket: " + this.ticket.Id;
            EditTicket_lblTicketSubject.Text = this.ticket.Subject;
            EditTicket_lblTicketCategory.Text = this.ticket.Category.ToString();
            EditTicket_lblTicketPriority.Text = this.ticket.Priority.ToString();
            EditTicket_lblTicketDeadline.Text = this.ticket.DaysToSolve.ToString() + " days";
            EditTicket_lblTicketDescription.Text = this.ticket.Description;
        }

        private void EditTicket_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

                if (EditTicket_txtSubject != null)
                {
                    this.ticket.Subject = EditTicket_txtSubject.Text;
                }

                if (EditTicket_cmbCategory.SelectedItem != null)
                {
                    this.ticket.Category = (Category)EditTicket_cmbCategory.SelectedItem;
                }

                if (EditTicket_rBtnHighPriority.Checked || EditTicket_rBtnMediumPriority.Checked ||
                    EditTicket_rBtnLowPriority.Checked)
                {
                    Enum.TryParse(ActiveForm.Controls.OfType<RadioButton>()
                                             .FirstOrDefault(r => r.Checked).Tag.ToString(), out Priority priority);
                    this.ticket.Priority = priority;
                }

                if (EditTicket_txtDeadline != null)
                {
                    this.ticket.DaysToSolve = int.Parse(EditTicket_txtDeadline.Text);
                }

                if (EditTicket_txtAreaDescription != null)
                {
                    this.ticket.Description = EditTicket_txtAreaDescription.Text;
                }

                ticketService.Update(this.ticket);
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

                this.Close();
            }
        }

        private void EditTicket_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}