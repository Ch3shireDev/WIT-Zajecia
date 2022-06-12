package strumienie;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

public class Strumienie {

    public static void main(String[] args) throws IOException {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        //------------------------------------------
        
        String str;
        System.out.println("Wpisz tekst");
        str = br.readLine();
        System.out.println(str);
         //-----------------------------------------
        
         char z;
        System.out.println("Wpisz znaki");        
        do {
            z = (char) br.read();
            System.out.println(z);
           }while(z!='q');
        //============================================
        
        FileWriter out=new FileWriter("c:\\temp\\plikText.txt");
        out.write("przykladowy tekst");
        out.close();
        //------------------------------------------
        
        int c=0;  
        char [] tab=new char [200];
        FileReader in=new FileReader("c:\\temp\\plikText.txt");
        do{
            System.out.print((char)c); 
            c=in.read();
            
        }while (c!=-1);
        in.close();
        //-----------------------------------------------
        
        BufferedReader brf = new BufferedReader(new FileReader("c:\\temp\\plikText.txt"));
        String strp;
        strp = brf.readLine();
        System.out.println(strp);
        br.close();
        
        System.out.println("");
    }
    
}
