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
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
            PersonControl_Resize(null, null);
        }
        public void Rebind(Person person)
        {
            TxtName.DataBindings.Clear();
            TxtSurname.DataBindings.Clear();
            PbxImage.DataBindings.Clear();
            if(person!=null)
            {
                TxtName.DataBindings.Add(nameof(TxtName.Text),person,nameof(person.Name),false,DataSourceUpdateMode.OnPropertyChanged);
                TxtSurname.DataBindings.Add(nameof(TxtSurname.Text), person, nameof(person.Surname), false, DataSourceUpdateMode.OnPropertyChanged);
                //PnImage.DataBindings.Add(nameof(PbxImage.Image), person, nameof(person.Image), false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        private void PersonControl_Resize(object sender, EventArgs e)
        {
            PnImage.Width = (int)Math.Round((PnImage.Height - 8) * (3.0 / 4)) + 8;
        }
    }
}
