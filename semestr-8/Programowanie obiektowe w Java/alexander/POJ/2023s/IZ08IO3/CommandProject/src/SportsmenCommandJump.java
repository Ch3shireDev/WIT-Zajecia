public class SportsmenCommandJump implements SportsmenCommand
{
    @Override public String execute(Sportsmen s) { return s.jump(); }
    @Override public String toString() { return "Jump"; }    
}
