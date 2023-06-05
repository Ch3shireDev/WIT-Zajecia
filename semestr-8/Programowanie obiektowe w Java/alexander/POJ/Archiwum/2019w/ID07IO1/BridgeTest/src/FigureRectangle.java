
import java.awt.Color;
import java.awt.Graphics;

public class FigureRectangle extends Figure
{
    private double ax,ay,bx,by;
    private FigureRectangle() {}
    public static Figure make(String str)
    {
        double[] tb=toDoubleArray(str);
        if(tb.length!=4) return null;
        FigureRectangle fig=new FigureRectangle();
        int i=0;
        fig.ax=tb[i++];
        fig.ay=tb[i++];
        fig.bx=tb[i++];
        fig.by=tb[i++];
        return fig;
    }
    @Override public String toString() 
    {
        return "Rectangle{" + ax + ", " + ay + ", " + bx + ", " + by + '}';
    }
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.GREEN);
        g.drawLine(to_i(ax), to_i(ay), to_i(bx), to_i(ay));
        g.drawLine(to_i(bx), to_i(ay), to_i(bx), to_i(by));
        g.drawLine(to_i(bx), to_i(by), to_i(ax), to_i(by));
        g.drawLine(to_i(ax), to_i(by), to_i(ax), to_i(ay));
    }
}
