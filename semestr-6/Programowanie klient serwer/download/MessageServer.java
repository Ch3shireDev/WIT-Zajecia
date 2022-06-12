package messageserver;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class MessageServer {

    public static void main(String[] args) throws IOException{
       ServerSocket serverSocket = new ServerSocket(29099);
        try {
            
            while (true) {
                Socket socket1 = serverSocket.accept();
                Socket socket2 = serverSocket.accept();
                try {
                    String s;
                    BufferedReader in1 = new BufferedReader(new InputStreamReader(socket1.getInputStream()));
                    PrintWriter out1 = new PrintWriter(socket1.getOutputStream(), true);
                    BufferedReader in2 = new BufferedReader(new InputStreamReader(socket2.getInputStream()));
                    PrintWriter out2 = new PrintWriter(socket2.getOutputStream(), true);               
                    s = in1.readLine();
                    out2.println(s); 
                    s = in2.readLine();
                    out1.println(s);
                                        }
                
                finally {
                    socket1.close();
                    socket2.close();
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
