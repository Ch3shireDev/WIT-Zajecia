package pl.wit.lab6;

import org.junit.Test;

/**
 * Klasa obrazująca podstawowe aspekty wielowątkowości
 * z użyciem jUnit'a, lecz nie jako testy jednostkowe!!!!
 * @author Łukasz
 *
 */
public class Threads1Test {

	/**
	 * Przykład prostej klasy implementującej
	 * interfejs Runnable i uruchomionnej  w wątku
	 * Obiekt klasy thread na zwenątrz - ręczna obsługa
	 */
	@Test
	public void simpleThreadTest() {
		System.out.println("Wątek główny rozpoczyna działanie");
		SimpleThread st = new SimpleThread("Nr1");
		
		Thread newTh = new Thread(st);
		newTh.start();
		//newTh.run();

		for(int i=0;i<30;i++) {
			System.out.print("_");
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("Wątek główny kończy działanie");
	}
	
	/**
	 * Prosty przykład analogiczny jak wyżej 
	 * lecz z osadzeniem obiektu Thread wewnątrz klasy
	 * co ułatwia tworzenie i startowanie wątku
	 */
	@Test
	public void simpleThread2Test() {
		System.out.println("Wątek główny rozpoczyna działanie");
		@SuppressWarnings("unused")
		SimpleThread2 st = SimpleThread2.createAndRun("Nr1");
		
		for(int i=0;i<30;i++) {
			System.out.print("_");
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("Wątek główny kończy działanie");
	}
	
	/**
	 * Przykład klasy pochodnej klasy Thread
	 * Analogiczne proste uruchomienie wątku
	 */
	@Test
	public void firstThreadTest() {
		System.out.println("Wątek główny rozpoczyna działanie");
		FirstThread ft = new FirstThread("Nr1");
		ft.start();
		for(int i=0;i<30;i++) {
			System.out.print("_");
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("Wątek główny kończy działanie");
	}

	
	
	
}
