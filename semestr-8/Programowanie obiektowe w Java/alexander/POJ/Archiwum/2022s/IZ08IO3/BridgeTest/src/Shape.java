
import java.awt.Graphics;

public abstract class Shape
{
   protected int[] tb;
   public Shape(String text,int count)
   {
      String[] params=text.split("[\\s\t;]+");
      if(params.length!=count) throw new IllegalArgumentException("Niueodpowiednia ilość parametrów");
      tb=new int[count];
      for(int i=0;i<count;++i) tb[i]=Integer.parseInt(params[i]);
   }
   public abstract void Draw(Graphics g);
   public abstract String toXml();
}
