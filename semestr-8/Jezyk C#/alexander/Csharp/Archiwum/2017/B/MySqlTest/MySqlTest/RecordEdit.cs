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
    public partial class RecordEdit : Form
    {
        public RecordEdit()
        {
            InitializeComponent();
        }
        public static bool Execute(ref string name, ref string surname, ref string phones)
        {
            using (RecordEdit form = new RecordEdit())
            {
                form.edName.Text = name;
                form.edSurname.Text = surname;
                form.edPhones.Text = phones;
                bool result = (form.ShowDialog() == DialogResult.OK);
                if(result)
                {
                    name = form.edName.Text.Trim();
                    surname = form.edSurname.Text.Trim();
                    phones = form.edPhones.Text.Trim();
                }
                return result;
            }
        }
    }
}
