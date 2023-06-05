import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

public class ShapeBridgeGraphics extends ShapeBridge
{
   private JImageBox field;
   private Graphics g;

   public ShapeBridgeGraphics(JImageBox field)
   {
      this.field=field;
   }

   @Override protected void init()
   {
      BufferedImage bitmap=new BufferedImage(field.getWidth(),field.getHeight(),BufferedImage.TYPE_INT_RGB);
      field.setImage(bitmap);
      g=bitmap.getGraphics();
      g.setColor(Color.lightGray);
      g.fillRect(0,0,bitmap.getWidth(),bitmap.getHeight());
   }

   @Override protected void Proceed(Shape shape)
   {
      shape.Draw(g);
   }

   @Override protected void finish()
   {
      field.repaint();
   }
}
