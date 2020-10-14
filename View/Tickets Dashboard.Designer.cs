namespace View
{
    partial class Tickets_Dashboard
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
            this.lv_Users = new System.Windows.Forms.ListView();
            this.ch_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Occupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Users
            // 
            this.lv_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lv_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_FirstName,
            this.ch_LastName,
            this.ch_Email,
            this.ch_BirthDate,
            this.ch_Company,
            this.ch_Occupation,
            this.ch_Tickets});
            this.lv_Users.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lv_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lv_Users.HideSelection = false;
            this.lv_Users.Location = new System.Drawing.Point(95, 152);
            this.lv_Users.Name = "lv_Users";
            this.lv_Users.Size = new System.Drawing.Size(1080, 505);
            this.lv_Users.TabIndex = 3;
            this.lv_Users.UseCompatibleStateImageBehavior = false;
            this.lv_Users.View = System.Windows.Forms.View.Details;
            // 
            // ch_FirstName
            // 
            this.ch_FirstName.Text = "Voornaam";
            this.ch_FirstName.Width = 150;
            // 
            // ch_LastName
            // 
            this.ch_LastName.Text = "Achternaam";
            this.ch_LastName.Width = 200;
            // 
            // ch_Email
            // 
            this.ch_Email.Text = "Email";
            this.ch_Email.Width = 220;
            // 
            // ch_BirthDate
            // 
            this.ch_BirthDate.Text = "Geboortedatum";
            this.ch_BirthDate.Width = 126;
            // 
            // ch_Company
            // 
            this.ch_Company.Text = "Werkzaam Bij";
            this.ch_Company.Width = 120;
            // 
            // ch_Occupation
            // 
            this.ch_Occupation.Text = "Werkzaamheden";
            this.ch_Occupation.Width = 204;
            // 
            // ch_Tickets
            // 
            this.ch_Tickets.Text = "Tickets";
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_Users);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(-1, -1);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1266, 69);
            this.panel_Header.TabIndex = 4;
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(95, 62);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(108, 5);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1180, 20);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(67, 27);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Uitloggen";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Users.Location = new System.Drawing.Point(110, 17);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(79, 30);
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Tickets";
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
            // Tickets_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.lv_Users);
            this.Name = "Tickets_Dashboard";
            this.Text = "Tickets_Dashboard";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Users;
        private System.Windows.Forms.ColumnHeader ch_FirstName;
        private System.Windows.Forms.ColumnHeader ch_LastName;
        private System.Windows.Forms.ColumnHeader ch_Email;
        private System.Windows.Forms.ColumnHeader ch_BirthDate;
        private System.Windows.Forms.ColumnHeader ch_Company;
        private System.Windows.Forms.ColumnHeader ch_Occupation;
        private System.Windows.Forms.ColumnHeader ch_Tickets;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel current_stripe;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.PictureBox logo;
    }
}