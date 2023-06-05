
import java.util.List;

public class SportsmenCommandTrening implements SportsmenCommand
{
   private final List<SportsmenCommand> cmds;
   public SportsmenCommandTrening(List<SportsmenCommand> cmds)
   {
      this.cmds=cmds;
   }
   @Override public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      for(SportsmenCommand cmd:cmds)
      {
         if(first) first=false; else sb.append(", ");
         sb.append(cmd.execute(sportsmen));
      }
      return sb.toString();
   }
}
