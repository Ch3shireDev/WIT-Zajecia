using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        private static double[] values = { 1.1, 1.2, 1.1, 1.2, 1.3, 1.1, 1.2, 1.3, 1.4 };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static void Main(string[] args)
        {
            TestA();
            TestB();
            TestC();
            TestD();
            TestE();
            TestF();
            Console.ReadKey();
        }
        private static void TestA()
        {
            var result = from n in numbers where n < 5 select n;
            foreach(var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        private static void TestB()
        {
            var result = from n in numbers where n <= 5 select digits[n];
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        private static void TestC()
        {
            var result = from n in numbers where n > 1 select new { n, sq = n * n, cb = n * n * n };
            foreach (var i in result) Console.Write("{0},{1},{2}\t", i.n, i.sq, i.cb);
            Console.WriteLine();
        }
        private static void TestD()
        {
            var result = digits.Where((value) => value.Length <= 3);
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        private static void TestE()
        {
            var result = digits.Where((value,index) => value.Length < index);
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        private static void TestF()
        {
            var result = values.Where((value) => value < 1.4).Distinct();
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
    }
}
