using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgress
{
    public delegate void InsertProc(string nazwisko, string imie, string pesel, string adres);
    public partial class PostgresEdit : Form
    {
        public PostgresEdit()
        {
            InitializeComponent();
        }
        public static void Execute(InsertProc proc)
        {
            PostgresEdit frm = new PostgresEdit();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                frm.InsertData(proc);
            }
        }
        private void InsertData(InsertProc proc)
        {
            proc(txtSurname.Text, txtName.Text, txtPESEL.Text, txtAdres.Text);
        }
    }
}
