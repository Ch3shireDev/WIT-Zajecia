using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAtrixOperation
{
    public class Matrix
    {
        private double[,] mat;
        public Matrix(int row,int col) { mat = new double[row, col]; }
        public int RowCount { get { return mat.GetLength(0); } }
        public int ColCount { get { return mat.GetLength(1); } }
        public static Matrix Parse(string text)
        {
            string[] Rows = text.Split("\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int row = Rows.Length, col = 0;
            Matrix m = null;
            for (int r = 0; r < row; ++r)
            {
                string[] Cols = Rows[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    col = Cols.Length;
                    m = new Matrix(row, col);
                }
                else if (col != Cols.Length) throw new ArgumentException("Non regular matrix data");
                for (int c = 0; c < col; ++c)
                {
                    m.mat[r, c] = double.Parse(norm(Cols[c]));
                }
            }
            return m;
        }
        public static string norm(string number)
        {
            return number
                .Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                .Replace(",", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            ;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int row = a.RowCount, col = a.ColCount;
            if (row != b.RowCount) throw new ArgumentException("Not equal row count");
            if (col != b.ColCount) throw new ArgumentException("Not equal column count");
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    m.mat[r, c] = a.mat[r, c] + b.mat[r, c];
                }
            }
            return m;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            int row = a.RowCount, col = a.ColCount;
            if (row != b.RowCount) throw new ArgumentException("Not equal row count");
            if (col != b.ColCount) throw new ArgumentException("Not equal column count");
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    m.mat[r, c] = a.mat[r, c] - b.mat[r, c];
                }
            }
            return m;
        }
        public static Matrix operator*(Matrix a, Matrix b)
        {
            int row = a.RowCount, col = b.ColCount, size = a.ColCount;
            if(size != b.RowCount) throw new ArgumentException("Not comatible matrix");
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    for (int s = 0; s < size; ++s) m.mat[r, c] += a.mat[r, s] * b.mat[s, c];
                }
            }
            return m;
        }
        public static Matrix solve(Matrix m, Matrix y)
        {
            int rows = m.RowCount;
            int mCols = m.ColCount;
            int yCols = y.ColCount;
            int cols = mCols + yCols;
            if (rows != mCols) throw new ArgumentException("Macierz musi być kwadratowa");
            if (rows != y.RowCount) throw new ArgumentException("Macierz musi być kwadratowa");
            Matrix tmp = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < mCols; ++c)
                {
                    tmp.mat[r, c] = m.mat[r, c];
                }
                for (int c = 0; c < yCols; ++c)
                {
                    tmp.mat[r, c + mCols] = y.mat[r, c];
                }
            }
            for (int d = 0; d < rows; ++d)
            {
                double div = tmp.mat[d, d];
                for (int r = 0; r < rows; ++r)
                {
                    if (r == d) continue;
                    double mult = tmp.mat[r, d];
                    for (int c = 0; c < cols; ++c)
                    {
                        tmp.mat[r, c] -= tmp.mat[d, c] * mult / div;
                    }
                }
            }

            for (int d = 0; d < rows; ++d)
            {
                for (int c = 0; c < cols; ++c)
                {
                    tmp.mat[d, c] /= tmp.mat[d, d];
                }
            }

            Matrix x = new Matrix(rows, yCols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < yCols; ++c)
                {
                    x.mat[r, c] = tmp.mat[r, c + mCols];
                }
            }
            return x;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int row = RowCount, col = ColCount;
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    if (c > 0) sb.Append(' ');
                    sb.Append(string.Format("{0,12:F2}", mat[r, c]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
