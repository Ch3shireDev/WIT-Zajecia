using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace UserControlTest
{
    public partial class WorkerControl : UserControl
    {
        private Worker person;
        private bool readOnly;
        public event EventHandler<EventArgs> DblClick;
        public WorkerControl()
        {
            InitializeComponent();
        }
        public Worker Person
        {
            get { return person; }
            set
            {
                if (person != value)
                {
                    EdName.DataBindings.Clear();
                    EdSurname.DataBindings.Clear();
                    Picture.DataBindings.Clear();
                    person = value;
                    EdName.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
                    EdSurname.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.OnPropertyChanged);
                    Picture.DataBindings.Add("Image", person, "Picture", false, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                EdName.ReadOnly = value;
                EdSurname.ReadOnly = value;
            }
        }

        private void WorkerControl_Resize(object sender, EventArgs e)
        {
            Picture.Width = Picture.Height * 4 / 5;
        }

        private void CallDoubleClick(EventArgs e)
        {
            if (readOnly) DblClick(this, e);
        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            if (readOnly) CallDoubleClick(e);
            else
            {
                DialogResult ret = DlgOpen.ShowDialog(this);
                if (ret == DialogResult.OK)
                {
                    person.Picture = new Bitmap(DlgOpen.FileName);
                }
            }
        }

        private void Client_DoubleClick(object sender, EventArgs e)
        {
            CallDoubleClick(e);
        }
    }
}
