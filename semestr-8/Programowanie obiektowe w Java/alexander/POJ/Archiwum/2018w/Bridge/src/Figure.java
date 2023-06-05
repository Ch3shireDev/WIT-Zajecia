
import java.awt.Graphics;

public abstract class Figure
{
   public void Draw(Screen screen) { screen.Draw(this); }
   public static int[] str2arr(String str)
   {
      final String[] src=str.split("\\s*,\\s*");
      int size=src.length;
      int[] tb=new int[size];
      for(int i=0;i<size;++i) tb[i]=Integer.parseInt(src[i]);
      return tb;
   }
   public abstract String getData();
   public abstract String getXml();
   public abstract String getString();
   public abstract void paint(Graphics g);
   @Override public String toString() { return getString(); }
}
