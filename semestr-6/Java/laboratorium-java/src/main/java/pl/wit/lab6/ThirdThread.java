package pl.wit.lab6;

public class ThirdThread extends Thread {
	static MultiplyArr ma = new MultiplyArr();
	int arr[];
	long result;
	public ThirdThread(String threadName,int arr[]) {
		super(threadName);
		this.arr=arr;
	}
	public void run() {
		System.out.println("Wątek "+getName()+" rozpoczyna działanie.");
		synchronized(ma) {
			result = ma.multiplyArr(arr);
		}
		System.out.println("Wątek "+getName()+" obliczył wynik końcowy="+result);
		System.out.println("Wątek "+getName()+" kończy działanie.");
	}
}
