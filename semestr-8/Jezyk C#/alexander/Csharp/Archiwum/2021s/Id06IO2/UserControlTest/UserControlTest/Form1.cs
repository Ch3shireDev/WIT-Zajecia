using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = "Adam";
            person.Surname = "Kowalski";
            person.Image = new Bitmap(1, 1);

            PersonControl pc = new PersonControl();
            pc.Parent = PnList;
            pc.Dock = DockStyle.Top;
            pc.Rebind(person);
        }
    }
}
