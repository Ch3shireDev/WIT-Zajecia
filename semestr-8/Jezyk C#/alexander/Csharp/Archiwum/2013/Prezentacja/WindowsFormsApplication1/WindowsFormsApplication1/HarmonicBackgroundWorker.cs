using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApplication1
{
    public class HarmonicBackgroundWorker
    {
        private Int32 count;
        private Double result;
        private ProgressBar pbar;
        private BackgroundWorker bw;
        private ListBox lb;
        private Panel panel;
        private Form1 form;

        public HarmonicBackgroundWorker(Int32 ai_count, Form1 a_form)
        {
            count = ai_count;

            form = a_form;
            panel = a_form.Controls.Find("panel1", true).FirstOrDefault() as Panel;
            lb = a_form.Controls.Find("listbox1", true).FirstOrDefault() as ListBox;

            pbar = new System.Windows.Forms.ProgressBar();
            pbar.Minimum = 0;
            pbar.Maximum = ai_count;
            pbar.Location = new System.Drawing.Point(4, 4);
            pbar.Name = "progressBar1";
            pbar.Size = new System.Drawing.Size(312, 23);
            pbar.TabIndex = 0;
            panel.Controls.Add(pbar);

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);

            bw.WorkerReportsProgress = true;
            bw.RunWorkerAsync(this);
        }

        public Int32 getCount()
        {
            return count;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HarmonicBackgroundWorker obj = (HarmonicBackgroundWorker)e.Argument;
            obj.Sum();
            e.Result = obj;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HarmonicBackgroundWorker obj = (HarmonicBackgroundWorker)e.Result;
            lb.Items.Add(obj.getCount().ToString() + '\t' + obj.GetResult().ToString());
            panel.Controls.Remove(pbar);
            form.ThreadRearrange();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
        }

        public void Sum()
        {
            Double ld_result = 0;
            for (int i = 1; i <= count; i++)
            {
                ld_result = ld_result + 1.0 / i;
                if (i % 100000 == 0)
                {
                    bw.ReportProgress(i);
                }
            }

            result = ld_result;
        }

        public Double GetResult()
        {
            return result;
        }
    }
}
