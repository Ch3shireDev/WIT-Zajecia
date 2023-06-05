using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperation
{
    class Matrix
    {
        private double[,] data;
        public int rowcount { get { return data.GetLength(0); } }
        public int colcount { get { return data.GetLength(1); } }
        public Matrix(int rowcount, int colcount)
        {
            data = new double[rowcount, colcount];
        }
        public Matrix(double[,] data)
        {
            this.data = (double[,])data.Clone();
        }
        public Matrix(Matrix m):this(m.data)
        {
        }
        public double this[int r, int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }
        public static Matrix operator+(Matrix a, Matrix b)
        {
            int rowcount=a.rowcount, colcount=a.colcount;
            if ((rowcount != b.rowcount) || (colcount != b.colcount)) return null;
            Matrix m = new Matrix(rowcount, colcount);
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    m[r, c] = a[r, c] + b[r, c];
                }
            }
            return m;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            int rowcount = a.rowcount, colcount = a.colcount;
            if ((rowcount != b.rowcount) || (colcount != b.colcount)) return null;
            Matrix m = new Matrix(rowcount, colcount);
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    m[r, c] = a[r, c] - b[r, c];
                }
            }
            return m;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int rowcount = a.rowcount, colcount = b.colcount, deepcount = a.colcount;
            if (deepcount != b.rowcount) return null;
            Matrix m = new Matrix(rowcount, colcount);
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    for (int d = 0; d < deepcount; ++d)
                    {
                        m[r, c] += a[r, d] - b[d, c];
                    }
                }
            }
            return m;
        }
        public static bool TryParse(string text,out Matrix m)
        {
            m = null;
            string[] rows = text.Split("\r\n\v\f".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int rowcount = rows.Length, colcount = 0;
            for (int r = 0; r < rowcount; ++r)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    colcount = cols.Length;
                    m = new Matrix(rowcount, colcount);
                }
                else if (colcount != cols.Length) return false;
                for (int c = 0; c < colcount; ++c)
                {
                    double value;
                    if (!double.TryParse(cols[c], out value)) return false;
                    //m.data[r, c] = value;
                    m[r, c] = value;
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int rowcount = this.rowcount;
            int colcount = this.colcount;
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    if (c > 0) sb.Append('\t');
                    sb.Append(data[r,c]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
