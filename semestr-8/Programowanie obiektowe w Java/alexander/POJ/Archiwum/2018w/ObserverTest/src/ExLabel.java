
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;
import javax.swing.JLabel;

public class ExLabel extends JLabel implements Observable
{
   private String last="";
   private static final SimpleDateFormat df=new SimpleDateFormat("HH.mm.ss");
   private BaseObservable bo=new BaseObservable();
   public void notifyObservers() { bo.notifyObservers(); } 
   public void addObserver(Observer ob) { bo.addObserver(ob); }
   public void dropObserver(Observer ob) { bo.dropObserver(ob); }
   public void clearObservers() { bo.clearObservers(); }
   public ExLabel()
   {
      super();
      final TimerTask task=new TimerTask()
      {
         @Override public void run() { timeCall(); }
      };
      new Timer().schedule(task,0,100);
   }
   private void timeCall()
   {
      String now=df.format(new Date());
      if(!now.equals(last))
      {
         setText(last=now);
         notifyObservers();
      }
   }
}
