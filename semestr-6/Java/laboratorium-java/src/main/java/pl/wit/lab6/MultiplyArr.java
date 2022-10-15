package pl.wit.lab6;

public class MultiplyArr {
	private long product;
	
	public synchronized long multiplySynchArr(int num[]) {
		product = (num.length==0)?0:1;
		for(int el:num) {
			product*=el;
			System.out.println(Thread.currentThread().getName()+" obliczył iloczyn częściowy="+product);
			try {
				Thread.sleep(10);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		return product;
	}
	
	public long multiplyArr(int num[]) {
		product = (num.length==0)?0:1;
		for(int el:num) {
			product*=el;
			System.out.println(Thread.currentThread().getName()+" obliczył iloczyn częściowy="+product);
			try {
				Thread.sleep(10);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		return product;
	}
}
