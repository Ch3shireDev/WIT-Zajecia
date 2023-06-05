using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSum
{
    public abstract class HarmonicSum
    {
        // 1/1 1/2 1/3 1/4 1/5 1/6 ... 1/n
        public static void sum(ulong count,out double result)
        {
            result=0;
            for(ulong i=1;i<=count;++i) result+=1.0/i; // 1D/i 1.0/i ((double)1)/i 1/(double)i
        }
        public static void sum(ulong count,int start,int step,out double result)
        {
            result = 0;
            for (ulong i=(ulong)start+1;i<=count;i+=(ulong)step) result+=1.0/i; // 1D/i 1.0/i ((double)1)/i 1/(double)i
        }
    }
}
