import java.util.concurrent.locks.ReentrantLock;

public class HarmonicTask 
{
   private final ReentrantLock lock = new ReentrantLock();
   private double sum=0;
   private int count,thcount,working;
   private final HarmonicTaskListener done;
   public HarmonicTask(int count,int thcount,HarmonicTaskListener done)
   {
      this.count=count;
      this.thcount=thcount;
      this.done=done;
      working=thcount;
      for(int i=0;i<thcount;++i)
      {
         int start=i+1;
         new Thread(() -> ThreadRun(start)).start();
      }
   }
   void ThreadRun(int start)
   {
      double part=0;
      for(int i=start;i<count;i+=thcount) part+=1.0/i;
      lock.lock();
      try
      {
         sum+=part;
         if((--working<=0)&&(done != null)) done.done(sum);
      }
      finally
      {
         lock.unlock();
      }
   }
}
