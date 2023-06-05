using System;
using System.Drawing;

namespace Crom.Controls.Test
{
   /// <summary>
   /// Picture form
   /// </summary>
   public class PictureForm : FormWithPreview
   {
      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public PictureForm()
      {
         InitializeComponent();
      }

      #endregion Instance

      #region Public section

      /// <summary>
      /// Draw preview
      /// </summary>
      /// <param name="bounds">bounds</param>
      /// <param name="graphics">graphics</param>
      public override void DrawPreview(Rectangle bounds, Graphics graphics)
      {
         if (BackgroundImage == null)
         {
            base.DrawPreview(bounds, graphics);
            return;
         }

         if (BackgroundImage.Width == 0 || BackgroundImage.Height == 0)
         {
            base.DrawPreview(bounds, graphics);
            return;
         }

         double previewRatio  = (double)bounds.Width / (double)bounds.Height;
         double imageRatio    = (double)BackgroundImage.Width / (double)BackgroundImage.Height;

         int width  = 0;
         int height = 0;

         if (previewRatio < imageRatio)
         {
            width    = Math.Min(bounds.Width, BackgroundImage.Width);
            height   = (int)(width / imageRatio);
         }
         else
         {
            height   = Math.Min(bounds.Height, BackgroundImage.Height);
            width    = (int)(height * imageRatio);
         }

         int left = bounds.Left + (bounds.Width - width) / 2;
         int top  = bounds.Top  + (bounds.Height - height) / 2;

         graphics.DrawImage(BackgroundImage, new Rectangle(left, top, width, height));

         graphics.DrawRectangle(Pens.DarkGray, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
      }

      #endregion Public section

      #region Private section

      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
         this.SuspendLayout();
         // 
         // PictureForm
         // 
         this.BackColor = System.Drawing.Color.Black;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.ClientSize = new System.Drawing.Size(292, 266);
         this.DoubleBuffered = true;
         this.Name = "PictureForm";
         this.ResumeLayout(false);

      }

      #endregion Private section
   }
}
