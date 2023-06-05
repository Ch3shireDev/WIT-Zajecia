using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Matrix
{
    public class Matrix
    {
        private double[,] mat;
        public Matrix(int rows,int cols) { mat = new double[rows, cols]; }
        public int RowCount { get { return mat.GetLength(0); } }
        public int ColCount { get { return mat.GetLength(1); } }
        public static Matrix Parse(string data)
        {
            Matrix m = null;
            string[] RowArray=data.Split("\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int rows = RowArray.Length, cols = 0;
            for (int r = 0; r < rows; ++r)
            {
                string[] ColArray = RowArray[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    cols = ColArray.Length;
                    m = new Matrix(rows, cols);
                }
                else if (cols != ColArray.Length) throw new ArgumentException("Irregular matrix not allowed");
                for (int c = 0; c < cols; ++c)
                {
                    m.mat[r, c] = double.Parse(norm(ColArray[c]));
                }
            }
            return m;
        }
        private static string norm(string number)
        {
            return number
                .Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                .Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            ;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rows = a.RowCount, cols = a.ColCount;
            if (rows != b.RowCount) throw new ArgumentException("Not same row sizes");
            if (cols != b.ColCount) throw new ArgumentException("Not same row sizes");
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
            int rows = a.RowCount, cols = b.ColCount, size = b.RowCount;
            if (size != a.ColCount) throw new ArgumentException("Uncompatible matrix sizes");
            Matrix m = new Matrix(rows, cols);
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    for (int s = 0; s < size; ++s) m.mat[r, c] += a.mat[r, s] * b.mat[s, c];
                }
            }
            return m;
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
                    sb.Append(string.Format("{0,12:F2}",mat[r,c]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
