import java.io.*;
import java.net.Socket;

public class Program {
    public static void main(String[] args) throws IOException {
        try {
            Socket socket = new Socket("127.0.0.1", 5000);

            DataInputStream in = new DataInputStream(socket.getInputStream());
            BufferedReader console = new BufferedReader(new InputStreamReader(System.in));
            DataOutputStream out = new DataOutputStream(socket.getOutputStream());

            while (true) {
                System.out.print("Enter response: ");
                String response = console.readLine();
                out.writeUTF(response);

                String message = in.readUTF();
                System.out.println(message);
            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }
}
