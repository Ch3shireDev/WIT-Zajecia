
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.locks.ReentrantLock;

public class SynchronizeThreadLock
{
   private double sum;
   private final ReentrantLock lock=new ReentrantLock();
   public SynchronizeThread()
   {
      sum=0;
   }

   public void proceedThread(int ThreadId)
   {
      double partSum=3.56754+6.4325234*ThreadId;
      lock.lock();
      try
      {
         sum+=partSum;
      }
      finally
      {
         lock.unlock();
      }
   }

   public double getSum() {
      return sum;
   }

}

public class SynchronizeThreadCount
{
   private double sum;
   private AtomicInteger partCount=new AtomicInteger();
   private double[] partValues;

   public SynchronizeThreadCount(int partCount)
   {
      this.partCount.set(partCount);
      partValues=new double[partCount];
      sum=0;
   }

   public void proceedThread(int ThreadId)
   {
      double partSum=3.56754+6.4325234*ThreadId;
      partValues[ThreadId]=partSum;
      if(partCount.decrementAndGet()==0)
      {
         for(double v:partValues) sum+=v;
      }
   }

   public double getSum() {
      return sum;
   }

}
