public class NamedCommand 
{
   private final Command cmd;
   private final String name;
   public NamedCommand(Command cmd,String name)
   {
      this.cmd=cmd;
      this.name=name;
   }
   public Command getCmd() { return cmd; }
   public String getName() { return name; }
   public @Override String toString() { return name; }
}
