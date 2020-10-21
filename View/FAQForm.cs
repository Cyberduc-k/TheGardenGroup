using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public partial class FAQForm : Form
    {
        private IServiceProvider provider;
        private IFAQService faqService;
        private FAQ selectedFAQ;
        private User user;

        public FAQForm(IServiceProvider provider)
        {
            this.provider = provider;
            InitializeComponent();
            user = LoggedInUser.Instance.User;           

            UserDisplay();
            FillCategoryCombobox();
            FillTreeView((Category)FAQ_comboCategory.SelectedItem);
            FillQuestionsCombobox((Category)FAQ_comboCategory.SelectedItem);
        }

        // Diffrent displays for diffrent usertypes
        private void UserDisplay()
        {
            if(user is Customer)
            {
                pnl_EditFAQ.Hide();
                treeView_FAQ.Left= 450;

                lbl_Statistics.Hide();
                lbl_Users.Hide();
                lbl_Tickets.Left = 95;
                current_stripe.Left = 180;
                lbl_FAqMenu.Left = 180;
            }
        }

        private void FillCategoryCombobox()
        {
            FAQ_comboCategory.Items.Clear();

            //Loop through all Categories
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                FAQ_comboCategory.Items.Add(category);
            }

            FAQ_comboCategory.SelectedIndex = 3;
        }

        private void FillQuestionsCombobox(Category category)
        {
            cmb_Questions.Items.Clear();

            List<FAQ> faqs = GetFAQs();

            foreach(FAQ f in faqs)
            {
                if (f.Category == category)
                {
                    cmb_Questions.Items.Add(f.Question);
                    selectedFAQ = f;
                }
            }
        }

        private void FAQ_comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillQuestionsCombobox((Category)FAQ_comboCategory.SelectedItem);
            FillTreeView((Category)FAQ_comboCategory.SelectedItem);
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string question = txt_QuestionAdd.Text;
                string answer = txt_AnswerAdd.Text;
                Category category = (Category)FAQ_comboCategory.SelectedItem;

                // Making sure both question and solution are filled in
                if (question != "" && answer != "")
                {
                    FAQ newQuestion = new FAQ(question, answer, category);
                    faqService = provider.GetService<IFAQService>();

                    faqService.Add(newQuestion);
                }
                else
                {
                    ErrorHandler.Instance.HandleError("Question and/or answer cannot be empty", "Can't be null", new ArgumentNullException());
                }
                
            }
            catch(Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while adding your question, try again please.", "Try again", ex);
            }
            finally
            {
                //Clearing textforms and filling treeview again so it is up to date
                txt_AnswerAdd.Clear();
                txt_QuestionAdd.Clear();
                FillTreeView((Category)FAQ_comboCategory.SelectedItem);
            }

        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            faqService.Delete(selectedFAQ);
            FillQuestionsCombobox((Category)FAQ_comboCategory.SelectedItem);
            FillTreeView((Category)FAQ_comboCategory.SelectedItem);
        }

        private void FillTreeView(Category category)
        {
            treeView_FAQ.Nodes.Clear();

            List<FAQ> faqs = GetFAQs();

            foreach (FAQ f in faqs)
            {
                if (f.Category == category)
                {
                    TreeNode question = new TreeNode(f.Question);
                    TreeNode answer = new TreeNode(f.Answer);
                    treeView_FAQ.Nodes.Add(question);
                    question.Nodes.Add(answer);
                }
            }
        }

        private List<FAQ> GetFAQs()
        {
            faqService = provider.GetService<IFAQService>();
            List<FAQ> faqs = (List<FAQ>)faqService.GetAll();

            return faqs;
        }

        private void lbl_Users_Click(object sender, EventArgs e)
        {
            User_Dashboard users = Application.OpenForms.OfType<User_Dashboard>().FirstOrDefault();

            if (users == null)
            {
                users = new User_Dashboard(provider);
            }
            
            users.StartPosition = FormStartPosition.Manual;
            users.Location = Location;
            users.Show();
            users.Activate();
            Hide();
        }

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {
            Tickets_Dashboard tickets = Application.OpenForms.OfType<Tickets_Dashboard>().FirstOrDefault();

            if (tickets == null)
            {
                tickets = new Tickets_Dashboard(provider);
            }
            
            tickets.StartPosition = FormStartPosition.Manual;
            tickets.Location = Location;
            tickets.Show();
            tickets.Activate();
            Hide();
        }

        private void lbl_Statistics_Click(object sender, EventArgs e)
        {
            Statistics_Dashboard stats = Application.OpenForms.OfType<Statistics_Dashboard>().FirstOrDefault();

            if (stats == null)
            {
                stats = new Statistics_Dashboard(provider);
            }
            
            stats.StartPosition = FormStartPosition.Manual;
            stats.Location = Location;
            stats.Show();
            stats.Activate();
            Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (login == null)
            {
                login = new Login(provider);
            }

            login.StartPosition = FormStartPosition.Manual;
            login.Location = Location;
            login.RestoreLogin();
            login.Activate();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Edit_User editUser = new Edit_User(provider, LoggedInUser.Instance.User);

            Hide();
            editUser.StartPosition = FormStartPosition.Manual;
            editUser.Location = Location;
            editUser.ShowDialog();
            Show();
        }
    }
}
