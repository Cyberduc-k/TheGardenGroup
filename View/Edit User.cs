using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Model;

namespace View
{
    public partial class Edit_User : Form
    {
        IServiceProvider provider;
        User user = LoggedInUser.Instance.User;

        public Edit_User(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;

            if (user is Employee)
            {
                lbl_Company.Hide();
                input_Company.Hide();
                lbl_Occupation.Hide();
                input_Occupation.Hide();
                lbl_Expertise.Show();
                input_Expertise.Show();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            IUserService service = provider.GetService<IUserService>();
            user.FirstName = input_FirstName.Text;
            user.LastName = input_LastName.Text;
            user.Email = input_Email.Text;
            user.BirthDate = input_BirthDate.Value;
            user.Alias = input_DisplayName.Text;

            if (user is Employee)
            {
                Employee employee = (Employee)user;

                employee.Expertise = (Category)input_Expertise.SelectedIndex;
            }
            else
            {
                Customer customer = (Customer)user;

                customer.Company = input_Company.Text;
                customer.Occupation = input_Occupation.Text;
            }

            service.Update(user);
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (input_FirstName.Text.Length == 0 || input_LastName.Text.Length == 0 || input_Email.Text.Length == 0 || input_DisplayName.Text.Length == 0)
            {
                if (user is Customer)
                {
                    if (input_Company.Text.Length == 0 || input_Occupation.Text.Length == 0)
                    {
                        btn_Save.Enabled = false;
                        return;
                    }
                }
                else
                {
                    btn_Save.Enabled = false;
                    return;
                }
            }

            btn_Save.Enabled = true;
        }
    }
}
