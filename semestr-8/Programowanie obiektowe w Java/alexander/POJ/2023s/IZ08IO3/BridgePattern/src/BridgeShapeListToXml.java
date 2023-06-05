
import java.util.List;
import javax.swing.JTextArea;

public class BridgeShapeListToXml extends BridgeShapeList
{
    private JTextArea field;
    private StringBuilder sb;
    public BridgeShapeListToXml(JTextArea field)
    {
        this.field=field;                
    }
    
    @Override public void initialiseProcess()
    {
        sb
        =
            new StringBuilder()
            .append("<root>").append(System.lineSeparator())
            .append("\t<shapes>").append(System.lineSeparator())
        ;
    }
    
    @Override public void proceed(ShapeBase shape)
    {
        sb.append("\t\t").append(shape.toXml()).append(System.lineSeparator());
    }
    
    @Override public void finaliseProcess()
    {
        field.setText
        (
            sb
            .append("\t</shapes>").append(System.lineSeparator())
            .append("</root>").append(System.lineSeparator())
            .toString()
        );
    }
}
