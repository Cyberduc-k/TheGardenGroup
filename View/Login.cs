using Service;
using Model;
using System;
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

                if (user is Customer)
                {
                    Tickets_Dashboard dashboard = new Tickets_Dashboard(provider);

                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Location = Location;
                    dashboard.Show();
                    dashboard.FormClosed += (_1, _2) => Show();
                    Hide();
                }
                else
                {
                    Statistics_Dashboard dashboard = new Statistics_Dashboard(provider);

                    dashboard.StartPosition = FormStartPosition.Manual;
                    dashboard.Location = Location;
                    dashboard.Show();
                    dashboard.FormClosed += (_1, _2) => Show();
                    Hide();
                }
            }
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

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (input_Email.Text.Length > 0 && input_Password.Text.Length > 0)
                btn_Login.Enabled = true;
            else
                btn_Login.Enabled = false;
        }
    }
}