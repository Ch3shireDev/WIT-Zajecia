
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends Shape
{
   public ShapeCircle(String text)
   {
      super(text,3);
   }
   public int x() { return tb[0]; }
   public int y() { return tb[1]; }
   public int r() { return tb[2]; }

   @Override public void Draw(Graphics g)
   {
      g.setColor(Color.red);
      g.fillOval(x()-r(),y()-r(),2*r(),2*r());
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
