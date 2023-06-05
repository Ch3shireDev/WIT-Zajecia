class Mammal extends Animal
{
   public Mammal(String Name) { super(Name); }
   @Override public String kind() { return super.kind()+"Mammal: "; }
}
