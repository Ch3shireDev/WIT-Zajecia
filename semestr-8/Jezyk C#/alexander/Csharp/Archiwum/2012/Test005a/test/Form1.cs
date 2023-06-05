using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap("empty.bmp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("em.bmp", FileMode.Create);
            bmp.Save(fs, ImageFormat.Bmp);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            ms.Position = 0;
            byte[] buf = new byte[ms.Length];
            ms.Read(buf, 0, (int)ms.Length);

            FileStream fs = new FileStream("emp.bmp", FileMode.Create);
            fs.Write(buf, 0, (int)ms.Length);
            fs.Close();
        }
    }
}