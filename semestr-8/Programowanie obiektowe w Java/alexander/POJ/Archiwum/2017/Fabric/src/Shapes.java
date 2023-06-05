import java.util.ArrayList;
import java.util.Iterator;

public class Shapes implements ComboList
{
   @Override public Iterator<ComboItem> iterator() 
   {
      final ArrayList<ComboItem> tb=new ArrayList<ComboItem>()
      {
         {
            add(new Circle());
            add(new Square());
            add(new Triangle());
         }
      };
      return tb.iterator();
   }   
}
