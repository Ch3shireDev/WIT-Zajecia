
import java.awt.Color;
import java.awt.Graphics;

public class FigureCircle extends Figure
{
    private double ax,ay,radius;
    private FigureCircle() {}
    public static Figure make(String str)
    {
        double[] tb=toDoubleArray(str);
        if(tb.length!=3) return null;
        FigureCircle fig=new FigureCircle();
        int i=0;
        fig.ax=tb[i++];
        fig.ay=tb[i++];
        fig.radius=tb[i++];
        return fig;
    }
    @Override public String toString() 
    {
        return "Circle{" + ax + ", " + ay + ", " + radius + '}';
    }
    @Override public void draw(Graphics g)
    {
        g.setColor(Color.RED);
        g.drawOval(to_i(ax-radius), to_i(ay-radius), to_i(2*radius), to_i(2*radius));
    }
}
