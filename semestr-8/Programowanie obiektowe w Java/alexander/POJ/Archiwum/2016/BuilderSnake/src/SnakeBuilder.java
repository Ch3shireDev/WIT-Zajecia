public class SnakeBuilder 
{
   private EnvironmentOption eo=EnvironmentOption.None;
   public SnakeBuilder()
   {
   }
   public void setEnvironmentOption(EnvironmentOption eo)
   {
      this.eo = eo;
   }
   public SnakeEngine build()
   {
      ScreenBuilder sb=new ScreenBuilder();
      sb.setEnvironmentOption(eo);
      IntScreen is=sb.build();
      KeyboardBuilder kb=new KeyboardBuilder();
      kb.setEnvironmentOption(eo);
      kb.setIntScreen(is);
      IntKeyboard ik=kb.build();
      SnakeEngine snake=new SnakeEngine(is,ik);
      return snake;
   }
}
