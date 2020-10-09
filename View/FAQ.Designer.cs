namespace View
{
    partial class FAQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView_FAQ = new System.Windows.Forms.TreeView();
            this.lbl_FAQ = new System.Windows.Forms.Label();
            this.FAQ_comboCategory = new System.Windows.Forms.ComboBox();
            this.lbl_CategoryFAQ = new System.Windows.Forms.Label();
            this.cmb_Questions = new System.Windows.Forms.ComboBox();
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            this.txt_QuestionAdd = new System.Windows.Forms.TextBox();
            this.txt_AnswerAdd = new System.Windows.Forms.TextBox();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView_FAQ
            // 
            this.treeView_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_FAQ.Location = new System.Drawing.Point(94, 151);
            this.treeView_FAQ.Name = "treeView_FAQ";
            this.treeView_FAQ.Size = new System.Drawing.Size(344, 261);
            this.treeView_FAQ.TabIndex = 0;
            // 
            // lbl_FAQ
            // 
            this.lbl_FAQ.AutoSize = true;
            this.lbl_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FAQ.Location = new System.Drawing.Point(88, 23);
            this.lbl_FAQ.Name = "lbl_FAQ";
            this.lbl_FAQ.Size = new System.Drawing.Size(73, 32);
            this.lbl_FAQ.TabIndex = 1;
            this.lbl_FAQ.Text = "FAQ";
            // 
            // FAQ_comboCategory
            // 
            this.FAQ_comboCategory.FormattingEnabled = true;
            this.FAQ_comboCategory.Location = new System.Drawing.Point(94, 107);
            this.FAQ_comboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.FAQ_comboCategory.Name = "FAQ_comboCategory";
            this.FAQ_comboCategory.Size = new System.Drawing.Size(221, 24);
            this.FAQ_comboCategory.TabIndex = 11;
            this.FAQ_comboCategory.SelectedIndexChanged += new System.EventHandler(this.FAQ_comboCategory_SelectedIndexChanged);
            // 
            // lbl_CategoryFAQ
            // 
            this.lbl_CategoryFAQ.AutoSize = true;
            this.lbl_CategoryFAQ.Location = new System.Drawing.Point(91, 75);
            this.lbl_CategoryFAQ.Name = "lbl_CategoryFAQ";
            this.lbl_CategoryFAQ.Size = new System.Drawing.Size(69, 17);
            this.lbl_CategoryFAQ.TabIndex = 12;
            this.lbl_CategoryFAQ.Text = "Category:";
            // 
            // cmb_Questions
            // 
            this.cmb_Questions.FormattingEnabled = true;
            this.cmb_Questions.Location = new System.Drawing.Point(531, 107);
            this.cmb_Questions.Name = "cmb_Questions";
            this.cmb_Questions.Size = new System.Drawing.Size(249, 24);
            this.cmb_Questions.TabIndex = 13;
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(562, 151);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(199, 51);
            this.btn_DeleteQuestion.TabIndex = 14;
            this.btn_DeleteQuestion.Text = "Delete Question";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // txt_QuestionAdd
            // 
            this.txt_QuestionAdd.Location = new System.Drawing.Point(531, 232);
            this.txt_QuestionAdd.Name = "txt_QuestionAdd";
            this.txt_QuestionAdd.Size = new System.Drawing.Size(248, 22);
            this.txt_QuestionAdd.TabIndex = 15;
            // 
            // txt_AnswerAdd
            // 
            this.txt_AnswerAdd.Location = new System.Drawing.Point(531, 272);
            this.txt_AnswerAdd.Multiline = true;
            this.txt_AnswerAdd.Name = "txt_AnswerAdd";
            this.txt_AnswerAdd.Size = new System.Drawing.Size(248, 79);
            this.txt_AnswerAdd.TabIndex = 16;
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.Location = new System.Drawing.Point(562, 361);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(199, 51);
            this.btn_AddQuestion.TabIndex = 17;
            this.btn_AddQuestion.Text = "Add Question";
            this.btn_AddQuestion.UseVisualStyleBackColor = true;
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.btn_AddQuestion);
            this.Controls.Add(this.txt_AnswerAdd);
            this.Controls.Add(this.txt_QuestionAdd);
            this.Controls.Add(this.btn_DeleteQuestion);
            this.Controls.Add(this.cmb_Questions);
            this.Controls.Add(this.lbl_CategoryFAQ);
            this.Controls.Add(this.FAQ_comboCategory);
            this.Controls.Add(this.lbl_FAQ);
            this.Controls.Add(this.treeView_FAQ);
            this.Name = "FAQ";
            this.Text = "FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_FAQ;
        private System.Windows.Forms.Label lbl_FAQ;
        private System.Windows.Forms.ComboBox FAQ_comboCategory;
        private System.Windows.Forms.Label lbl_CategoryFAQ;
        private System.Windows.Forms.ComboBox cmb_Questions;
        private System.Windows.Forms.Button btn_DeleteQuestion;
        private System.Windows.Forms.TextBox txt_QuestionAdd;
        private System.Windows.Forms.TextBox txt_AnswerAdd;
        private System.Windows.Forms.Button btn_AddQuestion;
    }
}