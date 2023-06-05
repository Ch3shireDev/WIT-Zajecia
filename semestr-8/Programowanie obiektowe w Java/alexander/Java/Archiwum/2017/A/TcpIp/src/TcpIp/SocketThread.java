package TcpIp;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.net.Socket;

public class SocketThread extends Thread
{
   private final Socket socket;
   private final ThreadParent parent;
   private final String who;
   private BufferedReader in;
   private PrintStream out;
   private boolean stop;
   public SocketThread(ThreadParent parent,Socket socket)
   {
      stop=false;
      this.socket=socket;
      this.parent=parent;
      who=socket.getRemoteSocketAddress().toString();         
   }
   public String getWho() { return who; }
   public boolean stoped() { return (parent.stoped())||(stop); }
   public void terminate() 
   {
      stop=true;
      try { socket.close(); } catch (Exception ex) {}
   }
   public void outMessage(String msg)
   {
      out.println(msg); 
      out.flush();
   }
   @Override public void run()
   {
      //parent.appendMessage("Client connected "+who);
      try 
      {
         in=new BufferedReader(new InputStreamReader(socket.getInputStream()));
         out=new PrintStream(socket.getOutputStream());
         while(!stoped())
         {
            String msg=in.readLine();
            if(msg==null) break;
            parent.appendMessage(who+": "+msg);
         }
         try { socket.close(); } catch (Exception ex) {}
      } 
      catch(IOException ex) 
      {
         if(!stoped()) parent.appendMessage(ex.getMessage());
      }
      parent.finished(this);
      //parent.appendMessage("Client disconnected "+who);
   }
}