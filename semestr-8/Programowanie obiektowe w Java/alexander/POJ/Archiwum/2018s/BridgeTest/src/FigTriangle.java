public class FigTriangle extends Figure
{
   private int x1,y1,x2,y2,x3,y3;   
   public FigTriangle(String params)
   {
      String[] tb=params.split("\\s");
      if(tb.length>0) x1=Integer.parseInt(tb[0]);
      if(tb.length>1) y1=Integer.parseInt(tb[1]);
      if(tb.length>2) x2=Integer.parseInt(tb[2]);
      if(tb.length>3) y2=Integer.parseInt(tb[3]);
      if(tb.length>4) x3=Integer.parseInt(tb[4]);
      if(tb.length>5) y3=Integer.parseInt(tb[5]);
   }
   public int getX1() { return x1; }
   public int getY1() { return y1; }
   public int getX2() { return x2; }
   public int getY2() { return y2; }
   public int getX3() { return x3; }
   public int getY3() { return y3; }
   @Override public String toString() 
   {
      return "Triangle(" + x1 + ", " + y1 + ", " + x2 + ", " + y2 +", " + x3 + ", " + y3 + ')';
   }   
}