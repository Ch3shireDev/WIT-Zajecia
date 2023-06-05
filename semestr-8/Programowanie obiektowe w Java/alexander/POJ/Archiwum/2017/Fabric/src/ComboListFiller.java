
import javax.swing.DefaultComboBoxModel;

public class ComboListFiller 
{
   public static void fill(DefaultComboBoxModel<ComboItem> model,ComboList list)
   {
      for(ComboItem item:list) model.addElement(item);
   }
}
