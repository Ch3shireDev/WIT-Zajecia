import java.awt.Color;
import java.awt.Graphics;

public class ScreenImage extends Screen
{
   private final Graphics dst;
   public ScreenImage(Graphics dst)
   {
      this.dst=dst;
   }

   @Override public void Clear()
   {
      dst.setColor(Color.LIGHT_GRAY);
      dst.fillRect(0,0,1000,1000);
   }

   @Override public void Draw(Figure fig)
   {
      fig.paint(dst);
   }

   @Override public void Select(Figure fig)
   {
   }
}
