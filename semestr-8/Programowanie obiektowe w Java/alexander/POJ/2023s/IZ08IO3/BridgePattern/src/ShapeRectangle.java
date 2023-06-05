
import java.awt.Color;
import java.awt.Graphics;

public class ShapeRectangle extends ShapeBase
{
    private int ax,ay,bx,by;
    public ShapeRectangle(String text)
    {
        parse(text, (v)->ax=v, (v)->ay=v, (v)->bx=v, (v)->by=v);
    }
    
    @Override public String toXml()
    {
        return String.format("<Rectangle ax=\"%d\" ay=\"%d\" bx=\"%d\" by=\"%d\" />", ax,ay,bx,by);
    }
    
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.blue);
        g.drawRect(ax,ay,bx,by);
    }

    @Override public String toString()
    {
        return String.format("Rectangle(ax:%d, ay:%d, bx:%d, by:%d)", ax,ay,bx,by);
    }
}
