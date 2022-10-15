package pl.wit.lab6;

import java.util.Arrays;
import java.util.Random;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.concurrent.TimeUnit;

import org.junit.Test;

/**
 * Klasa obrazująca zaawansowane techniki wielowątkowości
 * z użyciem jUnit'a, lecz nie jako testy jednostkowe!!!!
 * @author Łukasz
 *
 */
public class Threads3Test {

	/**
	 * Przykład użycia egzekutora do
	 * kontroli wątków w puli o ustalonej
	 * wielkości
	 */
	@Test
	public void executorsThreadTest() {
		System.out.println("Wątek główny rozpoczyna działanie");
		ExecutorService es = Executors.newFixedThreadPool(3);
		for(int i=0;i<10;i++) {
			es.execute(new FirstThread("Nr"+(i+1)));
		}
		es.shutdown();
		try {
			es.awaitTermination(1, TimeUnit.MINUTES);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("Wątek główny kończy działanie");
	}
	
	/**
	 * Przykład użycia zatrzasku
	 * dla programowania wielowątkowego
	 */
	@Test
	public void latchThreadTest() {
		System.out.println("Wątek główny rozpoczyna działanie");
		CountDownLatch cdl = new CountDownLatch(4);
		ExecutorService es = Executors.newFixedThreadPool(1);
		es.execute(new CountDownLatchThread(cdl));
		
		try {
			cdl.await();
			es.shutdown();
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("Wątek główny kończy działanie");
	}
	
	/**
	 * Przykład łątwości podziału obliczeń na wile wątków 
	 * w JAVA, policzenie niezlaeznie części 
	 * a następnie zsumowanie
	 */
	@Test
	public void callableFutureTest() {
		int arr[] = new int[21];
		Random random = new Random();

		arr = random.ints(21, 10,100).toArray();
		ExecutorService es = Executors.newFixedThreadPool(3);
		Future<Integer> sum1;
		Future<Integer> sum2;
		Future<Integer> sum3;
		Future<Integer> sumAll;
		System.out.println("Start");
		System.out.println("arr="+Arrays.toString(arr));
		sum1 = es.submit(new ArrayIntSum(Arrays.copyOf(arr, 7)));
		sum2 = es.submit(new ArrayIntSum(Arrays.copyOfRange(arr, 7,14)));
		sum3 = es.submit(new ArrayIntSum(Arrays.copyOfRange(arr, 14,21)));
		sumAll = es.submit(new ArrayIntSum(arr));
		
		try {
			System.out.println("sum1="+sum1.get());
			System.out.println("sum2="+sum2.get());
			System.out.println("sum3="+sum3.get());
			System.out.println("sumAll="+sumAll.get());
		}catch(InterruptedException | ExecutionException e) {
			System.out.println(e);
		}
		es.shutdown();
		System.out.println("Koniec");
	}

}
