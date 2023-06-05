
import java.awt.Color;
import java.awt.Graphics;

public class ShapeTriangle extends Shape
{
   private float ax,ay,bx,by,cx,cy;
   public ShapeTriangle(String text)
   {
      float[] params=parseParams(text,6);
      ax=params[0];
      ay=params[1];
      bx=params[2];
      by=params[3];
      cx=params[4];
      cy=params[5];
   }

   @Override public void draw(Graphics g)
   {
      g.setColor(Color.blue);
      //g.drawPolyline
      g.fillPolygon
      (
         new int[] { Math.round(ax),Math.round(bx),Math.round(cx),Math.round(ax) },
         new int[] { Math.round(ay),Math.round(by),Math.round(cy),Math.round(ay) },
         4
      );
   }

   @Override public String toString()
   {
      return String.format("%g, %g; %g, %g; %g, %g",ax,ay,bx,by,cx,cy);
   }
}
