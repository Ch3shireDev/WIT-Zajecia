import java.io.IOException;
import java.net.InetAddress;
import java.net.Socket;

public class ClientManager extends WorkManager
{
   private final ConnectionManager connection;
   public ClientManager(int port,String host,StringReceiver receiver) throws Exception
   {
      connection=new ConnectionManager(port,host,receiver);
   }
   @Override public void send(String msg) throws Exception { connection.send(msg); }
   public void disconnect(String msg) { connection.disconnect(msg); }
}
