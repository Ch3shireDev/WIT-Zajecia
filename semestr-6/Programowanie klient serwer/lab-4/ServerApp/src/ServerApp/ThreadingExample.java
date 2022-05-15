package ServerApp;

public class ThreadingExample {

    public static void main(String[] args) {
        MyThread t1 = new MyThread("główny");
        MyThread t2 = new MyThread("poboczny");
        t1.start();
        t2.start();
    }
}

class MyThread extends Thread {

    private final String name;

    public MyThread(String name) {
        this.name = name;
    }

    public void run() {
        System.out.println(String.format("Start wątku: %s", name));
        for (int i = 0; i < 5; i++) {
            System.out.println(String.format("Wątek %s: %d", name, i));
            sleep(500);
        }
        System.out.println(String.format("Koniec wątku: %s", name));
    }

    private void sleep(int miliseconds) {
        try {
            Thread.sleep(miliseconds);
        }
        catch (Exception e) {
            System.out.println(String.format("Error: %s", e.getMessage()));
        }
    }
}
