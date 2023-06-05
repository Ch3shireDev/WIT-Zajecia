package decoratortest;

import javax.swing.*;
import javax.swing.border.*;
import java.awt.*;
import java.awt.event.*;

public class CheckBoxList extends JList<JCheckBox>
{
   protected static Border noFocusBorder=new EmptyBorder(0, 1, 1, 1);
   private DefaultListModel<JCheckBox> model=new DefaultListModel<>();
   public CheckBoxList()
   {
      setModel(model);
      setCellRenderer(new CellRenderer());
      setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
      MouseAdapter ma=new MouseAdapter()
      {
         @Override public void mousePressed(MouseEvent e)
         {
            int index=locationToIndex(e.getPoint());
            if(index>=0)
            {
               JCheckBox cb=item(index);
               cb.setSelected(!cb.isSelected());
               repaint();
            }
         }
      };
      addMouseListener(ma);
   }
   public JCheckBox add(String text)
   {
      JCheckBox cb=new JCheckBox();
      cb.setText(text);
      model.addElement(cb);
      return cb;
   }
   public JCheckBox item(int index)
   {
      return model.getElementAt(index);
   }
   public boolean isSelected(int index)
   {
      return index>=0?item(index).isSelected():false;
   }
   protected class CellRenderer implements ListCellRenderer
   {
      public Component getListCellRendererComponent
      (
         JList list,
         Object value,
         int index,
         boolean isSelected,
         boolean cellHasFocus
      )
      {
         JCheckBox cb=(JCheckBox)value;
         cb.setBackground
         (
            isSelected?
            getSelectionBackground():
            getBackground()
         );
         cb.setForeground
         (
            isSelected?
            getSelectionForeground():
            getForeground()
         );
         cb.setEnabled(isEnabled());
         cb.setFont(getFont());
         cb.setFocusPainted(false);
         cb.setBorderPainted(true);
         cb.setBorder
         (
            isSelected?
            UIManager.getBorder("List.focusCellHighlightBorder"):
            noFocusBorder
         );
         return cb;
      }
   }
}