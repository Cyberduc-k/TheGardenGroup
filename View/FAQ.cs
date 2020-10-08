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

            FAQ_comboCategory.Items.Clear();

            FAQ_comboCategory.Items.Add(Category.General);
            FAQ_comboCategory.Items.Add(Category.Printers);
            FAQ_comboCategory.Items.Add(Category.Computers);
            FAQ_comboCategory.Items.Add(Category.Mail);         
            FAQ_comboCategory.Items.Add(Category.Other);

            FAQ_comboCategory.SelectedIndex = 0;

            treeView_FAQ.Nodes.Clear();

            TreeNode question1 = new TreeNode("Question 1");
            TreeNode answer1 = new TreeNode("Answer 1");
            treeView_FAQ.Nodes.Add(question1);
            question1.Nodes.Add(answer1);
        }
    }
}
