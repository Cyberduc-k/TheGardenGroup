namespace View
{
    partial class Login
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
            this.lbl_Inloggen = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.lbl_WrongCredentials = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.input_Email = new System.Windows.Forms.TextBox();
            this.input_Password = new System.Windows.Forms.TextBox();
            this.pnl_NewAccount = new System.Windows.Forms.Panel();
            this.lbl_New = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnl_Login.SuspendLayout();
            this.pnl_NewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::View.Properties.Resources.GGLogoTM;
            this.logo.Location = new System.Drawing.Point(571, 49);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 138);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // lbl_Inloggen
            // 
            this.lbl_Inloggen.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Inloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lbl_Inloggen.Location = new System.Drawing.Point(587, 213);
            this.lbl_Inloggen.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Inloggen.Name = "lbl_Inloggen";
            this.lbl_Inloggen.Size = new System.Drawing.Size(106, 31);
            this.lbl_Inloggen.TabIndex = 1;
            this.lbl_Inloggen.Text = "Inloggen";
            this.lbl_Inloggen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_Login.Controls.Add(this.lbl_WrongCredentials);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.lbl_Email);
            this.pnl_Login.Controls.Add(this.input_Email);
            this.pnl_Login.Controls.Add(this.input_Password);
            this.pnl_Login.Location = new System.Drawing.Point(517, 271);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(246, 226);
            this.pnl_Login.TabIndex = 2;
            // 
            // lbl_WrongCredentials
            // 
            this.lbl_WrongCredentials.AutoSize = true;
            this.lbl_WrongCredentials.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_WrongCredentials.ForeColor = System.Drawing.Color.Red;
            this.lbl_WrongCredentials.Location = new System.Drawing.Point(25, 158);
            this.lbl_WrongCredentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WrongCredentials.Name = "lbl_WrongCredentials";
            this.lbl_WrongCredentials.Size = new System.Drawing.Size(163, 12);
            this.lbl_WrongCredentials.TabIndex = 5;
            this.lbl_WrongCredentials.Text = "Verkeerd email adres of wachtwoord";
            this.lbl_WrongCredentials.Visible = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_Login.Enabled = false;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(35)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(25, 176);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(196, 27);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Inloggen";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Clicked);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(25, 99);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(81, 17);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Wachtwoord";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(25, 22);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(76, 17);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email adres";
            // 
            // input_Email
            // 
            this.input_Email.BackColor = System.Drawing.Color.White;
            this.input_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_Email.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Email.Location = new System.Drawing.Point(25, 45);
            this.input_Email.Margin = new System.Windows.Forms.Padding(0);
            this.input_Email.Name = "input_Email";
            this.input_Email.Size = new System.Drawing.Size(196, 29);
            this.input_Email.TabIndex = 3;
            this.input_Email.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // input_Password
            // 
            this.input_Password.BackColor = System.Drawing.Color.White;
            this.input_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
            this.input_Password.Location = new System.Drawing.Point(25, 122);
            this.input_Password.Margin = new System.Windows.Forms.Padding(0);
            this.input_Password.Name = "input_Password";
            this.input_Password.Size = new System.Drawing.Size(196, 29);
            this.input_Password.TabIndex = 4;
            this.input_Password.UseSystemPasswordChar = true;
            this.input_Password.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // pnl_NewAccount
            // 
            this.pnl_NewAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnl_NewAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_NewAccount.Controls.Add(this.lbl_New);
            this.pnl_NewAccount.Controls.Add(this.btn_New);
            this.pnl_NewAccount.Location = new System.Drawing.Point(517, 516);
            this.pnl_NewAccount.Name = "pnl_NewAccount";
            this.pnl_NewAccount.Size = new System.Drawing.Size(246, 39);
            this.pnl_NewAccount.TabIndex = 5;
            // 
            // lbl_New
            // 
            this.lbl_New.AutoSize = true;
            this.lbl_New.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_New.Location = new System.Drawing.Point(34, 10);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Size = new System.Drawing.Size(50, 17);
            this.lbl_New.TabIndex = 0;
            this.lbl_New.Text = "Nieuw?";
            // 
            // btn_New
            // 
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btn_New.Location = new System.Drawing.Point(79, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(135, 25);
            this.btn_New.TabIndex = 6;
            this.btn_New.Text = "Maak een account";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Clicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_NewAccount);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.lbl_Inloggen);
            this.Controls.Add(this.logo);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.pnl_NewAccount.ResumeLayout(false);
            this.pnl_NewAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl_Inloggen;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Panel pnl_NewAccount;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox input_Email;
        private System.Windows.Forms.TextBox input_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_New;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label lbl_WrongCredentials;
    }
}