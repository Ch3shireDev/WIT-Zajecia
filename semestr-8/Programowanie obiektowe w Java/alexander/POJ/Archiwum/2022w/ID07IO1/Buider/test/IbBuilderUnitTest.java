import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

public class IbBuilderUnitTest
{

   public IbBuilderUnitTest()
   {
   }

   @BeforeClass
   public static void setUpClass()
   {
   }

   @AfterClass
   public static void tearDownClass()
   {
   }

   @Before
   public void setUp()
   {
   }

   @After
   public void tearDown()
   {
   }

   @Test
   public void Test1()
   {
      final IdBuilder ib=new IdBuilder();
      ib.add(1);
      ib.add(2);
      ib.add(3);
      assertNotEquals(ib.toString(),"1, 2, 3");
   }
}
