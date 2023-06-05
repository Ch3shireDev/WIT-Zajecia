using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//************************************************
using System.IO;
using System.Reflection;
using System.Configuration;

/****************************************************************************************/
// zmiana
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //private string key = System.Configuration.ConfigurationManager.AppSettings["klucz"];
        string pathCombo = System.Configuration.ConfigurationManager.AppSettings["pathCombo"];
        string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+ "/../../App1.Config";
        public static List<data> tmp = new List<data>() { new data("abc", 1), new data("def", 2), new data("ghi", 3) };


        public Form1()
        {
            InitializeComponent();
            readFile(pathCombo);
            initButtons(pathCombo);
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/../../dat.bin";
            addConfig("frytki", "dlugie", appPath);
            List<data> lst;
            using (FileStream fs = new FileStream(path, FileMode.Create)) new BinaryFormatter().Serialize(fs, tmp);
            using (FileStream fs = new FileStream(path, FileMode.Open)) lst=(List<data>)(new BinaryFormatter().Deserialize(fs));
            //using (FileStream fs = new FileStream(path, FileMode.Create)) new SoapFormatter().Serialize(fs, tmp);
            //using (FileStream fs = new FileStream(path, FileMode.Open)) lst=(List<data>)(new SoapFormatter().Deserialize(fs));
            Text = lst.Count.ToString();

        }
        private void addConfig(string key, string value, string path)
        {
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = path;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap,
                ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key,value);
            config.Save();
        }



        private void initButtons(string path)
        {
            StreamReader read = new StreamReader(path);
            foreach(Button bt in panel_buttons.Controls)
            {
                bt.Text = read.ReadLine();
            }
        }

        private void readFile(string path)
        {
            StreamReader read = new StreamReader(path);
            String line;
            while ((line = read.ReadLine()) != null)
            {
                cBox.Items.Add(line);
            }
        }
    }

    [Serializable]
    public class data
    {
        public data(string str, int integer)
        {
            this.str = str;
            this.integer = integer;
        }
        public string str { get; set; }
        public int integer { get; set; }

        [NonSerialized]
        public int value;
    }
}
