using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTableSize(8);
        }

        private TextBox[,] boxes;

        private double[,] FromString(string text)
        {
            string[] rows = text.Trim().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int size = rows.Length;
            double[,] tb = new double[size, size];
            for (int y = 0; y < size; ++y)
            {
                string[] cols = rows[y].Trim().Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cols.Length != size) return null;
                for (int x = 0; x < size; ++x)
                {
                    if (!double.TryParse(cols[x], out tb[y, x])) return null;
                }
            }
            return tb;
        }

        private double[,] FromField()
        {
            return FromString(BoxTab.Text);
        }

        private double[,] FromTable()
        {
            int size = (int)TabSize.Value;
            double[,] tb = new double[size, size];
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    tb[y, x] = double.Parse(boxes[y, x].Text);
                }
            }
            return tb;
        }

        private string ToText(double[,] tb)
        {
            string ret = "";
            int size = tb.GetLength(0);
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    ret += "" + tb[y, x] + '\t';
                }
                ret = ret.Trim() + Environment.NewLine;
            }
            return ret;
        }

        void CompareTables()
        {
            string str = "";
            double[,] tb1 = FromField();
            if(tb1 == null)
            {
                str = "W polu tekstowym - niepoprawna tablica";
            }
            else
            {
                int size = tb1.GetLength(0);
                double[,] tb2 = FromTable();
                if (size != tb2.GetLength(0))
                {
                    str = "Rozmiary tablic są różne";
                }
                else
                {
                    bool ok = true;
                    for (int y = 0; y < size; ++y)
                    {
                        for (int x = 0; x < size; ++x)
                        {
                            ok = (tb1[y,x] == tb2[y,x]);
                            if(!ok) break;
                        }
                        if(!ok) break;
                    }
                    if (ok) str = "Tablice są identyczne";
                    else str = "Tablice są różne";
                }
            }

            Info.Text = str;
        }

        private void SaveText(TextBox box)
        {
            box.Tag = new Object[] { box.Text, box.SelectionStart, box.SelectionLength };
        }

        private void RestoreText(TextBox box)
        {
            Object[] arr = (Object[])box.Tag;
            box.Text = (String)arr[0];
            box.SelectionStart = (Int32)arr[1];
            box.SelectionLength = (Int32)arr[2];
        }

        private void SetTableSize(int size)
        {
            SuspendLayout();
            Tab.SuspendLayout();
            Tab.Controls.Clear();
            Tab.ColumnStyles.Clear();
            Tab.RowStyles.Clear();
            Tab.ColumnCount = size;
            Tab.RowCount = size;
            float percent = 100F / size;
            for (int s = 0; s < size; ++s)
            {
                Tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
                Tab.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }
            boxes = new TextBox[size, size];
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    TextBox box = new TextBox();
                    boxes[y, x] = box;
                    box.Dock = DockStyle.Fill;
                    box.Margin = new Padding(0, 0, 1, 1);
                    box.Text = "0";
                    box.TextAlign = HorizontalAlignment.Right;
                    box.Enter += box_Enter;
                    box.TextChanged += box_TextChanged;
                    box.MouseUp += box_MouseUp;
                    box.KeyUp += box_KeyUp;
                    Tab.Controls.Add(box, x, y);
                    SaveText(box);
                }
            }
            Tab.ResumeLayout(true);
            ResumeLayout(true);
        }

        private void SetTableValues(double[,] tb)
        {
            int size=tb.GetLength(0);
            TabSize.Value = size;
            SetTableSize(size);
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    boxes[y, x].Text = tb[y, x].ToString();
                }
            }
        }

        private void TabSize_ValueChanged(object sender, EventArgs e)
        {
            SetTableSize((int)TabSize.Value);
        }

        private void box_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            double v;
            if(double.TryParse(box.Text,out v)) SaveText(box);
            else RestoreText(box);
        }

        private void box_MouseUp(object sender, MouseEventArgs e)
        {
            SaveText((TextBox)sender);
        }

        private void box_KeyUp(object sender, KeyEventArgs e)
        {
            SaveText((TextBox)sender);
        }

        private void BoxTab_TextChanged(object sender, EventArgs e)
        {
            CompareTables();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            double[,] tb;
            if (Tabs.SelectedIndex == 1) tb = FromField();
            else tb = FromTable();
            Clipboard.SetText(ToText(tb));
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                double[,] tb = FromString(Clipboard.GetText());
                if (tb != null)
                {
                    if (Tabs.SelectedIndex == 1) BoxTab.Text = ToText(tb);
                    else SetTableValues(tb);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                double[,] tb;
                if (Tabs.SelectedIndex == 1) tb = FromField();
                else tb = FromTable();
                using (StreamWriter sw = new StreamWriter(DlgSave.FileName)) sw.Write(ToText(tb));
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                double[,] tb;
                using (StreamReader sr = new StreamReader(DlgOpen.FileName)) tb = FromString(sr.ReadToEnd());
                if (tb != null)
                {
                    if (Tabs.SelectedIndex == 1) BoxTab.Text = ToText(tb);
                    else SetTableValues(tb);
                }                
            }
        }
    }
}
