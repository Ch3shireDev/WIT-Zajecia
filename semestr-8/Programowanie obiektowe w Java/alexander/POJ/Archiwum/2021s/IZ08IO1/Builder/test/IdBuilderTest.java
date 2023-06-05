
import static org.junit.Assert.assertEquals;
import org.junit.Test;

/**
 *
 * @author alex
 */
public class IdBuilderTest
{
   private final IdBuilder ib=new IdBuilder();
   @Test public void test001()
   {
      ib.clear();
      assertEquals(ib.toString(),"null");
   }
   @Test public void test002()
   {
      ib.clear().append(1).append(13).append(666);
      assertEquals(ib.toString(),"1, 13, 666");
   }

}
