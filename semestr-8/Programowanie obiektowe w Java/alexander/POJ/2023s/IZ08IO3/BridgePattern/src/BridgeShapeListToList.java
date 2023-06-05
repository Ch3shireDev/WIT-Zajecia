
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class BridgeShapeListToList extends BridgeShapeList
{
    private final JList<String> field;
    private final DefaultListModel<String> model;
    public BridgeShapeListToList(JList<String> field)
    {
        this.field=field;
        model=(DefaultListModel<String>)field.getModel();
    }
    
    @Override public void initialiseProcess()
    {
        model.clear();
    }
    
    @Override public void proceed(ShapeBase shape)
    {
        model.addElement(shape.toString());
    }
    
    @Override public void finaliseProcess()
    {
        field.setSelectedIndex(model.size()-1);
    }
}
