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
    public partial class WorkerEditor : Form
    {
        private string name, surname;
        private Bitmap picture;
        public WorkerEditor()
        {
            InitializeComponent();
        }
        public Worker Person
        {
            get { return UcWorker.Person; }
            set
            {
                UcWorker.Person = value;
                name = value.Name;
                surname = value.Surname;
                picture = value.Picture;
            }
        }

        private void WorkerEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                Worker person = UcWorker.Person;
                person.Name = name;
                person.Surname = surname;
                person.Picture = picture;
            }
        }
    }
}
