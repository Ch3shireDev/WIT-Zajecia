using System;

namespace Test008
{
    class Ulamek
    {
        public int L,M;
        public Ulamek(int L, int M)
        {
            this.L = L; 
            this.M = M; 
            norm(); 
        }
        private static int nwd(int A, int B)
        {
            if (A == 0) return B;
            A = Math.Abs(A);
            B = Math.Abs(B);
            while(B!=0)
            {
                int C = A % B;
                A = B;
                B = C;
            }
            return A;
        }
        public static Ulamek operator+(Ulamek a,Ulamek b)
        {
            return new Ulamek(a.L * b.M + b.L * a.M, a.M * b.M);
        }
        public void norm()
        {
            if(M<0)
            {
                M = -M;
                L = -L;
            }
            int n = nwd(L, M);
            L /= n;
            M /= n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(4, -10);
            Ulamek b = new Ulamek(5, -15);
            Console.WriteLine("{0}/{1}", a.L, a.M);
            Console.WriteLine("{0}/{1}", b.L, b.M);
            Ulamek c = a + b;
            Console.WriteLine("{0}/{1}", c.L, c.M);
            Console.ReadKey();
        }
    }
}
