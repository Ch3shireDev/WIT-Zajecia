
import java.util.logging.Level;
import java.util.logging.Logger;

public class ListenerMain 
{
   public static void main(String[] args)  
   {
      new Manager().run(); 
   }
}

interface MyListener
{
   public void myCall(int value,int id);
}

class Worker implements Runnable
{
   private MyListener listener;
   private final int start;
   public void setListener(MyListener listener) { this.listener = listener; }
   public Worker(int start) { this.start=start; }
   @Override public void run() 
   {
      for(int i=start;i<100;i+=3) listener.myCall(i+1,start);
   }
}

class Manager
{
    final static int ThreadCount=3;
    Thread [] tb=new Thread[ThreadCount];
    volatile int currid;
    void run() 
    {
       for(int i=0;i<ThreadCount;++i)
       {
          Worker w=new Worker(i);
          w.setListener(new MyListener() { public void myCall(int value,int id) { show(value,id); }  } );
          tb[i]=new Thread(w);
       }
       currid=0;
       for(int i=0;i<ThreadCount;++i) tb[i].start();
    }    
    void show(int value,int id) 
    {
       try 
       {
          while(currid!=id) Thread.sleep(10);
          System.out.println(value);
          currid=(currid+1)%ThreadCount;
       }
       catch (InterruptedException ex)
       {
       }
    }
}