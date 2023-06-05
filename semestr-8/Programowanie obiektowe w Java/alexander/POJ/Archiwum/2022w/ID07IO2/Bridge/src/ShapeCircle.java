
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends Shape
{
   private int x,y,r;
   public ShapeCircle(String text)
   {
      int[] params=parseParameters(text,3);
      x=params[0];
      y=params[1];
      r=params[2];
   }
   
   @Override public void draw(Graphics g)
   {
      g.setColor(Color.red);
      g.drawOval(x-r,y-r,r<<1,r<<1);
   }

   @Override public String xml()
   {
      return String.format("\t\t<Circle x=%d y=%d r=%d>\n",x,y,r);
   }

   @Override public String toString()
   {
      return String.format("Circle: %d, %d; %d",x,y,r);
   }
}
