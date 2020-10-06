using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class BorderedTextBox : Panel
    {
        public TextBox TextBox;
        public Color BorderColor = Color.Gray;

        public BorderedTextBox()
        {
            DoubleBuffered = true;
            Padding = new Padding(2);

            TextBox = new TextBox();
            TextBox.AutoSize = false;
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Dock = DockStyle.Fill;
            TextBox.Enter += new EventHandler(TextBox_Refresh);
            TextBox.Leave += new EventHandler(TextBox_Refresh);
            TextBox.Resize += new EventHandler(TextBox_Refresh);
            Controls.Add(TextBox);
        }

        private void TextBox_Refresh(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Window);
            using (Pen borderPen = new Pen(BorderColor))
            {
                e.Graphics.DrawRectangle(borderPen,
                    new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
            base.OnPaint(e);
        }
    }
}
