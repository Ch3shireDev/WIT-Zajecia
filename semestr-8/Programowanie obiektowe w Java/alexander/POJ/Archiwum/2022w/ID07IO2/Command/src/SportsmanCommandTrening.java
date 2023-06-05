
import java.util.List;

public class SportsmanCommandTrening extends SportsmanCommandComplex
{
   private final List<SportsmanCommand> cmds;
   public SportsmanCommandTrening(String name,List<SportsmanCommand> cmds)
   {
      super(name);
      this.cmds=cmds;
   }
   @Override public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      sb.append("[");
      boolean first=true;
      for(SportsmanCommand cmd:cmds)
      {
         if(first) first=false; else sb.append(", ");
         sb.append(cmd.execute(sportsmen));
      }
      return sb.append(']').toString();
   }
}
