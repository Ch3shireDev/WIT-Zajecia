
import java.awt.Color;
import java.awt.Graphics;

public class ShapeRectangle extends ShapeBase
{
    public int ax,ay,bx,by;
    public ShapeRectangle(String text)
    {
        ParseParameters(text,(v)->ax=v,(v)->ay=v,(v)->bx=v,(v)->by=v);
    }

    @Override public String xml()
    {
        return String.format("<rectangle ax=\"%d\", ay=\"%d\", bx=\"%d\", by=\"%d\"/>",ax,ay,bx,by);
    }
    
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.blue);
        g.drawRect(ax, ay, bx, by);
    }
    
    @Override public String toString()
    {
        return "Rectangle(ax:" + ax + ", ay:" + ay + ", bx:" + bx + ", by:" + by + ')';
    }
}
