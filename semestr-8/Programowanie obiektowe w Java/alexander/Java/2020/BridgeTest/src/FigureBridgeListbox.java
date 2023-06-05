import javax.swing.DefaultListModel;
import javax.swing.JList;

public class FigureBridgeListbox extends FigureBridge
{
   private final JList<Figure> lb;
   public FigureBridgeListbox(JList<Figure> lb)
   {
      this.lb=lb;
   }
   private DefaultListModel<Figure> getModel()
   {
      return (DefaultListModel<Figure>)lb.getModel();
   }
   @Override protected void initialize()
   {
      lb.removeAll();
   }
   @Override protected void finalize()
   {
      lb.setSelectedIndex(getModel().getSize()-1);
   }
   @Override protected void proceed(Figure fig)
   {
      getModel().addElement(fig);
   }
}
