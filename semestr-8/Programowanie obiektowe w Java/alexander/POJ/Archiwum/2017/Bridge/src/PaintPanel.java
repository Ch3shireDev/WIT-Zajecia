
import java.awt.Graphics;
import javax.swing.JPanel;

public class PaintPanel extends JPanel
{
   private Runnable call;
   public void setCall(Runnable call) { this.call=call; }
   @Override public void paint(Graphics g)
   {
      super.paint(g);
      if(call!=null) call.run();
   }
}
