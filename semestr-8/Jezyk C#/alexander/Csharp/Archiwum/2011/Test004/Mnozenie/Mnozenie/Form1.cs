using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Mnozenie
{
    public partial class Product : Form
    {
        public static Random rnd = new Random();
        public double[,] A;
        public double[,] B;
        public double[,] C;
        public int Mid, Row, Col;


        public Product()
        {
            InitializeComponent();
            ThreadPool.SetMaxThreads(400,0);
            ThreadPool.SetMinThreads(400,0);
        }

        private void BtnRunT_Click(object sender, EventArgs e)
        {
            BtnRunT.Enabled = false;
            Stopwatch stop = new Stopwatch();
            stop.Start();
            new Prod(this);
            TimeT.Text=stop.ElapsedMilliseconds.ToString();
            BtnRunT.Enabled = true;

        }

        private void BtnRunN_Click(object sender, EventArgs e)
        {
            BtnRunN.Enabled = false;
            Stopwatch stop = new Stopwatch();
            stop.Start();
            for (int y = 0; y < Row; ++y)
            {
                for (int x = 0; x < Col; ++x)
                {
                    double suma = 0;
                    for (int i = 0; i < Mid; ++i) suma += A[y, i] * B[i, x];
                    C[y,x] = suma;
                    Thread.Sleep(2);
                }
            }

            TimeN.Text = stop.ElapsedMilliseconds.ToString();
            BtnRunN.Enabled = true;

        }

        private void Generator_Click(object sender, EventArgs e)
        {
            Mid = rnd.Next(30000, 30001);
            Row = rnd.Next(19, 20);
            Col = rnd.Next(19, 20);
            A = new double[Row, Mid];
            B = new double[Mid, Col];
            C = new double[Row, Col];
            for (int y = 0; y < Row; ++y) for (int x = 0; x < Mid; ++x) A[y, x] = 10 * rnd.NextDouble();
            for (int y = 0; y < Mid; ++y) for (int x = 0; x < Col; ++x) B[y, x] = 10 * rnd.NextDouble();
        }
    }

    public class Prod
    {
        private int Count;
        Product pr;

        public Prod(Product pr)
        {
            this.pr = pr;
            Count = pr.Row * pr.Col;
            for (int y = 0; y < pr.Row; ++y)
            {
                for (int x = 0; x < pr.Col; ++x)
                {
                    ThreadPool.QueueUserWorkItem(this.Work, new Point(x, y));
                }
            }
            while (Count > 0) Thread.Sleep(0);
        }

        public void Work(Object param)
        {
            Point p = (Point)param;
            double suma=0;
            for (int i = 0; i < pr.Mid; ++i) suma += pr.A[p.Y, i] * pr.B[i, p.X];
            pr.C[p.Y, p.X] = suma;
            Thread.Sleep(2);
            //lock (this) { --Count; }
            Interlocked.Decrement(ref Count);
        }

    }

}