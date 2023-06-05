
import javax.swing.DefaultListModel;
import javax.swing.JList;


public class FigureBridgeListbox extends FigureBridge
{
   private final JList lb;
   private DefaultListModel<Figure> model;
   public FigureBridgeListbox(JList lb)
   {
      this.lb = lb;
      model=(DefaultListModel<Figure>)lb.getModel();
   }
   @Override protected void initialize()
   {
      model.clear();
   }
   @Override protected void proceed(Figure fig)
   {
      model.addElement(fig);
   }
   @Override protected void finalize()
   {
      lb.setSelectedIndex(model.size()-1);
   }
}
