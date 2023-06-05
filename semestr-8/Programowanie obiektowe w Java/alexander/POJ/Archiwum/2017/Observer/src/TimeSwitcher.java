import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import javax.swing.JLabel;
import java.util.Timer;
import java.util.TimerTask;

public class TimeSwitcher implements IntObservable
{
   private static final SimpleDateFormat df=new SimpleDateFormat("HH.mm.ss");
   private final JLabel panel;
   private final ArrayList<IntObserver> objList=new ArrayList<>();
   private String strTime;
   
   public TimeSwitcher(JLabel panel)
   {
      this.panel=panel;
      setTime();      
   }
   
   private String timeNow()
   {
      return df.format(new Date());
   }
   
   private void setTime()
   {
      final Timer timer=new Timer();
      TimerTask task=new TimerTask()
      {
        @Override public void run() 
        {
           String newTime=timeNow();
           if(!newTime.equals(strTime))
           {
              strTime=newTime;
              panel.setText(strTime);
              doNotifyAll(strTime);
           }
        }
      };
      timer.schedule(task,0,1000);
   }

   private void doNotifyAll(String time)
   {
      for(IntObserver obj:objList) obj.doNotify(time);
   }
   
   @Override public void addObserver(IntObserver obj) 
   {
      objList.add(obj);
   }

   @Override public void removeObserver(IntObserver obj) 
   {
      objList.remove(obj);
   }

   @Override public void clearObservers() 
   {
      objList.clear();
   }
}
