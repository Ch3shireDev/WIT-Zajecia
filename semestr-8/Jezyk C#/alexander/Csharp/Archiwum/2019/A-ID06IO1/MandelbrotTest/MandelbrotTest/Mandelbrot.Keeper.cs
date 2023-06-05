using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MandelbrotTest
{
    class MandelbrotKeeper
    {
        private readonly int PartSize = 128;
        private double zoom, mult;
        private int width, height;
        public MandelbrotKeeper(double startIm, double startRe, double zoom, int width, int height)
        {
            this.zoom = zoom;
            StartIm = startIm;
            StartRe = startRe;
            SetSize(width, height);
        }
        public double StartIm { get; set; }
        public double StartRe { get; set; }
        public double Mult { get { return mult; } }
        public double Zoom { get { return zoom; } set { zoom = value; Recalc(); } }
        public int Height { get { return height; } }
        public int Width { get { return width; } }
        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
            Recalc();
        }
        private void Recalc() { mult = 3 * zoom / Width; }
        public double DeltaIm(int y) { return -Mult * y; }
        public double DeltaRe(int x) { return +Mult * x; }
        public double CalcIm(int y) { return StartIm + DeltaIm(y); }
        public double CalcRe(int x) { return StartRe + DeltaRe(x); }
        public void OneThreadBitmap(PaintPartProc proc)
        {
            Color[,] arr = new Color[Height, Width];
            for (int y = 0; y < Height; ++y)
            {
                double Im = CalcIm(y);
                for (int x = 0; x < Width; ++x)
                {
                    double Re = CalcRe(x);
                    Mandelbrot.Calc(ref arr[y, x], Im, Re);
                }
            }
            proc(Mandelbrot.ArrToBmp(arr));
        }
        private class ThreadData
        {
            private Bitmap big;
            private Graphics gr;
            private PaintPartProc proc;
            private MandelbrotKeeper keeper;
            private int col, row;
            public ThreadData(MandelbrotKeeper keeper,int col, int row, Bitmap big, Graphics gr, PaintPartProc proc)
            {
                this.keeper = keeper;
                this.col = col;
                this.row = row;
                this.big = big;
                this.gr = gr;
                this.proc = proc;
            }
            public void Run()
            {
                Bitmap small = keeper.SmallBitmap(col,row);
                lock (big)
                {
                    gr.DrawImage(small, col, row);
                }
                proc(big);
            }
        }
        private class SmallThread : ThreadData
        {
            private Thread th;
            public SmallThread(MandelbrotKeeper keeper, int col, int row, Bitmap big, Graphics gr, PaintPartProc proc):
                base(keeper, col, row, big, gr, proc)
            {
                th = new Thread(Run);
            }
            public void Start() { th.Start(); }
        }
        public Bitmap SmallBitmap(int col,int row)
        {
            Color[,] arr = new Color[PartSize, PartSize];
            for (int y = 0; y < PartSize; ++y)
            {
                double Im = CalcIm(row + y);
                for (int x = 0; x < PartSize; ++x)
                {
                    double Re = CalcRe(col + x);
                    Mandelbrot.Calc(ref arr[y, x], Im, Re);
                }
            }
            return Mandelbrot.ArrToBmp(arr);
        }
        public void MultiThreadBitmap(PaintPartProc proc)
        {
            Bitmap big = new Bitmap(Width, Height);
            Graphics gr = Graphics.FromImage(big);
            gr.FillRectangle(Brushes.Azure, 0, 0, Width, Height);
            proc(big);
            for (int row = 0; row < Height; row+=PartSize)
            {
                for (int col = 0; col < Width; col += PartSize)
                {
                    new SmallThread(this, col, row, big, gr, proc).Start();
                }
            }
        }
        private void WaitCallback(object state)
        {
            (state as ThreadData).Run();
        }
        public void ThreadPoolBitmap(PaintPartProc proc)
        {
            Bitmap big = new Bitmap(Width, Height);
            Graphics gr = Graphics.FromImage(big);
            gr.FillRectangle(Brushes.Azure, 0, 0, Width, Height);
            proc(big);
            for (int row = 0; row < Height; row += PartSize)
            {
                for (int col = 0; col < Width; col += PartSize)
                {
                    ThreadPool.QueueUserWorkItem(WaitCallback, new ThreadData(this, col, row, big, gr, proc));
                }
            }
        }
    }
}
