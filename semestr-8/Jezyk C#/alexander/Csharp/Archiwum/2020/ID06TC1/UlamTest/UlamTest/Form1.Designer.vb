<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.PnlScroll = New System.Windows.Forms.Panel()
        Me.PbUlam = New System.Windows.Forms.PictureBox()
        Me.EdCount = New System.Windows.Forms.TextBox()
        Me.BtnDraw = New System.Windows.Forms.Button()
        Me.PnlHeader.SuspendLayout()
        Me.PnlScroll.SuspendLayout()
        CType(Me.PbUlam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.Controls.Add(Me.BtnDraw)
        Me.PnlHeader.Controls.Add(Me.EdCount)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(783, 44)
        Me.PnlHeader.TabIndex = 0
        '
        'PnlScroll
        '
        Me.PnlScroll.AutoScroll = True
        Me.PnlScroll.Controls.Add(Me.PbUlam)
        Me.PnlScroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlScroll.Location = New System.Drawing.Point(0, 44)
        Me.PnlScroll.Name = "PnlScroll"
        Me.PnlScroll.Padding = New System.Windows.Forms.Padding(4)
        Me.PnlScroll.Size = New System.Drawing.Size(783, 459)
        Me.PnlScroll.TabIndex = 1
        '
        'PbUlam
        '
        Me.PbUlam.Location = New System.Drawing.Point(4, 4)
        Me.PbUlam.Name = "PbUlam"
        Me.PbUlam.Size = New System.Drawing.Size(100, 50)
        Me.PbUlam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbUlam.TabIndex = 0
        Me.PbUlam.TabStop = False
        '
        'EdCount
        '
        Me.EdCount.Location = New System.Drawing.Point(12, 12)
        Me.EdCount.Name = "EdCount"
        Me.EdCount.Size = New System.Drawing.Size(92, 20)
        Me.EdCount.TabIndex = 0
        '
        'BtnDraw
        '
        Me.BtnDraw.Location = New System.Drawing.Point(696, 12)
        Me.BtnDraw.Name = "BtnDraw"
        Me.BtnDraw.Size = New System.Drawing.Size(75, 23)
        Me.BtnDraw.TabIndex = 1
        Me.BtnDraw.Text = "Draw"
        Me.BtnDraw.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 503)
        Me.Controls.Add(Me.PnlScroll)
        Me.Controls.Add(Me.PnlHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlScroll.ResumeLayout(False)
        Me.PnlScroll.PerformLayout()
        CType(Me.PbUlam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnDraw As System.Windows.Forms.Button
    Friend WithEvents EdCount As System.Windows.Forms.TextBox
    Friend WithEvents PnlScroll As System.Windows.Forms.Panel
    Friend WithEvents PbUlam As System.Windows.Forms.PictureBox

End Class
