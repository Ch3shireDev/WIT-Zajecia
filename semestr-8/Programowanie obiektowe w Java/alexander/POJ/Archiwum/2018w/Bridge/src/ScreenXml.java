import javax.swing.JTextArea;

public class ScreenXml extends Screen
{
   private final JTextArea dst;
   public ScreenXml(JTextArea dst)
   {
      this.dst=dst;
   }

   @Override public void Clear()
   {
      dst.setText("");
   }

   @Override public void Draw(Figure fig)
   {
      dst.append(fig.getXml()+System.lineSeparator());
   }

   @Override public void Select(Figure fig)
   {
   }
}
