import java.util.HashMap;

public class ScreenBuilder 
{
   private EnvironmentOption eo=EnvironmentOption.None;
   private static HashMap<EnvironmentOption,IntScreenBuilder> map=makemap();
   public ScreenBuilder()
   {
   }
   public void setEnvironmentOption(EnvironmentOption eo)
   {
      this.eo = eo;
   }
   public IntScreen build()
   {
      if(!map.containsKey(eo)) throw new IllegalArgumentException("Dont't choice EnvironmentOption");
      IntScreen is=map.get(eo).make();
      return is;
   }
   private static HashMap<EnvironmentOption,IntScreenBuilder> makemap()
   {
      HashMap<EnvironmentOption,IntScreenBuilder> map=new HashMap<>();
      IntScreenBuilder guiBuider=new IntScreenBuilder()
      {
         @Override public IntScreen make()
         {
            return new SnakeForm();
         }
      };
      IntScreenBuilder tuiBuider=new IntScreenBuilder()
      {
         @Override public IntScreen make()
         {
            return null;
         }
      };
      map.put(EnvironmentOption.GUI,guiBuider);
      map.put(EnvironmentOption.TUI,tuiBuider);
      return map;
   }
}

interface IntScreenBuilder
{
   public IntScreen make();
}