namespace View
{
    partial class Review_Ticket
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
            this.pnl_EditTicket = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_ResolvedBy = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_TicketId = new System.Windows.Forms.Label();
            this.input_ReviewScore = new System.Windows.Forms.NumericUpDown();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.txtBox_Solution = new System.Windows.Forms.TextBox();
            this.lbl_Review = new System.Windows.Forms.Label();
            this.input_Review = new System.Windows.Forms.TextBox();
            this.lbl_editTicket = new System.Windows.Forms.Label();
            this.pnl_EditTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ReviewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_EditTicket
            // 
            this.pnl_EditTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_EditTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_EditTicket.Controls.Add(this.btn_Save);
            this.pnl_EditTicket.Controls.Add(this.btn_Cancel);
            this.pnl_EditTicket.Controls.Add(this.lbl_ResolvedBy);
            this.pnl_EditTicket.Controls.Add(this.lbl_Email);
            this.pnl_EditTicket.Controls.Add(this.lbl_Name);
            this.pnl_EditTicket.Controls.Add(this.lbl_TicketId);
            this.pnl_EditTicket.Controls.Add(this.input_ReviewScore);
            this.pnl_EditTicket.Controls.Add(this.lbl_Score);
            this.pnl_EditTicket.Controls.Add(this.lbl_Solution);
            this.pnl_EditTicket.Controls.Add(this.txtBox_Solution);
            this.pnl_EditTicket.Controls.Add(this.lbl_Review);
            this.pnl_EditTicket.Controls.Add(this.input_Review);
            this.pnl_EditTicket.Location = new System.Drawing.Point(319, 134);
            this.pnl_EditTicket.Name = "pnl_EditTicket";
            this.pnl_EditTicket.Size = new System.Drawing.Size(651, 476);
            this.pnl_EditTicket.TabIndex = 33;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(507, 414);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 39);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.EditTicket_btnEdit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(22, 414);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 39);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.EditTicket_btnCancel_Click);
            // 
            // lbl_ResolvedBy
            // 
            this.lbl_ResolvedBy.AutoSize = true;
            this.lbl_ResolvedBy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ResolvedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_ResolvedBy.Location = new System.Drawing.Point(178, 16);
            this.lbl_ResolvedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ResolvedBy.Name = "lbl_ResolvedBy";
            this.lbl_ResolvedBy.Size = new System.Drawing.Size(85, 19);
            this.lbl_ResolvedBy.TabIndex = 36;
            this.lbl_ResolvedBy.Text = "Resolved by:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Email.Location = new System.Drawing.Point(177, 49);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(146, 19);
            this.lbl_Email.TabIndex = 35;
            this.lbl_Email.Text = "bram@bramsierhuis.nl";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Name.Location = new System.Drawing.Point(177, 32);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 19);
            this.lbl_Name.TabIndex = 34;
            this.lbl_Name.Text = "Bram Sierhuis";
            // 
            // lbl_TicketId
            // 
            this.lbl_TicketId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TicketId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_TicketId.Location = new System.Drawing.Point(18, 19);
            this.lbl_TicketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TicketId.Name = "lbl_TicketId";
            this.lbl_TicketId.Size = new System.Drawing.Size(130, 46);
            this.lbl_TicketId.TabIndex = 33;
            this.lbl_TicketId.Text = "Ticket #xxxxxxx";
            // 
            // input_ReviewScore
            // 
            this.input_ReviewScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_ReviewScore.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_ReviewScore.Location = new System.Drawing.Point(375, 246);
            this.input_ReviewScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.input_ReviewScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_ReviewScore.Name = "input_ReviewScore";
            this.input_ReviewScore.Size = new System.Drawing.Size(254, 25);
            this.input_ReviewScore.TabIndex = 32;
            this.input_ReviewScore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Score.Location = new System.Drawing.Point(318, 247);
            this.lbl_Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(42, 19);
            this.lbl_Score.TabIndex = 5;
            this.lbl_Score.Text = "Score";
            // 
            // lbl_Solution
            // 
            this.lbl_Solution.AutoSize = true;
            this.lbl_Solution.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Solution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Solution.Location = new System.Drawing.Point(18, 78);
            this.lbl_Solution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Solution.Name = "lbl_Solution";
            this.lbl_Solution.Size = new System.Drawing.Size(59, 19);
            this.lbl_Solution.TabIndex = 5;
            this.lbl_Solution.Text = "Solution";
            // 
            // txtBox_Solution
            // 
            this.txtBox_Solution.Enabled = false;
            this.txtBox_Solution.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBox_Solution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.txtBox_Solution.Location = new System.Drawing.Point(22, 109);
            this.txtBox_Solution.Multiline = true;
            this.txtBox_Solution.Name = "txtBox_Solution";
            this.txtBox_Solution.Size = new System.Drawing.Size(607, 111);
            this.txtBox_Solution.TabIndex = 24;
            // 
            // lbl_Review
            // 
            this.lbl_Review.AutoSize = true;
            this.lbl_Review.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_Review.Location = new System.Drawing.Point(18, 247);
            this.lbl_Review.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Review.Name = "lbl_Review";
            this.lbl_Review.Size = new System.Drawing.Size(51, 19);
            this.lbl_Review.TabIndex = 5;
            this.lbl_Review.Text = "Review";
            // 
            // input_Review
            // 
            this.input_Review.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.input_Review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Review.Location = new System.Drawing.Point(22, 278);
            this.input_Review.Multiline = true;
            this.input_Review.Name = "input_Review";
            this.input_Review.Size = new System.Drawing.Size(607, 111);
            this.input_Review.TabIndex = 24;
            // 
            // lbl_editTicket
            // 
            this.lbl_editTicket.AutoSize = true;
            this.lbl_editTicket.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_editTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.lbl_editTicket.Location = new System.Drawing.Point(553, 22);
            this.lbl_editTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_editTicket.Name = "lbl_editTicket";
            this.lbl_editTicket.Size = new System.Drawing.Size(162, 35);
            this.lbl_editTicket.TabIndex = 0;
            this.lbl_editTicket.Text = "Review Ticket";
            // 
            // Review_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_EditTicket);
            this.Controls.Add(this.lbl_editTicket);
            this.Name = "Review_Ticket";
            this.Text = "Review Ticket";
            this.pnl_EditTicket.ResumeLayout(false);
            this.pnl_EditTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ReviewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_EditTicket;
        private System.Windows.Forms.NumericUpDown input_ReviewScore;
        private System.Windows.Forms.Label lbl_editTicket;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Review;
        private System.Windows.Forms.TextBox input_Review;
        private System.Windows.Forms.Label lbl_ResolvedBy;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_TicketId;
        private System.Windows.Forms.Label lbl_Solution;
        private System.Windows.Forms.TextBox txtBox_Solution;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}