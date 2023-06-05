
import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

public class ShapeBridgeImage extends ShapeBridge
{
   private BufferedImage image;
   private Graphics g;
   public ShapeBridgeImage(BufferedImage image)
   {
      this.image=image;
   }

   public void setImage(BufferedImage image)
   {
      this.image=image;
   }

   @Override public void _initialize()
   {
      g=image.getGraphics();
      g.setColor(Color.gray);
      g.fillRect(0,0,image.getWidth(),image.getHeight());
   }

   @Override public void _proceed(Shape shape)
   {
      shape.draw(g);
   }

   @Override public void _finalize()
   {
   }
}
