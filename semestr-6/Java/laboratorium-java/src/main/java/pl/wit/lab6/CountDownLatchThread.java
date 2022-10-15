package pl.wit.lab6;

import java.util.concurrent.CountDownLatch;

public class CountDownLatchThread extends Thread {
	private CountDownLatch latch=null;
	private long limit;
	public CountDownLatchThread(CountDownLatch latch) {
		this.latch=latch;
		this.limit = latch.getCount();
	}
	
	public void run() {
		for(int i=0;i<limit;i++) {
			System.out.println(""+i);
			latch.countDown();
			try {
				Thread.sleep(200);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
}
