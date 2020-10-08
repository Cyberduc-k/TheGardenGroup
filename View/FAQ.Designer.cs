namespace View
{
    partial class FAQ
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
            this.treeView_FAQ = new System.Windows.Forms.TreeView();
            this.lbl_FAQ = new System.Windows.Forms.Label();
            this.FAQ_comboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView_FAQ
            // 
            this.treeView_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_FAQ.Location = new System.Drawing.Point(109, 139);
            this.treeView_FAQ.Name = "treeView_FAQ";
            this.treeView_FAQ.Size = new System.Drawing.Size(344, 261);
            this.treeView_FAQ.TabIndex = 0;
            // 
            // lbl_FAQ
            // 
            this.lbl_FAQ.AutoSize = true;
            this.lbl_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FAQ.Location = new System.Drawing.Point(103, 48);
            this.lbl_FAQ.Name = "lbl_FAQ";
            this.lbl_FAQ.Size = new System.Drawing.Size(73, 32);
            this.lbl_FAQ.TabIndex = 1;
            this.lbl_FAQ.Text = "FAQ";
            // 
            // FAQ_comboCategory
            // 
            this.FAQ_comboCategory.FormattingEnabled = true;
            this.FAQ_comboCategory.Location = new System.Drawing.Point(109, 97);
            this.FAQ_comboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.FAQ_comboCategory.Name = "FAQ_comboCategory";
            this.FAQ_comboCategory.Size = new System.Drawing.Size(221, 24);
            this.FAQ_comboCategory.TabIndex = 11;
            this.FAQ_comboCategory.SelectedIndexChanged += new System.EventHandler(this.FAQ_comboCategory_SelectedIndexChanged);
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.FAQ_comboCategory);
            this.Controls.Add(this.lbl_FAQ);
            this.Controls.Add(this.treeView_FAQ);
            this.Name = "FAQ";
            this.Text = "FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_FAQ;
        private System.Windows.Forms.Label lbl_FAQ;
        private System.Windows.Forms.ComboBox FAQ_comboCategory;
    }
}