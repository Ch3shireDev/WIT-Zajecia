import java.awt.Graphics;

public abstract class Figure
{
   protected abstract void draw(Graphics g);
   protected abstract String getKind();
   protected abstract String getParameters();

   @Override public String toString() {
      return String.format("%s(%s)", getKind(), getParameters());
   }
}