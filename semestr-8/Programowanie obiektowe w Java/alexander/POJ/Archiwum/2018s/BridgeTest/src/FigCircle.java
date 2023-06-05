public class FigCircle extends Figure
{
   private int x,y,width,height;   
   public FigCircle(String params)
   {
      String[] tb=params.split("\\s");
      if(tb.length>0) x=Integer.parseInt(tb[0]);
      if(tb.length>1) y=Integer.parseInt(tb[1]);
      if(tb.length>2) width=Integer.parseInt(tb[2]);
      if(tb.length>3) height=Integer.parseInt(tb[3]);
   }
   public int getX() { return x; }
   public int getY() { return y; }
   public int getWidth() { return width; }
   public int getHeight() { return height; }
   @Override public String toString() 
   {
      return "Circle(" + x + ", " + y + ", " + width + ", " + height + ')';
   }   
}