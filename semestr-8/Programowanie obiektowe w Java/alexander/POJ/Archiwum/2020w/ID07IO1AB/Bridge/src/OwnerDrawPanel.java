
import java.awt.Graphics;
import java.util.ArrayList;
import javax.swing.JPanel;

public class OwnerDrawPanel extends JPanel
{
   private ArrayList<DrawCall> calls=new ArrayList<>();
   public OwnerDrawPanel(DrawCall dc)
   {
      addListener(dc);
   }
   public void addListener(DrawCall dc) { calls.add(dc); }
   public void removeListener(DrawCall dc) { calls.remove(dc); }
   public void clearListener() { calls.clear(); }
   public void docall(Graphics g) { for(DrawCall dc:calls) dc.onDraw(g); }

   @Override public void paint(Graphics g)
   {
      super.paint(g);
      docall(g);
   }
}
