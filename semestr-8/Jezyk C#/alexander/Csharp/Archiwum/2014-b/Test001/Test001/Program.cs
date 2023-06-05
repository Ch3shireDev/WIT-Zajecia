using System;

namespace Test001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=7856;
            uint b;
            short c;
            ushort d;
            long e=786;
            ulong f;
            byte g;
            sbyte h;
            float i=2.6987654321f;
            double k;
            char l='\\';
            string m=@"Wartosc f wynosi: ";
            Console.WriteLine(m+i);
            Console.WriteLine("a={1}; i={0:#.00}; l={2}",i,a,l);
            /*
            Console.WriteLine("{0:C}",);
            Console.WriteLine("{0:D}",);
            Console.WriteLine("{0:E}",);
            Console.WriteLine("{0:F}",);
            Console.WriteLine("{0:G}",);
            Console.WriteLine("{0:N}",);
            Console.WriteLine("{0:X}",);
            Console.WriteLine("{0:x}",);
            */

            if(a<10) Console.WriteLine("a<10");

            if(a<10) Console.WriteLine("a<10");
            else Console.WriteLine("a>=10");

            if (a < 10)
            {
                Console.WriteLine("a<10");
            }
            else
            {
                Console.WriteLine("a>=10");
            }
            // &&-oraz ||-lub !-nie

            for (a = 1; a <= 10; ++a) Console.WriteLine("a={0}",a);
            for (int w = 1; a <= 10; ++a) Console.WriteLine("w={0}", w);
            int p = 0, q = 0;
            for (p = 1, q = 9; p < q; ++p, --q) Console.WriteLine("{0},{1}", p, q);
            for (; ; )
            {
                if (a == 666) break;
            }
            for ( ;p<q; )
            {
            }
            while(p < q)
            {
                if (a > 10) continue;
            }
            do {  } while( p<q );
            switch (a + 3)
            {
                case 1: { Console.WriteLine("1"); break; }
                case 5: { Console.WriteLine("5"); break; }
                default: { Console.WriteLine("*"); break; }
            }
            Console.ReadKey();
        }
    }
}
