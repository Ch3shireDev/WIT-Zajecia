
import java.awt.Graphics;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class PaintPanel extends JPanel
{
   private BufferedImage image=new BufferedImage(1,1,BufferedImage.TYPE_INT_RGB);
   public PaintPanel()
   {
      ComponentAdapter adapter=new ComponentAdapter()
      {
         @Override public void componentResized(ComponentEvent e)
         {
           image=new BufferedImage(getWidth(),getHeight(),BufferedImage.TYPE_INT_RGB);
         }
      };
      addComponentListener(adapter);
   }

   @Override protected void paintComponent(Graphics g)
   {
      super.paintComponent(g);
      g.drawImage(image,0,0,this);
   }

   public Graphics g() { return image.getGraphics(); }
}
