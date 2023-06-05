using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SpecialLibrary
{
    public class EllipseButton:Button
    {
        private Color _BackColorTo = Color.FromKnownColor(KnownColor.ControlDark);
        private Color _HoverColor = Color.FromKnownColor(KnownColor.ControlLightLight);
        private Color _HoverColorTo = Color.FromKnownColor(KnownColor.ControlDark);
        private uint _GradientStep = 64;
        private Pen pen;
        private SolidBrush brush;
        private bool hover, fade;

        [Category("Appearance"), Description("Gradient koloru tła")]
        public Color BackColorTo
        {
            get { return _BackColorTo; }
            set { _BackColorTo = value; Invalidate(); }
        }

        [Category("Gradient"), Description("Kolor tła kiedy mysza jest na nim")]
        public Color HoverColor
        {
            get { return _HoverColor; }
            set { _HoverColor = value; Invalidate(); }
        }

        [Category("Gradient"), Description("Gradient koloru tła kiedy mysza jest na nim")]
        public Color HoverColorTo
        {
            get { return _HoverColorTo; }
            set { _HoverColorTo = value; Invalidate(); }
        }

        [Category("Gradient"), Description("Ilość kroków gradientu")]
        public uint GradientStep
        {
            get { return _GradientStep; }
            set { _GradientStep = Math.Max(2U, value); Invalidate(); }
        }

        public EllipseButton()
        {
            pen = new Pen(SystemColors.Control, 1);
            brush = new SolidBrush(SystemColors.Control);
            hover = false;
            fade = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath(FillMode.Winding);
            Rectangle R = ClientRectangle;
            --R.Width;
            --R.Height;
            path.AddEllipse(R);

            this.Region = new Region(path);
            DrawIt(e.Graphics);
        }

        protected void DrawIt(Graphics g)
        {
            int W = ClientSize.Width - 1, H = ClientSize.Height - 1;
            Color ClrF, ClrT;
            if (fade) { ClrT = HoverColor; ClrF = HoverColorTo; } // wymiana
            else if (hover) { ClrT = HoverColor; ClrF = HoverColorTo; }
            else { ClrT = BackColor; ClrF = BackColorTo; }
            byte FR = ClrF.R, FG = ClrF.G, FB = ClrF.B, TR = ClrT.R, TG = ClrT.G, TB = ClrT.B;
            for (uint div = _GradientStep - 1, t = 0, f = div; t <= div; ++t, --f)
            {
                Color Clr;
                if ((fade) && (t > f))
                {

                    Clr = Color.FromArgb
                    (
                        (byte)Math.Round((FR * t + TR * f) / (double)div),
                        (byte)Math.Round((FG * t + TG * f) / (double)div),
                        (byte)Math.Round((FB * t + TB * f) / (double)div)
                    );
                }
                else
                {
                    Clr = Color.FromArgb
                    (
                        (byte)Math.Round((FR * f + TR * t) / (double)div),
                        (byte)Math.Round((FG * f + TG * t) / (double)div),
                        (byte)Math.Round((FB * f + TB * t) / (double)div)
                    );
                }

                pen.Color = Clr;
                brush.Color = Clr;
                double size = 1 - 2 * Math.Asin(t / (double)_GradientStep) / Math.PI;
                double pos = t / (3.0 * div);
                int
                    x = (int)Math.Round(W * pos),
                    y = (int)Math.Round(H * pos),
                    w = (int)Math.Round(W * size),
                    h = (int)Math.Round(H * size)
                ;
                if (fade)
                {
                    x = W - w - x;
                    y = H - h - y;
                }
                g.DrawEllipse(pen, x, y, w, h);
                g.FillEllipse(brush, x, y, w, h);
            }
            if (Focused)
            {
                pen.Width = 2;
                pen.Color = SystemColors.ControlDarkDark;
                g.DrawEllipse(pen, 0, 0, W, H);
                pen.Width = 1;
            }
            SizeF s=g.MeasureString(Text, Font);
            W = (int)Math.Round((W - s.Width + 0.5) / 2);
            H = (int)Math.Round((H - s.Height + 0.5) / 2);
            brush.Color = ForeColor;
            g.DrawString(Text, Font, brush, W, H);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            hover = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            hover = false;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            fade = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            fade = false;
            base.OnMouseUp(mevent);
        }
    }
}
