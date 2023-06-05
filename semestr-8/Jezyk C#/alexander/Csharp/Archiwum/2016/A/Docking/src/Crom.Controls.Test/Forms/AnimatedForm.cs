using System;
using System.Drawing;
using System.Windows.Forms;

namespace Crom.Controls.Test
{
   /// <summary>
   /// Animated form
   /// </summary>
   public class AnimatedForm : FormWithPreview
   {
      #region Fields

      private System.Windows.Forms.Timer _animationTimer;
      private System.ComponentModel.IContainer components;
      private bool _firstGreen = true;

      #endregion Fields

      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public AnimatedForm()
      {
         InitializeComponent();

         SetStyle(ControlStyles.AllPaintingInWmPaint,  true);
         SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
         SetStyle(ControlStyles.ResizeRedraw,          true);
         SetStyle(ControlStyles.Selectable,            true);
         SetStyle(ControlStyles.UserPaint,             true);
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
         PaintForm(bounds, graphics);
         graphics.DrawRectangle(Pens.DarkGray, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
      }

      #endregion Public section

      #region Private section

      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this._animationTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // _animationTimer
         // 
         this._animationTimer.Enabled = true;
         this._animationTimer.Interval = 400;
         this._animationTimer.Tick += new System.EventHandler(this.OnAnimatedTimerTick);
         // 
         // AnimatedForm
         // 
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.ClientSize = new System.Drawing.Size(292, 266);
         this.DoubleBuffered = true;
         this.Name = "AnimatedForm";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
         this.ResumeLayout(false);

      }

      /// <summary>
      /// Event received when animated timer tick occurs
      /// </summary>
      /// <param name="sender">sender of the event</param>
      /// <param name="e">event argument</param>
      private void OnAnimatedTimerTick(object sender, EventArgs e)
      {
        //_firstGreen = _firstGreen == false;
        _firstGreen ^= true;

         Invalidate();
      }

      /// <summary>
      /// Occurs when paint is required
      /// </summary>
      /// <param name="sender">sender of the event</param>
      /// <param name="e">event argument</param>
      private void OnPaint(object sender, PaintEventArgs e)
      {
         PaintForm(ClientRectangle, e.Graphics);
      }

      /// <summary>
      /// Paint the form
      /// </summary>
      /// <param name="bounds">bounds</param>
      /// <param name="graphics">graphics</param>
      private void PaintForm(Rectangle bounds, Graphics graphics)
      {
         int diameter = (int)Math.Min((double)bounds.Width / 5.0, (double)bounds.Height / 3.0);
         if (diameter <= 0)
         {
            return;
         }

         int top     = bounds.Top + diameter;
         int left1   = bounds.Left + diameter;
         int left2   = bounds.Right - 2 * diameter;

         Rectangle boundsCircle1 = new Rectangle(left1, top, diameter, diameter);
         Rectangle boundsCircle2 = new Rectangle(left2, top, diameter, diameter);

         Brush brush1 = Brushes.Green;
         Brush brush2 = Brushes.Blue;

         if (_firstGreen == false)
         {
            brush1 = Brushes.Blue;
            brush2 = Brushes.Green;
         }

         graphics.FillEllipse(Brushes.Yellow, boundsCircle1);
         boundsCircle1.Inflate(1, 1);
         graphics.FillEllipse(brush1, boundsCircle1);

         graphics.FillEllipse(Brushes.Yellow, boundsCircle2);
         boundsCircle2.Inflate(1, 1);
         graphics.FillEllipse(brush2, boundsCircle2);
      }

      #endregion Private section
   }
}
