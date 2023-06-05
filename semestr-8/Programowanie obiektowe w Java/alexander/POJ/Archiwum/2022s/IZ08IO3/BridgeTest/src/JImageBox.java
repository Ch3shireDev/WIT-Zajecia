
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

class JImageBox extends JPanel
{
   private BufferedImage bitmap=null;

   public void setImage(BufferedImage bitmap)
   {
      this.bitmap=bitmap;
   }

   @Override
   public void print(Graphics g)
   {
      super.print(g);
      if(bitmap!=null) g.drawImage(bitmap,0,0,null);
   }
}
