public class BaseCalc
{
   protected long count;
   protected ReportResult rr;
   protected double result;

   public BaseCalc(long count,ReportResult rr)
   {
      this.count=count;
      this.rr=rr;
   }

   protected double calc(long count,int start,int step)
   { // 1/1 + 1/2 + 1/3 ... 1/count
      double sum=0;
      for(long i=1+start;i<=count;i+=step) sum+=((double)1)/i;
      return sum;
   }
}
