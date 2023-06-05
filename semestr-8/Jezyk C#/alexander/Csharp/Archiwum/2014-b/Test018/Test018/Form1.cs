using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test018
{
    public partial class Form1 : Form
    {
        private layer lst = new layer();
        private Point downpt;
        private shape.HitTest isdown = shape.HitTest.htNone;
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendListBox(shape s, object obj)
        {
            ListBox.Items.Add(s);
        }

        private void RefreshListBox(shape s)
        {
            ListBox.BeginUpdate();
            try
            {
                ListBox.Items.Clear();
                lst.Fill(AppendListBox, null);
                ListBox.SelectedItem = s;
                PaintBox.Invalidate();
            }
            finally
            {
                ListBox.EndUpdate();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            RefreshListBox((shape)timer.Tag);
        }

        private void RefreshListBoxObj(object s)
        {
            //RefreshListBox((shape)s);
            timer.Tag = s;
            timer.Enabled = true;
        }

        private void btnNewCircle_Click(object sender, EventArgs e)
        {
            RefreshListBox(lst.AddCircle());
        }

        private void btnNewSquare_Click(object sender, EventArgs e)
        {
            RefreshListBox(lst.AddSquare());
        }

        private void btnNewRectangle_Click(object sender, EventArgs e)
        {
            RefreshListBox(lst.AddRectangle());
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape s = ((shape)ListBox.SelectedItem);
            if (s != null)
            {
                LbSurface.Text = "Surface: " + s.surface.ToString("0.00");
                LbPerimeter.Text = "Perimeter: " + s.perimeter.ToString("0.00");
            }
            else
            {
                LbSurface.Text = LbPerimeter.Text = "";
            }
            PaintBox.Invalidate();
        }

        private void PaintShape(shape s, object obj)
        {
            s.paint((Graphics)obj,1);
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            lst.Fill(PaintShape, e.Graphics);
            shape s = ((shape)ListBox.SelectedItem);
            if (s != null)
            {
                Rectangle rect = s.client(1);
                rect.Inflate(5, 5);
                Pen p = new Pen(Color.Silver);
                p.DashPattern = new float[] { 2F, 2F };
                e.Graphics.DrawRectangle(p, rect);
                Rectangle[] tb = s.boxes(1);
                for (int i = 0; i < tb.Length; ++i) e.Graphics.FillRectangle(Brushes.Black, tb[i]);
            }
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            shape s = ((shape)ListBox.SelectedItem);
            if (s != null)
            {
                Rectangle rect = s.client(1);
                rect.Inflate(5, 5);
                Point pt = new Point(e.X, e.Y);
                isdown = s.calcOver(1, pt);
                if (isdown != shape.HitTest.htNone)
                {
                    downpt = pt;
                    PaintBox.Cursor = Cursors.SizeAll;
                    return;
                }
            }
            isdown = shape.HitTest.htNone;
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdown==shape.HitTest.htNone)
            {
                shape s = ((shape)ListBox.SelectedItem);
                if (s != null)
                {
                    Rectangle rect = s.client(1);
                    rect.Inflate(5, 5);
                    if (s.calcOver(1,new Point(e.X, e.Y))!=shape.HitTest.htNone)
                    {
                        PaintBox.Cursor = Cursors.Hand;
                    }
                    else PaintBox.Cursor = Cursors.Default;
                }
            }
            else
            {
                shape s = ((shape)ListBox.SelectedItem);
                if (s != null)
                {
                    double X=1*(e.X-downpt.X), Y=(e.Y-downpt.Y);
                    if (e.Button == MouseButtons.Left)
                    {
                        if (isdown == shape.HitTest.htNone) { } // nothing to do, just align rows below
                        else if (isdown == shape.HitTest.htTL) s.inflate(X / 2, Y / 2, -X, -Y);
                        else if (isdown == shape.HitTest.htTR) s.inflate(X / 2, Y / 2, X, -Y);
                        else if (isdown == shape.HitTest.htBL) s.inflate(X / 2, Y / 2, -X, Y);
                        else if (isdown == shape.HitTest.htBR) s.inflate(X / 2, Y / 2, X, Y);
                        downpt = new Point(e.X, e.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        if (isdown == shape.HitTest.htNone) { } // nothing to do, just align rows below
                        else s.inflate(X, Y, 0, 0);
                        downpt = new Point(e.X, e.Y);
                    }
                    PaintBox.Invalidate();
                }
            }
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            isdown = shape.HitTest.htNone;
        }

        private void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object obj = ListBox.SelectedItem;
            if (obj != null)
            {
                //new Form2(obj, RefreshListBoxObj).ShowDialog();
                new Form2(obj, RefreshListBoxObj).Show();
            }
        }

    }
    public abstract class shape
    {
        public enum HitTest { htNone, htTL, htTR, htBL, htBR };
        private static int sid = 0;
        protected int id { get; set; }
        public string name { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public abstract double perimeter { get; }
        public abstract double surface { get; }
        public shape(string name, double x, double y)
        {
            id=++sid; // TODO upewnić sie że jest atomowa
            this.name = name + id.ToString();
            this.x = x;
            this.y = y;
        }
        public override int GetHashCode() { return id; }
        public override string ToString() { return name; }
        public abstract Rectangle client(double zoom);
        public abstract void paint(Graphics g, double zoom);
        static bool PtInRect(Point p, Rectangle r)
        {
            return (r.Left <= p.X) && (p.X <= r.Right) && (r.Top <= p.Y) && (p.Y <= r.Bottom);
        }
        public Rectangle[] boxes(double zoom)
        {
            Rectangle rect = client(zoom);
            rect.Inflate(5, 5);
            Rectangle[] tb = new Rectangle[4];
            tb[0] = new Rectangle(rect.Left, rect.Top, 5, 5);
            tb[1] = new Rectangle(rect.Right - 4, rect.Top, 5, 5);
            tb[2] = new Rectangle(rect.Left, rect.Bottom - 4, 5, 5);
            tb[3] = new Rectangle(rect.Right - 4, rect.Bottom - 4, 5, 5);
            return tb;
        }
        public HitTest calcOver(double zoom, Point pt)
        {
            Rectangle[] tb = boxes(zoom);
            for (int i = 0; i < tb.Length; ++i) if (PtInRect(pt, tb[i])) return (HitTest)(i + 1);
            return HitTest.htNone;
        }
        public abstract void inflate(double x, double y, double width, double height);
    }
    public abstract class oneparamshape : shape
    {
        protected double p1;
        public oneparamshape(string name, double p1)
            : base(name, 75, 75)
        {
            this.p1 = p1;
        }
        public override Rectangle client(double zoom)
        {
            return new Rectangle
            (
                (int)Math.Round(zoom * (x - p1 / 2)),
                (int)Math.Round(zoom * (y - p1 / 2)),
                (int)Math.Round(zoom * p1),
                (int)Math.Round(zoom * p1)
            );
        }
        public override void inflate(double x, double y, double width, double height)
        {
            this.x += x;
            this.y += y;
            p1 = Math.Max(p1 + (width + height) / 2, 5);
        }
    }
    public abstract class twoparamshape : oneparamshape
    {
        protected double p2;
        public twoparamshape(string name, double p1, double p2)
            : base(name, p1)
        {
            this.p2 = p2;
        }
        public override Rectangle client(double zoom)
        {
            return new Rectangle
            (
                (int)Math.Round(zoom * (x - p1 / 2)),
                (int)Math.Round(zoom * (y - p2 / 2)),
                (int)Math.Round(zoom * p1),
                (int)Math.Round(zoom * p2)
            );
        }
        public override void inflate(double x, double y, double width, double height)
        {
            this.x += x;
            this.y += y;
            p1 = Math.Max(p1 + width, 5);
            p2 = Math.Max(p2 + height, 5);
        }
    }
    public class circle : oneparamshape
    {
        public double diameter { get { return p1; } set { p1 = value; } }
        public override double perimeter { get { return diameter * Math.PI; } }
        public override double surface { get { return diameter * diameter * Math.PI / 4; } }
        public circle(string name, double diameter)
            : base(name, diameter)
        {
        }
        public override void paint(Graphics g, double zoom)
        {
            g.DrawEllipse(Pens.Red, client(zoom));
        }
    }
    public class square : oneparamshape
    {
        public double side { get { return p1; } set { p1 = value; } }
        public override double perimeter { get { return 4*side; } }
        public override double surface { get { return side * side; } }
        public square(string name, double side)
            : base(name, side)
        {
        }
        public override void paint(Graphics g, double zoom)
        {
            g.DrawRectangle(Pens.Blue, client(zoom));
        }
    }
    public class rectangle : twoparamshape
    {
        public double width { get { return p1; } set { p1 = value; } }
        public double height { get { return p2; } set { p2 = value; } }
        public override double perimeter { get { return 2 * (width * height); } }
        public override double surface { get { return width * height; } }
        public rectangle(string name, double width, double height)
            : base(name, width, height)
        {
        }
        public override void paint(Graphics g, double zoom)
        {
            g.DrawRectangle(Pens.Green, client(zoom));
        }
    }
    public class layer
    {
        public delegate void foreachItem(shape s, object obj);
        private List<shape> lst=new List<shape>();
        public int IndexOf(shape s) { return lst.IndexOf(s); }
        public shape AddCircle() { shape s = new circle("circle", 120); lst.Add(s); return s; }
        public shape AddSquare() { shape s = new square("square", 100); lst.Add(s); return s; }
        public shape AddRectangle() { shape s = new rectangle("rectangle", 80, 120); lst.Add(s); return s; }
        public void up(shape s)
        { 
            int pos=IndexOf(s);
            if(pos+1<lst.Count)
            {
                lst[pos]=lst[pos + 1];
                lst[pos + 1] = s;
            }
        }
        public void dn(shape s)
        {
            int pos = IndexOf(s);
            if (pos > 0)
            {
                lst[pos] = lst[pos - 1];
                lst[pos - 1] = s;
            }
        }
        public void Fill(foreachItem call, object obj)
        {
            foreach (shape s in lst) call(s, obj);
        }
    }
}
