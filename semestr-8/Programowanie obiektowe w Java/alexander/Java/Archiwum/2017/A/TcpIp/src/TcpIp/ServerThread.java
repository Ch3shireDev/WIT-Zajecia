package TcpIp;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ServerThread extends Thread implements ThreadParent
{
   private final ServerSocket server;
   private final ThreadParent parent;
   private final ArrayList<SocketThread> lst;
   private boolean stop;
   public ServerThread(ThreadParent parent,ServerSocket server)
   {
      stop=false;
      this.server=server;
      this.parent=parent;
      lst=new ArrayList<>();
   }
   public void terminate()
   {
      for(SocketThread th:lst) th.terminate();
      stop=true;
      try { server.close(); } catch (Exception ex) {}
   }
   @Override public void appendMessage(String msg)
   {
      parent.appendMessage(msg);
      for(SocketThread th:lst) th.outMessage(msg);
   }
   @Override public boolean stoped() { return (parent.stoped())||(stop); }
   @Override public void finished(SocketThread th) 
   {
      lst.remove(th); 
      parent.appendMessage("Disconneced client "+th.getWho());
   }
   @Override public void run()
   {
      parent.appendMessage("Server connected");
      try
      {
         while(!stoped())
         {
            Socket cln=server.accept();
            SocketThread th=new SocketThread(this,cln);
            lst.add(th);
            parent.appendMessage("Connected client "+th.getWho());
            th.start();
         }
         try { server.close(); } catch (Exception ex) {}
      }
      catch(IOException ex) 
      {
         if(!stoped()) parent.appendMessage(ex.getMessage());
      }
      parent.appendMessage("Server disconnected");
   }
}