
import java.util.List;

public class SportsmenCommandTrening extends SportsmenCommandComplex
{
   private final List<SportsmenCommand> cmds;
   public SportsmenCommandTrening(String name,List<SportsmenCommand> cmds)
   {
      super(name);
      this.cmds=cmds;
   }
   @Override public String execute(Sportsmen s)
   {
      StringBuilder sb=new StringBuilder().append('{');
      for(int i=0;i<cmds.size();++i)
      {
         if(i>0) sb.append(", ");
         sb.append(cmds.get(i).execute(s));
      }
      return sb.append('}').toString();
   }
}
