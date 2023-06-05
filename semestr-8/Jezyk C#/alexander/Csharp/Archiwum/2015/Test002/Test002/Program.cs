using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test002
{
    class Program
    {
        static readonly int size = 3;
        public static ConsoleKey ReadInt(int left, int top, int max, ref int val)
        {
            while (true)
            {
                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0,3}", val);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo key = Console.ReadKey(true);
                ConsoleKey kb = key.Key;
                if (kb == ConsoleKey.Escape) return kb;
                if (kb == ConsoleKey.Enter) return kb;
                if (kb == ConsoleKey.Tab) return kb;
                if (kb == ConsoleKey.LeftArrow) return kb;
                if (kb == ConsoleKey.RightArrow) return kb;
                if (kb == ConsoleKey.UpArrow) return kb;
                if (kb == ConsoleKey.DownArrow) return kb;
                if (kb == ConsoleKey.Backspace) val /= 10;
                else if (key.KeyChar == '-') val = -val;
                else if (Char.IsDigit(key.KeyChar))
                {
                    int x = val * 10;
                    if (val<0) x -= (key.KeyChar - '0');
                    else x += (key.KeyChar - '0');
                    if ((-max <= x) && (x <= max)) val = x;
                }
            }
        }

        static void Main(string[] args)
        {
            int[, ,] tb = new int[3, size, size];
            for (int z = 0; z < 3; ++z)
                for (int y = 0; y < size; ++y)
                    for (int x = 0; x < size; ++x) tb[z,y,x]=0;
            Console.CursorSize = 100;
            Console.TreatControlCAsInput = true;
            int Y = 0, X = 0, Z = 0;
            while (true)
            {
                for (int z = 0; z < 3; ++z)
                {
                    for (int y = 0; y < size; ++y)
                    {
                        for (int x = 0; x < size; ++x)
                        {
                            Console.CursorTop = y + 2;
                            Console.CursorLeft = x * (z < 2 ? 4 : 6) + z * 18;
                            if (z < 2) Console.Write("{0,3}", tb[z, y, x]);
                            else Console.Write("{0,5}", tb[z, y, x]);
                        }
                    }
                }
                ConsoleKey kb = ReadInt(X * 4 + Z * 18, Y + 2, 99, ref tb[Z, Y, X]);
                if (kb == ConsoleKey.Escape) break;
                else if (kb == ConsoleKey.Tab) Z = 1 - Z;
                else if (kb == ConsoleKey.RightArrow) X = (X + 1) % 3;
                else if (kb == ConsoleKey.LeftArrow) X = (X + 2) % 3;
                else if (kb == ConsoleKey.DownArrow) Y = (Y + 1) % 3;
                else if (kb == ConsoleKey.UpArrow) Y = (Y + 2) % 3;
                else if (kb == ConsoleKey.Enter)
                {
                    if (++X >= 3)
                    {
                        X = 0;
                        if (++Y >= 3)
                        {
                            Y = 0;
                            Z = 1 - Z;
                        }
                    }
                }
                for (int y = 0; y < size; ++y)
                {
                    for (int x = 0; x < size; ++x)
                    {
                        int sum=0;
                        for (int z = 0; z < size; ++z)
                        {
                            sum += tb[0, y, z] * tb[1, z, x];
                        }
                        tb[2, y, x] = sum;
                    }
                }
            }
        }
    }
}
