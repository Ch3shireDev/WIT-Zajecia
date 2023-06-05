public class HarmonicCalcThread extends HarmonicCalc
{
   // 1/1 + 1/2 + 1/3 + ... 1/N
   public HarmonicCalcThread(long count,ValueReport report) { super(count,report); }
   public void calc()
   {
      new Thread(this::internalCalc).start();
   }
   public void internalCalc()
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1./i;
      report.report("T", count, sum);
   }
}
