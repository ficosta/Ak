<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOvewriteClock
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.TextBoxSeconds = New System.Windows.Forms.TextBox()
    Me.TextBoxMinutes = New System.Windows.Forms.TextBox()
    Me.MetroLabelTime = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(297, 76)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(187, 38)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(3, 4)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(87, 30)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(96, 4)
    Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(88, 30)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabelTime, 0, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(19, 16)
    Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(465, 38)
    Me.TableLayoutPanel3.TabIndex = 3
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSeconds, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.TextBoxMinutes, 0, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(235, 4)
    Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(226, 30)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'TextBoxSeconds
    '
    Me.TextBoxSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxSeconds.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxSeconds.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSeconds.Location = New System.Drawing.Point(116, 0)
    Me.TextBoxSeconds.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.TextBoxSeconds.Name = "TextBoxSeconds"
    Me.TextBoxSeconds.Size = New System.Drawing.Size(107, 29)
    Me.TextBoxSeconds.TabIndex = 6
    Me.TextBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'TextBoxMinutes
    '
    Me.TextBoxMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxMinutes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxMinutes.Location = New System.Drawing.Point(3, 0)
    Me.TextBoxMinutes.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.TextBoxMinutes.Name = "TextBoxMinutes"
    Me.TextBoxMinutes.Size = New System.Drawing.Size(107, 29)
    Me.TextBoxMinutes.TabIndex = 5
    Me.TextBoxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'MetroLabelTime
    '
    Me.MetroLabelTime.AutoSize = True
    Me.MetroLabelTime.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelTime.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelTime.Name = "MetroLabelTime"
    Me.MetroLabelTime.Size = New System.Drawing.Size(226, 38)
    Me.MetroLabelTime.TabIndex = 3
    Me.MetroLabelTime.Text = "New clock time"
    Me.MetroLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'FormOvewriteClock
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(519, 127)
    Me.Controls.Add(Me.TableLayoutPanel3)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormOvewriteClock"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Overwrite clock"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents MetroLabelTime As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents TextBoxSeconds As TextBox
  Friend WithEvents TextBoxMinutes As TextBox
End Class
