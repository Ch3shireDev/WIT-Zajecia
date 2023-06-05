
import javax.swing.JTextField;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CheckerDouble 
{
    private final JTextField TfValue;
    private final Runnable changed;
    private double value=0;
    private boolean ok=true;

    public CheckerDouble(JTextField TfValue, Runnable changed) 
    {
        this.TfValue = TfValue;
        this.changed = changed;
        DocumentListener listener=new DocumentListener() 
        {
            @Override public void insertUpdate(DocumentEvent e) { check(); }
            @Override public void removeUpdate(DocumentEvent e) { check(); }
            @Override public void changedUpdate(DocumentEvent e) { check(); }
        };
        TfValue.getDocument().addDocumentListener(listener);
        java.awt.EventQueue.invokeLater(this::check);
    }

    public boolean isOk() { return ok; }
    public double getValue() { return value; }
    
    private void check()
    {
        try
        {
            value=Double.parseDouble(TfValue.getText());
            ok=true;
        }
        catch(Exception ex)
        {
            ok=false;
        }
        changed.run();
    }
}
