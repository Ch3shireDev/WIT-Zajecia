
import javax.swing.JTextArea;

public class ShapeBridgeXml extends ShapeBridge
{
   private JTextArea field;
   private StringBuilder sb;

   public ShapeBridgeXml(JTextArea field)
   {
      this.field=field;
   }

   @Override protected void init()
   {
      sb
      =
         new StringBuilder()
         .append("<xml>")
         .append(System.lineSeparator())
         .append("\t<Shapes>")
         .append(System.lineSeparator())
      ;
   }

   @Override protected void Proceed(Shape shape)
   {
      sb.append("\t\t").append(shape.toXml()).append(System.lineSeparator());
   }

   @Override protected void finish()
   {
      field.setText
      (
         sb
         .append("\t</Shapes>")
         .append(System.lineSeparator())
         .append("</xml>")
         .append(System.lineSeparator())
         .toString()
      );
   }
}
