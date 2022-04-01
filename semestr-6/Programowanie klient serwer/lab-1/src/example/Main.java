package example;

import java.io.*;
import java.nio.file.Path;
import java.nio.file.Paths;

/*
Skonstruować aplikację która tworzy kopię pliku o zadanej nazwie.

1. Pytamy użytkownika o nazwę pliku.
2. Otwieramy plik, pobieramy zawartość.
3. Otwieramy drugi plik i wpisujemy tam zawartość.
4. Zakładamy że plik może być większy niż pamięć podręczna programu.

 */

public class Main
{

    public static void main(String[] args) throws IOException
    {
        Path currentRelativePath = Paths.get("");
        String s = currentRelativePath.toAbsolutePath().toString();
        System.out.println("Current absolute path is: " + s);

        System.out.println("Proszę podać nazwę pliku do skopiowania: ");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String filename = br.readLine();

        FileWriter writer = new FileWriter(filename + ".copy");
        FileReader reader = new FileReader(filename);
        int x = 0;

        while (true)
        {
            x = reader.read();
            if (x == -1) break;
            writer.write(x);
        }

        writer.close();
        reader.close();
        //
        //        //------------------------------------------
        //
        //        String str;
        //        System.out.println("Wpisz tekst");
        //        str = br.readLine();
        //        System.out.println(str);
        //        //-----------------------------------------
        //
        //        char z;
        //        System.out.println("Wpisz znaki");
        //        do {
        //            z = (char) br.read();
        //            System.out.println(z);
        //        }while(z!='q');
        //        //============================================
        //
        //        FileWriter out=new FileWriter("c:\\temp\\plikText.txt");
        //        out.write("przykladowy tekst");
        //        out.close();
        //        //------------------------------------------
        //
        //        int c=0;
        //        char [] tab=new char [200];
        //        FileReader in=new FileReader("c:\\temp\\plikText.txt");
        //        do{
        //            System.out.print((char)c);
        //            c=in.read();
        //
        //        }while (c!=-1);
        //        in.close();
        //        //-----------------------------------------------
        //
        //        BufferedReader brf = new BufferedReader(new
        //        FileReader("c:\\temp\\plikText.txt")); String strp =
        //        brf.readLine(); System.out.println(strp); br.close();
        //
        //        System.out.println("");
    }
}
