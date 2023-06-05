package animaltree;

public abstract class Animal 
{
   private String name;
   public Animal(String name) { this.name=name; }
   public String hierarchy() { return ""; }
   public String introduce() { return name+": "+hierarchy(); }
   public @Override String toString() { return introduce(); }   
}
