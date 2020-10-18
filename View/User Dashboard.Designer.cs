namespace View
{
    partial class User_Dashboard
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Statistics = new System.Windows.Forms.Label();
            this.lbl_Ticketrs = new System.Windows.Forms.Label();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.lv_Users = new System.Windows.Forms.ListView();
            this.ch_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Occupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_ReviewScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_TicketsHelped = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_TicketsNotHelped = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_editTicket = new System.Windows.Forms.Button();
            this.btn_deleteTicket = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_Statistics);
            this.panel_Header.Controls.Add(this.lbl_Ticketrs);
            this.panel_Header.Controls.Add(this.lbl_Users);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(-1, -1);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1266, 69);
            this.panel_Header.TabIndex = 0;
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(308, 62);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(118, 5);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1172, 21);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(80, 27);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Uitloggen";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Statistics
            // 
            this.lbl_Statistics.AutoSize = true;
            this.lbl_Statistics.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Statistics.Location = new System.Drawing.Point(95, 16);
            this.lbl_Statistics.Name = "lbl_Statistics";
            this.lbl_Statistics.Size = new System.Drawing.Size(122, 30);
            this.lbl_Statistics.TabIndex = 2;
            this.lbl_Statistics.Text = "Statistieken";
            this.lbl_Statistics.Click += new System.EventHandler(this.lbl_Statistics_Click);
            // 
            // lbl_Ticketrs
            // 
            this.lbl_Ticketrs.AutoSize = true;
            this.lbl_Ticketrs.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Ticketrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Ticketrs.Location = new System.Drawing.Point(223, 16);
            this.lbl_Ticketrs.Name = "lbl_Ticketrs";
            this.lbl_Ticketrs.Size = new System.Drawing.Size(79, 30);
            this.lbl_Ticketrs.TabIndex = 2;
            this.lbl_Ticketrs.Text = "Tickets";
            this.lbl_Ticketrs.Click += new System.EventHandler(this.lbl_Ticketrs_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Users.Location = new System.Drawing.Point(308, 16);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(118, 30);
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Gebruikers";
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
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Klanten",
            "Medewerkers"});
            this.filter.Location = new System.Drawing.Point(95, 99);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(196, 29);
            this.filter.TabIndex = 1;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
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
            this.lv_Users.FullRowSelect = true;
            this.lv_Users.HideSelection = false;
            this.lv_Users.Location = new System.Drawing.Point(95, 152);
            this.lv_Users.MultiSelect = false;
            this.lv_Users.Name = "lv_Users";
            this.lv_Users.Size = new System.Drawing.Size(1080, 454);
            this.lv_Users.TabIndex = 2;
            this.lv_Users.UseCompatibleStateImageBehavior = false;
            this.lv_Users.View = System.Windows.Forms.View.Details;
            this.lv_Users.SelectedIndexChanged += new System.EventHandler(this.lv_Users_SelectedIndexChanged);
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
            // ch_ReviewScore
            // 
            this.ch_ReviewScore.Text = "Review Score";
            this.ch_ReviewScore.Width = 106;
            // 
            // ch_TicketsHelped
            // 
            this.ch_TicketsHelped.Text = "Verholpen";
            this.ch_TicketsHelped.Width = 86;
            // 
            // ch_TicketsNotHelped
            // 
            this.ch_TicketsNotHelped.Text = "Niet Verholpen";
            this.ch_TicketsNotHelped.Width = 130;
            // 
            // btn_editTicket
            // 
            this.btn_editTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_editTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_editTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_editTicket.ForeColor = System.Drawing.Color.White;
            this.btn_editTicket.Location = new System.Drawing.Point(964, 627);
            this.btn_editTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editTicket.Name = "btn_editTicket";
            this.btn_editTicket.Size = new System.Drawing.Size(97, 32);
            this.btn_editTicket.TabIndex = 8;
            this.btn_editTicket.Text = "Edit";
            this.btn_editTicket.UseVisualStyleBackColor = false;
            this.btn_editTicket.Click += new System.EventHandler(this.btn_editTicket_Click);
            // 
            // btn_deleteTicket
            // 
            this.btn_deleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_deleteTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btn_deleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_deleteTicket.ForeColor = System.Drawing.Color.White;
            this.btn_deleteTicket.Location = new System.Drawing.Point(1078, 627);
            this.btn_deleteTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteTicket.Name = "btn_deleteTicket";
            this.btn_deleteTicket.Size = new System.Drawing.Size(97, 32);
            this.btn_deleteTicket.TabIndex = 7;
            this.btn_deleteTicket.Text = "Delete";
            this.btn_deleteTicket.UseVisualStyleBackColor = false;
            this.btn_deleteTicket.Click += new System.EventHandler(this.btn_deleteTicket_Click);
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_editTicket);
            this.Controls.Add(this.btn_deleteTicket);
            this.Controls.Add(this.lv_Users);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.panel_Header);
            this.Name = "User_Dashboard";
            this.Text = "User Dashboard";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel current_stripe;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.ListView lv_Users;
        private System.Windows.Forms.ColumnHeader ch_FirstName;
        private System.Windows.Forms.ColumnHeader ch_LastName;
        private System.Windows.Forms.ColumnHeader ch_Email;
        private System.Windows.Forms.ColumnHeader ch_BirthDate;
        private System.Windows.Forms.ColumnHeader ch_ReviewScore;
        private System.Windows.Forms.ColumnHeader ch_Tickets;
        private System.Windows.Forms.ColumnHeader ch_TicketsHelped;
        private System.Windows.Forms.ColumnHeader ch_TicketsNotHelped;
        private System.Windows.Forms.ColumnHeader ch_Company;
        private System.Windows.Forms.ColumnHeader ch_Occupation;
        private System.Windows.Forms.Button btn_editTicket;
        private System.Windows.Forms.Button btn_deleteTicket;
        private System.Windows.Forms.Label lbl_Statistics;
        private System.Windows.Forms.Label lbl_Ticketrs;
    }
}