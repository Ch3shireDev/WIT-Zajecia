package messageclient;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Scanner;
import javax.swing.JOptionPane;

public class MessageClient {

    public static void main(String[] args) throws IOException{
        Socket s = new Socket("localhost", 29099);        
        BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
        PrintWriter out = new PrintWriter(s.getOutputStream(), true);
        System.out.println("Wpisz wiadomoœæ:");
        Scanner scan = new Scanner(System.in);
        String msg1 = scan.nextLine();
        out.println(msg1);
        String msg2 = in.readLine();
        //JOptionPane.showMessageDialog(null, msg2);
        System.out.println(msg2);
        s.close();
    }
    
}
