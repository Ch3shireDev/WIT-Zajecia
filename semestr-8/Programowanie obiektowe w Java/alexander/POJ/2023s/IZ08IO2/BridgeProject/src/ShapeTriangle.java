
import java.awt.Color;
import java.awt.Graphics;

public class ShapeTriangle extends ShapeBase
{
    private int ax,ay,bx,by,cx,cy;
    public ShapeTriangle(String text)
    {
        parse(text, (v)->ax=v, (v)->ay=v, (v)->bx=v, (v)->by=v, (v)->cx=v, (v)->cy=v);
    }
    
    @Override public void Draw(Graphics g)
    {
        g.setColor(Color.blue);
        int[] xs={ax,bx,cx,ax},ys={ay,by,cy,ay};
        g.drawPolyline(xs,ys,4);
    }
    
    @Override public String toXML()
    {
        return String.format("<triangle ax=\"%d\" ay=\"%d\" bx=\"%d\" by=\"%d\" cx=\"%d\" cy=\"%d\" />",ax,ay,bx,by,cx,cy);
    }

    @Override public String toString()
    {
        return String.format("Triangle(ax:%d,ay:%d,bx:%d,by:%d,cx:%d,cy:%d)",ax,ay,bx,by,cx,cy);
    }
}
