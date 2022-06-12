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

	//=================================================================
        DataOutputStream dos = new DataOutputStream (new FileOutputStream("c:\\temp\\liczba.txt"));
        int x=10;
        dos.writeInt(x);
        dos.close();
        
        DataInputStream dis = new DataInputStream (new FileInputStream("c:\\temp\\liczba.txt"));
        int y=dis.readInt();
        dis.close();
        
        System.out.println(y);
        //==================================================================
        ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("c:\\temp\\data.tmp"));
        oos.writeObject(new Date());

        oos.close();
        
        ObjectInputStream ois = new ObjectInputStream(new FileInputStream("c:\\temp\\data.tmp"));
        Date date = (Date) ois.readObject();
        System.out.println(date.toString());

        ois.close();

    }
    
}
