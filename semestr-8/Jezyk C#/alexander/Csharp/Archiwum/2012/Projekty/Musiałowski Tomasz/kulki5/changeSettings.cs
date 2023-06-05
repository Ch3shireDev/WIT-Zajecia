using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kulki
{
    public partial class changeSettings : Form
    {
        public changeSettings()
        {
            InitializeComponent();
            readSettings();
        }
        private void readSettings()
        {
            string pom;
            int i = 0;
            setting = new string[7];
            try
            {
                plik = new FileStream("settings.conf", FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                this.Close();
                return;
            }
            gameSetting = new StreamReader(plik);
            pom = gameSetting.ReadLine();
            while (pom != null)
            {
                setting[i] = pom;
                i++;
                pom = gameSetting.ReadLine();
            }
            this.comboBox1.Text = setting[0];
            this.comboBox2.Text = setting[1];
            this.comboBox3.Text = setting[2];
            if (setting[3] == "0")
                this.radioButton1.Checked = true;
            if (setting[3] == "1")
                this.radioButton2.Checked = true;
            if (setting[3] == "2")
                this.radioButton3.Checked = true;
            if (setting[4] == "1")
                this.checkBox1.Checked = true;
            if (setting[5] == "1")
                this.checkBox2.Checked = true;
            if (setting[6] == "0")
                this.radioButton4.Checked = true;
            else
                this.radioButton5.Checked = true;
            if (this.radioButton5.Checked == true)
                this.comboBox3.Enabled = false;
            plik.Close();
            gameSetting.Close();
        }
        private void uruchom()
        {
            Application.Run(new gameGUI());
        }
        private void zapisz_ustawienia_Click(object sender, EventArgs e)
        {
            int icons = 0;
            int overSound = 0;
            int fieldSound = 0;
            int gameMode = 0;
            plik = new FileStream("settings.conf", FileMode.Open);
            StreamWriter save = new StreamWriter(plik);
            if (this.radioButton1.Checked == true)
                icons = 0;
            if (this.radioButton2.Checked == true)
                icons = 1;
            if (this.radioButton3.Checked == true)
                icons = 2;
            if (this.checkBox1.Checked == true)
                overSound = 1;
            if (this.checkBox2.Checked == true)
                fieldSound = 1;
            if (this.radioButton4.Checked == true)
                gameMode = 0;
            if (this.radioButton5.Checked == true)
                gameMode = 1;

            save.Write(this.comboBox1.Text + "\r\n" + this.comboBox2.Text + "\r\n" + this.comboBox3.Text + "\r\n" + icons + "\r\n" + overSound + "\r\n" + fieldSound + "\r\n" + gameMode);
            save.Flush();
            save.Close();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(uruchom));
            t.Start();
            Application.ExitThread();
        }
        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked == true)
                this.comboBox3.Enabled = true;
            else
                this.comboBox3.Enabled = false;
        }
    }
}
