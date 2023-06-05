public abstract class HarmonicCalc
{
   // 1/1 + 1/2 + 1/3 + ... 1/N
   protected long count;
   protected ValueReport report;
   public HarmonicCalc(long count,ValueReport report)
   {
      this.count=count;
      this.report=report;
   }
   public abstract void calc();
}
