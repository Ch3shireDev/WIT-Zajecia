import javax.swing.DefaultListModel;
import javax.swing.JList;

public class ScreenListbox extends Screen
{
   private final JList<Figure> dst;
   public ScreenListbox(JList<Figure> dst)
   {
      this.dst=dst;
   }

   private DefaultListModel<Figure> getModel()
   {
      return (DefaultListModel<Figure>)dst.getModel();
   }

   @Override public void Clear()
   {
      getModel().clear();
   }

   @Override public void Draw(Figure fig)
   {
      getModel().addElement(fig);
   }

   @Override public void Select(Figure fig)
   {
      dst.setSelectedValue(fig,true);
   }
}
