package pl.wit.lab3;

import org.junit.Test;
import pl.wit.lab3.p6.A;
import pl.wit.lab3.p6.B;

/**
 * Klasa testowa pokazująca
 * możliwość zapisania w zmiennej referencyjnej klasy bazowej
 * zmienną referencyjną klasy pochodnej
 *
 * @author Łukasz
 */
public class BTest {

    @Test
    public void test() {
        A a = new A(9), aa;
        B b = new B(3, 4);
        B bb = null;
        aa = a;  //Wszystko OK
        System.out.println("aa.x = " + aa.x);
        aa = b; //Wszystko OK
        System.out.println("aa.x = " + aa.x);
        //aa.y //Błąd!
        if (aa instanceof B) bb = (B) aa; //Rzutowanie
        System.out.println("bb.y=" + bb.y);

    }

    @Test
    public void test2() {
        A a = new A(9), aa;
        B b = new B(3, 4);

        a.show();
        b.show();
        //Przypisujemy zmienne klasy A, zmienną referencyjną klasy B
        aa = b;
        //Tutaj działa mechanizm dynamicznego wyboru metody!!!
        aa.show();//Wywołuje się metoda show z klasy B!!!
    }


}
