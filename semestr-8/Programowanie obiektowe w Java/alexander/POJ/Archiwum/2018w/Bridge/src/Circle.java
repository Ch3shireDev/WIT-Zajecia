import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

public class Circle extends Figure
{
   public Point mid;
   public int radius;
   public Circle(Point mid,int radius)
   {
      this.mid=mid;
      this.radius=radius;
   }
   public Circle(int tb[])
   {
      this(new Point(tb[0],tb[1]),tb[2]);
   }
   public Circle(String str)
   {
      this(str2arr(str));
   }
   @Override public String getData()
   {
      return String.format("%d, %d, %d",mid.x,mid.y,radius);
   }
   @Override public String getXml()
   {
      return String.format("<Circle midx=%d midy=%d radius=%d/>",mid.x,mid.y,radius);
   }
   @Override public String getString()
   {
      return String.format("Circle/%d/%d/%d",mid.x,mid.y,radius);
   }
   public void paint(Graphics g)
   {
      g.setColor(Color.blue);
      g.drawOval(mid.x-radius,mid.y-radius,2*radius,2*radius);
   }
}
