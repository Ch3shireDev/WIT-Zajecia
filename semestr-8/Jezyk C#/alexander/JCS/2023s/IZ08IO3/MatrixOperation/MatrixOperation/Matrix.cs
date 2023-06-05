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
        public Matrix(int rowcount,int colcount)
        {
            data = new double[rowcount, colcount];
        }
        public double this[int r,int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }
        public static Matrix Parse(string text)
        {
            string[] rows = text.Split("\r\n\f\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int rowcount = rows.Length, colcount = 0;
            Matrix m = null;
            for (int r = 0; r < rowcount; ++r)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    colcount = cols.Length;
                    m = new Matrix(rowcount, colcount);
                }
                else if (colcount != cols.Length) throw new ArgumentException("Irregular matrix data");
                for (int c = 0; c < colcount; ++c)
                {
                    m[r, c] = double.Parse(cols[c]);
                }
            }
            return m;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rowcount=0, colcount=0;

            if (false) throw new ArgumentException("Uncompatible matrix sizes");
            Matrix m = new Matrix(rowcount, colcount);
            for (int r = 0; r < rowcount; ++r)
            {
                for (int c = 0; c < colcount; ++c)
                {
                    m[r, c] = 0;
                }
            }
            return m;
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
                    sb.Append(data[r, c]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
