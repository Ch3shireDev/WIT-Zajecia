using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Test011
{
    public partial class MandelBrottServer : Form
    {
        private CalculatePart[] calctb = null;
        private Bitmap bmp = null;
        private readonly int MaxThreadCount = 4;

        public MandelBrottServer()
        {
            InitializeComponent();
            EXmin.Text = string.Format("{0:0.############}", 0.2016);
            EYmin.Text = string.Format("{0:0.############}", 0.541);
            EXmax.Text = string.Format("{0:0.############}", 0.2175);
            EYmax.Text = string.Format("{0:0.############}", 0.5521);
            //foreach (TextBox txt in new TextBox[] { EXmin, EXmax, EYmin, EYmax }) SaveValue(txt);
            //foreach (Control txt in Header.Controls) if(txt is TextBox) SaveValue((TextBox)txt);
            //SaveValue(EXmin);
            //SaveValue(EXmax);
            //SaveValue(EYmin);
            //SaveValue(EYmax);
            Box_Resize(null, null);
        }

        private void SaveValue(TextBox txt)
        {
            txt.Tag = new Object[] { txt.Text, txt.SelectionStart, txt.SelectionLength };
        }

        private void LoadValue(TextBox txt)
        {
            Object[] tb = (Object[])txt.Tag;
            txt.Text = (string)(tb[0]);
            txt.SelectionStart = (int)(tb[1]);
            txt.SelectionLength = (int)(tb[2]);
        }

        private void TerminateAll()
        {
            if(calctb!=null)
            {
                for (int i = 0; i < calctb.Length; ++i)
                {
                    if(calctb[i] != null) calctb[i].Abort();
                }
                for (int i = 0; i < calctb.Length; ++i)
                {
                    if (calctb[i] != null) calctb[i].Join();
                }
                calctb = null;
            }
        }

        private void EValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = ((TextBox)sender);
            double v;
            if (double.TryParse(txt.Text, out v))
            {
                Clock.Enabled = false;
                Clock.Enabled = true;
                SaveValue(txt);
            }
            else LoadValue(txt);
        }

        private void EValue_KeySaveAction(object sender, KeyEventArgs e)
        {
            SaveValue(((TextBox)sender));
        }

        private void EValue_MouseSaveAction(object sender, MouseEventArgs e)
        {
            SaveValue(((TextBox)sender));
        }

        private void Box_Resize(object sender, EventArgs e)
        {
            Clock.Enabled = false;
            Clock.Enabled = true;
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            if (bmp != null)
            {
                lock(bmp)
                {
                    e.Graphics.DrawImage(bmp, 0, 0);
                }
            }
        }

        private void MandelBrottServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            TerminateAll();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            Clock.Enabled = false;
            lock (Box)
            {
                if ((Box.Width > 0) && (Box.Height > 0))
                {
                    TerminateAll();
                    bmp = new Bitmap(Box.Width, Box.Height, PixelFormat.Format24bppRgb);
                    int size = bmp.Height < MaxThreadCount ? bmp.Height : MaxThreadCount;
                    calctb = new CalculatePart[size];
                    double Lf = double.Parse(EXmin.Text);
                    double Up = double.Parse(EYmin.Text);
                    double W = double.Parse(EXmax.Text) - Lf;
                    double H = double.Parse(EYmax.Text) - Up;
                    for (int y = 0; y < calctb.Length; ++y)
                    {
                        calctb[y] = new CalculatePart(y, MaxThreadCount, bmp, Box, Lf, Up, W, H);
                    }
                }
            }
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            const double addscale=0.2;
            const double mulscale=1+2*addscale;
            double Lf = double.Parse(EXmin.Text);
            double Up = double.Parse(EYmin.Text);
            double W = double.Parse(EXmax.Text) - Lf;
            double H = double.Parse(EYmax.Text) - Up;
            if (e.Clicks == 1)
            {
                Lf += e.X * W / Box.Width - 0.5 * W;
                Up += e.Y * H / Box.Height - 0.5 * H;
            }
            else if (e.Clicks == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Lf += addscale * W;
                    Up += addscale * H;
                    W /= mulscale;
                    H /= mulscale;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Lf -= addscale * W;
                    Up -= addscale * H;
                    W *= mulscale;
                    H *= mulscale;
                }
            }
            EXmin.Text = string.Format("{0:0.############}", Lf);
            EYmin.Text = string.Format("{0:0.############}", Up);
            EXmax.Text = string.Format("{0:0.############}", Lf + W);
            EYmax.Text = string.Format("{0:0.############}", Up + H);
        }
    }

    internal class CalculatePart
    {
        private int Y, Yadd, bmpW, bmpH;
        private Bitmap bmp;
        private Panel Box;
        private double Lf, Up, W, H;
        private byte[] data;
        private Thread th;

        #region private static Color[] Theme = { ... }
        private static Color[] Theme =
        {
            Color.FromArgb( 255, 0, 0),
            Color.FromArgb( 255, 4, 0),
            Color.FromArgb( 255, 8, 0),
            Color.FromArgb( 255, 12, 0),
            Color.FromArgb( 255, 16, 0),
            Color.FromArgb( 255, 20, 0),
            Color.FromArgb( 255, 24, 0),
            Color.FromArgb( 255, 28, 0),
            Color.FromArgb( 255, 31, 0),
            Color.FromArgb( 255, 35, 0),
            Color.FromArgb( 255, 39, 0),
            Color.FromArgb( 255, 43, 0),
            Color.FromArgb( 255, 47, 0),
            Color.FromArgb( 255, 51, 0),
            Color.FromArgb( 255, 55, 0),
            Color.FromArgb( 255, 59, 0),
            Color.FromArgb( 255, 63, 0),
            Color.FromArgb( 255, 67, 0),
            Color.FromArgb( 255, 71, 0),
            Color.FromArgb( 255, 75, 0),
            Color.FromArgb( 255, 79, 0),
            Color.FromArgb( 255, 83, 0),
            Color.FromArgb( 255, 87, 0),
            Color.FromArgb( 255, 91, 0),
            Color.FromArgb( 255, 94, 0),
            Color.FromArgb( 255, 98, 0),
            Color.FromArgb( 255, 102, 0),
            Color.FromArgb( 255, 106, 0),
            Color.FromArgb( 255, 110, 0),
            Color.FromArgb( 255, 114, 0),
            Color.FromArgb( 255, 118, 0),
            Color.FromArgb( 255, 122, 0),
            Color.FromArgb( 255, 126, 0),
            Color.FromArgb( 255, 130, 0),
            Color.FromArgb( 255, 133, 0),
            Color.FromArgb( 255, 137, 0),
            Color.FromArgb( 255, 141, 0),
            Color.FromArgb( 255, 145, 0),
            Color.FromArgb( 255, 149, 0),
            Color.FromArgb( 255, 153, 0),
            Color.FromArgb( 255, 157, 0),
            Color.FromArgb( 255, 161, 0),
            Color.FromArgb( 255, 255, 0),
            Color.FromArgb( 255, 167, 0),
            Color.FromArgb( 255, 170, 0),
            Color.FromArgb( 255, 172, 0),
            Color.FromArgb( 255, 174, 0),
            Color.FromArgb( 255, 176, 0),
            Color.FromArgb( 255, 178, 0),
            Color.FromArgb( 255, 180, 0),
            Color.FromArgb( 255, 182, 0),
            Color.FromArgb( 255, 185, 0),
            Color.FromArgb( 255, 187, 0),
            Color.FromArgb( 255, 189, 0),
            Color.FromArgb( 255, 191, 0),
            Color.FromArgb( 255, 193, 0),
            Color.FromArgb( 255, 195, 0),
            Color.FromArgb( 255, 197, 0),
            Color.FromArgb( 255, 199, 0),
            Color.FromArgb( 255, 201, 0),
            Color.FromArgb( 255, 203, 0),
            Color.FromArgb( 255, 205, 0),
            Color.FromArgb( 255, 208, 0),
            Color.FromArgb( 255, 210, 0),
            Color.FromArgb( 255, 212, 0),
            Color.FromArgb( 255, 215, 0),
            Color.FromArgb( 255, 217, 0),
            Color.FromArgb( 255, 219, 0),
            Color.FromArgb( 255, 221, 0),
            Color.FromArgb( 255, 223, 0),
            Color.FromArgb( 255, 225, 0),
            Color.FromArgb( 255, 227, 0),
            Color.FromArgb( 255, 230, 0),
            Color.FromArgb( 255, 232, 0),
            Color.FromArgb( 255, 234, 0),
            Color.FromArgb( 255, 236, 0),
            Color.FromArgb( 255, 238, 0),
            Color.FromArgb( 255, 240, 0),
            Color.FromArgb( 255, 242, 0),
            Color.FromArgb( 255, 244, 0),
            Color.FromArgb( 255, 246, 0),
            Color.FromArgb( 255, 248, 0),
            Color.FromArgb( 255, 250, 0),
            Color.FromArgb( 255, 253, 0),
            Color.FromArgb( 0, 128, 0),
            Color.FromArgb( 249, 252, 0),
            Color.FromArgb( 243, 249, 0),
            Color.FromArgb( 237, 246, 0),
            Color.FromArgb( 231, 243, 0),
            Color.FromArgb( 225, 240, 0),
            Color.FromArgb( 218, 237, 0),
            Color.FromArgb( 212, 234, 0),
            Color.FromArgb( 206, 231, 0),
            Color.FromArgb( 200, 228, 0),
            Color.FromArgb( 194, 225, 0),
            Color.FromArgb( 188, 222, 0),
            Color.FromArgb( 182, 218, 0),
            Color.FromArgb( 176, 215, 0),
            Color.FromArgb( 170, 212, 0),
            Color.FromArgb( 164, 209, 0),
            Color.FromArgb( 158, 206, 0),
            Color.FromArgb( 151, 203, 0),
            Color.FromArgb( 145, 200, 0),
            Color.FromArgb( 139, 197, 0),
            Color.FromArgb( 134, 195, 0),
            Color.FromArgb( 128, 192, 0),
            Color.FromArgb( 122, 189, 0),
            Color.FromArgb( 116, 186, 0),
            Color.FromArgb( 110, 183, 0),
            Color.FromArgb( 104, 180, 0),
            Color.FromArgb( 98, 177, 0),
            Color.FromArgb( 91, 174, 0),
            Color.FromArgb( 85, 171, 0),
            Color.FromArgb( 79, 168, 0),
            Color.FromArgb( 73, 165, 0),
            Color.FromArgb( 67, 162, 0),
            Color.FromArgb( 61, 159, 0),
            Color.FromArgb( 55, 155, 0),
            Color.FromArgb( 49, 152, 0),
            Color.FromArgb( 43, 149, 0),
            Color.FromArgb( 37, 146, 0),
            Color.FromArgb( 31, 143, 0),
            Color.FromArgb( 24, 140, 0),
            Color.FromArgb( 18, 137, 0),
            Color.FromArgb( 12, 134, 0),
            Color.FromArgb( 6, 131, 0),
            Color.FromArgb( 0, 0, 255),
            Color.FromArgb( 0, 125, 6),
            Color.FromArgb( 0, 122, 12),
            Color.FromArgb( 0, 119, 18),
            Color.FromArgb( 0, 116, 24),
            Color.FromArgb( 0, 113, 30),
            Color.FromArgb( 0, 110, 37),
            Color.FromArgb( 0, 107, 43),
            Color.FromArgb( 0, 104, 49),
            Color.FromArgb( 0, 101, 55),
            Color.FromArgb( 0, 98, 61),
            Color.FromArgb( 0, 95, 67),
            Color.FromArgb( 0, 91, 73),
            Color.FromArgb( 0, 88, 79),
            Color.FromArgb( 0, 85, 85),
            Color.FromArgb( 0, 82, 91),
            Color.FromArgb( 0, 79, 98),
            Color.FromArgb( 0, 76, 104),
            Color.FromArgb( 0, 73, 110),
            Color.FromArgb( 0, 70, 116),
            Color.FromArgb( 0, 67, 122),
            Color.FromArgb( 0, 64, 128),
            Color.FromArgb( 0, 61, 134),
            Color.FromArgb( 0, 58, 139),
            Color.FromArgb( 0, 55, 145),
            Color.FromArgb( 0, 52, 151),
            Color.FromArgb( 0, 49, 157),
            Color.FromArgb( 0, 46, 164),
            Color.FromArgb( 0, 43, 170),
            Color.FromArgb( 0, 40, 176),
            Color.FromArgb( 0, 37, 182),
            Color.FromArgb( 0, 34, 188),
            Color.FromArgb( 0, 31, 194),
            Color.FromArgb( 0, 27, 200),
            Color.FromArgb( 0, 24, 206),
            Color.FromArgb( 0, 21, 212),
            Color.FromArgb( 0, 18, 218),
            Color.FromArgb( 0, 15, 225),
            Color.FromArgb( 0, 12, 231),
            Color.FromArgb( 0, 9, 237),
            Color.FromArgb( 0, 6, 243),
            Color.FromArgb( 0, 3, 249),
            Color.FromArgb( 75, 0, 130),
            Color.FromArgb( 2, 0, 252),
            Color.FromArgb( 4, 0, 249),
            Color.FromArgb( 6, 0, 246),
            Color.FromArgb( 7, 0, 243),
            Color.FromArgb( 9, 0, 240),
            Color.FromArgb( 10, 0, 237),
            Color.FromArgb( 12, 0, 234),
            Color.FromArgb( 14, 0, 232),
            Color.FromArgb( 16, 0, 229),
            Color.FromArgb( 18, 0, 226),
            Color.FromArgb( 20, 0, 223),
            Color.FromArgb( 21, 0, 219),
            Color.FromArgb( 23, 0, 216),
            Color.FromArgb( 25, 0, 213),
            Color.FromArgb( 27, 0, 210),
            Color.FromArgb( 28, 0, 207),
            Color.FromArgb( 30, 0, 204),
            Color.FromArgb( 32, 0, 201),
            Color.FromArgb( 34, 0, 198),
            Color.FromArgb( 36, 0, 196),
            Color.FromArgb( 38, 0, 193),
            Color.FromArgb( 40, 0, 190),
            Color.FromArgb( 41, 0, 187),
            Color.FromArgb( 43, 0, 184),
            Color.FromArgb( 45, 0, 181),
            Color.FromArgb( 47, 0, 178),
            Color.FromArgb( 48, 0, 175),
            Color.FromArgb( 50, 0, 172),
            Color.FromArgb( 52, 0, 169),
            Color.FromArgb( 54, 0, 166),
            Color.FromArgb( 55, 0, 163),
            Color.FromArgb( 57, 0, 160),
            Color.FromArgb( 59, 0, 156),
            Color.FromArgb( 61, 0, 153),
            Color.FromArgb( 63, 0, 151),
            Color.FromArgb( 65, 0, 148),
            Color.FromArgb( 66, 0, 145),
            Color.FromArgb( 68, 0, 142),
            Color.FromArgb( 69, 0, 139),
            Color.FromArgb( 71, 0, 136),
            Color.FromArgb( 73, 0, 133),
            Color.FromArgb( 238, 130, 238),
            Color.FromArgb( 79, 3, 133),
            Color.FromArgb( 83, 6, 135),
            Color.FromArgb( 86, 9, 138),
            Color.FromArgb( 90, 12, 141),
            Color.FromArgb( 94, 15, 143),
            Color.FromArgb( 98, 18, 146),
            Color.FromArgb( 102, 21, 148),
            Color.FromArgb( 106, 24, 150),
            Color.FromArgb( 110, 28, 153),
            Color.FromArgb( 114, 31, 156),
            Color.FromArgb( 118, 35, 158),
            Color.FromArgb( 122, 38, 161),
            Color.FromArgb( 125, 41, 164),
            Color.FromArgb( 129, 44, 166),
            Color.FromArgb( 133, 47, 169),
            Color.FromArgb( 137, 50, 172),
            Color.FromArgb( 141, 53, 174),
            Color.FromArgb( 145, 56, 176),
            Color.FromArgb( 149, 59, 179),
            Color.FromArgb( 153, 62, 181),
            Color.FromArgb( 157, 65, 184),
            Color.FromArgb( 161, 68, 187),
            Color.FromArgb( 165, 71, 189),
            Color.FromArgb( 168, 74, 192),
            Color.FromArgb( 172, 77, 195),
            Color.FromArgb( 176, 80, 197),
            Color.FromArgb( 180, 83, 200),
            Color.FromArgb( 184, 86, 202),
            Color.FromArgb( 187, 89, 204),
            Color.FromArgb( 191, 93, 207),
            Color.FromArgb( 195, 96, 210),
            Color.FromArgb( 199, 100, 212),
            Color.FromArgb( 203, 103, 215),
            Color.FromArgb( 206, 106, 218),
            Color.FromArgb( 211, 109, 220),
            Color.FromArgb( 215, 112, 223),
            Color.FromArgb( 219, 115, 226),
            Color.FromArgb( 223, 118, 228),
            Color.FromArgb( 227, 121, 230),
            Color.FromArgb( 230, 124, 233),
            Color.FromArgb( 234, 127, 235),
            Color.FromArgb( 238, 130, 238),
            Color.FromArgb( 0, 0, 0),
            Color.FromArgb( 0, 0, 0),
            Color.FromArgb( 0, 0, 0),
        };
        #endregion

        public CalculatePart(int Y, int Yadd, Bitmap bmp, Panel Box, double Lf, double Up, double W, double H)
        {
            this.Y = Y;
            this.Yadd = Yadd;
            this.bmp = bmp;
            this.Box = Box;
            this.Lf = Lf;
            this.Up = Up;
            this.W = W;
            this.H = H;
            lock(bmp)
            {
                bmpW = bmp.Width;
                bmpH = bmp.Height;
                BitmapData reg = bmp.LockBits(new Rectangle(0, 0, bmpW, 1), ImageLockMode.ReadOnly, bmp.PixelFormat);
                try
                {
                    data = new byte[reg.Stride];
                }
                finally
                {
                    bmp.UnlockBits(reg);
                }
            }
            th = new Thread(work);
            th.Priority = ThreadPriority.Lowest;
            th.Start();
        }

        public void Abort()
        {
            lock (this) 
            {
                if (th != null)
                {
                    th.Abort();
                }
            }
        }

        public void Join()
        {
            lock (this) 
            {
                if (th != null)
                {
                    th.Join();
                    th = null;
                }
            }
        }

        private void work()
        {
            while (Y < bmpH)
            {
                double DY = Up + Y * H / bmpH;
                int pos = 0;
                for (int x = 0; x < bmpW; ++x)
                {
                    double DX = Lf + x * W / bmpW;
                    int idx = 0;
                    for (double Zr = 0, Zi = 0; (idx < 255) && (Zr * Zr + Zi * Zi < 4); ++idx)
                    {
                        double Tmp = Zr * Zr - Zi * Zi + DX;
                        Zi = 2 * Zr * Zi + DY;
                        Zr = Tmp;
                    }
                    data[pos++] = Theme[idx].B;
                    data[pos++] = Theme[idx].G;
                    data[pos++] = Theme[idx].R;
                }
                Draw(new Rectangle(0, Y, bmpW, 1));
                Y += Yadd;
            }
            th = null;
        }

        private void Draw(Rectangle rect)
        {
            lock (this)
            {
                lock (bmp)
                {
                    BitmapData reg = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);
                    try
                    {
                        //*///
                        Marshal.Copy(data, 0, reg.Scan0, reg.Stride);
                        /*/
                        Marshal.Copy(data, 0, reg.Scan0, data.Length);
                        //*///
                    }
                    finally
                    {
                        bmp.UnlockBits(reg);
                    }
                }
            }
            Box.Invalidate(rect);
        }
    }
}
