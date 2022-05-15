import java.io.IOException;
import java.net.ServerSocket;


public class Program {
    public static void main(String[] args) throws IOException {

        int port = 80;
        ServerSocket serverSocket = new ServerSocket(port);

        while (true) {
            HttpServer server = new HttpServer(serverSocket).open();
            HttpRequest request = server.getRequest();
            server.sendResponse();
            server.close();
        }
    }

}
