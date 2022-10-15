package pl.wit.lab6;

public class SimpleThread implements Runnable {
	String threadName;
	public SimpleThread(String threadName) {
		this.threadName=threadName;
	}
	public void run() {
		System.out.println("Wątek "+threadName+" rozpoczyna działanie.");
		try {
			for (int i = 0; i < 5; i++) {
				Thread.sleep(500);
				System.out.println("Wątek "+threadName+" działa, i="+(i+1));
			}
		} catch (InterruptedException e) {
			System.out.println(e);
		}
		System.out.println("Wątek "+threadName+" kończy działanie.");
	}
}
