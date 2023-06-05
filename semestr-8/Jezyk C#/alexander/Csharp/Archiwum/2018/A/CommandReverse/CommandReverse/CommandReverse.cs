using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandReverse
{
    interface Command
    {
        string execute();
    }
    interface Jump : Command
    {
    }
    interface Swim : Command
    {
    }
    interface Run : Command
    {
    }
    class Maraton : Run
    {
        public string execute() { return "run Maraton"; }
    }
    class Sprint : Run
    {
        public string execute() { return "run Sprint"; }
    }
    class MediumDistance : Run
    {
        public string execute() { return "run medium distance"; }
    }
    class LongJump : Jump
    {
        public string execute() { return "jump to long"; }
    }
    class HighJump : Jump
    {
        public string execute() { return "jump to high"; }
    }
    class Crawl : Swim
    {
        public string execute() { return "swim crawl style"; }
    }
    class Butterfly : Swim
    {
        public string execute() { return "swim butterfly style"; }
    }
    class Frog : Swim
    {
        public string execute() { return "swim frog style"; }
    }
    class Sportsman
    {
        public string name { get; private set; }
        private Run run;
        private Swim swim;
        private Jump jump;
        public Sportsman(string name,Run run, Swim swim, Jump jump)
        {
            this.name = name;
            this.run = run;
            this.swim = swim;
            this.jump = jump;
        }
        public string executeRun() { return run.execute(); }
        public string executeSwim() { return swim.execute(); }
        public string executeJump() { return jump.execute(); }
    }

    class Test
    {
        public static string test1()
        {
            Sportsman man = new Sportsman("Kowalski",new Sprint(), new Crawl(), new HighJump());
            string result= man.name + ": ";
            result += man.executeRun() + Environment.NewLine;
            result += man.executeSwim() + Environment.NewLine;
            result += man.executeJump() + Environment.NewLine;
            return result.Trim().Replace(Environment.NewLine," + ");
        }
    }
}
