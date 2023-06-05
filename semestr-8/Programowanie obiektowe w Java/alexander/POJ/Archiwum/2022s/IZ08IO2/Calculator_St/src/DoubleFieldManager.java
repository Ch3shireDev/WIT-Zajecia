
import java.awt.Color;
import java.awt.SystemColor;
import javax.swing.JTextField;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class DoubleFieldManager {
    private double input;
    private JTextField field;
    private AdjustButtonInterface adjust;

    public DoubleFieldManager(double input, JTextField field, AdjustButtonInterface adjust) {
        this.input = input;
        this.field = field;
        this.adjust = adjust;
        
        DocumentListener listener = new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                checkValue();
            }
            @Override
            public void removeUpdate(DocumentEvent e) {
                checkValue();
            }
            @Override
            public void changedUpdate(DocumentEvent e) {
                checkValue();
            }
        };
        
        field.getDocument().addDocumentListener(listener);
        
        field.setText(Double.toString(input));
    }
    
    private void checkValue() {
        try {
            input = Double.parseDouble(field.getText());
            field.setBackground(SystemColor.window);
        } catch (NumberFormatException e) {
            field.setBackground(Color.yellow);
        }
        
        adjust.AdjustButton();
    }
    
    public double getInput() {
        return input;
    }
}
