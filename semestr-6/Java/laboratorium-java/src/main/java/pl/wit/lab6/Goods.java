package pl.wit.lab6;

public class Goods {
	    private String product;
	    // True jeśli konsument czeka, False jesli producent czeka
	    private boolean production = true;
	    public synchronized void produce(String product) {
	        while (!production) {
	            try { 
	            	System.out.println("Producer waits");
	                wait();
	            } catch (InterruptedException e)  {
	                Thread.currentThread().interrupt(); 
	                System.out.println("Thread interrupted"); 
	            }
	        }
	        production = false;
	        System.out.println("Produced product:"+product);
	        this.product = product;
	        notify();
	    }
	    public synchronized String consume() {
	        while (production) {
	            try {
	            	System.out.println("Consumer waits");
	                wait();
	            } catch (InterruptedException e)  {
	                Thread.currentThread().interrupt(); 
	                System.out.println("Thread interrupted"); 
	            }
	        }
	        production = true;

	        notify();
	        return product;
	    }
}
