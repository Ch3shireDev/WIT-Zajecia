using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MergeThreadTest
{
    class Merge
    {
        private int[] Tb, Tmp;
        class LR
        {
            public int L { get; set; }
            public int R { get; set; }
            public LR(int L,int R)
            {
                this.L = L;
                this.R = R;
            }
        }
        private Merge(int[] Tb)
        {
            this.Tb = Tb;
            Tmp=new int[Tb.Length];
            MakeThread(new LR(0, Tb.Length)).Join();
        }
        private void ThreadRun(LR lr)
        {
            int L = lr.L, R = lr.R;
            Thread tha = null, thb = null;
            int M = (L + R) >> 1;
            if (M - L > 1) tha = MakeThread(new LR(L, M));
            if (R - M > 1) thb = MakeThread(new LR(M, R));
            if (tha != null) tha.Join();
            if (thb != null) thb.Join();
            int a = L, b = M, p = L;
            while ((a < M) && (b < R))
            {
                if (Tb[a] < Tb[b]) Tmp[p++] = Tb[a++];
                else Tmp[p++] = Tb[b++];
            }
            while (a < M) Tmp[p++] = Tb[a++];
            while (b < R) Tmp[p++] = Tb[b++];
            Array.Copy(Tmp, L, Tb, L, R - L);
        }
        private void run(object obj)
        {
            ThreadRun((LR)obj);
        }
        private Thread MakeThread(LR lr)
        {
            Thread th = new Thread(run);
            th.Start(lr);
            return th;
        }
        public static int[] Sort(int[] Src)
        {
            return new Merge(Src).Tb;
        }
    }
}
