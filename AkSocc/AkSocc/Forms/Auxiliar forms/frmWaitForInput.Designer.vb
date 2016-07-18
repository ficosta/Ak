<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWaitForInput
  Inherits MetroFramework.Forms.MetroForm

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonOK = New MetroFramework.Controls.MetroButton()
    Me.MetroButtonCancel = New MetroFramework.Controls.MetroButton()
    Me.MetroLabelPrompt = New MetroFramework.Controls.MetroLabel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.MetroButtonOK, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroButtonCancel, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroLabelPrompt, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 63)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(590, 139)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'MetroButtonOK
    '
    Me.MetroButtonOK.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonOK.Location = New System.Drawing.Point(353, 112)
    Me.MetroButtonOK.Name = "MetroButtonOK"
    Me.MetroButtonOK.Size = New System.Drawing.Size(114, 24)
    Me.MetroButtonOK.TabIndex = 0
    Me.MetroButtonOK.Text = "OK"
    Me.MetroButtonOK.UseSelectable = True
    '
    'MetroButtonCancel
    '
    Me.MetroButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.MetroButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonCancel.Location = New System.Drawing.Point(473, 112)
    Me.MetroButtonCancel.Name = "MetroButtonCancel"
    Me.MetroButtonCancel.Size = New System.Drawing.Size(114, 24)
    Me.MetroButtonCancel.TabIndex = 1
    Me.MetroButtonCancel.Text = "Cancel"
    Me.MetroButtonCancel.UseSelectable = True
    '
    'MetroLabelPrompt
    '
    Me.MetroLabelPrompt.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLabelPrompt, 3)
    Me.MetroLabelPrompt.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelPrompt.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelPrompt.Name = "MetroLabelPrompt"
    Me.MetroLabelPrompt.Size = New System.Drawing.Size(584, 109)
    Me.MetroLabelPrompt.TabIndex = 2
    '
    'frmWaitForInput
    '
    Me.AcceptButton = Me.MetroButtonOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.MetroButtonCancel
    Me.ClientSize = New System.Drawing.Size(636, 225)
    Me.ControlBox = False
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmWaitForInput"
    Me.Opacity = 0.75R
    Me.Text = "Wait"
    Me.TopMost = True
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroButtonOK As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroButtonCancel As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroLabelPrompt As MetroFramework.Controls.MetroLabel
End Class
