
import java.awt.Color;
import java.awt.Graphics;

public class ShapeTriangle extends Shape
{
   public ShapeTriangle(String parameters)
   {
      super(parameters,6);
   }
   public int ax() { return par[0]; }
   public int ay() { return par[1]; }
   public int bx() { return par[2]; }
   public int by() { return par[3]; }
   public int cx() { return par[4]; }
   public int cy() { return par[5]; }

   @Override public void draw(Graphics g)
   {
      g.setColor(Color.red);
      g.drawPolyline
      (
         new int[] { ax(),bx(),cx(),ax() },
         new int[] { ay(),by(),cy(),ay() },
         4
      );
   }

   @Override public String toXML()
   {
      return String.format("<Triangle ax=\"%d\" ay=\"%d\" bx=\"%d\" by=\"%d\" cx=\"%d\" cy=\"%d\"/>",ax(),ay(),bx(),by(),cx(),cy());
   }

   @Override public String toString()
   {
      return String.format("Triangle(%d,%d,%d,%d,%d,%d)",ax(),ay(),bx(),by(),cx(),cy());
   }
}
