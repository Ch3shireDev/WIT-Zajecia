using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Harmonic
{
    delegate void HarmonicCalcProc(long Count);
    class HarmonicCalc
    {
        private long Count;
        private HarmonicCalcProc job;
        public HarmonicCalc(long Count,HarmonicCalcProc job)
        {
            this.Count = Count;
            this.job = job;
            Thread th = new Thread(run);
            th.Start();
        }
        public void run()
        {
            job(Count);
        }
    }
}
