import java.awt.Color;
import java.util.HashSet;
import javax.swing.JPanel;

public class ObservablePanel extends JPanel implements Observer
{
    private static final Color[] colors={Color.BLUE, Color.GREEN, Color.ORANGE};
    public static final int base=colors.length;
    private final HashSet<Observer> set=new HashSet<>();
    private int value=0;
    public ObservablePanel() { setbg(); }
    private void setbg() { setBackground(colors[value]); }
    public int getValue() { return value; }    
    public void addObserver(Observer observer) { set.add(observer); }
    public void removeObserver(Observer observer) { set.remove(observer); }
    public void clearObservers() { set.clear(); }
    private void sendSygnal() { for (Observer observer : set) observer.sygnal(this); }

    @Override public void sygnal(ObservablePanel observable)
    {
        value=(value+1)%base;
        setbg();
        if(value==0) sendSygnal();
    }
}
