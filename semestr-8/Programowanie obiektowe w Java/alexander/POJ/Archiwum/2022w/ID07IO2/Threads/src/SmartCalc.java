public class SmartCalc extends BaseCalc
{
   private static final int ThreadCount=4;
   private int TreadDone=0;
   public SmartCalc(long count,ReportResult rr)
   {
      super(count,0,1,rr);
      internalCalc();
   }

   private synchronized void internalReport(String method,long count,double result)
   {
      addResult(result);
      if(++TreadDone>=ThreadCount) report("R");
   }

   private void internalCalc()
   {
      final BaseCalc[] bc=new BaseCalc[ThreadCount];
      final Thread[] th=new Thread[ThreadCount];
      for(int i=0;i<ThreadCount;++i) bc[i]=new BaseCalc(getCount(),i,ThreadCount,this::internalReport);
      for(int i=0;i<ThreadCount;++i)
      {
         final int k=i;
         th[k]=new Thread(() -> bc[k].calcAndReport("R"));
      }
      for(int i=0;i<ThreadCount;++i) th[i].start();
   }
}
