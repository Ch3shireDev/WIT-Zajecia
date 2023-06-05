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
    public partial class WorkerEdit : Form
    {
        private string CopySurname, CopyName;
        private Bitmap CopyPhoto;
        public WorkerEdit()
        {
            InitializeComponent();
        }
        public Worker worker
        {
            get { return EdWorker.worker; }
            set
            {
                EdWorker.worker = value;
                CopySurname = value.Surname;
                CopyName = value.Name;
                CopyPhoto = value.Photo;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Worker tmp = EdWorker.worker;
            tmp.Surname = CopySurname;
            tmp.Name = CopyName;
            tmp.Photo = CopyPhoto;
        }
    }
}
