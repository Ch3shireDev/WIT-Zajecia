public class ThreadCalc extends BaseCalc
{
   public ThreadCalc(long count,ReportResult rr)
   {
      super(count,0,1,rr);
      new Thread(this::internalCalc).start();
   }

   private void internalCalc()
   {
      calc();
      report("T");
   }
}
