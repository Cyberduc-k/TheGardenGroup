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
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_DateOfIssueing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.current_stripe = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
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
            this.lv_Tickets.HideSelection = false;
            this.lv_Tickets.Location = new System.Drawing.Point(95, 152);
            this.lv_Tickets.Name = "lv_Tickets";
            this.lv_Tickets.Size = new System.Drawing.Size(1080, 505);
            this.lv_Tickets.TabIndex = 3;
            this.lv_Tickets.UseCompatibleStateImageBehavior = false;
            this.lv_Tickets.View = System.Windows.Forms.View.Details;
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
            // ch_DateOfIssueing
            // 
            this.ch_DateOfIssueing.Text = "Date of issueing";
            this.ch_DateOfIssueing.Width = 160;
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
            this.Controls.Add(this.lv_Tickets);
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
    }
}