public class HarmonicCalcSimple extends HarmonicCalc
{
   // 1/1 + 1/2 + 1/3 + ... 1/N
   public HarmonicCalcSimple(long count,ValueReport report) { super(count,report); }
   public void calc()
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1./i;
      report.report("S", count, sum);
   }
}
