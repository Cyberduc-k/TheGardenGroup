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

        public User_Dashboard(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
            FillCustomers();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
