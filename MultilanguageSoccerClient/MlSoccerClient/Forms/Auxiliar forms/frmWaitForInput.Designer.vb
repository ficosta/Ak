<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWaitForInput
  Inherits System.Windows.Forms.Form

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
    Me.LabelPrompt = New System.Windows.Forms.Label()
    Me.MetroButtonOK = New System.Windows.Forms.Button()
    Me.ButtonCancel = New System.Windows.Forms.Button()
    Me.LabelTitle = New System.Windows.Forms.Label()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'LabelPrompt
    '
    Me.LabelPrompt.AutoSize = True
    Me.TableLayoutPanel3.SetColumnSpan(Me.LabelPrompt, 3)
    Me.LabelPrompt.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelPrompt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelPrompt.Location = New System.Drawing.Point(10, 0)
    Me.LabelPrompt.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
    Me.LabelPrompt.Name = "LabelPrompt"
    Me.LabelPrompt.Size = New System.Drawing.Size(422, 57)
    Me.LabelPrompt.TabIndex = 2
    Me.LabelPrompt.Text = "This is the message"
    Me.LabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroButtonOK
    '
    Me.MetroButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonOK.Location = New System.Drawing.Point(285, 61)
    Me.MetroButtonOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroButtonOK.Name = "MetroButtonOK"
    Me.MetroButtonOK.Size = New System.Drawing.Size(74, 31)
    Me.MetroButtonOK.TabIndex = 3
    Me.MetroButtonOK.Text = "OK"
    Me.MetroButtonOK.UseVisualStyleBackColor = True
    '
    'ButtonCancel
    '
    Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonCancel.Location = New System.Drawing.Point(365, 61)
    Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonCancel.Name = "ButtonCancel"
    Me.ButtonCancel.Size = New System.Drawing.Size(74, 31)
    Me.ButtonCancel.TabIndex = 4
    Me.ButtonCancel.Text = "Cancel"
    Me.ButtonCancel.UseVisualStyleBackColor = True
    '
    'LabelTitle
    '
    Me.LabelTitle.AutoSize = True
    Me.LabelTitle.BackColor = System.Drawing.Color.Gainsboro
    Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelTitle.Location = New System.Drawing.Point(0, 0)
    Me.LabelTitle.Margin = New System.Windows.Forms.Padding(0)
    Me.LabelTitle.Name = "LabelTitle"
    Me.LabelTitle.Size = New System.Drawing.Size(448, 30)
    Me.LabelTitle.TabIndex = 5
    Me.LabelTitle.Text = "Caption"
    Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.TableLayoutPanel3, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelTitle, 0, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(448, 133)
    Me.TableLayoutPanelAll.TabIndex = 1
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel3.ColumnCount = 3
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.ButtonCancel, 2, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroButtonOK, 1, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelPrompt, 0, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 2
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(442, 97)
    Me.TableLayoutPanel3.TabIndex = 2
    '
    'frmWaitForInput
    '
    Me.AcceptButton = Me.MetroButtonOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Gainsboro
    Me.ClientSize = New System.Drawing.Size(448, 133)
    Me.ControlBox = False
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmWaitForInput"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Wait"
    Me.TopMost = True
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelPrompt As System.Windows.Forms.Label
  Friend WithEvents MetroButtonOK As Button
  Friend WithEvents ButtonCancel As Button
  Friend WithEvents LabelTitle As Label
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
End Class
