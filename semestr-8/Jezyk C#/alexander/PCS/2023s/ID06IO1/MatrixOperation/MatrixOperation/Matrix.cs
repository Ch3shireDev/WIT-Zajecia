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
        public int Rsize { get { return data.GetLength(0); } }
        public int Csize { get { return data.GetLength(1); } }
        public Matrix(int Rsize, int Csize)
        {
            data = new double[Rsize, Csize];
        }
        public Matrix(double[,] data)
        {
            this.data = (double[,])data.Clone();
        }
        public Matrix(Matrix m) : this(m.data) {}
        public double this[int r,int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }
        public static Matrix operator+(Matrix a,Matrix b)
        {
            int Rsize = 0; // TU USTALAMY KONKRETNE WARTOŚCI
            int Csize = 0;
            if (false) throw new ArgumentException("Incompatible sizes");
            Matrix m = new Matrix(Rsize, Csize);
            for (int r = 0; r < Rsize; ++r)
            {
                for (int c = 0; c < Csize; ++c)
                {
                    //
                }
            }
            return m;
        }
        public static bool TryParse(string text, out Matrix m)
        {
            m = null;
            string[] rows = text.Split("\r\n\v\f".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int Rsize = rows.Length, Csize=0;
            for (int r = 0; r < Rsize; ++r)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    Csize = cols.Length;
                    m = new Matrix(Rsize, Csize);
                }
                else if (Csize != cols.Length) return false;
                for (int c = 0; c < Csize; ++c)
                {
                    double value;
                    if (!double.TryParse(cols[c], out value)) return false;
                    //m.data[r, c] = value;
                    m[r, c] = value;
                }
            }
            return (m != null);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int Rsize = this.Rsize;
            int Csize = this.Csize;
            for (int r = 0; r < Rsize; ++r)
            {
                for (int c = 0; c < Csize; ++c)
                {
                    if(c>0) sb.Append('\t');
                    sb.Append(data[r,c]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
