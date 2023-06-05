
import java.awt.Color;
import java.awt.Graphics;

public class ShapeCircle extends ShapeBase
{
    private int cx,cy,r;
    public ShapeCircle(String text)
    {
        parse(text, (v)->cx=v, (v)->cy=v, (v)->r=v);
    }
    
    @Override public String toXml()
    {
        return String.format("<Circle cx=\"%d\" cy=\"%d\" r=\"%d\" />", cx,cy,r);
    }
    
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.red);
        g.drawOval(cx-r,cy-r,2*r,2*r);
    }

    @Override public String toString()
    {
        return String.format("Circle(cx:%d, cy:%d, r:%d)", cx,cy,r);
    }
}
