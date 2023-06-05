package decoratortest;

public class CarSkoda implements Car
{
   @Override public String Info() { return "Skoda"; }
   @Override public double Price() { return 45000; }
}
