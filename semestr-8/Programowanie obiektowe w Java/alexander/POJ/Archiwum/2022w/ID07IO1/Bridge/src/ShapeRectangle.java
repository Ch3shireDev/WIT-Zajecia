
import java.awt.Color;
import java.awt.Graphics;

public class ShapeRectangle extends Shape
{
   private float ax,ay,bx,by;
   public ShapeRectangle(String text)
   {
      float[] params=parseParams(text,4);
      ax=params[0];
      ay=params[1];
      bx=params[2];
      by=params[3];
   }

   @Override public void draw(Graphics g)
   {
      g.setColor(Color.green);
      g.fillRect(Math.round(ax),Math.round(ay),Math.round(bx-ax),Math.round(by-ay));
   }

   @Override public String toString()
   {
      return String.format("%g, %g; %g, %g",ax,ay,bx,by);
   }
}
