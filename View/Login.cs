using Service;
using Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    public partial class Login : Form
    {
        private IServiceProvider provider;

        public Login(IServiceProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }

        private void btn_Login_Clicked(object caller, EventArgs e)
        {
            Console.WriteLine("login");
        }
    }
}

/*
When the designer is opened, visual studio will remove this code on save.
// 
// input_Email
// 
this.input_Email.BorderColor = System.Drawing.Color.FromArgb(78, 90, 98);
this.input_Email.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
this.input_Email.TextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
this.input_Email.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
this.input_Email.Location = new System.Drawing.Point(37, 68);
this.input_Email.Margin = new System.Windows.Forms.Padding(0);
this.input_Email.Name = "input_Email";
this.input_Email.Size = new System.Drawing.Size(294, 43);
this.input_Email.TabIndex = 1;
// 
// input_Password
// 
this.input_Password.BorderColor = System.Drawing.Color.FromArgb(78, 90, 98);
this.input_Password.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
this.input_Password.TextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
this.input_Password.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(98)))));
this.input_Password.Location = new System.Drawing.Point(37, 183);
this.input_Password.Margin = new System.Windows.Forms.Padding(0);
this.input_Password.Name = "input_Email";
this.input_Password.Size = new System.Drawing.Size(294, 43);
this.input_Password.TabIndex = 1;
*/