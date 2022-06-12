package watki;
public class Watki {
    
    public static void main(String[] args) {
        System.out.println(" Glowny watek: POCZATEK");
        System.out.println(" Glowny watek: Tworze Nowy Watek");
        NowyWatek nowyWatek = new NowyWatek();
        System.out.println(" Glowny watek: Uruchamiam Nowy watek");
        nowyWatek.start();
        
        try { for(int i = 5; i > 0; i--)
            { System.out.println(" Glowny watek: " + i);
              //usypiamy w¹tek na 500 milisekund
              Thread.sleep(500);
            }
        } catch (InterruptedException e) {}
        System.out.println(" Glowny watek: KONIEC");
    }
}
class NowyWatek extends Thread
{
public void run()
{ System.out.println(" Nowy watek : POCZATEK");
    
    try { for(int i = 5; i > 0; i--)
    { System.out.println(" Nowy watek: " + i);
        Thread.sleep(500);
    }
    } catch (InterruptedException e) {}
    System.out.println(" Nowy watek : KONIEC");
}
}
