// 1/1, 1/2, 1/3,
// Ai=1/i
public abstract class HarmonicCalc
{
   private final long Count;
   private final HarmonicCalcDone DoneEvent;
   public HarmonicCalc(long Count,HarmonicCalcDone Done)
   {
      this.Count=Count;
      this.DoneEvent=Done;
   }
   public long getCount() { return Count; }
   public void CallDone(double sum) { DoneEvent.Done(Count,sum); }
   public abstract void Sum();
}
