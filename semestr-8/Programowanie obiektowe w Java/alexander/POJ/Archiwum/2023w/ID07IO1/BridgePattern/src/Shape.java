
import java.awt.Graphics;
import java.security.InvalidParameterException;

public abstract class Shape
{
   protected final int[] par;
   public Shape(String parameters,int size)
   {
      String[] sp=parameters.split("[\\s;]+");
      if(sp.length!=size) throw new InvalidParameterException("Wrong parameters count");
      par=new int[size];
      for(int i=0;i<size;++i) par[i]=Integer.parseInt(sp[i]);
   }
   public abstract void draw(Graphics g);
   public abstract String toXML();
}
