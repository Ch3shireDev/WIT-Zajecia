
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends Shape
{
   public ShapeCircle(String parameters)
   {
      super(parameters,3);
   }
   public int x() { return par[0]; }
   public int y() { return par[1]; }
   public int r() { return par[2]; }

   @Override public void draw(Graphics g)
   {
      g.setColor(Color.green);
      g.drawOval(x()-r(),y()-r(),2*r(),2*r());
   }

   @Override public String toXML()
   {
      return String.format("<Circle x=\"%d\" y=\"%d\" r=\"%d\"/>",x(),y(),r());
   }

   @Override public String toString()
   {
      return String.format("Circle(%d,%d,%d)",x(),y(),r());
   }
}
