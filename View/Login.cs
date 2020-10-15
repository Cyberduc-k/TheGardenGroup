using Service;
using Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
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

            if (user == null)
            {
                input_Email.Clear();
                input_Password.Clear();
                lbl_WrongCredentials.Show();
            } else
            {
                LoggedInUser.Instance.User = user;
                Tickets_Dashboard dashboard = new Tickets_Dashboard(provider);

                lbl_WrongCredentials.Hide();
                input_Email.Clear();
                input_Password.Clear();
                Hide();
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Location = Location;
                dashboard.ShowDialog();
                Show();
            }
        }

        private void btn_New_Clicked(object caller, EventArgs e)
        {
            NewAccount na = new NewAccount(provider);

            na.StartPosition = FormStartPosition.Manual;
            na.Location = this.Location;
            this.Hide();
            na.ShowDialog();
            this.Show();
        }
    }
}