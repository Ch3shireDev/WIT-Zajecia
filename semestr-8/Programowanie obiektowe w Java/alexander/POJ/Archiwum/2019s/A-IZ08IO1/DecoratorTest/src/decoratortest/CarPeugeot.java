package decoratortest;

public class CarPeugeot implements Car
{
   @Override public String Info() { return "Peugeot"; }
   @Override public double Price() { return 75000; }
}
