using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static ConsoleKey ReadString(int left, int top,int len, ref String val)
        {
            while (true)
            {
                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("{0} \b",val);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape) return key.Key;
                if (key.Key == ConsoleKey.Enter) return key.Key;
                if (key.Key == ConsoleKey.Tab) return key.Key;
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (val.Length > 0)
                    {
                        val = val.Remove(val.Length - 1);
                    }
                }
                else if (Char.IsLetter(key.KeyChar))
                {
                    if (val.Length < len)
                    {
                        val += key.KeyChar;
                    }
                }
            }
        }

        public static ConsoleKey ReadUint(int left, int top, uint max, ref uint val)
        {
            while (true)
            {
                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("{0} \b", val);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape) return key.Key;
                if (key.Key == ConsoleKey.Enter) return key.Key;
                if (key.Key == ConsoleKey.Tab) return key.Key;
                if (key.Key == ConsoleKey.Backspace) val /= 10;
                else if (Char.IsDigit(key.KeyChar))
                {
                    uint x = val * 10 + (uint)(key.KeyChar - '0');
                    if (x <= max) val = x;
                }
            }
        }

        static void Main(string[] args)
        {
            String surname = "";
            uint age = 20;
            Console.CursorLeft = 2;
            Console.CursorTop = 1;
            Console.Write("Nazwisko: {0}", surname);
            Console.CursorLeft = 2;
            Console.CursorTop = 2;
            Console.Write("Wiek: {0}", age);
            Console.TreatControlCAsInput = true;
            while (true)
            {
                if (ReadString(12, 1, 16, ref surname) == ConsoleKey.Escape) break;
                if (ReadUint(8, 2, 150, ref age) == ConsoleKey.Escape) break;
            }
        }
    }
}
