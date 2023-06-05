class Fly extends Insect
{
   public Fly(String Name) { super(Name); }
   @Override public String kind() { return super.kind()+"Fly: "; }
}
