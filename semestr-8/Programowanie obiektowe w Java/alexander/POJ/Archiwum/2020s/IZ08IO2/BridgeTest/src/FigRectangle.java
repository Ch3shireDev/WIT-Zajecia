import java.awt.Color;
import java.awt.Graphics;
import java.security.InvalidParameterException;

public class FigRectangle extends Figure
{
   private int ax, ay, bx, by;
   public FigRectangle(int[] tb)
   {
      if(tb.length!=4) throw new InvalidParameterException("Expected 4 values");
      ax=tb[0];
      ay=tb[1];
      bx=tb[2];
      by=tb[3];
   }
   @Override protected void draw(Graphics g)
   {
      g.setColor(Color.blue);
      g.drawRect(ax, ay, bx-ax, by-ay);
   }
   @Override protected String getKind()
   {
      return "Rectangle";
   }
   @Override protected String getParameters()
   {
      return String.format("%d, %d, %d, %d", ax, ay, bx, by);
   }
}