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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Answer 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Question 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView_FAQ = new System.Windows.Forms.TreeView();
            this.lbl_FAQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView_FAQ
            // 
            this.treeView_FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_FAQ.Location = new System.Drawing.Point(109, 112);
            this.treeView_FAQ.Name = "treeView_FAQ";
            treeNode1.Name = "node_A1";
            treeNode1.Text = "Answer 1";
            treeNode2.Name = "node_q1";
            treeNode2.Text = "Question 1";
            this.treeView_FAQ.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView_FAQ.Size = new System.Drawing.Size(344, 288);
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
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
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
    }
}