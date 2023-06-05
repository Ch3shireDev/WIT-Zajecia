import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class ImageBox extends JPanel
{
   private BufferedImage image=null;
   private Graphics g;
   public void setImage(BufferedImage image)
   {
      this.image=image;
      if(image!=null) g=image.getGraphics();
      else g=null;
   }
   @Override protected void paintComponent(Graphics g)
   {
      if(image!=null) g.drawImage(image,0,0,null);
   }
}
