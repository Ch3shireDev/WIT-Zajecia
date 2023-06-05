import java.util.ArrayList;

public class TickEvent implements TickSender
{
   private ArrayList<TickListener> lst=new ArrayList<>();
   public void AddTickListener(TickListener t) { lst.add(t); }
   public void RemoveTickListener(TickListener t) { lst.remove(t); }
   public void Clear() { lst.clear(); }
   public void Call(TickSender sender) { lst.forEach((t) -> t.signal(sender)); }
}
