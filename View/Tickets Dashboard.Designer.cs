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
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_deleteTicket = new System.Windows.Forms.Button();
            this.btn_editTicket = new System.Windows.Forms.Button();
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
            this.ch_Priority});
            this.lv_Tickets.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lv_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lv_Tickets.FullRowSelect = true;
            this.lv_Tickets.HideSelection = false;
            this.lv_Tickets.Location = new System.Drawing.Point(127, 187);
            this.lv_Tickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lv_Tickets.MultiSelect = false;
            this.lv_Tickets.Name = "lv_Tickets";
            this.lv_Tickets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_Tickets.Size = new System.Drawing.Size(1439, 558);
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
            this.panel_Header.Controls.Add(this.current_stripe);
            this.panel_Header.Controls.Add(this.btn_Logout);
            this.panel_Header.Controls.Add(this.lbl_Users);
            this.panel_Header.Controls.Add(this.logo);
            this.panel_Header.Location = new System.Drawing.Point(-1, -1);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1687, 84);
            this.panel_Header.TabIndex = 4;
            // 
            // current_stripe
            // 
            this.current_stripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(194)))), ((int)(((byte)(92)))));
            this.current_stripe.Location = new System.Drawing.Point(127, 76);
            this.current_stripe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(89, 33);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Uitloggen";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Users.Location = new System.Drawing.Point(147, 21);
            this.lbl_Users.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(84, 31);
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Tickets";
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
            // btn_deleteTicket
            // 
            this.btn_deleteTicket.Location = new System.Drawing.Point(1436, 772);
            this.btn_deleteTicket.Name = "btn_deleteTicket";
            this.btn_deleteTicket.Size = new System.Drawing.Size(129, 39);
            this.btn_deleteTicket.TabIndex = 5;
            this.btn_deleteTicket.Text = "Delete";
            this.btn_deleteTicket.UseVisualStyleBackColor = true;
            this.btn_deleteTicket.Click += new System.EventHandler(this.btn_deleteTicket_Click);
            // 
            // btn_editTicket
            // 
            this.btn_editTicket.Location = new System.Drawing.Point(1284, 772);
            this.btn_editTicket.Name = "btn_editTicket";
            this.btn_editTicket.Size = new System.Drawing.Size(129, 39);
            this.btn_editTicket.TabIndex = 6;
            this.btn_editTicket.Text = "Edit";
            this.btn_editTicket.UseVisualStyleBackColor = true;
            this.btn_editTicket.Click += new System.EventHandler(this.btn_editTicket_Click);
            // 
            // Tickets_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.btn_editTicket);
            this.Controls.Add(this.btn_deleteTicket);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.lv_Tickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tickets_Dashboard";
            this.Text = "Tickets_Dashboard";
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
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_deleteTicket;
        private System.Windows.Forms.Button btn_editTicket;
    }
}