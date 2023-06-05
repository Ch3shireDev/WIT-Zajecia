
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends ShapeBase
{
    private int cx,cy,r;
    public ShapeCircle(String text)
    {
        parse(text, (v)->cx=v, (v)->cy=v, (v)->r=v);
    }
    
    @Override public void Draw(Graphics g)
    {
        g.setColor(Color.red);
        g.drawOval(cx-r,cy-r,2*r,2*r);
    }
    
    @Override public String toXML()
    {
        return String.format("<circle cx=\"%d\" cy=\"%d\" r=\"%d\" />",cx,cy,r);
    }

    @Override public String toString()
    {
        return String.format("Circle(cx:%d,cy:%d,r:%d)",cx,cy,r);
    }
}
