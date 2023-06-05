
import javax.swing.JTextArea;

public class ShapesBridgeToXml extends ShapesBridge
{
   private JTextArea area;
   private StringBuilder sb=null;

   public ShapesBridgeToXml(JTextArea area)
   {
      this.area=area;
   }

   @Override public void init()
   {
      sb=new StringBuilder().append("<xml>").append(System.lineSeparator());
   }

   @Override public void proceed(Shape shape)
   {
      sb.append("\t").append(shape.toXml()).append(System.lineSeparator());
   }

   @Override public void finit()
   {
      area.setText(sb.append("</xml>").toString());
   }
}
