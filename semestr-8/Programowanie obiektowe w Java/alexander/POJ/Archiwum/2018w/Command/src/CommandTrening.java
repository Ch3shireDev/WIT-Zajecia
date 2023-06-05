
import java.util.ArrayList;

public class CommandTrening implements Command
{
   private final ArrayList<Command> lst;
   private final String name;
   public CommandTrening(String name,ArrayList<Command> lst)
   {
      this.lst=lst;
      this.name=name;
   }
   public ArrayList<Command> getList() { return lst; }
   public @Override String execute(Sportsmen s) 
   {
      final StringBuilder sb=new StringBuilder();
      for(Command cmd:lst) sb.append(cmd.execute(s)).append("\t");
      return sb.toString().trim().replace("\t",", ");
   }
   public @Override String toString() { return name; }
}
