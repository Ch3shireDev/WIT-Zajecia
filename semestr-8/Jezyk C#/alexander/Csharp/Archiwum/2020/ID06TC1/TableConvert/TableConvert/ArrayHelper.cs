using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableConvert
{
    class ArrayHelper
    {
        public static double[] ParseVector(string source)
        {
            string[] arr = source.Split(" \t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[] tb = new double[arr.Length];
            for (int i = 0; i < tb.Length; ++i)
            {
                double.TryParse(arr[i],out tb[i]);
            }
            return tb;
        }
        public static double[,] ParseMatrix(string source)
        {
            /*///
            string[] rows = source.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[,] tb = null;
            for (int r = 0; r < rows.Length; ++r)
            {
                string[] cols = rows[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r == 0) tb = new double[rows.Length, cols.Length];
                else if (cols.Length != tb.GetLength(1)) throw new ArgumentException("Different row sizes");
                for (int c = 0; c < cols.Length; ++c) tb[r, c] = double.Parse(cols[c]);
            }
            /*/
            string[] rows = source.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            string[][] tmp = new string[rows.Length][];
            for (int i = 0; i < rows.Length; ++i)
            {
                tmp[i] = rows[i].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (tmp[i].Length != tmp[0].Length) return null;
            }
            double[,] tb = new double[rows.Length, tmp[0].Length];
            for (int r = 0; r < rows.Length; ++r)
            {
                for (int c = 0; c < tmp[0].Length; ++c)
                {
                    double.TryParse(tmp[r][c],out tb[r, c]);
                }
            }

            //*///
            return tb;
        }

        public static string VectorToRows(double[] source)
        {
            if (source == null) return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < source.Length; ++i) 
            {
                if (i > 0) sb.Append(Environment.NewLine);
                sb.Append(source[i]);
            }
            return sb.ToString();
        }

        public static double[] MatrixMulVector(double[,] mat,double[] vec)
        {
            if((mat==null)||(vec==null)) return null;
            int rowcount = mat.GetLength(0);
            int colcount = mat.GetLength(1);
            if (vec.Length != colcount) return null;
            double[] ret = new double[rowcount];
            for (int r = 0; r < rowcount; ++r)
            {
                double sum = 0;
                for (int c = 0; c < colcount; ++c)
                {
                    sum += mat[r, c] * vec[c];
                }
                ret[r] = sum;
            }
            return ret;
        }
    }
}
