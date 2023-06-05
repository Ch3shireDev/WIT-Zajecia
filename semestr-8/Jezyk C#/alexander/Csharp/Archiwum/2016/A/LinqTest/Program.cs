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
        private static Dictionary<string, TestRun> dic = new Dictionary<string, TestRun>
        {
            {"TestA", TestA},
            {"TestB", TestB},
            {"TestC", TestC},
            {"TestD", TestD},
        };
        private static void Show<TSource>(string msg, IEnumerable<TSource> lst, string format)
        { 
            Console.WriteLine(msg+":");
            foreach (var item in lst) Console.WriteLine(format, item);
        }
        private static void TestA()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((str, index) => str.Length < index);
            Show("Krótsze nazwy", shortDigits, "Slowo {0} jest krótsze niż wartość którą oznacza");
        }
        private static void TestB()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var conversion = from n in numbers select 100 + 2 * n;
            Show("Po konwersji", conversion, "{0}");
        }
        private static void TestC()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var conversion = from n in numbers select new { n, value = 100 + 2 * n };
            Console.WriteLine("Konwersja:");
            foreach (var item in conversion) Console.WriteLine("{0} => {1}", item.n, item.value);
        }
        private static void TestD()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sel = from item in numbers where item > 6 orderby digits[item] select digits[item];
            Show("Nazwy > 6", sel, "{0}");
        }
        static void Main(string[] args)
        {
            while(true)
            {
                int pos = 0;
                foreach (var item in dic) Console.WriteLine((++pos).ToString() + ". " + item.Key);
                Console.Write("0. Koniec\nTwój wybór: ");
                int ch;
                if (int.TryParse(Console.ReadLine(), out ch) && (0 <= ch) && (ch <= pos))
                {
                    if (ch == 0) break;
                    pos = 0;
                    foreach (var item in dic)
                    {
                        if (++pos == ch)
                        {
                            item.Value();
                            break;
                        }
                    }
                }
                else Console.WriteLine("Wybór musi być liczbą w granicach 1.." + pos.ToString());
                Console.WriteLine("");
            }
        }
    }
}
