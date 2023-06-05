
import java.awt.Graphics;
import java.awt.Image;
import java.awt.LayoutManager;
import java.awt.image.BufferedImage;
import java.awt.image.ImageObserver;
import javax.swing.JPanel;

public class ImageBox extends JPanel
{
   private BufferedImage image;
   public ImageBox(BufferedImage image)
   {
      super();
      this.image=image;
   }

   public void setImage(BufferedImage image)
   {
      this.image=image;
   }

   @Override protected void paintComponent(Graphics g)
   {
      g.drawImage(image,0,0,null);
   }
}
