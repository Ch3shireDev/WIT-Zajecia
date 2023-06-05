import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class ImagePaintBox extends JPanel
{
   private BufferedImage bim=null;
   public BufferedImage getImage() { return bim; }
   public void resizeImage() 
   {
      int W=getWidth(),H=getHeight();
      if((W>0)&&(H>0)) bim = new BufferedImage(W,H,BufferedImage.TYPE_INT_RGB);
      else bim = null;
   }
   public ImagePaintBox() {}
   @Override public void paintComponent(Graphics g)
   {
      super.paintComponent(g);
      if(bim!=null) g.drawImage(bim,0,0,null);
      repaint();
   }
}
