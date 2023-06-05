import java.security.InvalidParameterException;

public class FigRectangle implements Figure
{
   private int ax,ay,bx,by;
   public FigRectangle(int[] tb)
   {
      if(tb.length != 4) throw new InvalidParameterException("Expected 4 values");
      ax=tb[0];
      ay=tb[1];
      bx=tb[2];
      by=tb[3];
   }

   @Override public String toString()
   {
      return String.format("Rectangle(%d, %d, %d, %d)",ax,ay,bx,by);
   }
}
