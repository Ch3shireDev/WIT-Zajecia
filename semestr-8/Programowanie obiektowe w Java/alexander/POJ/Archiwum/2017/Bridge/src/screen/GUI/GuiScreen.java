package screen.GUI;

import core.*;
import screen.Screen;
import java.awt.Graphics;

public class GuiScreen extends Screen
{
   private Graphics g;
   public GuiScreen(Graphics g)
   {
      this.g=g;
   }
   @Override protected void DrawTriangle(Triangle f)
   {
      int[] xp = new int[] { f.a.x, f.b.x, f.c.x, f.a.x };
      int[] yp = new int[] { f.a.y, f.b.y, f.c.y, f.a.y };
      g.drawPolyline(xp, yp, 4);
   }
   @Override protected void DrawRectangle(Rectangle f)
   {
      //*///
      int[] xp = new int[] { f.a.x, f.b.x, f.b.x, f.a.x, f.a.x };
      int[] yp = new int[] { f.a.y, f.a.y, f.b.y, f.b.y, f.a.y };
      g.drawPolyline(xp, yp, 5);
      /*/
      int w=Math.abs(f.b.x-f.a.x), h=Math.abs(f.b.y-f.b.x);
      int x=Math.min(f.a.x,f.b.x), y=Math.min(f.a.y,f.b.y);
      g.drawRect(x, y, w, h);
      //*///
   }
   @Override protected void DrawCircle(Circle f)
   {
      int r=f.radius, r2=2*r;
      g.drawOval(f.mid.x-r, f.mid.y-r, r2, r2);
   }
}
