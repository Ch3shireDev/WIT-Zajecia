import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JPanel;

public class FigureBridgePanel extends FigureBridge
{
   private JPanel pn;
   private Graphics g;
   public FigureBridgePanel(JPanel pn)
   {
      this.pn=pn;
   }
   @Override protected void initialize()
   {
      g=pn.getGraphics();
      g.setColor(Color.white);
      g.fillRect(0, 0, pn.getWidth(), pn.getHeight());
   }
   @Override protected void finalize()
   {
   }
   @Override protected void proceed(Figure fig)
   {
      fig.Draw(g);
   }
}
