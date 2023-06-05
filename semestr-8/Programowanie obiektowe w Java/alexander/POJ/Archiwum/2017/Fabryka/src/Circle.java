
import java.awt.Graphics;

public class Circle extends Shape
{
   public Circle(int size)
   {
      super(size);
   }
   @Override public String toString()
   {
      return "Circle: "+size;
   }
   @Override public void draw(Graphics g,int width,int height)
   {
      g.drawOval(50, 50, size, size);
   }
}
