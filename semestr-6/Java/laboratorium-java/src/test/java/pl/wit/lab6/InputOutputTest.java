package pl.wit.lab6;

import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.Level;
import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;

import java.io.*;

import static org.junit.Assert.*;

public class InputOutputTest {
    protected static final Logger log = LogManager.getLogger(InputOutputTest.class.getName());


    /**
     * @throws java.lang.Exception
     */
    @BeforeClass
    public static void setUpBeforeClass() throws Exception {
        BasicConfigurator.configure();
        Logger.getRootLogger().setLevel(Level.TRACE);
    }

    /**
     * Przykład odczytu danych z plików strumieniem bajtowym
     */
    @Test
    public void readFileTest() {
        FileInputStream fIn = null;
        String filePath = "./src/test/resources/plik1.txt";
        StringBuilder sB = new StringBuilder();
		int i;
        try {
            fIn = new FileInputStream(filePath);
            do {
                i = fIn.read();
                if (i != -1)
                    sB.append((char) i);
            } while (i != -1);
        }
        catch (IOException e) {
            log.error(e, e);
        }
        finally {
            try {
                if (fIn != null)
                    fIn.close();
            }
            catch (IOException e) {
                log.error(e, e);
            }
        }
        if (sB.isEmpty())
            log.trace("Nic nie odczytano");
        else
            log.trace("Odczytano: ".concat(sB.toString()));
        Assert.assertTrue(sB.toString().startsWith("Lorem ipsum dolor sit amet"));
    }

    /**
     * Przykład zapisu danych do pliku strumieniem bajtowym
     */
    @Test
    public void writeFileTest() {
        FileOutputStream fOut = null;
        String filePath = "./src/test/resources/plik2.txt";
        StringBuilder sB = new StringBuilder();
        for (int i = 0; i < 100; i++)
            sB.append("Ala ma kota (" + (i + 1) + ").\n");

        try {
            fOut = new FileOutputStream(filePath);
            String content = sB.toString();
            for (int i = 0; i < content.length(); i++)
                fOut.write(content.charAt(i));
        }
        catch (IOException e) {
            log.error(e, e);
        }
        finally {
            try {
                if (fOut != null)
                    fOut.close();
            }
            catch (IOException e) {
                log.error(e, e);
            }
        }
        File f = new File(filePath);
        assertTrue(f.exists());
    }

    /**
     * Przykład odczytu tekstu z pliku strumieniem znakowym	bufprpwanym
     */
    @Test
    public void readFileTxtBufferedTest() {
        String filePath = "./src/test/resources/plik1.txt";
        StringBuilder sB = new StringBuilder();
        String line;
        try (BufferedReader br = new BufferedReader(new FileReader(filePath))) {
            while ((line = br.readLine()) != null) {
                sB.append(line);
            }
        }
        catch (IOException e) {
            log.error(e, e);
        }
        if (sB.isEmpty())
            log.trace("Nic nie odczytano");
        else
            log.trace("Odczytano: ".concat(sB.toString()));
        Assert.assertTrue(sB.toString().startsWith("Lorem ipsum dolor sit amet"));
    }

    /**
     * Przykład zapisu tekstu do pliku strumieniem znakowym	buforowanym
     */
    @Test
    public void writeFileTxtBufferedTest() {
        String filePath = "./src/test/resources/plik3.txt";
        StringBuilder sB = new StringBuilder();
        for (int i = 0; i < 100; i++)
            sB.append("Ala ma kota (" + (i + 1) + ").\n");

        try (BufferedWriter bw = new BufferedWriter(new FileWriter(filePath))) {
            bw.write(sB.toString());
        }
        catch (IOException e) {
            log.error(e, e);
        }

        File f = new File(filePath);
        assertTrue(f.exists());
    }

    /**
     * Przykład zapisu danych do pliku strumieniem danych
     */
    @Test
    public void writeFileDataTest() {
        String filePath = "./src/test/resources/data0.txt";
        String strItem = "Ala ma kota";
        int intItem = 9;
        double dItem = 8.67;
        boolean bItem = true;

        try (DataOutputStream dataOut = new DataOutputStream(new FileOutputStream(filePath))) {
            dataOut.writeInt(strItem.length());
            dataOut.writeBytes(strItem);
            dataOut.writeUTF(strItem);
            dataOut.writeInt(intItem);
            dataOut.writeDouble(dItem);
            dataOut.writeBoolean(bItem);
        }
        catch (IOException e) {
            log.error(e, e);
        }

        File f = new File(filePath);
        assertTrue(f.exists());
    }

    /**
     * Przykład odczytu danych z pliku strumieniem danych
     */
    @Test
    public void readFileDataTest() {
        String filePath = "./src/test/resources/data1.txt";
        int strLen = 0;
        String strItem = null;
        byte[] strInBytes = null;
        int intItem = 0;
        double dItem = 0d;
        boolean bItem = false;

        try (DataInputStream dataIn = new DataInputStream(new FileInputStream(filePath))) {
            strLen = dataIn.readInt();
            strInBytes = dataIn.readNBytes(strLen);
            strItem = dataIn.readUTF();
            intItem = dataIn.readInt();
            dItem = dataIn.readDouble();
            bItem = dataIn.readBoolean();
        }
        catch (IOException e) {
            log.error(e, e);
        }
        assertEquals(11, strLen);
        assertEquals("Ala ma kota", strItem);
        assertEquals(9, intItem);
        assertEquals(8.67, dItem, 0.0);
        assertTrue(bItem);
        assertArrayEquals("Ala ma kota".getBytes(), strInBytes);
    }


    /**
     * Przykład zapisu i odczytu danych z i do pliku o dostępie swobodnym
     */
    @Test
    public void writeAndReadFileRandowmTest() {
        String filePath = "./src/test/resources/data2.txt";
        double[] data = {-2.34, 5.65, 3.65, 7.99, 0.98, 4.567, 0.0};

        try (RandomAccessFile raf = new RandomAccessFile(filePath, "rw")) {
            //Zapis danych do pliku
            for (double d : data)
                raf.writeDouble(d);

            double d;
            //Odczyt danych z pliku

            for (int i = 0; i < data.length; i++) {
                raf.seek(8 * i);
                d = raf.readDouble();
                log.info("" + d + ", ");
            }
        }
        catch (IOException e) {
            log.error(e, e);
        }

        File f = new File(filePath);
        assertTrue(f.exists());
    }
}
