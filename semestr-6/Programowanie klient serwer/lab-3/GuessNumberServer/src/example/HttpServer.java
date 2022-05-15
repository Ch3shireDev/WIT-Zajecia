package example;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

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

        StringBuilder requestDataBuilder = new StringBuilder();
        String buffer;
        while ((buffer = in.readLine()) != null) {
            requestDataBuilder.append(buffer+"\r\n");
            if (buffer.isEmpty()) {
                break;
            }
        }
        String requestData = requestDataBuilder.toString();
        int length = requestData.length();

        System.out.println(String.format("Wynik: %s (długość = %d)", requestData, length));
        return new HttpRequest(requestData);
    }

    public HttpServer sendResponse(String body) throws IOException {
        String response = "HTTP/1.0 200 OK\r\n" +
                "Content-Type: text/html\r\n" +
                String.format("Content-Length: %d\r\n", body.length()) +
                "\r\n" + body;
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
