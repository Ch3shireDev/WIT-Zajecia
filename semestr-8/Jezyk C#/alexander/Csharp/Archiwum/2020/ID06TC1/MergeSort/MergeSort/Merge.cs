using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MergeSort
{
    class Merge
    {
        private double[] tbl, tmp;
        public static double[] Sort(double[] tbl)
        {
            if (tbl.Length > 1) new Merge(tbl);
            return tbl;
        }
        private Merge(double[] tbl)
        {
            this.tbl = tbl;
            this.tmp = new double[tbl.Length];
            MergeThread(0, tbl.Length).Join();
        }
        private Thread MergeThread(int lf,int rt)
        {
            Thread th = new Thread(() => MergeSort(lf,rt));
            th.Start();
            return th;
        }
        private void MergeSort(int lf,int rt)
        {
            int md = (lf + rt) >> 1;
            Thread[] th = { md - lf > 1 ? MergeThread(lf, md) : null, rt - md > 1 ? MergeThread(md, rt) : null };
            foreach (Thread t in th) if (t != null) t.Join();
            int ai = lf, ae = md, bi = md, be = rt, ci = lf;
            while ((ai < ae) && (bi < be)) tmp[ci++] = tbl[ai] < tbl[bi] ? tbl[ai++] : tbl[bi++];
            while (ai < ae) tmp[ci++] = tbl[ai++];
            while (bi < be) tmp[ci++] = tbl[bi++];
            Array.Copy(tmp, lf, tbl, lf, rt - lf);
        }
    }
}
