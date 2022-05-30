package pl.wit.lab6;

public class Consumer implements Runnable {
    private Goods goods;
 
    public Consumer(Goods goods) {
 	   this.goods=goods;
    }
 
    public void run() {
        for(String consumedProduct = goods.consume();
          !"STOP".equals(consumedProduct);
        		consumedProduct = goods.consume()) {
            
            System.out.println("Consumed Product:"+consumedProduct);

   
            try {
                Thread.sleep(500);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt(); 
               System.out.println("Thread interrupted"); 
            }
        }
    }

}
