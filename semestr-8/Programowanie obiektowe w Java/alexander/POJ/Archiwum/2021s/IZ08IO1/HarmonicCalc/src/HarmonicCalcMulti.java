public class HarmonicCalcMulti extends HarmonicCalc
{
   private static int MaxThreadCount=4;
   // 1/1 + 1/2 + 1/3 + ... 1/N
   public HarmonicCalcMulti(long count,ValueReport report) { super(count,report); }
   public void calc()
   {
      new Thread(this::internalCalc).start();
   }
   public void internalCalc()
   {
      double sum=0;
      HarmonicCalcPart[] th=new HarmonicCalcPart[MaxThreadCount];
      for(int i=0;i<MaxThreadCount;++i) th[i]=new HarmonicCalcPart(count,i,MaxThreadCount);
      for(int i=0;i<MaxThreadCount;++i) th[i].join();
      for(int i=0;i<MaxThreadCount;++i) sum+=th[i].getSum();
      report.report("M", count, sum);
   }
   private static class HarmonicCalcPart
   {
      private long count,start,step;
      private double sum=0;
      private Thread th;
      public HarmonicCalcPart(long count,int start,int step)
      {
         this.count=count;
         this.start=start;
         this.step=step;
         th=new Thread(this::internalCalc);
         th.start();
      }
      public double getSum() { return sum; }
      public void join() { try { th.join(); } catch(Exception e) {} }
      public void internalCalc()
      {
         for(long i=1+start;i<=count;i+=step) sum+=1./i;
      }
   }
}
