using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    delegate void TestRun();
    class Program
    {
        private static List<double> values = new List<double>() { 1.1, 1.2, 1.1, 1.2, 1.3, 1.1, 1.2, 1.3, 1.4 };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static void Main(string[] args)
        {
            var methods=typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static);
            foreach (var i in methods)
            {
                Console.Write("{0}: ", i.Name);
                i.Invoke(null, null);
            }
            Console.ReadKey();
        }

        public static void TestA()
        {
            var result = from item in numbers where item < 5 select item;
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        public static void TestB()
        {
            var result = from item in numbers where item >= 5 select digits[item];
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        public static void TestC()
        {
            var result = from n in numbers where n <= 5 select new { n, sq = n * n, cb = n * n * n };
            foreach (var i in result) Console.Write("{0}/{1}/{2}\t", i.n, i.sq, i.cb);
            Console.WriteLine();
        }
        public static void TestD()
        {
            var result = numbers.Where((value) => value < 5);
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        public static void TestE()
        {
            var result = digits.Where((value,index) => value.Length < index);
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
        public static void TestF()
        {
            var result = values.Where((value) => value <= 1.5).Distinct();
            foreach (var i in result) Console.Write("{0}\t", i);
            Console.WriteLine();
        }
    }
}