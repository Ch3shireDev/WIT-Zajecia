using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SumOf
{
    partial class ProgressBarText : System.Windows.Forms.ProgressBar
    {
        public override String Text
        {
            get { return base.Text; }
            set { base.Text = value; } 
        }

        public ProgressBarText()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Rectangle rect = ClientRectangle;
            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (this.Value > 0)
            {
                Rectangle clip = new Rectangle
                (
                    rect.X, 
                    rect.Y,
                    (int)Math.Round((float)rect.Width * Value / Maximum), 
                    rect.Height                   
                );
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            base.OnPaint(pe);
            using (Font f = new Font(FontFamily.GenericSerif, 10,FontStyle.Bold))
            {
                SizeF size = g.MeasureString(Text, f);
                Point location = new Point
                (
                    (int)(rect.Width - size.Width - 2),
                    (int)(rect.Bottom - size.Height / 2 - 5)
                );
                g.DrawString(Text, f, Brushes.Red, location);
            }
        }
    }
}
