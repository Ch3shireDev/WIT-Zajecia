
import java.awt.Graphics;

public abstract class Shape 
{
   protected int size;
   public Shape(int size)
   {
      this.size=size;
   }
   public abstract void draw(Graphics g,int width,int height);
}
