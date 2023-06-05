class Horse extends Mammal
{
   public Horse(String Name) { super(Name); }
   @Override public String kind() { return super.kind()+"Horse:"; }
}
