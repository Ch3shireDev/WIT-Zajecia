import java.net.*;
import java.io.*;

public class Client
{
	
	public Client()
	{
		try
		{
			//ceating the socket to connect to server running on same machine binded on port no 3000
			Socket client=new Socket("localhost",3000);
			System.out.println("Client connected ");
			//getting the o/p stream of that connection
			PrintStream out=new PrintStream(client.getOutputStream());
			//sending the message to server
			out.print("Hello from client\n");
			out.flush();
			//reading the response using input stream
			BufferedReader in= new BufferedReader(new InputStreamReader(client.getInputStream()));
			System.out.println(in.readLine());
			//closing the streams
			in.close();
			out.close();
 
		}
		catch(Exception err)
		{
			System.err.println("* err"+err);
		}
			
	}
	
	public static void main(String a[])
	{
		new Client();
	}
	
}