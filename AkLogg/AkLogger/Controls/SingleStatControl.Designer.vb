<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleStatControl
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.ButtonStat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'ButtonStat
    '
    Me.ButtonStat.BackColor = System.Drawing.Color.White
    Me.ButtonStat.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonStat.Location = New System.Drawing.Point(0, 0)
    Me.ButtonStat.Name = "ButtonStat"
    Me.ButtonStat.Size = New System.Drawing.Size(150, 40)
    Me.ButtonStat.TabIndex = 1
    Me.ButtonStat.Text = "Button1"
    Me.ButtonStat.UseVisualStyleBackColor = False
    '
    'SingleStatControl
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.Controls.Add(Me.ButtonStat)
    Me.Name = "SingleStatControl"
    Me.Size = New System.Drawing.Size(150, 40)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ButtonStat As Button
End Class
