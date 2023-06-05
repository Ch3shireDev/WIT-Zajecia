public class MultiCalc extends BaseCalc
{
   private static final int ThreadCount=4;
   public MultiCalc(long count,ReportResult rr)
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
         //1/1+1/5+1/9+1/13
         //1/2+1/6+1/10+1/14
         //...
      }

      public void join()
      {
         try { th.join(); } catch(Exception e) {}
      }
   }

   public void calc()
   {
      PartCalc[] tb=new PartCalc[ThreadCount];
      for(int i=0;i<tb.length;++i) tb[i]=new PartCalc(count,i,ThreadCount,rr);
      for(int i=0;i<tb.length;++i) tb[i].join();
      result=0;
      for(int i=0;i<tb.length;++i) result+=tb[i].result;
      rr.report("M",count,result);
   }
}
