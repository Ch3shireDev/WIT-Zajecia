
import javax.swing.JTextArea;

public class ShapeBridgeXml implements ShapeBridge
{
   private JTextArea field;
   private StringBuilder sb=null;

   public ShapeBridgeXml(JTextArea field)
   {
      this.field=field;
   }

   @Override public void init()
   {
      sb=new StringBuilder();
      sb.append("<xml>").append(System.lineSeparator());
      sb.append("\t<shapes>").append(System.lineSeparator());
   }

   @Override public void finit()
   {
      sb.append("\t</shapes>").append(System.lineSeparator());
      sb.append("</xml>");
      field.setText(sb.toString());
   }

   @Override public void proceed(Shape shape)
   {
      sb.append("\t\t").append(shape.toXml()).append(System.lineSeparator());
   }
}
