import java.util.logging.Level;
import java.util.logging.Logger;

public class HarmThread extends Thread
{
   private double sum=0;
   private long start,step,count;
   private final DoubleSender sender;

   public HarmThread(long start,long step,long count,DoubleSender sender)
   {
      this.start=start;
      this.step=step;
      this.count=count;
      this.sender=sender;
   }

   public static void go(long start,long step,long count,DoubleSender sender)
   {
      HarmThread th=new HarmThread(start,step,count,sender);
      th.start();
   }

   @Override public void run()
   {
      sum=0;
      for(long i=start;i<=count;i+=step) sum+=1.0/i;
      sender.done(sum);
   }
}
