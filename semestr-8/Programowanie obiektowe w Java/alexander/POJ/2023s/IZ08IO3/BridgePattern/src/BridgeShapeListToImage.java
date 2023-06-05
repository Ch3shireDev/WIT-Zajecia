
import java.awt.Graphics;

public class BridgeShapeListToImage extends BridgeShapeList
{
    private final JImagePanel field;
    private Graphics g;
    public BridgeShapeListToImage(JImagePanel field)
    {
        this.field=field;
    }
    
    @Override public void initialiseProcess()
    {
        g=field.g();
    }
    
    @Override public void proceed(ShapeBase shape)
    {
        shape.draw(g);
    }
    
    @Override public void finaliseProcess()
    {
        field.repaint();
    }
}
