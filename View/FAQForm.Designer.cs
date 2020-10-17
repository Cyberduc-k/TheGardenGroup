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
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_TicketEDit = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_FAQ
            // 
            this.treeView_FAQ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeView_FAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.treeView_FAQ.Location = new System.Drawing.Point(300, 264);
            this.treeView_FAQ.Name = "treeView_FAQ";
            this.treeView_FAQ.Size = new System.Drawing.Size(596, 436);
            this.treeView_FAQ.TabIndex = 0;
            // 
            // lbl_FAQ
            // 
            this.lbl_FAQ.AutoSize = true;
            this.lbl_FAQ.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_FAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FAQ.Location = new System.Drawing.Point(916, 114);
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
            this.FAQ_comboCategory.Location = new System.Drawing.Point(736, 196);
            this.FAQ_comboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.FAQ_comboCategory.Name = "FAQ_comboCategory";
            this.FAQ_comboCategory.Size = new System.Drawing.Size(410, 27);
            this.FAQ_comboCategory.TabIndex = 11;
            this.FAQ_comboCategory.SelectedIndexChanged += new System.EventHandler(this.FAQ_comboCategory_SelectedIndexChanged);
            // 
            // lbl_CategoryFAQ
            // 
            this.lbl_CategoryFAQ.AutoSize = true;
            this.lbl_CategoryFAQ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_CategoryFAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_CategoryFAQ.Location = new System.Drawing.Point(905, 172);
            this.lbl_CategoryFAQ.Name = "lbl_CategoryFAQ";
            this.lbl_CategoryFAQ.Size = new System.Drawing.Size(72, 20);
            this.lbl_CategoryFAQ.TabIndex = 12;
            this.lbl_CategoryFAQ.Text = "Category:";
            // 
            // cmb_Questions
            // 
            this.cmb_Questions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Questions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.cmb_Questions.FormattingEnabled = true;
            this.cmb_Questions.Location = new System.Drawing.Point(1051, 280);
            this.cmb_Questions.Name = "cmb_Questions";
            this.cmb_Questions.Size = new System.Drawing.Size(322, 27);
            this.cmb_Questions.TabIndex = 13;
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_DeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(1111, 338);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(199, 51);
            this.btn_DeleteQuestion.TabIndex = 14;
            this.btn_DeleteQuestion.Text = "Delete Question";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = false;
            this.btn_DeleteQuestion.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // txt_QuestionAdd
            // 
            this.txt_QuestionAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_QuestionAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.txt_QuestionAdd.Location = new System.Drawing.Point(1051, 469);
            this.txt_QuestionAdd.Name = "txt_QuestionAdd";
            this.txt_QuestionAdd.Size = new System.Drawing.Size(322, 26);
            this.txt_QuestionAdd.TabIndex = 15;
            // 
            // txt_AnswerAdd
            // 
            this.txt_AnswerAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AnswerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.txt_AnswerAdd.Location = new System.Drawing.Point(1051, 511);
            this.txt_AnswerAdd.Multiline = true;
            this.txt_AnswerAdd.Name = "txt_AnswerAdd";
            this.txt_AnswerAdd.Size = new System.Drawing.Size(322, 132);
            this.txt_AnswerAdd.TabIndex = 16;
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_AddQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_AddQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_AddQuestion.Location = new System.Drawing.Point(1111, 649);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(199, 51);
            this.btn_AddQuestion.TabIndex = 17;
            this.btn_AddQuestion.Text = "Add Question";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_TicketEDit);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(2, 1);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1687, 84);
            this.panel_Header.TabIndex = 30;
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(127, 76);
            this.current_stripe.Margin = new System.Windows.Forms.Padding(4);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(144, 6);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1573, 25);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(89, 33);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Uitloggen";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_TicketEDit
            // 
            this.lbl_TicketEDit.AutoSize = true;
            this.lbl_TicketEDit.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_TicketEDit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_TicketEDit.Location = new System.Drawing.Point(135, 27);
            this.lbl_TicketEDit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TicketEDit.Name = "lbl_TicketEDit";
            this.lbl_TicketEDit.Size = new System.Drawing.Size(116, 31);
            this.lbl_TicketEDit.TabIndex = 2;
            this.lbl_TicketEDit.Text = "Edit ticket";
            // 
            // logo
            // 
            this.logo.Image = global::View.Properties.Resources.GGLogoTM;
            this.logo.Location = new System.Drawing.Point(9, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(71, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(1048, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(956, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Solution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(956, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Question:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(1048, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Select category for new question above";
            // 
            // FAQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.btn_AddQuestion);
            this.Controls.Add(this.txt_AnswerAdd);
            this.Controls.Add(this.txt_QuestionAdd);
            this.Controls.Add(this.btn_DeleteQuestion);
            this.Controls.Add(this.cmb_Questions);
            this.Controls.Add(this.lbl_CategoryFAQ);
            this.Controls.Add(this.FAQ_comboCategory);
            this.Controls.Add(this.lbl_FAQ);
            this.Controls.Add(this.treeView_FAQ);
            this.Name = "FAQForm";
            this.Text = "FAQ";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
        private System.Windows.Forms.Label lbl_TicketEDit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}