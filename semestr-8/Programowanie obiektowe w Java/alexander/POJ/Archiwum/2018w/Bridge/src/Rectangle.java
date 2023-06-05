import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

public class Rectangle extends Figure
{
   public Point a,b;
   public Rectangle(Point a,Point b)
   {
      this.a=a;
      this.b=b;
   }
   public Rectangle(int tb[])
   {
      this(new Point(tb[0],tb[1]),new Point(tb[2],tb[3]));
   }
   public Rectangle(String str)
   {
      this(str2arr(str));
   }
   @Override public String getData()
   {
      return String.format("%d, %d, %d",a.x,a.y,b.x,b.y);
   }
   @Override public String getXml()
   {
      return String.format("<Rectangle ax=%d ay=%d bx=%d by=%d/>",a.x,a.y,b.x,b.y);
   }
   @Override public String getString()
   {
      return String.format("Rectangle/%d/%d/%d/%d",a.x,a.y,b.x,b.y);
   }
   public void paint(Graphics g)
   {
      g.setColor(Color.red);
      g.drawRect(Math.min(a.x,b.x),Math.min(a.y,b.y),Math.abs(b.x-a.x),Math.abs(b.y-a.y));
   }
}
