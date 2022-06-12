
package graserver;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

public class GraServer {

    public static void main(String[] args) throws IOException{
        ServerSocket serverSocket = new ServerSocket(29099);
        try {
            
            while (true) {
                Socket socket = serverSocket.accept();
                try {
                    int x = 9, y;
                    BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
                    PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
                    do
                    {                    
                    y = Integer.parseInt(in.readLine());
                    if(y==x)  out.println("Zgad³eœ");
                    else out.println("Nie zgad³eœ");
                    }while(y!=x);
                    }
                
                finally {
                    socket.close();
                }
            }
        }
        catch(IOException e) 
            { System.out.println("B³¹d"); }      
        finally {
            serverSocket.close();
        }
    }
    
}
