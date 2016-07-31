<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoal
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
    Me.MetroRadioButtonNormal = New MetroFramework.Controls.MetroRadioButton()
    Me.MetroRadioButtonOwnGoal = New MetroFramework.Controls.MetroRadioButton()
    Me.MetroRadioButtonPenalty = New MetroFramework.Controls.MetroRadioButton()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.NumericUpDownSeconds = New System.Windows.Forms.NumericUpDown()
    Me.NumericUpDownMinutes = New System.Windows.Forms.NumericUpDown()
    Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
    Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
    Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
    Me.MetroComboBoxPlayer = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    CType(Me.NumericUpDownSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'MetroRadioButtonNormal
    '
    Me.MetroRadioButtonNormal.AutoSize = True
    Me.MetroRadioButtonNormal.FontSize = MetroFramework.MetroCheckBoxSize.Tall
    Me.MetroRadioButtonNormal.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
    Me.MetroRadioButtonNormal.Location = New System.Drawing.Point(3, 33)
    Me.MetroRadioButtonNormal.Name = "MetroRadioButtonNormal"
    Me.MetroRadioButtonNormal.Size = New System.Drawing.Size(67, 25)
    Me.MetroRadioButtonNormal.TabIndex = 0
    Me.MetroRadioButtonNormal.Text = "Goal"
    Me.MetroRadioButtonNormal.UseSelectable = True
    '
    'MetroRadioButtonOwnGoal
    '
    Me.MetroRadioButtonOwnGoal.AutoSize = True
    Me.MetroRadioButtonOwnGoal.FontSize = MetroFramework.MetroCheckBoxSize.Tall
    Me.MetroRadioButtonOwnGoal.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
    Me.MetroRadioButtonOwnGoal.Location = New System.Drawing.Point(3, 70)
    Me.MetroRadioButtonOwnGoal.Name = "MetroRadioButtonOwnGoal"
    Me.MetroRadioButtonOwnGoal.Size = New System.Drawing.Size(109, 25)
    Me.MetroRadioButtonOwnGoal.TabIndex = 1
    Me.MetroRadioButtonOwnGoal.Text = "Own goal"
    Me.MetroRadioButtonOwnGoal.UseSelectable = True
    '
    'MetroRadioButtonPenalty
    '
    Me.MetroRadioButtonPenalty.AutoSize = True
    Me.MetroRadioButtonPenalty.FontSize = MetroFramework.MetroCheckBoxSize.Tall
    Me.MetroRadioButtonPenalty.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
    Me.MetroRadioButtonPenalty.Location = New System.Drawing.Point(3, 107)
    Me.MetroRadioButtonPenalty.Name = "MetroRadioButtonPenalty"
    Me.MetroRadioButtonPenalty.Size = New System.Drawing.Size(92, 25)
    Me.MetroRadioButtonPenalty.TabIndex = 2
    Me.MetroRadioButtonPenalty.Text = "Penalty"
    Me.MetroRadioButtonPenalty.UseSelectable = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroRadioButtonNormal, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroRadioButtonPenalty, 0, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroRadioButtonOwnGoal, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroTile1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroTile2, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroTile3, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroComboBoxPlayer, 1, 1)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 5
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(643, 165)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 1
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(523, 30)
    Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(120, 37)
    Me.TableLayoutPanel3.TabIndex = 7
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel4.ColumnCount = 2
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDownSeconds, 1, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDownMinutes, 0, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(114, 31)
    Me.TableLayoutPanel4.TabIndex = 2
    '
    'NumericUpDownSeconds
    '
    Me.NumericUpDownSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownSeconds.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownSeconds.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownSeconds.Location = New System.Drawing.Point(60, 4)
    Me.NumericUpDownSeconds.Name = "NumericUpDownSeconds"
    Me.NumericUpDownSeconds.Size = New System.Drawing.Size(50, 25)
    Me.NumericUpDownSeconds.TabIndex = 1
    '
    'NumericUpDownMinutes
    '
    Me.NumericUpDownMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownMinutes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownMinutes.Location = New System.Drawing.Point(4, 4)
    Me.NumericUpDownMinutes.Name = "NumericUpDownMinutes"
    Me.NumericUpDownMinutes.Size = New System.Drawing.Size(49, 25)
    Me.NumericUpDownMinutes.TabIndex = 0
    '
    'MetroTile1
    '
    Me.MetroTile1.ActiveControl = Nothing
    Me.MetroTile1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTile1.Location = New System.Drawing.Point(3, 3)
    Me.MetroTile1.Name = "MetroTile1"
    Me.MetroTile1.Size = New System.Drawing.Size(114, 24)
    Me.MetroTile1.TabIndex = 3
    Me.MetroTile1.Text = "Type of goal"
    Me.MetroTile1.UseSelectable = True
    '
    'MetroTile2
    '
    Me.MetroTile2.ActiveControl = Nothing
    Me.MetroTile2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTile2.Location = New System.Drawing.Point(123, 3)
    Me.MetroTile2.Name = "MetroTile2"
    Me.MetroTile2.Size = New System.Drawing.Size(397, 24)
    Me.MetroTile2.TabIndex = 4
    Me.MetroTile2.Text = "Scorer"
    Me.MetroTile2.UseSelectable = True
    '
    'MetroTile3
    '
    Me.MetroTile3.ActiveControl = Nothing
    Me.MetroTile3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTile3.Location = New System.Drawing.Point(526, 3)
    Me.MetroTile3.Name = "MetroTile3"
    Me.MetroTile3.Size = New System.Drawing.Size(114, 24)
    Me.MetroTile3.TabIndex = 5
    Me.MetroTile3.Text = "Time"
    Me.MetroTile3.UseSelectable = True
    '
    'MetroComboBoxPlayer
    '
    Me.MetroComboBoxPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.MetroComboBoxPlayer.FormattingEnabled = True
    Me.MetroComboBoxPlayer.ItemHeight = 17
    Me.MetroComboBoxPlayer.Location = New System.Drawing.Point(123, 33)
    Me.MetroComboBoxPlayer.Name = "MetroComboBoxPlayer"
    Me.MetroComboBoxPlayer.Size = New System.Drawing.Size(397, 25)
    Me.MetroComboBoxPlayer.TabIndex = 6
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(509, 183)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 40)
    Me.TableLayoutPanel2.TabIndex = 4
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 34)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 34)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'frmGoal
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(667, 235)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmGoal"
    Me.Text = "Goal"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel4.ResumeLayout(False)
    CType(Me.NumericUpDownSeconds, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents MetroRadioButtonNormal As MetroFramework.Controls.MetroRadioButton
  Friend WithEvents MetroRadioButtonOwnGoal As MetroFramework.Controls.MetroRadioButton
  Friend WithEvents MetroRadioButtonPenalty As MetroFramework.Controls.MetroRadioButton
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroComboBoxPlayer As System.Windows.Forms.ComboBox
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
  Friend WithEvents NumericUpDownSeconds As NumericUpDown
  Friend WithEvents NumericUpDownMinutes As NumericUpDown
End Class
