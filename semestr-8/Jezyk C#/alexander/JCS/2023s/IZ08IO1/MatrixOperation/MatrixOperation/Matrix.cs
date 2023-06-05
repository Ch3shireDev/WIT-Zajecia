using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperation
{
    class Matrix: ICloneable
    {
        private double[,] data;
        public int rowcount { get { return data.GetLength(0); } }
        public int colcount { get { return data.GetLength(1); } }
        public Matrix(double[,] data)
        {
            this.data = (double[,])data.Clone();
        }
        public Matrix(Matrix m): this(m.data)
        {
        }
        public Matrix(int rows, int cols)
        {
            data = new double[rows, cols];
        }
        public double this[int row,int col]
        {
            get { return data[row,col]; }
            set { data[row, col] = value; }
        }
        public static Matrix Parse(string text)
        {
            string[] rows = text.Split("\r\n\v\f".ToArray(),StringSplitOptions.RemoveEmptyEntries);
            int rowcount=rows.Length, colcount = 0;
            Matrix m = null;
            for (int r = 0; r < rowcount; ++r)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    colcount = cols.Length;
                    m = new Matrix(rowcount, colcount);
                }
                else if (colcount != cols.Length) throw new ArgumentException("Irregular matrix error");
                for (int c = 0; c < cols.Length; ++c)
                {
                    m[r, c] = double.Parse(cols[c]);
                }
            }
            return m;
        }
        public static bool TryParse(string text,out Matrix m)
        {
            string[] rows = text.Split("\r\n\v\f".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int rowcount = rows.Length, colcount = 0;
            m = null;
            for (int r = 0; r < rowcount; ++r)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    colcount = cols.Length;
                    m = new Matrix(rowcount, colcount);
                }
                else if (colcount != cols.Length) return false;
                for (int c = 0; c < cols.Length; ++c)
                {
                    double v;
                    if(!double.TryParse(cols[c],out v)) return false;
                    m[r, c] = v;
                }
            }
            return true;
        }
        public static Matrix zeros(int size)
        {
            return new Matrix(size, size);
        }
        public static Matrix ones(int size)
        {
            Matrix m=zeros(size);
            for (int s = 0; s < size; ++s) m[s, s] = 1;
            return m;
        }
        public static Matrix Solve(Matrix m,Matrix y)
        {
            int rowcount = m.rowcount;
            if (rowcount != m.colcount) throw new ArgumentException("Not square matrix error");
            if (rowcount != y.rowcount) throw new ArgumentException("Uncompatible sizes error");
            int mcolcount = rowcount;
            int ycolcount = y.colcount;
            m = new Matrix(m);
            y = new Matrix(y);
            for (int d = 0; d < rowcount; ++d)
            {
                double div = m[d, d];
                for (int r = 0; r < rowcount; ++r)
                {
                    if (d != r)
                    {
                        double mul = m[r, d];
                        for (int c = 0; c < mcolcount; ++c) m[r, c] -= mul * m[d, c] / div;
                        for (int c = 0; c < ycolcount; ++c) y[r, c] -= mul * y[d, c] / div;
                    }
                }
                for (int c = 0; c < mcolcount; ++c) m[d, c] /= div;
                for (int c = 0; c < ycolcount; ++c) y[d, c] /= div;
            }
            return y;
        }
        public static Matrix Inv(Matrix m)
        {
            return Solve(m, ones(m.rowcount));
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rowcount = a.rowcount;
            int colcount = a.colcount;
            if((rowcount!=b.rowcount)|| (colcount != b.colcount)) throw new ArgumentException("Uncompatible sizes error");
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
            int rowcount = a.rowcount;
            int colcount = a.colcount;
            if ((rowcount != b.rowcount) || (colcount != b.colcount)) throw new ArgumentException("Uncompatible sizes error");
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
            int rowcount = a.rowcount;
            int colcount = b.colcount;
            int deepcount = a.colcount;
            if (deepcount != b.rowcount) throw new ArgumentException("Uncompatible sizes error");
            Matrix m = new Matrix(rowcount, colcount);
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    for (int d = 0; d < deepcount; ++d)
                    {
                        m[r, c] += a[r, d] * b[d, c];
                    }
                }
            }
            return m;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    if (c > 0) sb.Append('\t');
                    sb.Append(data[r, c].ToString("F3"));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public object Clone()
        {
            return new Matrix(this);
        }
    }
}
