import java.awt.Color;
import java.util.ArrayList;
import javax.swing.JPanel;

public class TickPanel extends JPanel implements TickSender,TickListener
{
   private static Color[] colors=new Color[] { Color.BLUE,Color.GREEN };
   private int state=0;
   private ArrayList<TickListener> lst=new ArrayList<>();

   public TickPanel() { AdjustState(); }
   @Override public void AddTickListener(TickListener t) { lst.add(t); }
   @Override public void RemoveTickListener(TickListener t) { lst.remove(t); }
   @Override public void Clear() { lst.clear(); }
   @Override public void Call(TickSender sender) { lst.forEach((t) -> t.signal(sender)); }
   @Override public void signal(TickSender sender) { NextState(); }
   private void AdjustState() { setBackground(colors[state]); }

   private void NextState()
   {
      state=(state+1)%colors.length;
      if(state==0) Call(this);
      AdjustState();
      invalidate();
   }
}
