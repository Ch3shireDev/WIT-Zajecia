using System;
using System.Windows.Forms;

namespace CircleCross
{
	public class InputBox : System.Windows.Forms.Form
	{
  		#region Form Inicialization 
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label lbTexto;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
		private System.ComponentModel.Container components = null;
		private InputBox()
		{
			InitializeComponent();
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtText = new System.Windows.Forms.TextBox();
			this.lbTexto = new System.Windows.Forms.Label();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// txtText
			this.txtText.Location = new System.Drawing.Point(7, 90);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(342, 20);
			this.txtText.TabIndex = 0;
			this.txtText.Text = "txtText";
			this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);

			// lbTexto
			this.lbTexto.Location = new System.Drawing.Point(10, 11);
			this.lbTexto.Name = "lbTexto";
			this.lbTexto.Size = new System.Drawing.Size(267, 63);
			this.lbTexto.TabIndex = 1;

			// btOK
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(286, 14);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(60, 23);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";

			// btCancel
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(287, 40);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(59, 23);
			this.btCancel.TabIndex = 3;
			this.btCancel.Text = "Cancel";

			// InputBox
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(357, 120);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.lbTexto);
			this.Controls.Add(this.txtText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.ResumeLayout(false);
		}
		#endregion
		#region InputBox 
		private void txtText_KeyDown(object sender,System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.DialogResult=DialogResult.OK;
				this.Close();
			}
		}
		public static DialogResult ShowInputBox(string Prompt,string Title,string Default,ref string Return)
		{
			InputBox box = new InputBox();

			box.txtText.Text=Default;
			box.lbTexto.Text=Prompt;
			box.Text=Title;
			DialogResult wDialogResult=box.ShowDialog();
			if (wDialogResult==DialogResult.OK)
				Return=box.txtText.Text;
			else
				Return="";
			return wDialogResult;
		}    
	#endregion
	}
}
