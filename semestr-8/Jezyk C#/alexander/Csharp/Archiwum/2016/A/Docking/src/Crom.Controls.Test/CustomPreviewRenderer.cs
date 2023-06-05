using System;

using Crom.Controls.Docking;
using System.Drawing;
using System.Windows.Forms;

namespace Crom.Controls.Test
{
   /// <summary>
   /// Custom preview renderer
   /// </summary>
   public class CustomPreviewRenderer : PreviewRenderer
   {
      #region Fields

      private Form _oldForm = null;

      #endregion Fields

      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public CustomPreviewRenderer()
      {
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
         FormWithPreview form = SelectedForm as FormWithPreview;
         if (form != null)
         {
            form.DrawPreview(bounds, graphics);
         }
         else
         {
            base.DrawPreview(bounds, graphics);
         }
      }

      /// <summary>
      /// Clone current renderer
      /// </summary>
      /// <returns>cloned renderer</returns>
      public override PreviewRenderer Clone()
      {
         return new CustomPreviewRenderer();
      }

      #endregion Public section

      #region Protected section

      /// <summary>
      /// Occurs when selected form was changed
      /// </summary>
      protected override void OnSelectedFormChanged()
      {
         if (_oldForm != null)
         {
            _oldForm.Invalidated -= OnFormInvalidated;
         }

         _oldForm = SelectedForm;

         if (_oldForm != null)
         {
            _oldForm.Invalidated += OnFormInvalidated;
         }

         base.OnSelectedFormChanged();
      }

      #endregion Protected section

      #region Private section

      /// <summary>
      /// Occurs when selected form was invalidated
      /// </summary>
      /// <param name="sender">sender of the event</param>
      /// <param name="e">event argument</param>
      private void OnFormInvalidated(object sender, InvalidateEventArgs e)
      {
         Invalidate();
      }

      #endregion Private section
   }
}
