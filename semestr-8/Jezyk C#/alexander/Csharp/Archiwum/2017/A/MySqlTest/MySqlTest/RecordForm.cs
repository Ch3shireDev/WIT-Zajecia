using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlTest
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }
        public static bool Execute(ref string name, ref string surname, ref string phones)
        {
            using (RecordForm form = new RecordForm())
            {
                form.edName.Text = name;
                form.edSurname.Text = surname;
                form.edPhones.Text = phones;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    name = form.edName.Text.Trim();
                    surname = form.edSurname.Text.Trim();
                    phones = form.edPhones.Text.Trim();
                    return true;
                }
            }
            name = surname = phones = null;
            return false;
        }
    }
}
