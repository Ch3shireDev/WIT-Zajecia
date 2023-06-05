class Insect extends Animal
{
   public Insect(String Name) { super(Name); }
   @Override public String kind() { return super.kind()+"Insect: "; }
}
