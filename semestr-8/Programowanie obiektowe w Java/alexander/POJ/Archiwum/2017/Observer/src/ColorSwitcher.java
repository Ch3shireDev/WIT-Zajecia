import java.awt.Color;
import java.util.ArrayList;
import javax.swing.JLabel;

public class ColorSwitcher implements IntObservable,IntObserver
{
   private static final Color[] clrs=new Color[] { Color.WHITE, Color.BLACK };
   private final ArrayList<IntObserver> objList=new ArrayList<>();
   private final JLabel text;   
   private final int pos;
   private boolean state;
   
   public ColorSwitcher(JLabel text,int pos)
   {
      this.text=text;
      this.pos=pos;
      setState(false);
   }
   
   @Override public void doNotify(String time)
   {
      setState(!state);
      setDigit(time);
      if(!state) doNotifyAll(time);
   }
   
   private void setState(boolean state)
   {
      this.state=state;
      text.setBackground(clrs[state?1:0]);
   }

   private void setDigit(String digit)
   {
      text.setText(digit.substring(pos,pos+1));
   }

   private void doNotifyAll(String time)
   {
      for(IntObserver obj:objList) obj.doNotify(time);
   }
   
   @Override public void addObserver(IntObserver obj) 
   {
      objList.add(obj);
   }

   @Override public void removeObserver(IntObserver obj) 
   {
      objList.remove(obj);
   }

   @Override public void clearObservers() 
   {
      objList.clear();
   }

}
