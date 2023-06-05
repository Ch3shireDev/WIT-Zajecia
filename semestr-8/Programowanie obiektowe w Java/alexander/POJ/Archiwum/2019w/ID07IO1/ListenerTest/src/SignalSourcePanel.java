import java.awt.Color;
import javax.swing.JPanel;

public class SignalSourcePanel extends SignalSourceBase implements SignalListener
{
    private final static Color[] colors={Color.BLUE,Color.RED,Color.GREEN};
    private final JPanel panel;
    private int index=0;
    SignalSourcePanel(final JPanel panel)
    {
        this.panel = panel;
        updateColor();
    }
    private void updateColor() { panel.setBackground(colors[index]); }
    @Override public void signal(SignalSource src) 
    {
        index=(index+1)%colors.length;
        updateColor();
        if(index<=0) SendSignals();
    }        
}
