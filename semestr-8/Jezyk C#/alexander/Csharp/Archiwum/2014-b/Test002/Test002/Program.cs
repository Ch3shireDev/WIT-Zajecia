using System;

namespace Test002
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                uint Count = 0;
                double min = 0, max = 0;
                while (true)
                {
                    Console.WriteLine("Podaj liczbê {0}: ", Count+1);
                    double v;
                    if (double.TryParse(Console.ReadLine(), out v))
                    {
                        if (v == 0) break;
                        if (Count == 0) min = max = v;
                        else if (min > v) min = v;
                        else if (max < v) max = v;
                        ++Count;
                    }
                    else Console.WriteLine("Podano nie liczbê!");
                }
                if (Count <= 0) break;
                Console.WriteLine("min={0}; max={1};", min, max);
            }
        }
    }
}
