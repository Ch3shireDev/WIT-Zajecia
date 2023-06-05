
import java.awt.Color;
import java.awt.Graphics;
import java.util.List;
import javax.swing.JTextArea;

public class BridgeShapesToImage extends BridgeShapes
{
    private JDrawPanel field;
    private Graphics g;
    public BridgeShapesToImage(JDrawPanel field)
    {
        this.field=field;
    }
    
    @Override protected void initializeProceed()
    {
        g=field.g();
        g.setColor(Color.LIGHT_GRAY);
        g.fillRect(0,0,field.getWidth(),field.getHeight());
    }
    
    @Override protected void proceed(ShapeBase shape)
    {
        shape.Draw(g);
    }
    
    @Override protected void finalizeProceed()
    {
        field.repaint();
    }
}
