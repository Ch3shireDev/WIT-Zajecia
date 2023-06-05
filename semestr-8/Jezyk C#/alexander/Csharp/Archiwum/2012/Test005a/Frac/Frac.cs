using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Frac
{
    public partial class Frac : Form
    {
        private bool Go,Draw;
        //*///
        private static int Step = 64;
        /*/
        private static int Step = 128;
        //*///
        delegate void DrawEvent(Bitmap Bmp, int Wmin, int Hmin, int Wsize, int Hsize);
        public Bitmap Big;

        public Frac()
        {
            Go = true;
            Draw = false;
            InitializeComponent();
            EXmin.Text = (0.2016).ToString();
            EYmin.Text = (0.5410).ToString();
            EXmax.Text = (0.2175).ToString();
            EYmax.Text = (0.5521).ToString();

            Work.RunWorkerAsync();
            Draw = true;
        }

        public bool Where(out double Xmin, out double Ymin, out double Xmax, out double Ymax)
        {
            Xmin = Ymin = Xmax = Ymax = 0;
            return
            (
                Double.TryParse(EXmin.Text, out Xmin)
                &&
                Double.TryParse(EYmin.Text, out Ymin)
                &&
                Double.TryParse(EXmax.Text, out Xmax)
                &&
                Double.TryParse(EYmax.Text, out Ymax)
                &&
                (Xmin < Xmax)
                &&
                (Ymin < Ymax)
            );
        }

        public void DrawBitmap(Bitmap bmp, int Wmin, int Hmin, int Wsize, int Hsize)
        {
            Bitmap Big = new Bitmap(Pic.Width, Pic.Height);
            Graphics g = Graphics.FromImage(Big);
            if (Pic.Image != null) g.DrawImage(Pic.Image, 0, 0);
            g.DrawImage(bmp, Wmin, Hmin);
            Pic.Image = Big;
        }

        public void ThDrawBitmap(Bitmap Bmp, int Wmin, int Hmin, int Wsize, int Hsize)
        {
            DrawEvent call = new DrawEvent(DrawBitmap);
            Object[] param = new Object[] { Bmp, Wmin, Hmin, Wsize, Hsize };
            Invoke(call,param);
        }

        private void Work_DoWork(object sender, DoWorkEventArgs e)
        {
            while(Go)
            {
                if (Draw)
                {
                    Draw = false;
                    int W = Pic.Width, H = Pic.Height;
                    double Xmin, Ymin, Xmax, Ymax;

                    if (Where(out Xmin, out Ymin, out Xmax, out Ymax))
                    {
                        int JobSize=((W+Step-1)/Step)*((H+Step-1)/Step), JobCount=0;
                        Job[] JobLst = new Job[JobSize];

                        Bitmap bmp = new Bitmap(Step, Step);
                        Task tsk = new Task(Xmin, Ymin, (Xmax - Xmin) / W, (Ymax - Ymin) / H);
                        for (int Hmin = 0; Hmin < H; Hmin += Step)
                        {
                            int Hmax = Math.Min(Hmin + Step, H);
                            int Hsize = Hmax - Hmin;
                            for (int Wmin = 0; Wmin < W; Wmin += Step)
                            {
                                int Wmax = Math.Min(Wmin + Step, W);
                                int Wsize = Wmax - Wmin;
                                Job job = new Job(tsk, Wmin, Hmin, Wmax, Hmax);
                                JobLst[JobCount++] = job;
                                job.run();
                                if (Draw) break;
                            }
                            if (Draw) break;
                        }
                        while(JobCount>0)
                        {
                            if (Draw) break;
                            for (int p = 0; p < JobSize; ++p)
                            {
                                if (JobLst[p] != null)
                                {
                                    if (JobLst[p].Done)
                                    {
                                        ThDrawBitmap(JobLst[p].bmp, JobLst[p].Wmin, JobLst[p].Hmin, JobLst[p].Wsize, JobLst[p].Hsize);
                                        JobLst[p] = null;
                                        --JobCount;
                                    }
                                }
                            }
                        }
                    }
                }
                else Thread.Sleep(5);
            }
        }

        private void Work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ;
        }

        private void Frac_FormClosing(object sender, FormClosingEventArgs e)
        {
            Draw = false;
            Go = false;
        }

        private void Frac_Resize(object sender, EventArgs e)
        {
            Draw = true;
        }

        private void EVal_TextChanged(object sender, EventArgs e)
        {
            Draw = true;
        }

        private void Pic_Click(object sender, EventArgs e)
        {

        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 1) && ((Control.ModifierKeys & Keys.Control) == Keys.Control))
            {
                
            }
            else if ((e.Button == MouseButtons.Left) && (e.Clicks == 2))
            {
                double Xmin, Ymin, Xmax, Ymax;
                if (Where(out Xmin, out Ymin, out Xmax, out Ymax))
                {
                    EXmin.Text = (0.8 * Xmin + 0.2 * Xmax).ToString();
                    EXmax.Text = (0.8 * Xmax + 0.2 * Xmin ).ToString();
                    EYmin.Text = (0.8 * Ymin + 0.2 * Ymax).ToString();
                    EYmax.Text = (0.8 * Ymax + 0.2 * Ymin).ToString();
                }
            }
            else if ((e.Button == MouseButtons.Right) && (e.Clicks == 2))
            {
                double Xmin, Ymin, Xmax, Ymax;
                if (Where(out Xmin, out Ymin, out Xmax, out Ymax))
                {
                    EXmin.Text = (1.2 * Xmin - 0.2 * Xmax).ToString();
                    EXmax.Text = (1.2 * Xmax - 0.2 * Xmin).ToString();
                    EYmin.Text = (1.2 * Ymin - 0.2 * Ymax).ToString();
                    EYmax.Text = (1.2 * Ymax - 0.2 * Ymin).ToString();
                }
            }
        }
    }

    public class Job
    {
        public int Wmin, Hmin, Wmax, Hmax, Wsize, Hsize;
        private Task tsk;
        private Thread th;
        public Bitmap bmp;
        public bool Done;
        
        #region Table of Colors
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

        public Job(Task tsk,int Wmin, int Hmin, int Wmax, int Hmax)
        {
            this.tsk = tsk;
            this.Wmin = Wmin;
            this.Hmin = Hmin;
            this.Wmax = Wmax;
            this.Hmax = Hmax;
            Wsize = Wmax - Wmin;
            Hsize = Hmax - Hmin;
            bmp = null;
            //bmp = new Bitmap(Wsize,Hsize);
            th = new Thread(new ThreadStart(calc));
            th.Priority = ThreadPriority.BelowNormal;
            Done = false;
        }

        private void calc()
        {
//*///
            while (bmp == null)
            {
                TcpClient Cln = new TcpClient("localhost", 8002);
                Cln.ReceiveTimeout = 100;
                Stream str = new NetworkStream(Cln.Client, FileAccess.ReadWrite, true);
                BinaryReader rd = new BinaryReader(str, Encoding.UTF8);
                BinaryWriter wr = new BinaryWriter(str, Encoding.UTF8);
                wr.Write(tsk.Xmin);
                wr.Write(tsk.Ymin);
                wr.Write(tsk.Xscale);
                wr.Write(tsk.Yscale);
                wr.Write(Wmin);
                wr.Write(Hmin);
                wr.Write(Wmax);
                wr.Write(Hmax);
                try
                {
                    while (true)
                    {
                        if (Cln.Client.Poll(5, SelectMode.SelectRead))
                        {
                            if (Cln.Available > 0)
                            {
                                int len = rd.ReadInt32();
                                byte[] buf = new byte[len];
                                rd.Read(buf, 0, len);
                                int nel = rd.ReadInt32();
                                MemoryStream ms = new MemoryStream(buf);
                                bmp = new Bitmap(ms);
                                if (len != nel) bmp = null;
                                break;
                            }
                            else break;
                        }
                    }
                }
                catch (Exception e)
                {
                }
                Cln.Close();
            }
         

/*/
            byte[] val = tsk.calc(Wmin, Hmin, Wmax, Hmax);
            for (int y = 0, p = 0; y < Hsize; ++y)
            {
                for (int x = 0; x < Wsize; ++x, ++p)
                {
                    bmp.SetPixel(x, y, Theme[val[p]]);
                }
            }
//*///
            Done = true;
        }

        public void run()
        {
            th.Start();
        }
    }

    public class Task
    {
        public double Xmin, Ymin, Xscale, Yscale;
        

        public Task(double Xmin, double Ymin, double Xscale, double Yscale)
        {
            this.Xmin = Xmin;
            this.Ymin = Ymin;
            this.Xscale = Xscale;
            this.Yscale = Yscale;
        }

        public byte[] calc(int Wmin, int Hmin, int Wmax, int Hmax)
        {
            int Wsize = Wmax - Wmin;
            int Hsize = Hmax - Hmin;
            byte[] val = new byte[Wsize * Hsize];
            for (int h = Hmin, p = 0; h < Hmax; ++h)
            {
                double Ci = Ymin + h * Yscale;
                for (int w = Wmin; w < Wmax; ++w, ++p)
                {
                    double Cr = Xmin + w * Xscale;
                    byte i = 0;
                    for (double Zr = 0, Zi = 0; i < 255; ++i)
                    {
                        double Tmp = Zr * Zr - Zi * Zi + Cr;
                        Zi = 2 * Zr * Zi + Ci;
                        Zr = Tmp;
                        if (Zr * Zr + Zi * Zi >= 4) break;
                    }
                    val[p] = i;
                }
            }
            return val;
        }
    }
}