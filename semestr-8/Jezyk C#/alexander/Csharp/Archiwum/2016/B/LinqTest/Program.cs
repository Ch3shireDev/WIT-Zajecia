using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    delegate void TestRun();
    class Program
    {
        private static double[] values = { 1.1, 1.2, 1.1, 1.2, 1.3, 1.1, 1.2, 1.3, 1.4 };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static Dictionary<string, TestRun> dic = new Dictionary<string, TestRun>
        {
            {"Test A", TestA},
            {"Test B", TestB},
            {"Test C", TestC},
            {"Test D", TestD},
            {"Test E", TestE},
            {"Test F", TestF},
            {"Test G", TestG},
        };
        static void Main(string[] args)
        {
            while(true)
            {
                int pos=0;
                foreach(var i in dic) Console.WriteLine((++pos).ToString()+": "+i.Key);
                Console.Write("Twoj wybór: ");
                int ch;
                if (int.TryParse(Console.ReadLine(), out ch) && (1 <= ch) && (ch <= pos))
                {
                    pos = 0;
                    foreach(var i in dic)
                    {
                        if (++pos == ch)
                        {
                            i.Value();
                            break;
                        }
                    }
                }
                else Console.WriteLine("Błąd");
                Console.WriteLine();
            }
        }
        static void TestA()
        {
            var low = from n in numbers where n < 5 select n;
            foreach (var i in low) Console.WriteLine("Wybrano: {0}", i);
        }
        static void TestB()
        {
            var low = from n in numbers where n < 5 select digits[n];
            foreach (var i in low) Console.WriteLine("Wybrano: {0}", i);
        }
        static void TestC()
        {
            var conv = from n in numbers where n > 1 select new { n, sq = n * n, cb = n * n * n };
            foreach (var i in conv) Console.WriteLine("{0}\t{1}\t{2}", i.n, i.sq, i.cb);
        }
        static void TestD()
        {
            var sel = digits.Where((digits) => digits.Length <= 3);
            foreach (var i in sel) Console.WriteLine("{0}", i);
        }
        static void TestE()
        {
            var sel = digits.Where((digits, index) => digits.Length < index);
            foreach (var i in sel) Console.WriteLine("{0}", i);
        }
        static void TestF()
        {
            var conv = from n in numbers select n*100;
            foreach (var i in conv) Console.WriteLine("{0}", i);
        }
        static void TestG()
        {
            var conv = values.Distinct();
            foreach (var i in conv) Console.WriteLine("{0}", i);
        }
    }
}
