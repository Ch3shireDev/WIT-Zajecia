package pl.wit.lab5;

import junit.framework.TestCase;
import org.junit.Assert;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.io.*;
import java.util.Map;


class DocHistogramTest extends TestCase {

    @Test
    void testParse() {
        Reader reader = new StringReader("ala ma kota");
        DocHistogram docHistogram = new DocHistogram(reader);
        Map<String, Integer> map = docHistogram.getHistogram();

        Assert.assertTrue(map.containsKey("ala"));
        Assert.assertEquals((Integer) 1, map.get("ala"));
        Assert.assertTrue(map.containsKey("ma"));
        Assert.assertEquals((Integer) 1, map.get("ma"));
        Assert.assertTrue(map.containsKey("kota"));
        Assert.assertEquals((Integer) 1, map.get("kota"));
    }

    @Test
    void parseFile() throws Exception {
        Reader reader = new FileReader("src/test/resources/tutorial9.txt");
        DocHistogram histogram = new DocHistogram(reader);
        Map<String, Integer> map = histogram.getHistogram();

        Assertions.assertTrue(map.containsKey("avós"));
        Assertions.assertEquals((Integer) 2, map.get("avós"));
    }

    @Test
    void testParseFileOneLine() {
        //    Jeśli plik zawierałby następujące przykładowe 3 linie tekstu:
        //    Ala ma kota
        //    ale Ala nie ma psa
        //    za to psa ma Ela

        //    To wtedy przetwarzanie pierwszej linii powinno zasilić mapę następującymi elementami:
        //    Ala,1
        //    ma,1
        //    kota,1

        Reader reader = new StringReader("Ala ma kota");
        DocHistogram histogram = new DocHistogram(reader);
        Map<String, Integer> map = histogram.getHistogram();

        Assertions.assertEquals(3, map.keySet().size());
        Assertions.assertEquals(1, map.get("ala"));
        Assertions.assertEquals(1, map.get("ma"));
        Assertions.assertEquals(1, map.get("kota"));
    }

    @Test
    public void testParseFileTwoLines() {
        //    przetwarzanie drugiej linii powinno pozostawić w zmiennej mapy następujące elmenty:
        //    Ala,2
        //    ma,2
        //    kota,1
        //    ale,1
        //    nie,1
        //    psa,1

        Reader reader2 = new StringReader("Ala ma kota\nale Ala nie ma psa");
        DocHistogram histogram2 = new DocHistogram(reader2);
        Map<String, Integer> map2 = histogram2.getHistogram();

        Assertions.assertEquals(6, map2.keySet().size());
        Assertions.assertEquals(2, map2.get("ala"));
        Assertions.assertEquals(2, map2.get("ma"));
        Assertions.assertEquals(1, map2.get("kota"));
        Assertions.assertEquals(1, map2.get("ale"));
        Assertions.assertEquals(1, map2.get("nie"));
        Assertions.assertEquals(1, map2.get("psa"));

    }

    @Test
    public void testParseFileThreeLines() {
        //    po zakończeniu przetwarzania całościowo mapa powinna zawierać:
        //    Ala,2
        //    ma,3
        //    kota,1
        //    ale,1
        //    nie,1
        //    psa,2
        //    za,1
        //    to,1
        //    Ela,1
        //    Kolejność elementów nie ma znaczenia!!!

        Reader reader3 = new StringReader("Ala ma kota\nale Ala nie ma psa\nza to psa ma Ela");
        DocHistogram histogram3 = new DocHistogram(reader3);
        Map<String, Integer> map3 = histogram3.getHistogram();

        Assertions.assertEquals(9, map3.keySet().size());
        Assertions.assertEquals(2, map3.get("ala"));
        Assertions.assertEquals(3, map3.get("ma"));
        Assertions.assertEquals(1, map3.get("kota"));
        Assertions.assertEquals(1, map3.get("ale"));
        Assertions.assertEquals(1, map3.get("nie"));
        Assertions.assertEquals(2, map3.get("psa"));
        Assertions.assertEquals(1, map3.get("za"));
        Assertions.assertEquals(1, map3.get("to"));
        Assertions.assertEquals(1, map3.get("ela"));
    }

    @Test
    void printHistogram() {
        Reader reader = new StringReader("Ala ma kota\nale Ala nie ma psa\nza to psa ma Ela");
        DocHistogram histogram = new DocHistogram(reader);
        Assertions.assertEquals("ala,2\nale,1\nela,1\nkota,1\nma,3\nnie,1\npsa,2\nto,1\nza,1",
                histogram.printHistogram());
    }

    @Test
    void saveHistogramToFile() throws  IOException{
        Reader reader = new StringReader("Ala ma kota\nale Ala nie ma psa\nza to psa ma Ela");
        DocHistogram histogram = new DocHistogram(reader);
        Writer writer = new StringWriter();
        histogram.saveHistogramToFile(writer);
        Assertions.assertEquals("ala,2\nale,1\nela,1\nkota,1\nma,3\nnie,1\npsa,2\nto,1\nza,1",
                writer.toString());
    }
    @Test
    void saveHistogramToFileTutorial9() throws  IOException{
        Reader reader = new FileReader("src/test/resources/tutorial9.txt");
        DocHistogram histogram = new DocHistogram(reader);
        Writer writer = new StringWriter();
        histogram.saveHistogramToFile(writer);
        Assertions.assertEquals("a,1\n" +
                        "admira,1\n" +
                        "ainda,1\n" +
                        "alice,1\n" +
                        "aline,1\n" +
                        "anos,5\n" +
                        "antônia,2\n" +
                        "as,1\n" +
                        "assistir,1\n" +
                        "avó,1\n" +
                        "avós,2\n" +
                        "avô,1\n" +
                        "bastante,1\n" +
                        "bola,1\n" +
                        "bonecas,1\n" +
                        "brancas,1\n" +
                        "brincar,1\n" +
                        "cabelos,1\n" +
                        "casa,1\n" +
                        "castanhos,1\n" +
                        "chama,3\n" +
                        "chamam,1\n" +
                        "chamará,1\n" +
                        "cidade,1\n" +
                        "cinco,1\n" +
                        "com,1\n" +
                        "como,1\n" +
                        "cultivar,1\n" +
                        "de,19\n" +
                        "desenhar,1\n" +
                        "divertem,1\n" +
                        "do,3\n" +
                        "dos,1\n" +
                        "douglas,1\n" +
                        "duas,1\n" +
                        "e,16\n" +
                        "ela,2\n" +
                        "elas,1\n" +
                        "ele,1\n" +
                        "eles,2\n" +
                        "em,2\n" +
                        "esses,1\n" +
                        "estado,1\n" +
                        "está,2\n" +
                        "estão,1\n" +
                        "familiares,1\n" +
                        "família,1\n" +
                        "fazer,1\n" +
                        "férias,1\n" +
                        "gabriel,1\n" +
                        "garotas,1\n" +
                        "garoto,4\n" +
                        "gosta,3\n" +
                        "gostam,1\n" +
                        "grávida,1\n" +
                        "gêmeas,1\n" +
                        "heitor,1\n" +
                        "interior,1\n" +
                        "irmãs,1\n" +
                        "janeiro,1\n" +
                        "jardim,1\n" +
                        "jogar,2\n" +
                        "juntos,1\n" +
                        "já,1\n" +
                        "leonardo,1\n" +
                        "longos,1\n" +
                        "lucas,1\n" +
                        "luciano,7\n" +
                        "mais,1\n" +
                        "maria,1\n" +
                        "maternos,1\n" +
                        "mora,2\n" +
                        "moram,1\n" +
                        "muito,1\n" +
                        "mãe,2\n" +
                        "netos,1\n" +
                        "no,2\n" +
                        "nome,1\n" +
                        "nomes,1\n" +
                        "novelas,1\n" +
                        "novo,1\n" +
                        "não,1\n" +
                        "o,6\n" +
                        "oito,1\n" +
                        "olavo,1\n" +
                        "olívia,1\n" +
                        "os,3\n" +
                        "outra,1\n" +
                        "pai,3\n" +
                        "para,1\n" +
                        "parte,2\n" +
                        "paterna,1\n" +
                        "paterno,1\n" +
                        "paulo,1\n" +
                        "por,3\n" +
                        "possui,3\n" +
                        "preciso,1\n" +
                        "primo,1\n" +
                        "primos,1\n" +
                        "quando,2\n" +
                        "que,4\n" +
                        "ricardo,2\n" +
                        "rio,1\n" +
                        "rita,1\n" +
                        "rosas,1\n" +
                        "se,7\n" +
                        "semana,1\n" +
                        "será,1\n" +
                        "seus,1\n" +
                        "sua,2\n" +
                        "são,4\n" +
                        "tem,4\n" +
                        "tia,1\n" +
                        "tios,2\n" +
                        "têm,2\n" +
                        "um,2\n" +
                        "uma,4\n" +
                        "veem,1\n" +
                        "vez,1\n" +
                        "viagem,1\n" +
                        "visitar,1\n" +
                        "xadrez,1\n" +
                        "é,3",
                writer.toString());
    }
}