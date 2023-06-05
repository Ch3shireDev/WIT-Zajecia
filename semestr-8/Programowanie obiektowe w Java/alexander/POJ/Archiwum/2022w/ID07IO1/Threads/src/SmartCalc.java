public class SmartCalc extends BaseCalc
{
   private static final int ThreadCount=4;
   private int ThreadDone=0;
   public SmartCalc(long count,ReportResult rr)
   {
      super(count,rr);
      new Thread(this::calc).start();
   }

   private static class PartCalc extends BaseCalc
   {
      private Thread th;
      private int start,step;
      public PartCalc(long count,int start,int step,ReportResult rr)
      {
         super(count,rr);
         this.start=start;
         this.step=step;
         th=new Thread(this::calc);
         th.start();
      }

      public void calc()
      {
         result=calc(count,start,step);
         rr.report("R",count,result);
      }

      public void join()
      {
         try { th.join(); } catch(Exception e) {}
      }
   }

   public synchronized void ReportDone(String method,long count,double add)
   {
      this.result+=add;
      if(++ThreadDone>=ThreadCount) rr.report(method,count,this.result);
   }

   public void calc()
   {
      PartCalc[] tb=new PartCalc[ThreadCount];
      for(int i=0;i<tb.length;++i) tb[i]=new PartCalc(count,i,ThreadCount,this::ReportDone);
      for(int i=0;i<tb.length;++i) tb[i].join();
   }
}
