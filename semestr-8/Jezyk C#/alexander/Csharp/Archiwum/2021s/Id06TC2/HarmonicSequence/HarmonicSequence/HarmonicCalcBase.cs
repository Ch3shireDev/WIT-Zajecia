using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HarmonicSequence
{
    public delegate void ReportResult(string method,ulong count,double sum);
    // 1/1 1/2 1/3 1/4 ... 1/count
    public abstract class HarmonicCalcBase
    {
        protected ulong count;
        protected ReportResult report;
        public HarmonicCalcBase(ulong count,ReportResult report)
        {
            this.count=count;
            this.report=report;
        }
        public abstract void calc();
    }

    public class HarmonicCalcSimple:HarmonicCalcBase
    {
        public HarmonicCalcSimple(ulong count,ReportResult report):base(count,report) {}
        public override void calc()
        {
            double sum=0;
            for(ulong i=1;i<=count;++i) sum+=1.0/i; // ((double)1)/i; 1/(double)i; 1D/i; 1.0/i;
            report("S",count,sum);
        }
    }
    public class HarmonicCalcOneThread:HarmonicCalcBase
    {
        public HarmonicCalcOneThread(ulong count, ReportResult report) : base(count, report) {}
        private void internalCalc()
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i; // ((double)1)/i; 1/(double)i; 1D/i; 1.0/i;
            report("O", count, sum);
        }
        public override void calc()
        {
            new Thread(internalCalc).Start();
        }
    }
    public class HarmonicCalcMultiThread:HarmonicCalcBase
    {
        private static readonly int ThreadCount=4;
        private class HarmonicCalcPart
        {
            private int start,step;
            private ulong count;
            private double sum;
            private Thread thread;
            public HarmonicCalcPart(int start,int step,ulong count)
            {
                this.start=start;
                this.step=step;
                this.count=count;
                thread=new Thread(internalCalc);
            }
            private void internalCalc()
            {
                sum=0;
                for(ulong i=(ulong)start+1;i<=count;i+=(ulong)step) sum+=1.0/i;
            }
            public void Start() { thread.Start(); }
            public void Join() { thread.Join(); }
            public double Sum { get { return sum; } }
        }
        public HarmonicCalcMultiThread(ulong count, ReportResult report) : base(count, report) { }
        public void internalCalc()
        {
            HarmonicCalcPart[] parts=new HarmonicCalcPart[ThreadCount];
            for(int i=0;i<ThreadCount;++i) parts[i]=new HarmonicCalcPart(i,ThreadCount,count);
            for(int i=0;i<ThreadCount;++i) parts[i].Start();
            for(int i=0;i<ThreadCount;++i) parts[i].Join();
            double sum=0;
            for(int i=0;i<ThreadCount;++i) sum+=parts[i].Sum;
            report("M",count,sum);
        }
        public override void calc()
        {
            new Thread(internalCalc).Start();
        }
    }
}
