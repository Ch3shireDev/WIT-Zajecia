using System;
using System.Drawing;
using System.Windows.Forms;

namespace Crom.Controls.Test
{
   /// <summary>
   /// Implementation of a form with preview
   /// </summary>
   public class FormWithPreview : Form
   {
      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public FormWithPreview()
      {
         InitializeComponent();
         TopLevel = false;
      }

      #endregion Instance

      #region Public section

      /// <summary>
      /// Draw preview
      /// </summary>
      /// <param name="bounds">bounds</param>
      /// <param name="graphics">graphics</param>
      public virtual void DrawPreview(Rectangle bounds, Graphics graphics)
      {
         graphics.DrawRectangle(Pens.DarkGray, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
      }

      #endregion Public section

      #region Private section

      private void InitializeComponent()
      {
         this.SuspendLayout();
         // 
         // FormWithPreview
         // 
         this.ClientSize = new System.Drawing.Size(292, 266);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "FormWithPreview";
         this.ResumeLayout(false);

      }

      #endregion Private section
   }
}
