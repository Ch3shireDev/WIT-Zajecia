
import java.awt.Graphics;

public abstract class ShapeBase
{
    public void ParseParameters(String text,IntValue... values)
    {
        String[] parameters=text.split("[\\s\t;]+");
        if(parameters.length!=values.length) throw new IllegalArgumentException("Wrong parameters count");
        for(int i=0;i<values.length;++i)
        {
            values[i].set(Integer.parseInt(parameters[i]));
        }
    }
    public abstract void draw(Graphics g);
    public abstract String xml();
}
