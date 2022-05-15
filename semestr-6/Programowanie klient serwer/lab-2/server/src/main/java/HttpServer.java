import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

class HttpRequest{

}

public class HttpServer {

    private final ServerSocket serverSocket;
    Socket clientSocket;
    BufferedReader in;
    BufferedWriter out;

    public HttpServer(ServerSocket serverSocket) {
        this.serverSocket = serverSocket;
    }

    public HttpServer open() throws IOException {
        clientSocket = serverSocket.accept();
        in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
        out = new BufferedWriter(new OutputStreamWriter(clientSocket.getOutputStream()));
        return this;
    }

    public HttpRequest getRequest() throws IOException {

        StringBuilder sb = new StringBuilder();
        String s;
        while ((s = in.readLine()) != null) {
            sb.append(s);
            if (s.isEmpty()) {
                break;
            }
        }

        return new HttpRequest();
    }

    public HttpServer sendResponse() throws IOException {
//        String response = "HTTP/1.0 200 OK\r\n" +
//                "Content-Type: text/html\r\n" +
//                String.format("Content-Length: %d\r\n", body.length()) +
//                "\r\n" + body;
        Date date = new Date();
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("YYYY.mm.dd HH:mm:ss");
        String response = simpleDateFormat.format(date);
        out.write(response);
        return this;
    }

    public HttpServer close() throws IOException {
        out.close();
        in.close();
        clientSocket.close();
        return this;
    }

}
