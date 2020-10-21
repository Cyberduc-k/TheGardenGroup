using Service;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public partial class Login : Form
    {
        private IServiceProvider provider;

        public Login(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }

        private void btn_Login_Clicked(object caller, EventArgs e)
        {
            IUserService users = provider.GetService<IUserService>();
            string email = input_Email.Text;
            string password = input_Password.Text;
            User user = users.GetSingleBy(u => u.Email == email && u.Password == password);

            // when the password or email is wrong
            if (user == null)
            {
                input_Email.Clear();
                input_Password.Clear();
                lbl_WrongCredentials.Show();
            } else
            {
                LoggedInUser.Instance.User = user;

                lbl_WrongCredentials.Hide();
                input_Email.Clear();
                input_Password.Clear();

                // show a different form when the user is a customer or employee.
                if (user is Customer)
                {
                    Tickets_Dashboard dashboard = new Tickets_Dashboard(provider);

                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Location = Location;
                    dashboard.Show();
                    dashboard.FormClosed += (_1, _2) => RestoreLogin();
                    Hide();
                }
                else
                {
                    Statistics_Dashboard dashboard = new Statistics_Dashboard(provider);

                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Location = Location;
                    dashboard.Show();
                    dashboard.FormClosed += (_1, _2) => RestoreLogin();
                    Hide();
                }
            }
        }

        // when the user logs out, close all other forms.
        public void RestoreLogin()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
                if (!(form is Login))
                    formsToClose.Add(form);

            foreach (Form form in formsToClose)
                form.Close();

            Show();
        }

        private void btn_New_Clicked(object caller, EventArgs e)
        {
            NewAccount na = new NewAccount(provider);

            na.StartPosition = FormStartPosition.Manual;
            na.Location = this.Location;
            Hide();
            na.ShowDialog();
            Show();
        }

        // make sure all inputs are filled
        private void input_TextChanged(object sender, EventArgs e)
        {
            if (input_Email.Text.Length > 0 && input_Password.Text.Length > 0)
                btn_Login.Enabled = true;
            else
                btn_Login.Enabled = false;
        }
    }
}