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
    public partial class NewAccount : Form
    {
        private IServiceProvider provider;
        private bool newEmployee;

        public NewAccount(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount1.Hide();
            pnl_MakeAccount2.Show();
            newEmployee = false;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount1.Hide();
            pnl_MakeAccount2.Show();
            newEmployee = true;
        }

        private void btn_Back1_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount2.Hide();
            pnl_MakeAccount1.Show();
        }

        private void btn_Next1_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount2.Hide();

            if (newEmployee)
                pnl_MakeAccount5.Show();
            else
                pnl_MakeAccount3.Show();
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount3.Hide();
            pnl_MakeAccount2.Show();
        }

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount3.Hide();
            pnl_MakeAccount4.Show();
        }

        private void btn_Back3_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount4.Hide();
            pnl_MakeAccount3.Show();
        }

        private void btn_Back4_Click(object sender, EventArgs e)
        {
            pnl_MakeAccount5.Hide();
            pnl_MakeAccount3.Show();
        }

        // Create new Customer
        private void btn_MakeAccount1_Click(object sender, EventArgs e)
        {
            string firstName = input_FirstName.Text;
            string lastName = input_LastName.Text;
            string company = input_Company.Text;
            string occupation = input_Occupation.Text;
            DateTime birthDate = input_BirthDate.Value;
            string email = input_Email1.Text;
            string password = input_Password1.Text;

            Customer customer = new Customer(firstName, lastName, birthDate, email, password, company, occupation);
            IUserService service = provider.GetService<IUserService>();

            customer.Alias = customer.Name;
            service.Add(customer);
            Close();
        }

        // Create new Employee
        private void btn_MakeAccount2_Click(object sender, EventArgs e)
        {
            string firstName = input_FirstName.Text;
            string lastName = input_LastName.Text;
            Category category = (Category)input_Category.SelectedIndex;
            DateTime birthDate = input_BirthDate.Value;
            string email = input_Email2.Text;
            string password = input_Password2.Text;

            Employee employee = new Employee(firstName, lastName, birthDate, email, password, category);
            IUserService service = provider.GetService<IUserService>();

            employee.Alias = employee.Name;
            service.Add(employee);
            Close();
        }

        // check if the two password fields are equal and non-empty
        private void input_Password1_TextChanged(object sender, EventArgs e)
        {
            if (input_Password1.Text.Length > 0 && input_Password1.Text == input_PasswordRepeat1.Text)
            {
                btn_MakeAccount1.Enabled = true;
            }
            else
            {
                btn_MakeAccount1.Enabled = false;
            }
        }

        // check if the two password fields are equal and non-empty
        private void input_Password2_TextChanged(object sender, EventArgs e)
        {
            if (input_Password2.Text.Length > 0 && input_Password2.Text == input_PasswordRepeat2.Text)
            {
                btn_MakeAccount2.Enabled = true;
            } else
            {
                btn_MakeAccount2.Enabled = false;
            }
        }
    }
}
