namespace View
{
    partial class Submit_Ticket
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
            this.SubmitTicket_btnCancel = new System.Windows.Forms.Button();
            this.SubmitTicket_btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitTicket_txtSubject = new System.Windows.Forms.TextBox();
            this.SubmitTicket_comboCategory = new System.Windows.Forms.ComboBox();
            this.SubmitTicket_rBtnLowPriority = new System.Windows.Forms.RadioButton();
            this.SubmitTicket_rBtnMediumPriority = new System.Windows.Forms.RadioButton();
            this.SubmitTicket_rBtnHighPriority = new System.Windows.Forms.RadioButton();
            this.SubmitTicket_txtDeadline = new System.Windows.Forms.TextBox();
            this.SubmitTicket_txtAreaDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitTicket_btnCancel
            // 
            this.SubmitTicket_btnCancel.Location = new System.Drawing.Point(233, 321);
            this.SubmitTicket_btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_btnCancel.Name = "SubmitTicket_btnCancel";
            this.SubmitTicket_btnCancel.Size = new System.Drawing.Size(100, 28);
            this.SubmitTicket_btnCancel.TabIndex = 0;
            this.SubmitTicket_btnCancel.Text = "Cancel";
            this.SubmitTicket_btnCancel.UseVisualStyleBackColor = true;
            this.SubmitTicket_btnCancel.Click += new System.EventHandler(this.SubmitTicket_btnCancel_Click);
            // 
            // SubmitTicket_btnSubmit
            // 
            this.SubmitTicket_btnSubmit.Location = new System.Drawing.Point(356, 321);
            this.SubmitTicket_btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_btnSubmit.Name = "SubmitTicket_btnSubmit";
            this.SubmitTicket_btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.SubmitTicket_btnSubmit.TabIndex = 1;
            this.SubmitTicket_btnSubmit.Text = "Submit";
            this.SubmitTicket_btnSubmit.UseVisualStyleBackColor = true;
            this.SubmitTicket_btnSubmit.Click += new System.EventHandler(this.SubmitTicket_btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Submit new ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "What is the subject?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deadline (in days)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // SubmitTicket_txtSubject
            // 
            this.SubmitTicket_txtSubject.Location = new System.Drawing.Point(233, 58);
            this.SubmitTicket_txtSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_txtSubject.Name = "SubmitTicket_txtSubject";
            this.SubmitTicket_txtSubject.Size = new System.Drawing.Size(221, 22);
            this.SubmitTicket_txtSubject.TabIndex = 8;
            // 
            // SubmitTicket_comboCategory
            // 
            this.SubmitTicket_comboCategory.FormattingEnabled = true;
            this.SubmitTicket_comboCategory.Items.AddRange(new object[] {
            "Printers",
            "Computers",
            "Mail",
            "General",
            "Other"});
            this.SubmitTicket_comboCategory.Location = new System.Drawing.Point(233, 90);
            this.SubmitTicket_comboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_comboCategory.Name = "SubmitTicket_comboCategory";
            this.SubmitTicket_comboCategory.Size = new System.Drawing.Size(221, 24);
            this.SubmitTicket_comboCategory.TabIndex = 10;
            // 
            // SubmitTicket_rBtnLowPriority
            // 
            this.SubmitTicket_rBtnLowPriority.AutoSize = true;
            this.SubmitTicket_rBtnLowPriority.Location = new System.Drawing.Point(233, 123);
            this.SubmitTicket_rBtnLowPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_rBtnLowPriority.Name = "SubmitTicket_rBtnLowPriority";
            this.SubmitTicket_rBtnLowPriority.Size = new System.Drawing.Size(54, 21);
            this.SubmitTicket_rBtnLowPriority.TabIndex = 11;
            this.SubmitTicket_rBtnLowPriority.TabStop = true;
            this.SubmitTicket_rBtnLowPriority.Tag = "Low";
            this.SubmitTicket_rBtnLowPriority.Text = "Low";
            this.SubmitTicket_rBtnLowPriority.UseVisualStyleBackColor = true;
            // 
            // SubmitTicket_rBtnMediumPriority
            // 
            this.SubmitTicket_rBtnMediumPriority.AutoSize = true;
            this.SubmitTicket_rBtnMediumPriority.Location = new System.Drawing.Point(303, 123);
            this.SubmitTicket_rBtnMediumPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_rBtnMediumPriority.Name = "SubmitTicket_rBtnMediumPriority";
            this.SubmitTicket_rBtnMediumPriority.Size = new System.Drawing.Size(78, 21);
            this.SubmitTicket_rBtnMediumPriority.TabIndex = 12;
            this.SubmitTicket_rBtnMediumPriority.TabStop = true;
            this.SubmitTicket_rBtnMediumPriority.Tag = "Medium";
            this.SubmitTicket_rBtnMediumPriority.Text = "Medium";
            this.SubmitTicket_rBtnMediumPriority.UseVisualStyleBackColor = true;
            // 
            // SubmitTicket_rBtnHighPriority
            // 
            this.SubmitTicket_rBtnHighPriority.AutoSize = true;
            this.SubmitTicket_rBtnHighPriority.Location = new System.Drawing.Point(393, 123);
            this.SubmitTicket_rBtnHighPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_rBtnHighPriority.Name = "SubmitTicket_rBtnHighPriority";
            this.SubmitTicket_rBtnHighPriority.Size = new System.Drawing.Size(58, 21);
            this.SubmitTicket_rBtnHighPriority.TabIndex = 13;
            this.SubmitTicket_rBtnHighPriority.TabStop = true;
            this.SubmitTicket_rBtnHighPriority.Tag = "High";
            this.SubmitTicket_rBtnHighPriority.Text = "High";
            this.SubmitTicket_rBtnHighPriority.UseVisualStyleBackColor = true;
            // 
            // SubmitTicket_txtDeadline
            // 
            this.SubmitTicket_txtDeadline.Location = new System.Drawing.Point(233, 158);
            this.SubmitTicket_txtDeadline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_txtDeadline.Name = "SubmitTicket_txtDeadline";
            this.SubmitTicket_txtDeadline.Size = new System.Drawing.Size(221, 22);
            this.SubmitTicket_txtDeadline.TabIndex = 14;
            // 
            // SubmitTicket_txtAreaDescription
            // 
            this.SubmitTicket_txtAreaDescription.Location = new System.Drawing.Point(233, 192);
            this.SubmitTicket_txtAreaDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitTicket_txtAreaDescription.Multiline = true;
            this.SubmitTicket_txtAreaDescription.Name = "SubmitTicket_txtAreaDescription";
            this.SubmitTicket_txtAreaDescription.Size = new System.Drawing.Size(221, 121);
            this.SubmitTicket_txtAreaDescription.TabIndex = 15;
            // 
            // Submit_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 362);
            this.Controls.Add(this.SubmitTicket_txtAreaDescription);
            this.Controls.Add(this.SubmitTicket_txtDeadline);
            this.Controls.Add(this.SubmitTicket_rBtnHighPriority);
            this.Controls.Add(this.SubmitTicket_rBtnMediumPriority);
            this.Controls.Add(this.SubmitTicket_rBtnLowPriority);
            this.Controls.Add(this.SubmitTicket_comboCategory);
            this.Controls.Add(this.SubmitTicket_txtSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitTicket_btnSubmit);
            this.Controls.Add(this.SubmitTicket_btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Submit_Ticket";
            this.Text = "Submit_Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitTicket_btnCancel;
        private System.Windows.Forms.Button SubmitTicket_btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SubmitTicket_txtSubject;
        private System.Windows.Forms.ComboBox SubmitTicket_comboCategory;
        private System.Windows.Forms.RadioButton SubmitTicket_rBtnLowPriority;
        private System.Windows.Forms.RadioButton SubmitTicket_rBtnMediumPriority;
        private System.Windows.Forms.RadioButton SubmitTicket_rBtnHighPriority;
        private System.Windows.Forms.TextBox SubmitTicket_txtDeadline;
        private System.Windows.Forms.TextBox SubmitTicket_txtAreaDescription;
    }
}