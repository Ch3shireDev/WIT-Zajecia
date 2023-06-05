using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AddBox
{
    public class Int32Box:TextBox
    {
        private string SaveText;
        private int SaveStart, SaveLength;
        private bool Flag;

        public Int32Box()
        {
            StartupInit();
            //InitializeComponent();
        }

        public Int32Box(IContainer container)
        {
            StartupInit();
            container.Add(this);
            //InitializeComponent();
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                Flag = true;
                int val;
                if(value.Length==0)
                {
                    base.Text = SaveText = value;
                    SaveStart = SaveLength = 0;
                }
                else if (Int32.TryParse(value, out val))
                {
                    base.Text = SaveText = value;
                    SaveStart = SaveLength = SaveText.Length;
                }
                Flag = false;
            }
        }

        [Category("Apperance"),Description("Int value")]
        public int Value
        {
            get
            {
                int val=0;
                Int32.TryParse(Text, out val);
                return val;
            }
            set
            {
                Text = SaveText = value.ToString();
                SaveStart = SaveText.Length;
                SaveLength = 0;
            }

        }

        private void StartupInit()
        {
            SaveStart=1;
            SaveLength=0;
            Text=SaveText="0";
            Flag = false;
            TextAlign = HorizontalAlignment.Right;
        }

        private void SaveSel()
        {
            SaveStart = SelectionStart;
            SaveLength = SelectionLength;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            SaveSel();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            SaveSel();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Flag) return;
            int val, L = Text.Length;
            if (L == 0)
            {
                base.OnTextChanged(e);
            }
            else if (Int32.TryParse(Text, out val))
            {
                Flag = true;
                int N = 0;
                SaveText = Text;
                SaveSel();
                --L;
                for (; N < L; ++N) if (SaveText[N] != '0') break;
                if (N>0)
                {
                    Text = SaveText.Remove(0, N);
                    if (SaveStart > 0)
                    {
                        SelectionStart = SaveStart = SaveText.Length;
                    }
                }

                Flag = false;
                base.OnTextChanged(e);
            }
            else
            {
                Flag = true;
                Text = SaveText;
                SelectionStart = SaveStart;
                SelectionLength = SaveLength;
                Flag = false;
            }
        }

    }
}
