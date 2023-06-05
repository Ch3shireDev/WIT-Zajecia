
import java.awt.Graphics;

public class Triangle extends Shape
{
   public Triangle(int size)
   {      
      super(size);
   }
   @Override public String toString()
   {
      return "Triangle: "+size;
   }
   @Override public void draw(Graphics g,int width,int height)
   {
      g.drawRect(50, 50, size, size);
   }
}
