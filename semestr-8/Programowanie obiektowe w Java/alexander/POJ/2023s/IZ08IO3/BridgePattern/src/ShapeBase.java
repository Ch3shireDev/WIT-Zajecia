
import java.awt.Graphics;
import java.util.function.Consumer;

public abstract class ShapeBase
{
    protected void parse(String text,Consumer<Integer>... setters)
    {
        String[] values=text.split("[\\s\t;]+");
        if(values.length!=setters.length) throw new IllegalArgumentException("Wrong parameters count");
        for(int i=0;i<setters.length;++i) setters[i].accept(Integer.parseInt(values[i]));
    }
    public abstract String toXml();
    public abstract void draw(Graphics g);
}
