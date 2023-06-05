using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClassic
{
    abstract class Command
    {
        public string Execute(CommandReverse.Sportsman s)
        {
            return s.name + ": " + execute(s);
        }
        public abstract string execute(CommandReverse.Sportsman s);
    }
    class JumpCommand: Command
    {
        public override string execute(CommandReverse.Sportsman s)
        {
            return s.executeJump();
        }
    }
    class RunCommand : Command
    {
        public override string execute(CommandReverse.Sportsman s)
        {
            return s.executeRun();
        }
    }
    class SwimCommand : Command
    {
        public override string execute(CommandReverse.Sportsman s)
        {
            return s.executeSwim();
        }
    }
    class Trening : Command
    {
        public Command[] trening { get; private set; }
        public Trening(Command[] list)
        {
            this.trening = list;
        }
        public override string execute(CommandReverse.Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Command cmd in trening) sb.Append(cmd.execute(s)).Append(Environment.NewLine);
            return sb.ToString().Trim().Replace(Environment.NewLine," + ");
        }
    }
    class Test
    {
        static CommandReverse.Sportsman man = new CommandReverse.Sportsman("Kowalski", new CommandReverse.Maraton(), new CommandReverse.Butterfly(), new CommandReverse.LongJump());
        public static string test1()
        {
            Command cmd = new SwimCommand();
            return cmd.Execute(man);
        }
        public static string test2()
        {
            Command cmd = new RunCommand();
            return cmd.Execute(man);
        }
        public static string test3()
        {
            Command cmd = new JumpCommand();
            return cmd.Execute(man);
        }
        public static string test4()
        {
            Command cmd = new Trening
            (
                new Command[]
                {
                    new SwimCommand(), new JumpCommand(), new JumpCommand(), new RunCommand()
                }
            );
            return cmd.Execute(man);
        }
    }
}
