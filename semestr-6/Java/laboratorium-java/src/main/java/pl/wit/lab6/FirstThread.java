package pl.wit.lab6;

public class FirstThread extends Thread {
	public FirstThread(String threadName) {
		super(threadName);
	}
	public void run() {
		System.out.println("Wątek "+getName()+" rozpoczyna działanie.");
		try {
			for (int i = 0; i < 5; i++) {
				Thread.sleep(500);
				System.out.println("Wątek "+getName()+" działa, i="+(i+1));
			}
		} catch (InterruptedException e) {
			System.out.println(e);
		}
		System.out.println("Wątek "+getName()+" kończy działanie.");
	}
}
