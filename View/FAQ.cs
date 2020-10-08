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

            treeView_FAQ.CollapseAll();

            TreeNode question2 = new TreeNode("Question 2");
            TreeNode answer2 = new TreeNode("Answer 2");
            treeView_FAQ.Nodes.Add(question2);
            question2.Nodes.Add(answer2);
        }
    }
}
