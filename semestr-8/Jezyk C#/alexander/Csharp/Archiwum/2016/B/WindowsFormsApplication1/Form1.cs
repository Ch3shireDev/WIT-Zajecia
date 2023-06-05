using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static List<Data> tmp = new List<Data>()
        {
            new Data("abc",1),
            new Data("def",2),
            new Data("ghi",3),
        };
        public Form1()
        {
            InitializeComponent();
            string path = "data.bin";
            List<Data> lst;
            using (FileStream fs = new FileStream(path, FileMode.Create)) new BinaryFormatter().Serialize(fs, tmp);
            using (FileStream fs = new FileStream(path, FileMode.Open)) lst = (List<Data>)(new BinaryFormatter().Deserialize(fs));
            Text = lst.Count.ToString();
        }
    }

    [Serializable]
    public class Data
    {
        public string str { get; set; }
        public int value { get; set; }

        public Data(string str, int value)
        {
            this.str = str;
            this.value = value;
        }
        public void toStream(FileStream fs)
        {
            new BinaryFormatter().Serialize(fs,this);
        }
        public static Data fromStream(FileStream fs)
        {
            return (Data)(new BinaryFormatter().Deserialize(fs));
        }
    }

}
