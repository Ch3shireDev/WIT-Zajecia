public class ThreadCalc extends BaseCalc
{
   public ThreadCalc(long count,ReportResult rr)
   {
      super(count,rr);
      new Thread(this::calc).start();
   }

   public void calc()
   {
      result=calc(count,0,1);
      rr.report("T",count,result);
   }
}
