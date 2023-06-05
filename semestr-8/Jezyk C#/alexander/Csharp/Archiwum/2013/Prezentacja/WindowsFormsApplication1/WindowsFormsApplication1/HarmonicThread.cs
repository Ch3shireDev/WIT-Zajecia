using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public class HarmonicThread
    {
        static public Int32 id=1;
        private Int32 count;
        private Double result;
        private ProgressBar pbar;
        private Thread thread;
        private ListBox lb;
        private Panel panel;
        private Form1 form;
        public int progress;

        public HarmonicThread(Int32 ai_count, Form1 a_form)
        {
            count = ai_count;

            form = a_form;
            //panel = a_form.Controls.Find("panel1", true).FirstOrDefault() as Panel;
            panel = a_form.panel1;
            lb = a_form.Controls.Find("listbox1", true).FirstOrDefault() as ListBox;

            pbar = new System.Windows.Forms.ProgressBar();
            pbar.Minimum = 0;
            pbar.Maximum = ai_count;
            pbar.Location = new System.Drawing.Point(4, 4);
            pbar.Name = "progressBar" + id.ToString();
            pbar.Size = new System.Drawing.Size(312, 23);
            pbar.TabIndex = 0;
            panel.Controls.Add(pbar);

            // rearrange teraz

        }

        public void StartThread()
        {
            thread = new Thread(new ThreadStart(this.Sum));
            thread.Start();
        }

        public Int32 getCount()
        {
            return count;
        }

        public ProgressBar getPBar()
        {
            return pbar;
        }

        public String getPBarName()
        {
            return pbar.Name;
        }
        
        public void Sum()
        {
            Double ld_result = 0;
            for (int i = 1; i <= count; i++)
            {
                ld_result = ld_result + 1.0 / i;
                if (i % 100000 == 0)
                {
                    progress = i;
                    form.SetProgressBarValueThread(this);
                }
            }

            result = ld_result;
            form.NewListBoxThread(this);
            form.ThreadRearrange();
        }

        public Double GetResult()
        {
            return result;
        }
    }
}
