package pl.wit.lab6;

import java.io.File;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

public class CounterMultiThread implements Runnable {
    /**
     * Mapa globalna prechowuje nr katalogu i aktualną liczbę plików wewnątrz.
     */
    public static volatile Map<Integer, Integer> mapFolders = new HashMap<Integer, Integer>();

    /**
     * Numer folderu.
     */
    protected int folderNo;

    /**
     * Folder główny od którego startuje program.
     */
    private String mainFolder;

    /**
     * Konstruktor.
     *
     * @param mainFolder Folder główny od którego startuje program.
     * @param folderNo   Numer folderu.
     */
    public CounterMultiThread(String mainFolder, int folderNo) {
        this.folderNo = folderNo;
        this.mainFolder = mainFolder;
    }

    @Override
    public synchronized void run() {
        String dirPath = String.format("%s/%d", mainFolder, folderNo);
        try {
            synchronized (mapFolders) {
                File dir = new File(dirPath);
                dir.mkdirs();
                String filename = getFilename(folderNo);
                String filePath = String.format("%s/%d/%s", mainFolder, folderNo, filename);
                File file = new File(filePath);
                file.createNewFile();
            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }

    synchronized String getFilename(int folderNo) {

        synchronized (this) {
            if (!mapFolders.containsKey(folderNo)) {
                mapFolders.put(folderNo, 1);
                return "1.txt";
            }

            int number = mapFolders.get(folderNo);
            mapFolders.replace(folderNo, number + 1);
            return String.format("%d.txt", number + 1);
        }
    }
}
