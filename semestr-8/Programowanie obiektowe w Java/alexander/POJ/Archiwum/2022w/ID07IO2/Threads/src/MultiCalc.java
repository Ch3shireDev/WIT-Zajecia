public class MultiCalc extends BaseCalc
{
   private static final int ThreadCount=4;
   public MultiCalc(long count,ReportResult rr)
   {
      super(count,0,1,rr);
      new Thread(this::internalCalc).start();
   }

   private void internalReport(String method,long count,double result)
   {
   }

   private void internalCalc()
   {
      BaseCalc[] bc=new BaseCalc[ThreadCount];
      Thread[] th=new Thread[ThreadCount];
      for(int i=0;i<ThreadCount;++i) bc[i]=new BaseCalc(getCount(),i,ThreadCount,this::internalReport);
      for(int i=0;i<ThreadCount;++i) th[i]=new Thread(bc[i]::calc);
      for(int i=0;i<ThreadCount;++i) th[i].start();
      for(int i=0;i<ThreadCount;++i) try { th[i].join(); } catch(Exception ex) {}
      for(int i=0;i<ThreadCount;++i) addResult(bc[i].getResult());
      report("M");
   }
}
