using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class ArrayHelper
    {
        private static Random rnd = new Random();
        public static double[] ParseArray(string text)
        {
            string[] values = text.Split("\\s\t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[] ret = new double[values.Length];
            for (int i = 0; i < ret.Length; ++i) ret[i] = double.Parse(values[i]);
            return ret;
        }
        public static string ToString(double[] values)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Length; ++i)
            {
                if (i > 0) sb.Append(Environment.NewLine);
                sb.Append(values[i]);
            }
            return sb.ToString();
        }
        public static double[] Generate(int size)
        {
            double[] ret = new double[size];
            for (int i = 0; i < size; ++i) ret[i] = 10*rnd.NextDouble();
            return ret;
        }
    }
}
