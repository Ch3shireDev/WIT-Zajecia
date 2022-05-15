package ServerApp;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        int port1 = 5000;
        int port2 = 6000;

        ServerSocket s1, s2;
        try{
            s1 = new ServerSocket(port1);
            s2 = new ServerSocket(port2);
        }
        catch (IOException e) {
            System.out.println("Error: " + e);
            return;
        }

        while (true) {

            try {
                Socket remote1 = s1.accept();
                BufferedReader in1 = new BufferedReader(new InputStreamReader(remote1.getInputStream()));
                PrintWriter out1 = new PrintWriter(remote1.getOutputStream());

                Socket remote2 = s2.accept();
                BufferedReader in2 = new BufferedReader(new InputStreamReader(remote2.getInputStream()));
                PrintWriter out2 = new PrintWriter(remote2.getOutputStream());

                String message1 =  getMessage(in1);
                String message2 = getMessage(in2);

                sendMessage(out1, message2);
                sendMessage(out2, message1);

                remote1.close();
                remote2.close();
            }
            catch (Exception e){
                System.out.println("Error: " + e);
            }

        }

    }

    private static void sendMessage(PrintWriter out1, String message2) {
        // Send the response
        // Send the headers
        out1.println("HTTP/1.0 200 OK");
        out1.println("Content-Type: text/html");
        out1.println("Server: Bot");
        // this blank line signals the end of the headers
        out1.println("");
        // Send the HTML page
        out1.println(String.format("Message from 2: %s", message2));
        out1.flush();
    }

    private static String getMessage(BufferedReader in1) throws IOException {
        String str = ".";
        int contentLength = 0;
        while (str!=null &&  !str.equals("")) {
            str = in1.readLine();
            System.out.println(str);
            Matcher matcher = Pattern.compile("Content-Length: (\\d+)").matcher(str);
            if(matcher.matches()){
                String contentLengthStr = matcher.group(1);
                contentLength = Integer.parseInt(contentLengthStr);
            }
        }

        if(contentLength>0){
            char[] buffer= new char[contentLength];
            in1.read(buffer, 0, contentLength);
            String content = String.valueOf(buffer);
            return content;
        }

        return "";
    }



}
