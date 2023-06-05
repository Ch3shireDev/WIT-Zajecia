public class BaseCalc // 1/1+1/2+1/3 ... 1/count
{
   private final long count;
   private final int start,step;
   private final ReportResult rr;
   private double result=0;

   public BaseCalc(long count,int start,int step,ReportResult rr)
   {
      this.count=count;
      this.start=start;
      this.step=step;
      this.rr=rr;
   }

   public void calc()
   {
      for(int i=1+start;i<=count;i+=step) result+=((double)1)/i;
   }

   public void calcAndReport(String method)
   {
      calc();
      report(method);
   }

   public long getCount() { return count; }
   public double getResult() { return result; }
   public void addResult(double value) { result+=value; }
   public void report(String method) { rr.report(method,count,result); }
}
