
import java.awt.Graphics;
import javax.swing.JPanel;

public class PaintPanel extends JPanel
{
   private final PaintCaller call;
   PaintPanel(PaintCaller call)
   {
      this.call=call;
   }
   @Override public void paint(Graphics g)
   {
      super.paint(g);
      call.paint(g);
   }
}
