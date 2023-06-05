
import java.awt.Graphics;
import javax.swing.DefaultListModel;
import javax.swing.JPanel;

public class DrawablePanel extends JPanel
{
   private Drawing drawing;
   public void setDrawing(Drawing drawing)
   {
      this.drawing=drawing;
   }
   @Override public void paint(Graphics g) 
   {
      super.paint(g);
      if(drawing!=null) drawing.paint(g);
   }
}
