
import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

public class ShapeListToImageBridge extends ShapeListBridge
{
   private BufferedImage image=null;
   private Graphics g=null;

   public void setImage(BufferedImage image)
   {
      this.image=image;
      g=image.getGraphics();
   }

   @Override protected void _initialize()
   {
      g.setColor(Color.gray);
      g.fillRect(0,0,image.getWidth(),image.getHeight());
   }

   @Override protected void proceed(Shape shape)
   {
      shape.draw(g);
   }

   @Override protected void _finalize()
   {
   }
}
