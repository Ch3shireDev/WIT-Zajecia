
import java.awt.Graphics;

public abstract class Shape
{
   protected int[] params;
   public Shape(String text,int count)
   {
      params=parameters(text);
      if(params.length!=count) throw new IllegalArgumentException("Wrong parameters count");
   }
   public abstract void Draw(Graphics g);
   public abstract String toXml();
   public static int[] parameters(String text)
   {
      String[] items=text.split("[\\s\t,;]+");
      int size=items.length;
      int[] params=new int[size];
      for(int i=0;i<size;++i) params[i]=Integer.parseInt(items[i]);
      return params;
   }
}
