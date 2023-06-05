import java.awt.Color;
import java.awt.Graphics;
import java.security.InvalidParameterException;

public class FigTriangle implements Figure
{
   private int ax, ay, bx, by, cx, cy;
   public FigTriangle(int[] tb)
   {
      if(tb.length!=6) throw new InvalidParameterException("Expected 6 values");
      ax=tb[0];
      ay=tb[1];
      bx=tb[2];
      by=tb[3];
      cx=tb[4];
      cy=tb[5];
   }
   @Override public void Draw(Graphics g)
   {
      g.setColor(Color.green);
      g.drawPolyline(new int[] {ax, bx, cx, ax}, new int[] {ay, by, cy, ay}, 4);
   }
   @Override public String getKind()
   {
      return "Triangle";
   }
   @Override public String getParameters()
   {
      return String.format("%d, %d, %d, %d, %d, %d", ax, ay, bx, by, cx, cy);
   }
   @Override public String toString()
   {
      return getKind()+"("+getParameters()+")";
   }
}