using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class WorkerControl : UserControl
    {
        private Worker _worker;
        private bool _readOnly;
        public event EventHandler EditCall;
        public WorkerControl()
        {
            InitializeComponent();
        }

        public bool readOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                EdName.ReadOnly = value;
                EdSurname.ReadOnly = value;
                if (value)
                {
                    EdPhoto.DoubleClick -= EdPhoto_DoubleClick;
                    EdPhoto.DoubleClick += WorkerControl_DoubleClick;
                    EdName.DoubleClick += WorkerControl_DoubleClick;
                    EdNameHint.DoubleClick += WorkerControl_DoubleClick;
                    EdSurname.DoubleClick += WorkerControl_DoubleClick;
                    EdSurnameHint.DoubleClick += WorkerControl_DoubleClick;
                    Client.DoubleClick += WorkerControl_DoubleClick;
                    DoubleClick += WorkerControl_DoubleClick;
                }
                else
                {
                    EdName.DoubleClick -= WorkerControl_DoubleClick;
                    EdNameHint.DoubleClick -= WorkerControl_DoubleClick;
                    EdSurname.DoubleClick -= WorkerControl_DoubleClick;
                    EdSurnameHint.DoubleClick -= WorkerControl_DoubleClick;
                    Client.DoubleClick -= WorkerControl_DoubleClick;
                    DoubleClick -= WorkerControl_DoubleClick;
                    EdPhoto.DoubleClick -= WorkerControl_DoubleClick;
                    EdPhoto.DoubleClick += EdPhoto_DoubleClick;
                }
            }
        }

        public Worker worker
        {
            get { return _worker; }
            set
            {
                EdName.DataBindings.Clear();
                EdSurname.DataBindings.Clear();
                EdPhoto.DataBindings.Clear();
                _worker = value;
                if(_worker!=null)
                {
                    EdName.DataBindings.Add("Text", _worker, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
                    EdSurname.DataBindings.Add("Text", _worker, "Surname", false, DataSourceUpdateMode.OnPropertyChanged);
                    EdPhoto.DataBindings.Add("Image", _worker, "Photo", false, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void WorkerControl_Resize(object sender, EventArgs e)
        {
            EdPhoto.Width = EdPhoto.Height * 4 / 5;
        }

        private void EdName_TextChanged(object sender, EventArgs e)
        {
            EdNameHint.Visible = (EdName.Text.Trim().Length <= 0);
        }

        private void EdSurname_TextChanged(object sender, EventArgs e)
        {
            EdSurnameHint.Visible = (EdSurname.Text.Trim().Length <= 0);
        }

        private void EdPhoto_DoubleClick(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                worker.Photo = new Bitmap(DlgOpen.FileName);
            }
        }

        private void WorkerControl_DoubleClick(object sender, EventArgs e)
        {
            EditCall?.Invoke(_worker, e);
        }
    }
}
