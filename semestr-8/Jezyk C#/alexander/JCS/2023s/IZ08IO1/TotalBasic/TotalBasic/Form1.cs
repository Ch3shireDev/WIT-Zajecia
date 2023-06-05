using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalBasic
{
    public delegate Animal SetAnimalString(string Value);
    public partial class Form1 : Form
    {
        public event SetAnimalString sas;
        public Form1()
        {
            InitializeComponent();
            Animal.description = "To jest klasa Zwierzak";
            //Animal.Kind = "";
            Animal a = new Animal("");
            a.Kind = "Snake";
            //a.description = "";
            Animal flow = new Animal("").SetKind("Spider").SetName("Piter");
            Animal param1 = new Animal(Name: "Piter");
            Animal param2 = new Animal(Kind: "Spider");
            Animal param3 = new Animal(Name: "Piter", Kind: "Spider");
            Animal param4 = new Animal("Spider", "Piter");
            SetAnimalString sn = a.SetName;
            SetAnimalString sk = a.SetKind;
            sn("abc");
            sk = sn;
            sas += a.SetName;
            sas += a.SetKind;
            sas("");
            sas -= a.SetKind;
        }
    }

    public class Animal
    {
        public string Kind;
        public string Name;
        public static string description;
        public Animal(string Kind = "", string Name="")
        {
            this.Kind = Kind;
            this.Name = Name;
        }

        public Animal SetKind(string Kind) { this.Kind = Kind; return this; }
        public Animal SetName(string Name) { this.Name = Name; return this; }

        public void foo_normal()
        {
            Kind += "*";
            description += "*";
            foo_static();
        }
        public static void foo_static()
        {
            //Kind += "!";
            description += "!";
            //foo_normal();
        }
    }
}
