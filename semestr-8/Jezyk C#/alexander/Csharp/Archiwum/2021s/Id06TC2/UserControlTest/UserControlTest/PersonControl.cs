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
    public enum ShowReason { View,Edit }
    public partial class PersonControl : UserControl
    {
        private Person person;
        public PersonControl()
        {
            InitializeComponent();
            PersonControl_Resize(null, null);
        }

        public void Bind(Person person, ShowReason reason)
        {
            TxtGivenname.DataBindings.Clear();
            TxtSurname.DataBindings.Clear();
            PbImage.DataBindings.Clear();
            this.person = person;
            if (person != null) 
            {
                TxtGivenname.DataBindings.Add(nameof(TxtGivenname.Text), person, nameof(person.Givenname), false, DataSourceUpdateMode.OnPropertyChanged);
                TxtSurname.DataBindings.Add(nameof(TxtSurname.Text), person, nameof(person.Surname), false, DataSourceUpdateMode.OnPropertyChanged);
                PbImage.DataBindings.Add(nameof(PbImage.Image), person, nameof(person.Image), true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if(reason==ShowReason.View)
            {
                TxtGivenname.ReadOnly = true;
                TxtSurname.ReadOnly = true;
                PnButtons.Visible = true;
            }
        }

        private void PersonControl_Resize(object sender, EventArgs e)
        {
            int padV = PnImage.Padding.Top + PnImage.Padding.Bottom;
            int padH = PnImage.Padding.Left + PnImage.Padding.Right;
            PnImage.Width = (int)Math.Round((PnImage.Height + padV) * (3.0 / 4) + padH);
        }

        private void PbImage_DoubleClick(object sender, EventArgs e)
        {
            if(DlgOpen.ShowDialog()==DialogResult.OK)
            {
                person.Image = new Bitmap(DlgOpen.FileName);
            }
        }
    }
}
