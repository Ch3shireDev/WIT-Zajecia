import java.security.InvalidParameterException;

public class FigTriangle implements Figure
{
   private int ax,ay,bx,by,cx,cy;
   public FigTriangle(int[] tb)
   {
      if(tb.length != 6) throw new InvalidParameterException("Expected 6 values");
      ax=tb[0];
      ay=tb[1];
      bx=tb[2];
      by=tb[3];
      cx=tb[4];
      cy=tb[5];
   }

   @Override public String toString()
   {
      return String.format("Triangle(%d, %d, %d, %d, %d, %d)",ax,ay,bx,by,cx,cy);
   }
}
