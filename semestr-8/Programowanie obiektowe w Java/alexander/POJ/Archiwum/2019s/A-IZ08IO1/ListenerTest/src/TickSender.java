public interface TickSender
{
   public void AddTickListener(TickListener t);
   public void RemoveTickListener(TickListener t);
   public void Clear();
   public void Call(TickSender sender);
}
