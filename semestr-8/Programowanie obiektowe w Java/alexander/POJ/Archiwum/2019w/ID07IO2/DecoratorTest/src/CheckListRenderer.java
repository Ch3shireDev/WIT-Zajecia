
import java.awt.Component;
import javax.swing.JCheckBox;
import javax.swing.JList;
import javax.swing.ListCellRenderer;

class CheckListRenderer extends JCheckBox implements ListCellRenderer 
{
    public Component getListCellRendererComponent(JList list,Object value,int index,boolean isSelected,boolean hasFocus) 
    {
        setEnabled(list.isEnabled());
        setSelected(((CheckListItem)value).isSelected());
        setFont(list.getFont());
        setBackground(list.getBackground());
        setForeground(list.getForeground());
        setText(value.toString());
        return this;
    }
}