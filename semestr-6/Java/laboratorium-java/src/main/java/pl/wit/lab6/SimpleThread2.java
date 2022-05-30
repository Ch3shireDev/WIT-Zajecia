package pl.wit.lab6;

public class SimpleThread2 implements Runnable{
	private Thread thread;
	private SimpleThread2(String threadName) {
		thread = new Thread(this,threadName);
	}
	public static SimpleThread2 createAndRun(String threadName) {
		SimpleThread2 st = new SimpleThread2(threadName);
		st.thread.start();
		return st;
	}
	@Override
	public void run() {
		System.out.println("Wątek "+thread.getName()+" rozpoczyna działanie.");
		try {
			for (int i = 0; i < 5; i++) {
				Thread.sleep(500);
				System.out.println("Wątek "+thread.getName()+" działa, i="+(i+1));
			}
		} catch (InterruptedException e) {
			System.out.println(e);
		}
		System.out.println("Wątek "+thread.getName()+" kończy działanie.");	
	}
}
