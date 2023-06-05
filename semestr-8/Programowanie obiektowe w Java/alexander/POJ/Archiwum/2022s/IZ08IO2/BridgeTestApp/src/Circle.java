
import java.awt.Color;
import java.awt.Graphics;

public class Circle extends Shape
{
   public Circle(String parameters)
   {
      super(parameters,3);
   }
   int getX() { return tb[0]; }
   int getY() { return tb[1]; }
   int getR() { return tb[2]; }

   @Override public void Draw(Graphics g)
   {
      g.setColor(Color.red);
      g.fillOval(getX()-getR(),getY()-getR(),2*getR(),2*getR());
   }

   @Override public String toXml()
   {
      return String.format("<Circle x=%d y=%d r=%d/>",getX(),getY(),getR());
   }

   @Override public String toString()
   {
      return String.format("Circle(%d,%d,%d)",getX(),getY(),getR());
   }
}
