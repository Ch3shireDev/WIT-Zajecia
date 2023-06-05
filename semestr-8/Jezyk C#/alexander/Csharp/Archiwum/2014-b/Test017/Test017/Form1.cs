using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test017
{
    public partial class Form1 : Form
    {
        private TextBox[,] AView, BView, CView;
        private Matrix A, B, C;
        private static TextBox mkBox(int y,int x)
        {
            TextBox mk = new TextBox();
            mk.Text = "0";
            mk.TextAlign = HorizontalAlignment.Right;
            mk.Tag = new Point(x, y);
            return mk;
        }
        public Form1()
        {
            InitializeComponent();
            AView = new TextBox[4, 4];
            BView = new TextBox[4, 4];
            CView = new TextBox[4, 4];
            A = new Matrix();
            B = new Matrix();
            C = new Matrix();
            for (int y = 0; y < 4; ++y)
            {
                for (int x = 0; x < 4; ++x)
                {
                    AView[y, x] = mkBox(y, x);
                    AView[y, x].TextChanged += MatrixAChanged;
                    AView[y, x].TextChanged += Calculate;
                    ATab.Controls.Add(AView[y, x], x, y);

                    BView[y, x] = mkBox(y, x);
                    BView[y, x].TextChanged += MatrixBChanged;
                    BView[y, x].TextChanged += Calculate;
                    BTab.Controls.Add(BView[y, x], x, y);

                    CView[y, x] = mkBox(y, x);
                    CView[y, x].ReadOnly = true;
                    CTab.Controls.Add(CView[y, x], x, y);
                }
            }
            Operation.SelectedIndex = 0;
        }
        private void MatrixAChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Point pt = (Point)tb.Tag;
            double val;
            if(double.TryParse(tb.Text, out val)) A[pt.Y, pt.X]=val;
        }
        private void MatrixBChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Point pt = (Point)tb.Tag;
            double val;
            if (double.TryParse(tb.Text, out val)) B[pt.Y, pt.X] = val;
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (Operation.SelectedIndex == 0) C = A + B;
            else if (Operation.SelectedIndex == 1) C = A - B;
            else if (Operation.SelectedIndex == 2) C = A * B;
            for (int y = 0; y < 4; ++y)
            {
                for (int x = 0; x < 4; ++x)
                {
                    CView[y, x].Text = C[y, x].ToString();
                }
            }
        }
    }
    public class Matrix
    {
        private double[,] tb;
        public Matrix()
        {
            tb = new double[4, 4];
        }
        public double this[int y, int x]
        {
            get { return tb[y, x]; }
            set { tb[y, x] = value; }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix c = new Matrix();
            for (int y = 0; y < 4; ++y)
            {
                for (int x = 0; x < 4; ++x)
                {
                    c[y, x] = a[y, x] + b[y, x];
                }
            }
            return c;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix c = new Matrix();
            for (int y = 0; y < 4; ++y)
            {
                for (int x = 0; x < 4; ++x)
                {
                    c[y, x] = a[y, x] - b[y, x];
                }
            }
            return c;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix c = new Matrix();
            for (int y = 0; y < 4; ++y)
            {
                for (int x = 0; x < 4; ++x)
                {
                    double sum = 0;
                    for (int i = 0; i < 4; ++i) sum += a[y, i] * b[i, x];
                    c[y, x] = sum;
                }
            }
            return c;
        }
    }
}
