import java.net.*;
import java.io.*;

public class Server
{
	public Server()
	{
		try
		{
			//creating server socket binding at port # 3000
			ServerSocket server=new ServerSocket(3000);
			System.out.println("Server binded at "+((server.getInetAddress()).getLocalHost()).getHostAddress()+":"+server.getLocalPort());
			System.out.println("Run the Client");
			//ready to accept client request
			Socket socket=server.accept();
                        
			//opening the input stream to read data from client connection
			BufferedReader in= new BufferedReader(new InputStreamReader(socket.getInputStream()));
			System.out.println(in.readLine());
			//using output stream responsing data 
			PrintStream out=new PrintStream(socket.getOutputStream());
			out.print("Welcome by server\n");
			out.flush();
			//closing the in & out streams
			out.close();
			in.close();
		}
		catch(Exception err)
		{
			System.err.println("* err"+err);
		}
			
	}
	
	public static void main(String a[])
	{
		new Server();
	}
	
}