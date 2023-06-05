using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbroat
{
    delegate ThreadData getNextJobProc();
    delegate void setResultProc(ThreadData data);

    public partial class MandelbroatForm : Form
    {
        int sizey, sizex, midy, midx;
        double dy, dx, zoom;
        bool goodParams,blockRecalc;
        List<ThreadData> job;
        Bitmap bmp;

        public MandelbroatForm()
        {
            InitializeComponent();
            job = new List<ThreadData>();
            recalc();
        }

        private void loadParams()
        {
            sizey = Box.Height;
            sizex = Box.Width;
            midy = sizey >> 1;
            midx = sizex >> 1;
            goodParams = false;
            if (!double.TryParse(txtPtY.Text, out dy)) return;
            if (!double.TryParse(txtPtX.Text, out dx)) return;
            if (!double.TryParse(txtZoom.Text, out zoom)) return;
            if(zoom<=0) return;
            zoom = 1 / zoom;
            bmp = new Bitmap(sizex, sizey);
            goodParams = true;
        }

        private ThreadData getNextJob()
        {
            lock(job)
            {
                int size = job.Count;
                if (size <= 0) return null;
                ThreadData ret = job[size - 1];
                job.Remove(ret);
                return ret;
            }
        }

        private void setResult(ThreadData data)
        {
            if (InvokeRequired)
            {
                Invoke(new setResultProc(setResult), data);
                return;
            }
            lock(bmp)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(data.getBmp, data.getX, data.getY);
                }
                Box.Image = bmp;
            }
        }

        private double rescaleY(int y)
        {
            return dy + zoom * (midy - y);
        }

        private double rescaleX(int x)
        {
            return dx + zoom * (x - midx);
        }

        private void recalc()
        {
            if(blockRecalc) return;
            loadParams();
            if (!goodParams) return;
            for (int y = 0; y < sizey; y+=128)
            {
                double py = rescaleY(y);
                for (int x = 0; x < sizex; x+=128)
                {
                    double px = rescaleX(x);
                    lock(job)
                    {
                        job.Add(new ThreadData(px, py, zoom, x, y));
                    }
                }
            }
            for (int t = 0; t < 4; ++t) new CalcThread(getNextJob, setResult);

            /*
            Color[,] arr = new Color[sizey,sizex];
            for (int y = 0; y < sizey; ++y)
            {
                double py = rescaleY(y);
                for (int x = 0; x < sizex; ++x)
                {
                    double px = rescaleX(x);
                    arr[y, x] = Theme[MandelbrotCalc(py, px)];
                }
            }
            Box.Image = ArrToBmp(arr);
            */
        }

        private void redrawNeed(object sender, EventArgs e)
        {
            recalc();
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            if (!goodParams) return;
            double y = rescaleY(e.Y), x = rescaleX(e.X);
            blockRecalc = true;
            txtPtY.Text = y.ToString();
            txtPtX.Text = x.ToString();
            if (e.Button == MouseButtons.Left)
            {
                txtZoom.Text = (2 / zoom).ToString();
            }
            else if(e.Button == MouseButtons.Right)
            {
                txtZoom.Text = (0.5 / zoom).ToString();
            }
            blockRecalc = false;
            recalc();
        }
    }

    class ThreadData
    {
        private double px, py, zoom;
        private int sx, sy;
        private Bitmap bmp;
        public ThreadData(double px, double py, double zoom, int sx, int sy)
        {
            this.px = px;
            this.py = py;
            this.zoom = zoom;
            this.sx = sx;
            this.sy = sy;
            bmp = new Bitmap(128, 128);
        }
        private double rescaleY(int y)
        {
            return py - zoom * y;
        }
        private double rescaleX(int x)
        {
            return px + zoom * x;
        }
        public void Calculate()
        {
            Color[,] arr = new Color[128, 128];
            for (int y = 0; y < 128; ++y)
            {
                double py = rescaleY(y);
                for (int x = 0; x < 128; ++x)
                {
                    double px = rescaleX(x);
                    arr[y, x] = MandelbroatForm.Theme[MandelbroatForm.MandelbrotCalc(py, px)];
                }
            }
            bmp = MandelbroatForm.ArrToBmp(arr);
        }
        public int getX { get { return sx; } }
        public int getY { get { return sy; } }
        public Bitmap getBmp { get { return bmp; } }
    }
    class CalcThread
    {
        private getNextJobProc getJob;
        private setResultProc setResult;
        private Thread th;
        public CalcThread(getNextJobProc getJob, setResultProc setResult)
        {
            this.getJob = getJob;
            this.setResult = setResult;
            th = new Thread(Work);
            th.Start();
        }
        private void Work()
        {
            while(true)
            {
                ThreadData data = getJob();
                if (data == null) return;
                data.Calculate();
                setResult(data);
            }
        }
    }
}
