import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class Program {
    public static void main(String[] args) throws IOException {

        Socket clientSocket = new Socket("localhost", 5000);
        InputStreamReader isr = new InputStreamReader(clientSocket.getInputStream());
        BufferedReader in = new BufferedReader(isr);
//        PrintWriter out = new PrintWriter(clientSocket.getOutputStream(), true);
//
//        System.out.println("Connected to localhost on port 5000");
//
//        String data = "Hello\nBye";
//
//        System.out.println("Sending to server:\n" + data);
//        out.println(data);
//
        String line;
        while ((line = in.readLine()) != null) {
            System.out.println("Client received: " + line);
        }

    }
}
