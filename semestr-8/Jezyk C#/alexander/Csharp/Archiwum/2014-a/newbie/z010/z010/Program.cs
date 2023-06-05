using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z010
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Ulamek
    {
        public long C,D;
        public Ulamek(long C = 0, long D = 1) 
        {
            long N = nwd(C, D); 
            this.C = C / N; 
            this.D = D / N; 
        }
        public static long nwd(long a, long b)
        {
            bool sign = false;
            if (a < 0) a = -a;
            if (b < 0) { b = -b; sign = true; }
            if (a != 0 && b != 0)
            {
                while (b != 0)
                {
                    long r = a % b;
                    a = b;
                    b = r;
                }
            }
            else a = 1;
            return sign ? -a : a;
        }

        public static Ulamek operator+(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.C * b.D + b.C * a.D, a.D * b.D);
        }
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.C * b.D - b.C * a.D, a.D * b.D);
        }
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.C * b.C, a.D * b.D);
        }
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.C * b.D, a.D * b.C);
        }
    }
}
