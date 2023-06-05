public class CommandSwim implements SportsmenCommand
{
    @Override public String Execute(Sportsmen sportsmen)
    {
        return sportsmen.Swim();
    }
    @Override public String toString() { return "Swim"; }    
}
