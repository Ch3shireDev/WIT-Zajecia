import java.util.ArrayList;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class HarmonicService {

    public double SimpleCalc(long count) {
        return ThreadCalc(count, 1, 0);
    }

    public double ThreadCalc(long count, int nThreads, int threadNumber) throws IllegalArgumentException{
        if(nThreads<1) throw new IllegalArgumentException("nThreads musi być większe od 0");
        if(threadNumber<0) throw new IllegalArgumentException("threadNumber musi być z zakresu od 0 do nThreads-1");

        double sum = 0;
        for (long i = threadNumber+1; i <= count; i+=nThreads) sum += 1.0D / (i);
        return sum;
    }

    public double getSumMultithreaded(long count) {
        var nThreads = Runtime
                .getRuntime()
                .availableProcessors();

        var executor = Executors
                .newFixedThreadPool(nThreads);

        var futures = new ArrayList<Future<Double>>();

        for (int i = 0; i < nThreads; i++) {
            final var iThread = i;
            var future = executor.submit(() -> ThreadCalc(count, nThreads, iThread));
            futures.add(future);
        }

        executor.shutdown();

        var sum = 0.0;

        for(var future : futures){
            try {
                sum += future.get();
            } catch (Exception ex) {
                //
            }
        }
        return sum;
    }
}
