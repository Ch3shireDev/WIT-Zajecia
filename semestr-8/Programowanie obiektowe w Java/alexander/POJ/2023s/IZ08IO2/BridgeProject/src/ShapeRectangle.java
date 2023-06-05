
import java.awt.Color;
import java.awt.Graphics;

public class ShapeRectangle extends ShapeBase
{
    private int ax,ay,bx,by;
    public ShapeRectangle(String text)
    {
        parse(text, (v)->ax=v, (v)->ay=v, (v)->bx=v, (v)->by=v);
    }
    
    @Override public void Draw(Graphics g)
    {
        g.setColor(Color.blue);
        g.drawRect(ax,ay,bx,by);
    }
    
    @Override public String toXML()
    {
        return String.format("<rectangle ax=\"%d\" ay=\"%d\" bx=\"%d\" by=\"%d\" />",ax,ay,bx,by);
    }

    @Override public String toString()
    {
        return String.format("Rectangle(ax:%d,ay:%d,bx:%d,by:%d)",ax,ay,bx,by);
    }
}
