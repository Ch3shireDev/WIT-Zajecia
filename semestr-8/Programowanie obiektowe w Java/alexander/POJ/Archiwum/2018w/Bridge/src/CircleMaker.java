public class CircleMaker implements FigureMaker
{
   @Override public Figure make(String params)
   {
      return new Circle(params);
   }

   @Override public String toString() { return "Circle"; }
}
