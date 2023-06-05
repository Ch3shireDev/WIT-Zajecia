using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortTest
{
    class ArrayHelper
    {
        private static Random rnd = new Random();
        public static double[] Generate(int size)
        {
            double[] values = new double[size];
            for (int i = 0; i < values.Length; ++i) values[i] = 10 * rnd.NextDouble();
            return values;
        }
        public static double[] Parse(string text)
        {
            string[] values = text.Split("\\s\t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[] ret = new double[values.Length];
            for (int i = 0; i < ret.Length; ++i) ret[i] = double.Parse(values[i]);
            return ret;
        }
        public static string ToString(double[] table)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < table.Length; ++i)
            {
                if(i>0) sb.Append(Environment.NewLine);
                sb.Append(table[i]);
            }
            return sb.ToString();
        }
    }
}
