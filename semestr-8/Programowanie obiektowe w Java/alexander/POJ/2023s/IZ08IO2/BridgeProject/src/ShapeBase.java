
import java.awt.Graphics;

public abstract class ShapeBase
{
    public void parse(String text,IntegerValue... setters)
    {
        String[] values=text.split("[\\s\t;]+");
        if(values.length!=setters.length) throw new IllegalArgumentException("Wrong parameters count");
        for(int i=0;i<setters.length;++i) setters[i].set(Integer.parseInt(values[i]));
    }
    public abstract void Draw(Graphics g);
    public abstract String toXML();
}
