import javax.swing.DefaultListModel;
import javax.swing.JList;

public class FigureBridgeListbox extends FigureBridge
{
   private JList lb;
   public FigureBridgeListbox(JList lb)
   {
      this.lb=lb;
   }
   private DefaultListModel<Figure> getModel()
   {
      return (DefaultListModel<Figure>)lb.getModel();
   }
   @Override protected void initialize()
   {
      getModel().clear();
   }
   @Override protected void finalize()
   {
      lb.setSelectedIndex(getModel().size()-1);
   }
   @Override protected void proceed(Figure fig)
   {
      getModel().addElement(fig);
   }
}
