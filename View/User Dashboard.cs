using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public partial class User_Dashboard : Form
    {
        IServiceProvider provider;
        User selectedUser;

        public User_Dashboard(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
            filter.SelectedIndex = 0;
            FillCustomers();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void FillUsers()
        {
            if (filter.SelectedIndex == 0)
                FillCustomers();
            else
                FillEmployees();
        }

        private void FillCustomers()
        {
            lv_Users.Clear();
            lv_Users.Columns.AddRange(new ColumnHeader[] {
                ch_FirstName,
                ch_LastName,
                ch_Email,
                ch_BirthDate,
                ch_Company,
                ch_Occupation,
                ch_Tickets
            });

            IUserService service = provider.GetService<IUserService>();
            IEnumerable<Customer> customers = service.GetAllCustomers();

            foreach (Customer customer in customers)
            {
                ListViewItem li = new ListViewItem(customer.FirstName);

                li.SubItems.Add(customer.LastName);
                li.SubItems.Add(customer.Email);
                li.SubItems.Add(customer.BirthDate.ToShortDateString());
                li.SubItems.Add(customer.Company);
                li.SubItems.Add(customer.Occupation);
                li.SubItems.Add(customer.Tickets.ToString());
                li.Tag = customer;

                lv_Users.Items.Add(li);
            }
        }

        private void FillEmployees()
        {
            lv_Users.Clear();
            lv_Users.Columns.AddRange(new ColumnHeader[] {
                ch_FirstName,
                ch_LastName,
                ch_Email,
                ch_BirthDate,
                ch_ReviewScore,
                ch_Tickets,
                ch_TicketsHelped,
                ch_TicketsNotHelped
            });

            IUserService service = provider.GetService<IUserService>();
            IEnumerable<Employee> employees = service.GetAllEmployees();

            foreach (Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.FirstName);

                li.SubItems.Add(employee.LastName);
                li.SubItems.Add(employee.Email);
                li.SubItems.Add(employee.BirthDate.ToShortDateString());
                li.SubItems.Add(employee.TicketsProcessed.ToString());
                li.SubItems.Add(employee.TicketsSucceeded.ToString());
                li.SubItems.Add(employee.TicketsFailed.ToString());
                li.Tag = employee;

                lv_Users.Items.Add(li);
            }
        }

        private void btn_editTicket_Click(object sender, EventArgs e)
        {
            if (lv_Users.SelectedItems == null)
            {
                MessageBox.Show("Please select a user to edit");
                return;
            }

            Edit_User editUser = new Edit_User(provider, selectedUser);

            Hide();
            editUser.StartPosition = FormStartPosition.Manual;
            editUser.Location = Location;
            editUser.ShowDialog();
            Show();

            FillUsers();
        }

        private void btn_deleteTicket_Click(object sender, EventArgs e)
        {
            IUserService service = provider.GetService<IUserService>();

            service.Delete(selectedUser);
        }

        private void lv_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Users.SelectedItems.Count <= 0)
                return;

            selectedUser = (User)lv_Users.SelectedItems[0].Tag;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (login == null)
            {
                login = new Login(provider);
            }

            login.StartPosition = FormStartPosition.Manual;
            login.Location = Location;
            login.Show();
            login.Activate();
            Close();
        }

        private void lbl_Statistics_Click(object sender, EventArgs e)
        {
            Statistics_Dashboard stats = Application.OpenForms.OfType<Statistics_Dashboard>().FirstOrDefault();

            if (stats == null)
            {
                stats = new Statistics_Dashboard(provider);
                stats.FormClosed += (_1, _2) => Close();
            }

            stats.StartPosition = FormStartPosition.Manual;
            stats.Location = Location;
            stats.Show();
            stats.Activate();
            Hide();
        }

        private void lbl_Ticketrs_Click(object sender, EventArgs e)
        {
            Tickets_Dashboard tickets = Application.OpenForms.OfType<Tickets_Dashboard>().FirstOrDefault();

            if (tickets == null)
            {
                tickets = new Tickets_Dashboard(provider);
                tickets.FormClosed += (_1, _2) => Close();
            }

            tickets.StartPosition = FormStartPosition.Manual;
            tickets.Location = Location;
            tickets.Show();
            tickets.Activate();
            Hide();
        }

        private void lbl_FAqMenu_Click(object sender, EventArgs e)
        {
            FAQForm faq = Application.OpenForms.OfType<FAQForm>().FirstOrDefault();

            if (faq == null)
            {
                faq = new FAQForm(provider);
                faq.FormClosed += (_1, _2) => Close();
            }

            faq.StartPosition = FormStartPosition.Manual;
            faq.Location = Location;
            faq.Show();
            faq.Activate();
            Hide();
        }
    }
}
