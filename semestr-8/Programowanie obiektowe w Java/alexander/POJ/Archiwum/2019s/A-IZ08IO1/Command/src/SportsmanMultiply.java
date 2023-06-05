public class SportsmanMultiply implements SportsmanComposite
{
   private final String Name;
   private final int Count;
   private final SportsmanCommand Cmd;
   public SportsmanMultiply(String Name,int Count,SportsmanCommand Cmd)
   {
      this.Name=Name;
      this.Count=Count;
      this.Cmd=Cmd;
   }
   @Override public String execute(Sportsman s)
   {
      return Count+"x"+Cmd.execute(s);
   }
   @Override public String toString() { return Name; }
}
