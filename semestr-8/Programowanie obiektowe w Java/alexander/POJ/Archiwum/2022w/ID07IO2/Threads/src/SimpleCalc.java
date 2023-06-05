public class SimpleCalc extends BaseCalc
{
   public SimpleCalc(long count,ReportResult rr)
   {
      super(count,0,1,rr);
      calc();
      report("S");
   }
}
