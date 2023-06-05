class Dog extends Mammal
{
   public Dog(String Name) { super(Name); }
   @Override public String kind() { return super.kind()+"Dog: "; }
}
