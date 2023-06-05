
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class BridgeShapesToList extends BridgeShapes
{
    private JList<String> field;
    private DefaultListModel<String> model;
    public BridgeShapesToList(JList<String> field)
    {
        this.field=field;
        model=(DefaultListModel<String>)field.getModel();
    }
    
    @Override protected void initializeProceed()
    {
        model.clear();       
    }
    
    @Override protected void proceed(ShapeBase shape)
    {
        model.addElement(shape.toString());
    }
    
    @Override protected void finalizeProceed()
    {
        field.setSelectedIndex(model.size()-1);
    }
}
