using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static byte[,] ReadTable()
        {
            string[] input = Console.In.ReadToEnd().Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int p = 0;
            int width = int.Parse(input[p++]);
            int height = int.Parse(input[p++]);
            byte[,] tb = new byte[height, width];
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x) tb[y, x] = byte.Parse(input[p++]);
            }
            return tb;
        }
        static void ShowTable(byte[,] tb)
        {
            for (int y = 0; y < tb.GetLength(0); ++y)
            {
                for (int x = 0; x < tb.GetLength(1); ++x)
                {
                    Console.Write(tb[y, x].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.In.ReadLine();

        }
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Paste data:");
            byte[,] tb = ReadTable();
            ShowTable(tb);
        }
    }
}
