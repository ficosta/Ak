<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTime
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
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.btnOk = New System.Windows.Forms.Button()
    Me.txtMinute = New System.Windows.Forms.TextBox()
    Me.txtHour = New System.Windows.Forms.TextBox()
    Me.label2 = New System.Windows.Forms.Label()
    Me.label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(147, 157)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(120, 39)
    Me.btnCancel.TabIndex = 9
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'btnOk
    '
    Me.btnOk.Location = New System.Drawing.Point(17, 157)
    Me.btnOk.Name = "btnOk"
    Me.btnOk.Size = New System.Drawing.Size(120, 39)
    Me.btnOk.TabIndex = 8
    Me.btnOk.Text = "OK"
    Me.btnOk.UseVisualStyleBackColor = True
    '
    'txtMinute
    '
    Me.txtMinute.Location = New System.Drawing.Point(171, 109)
    Me.txtMinute.MaxLength = 2
    Me.txtMinute.Name = "txtMinute"
    Me.txtMinute.Size = New System.Drawing.Size(60, 20)
    Me.txtMinute.TabIndex = 6
    Me.txtMinute.Text = "00"
    '
    'txtHour
    '
    Me.txtHour.Location = New System.Drawing.Point(171, 67)
    Me.txtHour.MaxLength = 3
    Me.txtHour.Name = "txtHour"
    Me.txtHour.Size = New System.Drawing.Size(60, 20)
    Me.txtHour.TabIndex = 4
    Me.txtHour.Text = "00"
    '
    'label2
    '
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(45, 112)
    Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(47, 13)
    Me.label2.TabIndex = 7
    Me.label2.Text = "Second:"
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(45, 70)
    Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(42, 13)
    Me.label1.TabIndex = 5
    Me.label1.Text = "Minute:"
    '
    'frmNewTime
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 262)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOk)
    Me.Controls.Add(Me.txtMinute)
    Me.Controls.Add(Me.txtHour)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.Name = "frmNewTime"
    Me.Text = "frmNewTime"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents btnCancel As Button
  Private WithEvents btnOk As Button
  Private WithEvents txtMinute As TextBox
  Private WithEvents txtHour As TextBox
  Private WithEvents label2 As Label
  Private WithEvents label1 As Label
End Class
