﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class PersonEdit : Form
    {
        public PersonEdit()
        {
            InitializeComponent();
        }

        public Person Person
        {
            get { return UcPerson.Person; }
            set { UcPerson.Person = value; }
        }
    }
}
