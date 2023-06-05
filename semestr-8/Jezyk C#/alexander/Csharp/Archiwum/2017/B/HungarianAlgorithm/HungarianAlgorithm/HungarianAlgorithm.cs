using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungarianAlgorithm
{
    class HungarianAlgorithm
    {
        private int size;
        private double[,] tb;
        private int[] rows, cols;
        private bool[] xrows, xcols;
        private double result;

        private double rowMin(int y)
        {
            double val = tb[y, 0];
            for (int x = 1; x < size; ++x) if (val > tb[y, x]) val = tb[y, x];
            return val;
        }
        private double colMin(int x)
        {
            double val = tb[0, x];
            for (int y = 1; y < size; ++y) if (val > tb[y, x]) val = tb[y, x];
            return val;
        }
        private void rowDec(int y, double val)
        {
            for (int x = 0; x < size; ++x) tb[y, x] -= val;
        }
        private void colDec(int x, double val)
        {
            for (int y = 0; y < size; ++y) tb[y, x] -= val;
        }
        private int rowZeros(int y)
        {
            int cnt = 0;
            if (xrows[y])
            {
                for (int x = 0; x < size; ++x) if (tb[y, x] == 0 && xcols[x]) ++cnt;
            }
            return cnt;
        }
        private int colZeros(int x)
        {
            int cnt = 0;
            if (xcols[x])
            {
                for (int y = 0; y < size; ++y) if (tb[y, x] == 0 && xrows[y]) ++cnt;
            }
            return cnt;
        }
        private void resetX()
        {
            for (int y = 0; y < size; ++y) xrows[y] = true;
            for (int x = 0; x < size; ++x) xcols[x] = true;
        }
        private bool independedZero(out int X,out int Y)
        {
            int best = size+1;
            X = Y = -1;
            for (int y = 0; y < size; ++y)
            {
                int rcnt = rowZeros(y);
                for (int x = 0; x < size; ++x)
                {
                    int cnt = Math.Min(rcnt, colZeros(x));
                    if (cnt > 0 && best > cnt)
                    {
                        best = cnt;
                        X = x;
                        Y = y;
                    }
                }
            }
            return best <= size;
        }
        public double findMin()
        {
            double min=0;
            for (int y = 0; y < size; ++y)
            {
                if (xrows[y])
                {
                    for (int x = 0; x < size; ++x)
                    {
                        if (xcols[x])
                        {
                            double val = tb[y, x];
                            if (min == 0 || min > val)
                            {
                                min = val;
                            }
                        }
                    }
                }
            }
            return min;
        }
        private void valIncDec(double val)
        {
            for (int y = 0; y < size; ++y)
            {
                int r = xrows[y] ? 1 : 0;
                for (int x = 0; x < size; ++x)
                {
                    int rc = r + (xcols[x] ? 1 : 0);
                    if (rc == 0) tb[y, x] -= val;
                    else if (rc == 2) tb[y, x] += val;
                }
            }
        }
        public void step2a()
        {
            for (int y = 0; y < size; ++y) rowDec(y, rowMin(y));
        }
        public void step2b()
        {
            for (int x = 0; x < size; ++x) colDec(x, colMin(x));
        }
        public int step3()
        {
            resetX();
            int cnt = 0;
            for (int i = 0; i < size; ++i)
            {
                int x, y;
                if (!independedZero(out x, out y)) break;
                xrows[y] = xcols[x] = false;
                rows[y] = x;
                cols[x] = y;
                ++cnt;
            }
            return cnt;
        }
        public void step4()
        {
            valIncDec(findMin());
        }
        public double SetData(double[,] Tb)
        {
            size = Tb.GetLength(0);
            if (size != Tb.GetLength(1)) throw new ArgumentException("Tb");
            rows = new int[size];
            cols = new int[size];
            xrows = new bool[size];
            xcols = new bool[size];
            tb = Tb.Clone() as double[,];
            step2a();
MessageBox.Show("2a:\n"+MatToStr(tb));
            step2b();
MessageBox.Show("2b:\n" + MatToStr(tb));
            while (step3() != size)
            {
MessageBox.Show("3:\n" + MatToStr(tb));
                step4();
MessageBox.Show("4:\n" + MatToStr(tb));
            }
            result = 0;
            for (int y = 0; y < size; ++y) result += Tb[y, rows[y]];
            return Result();
        }
        public int[] Rows()
        {
            return rows;
        }
        public int[] Cols()
        {
            return cols;
        }
        public double Result()
        {
            return result;
        }
        public HungarianAlgorithm(double[,] Tb)
        {
            SetData(Tb);
        }
        public static string MatToStr(double[,] mat)
        {
            string ret = "";
            int size = mat.GetLength(0);
            for (int y = 0; y < size; ++y)
            {
                if (y > 0) ret += "\n";
                for (int x = 0; x < size; ++x)
                {
                    if (x > 0) ret += "\t";
                    ret += mat[y, x].ToString();
                }
            }
            return ret;
        }
        public static string MatToStr(int[] mat)
        {
            string ret = "";
            int size = mat.Length;
            for (int x = 0; x < size; ++x)
            {
                if (x > 0) ret += "\t";
                ret += mat[x].ToString();
            }
            return ret;
        }
    }
}
