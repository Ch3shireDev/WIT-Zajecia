
import java.util.List;
import javax.swing.JTextArea;

public class BridgeShapesToXml extends BridgeShapes
{
    private JTextArea field;
    private StringBuilder sb;
    public BridgeShapesToXml(JTextArea field)
    {
        this.field=field;
    }
    
    @Override protected void initializeProceed()
    {
        sb
        =
            new StringBuilder()
            .append("<root>").append(System.lineSeparator())
            .append("\t<shapes>").append(System.lineSeparator())
        ;       
    }
    
    @Override protected void proceed(ShapeBase shape)
    {
        sb.append("\t\t").append(shape.toXML()).append(System.lineSeparator());
    }
    
    @Override protected void finalizeProceed()
    {
        sb
            .append("\t</shapes>").append(System.lineSeparator())
            .append("</root>").append(System.lineSeparator())
        ;
        field.setText(sb.toString());
        sb=null;
    }
}
