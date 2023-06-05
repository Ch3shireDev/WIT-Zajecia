using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy2
{
    public class Vector3d
    {
        private double x, y, z;
        public Vector3d() { x=y=x=0; }
        public Vector3d(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return string.Format("({0:F3}, {1:F3}, {2:F3})", x,y,z);
        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
        public static Vector3d operator +(Vector3d a, Vector3d b)
        {
            return new Vector3d(a.x+b.x,a.y+b.y,a.z+b.z);
        }
    }

    public interface AddInterface
    {
        int add(int a, int b); // { return a + b; } nie możemy definiować, tylko deklaracja
    }
    public interface SubInterface
    {
        int sub(int a, int b); // { return a + b; } nie możemy definiować, tylko deklaracja
    }
    public interface ExtraAddInterface: AddInterface
    {
        int add_x(int a, int b);
    }

    public class AddSubClass : AddInterface, SubInterface
    {
        public int add(int a, int b) { return a + b; }
        public int sub(int a, int b) { return a - b; }
    }

    public class ExtraAddClass : ExtraAddInterface
    {
        public int add(int a, int b) { return a + b; }
        public int add_x(int a, int b) { return a - b; }
    }

    public interface AddExec
    {
        int exec(int a, int b);
    }
    public interface SubExec
    {
        int exec(int a, int b);
    }

    public class AddSubExecClass : AddExec, SubExec
    {
        int SubExec.exec(int a, int b) { return a - b; }
        int AddExec.exec(int a, int b) { return a + b; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector3d a = new Vector3d();
            Vector3d b = new Vector3d(1,2,3);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            b.X = 4;
            Console.WriteLine(b.ToString());
            AddSubClass asb = new AddSubClass();
            AddInterface ai = asb;
            SubInterface si = asb;
            Console.WriteLine("dodawanie: " + ai.add(1, 2));
            Console.WriteLine("odejmowanie: " + si.sub(1, 2));
            AddSubExecClass ase = new AddSubExecClass();
            Console.WriteLine("bezpośrednio +: " + ((AddExec)ase).exec(1, 2));
            Console.WriteLine("bezpośrednio -: " + ((SubExec)ase).exec(1, 2));
            AddExec ae = ase;
            SubExec se = ase;
            Console.WriteLine("+: " + ae.exec(1, 2));
            Console.WriteLine("-: " + se.exec(1, 2));

            Console.ReadLine();
        }
    }
}
