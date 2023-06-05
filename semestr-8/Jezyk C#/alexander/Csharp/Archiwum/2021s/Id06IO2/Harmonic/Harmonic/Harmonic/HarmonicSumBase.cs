using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
    public abstract class HarmonicSumBase
    {
        public static double sum(ulong count)
        {
            double ret=0;
            for(ulong i=1;i<=count;++i) ret+=1D/i; // 1.0/i 1D/i, ((double)1)/i, 1/(double)i;
            return ret;
        }
        public static void sum(double[] results,ulong count, ulong start, ulong step)
        {
            double ret=0;
            for (ulong i=start+1;i<=count;i+=step) ret+=1D/i; // 1.0/i 1D/i, ((double)1)/i, 1/(double)i;
            results[start]=ret;
        }
    }
}
