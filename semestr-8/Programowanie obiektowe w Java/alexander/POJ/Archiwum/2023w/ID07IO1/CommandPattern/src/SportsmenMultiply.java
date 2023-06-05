
public class SportsmenMultiply implements SportsmenCommand
{
   private final String name;
   private final SportsmenCommand command;
   private final int count;

   public SportsmenMultiply(String name,SportsmenCommand commands,int count)
   {
      this.name=name;
      this.command=commands;
      this.count=count;
   }

   @Override public String command(Sportsmen s)
   {
      return String.format("%dx%s",count,command.toString());
   }

   @Override public String toString() { return name; }
}
