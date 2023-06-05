import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JPanel;

public class FigureBridgePanel extends FigureBridge
{
   private final JPanel pn;
   private Graphics g;
   
   public FigureBridgePanel(JPanel pn)
   {
      this.pn = pn;
   }
   @Override protected void initialize()
   {
      g = pn.getGraphics();
      g.setColor(Color.yellow);
      g.fillRect(0, 0, pn.getWidth(), pn.getHeight());
   }
   @Override protected void proceed(Figure fig)
   {
      fig.draw(g);
   }
   @Override protected void finalize()
   {
   }
}
