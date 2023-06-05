public class Result 
{
   private final long Count;
   private double Value;
   public Result(long Count)
   {
      this.Count=Count;
      Value=-1;
   }
   public long getCount() { return Count; }
   public double getValue() { return Value; }
   public void setValue(double Value) { this.Value = Value; }
   @Override public String toString() 
   {
      return String.format("%d: %.18f", Count, Value); 
   }   
}
