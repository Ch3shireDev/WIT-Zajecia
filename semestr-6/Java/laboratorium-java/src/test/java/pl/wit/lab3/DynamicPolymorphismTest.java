package pl.wit.lab3;

import static org.junit.Assert.assertNotNull;

import org.junit.Test;
import pl.wit.lab3.p4.DynP1;
import pl.wit.lab3.p4.DynP2;
import pl.wit.lab3.p4.DynP3;

/**
 * Klasa testowa do przykładku polimorfizmu
 * dynamicznego
 * @author Łukasz
 *
 */
public class DynamicPolymorphismTest {

	@Test
	public void dynamicPolyTest() {
		DynP1 dp1 = null;
		DynP2 dp2 = null;
		DynP3 dp3 = null;
		dp1 = new DynP1("Ala");
		dp2 = new DynP2("Ela");
		dp3 = new DynP3("Ula");
		assertNotNull(dp1);
		assertNotNull(dp2);
		assertNotNull(dp3);
		
		@SuppressWarnings("unused")
		DynP1 dp11 = dp2;
		DynP1 dp111 = dp3;
		
		//Zapisujemy wszystkie obiekty w tablicy typu bazowego
		DynP1 dps[] = new DynP1[]{dp1,dp2,dp3};
		DynP3 dp31 = null;
		//Następnie możemy "odzyskać" obiekt
		if(dp111 instanceof DynP3)
			dp31 = (DynP3) dp111;
		
		System.out.println(dp31.getDynP3Name());
		for(DynP1 dp:dps)
			dp.show();
	}

}
