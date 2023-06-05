
import java.awt.Graphics;
import javafx.beans.binding.StringBinding;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JTextArea;

public class BridgeShapeListToDrawPanel implements BridgeShapeListBase
{
    private DrawPanel field;
    private Graphics g;
    public BridgeShapeListToDrawPanel(DrawPanel field)
    {
        this.field=field;
    }
    
    @Override public void initialiseProceed()
    {
        g=field.getGraphics();
        g.fillRect(0, 0, field.getWidth(), field.getHeight());
    }

    @Override public void Proceed(ShapeBase shape)
    {
        shape.draw(g);
    }

    @Override public void finalizeProceed()
    {
        field.repaint();
    }    
}
