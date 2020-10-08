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

namespace View
{
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();

            CategoryCombobox();

        }

        private void CategoryCombobox()
        {
            FAQ_comboCategory.Items.Clear();

            FAQ_comboCategory.Items.Add(Category.Printers);
            FAQ_comboCategory.Items.Add(Category.Computers);
            FAQ_comboCategory.Items.Add(Category.Mail);
            FAQ_comboCategory.Items.Add(Category.General);
            FAQ_comboCategory.Items.Add(Category.Other);

            FAQ_comboCategory.SelectedIndex = 3;
        }

        private void FAQ_comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            treeView_FAQ.Nodes.Clear();

            if ((Category)FAQ_comboCategory.SelectedItem == Category.General)
            {
                TreeNode generalQuestion1 = new TreeNode("General Question 1");
                TreeNode answer1 = new TreeNode("Answer");
                treeView_FAQ.Nodes.Add(generalQuestion1);
                generalQuestion1.Nodes.Add(answer1);
            }
            else if ((Category)FAQ_comboCategory.SelectedItem == Category.Printers)
            {
                TreeNode printerQuestion1 = new TreeNode("Printer Question 1");
                TreeNode answer1 = new TreeNode("Answer");
                treeView_FAQ.Nodes.Add(printerQuestion1);
                printerQuestion1.Nodes.Add(answer1);
            }
            else if ((Category)FAQ_comboCategory.SelectedItem == Category.Computers)
            {
                TreeNode computerQuestion1 = new TreeNode("Computer Question 1");
                TreeNode answer1 = new TreeNode("Answer");
                treeView_FAQ.Nodes.Add(computerQuestion1);
                computerQuestion1.Nodes.Add(answer1);
            }
            else if ((Category)FAQ_comboCategory.SelectedItem == Category.Mail)
            {
                TreeNode mailQuestion1 = new TreeNode("Mail Question 1");
                TreeNode answer1 = new TreeNode("Answer");
                treeView_FAQ.Nodes.Add(mailQuestion1);
                mailQuestion1.Nodes.Add(answer1);
            }
            else if ((Category)FAQ_comboCategory.SelectedItem == Category.Other)
            {
                TreeNode otherQuestion1 = new TreeNode("Other Question 1");
                TreeNode answer1 = new TreeNode("Answer");
                treeView_FAQ.Nodes.Add(otherQuestion1);
                otherQuestion1.Nodes.Add(answer1);
            }
        }
    }
}
