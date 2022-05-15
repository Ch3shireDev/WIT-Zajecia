package ServerApp;

public class ProducerConsumerExample {

    public static void main(String[] args) {
    Buffer buffer = new Buffer();
    ProducerThread p = new ProducerThread(buffer);
    ConsumerThread c = new ConsumerThread(buffer);
    p.start();
    c.start();
    }
}


class ProducerThread extends Thread {

    private final Buffer buffer;

    public ProducerThread(Buffer buffer){
        this.buffer = buffer;
    }

    public void run() {
        for(int i=0;i<10;i++){
            buffer.set(String.format("Kopytko #%d", i));
            System.out.println(String.format("Wysłano #%d", i));
            try{
                sleep((int)(Math.random() * 100));
            }
            catch (InterruptedException e){

            }
        }
    }
}

class ConsumerThread extends Thread {

    private final Buffer buffer;

    public ConsumerThread(Buffer buffer){
        this.buffer = buffer;
    }

    public void run() {
        for(int i=0;i<10;i++){
            System.out.println(String.format("Wiadomość od producenta: %s", buffer.get()));
        }
    }
}

class Buffer {

    boolean isAvailable;
    String message;

    public synchronized String get() {
        while (!isAvailable) {
            waitForOthers();
        }

        isAvailable = false;
        notifyAll();
        return message;
    }

    public synchronized void set(String value) {
        while (isAvailable) {
            waitForOthers();
        }

        message = value;
        isAvailable = true;
        notifyAll();
    }

    private void waitForOthers() {
        try {
            wait();
        }
        catch (InterruptedException e) {
        }
    }
}