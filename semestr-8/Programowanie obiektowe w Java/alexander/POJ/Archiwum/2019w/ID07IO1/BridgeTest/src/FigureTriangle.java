
import java.awt.Color;
import java.awt.Graphics;

public class FigureTriangle extends Figure
{
    private double ax,ay,bx,by,cx,cy;
    private FigureTriangle() {}
    public static Figure make(String str)
    {
        double[] tb=toDoubleArray(str);
        if(tb.length!=6) return null;
        FigureTriangle fig=new FigureTriangle();
        int i=0;
        fig.ax=tb[i++];
        fig.ay=tb[i++];
        fig.bx=tb[i++];
        fig.by=tb[i++];
        fig.cx=tb[i++];
        fig.cy=tb[i++];
        return fig;
    }
    @Override public String toString() 
    {
        return "Triangle{" + ax + ", " + ay + ", " + bx + ", " + by + ", " + cx + ", " + cy + '}';
    }
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.BLUE);
        g.drawLine(to_i(ax), to_i(ay), to_i(bx), to_i(by));
        g.drawLine(to_i(bx), to_i(by), to_i(cx), to_i(cy));
        g.drawLine(to_i(cx), to_i(cy), to_i(ax), to_i(ay));
    }
}
