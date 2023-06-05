using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MatrixOperation
{
    public class Matrix
    {
        private double[,] mat;
        public Matrix(int rows,int cols)
        {
            mat = new double[rows, cols];
        }
        public Matrix(string data)
        {
            data = data.Trim();
            while(true)
            {
                string tmp=data
                    .Replace(Environment.NewLine + '\t', Environment.NewLine)
                    .Replace(Environment.NewLine + ' ', Environment.NewLine)
                ;
                if (tmp == data) break;
                data = tmp;
            }
            string[] Rows = data.Split("\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int rows = Rows.Length, cols = 0;
            for (int r = 0; r < rows; ++r)
            {
                string[] Cols = Rows[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    cols = Cols.Length;
                    mat = new double[rows, cols];
                }
                else if (cols != Cols.Length) throw new ArgumentException("Unregular matrix data");
                for (int c = 0; c < cols; ++c)
                {
                    mat[r, c] = double.Parse(normalise(Cols[c]));
                }
            }
        }
        private static string normalise(string number)
        {
            foreach(char sign in ".,".ToArray()) number = number.Replace(sign.ToString(), NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            return number;
        }
        public int RowCount { get { return mat.GetLength(0); } }
        public int ColCount { get { return mat.GetLength(1); } }
        public double this[int r,int c]
        {
            get { return mat[r, c]; }
            set { mat[r, c] = value; }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rows = a.RowCount, cols = a.ColCount;
            if (rows != b.RowCount) throw new ArgumentException("Different rows count");
            if (cols != b.ColCount) throw new ArgumentException("Different cols count");
            Matrix m = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    m.mat[r, c] = a.mat[r, c] + b.mat[r, c];
                }
            }
            return m;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int rows = a.RowCount, cols = b.ColCount, size = a.ColCount;
            if (size != b.RowCount) throw new ArgumentException("Uncompatible matrix sizes");
            Matrix m = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    double sum = 0;
                    for (int s = 0; s < size; ++s) sum+= a.mat[r, s] * b.mat[s, c];
                    m.mat[r, c] = sum;
                }
            }
            return m;
        }
        public static Matrix solve(Matrix a, Matrix m)
        {
            int rows = a.RowCount, mcols = m.ColCount, acols = rows, cols = acols + mcols;
            if (rows != acols) throw new ArgumentException("Firast matrix must be square");
            if (rows != m.RowCount) throw new ArgumentException("Row count of matrixees must be equal");
            Matrix tmp = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < acols; ++c) tmp[r, c] = a[r, c];
                for (int c = 0; c < mcols; ++c) tmp[r, acols + c] = m[r, c];
            }
            for (int d = 0; d < rows; ++d)
            {
                double div = tmp[d, d];
                for (int r = 0; r < rows; ++r)
                {
                    if (d == r) continue;
                    double mul = tmp[r, d];
                    for (int c = 0; c < cols; ++c) tmp[r, c] -= tmp[d, c] * mul / div;
                }
            }
            for (int d = 0; d < rows; ++d)
            {
                double div = tmp[d, d];
                //tmp[d, d] /= div;
                for (int c = acols; c < cols; ++c) tmp[d, c] /= div;
            }
            Matrix ret = new Matrix(rows, mcols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < mcols; ++c) ret[r, c] = tmp[r, acols + c];
            }
            return ret;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int rows = RowCount, cols = ColCount;
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    if (c > 0) sb.Append(' ');
                    sb.Append(string.Format("{0,12:F3}", mat[r, c]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
