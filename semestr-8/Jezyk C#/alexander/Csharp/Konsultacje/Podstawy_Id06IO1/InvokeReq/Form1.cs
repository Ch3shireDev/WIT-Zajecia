using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokeReq
{
    public partial class Form1 : Form
    {
        delegate void AppendLogProc(string text);
        public Form1()
        {
            InitializeComponent();
            //Invoke() - method
            //InvokeRequired - property
        }

        public void AppendLog(string text)
        {
            txtLog.AppendText(text + Environment.NewLine);
        }
        public void InvokeAppendLog(string text)
        {
            Invoke(new AppendLogProc(AppendLog),text);
        }
        public void SafeAppendLog(string text)
        {
            if(InvokeRequired) InvokeAppendLog(text);
            else AppendLog(text);
        }

        public void CallAppend()
        {
            AppendLog("ala ma kota");
        }
        public void CallInvokeAppend()
        {
            InvokeAppendLog("ala ma kota");
        }
        public void CallSafeAppend()
        {
            SafeAppendLog("ala ma kota");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (ckbThread.Checked) new Thread(CallAppend).Start();
            else CallAppend();
        }

        private void btnInoke_Click(object sender, EventArgs e)
        {
            if (ckbThread.Checked) new Thread(CallInvokeAppend).Start();
            CallInvokeAppend();
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            if (ckbThread.Checked) new Thread(CallSafeAppend).Start();
            CallSafeAppend();
        }
    }
}
