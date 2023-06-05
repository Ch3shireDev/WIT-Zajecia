
import java.util.logging.Level;
import java.util.logging.Logger;

public class HarmThread extends Thread implements DoublePicker
{
   private double sum=0;
   private long start,step,count;

   public HarmThread(long start,long step,long count)
   {
      this.start=start;
      this.step=step;
      this.count=count;
   }

   public static HarmThread go(long start,long step,long count)
   {
      HarmThread th=new HarmThread(start,step,count);
      th.start();
      return th;
   }

   @Override public void run()
   {
      sum=0;
      for(long i=start;i<=count;i+=step) sum+=1.0/i;
   }

   @Override public double get()
   {
      try { join(); }
      catch(InterruptedException ex) {}
      return sum;
   }
}
