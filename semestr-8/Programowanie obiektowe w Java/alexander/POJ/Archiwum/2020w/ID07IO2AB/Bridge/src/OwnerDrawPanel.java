
import java.awt.Graphics;
import java.util.ArrayList;
import javax.swing.JPanel;

public class OwnerDrawPanel extends JPanel
{
   private ArrayList<PaintCall> listeners=new ArrayList<>();
   public OwnerDrawPanel(PaintCall pc) { addListener(pc); }
   public void addListener(PaintCall pc) { listeners.add(pc); }
   public void removeListener(PaintCall pc) { listeners.remove(pc); }
   public void clearListener() { listeners.clear(); }
   public void callListener(Graphics g) { for(PaintCall pc:listeners) pc.paint(g); }
   @Override public void paint(Graphics g)
   {
      super.paint(g);
      callListener(g);
   }
}
