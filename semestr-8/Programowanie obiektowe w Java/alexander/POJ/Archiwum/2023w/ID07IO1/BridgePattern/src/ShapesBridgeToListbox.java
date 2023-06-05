
import java.util.List;
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class ShapesBridgeToListbox extends ShapesBridge
{
   private final JList Listbox;
   private final DefaultListModel<String> Model;

   public ShapesBridgeToListbox(JList Listbox)
   {
      this.Listbox=Listbox;
      Model=(DefaultListModel<String>)Listbox.getModel();
   }

   protected void initialization()
   {
      Model.removeAllElements();
   }

   protected void proceed(Shape shape)
   {
      Model.addElement(shape.toString());
   }

   protected void finalization()
   {
      Listbox.setSelectedIndex(Model.size()-1);
   }
}
