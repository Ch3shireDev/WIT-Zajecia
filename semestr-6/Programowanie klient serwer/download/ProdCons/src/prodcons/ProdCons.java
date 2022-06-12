package prodcons;

public class ProdCons {

    
    public static void main(String[] args) {
        Bufor c = new Bufor();
        Producent p1 = new Producent(c, 1);
        Konsument c1 = new Konsument(c, 1);
        
        p1.start();
        c1.start();
        
        
    }
    
}
