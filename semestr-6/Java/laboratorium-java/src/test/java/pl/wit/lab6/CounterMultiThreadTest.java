package pl.wit.lab6;

import org.apache.commons.io.FileUtils;
import org.junit.Test;
import org.junit.jupiter.api.Assertions;

import java.io.File;
import java.io.IOException;
import java.util.Arrays;
import java.util.Random;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class CounterMultiThreadTest {

    static int filesToCreate = 100;

    @Test
    public void CounterMultiThreadTest() throws IOException, InterruptedException {
        String baseFolderName = "./multiThreadTests";

        FileUtils.deleteDirectory(new File(baseFolderName));

        ExecutorService executor = Executors.newFixedThreadPool(10);

        Random random = new Random();

        for (int i = 0; i < filesToCreate; i++) {
            int r = random.nextInt(10);
            CounterMultiThread cmt = new CounterMultiThread(baseFolderName, r);
            executor.execute(cmt);
        }

        executor.shutdown();
        while (!executor.awaitTermination(10, TimeUnit.MILLISECONDS)) Thread.sleep(10);

        File[] files = FileUtils.listFiles(new File(baseFolderName), new String[]{"txt"}, true).toArray(File[]::new);

        Assertions.assertEquals(filesToCreate, Arrays.stream(files).count());
        FileUtils.deleteDirectory(new File(baseFolderName));
    }

    @Test
    public void SingleThreadTest() throws IOException {
        String baseFolderName = "./singleThreadTests";
        FileUtils.deleteDirectory(new File(baseFolderName));
        Random random = new Random();

        for (int i = 0; i < filesToCreate; i++) {
            int r = random.nextInt(10);
            CounterMultiThread cmt = new CounterMultiThread(baseFolderName, r);
            cmt.run();
        }
        File[] files = FileUtils.listFiles(new File(baseFolderName), new String[]{"txt"}, true).toArray(File[]::new);
        Assertions.assertEquals(filesToCreate, Arrays.stream(files).count());
        FileUtils.deleteDirectory(new File(baseFolderName));
    }

    @Test
    public void Test() throws InterruptedException {
        ExecutorService executor = Executors.newFixedThreadPool(10);

        for (int i = 0; i < 100; i++) {
            executor.execute(new XXX());
        }

        int count = 0;
        executor.shutdown();
        while (!executor.awaitTermination(10, TimeUnit.MILLISECONDS)) {
            Thread.sleep(10);
            System.out.println("Waiting " + count);
            count++;
        }

        Assertions.assertEquals(100, XXX.n);
    }

}

class XXX implements Runnable {
    public static Integer n = 0;

    public static void add() {
        n += 1;
    }

    @Override
    public void run() {
        try {
            Thread.sleep(100);
            synchronized (n) {
                n++;
                System.out.println(String.format("I am Thread %d, n : %d", Thread.currentThread().getId(), n));
            }
        }
        catch (Exception e) {

        }
    }

}
