<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoadScenes
  Inherits MetroFramework.Forms.MetroForm

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
    Me.MetroLabelScene = New System.Windows.Forms.Label()
    Me.MetroCheckBoxCloseWhenDone = New MetroFramework.Controls.MetroCheckBox()
    Me.SuspendLayout()
    '
    'MetroLabelScene
    '
    Me.MetroLabelScene.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MetroLabelScene.Location = New System.Drawing.Point(23, 60)
    Me.MetroLabelScene.Name = "MetroLabelScene"
    Me.MetroLabelScene.Size = New System.Drawing.Size(575, 354)
    Me.MetroLabelScene.TabIndex = 0
    Me.MetroLabelScene.Text = "Scene..."
    '
    'MetroCheckBoxCloseWhenDone
    '
    Me.MetroCheckBoxCloseWhenDone.AutoSize = True
    Me.MetroCheckBoxCloseWhenDone.Checked = True
    Me.MetroCheckBoxCloseWhenDone.CheckState = System.Windows.Forms.CheckState.Checked
    Me.MetroCheckBoxCloseWhenDone.Location = New System.Drawing.Point(23, 417)
    Me.MetroCheckBoxCloseWhenDone.Name = "MetroCheckBoxCloseWhenDone"
    Me.MetroCheckBoxCloseWhenDone.Size = New System.Drawing.Size(114, 15)
    Me.MetroCheckBoxCloseWhenDone.TabIndex = 1
    Me.MetroCheckBoxCloseWhenDone.Text = "Close when done"
    Me.MetroCheckBoxCloseWhenDone.FlatStyle = FlatStyle.Flat
    '
    'FormLoadScenes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(621, 455)
    Me.Controls.Add(Me.MetroCheckBoxCloseWhenDone)
    Me.Controls.Add(Me.MetroLabelScene)
    Me.Name = "FormLoadScenes"
    Me.Text = "Load scenes"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MetroLabelScene As System.Windows.Forms.Label
  Friend WithEvents MetroCheckBoxCloseWhenDone As MetroFramework.Controls.MetroCheckBox
End Class
