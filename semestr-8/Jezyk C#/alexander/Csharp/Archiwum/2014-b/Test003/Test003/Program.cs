using System;

namespace Test003
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Y = 0; Y < 8; ++Y)
            {
                for (int y=0; y<5 ; ++y)
                {
                    for (int X = 0; X < 8; ++X)
                    {
                        for (int x=0; x<5 ; ++x)
                        {
                            if (((Y + X) & 1) == 0) Console.Write('*');
                            else Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
