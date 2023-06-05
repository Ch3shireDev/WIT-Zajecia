public abstract class HarmonicCalc
{
   private final long Count;
   private final HarmonicCalcDoneEvent DoneEvent;
   public HarmonicCalc(long Count,HarmonicCalcDoneEvent DoneEvent)
   {
      this.Count=Count;
      this.DoneEvent=DoneEvent;
   }
   public long getCount() { return Count; }
   public void CallDoneEven(long count,double sum,String method)
   {
      DoneEvent.Done(count, sum, method);
   }
   public abstract void sum();
}
