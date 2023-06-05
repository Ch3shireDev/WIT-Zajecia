public class SimpleCalc extends BaseCalc
{
   public SimpleCalc(long count,ReportResult rr)
   {
      super(count,rr);
      result=calc(count,0,1);
      rr.report("S",count,result);
   }
}
