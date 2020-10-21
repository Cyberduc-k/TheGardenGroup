namespace View
{
    partial class Edit_User
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
            this.lbl_EditAccount = new System.Windows.Forms.Label();
            this.input_FirstName = new System.Windows.Forms.TextBox();
            this.pnl_EditAccountCustomer = new System.Windows.Forms.Panel();
            this.input_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.input_Expertise = new System.Windows.Forms.ComboBox();
            this.lbl_Expertise = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Occupation = new System.Windows.Forms.Label();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.input_DisplayName = new System.Windows.Forms.TextBox();
            this.input_Email = new System.Windows.Forms.TextBox();
            this.input_LastName = new System.Windows.Forms.TextBox();
            this.input_Occupation = new System.Windows.Forms.TextBox();
            this.input_Company = new System.Windows.Forms.TextBox();
            this.pnl_EditAccountCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_EditAccount
            // 
            this.lbl_EditAccount.AutoSize = true;
            this.lbl_EditAccount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_EditAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_EditAccount.Location = new System.Drawing.Point(547, 87);
            this.lbl_EditAccount.Name = "lbl_EditAccount";
            this.lbl_EditAccount.Size = new System.Drawing.Size(149, 32);
            this.lbl_EditAccount.TabIndex = 0;
            this.lbl_EditAccount.Text = "Edit Account";
            this.lbl_EditAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_FirstName
            // 
            this.input_FirstName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_FirstName.Location = new System.Drawing.Point(24, 48);
            this.input_FirstName.Name = "input_FirstName";
            this.input_FirstName.Size = new System.Drawing.Size(196, 29);
            this.input_FirstName.TabIndex = 1;
            this.input_FirstName.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // pnl_EditAccountCustomer
            // 
            this.pnl_EditAccountCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_EditAccountCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_EditAccountCustomer.Controls.Add(this.input_BirthDate);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_Expertise);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_Expertise);
            this.pnl_EditAccountCustomer.Controls.Add(this.btn_Save);
            this.pnl_EditAccountCustomer.Controls.Add(this.btn_Cancel);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_BirthDate);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_DisplayName);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_Email);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_LastName);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_Occupation);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_Company);
            this.pnl_EditAccountCustomer.Controls.Add(this.lbl_FirstName);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_DisplayName);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_Email);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_LastName);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_Occupation);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_Company);
            this.pnl_EditAccountCustomer.Controls.Add(this.input_FirstName);
            this.pnl_EditAccountCustomer.Location = new System.Drawing.Point(396, 210);
            this.pnl_EditAccountCustomer.Name = "pnl_EditAccountCustomer";
            this.pnl_EditAccountCustomer.Size = new System.Drawing.Size(464, 382);
            this.pnl_EditAccountCustomer.TabIndex = 7;
            // 
            // input_BirthDate
            // 
            this.input_BirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.input_BirthDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_BirthDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_BirthDate.Location = new System.Drawing.Point(244, 48);
            this.input_BirthDate.Name = "input_BirthDate";
            this.input_BirthDate.Size = new System.Drawing.Size(196, 29);
            this.input_BirthDate.TabIndex = 5;
            // 
            // input_Expertise
            // 
            this.input_Expertise.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Expertise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Expertise.FormattingEnabled = true;
            this.input_Expertise.Items.AddRange(new object[] {
            "Printers",
            "Computers",
            "Mail",
            "General",
            "Other"});
            this.input_Expertise.Location = new System.Drawing.Point(244, 124);
            this.input_Expertise.Name = "input_Expertise";
            this.input_Expertise.Size = new System.Drawing.Size(196, 29);
            this.input_Expertise.TabIndex = 6;
            this.input_Expertise.Visible = false;
            // 
            // lbl_Expertise
            // 
            this.lbl_Expertise.AutoSize = true;
            this.lbl_Expertise.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Expertise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Expertise.Location = new System.Drawing.Point(244, 100);
            this.lbl_Expertise.Name = "lbl_Expertise";
            this.lbl_Expertise.Size = new System.Drawing.Size(61, 17);
            this.lbl_Expertise.TabIndex = 4;
            this.lbl_Expertise.Text = "Expertise";
            this.lbl_Expertise.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(244, 328);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(196, 30);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(24, 328);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(196, 30);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_BirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_BirthDate.Location = new System.Drawing.Point(244, 21);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(64, 17);
            this.lbl_BirthDate.TabIndex = 2;
            this.lbl_BirthDate.Text = "Birth date";
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_DisplayName.Location = new System.Drawing.Point(24, 252);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(86, 17);
            this.lbl_DisplayName.TabIndex = 2;
            this.lbl_DisplayName.Text = "Display name";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Email.Location = new System.Drawing.Point(24, 176);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(90, 17);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email address";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_LastName.Location = new System.Drawing.Point(24, 100);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(67, 17);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last name";
            // 
            // lbl_Occupation
            // 
            this.lbl_Occupation.AutoSize = true;
            this.lbl_Occupation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Occupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Occupation.Location = new System.Drawing.Point(244, 176);
            this.lbl_Occupation.Name = "lbl_Occupation";
            this.lbl_Occupation.Size = new System.Drawing.Size(74, 17);
            this.lbl_Occupation.TabIndex = 2;
            this.lbl_Occupation.Text = "Occupation";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Company.Location = new System.Drawing.Point(244, 100);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(63, 17);
            this.lbl_Company.TabIndex = 2;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FirstName.Location = new System.Drawing.Point(24, 21);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(68, 17);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "First name";
            // 
            // input_DisplayName
            // 
            this.input_DisplayName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_DisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_DisplayName.Location = new System.Drawing.Point(24, 276);
            this.input_DisplayName.Name = "input_DisplayName";
            this.input_DisplayName.Size = new System.Drawing.Size(196, 29);
            this.input_DisplayName.TabIndex = 4;
            this.input_DisplayName.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // input_Email
            // 
            this.input_Email.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Email.Location = new System.Drawing.Point(24, 200);
            this.input_Email.Name = "input_Email";
            this.input_Email.Size = new System.Drawing.Size(196, 29);
            this.input_Email.TabIndex = 3;
            this.input_Email.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // input_LastName
            // 
            this.input_LastName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_LastName.Location = new System.Drawing.Point(24, 124);
            this.input_LastName.Name = "input_LastName";
            this.input_LastName.Size = new System.Drawing.Size(196, 29);
            this.input_LastName.TabIndex = 2;
            this.input_LastName.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // input_Occupation
            // 
            this.input_Occupation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Occupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Occupation.Location = new System.Drawing.Point(244, 200);
            this.input_Occupation.Name = "input_Occupation";
            this.input_Occupation.Size = new System.Drawing.Size(196, 29);
            this.input_Occupation.TabIndex = 7;
            this.input_Occupation.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // input_Company
            // 
            this.input_Company.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Company.Location = new System.Drawing.Point(244, 124);
            this.input_Company.Name = "input_Company";
            this.input_Company.Size = new System.Drawing.Size(196, 29);
            this.input_Company.TabIndex = 6;
            this.input_Company.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_EditAccountCustomer);
            this.Controls.Add(this.lbl_EditAccount);
            this.Name = "Edit_User";
            this.Text = "Edit Account";
            this.pnl_EditAccountCustomer.ResumeLayout(false);
            this.pnl_EditAccountCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EditAccount;
        private System.Windows.Forms.TextBox input_FirstName;
        private System.Windows.Forms.Panel pnl_EditAccountCustomer;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DisplayName;
        private System.Windows.Forms.TextBox input_DisplayName;
        private System.Windows.Forms.TextBox input_Email;
        private System.Windows.Forms.TextBox input_LastName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox input_Company;
        private System.Windows.Forms.Label lbl_Occupation;
        private System.Windows.Forms.TextBox input_Occupation;
        private System.Windows.Forms.Label lbl_Expertise;
        private System.Windows.Forms.ComboBox input_Expertise;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.DateTimePicker input_BirthDate;
    }
}