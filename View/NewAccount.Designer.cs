namespace View
{
    partial class NewAccount
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl_MakeAccount = new System.Windows.Forms.Label();
            this.pnl_MakeAccount1 = new System.Windows.Forms.Panel();
            this.lbl_Job = new System.Windows.Forms.Label();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnl_MakeAccount1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::View.Properties.Resources.GGLogoTM;
            this.logo.Location = new System.Drawing.Point(571, 49);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 138);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // lbl_MakeAccount
            // 
            this.lbl_MakeAccount.AutoSize = true;
            this.lbl_MakeAccount.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_MakeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_MakeAccount.Location = new System.Drawing.Point(540, 213);
            this.lbl_MakeAccount.Name = "lbl_MakeAccount";
            this.lbl_MakeAccount.Size = new System.Drawing.Size(200, 31);
            this.lbl_MakeAccount.TabIndex = 1;
            this.lbl_MakeAccount.Text = "Maak een account";
            // 
            // pnl_MakeAccount1
            // 
            this.pnl_MakeAccount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_MakeAccount1.Controls.Add(this.btn_Employee);
            this.pnl_MakeAccount1.Controls.Add(this.btn_Customer);
            this.pnl_MakeAccount1.Controls.Add(this.lbl_Job);
            this.pnl_MakeAccount1.Location = new System.Drawing.Point(518, 275);
            this.pnl_MakeAccount1.Name = "pnl_MakeAccount1";
            this.pnl_MakeAccount1.Size = new System.Drawing.Size(245, 153);
            this.pnl_MakeAccount1.TabIndex = 2;
            // 
            // lbl_Job
            // 
            this.lbl_Job.AutoSize = true;
            this.lbl_Job.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Job.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_Job.Location = new System.Drawing.Point(24, 18);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(84, 21);
            this.lbl_Job.TabIndex = 0;
            this.lbl_Job.Text = "Ben je een:";
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(24, 60);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(196, 26);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Klant";
            this.btn_Customer.UseVisualStyleBackColor = false;
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Employee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Location = new System.Drawing.Point(24, 106);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(196, 26);
            this.btn_Employee.TabIndex = 1;
            this.btn_Employee.Text = "Medewerker";
            this.btn_Employee.UseVisualStyleBackColor = false;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_MakeAccount1);
            this.Controls.Add(this.lbl_MakeAccount);
            this.Controls.Add(this.logo);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnl_MakeAccount1.ResumeLayout(false);
            this.pnl_MakeAccount1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl_MakeAccount;
        private System.Windows.Forms.Panel pnl_MakeAccount1;
        private System.Windows.Forms.Label lbl_Job;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Employee;
    }
}