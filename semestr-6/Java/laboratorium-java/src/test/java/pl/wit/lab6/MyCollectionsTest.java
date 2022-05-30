package pl.wit.lab6;

import org.junit.Test;

public class MyCollectionsTest {

	@Test
	public void iterateWithIteratorDemoTest() {
		String[] items = new String[] {"Ala","ma","kota","ale","nie","ma","psa"};
		pl.wit.lab6.MyCollections myCol = new pl.wit.lab6.MyCollections(items);
		myCol.iterateWithItAll();
	}

	@Test
	public void iterateWithForEachDemoTest() {
		String[] items = new String[] {"Ala","ma","kota","ale","nie","ma","psa"};
		pl.wit.lab6.MyCollections myCol = new pl.wit.lab6.MyCollections(items);
		myCol.iterateWithForEach();
	}
}
