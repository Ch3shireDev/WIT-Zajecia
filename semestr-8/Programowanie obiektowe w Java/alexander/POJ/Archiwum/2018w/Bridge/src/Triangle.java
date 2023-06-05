import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

public class Triangle extends Figure
{
   public Point a,b,c;
   public Triangle(Point a,Point b,Point c)
   {
      this.a=a;
      this.b=b;
      this.c=c;
   }
   public Triangle(int tb[])
   {
      this(new Point(tb[0],tb[1]),new Point(tb[2],tb[3]),new Point(tb[4],tb[5]));
   }
   public Triangle(String str)
   {
      this(str2arr(str));
   }
   @Override public String getData()
   {
      return String.format("%d, %d, %d",a.x,a.y,b.x,b.y,c.x,c.y);
   }
   @Override public String getXml()
   {
      return String.format("<Triangle ax=%d ay=%d bx=%d by=%d cx=%d cy=%d/>",a.x,a.y,b.x,b.y,c.x,c.y);
   }
   @Override public String getString()
   {
      return String.format("Triangle/%d/%d/%d/%d/%d/%d",a.x,a.y,b.x,b.y,c.x,c.y);
   }
   public void paint(Graphics g)
   {
      g.setColor(Color.yellow);
      g.drawPolyline(new int[] {a.x,b.x,c.x,a.x},new int[] {a.y,b.y,c.y,a.y},4);
   }
}
