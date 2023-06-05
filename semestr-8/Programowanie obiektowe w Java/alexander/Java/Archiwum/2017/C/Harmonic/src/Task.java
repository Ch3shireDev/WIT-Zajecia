
public class Task implements Runnable, Comparable  
{
   private final Result result;
   public Task(TaskPriority priority,long Count)
   {
      result=new Result(priority,Count);
   }

   public Result getResult() { return result; }

   @Override public void run()
   {
      double sum=0;
      for(long i=1;i<=result.getCount();++i) sum+=1.0/i;
      result.setValue(sum);
   }   
   
   @Override public int compareTo(Object o) 
   {
      return result.compareTo(o);
   }
}
