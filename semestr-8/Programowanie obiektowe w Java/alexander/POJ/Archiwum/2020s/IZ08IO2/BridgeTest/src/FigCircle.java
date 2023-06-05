import java.awt.Color;
import java.awt.Graphics;
import java.security.InvalidParameterException;

public class FigCircle extends Figure
{
   private int x, y, r;
   public FigCircle(int[] tb)
   {
      if(tb.length!=3) throw new InvalidParameterException("Expected 3 values");
      x=tb[0];
      y=tb[1];
      r=tb[2];
   }
   @Override protected void draw(Graphics g)
   {
      g.setColor(Color.red);
      g.drawOval(x-r, y-r, r<<1, r<<1);
   }
   @Override protected String getKind()
   {
      return "Circle";
   }
   @Override protected String getParameters()
   {
      return String.format("%d, %d, %d", x, y, r);
   }
}