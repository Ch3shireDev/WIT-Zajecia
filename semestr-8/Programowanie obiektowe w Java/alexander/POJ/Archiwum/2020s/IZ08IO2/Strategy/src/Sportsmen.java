public class Sportsmen 
{
   private final String name;
   private final StrategyRun Run;
   private final StrategyJump Jump;
   private final StrategySwim Swim;
   public Sportsmen(String name, StrategyRun Run, StrategyJump Jump, StrategySwim Swim) 
   {
      this.name = name;
      this.Run = Run;
      this.Jump = Jump;
      this.Swim = Swim;
   }
   public String run() { return Run.execute(); }
   public String jump() { return Jump.execute(); }
   public String swim() { return Swim.execute(); }
   public String execute(Command cmd) { return name+": "+cmd.execute(this); }
   //@Override public String toString() { return name; }    
}

interface Command
{
    String execute(Sportsmen s);
}

class CommandRun implements Command
{
    public String execute(Sportsmen s) { return s.run(); }
    @Override public String toString() { return "Run"; }
}

class CommandJump implements Command
{
    public String execute(Sportsmen s) { return s.jump(); }
    @Override public String toString() { return "Jump"; }
}

class CommandSwim implements Command
{
    public String execute(Sportsmen s) { return s.swim(); }
    @Override public String toString() { return "Swim"; }
}

class CommandTrening implements Command
{
    private final String name;
    private final Command[] lst;
    public CommandTrening(String name, Command[] lst) 
    {
        this.name=name;
        this.lst=lst;
    }    
    public String execute(Sportsmen s)
    {
        final StringBuilder sb=new StringBuilder();
        boolean first=true;
        for(Command cmd:lst)
        {
            if(first) first=false; else sb.append(", ");
            sb.append(cmd.execute(s));
        }
        return sb.toString();
    }
    @Override public String toString() { return name; }
}
