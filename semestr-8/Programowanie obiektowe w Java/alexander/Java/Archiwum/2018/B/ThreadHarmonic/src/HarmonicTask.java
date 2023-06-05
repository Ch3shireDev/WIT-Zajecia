
import java.util.concurrent.locks.ReentrantLock;

public class HarmonicTask 
{
   private static int thcount=Runtime.getRuntime().availableProcessors();
   private ReentrantLock lock=new ReentrantLock();
   private int count,working;
   private double sum;
   private HarmonicTaskDone done;
   public HarmonicTask(int count,HarmonicTaskDone done)
   {
      this.done=done;      
      this.count=count;
      working=thcount;
      sum=0;
      for(int i=0;i<thcount;++i)
      {
         int start=i+1;
         new Thread(() -> ThreadRun(start)).start();
      }
   }   
   private void ThreadRun(int start)
   {
      double part=0;
      for(int i=start;i<=count;i+=thcount) part+=1.0/i;
      lock.lock();
      try
      {
         sum+=part;
         if((--working<=0)&&(done!=null)) done.done(sum);
      }
      finally
      {
         lock.unlock();
      }
   }
   
}
