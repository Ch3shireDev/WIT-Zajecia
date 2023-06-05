using System;
using System.Drawing;
using System.Windows.Forms;

using Crom.Controls.Docking;
using System.IO;
using System.Collections.Generic;

namespace Crom.Controls.Test
{
    delegate Form CreateFormProc();
    /// <summary>
    /// Form
    /// </summary>
    public class DockTest : Form
    {
        #region Fields


        private DockContainer _docker = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem _menuFile;
        private ToolStripMenuItem _menuFileSave;
        private ToolStripMenuItem _menuFileLoad;
        private ToolStripSeparator _menuFileS1;
        private ToolStripMenuItem _menuFileExit;
        private ToolStripMenuItem _menuWork;
        private ToolStripMenuItem _menuWorkInitialize;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem addSomeMenuHereToolStripMenuItem;
        private ToolStripMenuItem _menuHelp;
        private ToolStripMenuItem _menuHelpInfo;
        private DockStateSerializer _serializer = null;

        #endregion Fields

        #region Instance

        /// <summary>
        /// Default constructor
        /// </summary>
        public DockTest()
        {
            InitializeComponent();

            _serializer = new DockStateSerializer(_docker);
            _docker.PreviewRenderer = new CustomPreviewRenderer();
            _docker.ShowContextMenu += OnDockerShowContextMenu;
            _docker.FormClosing += OnDockerFormClosing;
            _docker.FormClosed += OnDockerFormClosed;

            Info info = new Info();
            info.ShowDialog();
        }

        #endregion Instance

        #region Private section

        private void OnFileSaveClick(object sender, EventArgs e)
        {
            _serializer.Save();
        }

        private void OnFileLoadClick(object sender, EventArgs e)
        {
            if (File.Exists(_serializer.SavePath) == false)
            {
                MessageBox.Show("Must save a layout before loading it.");
                return;
            }

            _serializer.Load(false, CreateTestForm);
        }

        private void OnFileExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnWorkInitializeClick(object sender, EventArgs e)
        {
            Initialize();
        }

        private void OnHelpInfoClick(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        void OnDockerShowContextMenu(object sender, FormContextMenuEventArgs e)
        {
            contextMenuStrip1.Show(e.Form, e.MenuLocation);
        }

        void OnDockerFormClosed(object sender, FormEventArgs e)
        {
            e.Form.Close();
        }

        void OnDockerFormClosing(object sender, DockableFormClosingEventArgs e)
        {
            DockableFormInfo info = _docker.GetFormInfo(e.Form);
            if (info.Id == new Guid("0a3f4468-080b-404e-b012-997b93ed2005"))
            {
                e.Cancel = true;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._docker = new Crom.Controls.Docking.DockContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileS1 = new System.Windows.Forms.ToolStripSeparator();
            this._menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuWork = new System.Windows.Forms.ToolStripMenuItem();
            this._menuWorkInitialize = new System.Windows.Forms.ToolStripMenuItem();
            this._menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._menuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSomeMenuHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _docker
            // 
            this._docker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this._docker.Dock = System.Windows.Forms.DockStyle.Fill;
            this._docker.Location = new System.Drawing.Point(0, 24);
            this._docker.Name = "_docker";
            this._docker.Size = new System.Drawing.Size(292, 242);
            this._docker.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuFile,
            this._menuWork,
            this._menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _menuFile
            // 
            this._menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuFileSave,
            this._menuFileLoad,
            this._menuFileS1,
            this._menuFileExit});
            this._menuFile.Name = "_menuFile";
            this._menuFile.Size = new System.Drawing.Size(37, 20);
            this._menuFile.Text = "&File";
            // 
            // _menuFileSave
            // 
            this._menuFileSave.Name = "_menuFileSave";
            this._menuFileSave.Size = new System.Drawing.Size(100, 22);
            this._menuFileSave.Text = "&Save";
            this._menuFileSave.Click += new System.EventHandler(this.OnFileSaveClick);
            // 
            // _menuFileLoad
            // 
            this._menuFileLoad.Name = "_menuFileLoad";
            this._menuFileLoad.Size = new System.Drawing.Size(100, 22);
            this._menuFileLoad.Text = "Load";
            this._menuFileLoad.Click += new System.EventHandler(this.OnFileLoadClick);
            // 
            // _menuFileS1
            // 
            this._menuFileS1.Name = "_menuFileS1";
            this._menuFileS1.Size = new System.Drawing.Size(97, 6);
            // 
            // _menuFileExit
            // 
            this._menuFileExit.Name = "_menuFileExit";
            this._menuFileExit.Size = new System.Drawing.Size(100, 22);
            this._menuFileExit.Text = "E&xit";
            this._menuFileExit.Click += new System.EventHandler(this.OnFileExitClick);
            // 
            // _menuWork
            // 
            this._menuWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuWorkInitialize});
            this._menuWork.Name = "_menuWork";
            this._menuWork.Size = new System.Drawing.Size(47, 20);
            this._menuWork.Text = "Work";
            // 
            // _menuWorkInitialize
            // 
            this._menuWorkInitialize.Name = "_menuWorkInitialize";
            this._menuWorkInitialize.Size = new System.Drawing.Size(152, 22);
            this._menuWorkInitialize.Text = "Initialize";
            this._menuWorkInitialize.Click += new System.EventHandler(this.OnWorkInitializeClick);
            // 
            // _menuHelp
            // 
            this._menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuHelpInfo});
            this._menuHelp.Name = "_menuHelp";
            this._menuHelp.Size = new System.Drawing.Size(44, 20);
            this._menuHelp.Text = "Help";
            // 
            // _menuHelpInfo
            // 
            this._menuHelpInfo.Name = "_menuHelpInfo";
            this._menuHelpInfo.Size = new System.Drawing.Size(95, 22);
            this._menuHelpInfo.Text = "Info";
            this._menuHelpInfo.Click += new System.EventHandler(this.OnHelpInfoClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSomeMenuHereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 26);
            // 
            // addSomeMenuHereToolStripMenuItem
            // 
            this.addSomeMenuHereToolStripMenuItem.Name = "addSomeMenuHereToolStripMenuItem";
            this.addSomeMenuHereToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addSomeMenuHereToolStripMenuItem.Text = "Add some menu here";
            // 
            // DockTest
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this._docker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DockTest";
            this.Text = "Test form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            Form form1 = CreateTestForm(new Guid("a6402b80-2ebd-4fd3-8930-024a6201d001"));
            Form form2 = CreateTestForm(new Guid("096b52a7-5f4b-44ee-ab77-9830ec717002"));
            Form form3 = CreateTestForm(new Guid("3d8466c1-e406-4e47-b744-6915afe6e003"));
            Form form4 = CreateTestForm(new Guid("1a957c12-df87-4a63-b8a4-ed485a203004"));
            Form form5 = CreateTestForm(new Guid("0a3f4468-080b-404e-b012-997b93ed2005"));
            Form form6 = CreateTestForm(new Guid("1da6e328-d158-47de-a4ea-14172c287006"));
            Form form7 = CreateTestForm(new Guid("fe4d6143-1934-4df3-9fca-be8ddfe19007"));

            DockableFormInfo info1 = _docker.Add(form1, zAllowedDock.All, new Guid("a6402b80-2ebd-4fd3-8930-024a6201d001"));
            DockableFormInfo info2 = _docker.Add(form2, zAllowedDock.All, new Guid("096b52a7-5f4b-44ee-ab77-9830ec717002"));
            DockableFormInfo info3 = _docker.Add(form3, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e003"));
            DockableFormInfo info4 = _docker.Add(form4, zAllowedDock.All, new Guid("1a957c12-df87-4a63-b8a4-ed485a203004"));
            DockableFormInfo info5 = _docker.Add(form5, zAllowedDock.Top | zAllowedDock.Bottom, new Guid("0a3f4468-080b-404e-b012-997b93ed2005"));
            DockableFormInfo info6 = _docker.Add(form6, zAllowedDock.Vertically, new Guid("1da6e328-d158-47de-a4ea-14172c287006"));
            DockableFormInfo info7 = _docker.Add(form7, zAllowedDock.All, new Guid("fe4d6143-1934-4df3-9fca-be8ddfe19007"));

            _docker.DockForm(info5, DockStyle.Top, zDockMode.Outer);
            _docker.DockForm(info6, DockStyle.Bottom, zDockMode.Outer);

            _docker.DockForm(info1, DockStyle.Left, zDockMode.Outer);
            _docker.DockForm(info2, info1, DockStyle.Bottom, zDockMode.Inner);

            _docker.DockForm(info3, DockStyle.Left, zDockMode.Inner);
            _docker.DockForm(info4, DockStyle.Left, zDockMode.Outer);
        }

        private static Dictionary<string, CreateFormProc> map = new Dictionary<string, CreateFormProc>
        {
          { "F13021DF-AD89-473F-BDFC-B52B447D6094", () => { return CreateTestForm(200, 100, 150, 450, Color.LemonChiffon, "Form 1"); } },
        };
        private static Form CreateTestForm(int left, int top, int width, int height, Color backColor, string caption)
        {
            Form form = new Form();
            form.Bounds = new Rectangle(left, top, width, height);
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            TextBox text = new TextBox();
            text.Multiline = true;
            text.Parent = form;
            text.Dock = DockStyle.Fill;
            text.BackColor = backColor;
            form.Text = caption;
            form.TopLevel = false;

            return form;
        }

      /// <summary>
      /// Create test form
      /// </summary>
      /// <param name="identifier">form identifier</param>
      /// <returns>test form</returns>
        private static Form CreateTestForm(Guid identifier)
      {
         if (identifier == new Guid("a6402b80-2ebd-4fd3-8930-024a6201d001"))
         {
            return CreateTestForm(200, 100, 150, 450, Color.LemonChiffon, "Form 1");
         }
         else if (identifier == new Guid("096b52a7-5f4b-44ee-ab77-9830ec717002"))
         {
            return CreateTestForm(700, 100, 150, 450, Color.LightBlue, "Form 2");
         }
         else if (identifier == new Guid("3d8466c1-e406-4e47-b744-6915afe6e003"))
         {
            PictureForm result   = new PictureForm();
            result.Bounds        = new Rectangle(700, 100, 200, 450);
            result.Text          = "Form 3";
            return result;
         }
         else if (identifier == new Guid("1a957c12-df87-4a63-b8a4-ed485a203004"))
         {
            AnimatedForm result  = new AnimatedForm();
            result.Bounds        = new Rectangle(700, 100, 150, 450);
            result.Text          = "Form 4";
            return result;
         }
         else if (identifier == new Guid("0a3f4468-080b-404e-b012-997b93ed2005"))
         {
            return CreateTestForm(700, 100, 200, 150, Color.LightBlue, "Form 5 - [close disabled]");
         }
         else if (identifier == new Guid("1da6e328-d158-47de-a4ea-14172c287006"))
         {
            return CreateTestForm(700, 100, 200, 150, Color.LightBlue, "Form 6");
         }
         else if (identifier == new Guid("fe4d6143-1934-4df3-9fca-be8ddfe19007"))
         {
            return CreateTestForm(700, 100, 300, 450, Color.LightGreen, "Form 7");
         }

         throw new InvalidOperationException();
      }

      #endregion Private section
   }
}
