import java.util.Arrays;
import java.util.Iterator;

public class Colors implements ComboList
{
   @Override public Iterator<ComboItem> iterator() 
   {
      ComboItem[] tb = { new Red(), new Blue(), new Green() };
      return Arrays.asList(tb).iterator();
   }   
}
