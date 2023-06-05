using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SpecialButton
{
    public partial class SpecialButton : Button
    {
        public SpecialButton()
        {
            //InitializeComponent();
        }

        public SpecialButton(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
        }
    }
}
