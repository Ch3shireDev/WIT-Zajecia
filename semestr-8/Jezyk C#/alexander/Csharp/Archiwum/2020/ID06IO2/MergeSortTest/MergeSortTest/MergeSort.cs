using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MergeSortTest
{
    class MergeSort
    {
        private double[] tbl, tmp;
        public static void Sort(double[] tbl)
        {
            if (tbl.Length>1) new MergeSort(tbl);
        }
        private MergeSort(double[] tbl)
        {
            this.tbl = tbl;
            this.tmp = new double[tbl.Length];
            MergeCall(0, tbl.Length).Join();
        }
        private Thread MergeCall(int lf, int rt)
        {
            Thread th = new Thread(() => Merge(lf, rt));
            th.Start();
            return th;
        }
        private void Merge(int lf, int rt)
        {
            int md = (lf + rt) >> 1;
            Thread[] tb = 
            {
                (md - lf > 1 ? MergeCall(lf, md) : null), 
                (rt - md > 1 ? MergeCall(md, rt) : null) 
            };
            foreach (Thread th in tb) if (th != null) th.Join();
            int ai = lf, ae = md, bi = md, be = rt, ci = lf;
            while ((ai < ae) && (bi < be)) tmp[ci++] = (tbl[ai] < tbl[bi]) ? tbl[ai++] : tbl[bi++];
            while (ai < ae) tmp[ci++] = tbl[ai++];
            while (bi < be) tmp[ci++] = tbl[bi++];
            //for (int i = lf; i < rt; ++i) tbl[i] = tmp[i];
            Array.Copy(tmp, lf, tbl, lf, rt - lf); // Jak wyżej ale szybsze
        }
    }
}
