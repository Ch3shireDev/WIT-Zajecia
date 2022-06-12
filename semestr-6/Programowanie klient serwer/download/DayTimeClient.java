package daytimeclient;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.Socket;
import java.net.UnknownHostException;
import javax.swing.JOptionPane;

public class DayTimeClient {

    public static void main(String[] args) {
        String hostname = "time.nist.gov";
        
         try
         {
             Socket s = new Socket(hostname,13);
             InputStream timeStream = s.getInputStream();
             StringBuffer time = new StringBuffer();
             int c;
             while((c = timeStream.read())!=-1)
                 time.append((char) c);
             String timeString = time.toString().trim();
             System.out.println("Jest "+timeString+" na "+hostname);
             s.close();
             
            /*s = new Socket("localhost", 29092);
            BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
            String msg = in.readLine();
            System.out.println(msg);
            s.close();*/
             
         }
         catch (UnknownHostException e) { System.out.println("Nieznany host"); }
         catch (IOException e) { System.out.println("B³¹d"); }
    }
    
}
