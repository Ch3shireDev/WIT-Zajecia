
import java.awt.Color;
import java.awt.event.MouseAdapter;
import javax.swing.JPanel;

public class ExPanel extends JPanel implements Observable,Observer
{
   private static Color[] colors=new Color[] { Color.BLUE, Color.RED, Color.GREEN };
   private int state=0;
   private BaseObservable bo=new BaseObservable();
   public void notifyObservers() { bo.notifyObservers(); } 
   public void addObserver(Observer ob) { bo.addObserver(ob); }
   public void dropObserver(Observer ob) { bo.dropObserver(ob); }
   public void clearObservers() { bo.clearObservers(); }
   public ExPanel()
   {
      super();
      AdjustColor();
      final MouseAdapter ma=new MouseAdapter() 
      {
         public void mouseClicked(java.awt.event.MouseEvent evt) 
         {
            signal();
         };
      };
      addMouseListener(ma);
   }
   public void signal()
   {
      state=(state+1)%colors.length;
      AdjustColor();
      if(state==0) notifyObservers();
   }
   private void AdjustColor()
   {
      setBackground(colors[state]);
   }
}
