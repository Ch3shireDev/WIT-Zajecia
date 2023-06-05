using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseFrame 
{
    public partial class EmployeeFrame : UserControl
    {
        private Employee emp;
        public EmployeeFrame(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            picEmployeeImg.Image = emp.Img;
            lbEmployeeName.Text = emp.Name;
            lbEmployeePhone.Text = emp.Phone;
        }
    }
}
