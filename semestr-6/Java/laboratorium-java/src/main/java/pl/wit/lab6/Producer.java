package pl.wit.lab6;

public class Producer  implements Runnable {
    private Goods goods;
 
   public Producer(Goods goods) {
	   this.goods=goods;
   }
 
    public void run() {
        String products[] = {
          "Product1",
          "Product2",
          "Product3",
          "Product4",
          "Product5",
          "Product6",
          "Product7",
          "Product8",
          "Product9",
          "Product10",
          "STOP"
        };
 
        for (String product : products) {
        	 goods.produce(product);
            try {
            	 Thread.sleep(500);
            } catch (InterruptedException e)  {
                Thread.currentThread().interrupt(); 
                System.out.println("Thread interrupted"); 
            }
        }
    }
}