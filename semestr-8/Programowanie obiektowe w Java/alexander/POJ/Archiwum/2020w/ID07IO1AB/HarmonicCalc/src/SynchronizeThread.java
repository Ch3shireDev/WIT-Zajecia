
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.locks.ReentrantLock;


class SynchronizeThreadLock
{
   private static final int PartCount=100;
   private double sum;
   private ReentrantLock lock=new ReentrantLock();

   public SynchronizeThreadLock()
   {
      sum=0;
   }
   void calcPart(int id)
   {
      double returnedPartValue=(3.0+id)+7;
      lock.lock();
      try
      {
         sum+=returnedPartValue;
      }
      finally
      {
         lock.unlock();
      }
   }
   public double getReuslt() { return sum; }
}

class SynchronizeThreadTable
{
   private static final int PartCount=100;
   private int waitFor;
   private double[] partValues=new double[PartCount];
   private double sum;

   public SynchronizeThreadTable()
   {
      waitFor=PartCount;
   }
   void calcPart(int id)
   {
      double returnedPartValue=(3.0+id)+7;
      partValues[id]=returnedPartValue;
      if((--waitFor)==0)
      {
         sum=0;
         for(double v:partValues) sum+=v;
      }
   }
   public double getReuslt()
   {
      return sum;
   }
}
class SynchronizeThreadTableAtomic
{
   private static final int PartCount=100;
   private AtomicInteger waitFor=new AtomicInteger();
   private double[] partValues=new double[PartCount];
   private double sum;

   public SynchronizeThreadTableAtomic()
   {
      waitFor.set(PartCount);
   }
   void calcPart(int id)
   {
      double returnedPartValue=(3.0+id)+7;
      partValues[id]=returnedPartValue;
      if(waitFor.decrementAndGet()==0)
      {
         sum=0;
         for(double v:partValues) sum+=v;
      }
   }
   public double getReuslt()
   {
      return sum;
   }
}
