public class Result implements Comparable   
{
   private final long Count;
   private final TaskPriority Priority;
   private double Value;

   public Result(TaskPriority Priority,long Count)
   {
      this.Priority=Priority;
      this.Count=Count;
      Value=-1;
   }

   public long getCount() { return Count; }
   public double getValue() { return Value; }
   public void setValue(double Value) { this.Value=Value; }
   
   @Override public String toString() 
   {
      return String.format("%d: %.18f",Count,Value);
   }   

   @Override public int compareTo(Object o) 
   {
      if(!(o instanceof Result)) return 0;
      return Priority.getValue()-((Result)o).Priority.getValue();
   }
}
