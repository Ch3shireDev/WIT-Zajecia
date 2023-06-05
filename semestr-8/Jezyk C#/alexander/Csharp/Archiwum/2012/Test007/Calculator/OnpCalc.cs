using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class OpnCalc
    {
        public enum State
        {
            StateStart,
            StateOperand,
            StateNumber,
            StateNumberPoint,
            StateNumberMantisa,
            StateNumberPowerSign,
            StateNumberPowerMinus,
            StateNumberPower,
            StateOperator,
            StateEnd,
            StateError,
        };

        public enum Operand
        {
            Sub,
            Add,
            Mul,
            Div,
            Neg,
            Pow,
            Val
        };

        private struct Priority
        {
            public Operand op;
            public string name;
            public char sign;
            public int priority;
            public Priority(Operand op, string name, char sign, int priority)
            {
                this.op = op;
                this.name = name;
                this.sign = sign;
                this.priority = priority;
            }
        };

        private static Priority[] PriorityTb = new Priority[]
        {
            new Priority ( Operand.Sub, "SUB", '-', 1 ),
            new Priority ( Operand.Add, "ADD", '+', 1 ),
            new Priority ( Operand.Mul, "MUL", '*', 2 ),
            new Priority ( Operand.Div, "DIV", '/', 2 ),
            new Priority ( Operand.Neg, "NEG", '-', 3 ),
            new Priority ( Operand.Pow, "POW", '^', 4 ),
            new Priority ( Operand.Val, "VAL", '#', 5 ),
        };

        private delegate void CmdFun();

        private struct CalcData
        {
            public State Start, Next;
            public string With;
            public CmdFun Cmd;
            public CalcData(State Start, State Next, string With, CmdFun Cmd)
            {
                this.Start = Start;
                this.Next = Next;
                this.With = With;
                this.Cmd = Cmd;
            }
            public bool Is(State cur, char Ch)
            {
                return (Start == cur) && (With.IndexOf(Ch) >= 0);
            }
        };

        private struct Node
        {
            public Operand op;
            public double Value;
            public Node(Operand op, int Weight)
            {
                this.op = op;
                Value = Weight;
            }
            public Node(double Value)
            {
                this.op = Operand.Val;
                this.Value = Value;
            }
        };

        private CalcData[] Automat;
        private Stack<Node> Main, Temp;
        private string line;
        public string Line { get { return line; } }
        private State cur;
        public State CurState { get { return cur; } }
        private int pos;
        public int Pos { get { return pos; } }
        private double result;
        public double Result { get { return result; } }
        private int SavePos;
        private int Weight;
        private char Ch;
        public bool Ok { get { return cur == State.StateEnd; } }

        public OpnCalc(string line)
        {
            this.line = line + '\xFF';
            Main = new Stack<Node>();
            Temp = new Stack<Node>();
            cur = State.StateStart;
            Weight = SavePos = pos = 0;

            Automat = new CalcData[]
            {
                new CalcData ( State.StateStart, State.StateStart, " \t",new CmdFun(CmdNone) ),
                new CalcData ( State.StateStart, State.StateNumber, "0123456789",new CmdFun(CmdSaveStartPos) ),
                new CalcData ( State.StateStart, State.StateNumberPoint, ".",new CmdFun(CmdSaveStartPos) ),
                new CalcData ( State.StateStart, State.StateOperand, "-",new CmdFun(CmdMinus) ),
                new CalcData ( State.StateStart, State.StateStart, "(",new CmdFun(CmdOpen) ),
                new CalcData ( State.StateOperand, State.StateOperand, " \t",new CmdFun(CmdNone) ),
                new CalcData ( State.StateOperand, State.StateNumber, "0123456789",new CmdFun(CmdSaveStartPos) ),
                new CalcData ( State.StateOperand, State.StateNumberPoint, ".",new CmdFun(CmdSaveStartPos) ),
                new CalcData ( State.StateOperand, State.StateStart, "(",new CmdFun(CmdOpen) ),
                new CalcData ( State.StateNumber, State.StateEnd, "\xFF",new CmdFun(CmdNumberEnd) ),
                new CalcData ( State.StateNumber, State.StateOperator, " \t",new CmdFun(CmdNumber) ),
                new CalcData ( State.StateNumber, State.StateNumber, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumber, State.StateNumberMantisa, ".",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumber, State.StateNumberPowerSign, "Ee",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumber, State.StateOperand, "-",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumber, State.StateOperand, "+",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumber, State.StateStart, "*/^",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumber, State.StateOperator, ")",new CmdFun(CmdNumberClose) ),
                new CalcData ( State.StateNumberPoint, State.StateNumberMantisa, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberMantisa, State.StateEnd, "\xFF",new CmdFun(CmdNumberEnd) ),
                new CalcData ( State.StateNumberMantisa, State.StateOperator, " \t",new CmdFun(CmdNumber) ),
                new CalcData ( State.StateNumberMantisa, State.StateNumberMantisa, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberMantisa, State.StateNumberPowerSign, "Ee",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberMantisa, State.StateOperand, "-",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberMantisa, State.StateOperand, "+",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberMantisa, State.StateStart, "*/^",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberMantisa, State.StateOperator, ")",new CmdFun(CmdNumberClose) ),
                new CalcData ( State.StateNumberPowerSign, State.StateNumberPower, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberPowerSign, State.StateNumberPowerMinus, "-",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberPowerMinus, State.StateNumberPower, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberPower, State.StateEnd, "\xFF",new CmdFun(CmdNumberEnd) ),
                new CalcData ( State.StateNumberPower, State.StateOperator, " \t",new CmdFun(CmdNumber) ),
                new CalcData ( State.StateNumberPower, State.StateNumberPower, "0123456789",new CmdFun(CmdNone) ),
                new CalcData ( State.StateNumberPower, State.StateOperand, "-",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberPower, State.StateOperand, "+",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberPower, State.StateStart, "*/^",new CmdFun(CmdNumberOperator) ),
                new CalcData ( State.StateNumberPower, State.StateOperator, ")",new CmdFun(CmdNumberClose) ),
                new CalcData ( State.StateOperator, State.StateEnd, "\xFF",new CmdFun(CmdEnd) ),
                new CalcData ( State.StateOperator, State.StateOperator, " \t",new CmdFun(CmdNone) ),
                new CalcData ( State.StateOperator, State.StateOperand, "-",new CmdFun(CmdOperator) ),
                new CalcData ( State.StateOperator, State.StateOperand, "+",new CmdFun(CmdOperator) ),
                new CalcData ( State.StateOperator, State.StateStart, "*/^",new CmdFun(CmdOperator) ),
                new CalcData ( State.StateOperator, State.StateOperator, ")",new CmdFun(CmdClose) ),
            };
            Compile();
            if (Ok) result = Calculate();
        }

        private double Calculate()
        {
            line = "";
            while (Temp.Count > 0)
            {
                Node T = Temp.Pop();
                if (T.op == Operand.Val) line += T.Value.ToString() + "\r\n";
                else line += PriorityTb[(int)T.op].name + "\r\n";
                if (T.op == Operand.Val) Main.Push(T);
                else if (T.op == Operand.Neg)
                {
                    T = Main.Pop();
                    T.Value = -T.Value;
                    Main.Push(T);
                }
                else if (T.op == Operand.Add)
                {
                    T = Main.Pop();
                    Node X = Main.Pop();
                    T.Value = X.Value + T.Value;
                    Main.Push(T);
                }
                else if (T.op == Operand.Sub)
                {
                    T = Main.Pop();
                    Node X = Main.Pop();
                    T.Value = X.Value - T.Value;
                    Main.Push(T);
                }
                else if (T.op == Operand.Mul)
                {
                    T = Main.Pop();
                    Node X = Main.Pop();
                    T.Value = X.Value * T.Value;
                    Main.Push(T);
                }
                else if (T.op == Operand.Div)
                {
                    T = Main.Pop();
                    Node X = Main.Pop();
                    T.Value = X.Value / T.Value;
                    Main.Push(T);
                }
                else if (T.op == Operand.Pow)
                {
                    T = Main.Pop();
                    Node X = Main.Pop();
                    T.Value = Math.Pow(X.Value, T.Value);
                    Main.Push(T);
                }
            }
            return Main.Pop().Value;
        }

        private void Compile()
        {
            cur = State.StateStart;
            Weight = SavePos = pos = 0;
            bool ok = true;
            while ((pos < line.Length) && (Weight >= 0) && (ok))
            {
                Ch = line[pos];
                ok = false;
                for (uint i = 0; i < Automat.Length; ++i)
                {
                    if (Automat[i].Is(cur, Ch))
                    {
                        Automat[i].Cmd();
                        cur = Automat[i].Next;
                        ok = true;
                        break;
                    }
                }
                ++pos;
            }
            if (Weight != 0) cur = State.StateError;
        }

        private void CmdNone()
        {
        }

        private void CmdSaveStartPos()
        {
            SavePos = pos;
        }

        private void CmdNumber()
        {
            Main.Push(new Node(Double.Parse(line.Substring(SavePos, pos - SavePos))));
        }

        private void CmdMinus()
        {
            Temp.Push(new Node(Operand.Neg, Weight + PriorityTb[(int)Operand.Neg].priority));
        }

        private void CmdOpen()
        {
            Weight += PriorityTb[(int)Operand.Val].priority;
        }

        private void CmdClose()
        {
            Weight -= PriorityTb[(int)Operand.Val].priority;
        }

        private void CmdNumberClose()
        {
            CmdNumber();
            CmdClose();
        }

        private void CmdOperator()
        {
            Operand op = Operand.Val;
            int W = 0;
            for (uint i = 0; i < PriorityTb.Length; ++i)
            {
                if (PriorityTb[i].sign == Ch)
                {
                    op = PriorityTb[i].op;
                    W = Weight + PriorityTb[i].priority;
                    break;
                }
            }
            Node N = new Node(op, W);
            while (Temp.Count > 0)
            {
                Node T = Temp.Peek();
                if (T.Value < N.Value) break;
                T = Temp.Pop();
                Main.Push(T);
            }
            Temp.Push(N);
        }

        private void CmdNumberOperator()
        {
            CmdNumber();
            CmdOperator();
        }

        private void CmdEnd()
        {
            while (Main.Count > 0) Temp.Push(Main.Pop());
        }

        private void CmdNumberEnd()
        {
            CmdNumber();
            CmdEnd();
        }

    }
}
