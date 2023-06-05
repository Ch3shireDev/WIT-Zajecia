package listenertestsync;

import java.util.logging.Level;
import java.util.logging.Logger;

public class ListenerTestSync
{
   public static void main(String[] args)  
   {
      new Manager().run();
      System.out.println("end of run");
   }
}

interface MyListener
{
   public void myCall(int value,int id);
}

class Worker implements Runnable
{
   private MyListener listener;
   private Worker forNotify;
   private final int start;
   public void setListener(MyListener listener) { this.listener = listener; }
   public void setForNotify(Worker forNotify) { this.forNotify = forNotify; }
   public Worker(int start) { this.start=start; }
   @Override public void run() 
   {
      for(int i=start;i<100;i+=3)
      {
         try 
         {
            synchronized(this) 
            {
               wait();
            }
            listener.myCall(i+1,start);
            synchronized(forNotify) 
            {
               forNotify.notify();
            }            
         } 
         catch (InterruptedException ex)
         {
         }
      }
   }
}

class Manager
{
    final static int ThreadCount=3;
    Thread [] tb=new Thread[ThreadCount];
    void run() 
    {
       Worker [] tbw=new Worker[ThreadCount];
       for(int i=0;i<ThreadCount;++i)
       {
          Worker w=new Worker(i);
          w.setListener(new MyListener() { public void myCall(int value,int id) { show(value,id); }  } );
          tbw[i]=w;
          tb[i]=new Thread(w);          
       }
       for(int i=0;i<ThreadCount;++i) tbw[i].setForNotify(tbw[(i+1)%ThreadCount]);
       for(int i=0;i<ThreadCount;++i) tb[i].start();
       synchronized(tbw[0]) 
       {
          tbw[0].notify(); 
       }
    }    
    void show(int value,int id) 
    {
       System.out.println(value);
    }
}