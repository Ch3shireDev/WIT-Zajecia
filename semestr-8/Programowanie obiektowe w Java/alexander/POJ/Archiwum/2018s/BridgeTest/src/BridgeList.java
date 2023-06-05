import javax.swing.DefaultListModel;
import javax.swing.JList;

public class BridgeList extends Bridge
{
   private final JList lb;
   private final DefaultListModel<Figure> model;
   public BridgeList(JList lb)
   {
      this.lb=lb;
      model=(DefaultListModel<Figure>)lb.getModel();
   }
      
   @Override protected void init() 
   {
      model.clear();
   }

   @Override protected void draw(Figure fig) 
   {
      model.addElement(fig);
   }

   @Override protected void done() 
   {
      if(model.getSize()>0) lb.setSelectedIndex(model.getSize()-1);
   }   
}
