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
    }
}
