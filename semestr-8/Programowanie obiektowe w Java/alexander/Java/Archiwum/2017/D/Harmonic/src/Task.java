public class Task implements Runnable, Comparable<Task>
{
   private final TaskPriority Priority;
   private final Result Result;
   public Task(TaskPriority Priority,long Count)
   {
      this.Priority=Priority;
      Result=new Result(Count);
   }

   public Result getResult() { return Result; }   
   
   @Override public void run() 
   {
      double sum=0;
      for(long i=1;i<=Result.getCount();++i) sum+=1.0/i;
      Result.setValue(sum);
   }
   @Override public int compareTo(Task obj) 
   {
      return Priority.getValue()-obj.Priority.getValue();
   }
}
