public class HarmonicCalcSimple extends HarmonicCalc
{
   public HarmonicCalcSimple(long Count,HarmonicCalcDoneEvent DoneEvent)
   {
      super(Count,DoneEvent);
   }
   // 1/1 1/2 1/3 1/4 ...
   @Override public void sum()
   {
      double Sum=0;
      long count=getCount();
      for(long i=1;i<=count;++i) Sum+=1.0/i;
      CallDoneEven(count,Sum,"Simple");
   }
}
