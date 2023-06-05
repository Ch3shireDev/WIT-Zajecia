
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends ShapeBase
{
    public int cx,cy,r;
    public ShapeCircle(String text)
    {
        ParseParameters(text,(v)->cx=v,(v)->cy=v,(v)->r=v);
    }

    @Override public String xml()
    {
        return String.format("<circle cx=\"%d\", cy=\"%d\", r=\"%d\"/>",cx,cy,r);
    }
    
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.red);
        g.drawOval(cx-r, cy-r, 2*r, 2*r);
    }
    
    @Override public String toString()
    {
        return "Circle(cx:" + cx + ", cy:" + cy + ", r:" + r + ')';
    }
}
