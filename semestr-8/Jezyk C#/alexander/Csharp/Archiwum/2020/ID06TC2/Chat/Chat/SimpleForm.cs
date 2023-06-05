using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    delegate void SetTextValue(string text);
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();
        }

        private int suma(int a,int b)
        {
            int c;
            c = a + b;
            return c;
        }

        private void setC(string text)
        {
            EdC.Text = text;
        }
        private void setC_invoke(string text)
        {
            Invoke(new SetTextValue(setC), new object[] { text });
        }

        private void calculate()
        {
            try
            {
                int a = int.Parse(EdA.Text);
                try
                {
                    int b = int.Parse(EdB.Text);
                    int c = suma(a, b);
                    setC_invoke(c.ToString());
                }
                catch (Exception e)
                {
                    setC_invoke("Niepoprawna liczba B");
                }
            }
            catch(Exception e)
            {
                setC_invoke("Niepoprawna liczba A");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => calculate());
            th.Start();
        }
    }
}
