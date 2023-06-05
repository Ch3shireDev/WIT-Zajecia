
import java.util.List;

public class SportsmenTrening implements SportsmenCommand
{
   private final String name;
   private final List<SportsmenCommand> commands;

   public SportsmenTrening(String name,List<SportsmenCommand> commands)
   {
      this.name=name;
      this.commands=commands;
   }

   @Override public String command(Sportsmen s)
   {
      StringBuilder sb=new StringBuilder().append('{');
      for(int i=0;i<commands.size();++i)
      {
         if(i>0) sb.append(", ");
         sb.append(commands.get(i).toString());
      }
      return sb.append('}').toString();
   }

   @Override public String toString() { return name; }
}
