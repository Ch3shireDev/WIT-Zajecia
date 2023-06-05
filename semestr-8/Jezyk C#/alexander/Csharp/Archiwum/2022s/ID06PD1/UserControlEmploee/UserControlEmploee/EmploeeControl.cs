using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlEmploee
{
    public partial class EmploeeControl : UserControl
    {
        private Employee employee = null;
        public EmploeeControl(Employee employee)
        {
            InitializeComponent();
            CurrentEmployee = employee;
        }

        public Employee CurrentEmployee
        {
            get { return employee; }
            set
            {
                if (employee == value) return;
                TbName.DataBindings.Clear();
                TbSurname.DataBindings.Clear();
                PbPicture.DataBindings.Clear();
                employee = value;
                if (employee == null) return;
                TbName.DataBindings.Add(nameof(TbName.Text), employee, nameof(employee.Name), false, DataSourceUpdateMode.OnPropertyChanged);
                TbSurname.DataBindings.Add(nameof(TbSurname.Text), employee, nameof(employee.Surname), false, DataSourceUpdateMode.OnPropertyChanged);
                PbPicture.DataBindings.Add(nameof(PbPicture.Image), employee, nameof(employee.Image), false);
            }
        }

        private void EmploeeControl_Resize(object sender, EventArgs e)
        {
            int pw = PnPicture.Padding.Left + PnPicture.Padding.Right;
            int ph = PnPicture.Padding.Top + PnPicture.Padding.Bottom;
            int h = PnPicture.Height;
            PnPicture.Width = 3 * (PnPicture.Height - ph) / 4 + pw;
        }

        private void PbPicture_DoubleClick(object sender, EventArgs e)
        {
            if(DlgOpen.ShowDialog()==DialogResult.OK)
            {
                //PbPicture.Image = new Bitmap(DlgOpen.FileName); // nie odpała się employee.Image.set ??
                employee.Image = new Bitmap(DlgOpen.FileName);
            }
        }
    }
}
