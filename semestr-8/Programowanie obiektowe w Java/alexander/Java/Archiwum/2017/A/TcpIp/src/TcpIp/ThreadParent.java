package TcpIp;

public interface ThreadParent
{
   public void appendMessage(String msg);
   public boolean stoped();
   public void finished(SocketThread th);
}