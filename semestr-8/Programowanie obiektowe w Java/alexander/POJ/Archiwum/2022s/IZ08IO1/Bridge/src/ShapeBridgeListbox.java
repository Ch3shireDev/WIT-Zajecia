
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class ShapeBridgeListbox implements ShapeBridge
{
   private JList<String> field;
   private DefaultListModel<String> model;

   public ShapeBridgeListbox(JList<String> field)
   {
      this.field=field;
      model=((DefaultListModel<String>)field.getModel());
   }

   @Override public void init()
   {
      field.removeAll();
   }

   @Override public void finit()
   {
      field.setSelectedIndex(model.size()-1);
   }

   @Override public void proceed(Shape shape)
   {
      model.addElement(shape.toString());
   }
}
