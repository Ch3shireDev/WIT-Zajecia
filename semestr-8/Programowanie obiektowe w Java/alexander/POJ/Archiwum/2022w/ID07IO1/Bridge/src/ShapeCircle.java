
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends Shape
{
   private float x,y,r;
   public ShapeCircle(String text)
   {
      float[] params=parseParams(text,3);
      x=params[0];
      y=params[1];
      r=params[2];
   }

   @Override public void draw(Graphics g)
   {
      g.setColor(Color.red);
      g.fillOval(Math.round(x-r),Math.round(y-r),Math.round(2*r),Math.round(2*r));
   }

   @Override public String toString()
   {
      return String.format("%g, %g; %g",x,y,r);
   }
}
