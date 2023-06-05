import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

public class IdBuilderUnitTest
{

   public IdBuilderUnitTest()
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
      IdBuilder ib=new IdBuilder();
      ib.add(2);
      ib.add(88);
      ib.add(3);
      assertEquals(ib.toString(),"2,3,88");
   }
}
