import java.util.Arrays;
import java.util.HashMap;
import java.util.concurrent.Semaphore;
import java.util.stream.Collectors;

public class SemaphoresABC
{
   private static final int DELAY=5;
   private static final HashMap<Character,Cicle> map=new HashMap<Character,Cicle>()
   {
      {
         
      }
   };

   public static void main(String[] args)
   {
      new Manager("ABCCBA").start();
   }

   private static final class Manager extends Thread
   {
      private final String order;
      private Semaphore me=new Semaphore(1,true);
      public Manager(String order)
      {
         this.order=order;
         char ch='A';
         SemaphoresABC.Cicle x=ch->new SemaphoresABC.Cicle((char)ch);
         map=Arrays.stream(order.toCharArray()).distinct().collect(Collectors.toMap(ch->ch,));
      }
   }

   private static final class Cicle extends Thread
   {
      private char Letter;
      private boolean Done=false;
      private final Semaphore manager;
      private Semaphore me=new Semaphore(0,true);
      public Cicle(char Letter,Semaphore manager)
      {
         this.Letter=Letter;
         this.manager=manager;
      }
      @Override
      @SuppressWarnings("SleepWhileInLoop")
      public void run()
      {
         try
         {
            while(!Done)
            {
                me.acquire();
                System.out.print(Letter+" ");
                manager.release();
                Thread.sleep(DELAY);
            }
         }
         catch(InterruptedException ex)
         {
            System.out.println("Ooops...");
            Thread.currentThread().interrupt();
         }
         System.out.println("\nThread "+Letter+": I'm done...");
       }
   }
}