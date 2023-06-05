
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class ImagePanel extends JPanel
{
   private BufferedImage image=null;

   public void setImage(BufferedImage image)
   {
      this.image=image;
      invalidate();
      repaint();
   }
   @Override protected void paintComponent(Graphics g)
   {
      super.paintComponent(g);
      if(image!=null) g.drawImage(image,0,0,this);
   }
}