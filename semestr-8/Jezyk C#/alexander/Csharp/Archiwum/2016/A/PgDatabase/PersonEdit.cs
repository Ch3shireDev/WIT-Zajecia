using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgDatabase
{
    public partial class PersonEdit : Form
    {
        public PersonEdit()
        {
            InitializeComponent();
        }

        public static bool Execute(ref string surname, ref string name, ref string PESEL, ref string adres)
        {
            PersonEdit frm = new PersonEdit();
            frm.txtSurname.Text = surname;
            frm.txtName.Text = name;
            frm.txtPESEL.Text = PESEL;
            frm.txtAdres.Text = adres;
            if (frm.ShowDialog()!=DialogResult.OK) return false;
            surname = frm.txtSurname.Text;
            name = frm.txtName.Text;
            PESEL = frm.txtPESEL.Text;
            adres = frm.txtAdres.Text;
            return true;
        }
    }
}
