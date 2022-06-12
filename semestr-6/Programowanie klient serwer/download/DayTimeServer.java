package daytimeserver;

import java.io.IOException;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

public class DayTimeServer {

    public static void main(String[] args) throws IOException{
        ServerSocket serverSocket = new ServerSocket(29092);
        try {
            
            while (true) {
                Socket socket = serverSocket.accept();
                try {
                    Date date = new Date();
                    SimpleDateFormat simpleDateFormat = new SimpleDateFormat("YYYY.mm.dd HH:mm:ss");
                    PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
                    out.println(simpleDateFormat.format(date)); 
                    //out.println(date.toString());
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