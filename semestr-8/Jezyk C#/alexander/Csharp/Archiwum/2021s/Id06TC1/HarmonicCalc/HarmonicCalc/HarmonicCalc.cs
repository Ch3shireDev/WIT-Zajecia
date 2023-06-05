using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HarmonicCalc
{
    // 1/1 1/2 1/3 1/4 /5 ... 1/count
    public abstract class HarmonicCalc
    {
        protected ulong count;
        protected AppendLogProc result;
        protected HarmonicCalc(ulong count,AppendLogProc result)
        {
            this.count=count;
            this.result=result;
        }
        public abstract void calc();
        //public static void Calc(ulong count,AppendLogProc result) { new HarmonicCalcSimple(count,result).calc(); } 
    }
    public class HarmonicCalcSimple:HarmonicCalc
    {
        public HarmonicCalcSimple(ulong count,AppendLogProc result):base(count,result) {}
        public override void calc()
        {
            double sum=0;
            for(ulong i=1;i<=count;++i) sum+=1.0/i; // 1D/i; 1.0/i; ((double)1)/i; 1/(double)i;
            result("S" + DateTime.Now.ToString("HH:mm:ss.fff"), count, sum);
        }
    }
    public class HarmonicCalcThread : HarmonicCalc
    {
        public HarmonicCalcThread(ulong count, AppendLogProc result) : base(count, result) { }
        public override void calc()
        {
            new Thread(internalCalc).Start();
        }
        public void internalCalc()
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i; // 1D/i; 1.0/i; ((double)1)/i; 1/(double)i;
            result("T" + DateTime.Now.ToString("HH:mm:ss.fffff"), count, sum);
        }
    }
    public class HarmonicCalcMulti : HarmonicCalc
    {
        private static readonly int ThreadCount = 4;
        private class CalcPart
        {
            private ulong start, step, count;
            double sum = 0;
            private Thread th;
            public CalcPart(int start, int step, ulong count)
            {
                this.start = (ulong)start;
                this.step = (ulong)step;
                this.count = count;
                th = new Thread(calc);
                th.Start();
            }
            public void calc()
            {
                for (ulong i = start+1; i <= count; i+=step) sum += 1.0 / i;
            }
            public void Join() { th.Join(); }
            public double Sum { get { return sum; } }
        }
        public HarmonicCalcMulti(ulong count, AppendLogProc result) : base(count, result) { }
        public override void calc()
        {
            new Thread(internalCalc).Start();
        }
        public void internalCalc()
        {
            CalcPart[] calcPart = new CalcPart[ThreadCount];
            for(int i=0;i<ThreadCount;++i) calcPart[i]=new CalcPart(i,ThreadCount,count);
            foreach (CalcPart part in calcPart) part.Join();
            double sum = 0;
            foreach (CalcPart part in calcPart) sum+=part.Sum;
            result("M" + DateTime.Now.ToString("HH:mm:ss.fffff"), count, sum);
        }
    }

}
