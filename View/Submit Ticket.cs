using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace View
{
    public partial class Submit_Ticket : Form
    {
        private IServiceProvider provider;

        public Submit_Ticket(IServiceProvider provider)
        {
            this.provider = provider;

            InitializeComponent();
        }

        private void SubmitTicket_btnSubmit_Click(object sender, EventArgs e)
        {
            string subject = SubmitTicket_txtSubject.Text;

            Enum.TryParse(SubmitTicket_comboCategory.SelectedItem.ToString(), out Category category);
            Enum.TryParse(ActiveForm.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Tag.ToString(), out Priority priority);

            int deadline = int.Parse(SubmitTicket_txtDeadline.Text);
            string description = SubmitTicket_txtAreaDescription.Text;

            Ticket ticket = new Ticket(subject, category, priority, deadline, description, null, DateTime.Now);
            ITicketService ticketService = provider.GetService(typeof(ITicketService)) as ITicketService;

            ticketService.Add(ticket);

            //Just for testing
            Console.WriteLine("Ticket added: " + subject);

        }

        private void SubmitTicket_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}