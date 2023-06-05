
import java.util.concurrent.locks.ReentrantLock;

public class HarmonicCalcAsync extends HarmonicCalc
{
   private static int MaxThreadCount=4;
   private interface PartReport
   {
      public void report(double sum);
   }
   private double sum=0;
   private int partCount=0;
   private ReentrantLock lock=new ReentrantLock();
   // 1/1 + 1/2 + 1/3 + ... 1/N
   public HarmonicCalcAsync(long count,ValueReport report) { super(count,report); }
   public void calc()
   {
      HarmonicCalcPart[] th=new HarmonicCalcPart[MaxThreadCount];
      for(int i=0;i<MaxThreadCount;++i)
      {
         th[i]=new HarmonicCalcPart(count,i,MaxThreadCount,this::partReported);
      }
   }
   //*///
   public void partReported(double partSum)
   {
      lock.lock();
      try
      {
         sum+=partSum;
         if(++partCount>=MaxThreadCount) report.report("A", count, sum);
      }
      finally { lock.unlock(); }
   }
   /*///
   public synchronized void partReported(double partSum)
   {
      sum+=partSum;
      if(++partCount>=MaxThreadCount) report.report("A", count, sum);
   }
   //*///
   private static class HarmonicCalcPart
   {
      private long count,start,step;
      private PartReport report;
      public HarmonicCalcPart(long count,int start,int step,PartReport report)
      {
         this.count=count;
         this.start=start;
         this.step=step;
         this.report=report;
         new Thread(this::internalCalc).start();
      }
      public void internalCalc()
      {
         double sum=0;
         for(long i=1+start;i<=count;i+=step) sum+=1./i;
         report.report(sum);
      }
   }
}
