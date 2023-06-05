public class RectangleMaker implements FigureMaker
{
   @Override public Figure make(String params)
   {
      return new Rectangle(params);
   }

   @Override public String toString() { return "Rectangle"; }
}
