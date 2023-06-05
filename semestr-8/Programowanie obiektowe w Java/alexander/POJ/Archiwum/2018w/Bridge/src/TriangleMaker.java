public class TriangleMaker implements FigureMaker
{
   @Override public Figure make(String params)
   {
      return new Triangle(params);
   }

   @Override public String toString() { return "Triangle"; }
}
