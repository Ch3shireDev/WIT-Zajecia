package observertest;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;
import javax.swing.JLabel;

public class TimeSwitcher extends BaseObservable
{
   private static final SimpleDateFormat df=new SimpleDateFormat("HH.mm.ss");
   private final JLabel panel;
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
   
   private void timeCall()
   {
      String newTime=timeNow();
      if(!newTime.equals(strTime))
      {
         strTime=newTime;
         panel.setText(strTime);
         notifyObservers();
      }
   }
   
   private void setTime()
   {
      TimerTask task=new TimerTask()
      {
         @Override public void run() { timeCall(); }
      };
      new Timer().schedule(task,0,1000);
   }
}
