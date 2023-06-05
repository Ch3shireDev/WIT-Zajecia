package screen.TUI;
import core.*;
import screen.Screen;

public class TuiScreen  extends Screen
{
   @Override protected void DrawTriangle(Triangle f)
   {
      System.out.format("Triangle (%d,%d),(%d,%d),(%d,%d)\n",f.a.x,f.a.y,f.b.x,f.b.y,f.c.x,f.c.y);
   }
   @Override protected void DrawRectangle(Rectangle f)
   {
      System.out.format("Rectangle (%d,%d),(%d,%d)\n",f.a.x,f.a.y,f.b.x,f.b.y);
   }
   @Override protected void DrawCircle(Circle f)
   {
      System.out.format("Circle (%d,%d),%d\n",f.mid.x,f.mid.y,f.radius);
   }
}
