package pl.wit.lab6;

import org.junit.Test;

/**
 * Klasa z przykładami prostych programów wielowątkowych
 * wykorzystujących podstawowe własności i metody
 * Przykłady używają metod jUnit;a lecz nie są klasycznymi testami
 * jednostkowymi. Stanowią jedynie ilustrację użycia danej konstrukcji
 *
 * @author Łukasz
 */
public class Threads2Test {

    /**
     * Wykorzystanie metody isAlive do kontroli
     * pracy wątku i jej zakończenia
     */
    @Test
    public void isAliveThreadTest() {
        System.out.println("Wątek główny rozpoczyna działanie");
        FirstThread ft1 = new FirstThread("Nr1");
        FirstThread ft2 = new FirstThread("Nr2");
        FirstThread ft3 = new FirstThread("Nr3");
        ft1.start();
        ft2.start();
        ft3.start();

        do {
            System.out.print("_");
            try {
                Thread.sleep(100);
            }
            catch (InterruptedException e) {
                e.printStackTrace();
            }
        } while (ft1.isAlive() || ft2.isAlive() || ft3.isAlive());
        System.out.println("Wątek główny kończy działanie");
    }

    /**
     * Przykład użycia metody join()
     * w celu oczekiwania na zkończenie pracy
     * watku
     */
    @Test
    public void joinThreadTest() {
        System.out.println("Wątek główny rozpoczyna działanie");
        FirstThread ft1 = new FirstThread("Nr1");
        FirstThread ft2 = new FirstThread("Nr2");
        FirstThread ft3 = new FirstThread("Nr3");
        ft1.start();
        ft2.start();
        ft3.start();
        try {
            ft1.join();
            ft2.join();
            ft3.join();
        }
        catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        System.out.println("Wątek główny kończy działanie");
    }

    /**
     * Ustawianie priorytetów wątków - Przykład
     */
    @Test
    public void priorityAndJoinThreadTest() {
        System.out.println("Wątek główny rozpoczyna działanie");
        FirstThread ft1 = new FirstThread("Nr1");
        FirstThread ft2 = new FirstThread("Nr2");
        FirstThread ft3 = new FirstThread("Nr3");
        ft3.setPriority(Thread.MAX_PRIORITY);
        ft2.setPriority(Thread.MIN_PRIORITY);
        ft1.setPriority(Thread.NORM_PRIORITY - 1);
        ft1.start();
        ft2.start();
        ft3.start();
        try {
            ft1.join();
            ft2.join();
            ft3.join();
        }
        catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        System.out.println("Wątek główny kończy działanie");
    }

    @Test
    public void waitNotifyThreadTest() {
        Goods goods = new Goods();
        Thread producer = new Thread(new Producer(goods));
        Thread consumer = new Thread(new Consumer(goods));

        producer.start();
        consumer.start();
        try {
            producer.join();
            consumer.join();
        }
        catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }


    }

    /**
     * Przykład zastosowania synchronizacji
     * do zasobu współdzielonego przez wątki
     */
    @Test
    public void synchMethodThreadTest() {
        System.out.println("Wątek główny rozpoczyna działanie");
        int arr[] = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        SecondThread st1 = new SecondThread("W1", arr);
        SecondThread st2 = new SecondThread("W2", arr);
        SecondThread st3 = new SecondThread("W3", arr);
        st1.start();
        st2.start();
        st3.start();
        try {
            st1.join();
            st2.join();
            st3.join();
        }
        catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        System.out.println("Wątek główny kończy działanie");
    }

    /**
     * Przykład bloku synchornizacji
     */
    @Test
    public void synchBlockThreadTest() {
        System.out.println("Wątek główny rozpoczyna działanie");
        int arr[] = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        ThirdThread tt1 = new ThirdThread("W1", arr);
        ThirdThread tt2 = new ThirdThread("W2", arr);
        ThirdThread tt3 = new ThirdThread("W3", arr);
        tt1.start();
        tt2.start();
        tt3.start();
        try {
            tt1.join();
            tt2.join();
            tt3.join();
        }
        catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        System.out.println("Wątek główny kończy działanie");
    }

}
