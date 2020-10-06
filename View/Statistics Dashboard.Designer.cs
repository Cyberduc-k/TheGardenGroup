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
            this.lbl_AmountOfActiveTickets = new System.Windows.Forms.Label();
            this.lbl_AmountOfImmediateAttentionTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TicketList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AmountOfActiveTickets
            // 
            this.lbl_AmountOfActiveTickets.AutoSize = true;
            this.lbl_AmountOfActiveTickets.Location = new System.Drawing.Point(191, 204);
            this.lbl_AmountOfActiveTickets.Name = "lbl_AmountOfActiveTickets";
            this.lbl_AmountOfActiveTickets.Size = new System.Drawing.Size(36, 13);
            this.lbl_AmountOfActiveTickets.TabIndex = 0;
            this.lbl_AmountOfActiveTickets.Text = "AOAT";
            // 
            // lbl_AmountOfImmediateAttentionTickets
            // 
            this.lbl_AmountOfImmediateAttentionTickets.AutoSize = true;
            this.lbl_AmountOfImmediateAttentionTickets.Location = new System.Drawing.Point(556, 204);
            this.lbl_AmountOfImmediateAttentionTickets.Name = "lbl_AmountOfImmediateAttentionTickets";
            this.lbl_AmountOfImmediateAttentionTickets.Size = new System.Drawing.Size(39, 13);
            this.lbl_AmountOfImmediateAttentionTickets.TabIndex = 1;
            this.lbl_AmountOfImmediateAttentionTickets.Text = "AOIAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-Active tickets-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-Active tickets-";
            // 
            // btn_TicketList
            // 
            this.btn_TicketList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_TicketList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketList.Location = new System.Drawing.Point(314, 334);
            this.btn_TicketList.Name = "btn_TicketList";
            this.btn_TicketList.Size = new System.Drawing.Size(153, 37);
            this.btn_TicketList.TabIndex = 4;
            this.btn_TicketList.Text = "Ticket list";
            this.btn_TicketList.UseVisualStyleBackColor = false;
            // 
            // Tickets_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TicketList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AmountOfImmediateAttentionTickets);
            this.Controls.Add(this.lbl_AmountOfActiveTickets);
            this.Name = "Tickets_Dashboard";
            this.Text = "Tickets_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AmountOfActiveTickets;
        private System.Windows.Forms.Label lbl_AmountOfImmediateAttentionTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TicketList;
    }
}