import java.net.ServerSocket;
import java.net.Socket;
import java.util.HashMap;

public class ServerMenager extends WorkManager
{
   private static final int maxClients=100;
   private final ServerSocket server;
   private final HashMap<String,ConnectionManager> clients=new HashMap<>();
   private final StringReceiver receiver;
   public ServerMenager(int port,StringReceiver receiver) throws Exception
   {
      server=new ServerSocket(5555,maxClients);
      this.receiver=receiver;
   }
   @Override protected void work()
   {
      try
      {
         server.setSoTimeout(100);
         while(isRun())
         {
            final Socket client=server.accept();
            if(client!=null)
            {
               final ConnectionManager connection=new ConnectionManager(client,receiver);
               final String name=connection.getName();
               ConnectionManager old=clients.get(name);
               if(old!=null) connection.disconnect("Imie jest używane");
               else
               {
                  clients.put(name,connection);
                  connection.start();
               }
            }
         }
      }
      catch(Exception ex) {}
      closeall();
   }
   @Override public void send(String msg) throws Exception
   {
      clients.entrySet().stream().forEach
      (
         (entry) ->
         {
            try { entry.getValue().send(msg); }
            catch(Exception ex) {}
         }
      );
   }
   private void closeall()
   {
      clients.entrySet().stream().forEach((entry) -> entry.getValue().disconnect("Serwer wyłączono"));
      clients.clear();
   }
}
