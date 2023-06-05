class Animal
{
	private String Name;
	public Animal(String Name) { this.Name=Name; }
   public String kind() { return "Animal: "; }
	@Override public String toString() { return kind()+Name; }
}