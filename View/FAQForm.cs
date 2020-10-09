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

        public FAQForm(IServiceProvider provider)
        {
            this.provider = provider;
            InitializeComponent();

            FillCategoryCombobox();
            FillTreeView((Category)FAQ_comboCategory.SelectedItem);
            FillQuestionsCombobox((Category)FAQ_comboCategory.SelectedItem);
        }

        private void FillCategoryCombobox()
        {
            FAQ_comboCategory.Items.Clear();

            FAQ_comboCategory.Items.Add(Category.Printers);
            FAQ_comboCategory.Items.Add(Category.Computers);
            FAQ_comboCategory.Items.Add(Category.Mail);
            FAQ_comboCategory.Items.Add(Category.General);
            FAQ_comboCategory.Items.Add(Category.Other);

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

                FAQ newQuestion = new FAQ(question, answer, category);
                faqService = provider.GetService<IFAQService>();

                faqService.Add(newQuestion);
            }
            catch(Exception ex)
            {
                ErrorHandler.Instance.HandleError("Something went wrong while adding your question, try again please.", "Try again", ex);
            }
            finally
            {
                txt_AnswerAdd.Clear();
                txt_QuestionAdd.Clear();
            }

        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            faqService.Delete((FAQ)cmb_Questions.SelectedItem);
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
    }
}
