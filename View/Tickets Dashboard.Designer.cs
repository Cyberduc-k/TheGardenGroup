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
            this.lv_Tickets = new System.Windows.Forms.ListView();
            this.ch_DateOfIssueing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_FAqMenu = new System.Windows.Forms.Label();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Tickets = new System.Windows.Forms.Label();
            this.lbl_Statistics = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_deleteTicket = new System.Windows.Forms.Button();
            this.btn_editTicket = new System.Windows.Forms.Button();
            this.TicketsDashboard_btnResolve = new System.Windows.Forms.Button();
            this.btn_SubmitTicket = new System.Windows.Forms.Button();
            this.TicketsDashboard_btnViewTicket = new System.Windows.Forms.Button();
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Tickets
            // 
            this.lv_Tickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lv_Tickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_DateOfIssueing,
            this.ch_Category,
            this.ch_Subject,
            this.ch_Priority,
            this.ch_Status});
            this.lv_Tickets.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lv_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lv_Tickets.FullRowSelect = true;
            this.lv_Tickets.HideSelection = false;
            this.lv_Tickets.Location = new System.Drawing.Point(95, 152);
            this.lv_Tickets.MultiSelect = false;
            this.lv_Tickets.Name = "lv_Tickets";
            this.lv_Tickets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_Tickets.Size = new System.Drawing.Size(1080, 454);
            this.lv_Tickets.TabIndex = 3;
            this.lv_Tickets.UseCompatibleStateImageBehavior = false;
            this.lv_Tickets.View = System.Windows.Forms.View.Details;
            this.lv_Tickets.SelectedIndexChanged += new System.EventHandler(this.lv_Tickets_SelectedIndexChanged);
            // 
            // ch_DateOfIssueing
            // 
            this.ch_DateOfIssueing.Text = "Date of issueing";
            this.ch_DateOfIssueing.Width = 160;
            // 
            // ch_Category
            // 
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 160;
            // 
            // ch_Subject
            // 
            this.ch_Subject.Text = "Subject";
            this.ch_Subject.Width = 500;
            // 
            // ch_Priority
            // 
            this.ch_Priority.Text = "Priority";
            this.ch_Priority.Width = 120;
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.lbl_FAqMenu);
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_Users);
            this.panel_Header.Controls.Add(this.lbl_Tickets);
            this.panel_Header.Controls.Add(this.lbl_Statistics);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(-1, -1);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1266, 69);
            this.panel_Header.TabIndex = 4;
            // 
            // lbl_FAqMenu
            // 
            this.lbl_FAqMenu.AutoSize = true;
            this.lbl_FAqMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_FAqMenu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_FAqMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FAqMenu.Location = new System.Drawing.Point(352, 17);
            this.lbl_FAqMenu.Name = "lbl_FAqMenu";
            this.lbl_FAqMenu.Size = new System.Drawing.Size(54, 30);
            this.lbl_FAqMenu.TabIndex = 10;
            this.lbl_FAqMenu.Text = "FAQ";
            this.lbl_FAqMenu.Click += new System.EventHandler(this.lbl_FAqMenu_Click);
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(195, 62);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(79, 5);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1172, 20);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(80, 27);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
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
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Users";
            this.lbl_Users.Click += new System.EventHandler(this.lbl_Users_Click);
            // 
            // lbl_Tickets
            // 
            this.lbl_Tickets.AutoSize = true;
            this.lbl_Tickets.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Tickets.Location = new System.Drawing.Point(195, 17);
            this.lbl_Tickets.Name = "lbl_Tickets";
            this.lbl_Tickets.Size = new System.Drawing.Size(79, 30);
            this.lbl_Tickets.TabIndex = 2;
            this.lbl_Tickets.Text = "Tickets";
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
            this.lbl_Statistics.TabIndex = 2;
            this.lbl_Statistics.Text = "Statistics";
            this.lbl_Statistics.Click += new System.EventHandler(this.lbl_Statistics_Click);
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
            // btn_deleteTicket
            // 
            this.btn_deleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_deleteTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btn_deleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_deleteTicket.ForeColor = System.Drawing.Color.White;
            this.btn_deleteTicket.Location = new System.Drawing.Point(1077, 627);
            this.btn_deleteTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteTicket.Name = "btn_deleteTicket";
            this.btn_deleteTicket.Size = new System.Drawing.Size(97, 32);
            this.btn_deleteTicket.TabIndex = 5;
            this.btn_deleteTicket.Text = "Delete";
            this.btn_deleteTicket.UseVisualStyleBackColor = false;
            this.btn_deleteTicket.Click += new System.EventHandler(this.btn_deleteTicket_Click);
            // 
            // btn_editTicket
            // 
            this.btn_editTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_editTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_editTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_editTicket.ForeColor = System.Drawing.Color.White;
            this.btn_editTicket.Location = new System.Drawing.Point(963, 627);
            this.btn_editTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editTicket.Name = "btn_editTicket";
            this.btn_editTicket.Size = new System.Drawing.Size(97, 32);
            this.btn_editTicket.TabIndex = 6;
            this.btn_editTicket.Text = "Edit";
            this.btn_editTicket.UseVisualStyleBackColor = false;
            this.btn_editTicket.Click += new System.EventHandler(this.btn_editTicket_Click);
            // 
            // TicketsDashboard_btnResolve
            // 
            this.TicketsDashboard_btnResolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.TicketsDashboard_btnResolve.Enabled = false;
            this.TicketsDashboard_btnResolve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.TicketsDashboard_btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketsDashboard_btnResolve.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TicketsDashboard_btnResolve.ForeColor = System.Drawing.Color.White;
            this.TicketsDashboard_btnResolve.Location = new System.Drawing.Point(850, 627);
            this.TicketsDashboard_btnResolve.Margin = new System.Windows.Forms.Padding(2);
            this.TicketsDashboard_btnResolve.Name = "TicketsDashboard_btnResolve";
            this.TicketsDashboard_btnResolve.Size = new System.Drawing.Size(97, 32);
            this.TicketsDashboard_btnResolve.TabIndex = 8;
            this.TicketsDashboard_btnResolve.Text = "Resolve";
            this.TicketsDashboard_btnResolve.UseVisualStyleBackColor = false;
            this.TicketsDashboard_btnResolve.Click += new System.EventHandler(this.TicketsDashboard_btnResolve_Click);
            // 
            // btn_SubmitTicket
            // 
            this.btn_SubmitTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_SubmitTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_SubmitTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_SubmitTicket.ForeColor = System.Drawing.Color.White;
            this.btn_SubmitTicket.Location = new System.Drawing.Point(850, 627);
            this.btn_SubmitTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SubmitTicket.Name = "btn_SubmitTicket";
            this.btn_SubmitTicket.Size = new System.Drawing.Size(97, 32);
            this.btn_SubmitTicket.TabIndex = 9;
            this.btn_SubmitTicket.Text = "Submit Ticket";
            this.btn_SubmitTicket.UseVisualStyleBackColor = false;
            this.btn_SubmitTicket.Visible = false;
            this.btn_SubmitTicket.Click += new System.EventHandler(this.btn_SubmitTicket_Click);
            // 
            // TicketsDashboard_btnViewTicket
            // 
            this.TicketsDashboard_btnViewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.TicketsDashboard_btnViewTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.TicketsDashboard_btnViewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketsDashboard_btnViewTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TicketsDashboard_btnViewTicket.ForeColor = System.Drawing.Color.White;
            this.TicketsDashboard_btnViewTicket.Location = new System.Drawing.Point(738, 627);
            this.TicketsDashboard_btnViewTicket.Margin = new System.Windows.Forms.Padding(2);
            this.TicketsDashboard_btnViewTicket.Name = "TicketsDashboard_btnViewTicket";
            this.TicketsDashboard_btnViewTicket.Size = new System.Drawing.Size(97, 32);
            this.TicketsDashboard_btnViewTicket.TabIndex = 10;
            this.TicketsDashboard_btnViewTicket.Text = "View Ticket";
            this.TicketsDashboard_btnViewTicket.UseVisualStyleBackColor = false;
            this.TicketsDashboard_btnViewTicket.Visible = false;
            this.TicketsDashboard_btnViewTicket.Click += new System.EventHandler(this.TicketsDashboard_btnViewTicket_Click);
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            // 
            // Tickets_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TicketsDashboard_btnViewTicket);
            this.Controls.Add(this.btn_SubmitTicket);
            this.Controls.Add(this.TicketsDashboard_btnResolve);
            this.Controls.Add(this.btn_editTicket);
            this.Controls.Add(this.btn_deleteTicket);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.lv_Tickets);
            this.Name = "Tickets_Dashboard";
            this.Text = "Tickets Dashboard";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Tickets;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Subject;
        private System.Windows.Forms.ColumnHeader ch_Priority;
        private System.Windows.Forms.ColumnHeader ch_DateOfIssueing;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel current_stripe;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Statistics;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_deleteTicket;
        private System.Windows.Forms.Button btn_editTicket;
        private System.Windows.Forms.Button TicketsDashboard_btnResolve;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_Tickets;
        private System.Windows.Forms.Label lbl_FAqMenu;
        private System.Windows.Forms.Button btn_SubmitTicket;
        private System.Windows.Forms.Button TicketsDashboard_btnViewTicket;
        private System.Windows.Forms.ColumnHeader ch_Status;
    }
}