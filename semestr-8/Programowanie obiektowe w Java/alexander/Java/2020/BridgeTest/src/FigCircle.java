import java.security.InvalidParameterException;

public class FigCircle implements Figure
{
   private int x,y,r;
   public FigCircle(int[] tb)
   {
      if(tb.length != 3) throw new InvalidParameterException("Expected 3 values");
      x=tb[0];
      y=tb[1];
      r=tb[2];
   }

   @Override public String toString()
   {
      return String.format("Circle(%d, %d, %d)",x,y,r);
   }
}
