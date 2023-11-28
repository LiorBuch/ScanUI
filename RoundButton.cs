using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace SchemaUIWF
{
    [ToolboxItem(true)]
    public class RoundButton : Button
    {
        public bool allowHover = true;

        public RoundButton()
        {
            this.BackColor = Color.Green;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.Black;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.Red;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Green;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            GraphicsPath path = new GraphicsPath();
            SolidBrush brush = new SolidBrush(BackColor);
            Pen pen = new Pen(ForeColor, 2);

            path.AddEllipse(ClientRectangle);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillEllipse(brush, ClientRectangle);
            g.DrawEllipse(pen, ClientRectangle);

        }
    }
}
