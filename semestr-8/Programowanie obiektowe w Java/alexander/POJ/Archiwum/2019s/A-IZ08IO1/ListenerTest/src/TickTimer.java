import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

public class TickTimer implements TickSender
{
   private ArrayList<TickListener> lst=new ArrayList<>();
   @Override public void AddTickListener(TickListener t) { lst.add(t); }
   @Override public void RemoveTickListener(TickListener t) { lst.remove(t); }
   @Override public void Clear() { lst.clear(); }
   @Override public void Call(TickSender sender) { lst.forEach((t) -> t.signal(sender)); }
   TickTimer()
   {
      TimerTask ts=new TimerTask() { @Override public void run() { Call(TickTimer.this); } };
      new Timer().schedule(ts,1000,1000);
   }
}