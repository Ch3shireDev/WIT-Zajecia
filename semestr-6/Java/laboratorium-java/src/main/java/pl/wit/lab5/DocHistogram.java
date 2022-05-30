package pl.wit.lab5;

import java.io.*;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;

public class DocHistogram {


    String filePath;
    Reader reader;
    Map<String, Integer> mapHistogram;

    private DocHistogram() {
        mapHistogram = new HashMap<>();
    }

    public DocHistogram(String filePath) throws FileNotFoundException {
        this();
        this.filePath = filePath;
        this.reader = new FileReader(this.filePath);
    }

    public DocHistogram(Reader reader) {
        this();
        this.reader = reader;
        parseFile();
    }

    /**
     * Zadaniem tej metody jest odczytanie zawartości pliku przekazanego w konstruktorze
     * (ścieżki) z użyciem strumienia znakowego sprzężonego ze strumieniem buforowanym
     * (patrz wykład!). Zakładając, że tekst nie zawiera przenoszenia wyrazów, zaimplementuj
     * dla każdej odczytanej linii tekstu:
     * - podział linii tekstu na wyrazy „oczyszczone” ze znaków typu przecinek i kropka oraz
     * znaków końca linii. Można użyć metody split() z klasy String.
     * - nową metodę prywatną liczącą wystąpienia wyrazów i dodającą do już zapisanego
     * wcześniej stanu zliczania (w zmiennej mapHistogram). Przy okazji liczenia zamieniaj
     * wszystkie wyrazy na pisane małymi literami.
     */
    private void parseFile() {
        try {
            //creates a buffering character input stream
            BufferedReader br = new BufferedReader(reader);

            //constructs a string buffer with no characters
            StringBuffer sb = new StringBuffer();

            String line;
            while ((line = br.readLine().replaceAll("[\\-,.:]", " ")) != null) {

                for (String word : line.split("\\s")) {
                    word = word.replaceAll("[\\d]", "");
                    word = word.toLowerCase(Locale.ROOT);
                    if(word.equals(""))continue;
                    int count = mapHistogram.getOrDefault(word, 0) + 1;
                    mapHistogram.put(word, count);
                }

                //line feed
                sb.append("\n");
            }

            //closes the stream and release the resources
            reader.close();

            System.out.println("Contents of File: ");
            System.out.println(sb);
        }
        catch (Exception e) {

        }
    }

    public Map<String, Integer> getHistogram() {
        return mapHistogram;
    }


    /**
     * @return zawartość histogramu posortowanego po wyrazach alfabetycznie W postaci stringa.
     */
    public String printHistogram() {
        StringBuilder stringBuilder = new StringBuilder();
        String[] words = mapHistogram.keySet().toArray(new String[0]);
        Arrays.sort(words, String.CASE_INSENSITIVE_ORDER);
        for (String word : words) {
            stringBuilder.append(String.format("%s,%s\n", word, mapHistogram.get(word)));
        }
        return stringBuilder.toString().trim();
    }

    /**
     * Wysyła wartość printHistogram do wskazanego obiektu writera.
     * @param writer Obiekt pozwalający na zapis informacji.
     * @throws IOException Wyjątek w przypadku błędu zapisu informacji.
     */
    public void saveHistogramToFile(Writer writer) throws IOException{
        writer.write(printHistogram());
    }

    /**
     * Wysyła wartość printHistogram do wskazanego pliku.
     * @param filename Nazwa pliku.
     * @throws IOException Wyjątek w przypadku błędu zapisu informacji.
     */
    public void saveHistogramToFile(String filename) throws IOException{
        var fileWriter = new FileWriter(filename);
        saveHistogramToFile(fileWriter);
    }

}
