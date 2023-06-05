import java.util.HashMap;

public class KeyboardBuilder
{
   private EnvironmentOption eo=EnvironmentOption.None;
   private IntScreen is=null;
   private static HashMap<EnvironmentOption,IntKeyboardBuilder> map=makemap();
   public KeyboardBuilder()
   {
   }
   public void setEnvironmentOption(EnvironmentOption eo)
   {
      this.eo = eo;
   }
   public void setIntScreen(IntScreen is) 
   {
      this.is = is;
   }   
   public IntKeyboard build()
   {
      if(is==null) throw new IllegalArgumentException("Dont't choice IntScreen");
      if(!map.containsKey(eo)) throw new IllegalArgumentException("Dont't choice EnvironmentOption");
      IntKeyboard ik=map.get(eo).make(is);
      return ik;
   }
   private static HashMap<EnvironmentOption,IntKeyboardBuilder> makemap()
   {
      HashMap<EnvironmentOption,IntKeyboardBuilder> map=new HashMap<>();
      IntKeyboardBuilder guiBuider=new IntKeyboardBuilder()
      {
         @Override public IntKeyboard make(IntScreen is)
         {
            return (IntKeyboard)(Object)is;
         }
      };
      IntKeyboardBuilder tuiBuider=new IntKeyboardBuilder()
      {
         @Override public IntKeyboard make(IntScreen is)
         {
            return null;
         }
      };
      map.put(EnvironmentOption.GUI,guiBuider);
      map.put(EnvironmentOption.TUI,tuiBuider);
      return map;
   }
}

interface IntKeyboardBuilder
{
   public IntKeyboard make(IntScreen is);
}