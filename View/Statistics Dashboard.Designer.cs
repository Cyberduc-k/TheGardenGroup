namespace View
{
    partial class Statistics_Dashboard
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
            this.lbl_AmountOfActiveTickets = new System.Windows.Forms.Label();
            this.lbl_AmountOfImmediateAttentionTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TicketList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_UserList = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Tickets = new System.Windows.Forms.Label();
            this.lbl_Statistics = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl_FAqMenu = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AmountOfActiveTickets
            // 
            this.lbl_AmountOfActiveTickets.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountOfActiveTickets.Location = new System.Drawing.Point(497, 404);
            this.lbl_AmountOfActiveTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AmountOfActiveTickets.Name = "lbl_AmountOfActiveTickets";
            this.lbl_AmountOfActiveTickets.Size = new System.Drawing.Size(131, 39);
            this.lbl_AmountOfActiveTickets.TabIndex = 0;
            this.lbl_AmountOfActiveTickets.Text = "AOAT";
            this.lbl_AmountOfActiveTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_AmountOfImmediateAttentionTickets
            // 
            this.lbl_AmountOfImmediateAttentionTickets.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountOfImmediateAttentionTickets.Location = new System.Drawing.Point(1061, 404);
            this.lbl_AmountOfImmediateAttentionTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AmountOfImmediateAttentionTickets.Name = "lbl_AmountOfImmediateAttentionTickets";
            this.lbl_AmountOfImmediateAttentionTickets.Size = new System.Drawing.Size(151, 39);
            this.lbl_AmountOfImmediateAttentionTickets.TabIndex = 1;
            this.lbl_AmountOfImmediateAttentionTickets.Text = "AOIAT";
            this.lbl_AmountOfImmediateAttentionTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "-Active tickets-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(921, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "-Tickets that need immediate attention!-";
            // 
            // btn_TicketList
            // 
            this.btn_TicketList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_TicketList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TicketList.Location = new System.Drawing.Point(637, 635);
            this.btn_TicketList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TicketList.Name = "btn_TicketList";
            this.btn_TicketList.Size = new System.Drawing.Size(396, 76);
            this.btn_TicketList.TabIndex = 4;
            this.btn_TicketList.Text = "Ticket list";
            this.btn_TicketList.UseVisualStyleBackColor = false;
            this.btn_TicketList.Click += new System.EventHandler(this.Btn_TicketList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "This is the amount of tickets that have been submitted but not processed yet.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(917, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "This is the amount of tickets that have surpassed the given wait time. Which mean" +
    "s these tickets need to be processed ASAP.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_UserList
            // 
            this.Btn_UserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.Btn_UserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UserList.Location = new System.Drawing.Point(707, 187);
            this.Btn_UserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_UserList.Name = "Btn_UserList";
            this.Btn_UserList.Size = new System.Drawing.Size(255, 44);
            this.Btn_UserList.TabIndex = 7;
            this.Btn_UserList.Text = "User list";
            this.Btn_UserList.UseVisualStyleBackColor = false;
            this.Btn_UserList.Click += new System.EventHandler(this.Btn_UserList_Click);
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
            this.panel_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1687, 84);
            this.panel_Header.TabIndex = 8;
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(127, 76);
            this.current_stripe.Margin = new System.Windows.Forms.Padding(0);
            this.current_stripe.Name = "current_stripe";
            this.current_stripe.Size = new System.Drawing.Size(163, 6);
            this.current_stripe.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1563, 25);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(107, 33);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Uitloggen";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Users.Location = new System.Drawing.Point(411, 21);
            this.lbl_Users.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(124, 31);
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Gebruikers";
            this.lbl_Users.Click += new System.EventHandler(this.lbl_Users_Click);
            // 
            // lbl_Tickets
            // 
            this.lbl_Tickets.AutoSize = true;
            this.lbl_Tickets.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Tickets.Location = new System.Drawing.Point(297, 21);
            this.lbl_Tickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tickets.Name = "lbl_Tickets";
            this.lbl_Tickets.Size = new System.Drawing.Size(84, 31);
            this.lbl_Tickets.TabIndex = 2;
            this.lbl_Tickets.Text = "Tickets";
            this.lbl_Tickets.Click += new System.EventHandler(this.lbl_Tickets_Click);
            // 
            // lbl_Statistics
            // 
            this.lbl_Statistics.AutoSize = true;
            this.lbl_Statistics.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Statistics.Location = new System.Drawing.Point(127, 21);
            this.lbl_Statistics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Statistics.Name = "lbl_Statistics";
            this.lbl_Statistics.Size = new System.Drawing.Size(131, 31);
            this.lbl_Statistics.TabIndex = 2;
            this.lbl_Statistics.Text = "Statistieken";
            // 
            // logo
            // 
            this.logo.Image = global::View.Properties.Resources.GGLogoTM;
            this.logo.Location = new System.Drawing.Point(9, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(71, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // lbl_FAqMenu
            // 
            this.lbl_FAqMenu.AutoSize = true;
            this.lbl_FAqMenu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_FAqMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_FAqMenu.Location = new System.Drawing.Point(578, 21);
            this.lbl_FAqMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FAqMenu.Name = "lbl_FAqMenu";
            this.lbl_FAqMenu.Size = new System.Drawing.Size(56, 31);
            this.lbl_FAqMenu.TabIndex = 9;
            this.lbl_FAqMenu.Text = "FAQ";
            this.lbl_FAqMenu.Click += new System.EventHandler(this.lbl_FAqMenu_Click);
            // 
            // Statistics_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.Btn_UserList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TicketList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AmountOfImmediateAttentionTickets);
            this.Controls.Add(this.lbl_AmountOfActiveTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Statistics_Dashboard";
            this.Text = "Statistics_Dashboard";
            this.Load += new System.EventHandler(this.Tickets_Dashboard_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AmountOfActiveTickets;
        private System.Windows.Forms.Label lbl_AmountOfImmediateAttentionTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TicketList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_UserList;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel current_stripe;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Statistics;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl_Tickets;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_FAqMenu;
    }
}