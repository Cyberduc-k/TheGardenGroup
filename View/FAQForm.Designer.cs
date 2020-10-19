namespace View
{
    partial class FAQForm
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Tickets = new System.Windows.Forms.Label();
            this.lbl_Statistics = new System.Windows.Forms.Label();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_FAqMenu = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_EditFAQ = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnl_EditFAQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_FAQ
            // 
            this.treeView_FAQ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeView_FAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.treeView_FAQ.Location = new System.Drawing.Point(225, 214);
            this.treeView_FAQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView_FAQ.Name = "treeView_FAQ";
            this.treeView_FAQ.Size = new System.Drawing.Size(448, 355);
            this.treeView_FAQ.TabIndex = 0;
            // 
            // lbl_FAQ
            // 
            this.lbl_FAQ.AutoSize = true;
            this.lbl_FAQ.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_FAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FAQ.Location = new System.Drawing.Point(687, 93);
            this.lbl_FAQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FAQ.Name = "lbl_FAQ";
            this.lbl_FAQ.Size = new System.Drawing.Size(61, 35);
            this.lbl_FAQ.TabIndex = 1;
            this.lbl_FAQ.Text = "FAQ";
            // 
            // FAQ_comboCategory
            // 
            this.FAQ_comboCategory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FAQ_comboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.FAQ_comboCategory.FormattingEnabled = true;
            this.FAQ_comboCategory.Location = new System.Drawing.Point(552, 159);
            this.FAQ_comboCategory.Name = "FAQ_comboCategory";
            this.FAQ_comboCategory.Size = new System.Drawing.Size(308, 27);
            this.FAQ_comboCategory.TabIndex = 11;
            this.FAQ_comboCategory.SelectedIndexChanged += new System.EventHandler(this.FAQ_comboCategory_SelectedIndexChanged);
            // 
            // lbl_CategoryFAQ
            // 
            this.lbl_CategoryFAQ.AutoSize = true;
            this.lbl_CategoryFAQ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_CategoryFAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_CategoryFAQ.Location = new System.Drawing.Point(679, 140);
            this.lbl_CategoryFAQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CategoryFAQ.Name = "lbl_CategoryFAQ";
            this.lbl_CategoryFAQ.Size = new System.Drawing.Size(68, 19);
            this.lbl_CategoryFAQ.TabIndex = 12;
            this.lbl_CategoryFAQ.Text = "Category:";
            // 
            // cmb_Questions
            // 
            this.cmb_Questions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Questions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.cmb_Questions.FormattingEnabled = true;
            this.cmb_Questions.Location = new System.Drawing.Point(82, 35);
            this.cmb_Questions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Questions.Name = "cmb_Questions";
            this.cmb_Questions.Size = new System.Drawing.Size(242, 27);
            this.cmb_Questions.TabIndex = 13;
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_DeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(128, 82);
            this.btn_DeleteQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(149, 41);
            this.btn_DeleteQuestion.TabIndex = 14;
            this.btn_DeleteQuestion.Text = "Delete Question";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = false;
            this.btn_DeleteQuestion.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // txt_QuestionAdd
            // 
            this.txt_QuestionAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_QuestionAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.txt_QuestionAdd.Location = new System.Drawing.Point(82, 188);
            this.txt_QuestionAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QuestionAdd.Name = "txt_QuestionAdd";
            this.txt_QuestionAdd.Size = new System.Drawing.Size(242, 26);
            this.txt_QuestionAdd.TabIndex = 15;
            // 
            // txt_AnswerAdd
            // 
            this.txt_AnswerAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AnswerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.txt_AnswerAdd.Location = new System.Drawing.Point(82, 223);
            this.txt_AnswerAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AnswerAdd.Multiline = true;
            this.txt_AnswerAdd.Name = "txt_AnswerAdd";
            this.txt_AnswerAdd.Size = new System.Drawing.Size(242, 108);
            this.txt_AnswerAdd.TabIndex = 16;
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_AddQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_AddQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_AddQuestion.Location = new System.Drawing.Point(128, 335);
            this.btn_AddQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(149, 41);
            this.btn_AddQuestion.TabIndex = 17;
            this.btn_AddQuestion.Text = "Add Question";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.lbl_Users);
            this.panel_Header.Controls.Add(this.lbl_Tickets);
            this.panel_Header.Controls.Add(this.lbl_Statistics);
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_FAqMenu);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(-1, -1);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1266, 69);
            this.panel_Header.TabIndex = 30;
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Users.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Users.Location = new System.Drawing.Point(280, 17);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(66, 30);
            this.lbl_Users.TabIndex = 5;
            this.lbl_Users.Text = "Users";
            this.lbl_Users.Click += new System.EventHandler(this.lbl_Users_Click);
            // 
            // lbl_Tickets
            // 
            this.lbl_Tickets.AutoSize = true;
            this.lbl_Tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Tickets.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Tickets.Location = new System.Drawing.Point(195, 17);
            this.lbl_Tickets.Name = "lbl_Tickets";
            this.lbl_Tickets.Size = new System.Drawing.Size(79, 30);
            this.lbl_Tickets.TabIndex = 6;
            this.lbl_Tickets.Text = "Tickets";
            this.lbl_Tickets.Click += new System.EventHandler(this.lbl_Tickets_Click);
            // 
            // lbl_Statistics
            // 
            this.lbl_Statistics.AutoSize = true;
            this.lbl_Statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Statistics.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Statistics.Location = new System.Drawing.Point(95, 17);
            this.lbl_Statistics.Name = "lbl_Statistics";
            this.lbl_Statistics.Size = new System.Drawing.Size(94, 30);
            this.lbl_Statistics.TabIndex = 7;
            this.lbl_Statistics.Text = "Statistics";
            this.lbl_Statistics.Click += new System.EventHandler(this.lbl_Statistics_Click);
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(352, 62);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(54, 5);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1169, 20);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(80, 27);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_FAqMenu
            // 
            this.lbl_FAqMenu.AutoSize = true;
            this.lbl_FAqMenu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_FAqMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FAqMenu.Location = new System.Drawing.Point(352, 17);
            this.lbl_FAqMenu.Name = "lbl_FAqMenu";
            this.lbl_FAqMenu.Size = new System.Drawing.Size(54, 30);
            this.lbl_FAqMenu.TabIndex = 2;
            this.lbl_FAqMenu.Text = "FAQ";
            // 
            // logo
            // 
            this.logo.Image = global::View.Properties.Resources.GGLogoTM;
            this.logo.Location = new System.Drawing.Point(7, 7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(53, 53);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(80, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(11, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Solution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Question:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(80, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Select category for new question above";
            // 
            // pnl_EditFAQ
            // 
            this.pnl_EditFAQ.Controls.Add(this.label4);
            this.pnl_EditFAQ.Controls.Add(this.label3);
            this.pnl_EditFAQ.Controls.Add(this.label2);
            this.pnl_EditFAQ.Controls.Add(this.label1);
            this.pnl_EditFAQ.Controls.Add(this.btn_AddQuestion);
            this.pnl_EditFAQ.Controls.Add(this.txt_AnswerAdd);
            this.pnl_EditFAQ.Controls.Add(this.txt_QuestionAdd);
            this.pnl_EditFAQ.Controls.Add(this.btn_DeleteQuestion);
            this.pnl_EditFAQ.Controls.Add(this.cmb_Questions);
            this.pnl_EditFAQ.Location = new System.Drawing.Point(706, 193);
            this.pnl_EditFAQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_EditFAQ.Name = "pnl_EditFAQ";
            this.pnl_EditFAQ.Size = new System.Drawing.Size(392, 401);
            this.pnl_EditFAQ.TabIndex = 36;
            // 
            // FAQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_EditFAQ);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.lbl_CategoryFAQ);
            this.Controls.Add(this.FAQ_comboCategory);
            this.Controls.Add(this.lbl_FAQ);
            this.Controls.Add(this.treeView_FAQ);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FAQForm";
            this.Text = "FAQ";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnl_EditFAQ.ResumeLayout(false);
            this.pnl_EditFAQ.PerformLayout();
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
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel current_stripe;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_FAqMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_EditFAQ;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_Tickets;
        private System.Windows.Forms.Label lbl_Statistics;
    }
}