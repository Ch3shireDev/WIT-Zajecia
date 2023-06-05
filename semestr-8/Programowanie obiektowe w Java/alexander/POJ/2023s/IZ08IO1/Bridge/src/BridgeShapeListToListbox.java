
import javafx.beans.binding.StringBinding;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JTextArea;

public class BridgeShapeListToListbox implements BridgeShapeListBase
{
    private JList<String> field;
    private DefaultListModel<String> model;
    public BridgeShapeListToListbox(JList<String> field)
    {
        this.field=field;
        model=(DefaultListModel<String>)field.getModel();        
    }
    
    @Override public void initialiseProceed()
    {
        model.clear();        
    }

    @Override public void Proceed(ShapeBase shape)
    {
        model.addElement(shape.toString());
    }

    @Override public void finalizeProceed()
    {
        field.setSelectedIndex(model.size()-1);
    }
    
}
