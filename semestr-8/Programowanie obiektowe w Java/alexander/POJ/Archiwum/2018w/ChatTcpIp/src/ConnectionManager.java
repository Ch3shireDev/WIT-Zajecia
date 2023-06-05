import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;


public class ConnectionManager extends WorkManager
{
   private final Socket conn;
   private final StringReceiver receiver;
   private final ObjectOutputStream out;
   private final ObjectInputStream inp;
   private final String name;
   public ConnectionManager(int port,String host,StringReceiver receiver) throws Exception
   {
      this.conn=new Socket(InetAddress.getByName(host),port);
      this.receiver=receiver;
      out= new ObjectOutputStream(conn.getOutputStream());
      inp=new ObjectInputStream(conn.getInputStream());
      name=null;
   }
   public ConnectionManager(Socket connection,StringReceiver receiver) throws Exception
   {
      this.conn=connection;
      this.receiver=receiver;
      out= new ObjectOutputStream(conn.getOutputStream());
      inp=new ObjectInputStream(conn.getInputStream());
      name=(String)inp.readObject();
   }
   public String getName() { return name; }
   @Override public void send(String msg) throws Exception { if(msg!=null) out.writeObject(msg); }
   public void disconnect(String msg)
   {
      if(conn!=null)
      {
         try
         {
            send(msg);
            conn.close();
         }
         catch(Exception ex) {}
      }
      terminate();
   }
   @Override protected void work()
   {
      if(conn==null) return;
      try { conn.setSoTimeout(100); }
      catch(Exception ex) {}
      while(isRun())
      {
         try
         {
            receiver.receive(this,(String)inp.readObject());
         }
         catch(IOException|ClassNotFoundException ex) {}
      }
   }
}
