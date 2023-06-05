using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperation
{
    public class Matrix
    {
        private double[,] mat;
        public Matrix(string text)
        {
            mat = Parse(text);
        }
        public Matrix(int rows,int cols)
        {
            mat = new double[rows,cols];
        }
        public int rows { get { return mat.GetLength(0); } }
        public int cols { get { return mat.GetLength(1); } }
        private static string NormSeparator(string text)
        {
            return 
                text
                    .Replace(",", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                    .Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                ;
        }
        private static double[,] Parse(string text)
        {
            double[,] mat=null;
            string[] rows = text.Split("\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            for(int r=0;r<rows.Length;++r)
            {
                string[] cols = rows[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                for(int c=0;c<cols.Length;++c)
                {
                    if ((r == 0) && (c == 0)) mat = new double[rows.Length, cols.Length];
                    else if (cols.Length != mat.GetLength(1)) throw new Exception("Rożne rozmiary wierszy");
                    mat[r, c] = double.Parse(NormSeparator(cols[c]));
                }
            }
            return mat;
        }
        public static Matrix operator +(Matrix a, Matrix b) { return add(a, b); }
        public static Matrix operator *(Matrix a, Matrix b) { return mul(a, b); }
        public static Matrix add(Matrix a,Matrix b)
        {
            int rows = a.rows,cols = a.cols;
            if (rows != b.rows) throw new Exception("Rożna ilość wierszy");
            if (cols != b.cols) throw new Exception("Rożna ilość kolumn");
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
        public double this[int r, int c]
        {
            get { return mat[r, c]; }
            set { mat[r, c] = value; }
        }
        public static Matrix mul(Matrix a, Matrix b)
        {
            int rows = a.rows, cols = b.cols, size = a.cols;
            if (size != b.rows) throw new Exception("Nieodpowiednie rozmiary macierzy");
            Matrix m = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    double sum = 0;
                    for (int s = 0; s < size; ++s) sum += a[r, s] * b[s, c];
                    //m.mat[r, c] = sum;
                    m[r, c] = sum;
                }
            }
            return m;
        }
        public static Matrix solve(Matrix m, Matrix y)
        {
            int rows = m.rows, mcols = m.cols, ycols = y.cols, cols = mcols + ycols;
            if (rows != m.cols) throw new Exception("Pierwsza macierz musi być kwadratowa");
            if (rows != y.rows) throw new Exception("Ilość wierszy obu macierzy musi być jednakowa");
            Matrix tmp = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < mcols; ++c) tmp[r, c] = m[r,c];
                for (int c = 0; c < ycols; ++c) tmp[r, mcols + c] = y[r, c];
            }
            for (int d = 0; d < rows; ++d)
            {
                double div = tmp[d, d];
                for (int r = 0; r < rows; ++r)
                {
                    if (r == d) continue;
                    double mul = tmp[r, d];
                    for (int c = 0; c < cols; ++c) tmp[r, c] -= tmp[d, c] * mul / div;
                }
            }
            for (int d = 0; d < rows; ++d)
            {
                double div = tmp[d, d];
                for (int c = 0; c < cols; ++c) tmp[d, c] /= div;
            }
            y = new Matrix(rows, ycols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < ycols; ++c) y[r, c] = tmp[r, mcols + c];
            }
            return y;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    if (c > 0) sb.Append('\t');
                    sb.Append(string.Format("{0,10:F5}", mat[r, c]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
