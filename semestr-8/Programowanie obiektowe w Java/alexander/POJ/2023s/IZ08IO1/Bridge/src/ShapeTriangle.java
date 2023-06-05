
import java.awt.Color;
import java.awt.Graphics;

public class ShapeTriangle extends ShapeBase
{
    public int ax,ay,bx,by,cx,cy;
    public ShapeTriangle(String text)
    {
        ParseParameters(text,(v)->ax=v,(v)->ay=v,(v)->bx=v,(v)->by=v,(v)->cx=v,(v)->cy=v);
    }

    @Override public String xml()
    {
        return String.format("<triangle ax=\"%d\", ay=\"%d\", bx=\"%d\", by=\"%d\", cx=\"%d\", cy=\"%d\"/>",ax,ay,bx,by,cx,cy);
    }
    
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.green);
        int[] xs={ax,bx,cx,ax},ys={ay,by,cy,ay};
        g.drawPolyline(xs,ys,4);
    }
    
    @Override public String toString()
    {
        return "Triangle(ax:" + ax + ", ay:" + ay + ", bx:" + bx + ", by:" + by + ", cx:" + bx + ", cy:" + by + ')';
    }
}
