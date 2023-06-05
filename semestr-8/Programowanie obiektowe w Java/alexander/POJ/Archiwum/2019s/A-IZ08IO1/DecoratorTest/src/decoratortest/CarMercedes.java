package decoratortest;

public class CarMercedes implements Car
{
   @Override public String Info() { return "Mercedes"; }
   @Override public double Price() { return 65000; }
}
