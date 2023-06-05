
import java.util.List;

public class SportsmenCommandMultiply extends SportsmenCommandComplex
{
   private int count;
   private SportsmenCommand cmd;

   public SportsmenCommandMultiply(String name,int count,SportsmenCommand cmds)
   {
      super(name);
      this.count=count;
      this.cmd=cmds;
   }

   @Override public String Execute(Sportsmen sportsmen)
   {
      return  Integer.toString(count)+" * "+cmd.Execute(sportsmen);
   }
}
