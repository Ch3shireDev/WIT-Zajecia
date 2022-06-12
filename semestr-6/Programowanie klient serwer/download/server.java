package serwer;

import java.io.IOException;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Date;


public class Serwer {

    
    public static void main(String[] args) throws IOException {
        ServerSocket serverSocket = new ServerSocket(29090);
        try {
            while (true) {
                Socket socket = serverSocket.accept();
                try {
                    PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
                    out.println("Po³¹czy³eœ siê z serwerem");
                    }
                finally {
                    socket.close();
                }
            }
        }
              
        finally {
            serverSocket.close();
        }
    }
    
}
