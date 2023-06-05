using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThreeButtons t = new ThreeButtons(Box, null, 4, 4);

            //BtnAs.Name = "BtnAs";
            //BtnAs.TabIndex = 0;
            //BtnAs.UseVisualStyleBackColor = true;
        }
    }
    public class ThreeButtons
    {
        private static uint Id=0;
        private Control Frm;
        private Button BtnD,BtnN,BtnS;
        private Label Lbl;
        private ThreeButtons Parent, Head, Tail, Next, Prev;
        private Button btn(int x, int y, string name)
        {
            Button Btn = new Button();
            Btn.Location = new Point(x, y);
            Btn.Size = new Size(36, 24);
            Btn.Text = name;
            Frm.Controls.Add(Btn);
            return Btn;
        }
        public ThreeButtons(Control frm, ThreeButtons up, int x, int y)
        {
            Frm = frm;
            Parent = up;
            BtnD = btn(x, y, "Del");
            if (up == null) BtnD.Enabled = false;
            else BtnD.Click += DelClick;
            BtnS = btn(x + 35, y, "Sub");
            BtnS.Click += SubClick;
            BtnN = btn(x + 70, y, "Nxt");
            if (up == null) BtnN.Enabled = false;
            else BtnN.Click += NxtClick;
            Lbl = new Label();
            Lbl.Location = new Point(x + 105, y);
            Lbl.Size = new Size(36, 24);
            Lbl.Text = (++Id).ToString();
            Lbl.TextAlign = ContentAlignment.MiddleLeft;
            Lbl.Click += LblClick;
            //Lbl.Click += new EventHandler(LblClick);
            Frm.Controls.Add(Lbl);
        }
        private void DelClick(object sender,EventArgs e)
        {
            Frm.Controls.Remove(BtnD);
            Frm.Controls.Remove(BtnN);
            Frm.Controls.Remove(BtnS);
            Frm.Controls.Remove(Lbl);
            if (Prev != null) Prev.Next = Next; else Parent.Head = Next;
            if (Next != null) Next.Prev = Prev; else Parent.Tail = Prev;
            for (ThreeButtons i = Head; i != null; i = i->Next) { }
            Boss.Move();
        }
        private void SubClick(object sender, EventArgs e)
        {
            ThreeButtons Curr = new ThreeButtons(Frm, this, BtnD.Location.X+24, BtnD.Location.Y+24);
            Curr.Next = Head;
            if (Head != null) Head.Prev = Curr; 
            else Tail = Curr;
            Head = Curr;
            Boss.Move();
        }
        private void NxtClick(object sender, EventArgs e)
        {
            ThreeButtons Curr = new ThreeButtons(Frm, Parent, BtnD.Location.X, BtnD.Location.Y + 24);
            if (Next != null) Next.Prev = Curr;
            else Parent.Tail = Curr;
            Curr.Prev = this;
            Curr.Next = Next;
            Next = Curr;
            Boss.Move();
        }
        private void LblClick(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                getId(Parent, "Parent: ", Environment.NewLine) +
                getId(Prev, "Prev: ", Environment.NewLine) +
                getId(Next, "Next: ", Environment.NewLine) +
                getId(Head, "Head: ", Environment.NewLine) +
                getId(Tail, "Tail: ", ""),
                "Me: " + Lbl.Text
            );
        }
        private static string getId(ThreeButtons curr,string prefix,string sufix)
        {
            return prefix + (curr != null ? curr.Lbl.Text : "null") + sufix;
        }
        private void Move(ref int y)
        {
            if (Parent != null)
            {
                y += 24;
                BtnD.Location = new Point(BtnD.Location.X, y);
                BtnS.Location = new Point(BtnS.Location.X, y);
                BtnN.Location = new Point(BtnN.Location.X, y);
                Lbl.Location = new Point(Lbl.Location.X, y);
            }
            for (ThreeButtons i = Head; i != null; i = i.Next) i.Move(ref y);
        }
        private void Move()
        {
            int y = BtnD.Location.Y;
            Move(ref y);
            //Frm.FindForm().Invalidate();
        }
        private ThreeButtons Boss 
        {
            get { return Parent != null?Parent.Boss:this; }
        }
    }
}
