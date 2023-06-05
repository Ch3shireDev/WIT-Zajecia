package observertest;

import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import javax.swing.JPanel;

public class PanelObserver extends BaseObservable
{
   private JPanel panel;
   private final static Color[] States= { Color.black, Color.red, Color.blue };
   private int state=0;
   public PanelObserver(JPanel panel,Observable source)
   {
      this.panel=panel;
      adjustState();
      source.addObserver(()->NextState());
      MouseAdapter ma=new MouseAdapter()
      {
         @Override public void mouseClicked(MouseEvent evt) { NextState(); }
      };
      panel.addMouseListener(ma);
   }
   private void NextState()
   {
      state=(state+1)%States.length;
      adjustState();
      if(state==0) notifyObservers();
   }
   private void adjustState()
   {
      panel.setBackground(States[state]);
   }
}
