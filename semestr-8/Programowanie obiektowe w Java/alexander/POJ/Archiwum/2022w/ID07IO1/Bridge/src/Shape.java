
import java.awt.Graphics;
import java.security.InvalidParameterException;

public abstract class Shape
{
   public abstract void draw(Graphics g);
   public static float[] parseParams(String text,int count)
   {
      String[] params=text.split("[\\s\t,;]+");
      if(count!=params.length) throw new InvalidParameterException(String.format("Bad parameters count expected %d",count));
      float[] result=new float[count];
      for(int i=0;i<count;++i) result[i]=Float.parseFloat(params[i]);
      return result;
   }
}
