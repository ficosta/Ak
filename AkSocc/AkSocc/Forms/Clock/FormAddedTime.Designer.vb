<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddedTime
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
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.NumericUpDownMinutes = New System.Windows.Forms.NumericUpDown()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelTime = New MetroFramework.Controls.MetroLabel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(262, 143)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(160, 29)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.UseSelectable = True
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(83, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel2.ColumnCount = 1
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDownMinutes, 0, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(202, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(194, 32)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'NumericUpDownMinutes
    '
    Me.NumericUpDownMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownMinutes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownMinutes.Location = New System.Drawing.Point(4, 4)
    Me.NumericUpDownMinutes.Name = "NumericUpDownMinutes"
    Me.NumericUpDownMinutes.Size = New System.Drawing.Size(186, 25)
    Me.NumericUpDownMinutes.TabIndex = 1
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabelTime, 0, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(23, 79)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(399, 39)
    Me.TableLayoutPanel3.TabIndex = 3
    '
    'MetroLabelTime
    '
    Me.MetroLabelTime.AutoSize = True
    Me.MetroLabelTime.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelTime.FontSize = MetroFramework.MetroLabelSize.Tall
    Me.MetroLabelTime.FontWeight = MetroFramework.MetroLabelWeight.Regular
    Me.MetroLabelTime.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelTime.Name = "MetroLabelTime"
    Me.MetroLabelTime.Size = New System.Drawing.Size(193, 39)
    Me.MetroLabelTime.TabIndex = 3
    Me.MetroLabelTime.Text = "New added time"
    Me.MetroLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'FormAddedTime
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(445, 195)
    Me.Controls.Add(Me.TableLayoutPanel3)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormAddedTime"
    Me.Resizable = False
    Me.Text = "Added time"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents NumericUpDownMinutes As NumericUpDown
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents MetroLabelTime As MetroFramework.Controls.MetroLabel
End Class
