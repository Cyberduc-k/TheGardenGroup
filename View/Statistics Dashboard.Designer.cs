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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_AmountOfActiveTickets
            // 
            this.lbl_AmountOfActiveTickets.AutoSize = true;
            this.lbl_AmountOfActiveTickets.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountOfActiveTickets.Location = new System.Drawing.Point(373, 328);
            this.lbl_AmountOfActiveTickets.Name = "lbl_AmountOfActiveTickets";
            this.lbl_AmountOfActiveTickets.Size = new System.Drawing.Size(98, 32);
            this.lbl_AmountOfActiveTickets.TabIndex = 0;
            this.lbl_AmountOfActiveTickets.Text = "AOAT";
            // 
            // lbl_AmountOfImmediateAttentionTickets
            // 
            this.lbl_AmountOfImmediateAttentionTickets.AutoSize = true;
            this.lbl_AmountOfImmediateAttentionTickets.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountOfImmediateAttentionTickets.Location = new System.Drawing.Point(796, 328);
            this.lbl_AmountOfImmediateAttentionTickets.Name = "lbl_AmountOfImmediateAttentionTickets";
            this.lbl_AmountOfImmediateAttentionTickets.Size = new System.Drawing.Size(113, 32);
            this.lbl_AmountOfImmediateAttentionTickets.TabIndex = 1;
            this.lbl_AmountOfImmediateAttentionTickets.Text = "AOIAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "-Active tickets-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "-Tickets that need immediate attention!-";
            // 
            // btn_TicketList
            // 
            this.btn_TicketList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_TicketList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketList.Location = new System.Drawing.Point(512, 535);
            this.btn_TicketList.Name = "btn_TicketList";
            this.btn_TicketList.Size = new System.Drawing.Size(232, 39);
            this.btn_TicketList.TabIndex = 4;
            this.btn_TicketList.Text = "Ticket list";
            this.btn_TicketList.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "This is the amount of tickets that have been submitted but not processed yet.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(688, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "This is the amount of tickets that have surpassed the given wait time. Which mean" +
    "s these tickets need to be processed ASAP.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tickets_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TicketList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AmountOfImmediateAttentionTickets);
            this.Controls.Add(this.lbl_AmountOfActiveTickets);
            this.Name = "Tickets_Dashboard";
            this.Text = "Tickets_Dashboard";
            this.Load += new System.EventHandler(this.Tickets_Dashboard_Load);
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
    }
}