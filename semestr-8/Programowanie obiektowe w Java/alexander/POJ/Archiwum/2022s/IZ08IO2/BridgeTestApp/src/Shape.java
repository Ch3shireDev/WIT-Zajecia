
import java.awt.Graphics;

public abstract class Shape
{
   protected int[] tb;
   public Shape(String parameters,int count)
   {
      String[] vals=parameters.split("[\\s\t;]+");
      if(vals.length!=count) throw new IllegalArgumentException("Wrong parameters count");
      tb=new int[vals.length];
      for(int i=0;i<vals.length;++i) tb[i]=Integer.parseInt(vals[i]);
   }
   public abstract void Draw(Graphics g);
   public abstract String toXml();
}
