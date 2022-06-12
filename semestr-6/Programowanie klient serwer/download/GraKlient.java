
package graclient;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Scanner;
import javax.swing.JOptionPane;

public class GraClient {

    public static void main(String[] args) throws IOException {
        
        Socket s = new Socket("localhost", 29099);
        
        BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
        PrintWriter out = new PrintWriter(s.getOutputStream(), true);
        Scanner scan = new Scanner(System.in);
        String liczba, msg;
        do
        {
        System.out.println("Podaj liczbê");
        liczba = scan.nextLine();
        out.println(liczba);
        msg = in.readLine();
        
        System.out.println(msg);
        }while(!msg.equals("Zgad³eœ"));
        
    }
    
}
