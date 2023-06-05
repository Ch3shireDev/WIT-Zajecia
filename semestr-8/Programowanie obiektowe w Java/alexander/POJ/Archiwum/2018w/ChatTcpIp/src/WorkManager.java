public class WorkManager
{
   private boolean run=true;
   public void terminate() { run=false; }
   public boolean isRun() { return run; }
   protected void work() {}
   public void send(String msg) throws Exception {}
   public void start() { new Thread(this::work).start(); }
}
