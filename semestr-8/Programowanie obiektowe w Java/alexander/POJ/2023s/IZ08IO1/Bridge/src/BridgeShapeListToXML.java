
import javafx.beans.binding.StringBinding;
import javax.swing.JTextArea;

public class BridgeShapeListToXML implements BridgeShapeListBase
{
    private JTextArea field;
    private StringBuilder sb;
    public BridgeShapeListToXML(JTextArea field)
    {
        this.field=field;
    }
    
    @Override public void initialiseProceed()
    {
        sb
        =
            new StringBuilder()
            .append("<data>").append(System.lineSeparator())
            .append("\t<shapes>").append(System.lineSeparator())
        ;        
    }

    @Override public void Proceed(ShapeBase shape)
    {
        sb.append("\t\t").append(shape.xml()).append(System.lineSeparator());
    }

    @Override public void finalizeProceed()
    {
        field.setText
        (
            sb
                .append("\t</shapes>").append(System.lineSeparator())
                .append("</data>").append(System.lineSeparator())
                .toString()
        );
    }
    
}
