using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseFrame
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"P:\Barski\C#\B\UseFrame\Koala.jpg");
            Employee emp = new Employee(bmp, "Kowalski Piotr", "123 456 789");
            EmployeeFrame frm = new EmployeeFrame(emp);
            SuspendLayout();
            Box.Controls.Add(frm);
            frm.Dock = DockStyle.Top;
            ResumeLayout(false);
        }
    }
}
