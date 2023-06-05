
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends Shape
{
   public ShapeCircle(String text)
   {
      super(text,3);
   }
   public int x() { return params[0]; }
   public int y() { return params[1]; }
   public int r() { return params[2]; }

   @Override public void Draw(Graphics g)
   {
      g.setColor(Color.red);
      g.drawOval(x()-r(),y()-r(),2*r(),2*r());
   }

   @Override public String toXml()
   {
      return String.format("<Circle x=%d y=%d r=%d/>",x(),y(),r());
   }

   @Override public String toString()
   {
      return String.format("Circle(%d,%d,%d)",x(),y(),r());
   }

}
