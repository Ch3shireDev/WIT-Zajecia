public class CommandJump implements SportsmenCommand
{
    @Override public String Execute(Sportsmen sportsmen)
    {
        return sportsmen.Jump();
    }
    @Override public String toString() { return "Jump"; }
}
