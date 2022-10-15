package pl.wit.lab6;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertTrue;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Arrays;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Random;
import java.util.Set;
import java.util.stream.Collectors;
import java.util.stream.DoubleStream;
import java.util.stream.IntStream;
import java.util.stream.LongStream;
import java.util.stream.Stream;

import org.junit.Test;

/**
 * Klasa testu wizualizująca wybrane
 * funkcjonalności API strumieni
 * @author Łukasz
 *
 */
public class StreamTest {

	/**
	 * Utworzenie strumienia z kolekcji
	 */
	@Test
	public void streamFromCollectionTest() {
		Set<String> setTest = new LinkedHashSet<String>();
		setTest.add("Ala");
		setTest.add("ma");
		setTest.add("kota");
		
		Stream<String> newStream = null;
		newStream = setTest.stream();
		assertNotNull(newStream);
		assertTrue(newStream.anyMatch((n)-> n.equals("ma")));
		newStream.close();
		Stream.empty();
	}

	/**
	 * Przykłąd strumieni dla elementów typów prostych (prymitywnych)
	 */
	@Test
	public void streamForPrimitivesTest() {
		IntStream ints = IntStream.range(0, 20);
		LongStream longs = LongStream.generate(() -> (new Random()).nextInt(100));
		DoubleStream doubles = DoubleStream.of(11, 21, 31);
		assertNotNull(ints);
		assertNotNull(longs);
		assertNotNull(doubles);
		
		int sum = ints.peek((n)->System.out.print(""+n+", ")).reduce(0, (a, b) -> a + b);
		assertEquals(190,sum);
		System.out.print("suma="+sum);
		ints.close();
		doubles.close();
		longs.close();
	}
	
	
	/**
	 * Utworzenie strumienia z danych pliku
	 */
	@Test
	public void streamFromFileTest() {
		String filePath = "./src/test/resources/plik2.txt";
		
		try (Stream<String> lines = new BufferedReader(new FileReader(filePath)).lines()) {
		    String itemsWith20 = lines.peek((n)->System.out.println(n))
		    		.filter((n)->n.contains("1"))
		    		.filter((n)->n.contains("2"))
		    		.reduce("", (a,b)->(a.equals("")?a:a.concat(";")).concat(b));
		    System.out.println("Wyniki:"+itemsWith20);
		} catch (FileNotFoundException e) {
			System.out.println(e);		
		}
	}
	
	/**
	 * Przykład odwzorowania dla strumienia elementów typu int
	 */
	@Test
	public void streamMapTest() {
		int arr[] = new int[] {1,3,5,7,9};
		List<String> lst = null;
		lst = Arrays.stream(arr).mapToObj((n)-> "element_".concat(Integer.toString(n)))
				.peek((n)->System.out.println(n)).collect(Collectors.toList());
		assertNotNull(lst);
		assertEquals(arr.length,lst.size());
		
		
		
	}
}
