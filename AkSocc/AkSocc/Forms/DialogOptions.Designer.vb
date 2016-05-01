<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogOptions
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
    Me.CheckBoxShowOptionsOnStartup = New System.Windows.Forms.CheckBox()
    Me.TabControlOptions = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelHost = New System.Windows.Forms.Label()
    Me.TextBoxVizrtHost = New System.Windows.Forms.TextBox()
    Me.LabelREPort = New System.Windows.Forms.Label()
    Me.NumericUpDownPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelPreviewPort = New System.Windows.Forms.Label()
    Me.NumericUpDownPreviewPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelSceneVersion = New System.Windows.Forms.Label()
    Me.ComboBoxSceneVersion = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TabControlOptions.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownPreviewPort, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxShowOptionsOnStartup, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 274)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(411, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(257, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(337, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'CheckBoxShowOptionsOnStartup
    '
    Me.CheckBoxShowOptionsOnStartup.AutoSize = True
    Me.CheckBoxShowOptionsOnStartup.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxShowOptionsOnStartup.Location = New System.Drawing.Point(3, 3)
    Me.CheckBoxShowOptionsOnStartup.Name = "CheckBoxShowOptionsOnStartup"
    Me.CheckBoxShowOptionsOnStartup.Size = New System.Drawing.Size(245, 23)
    Me.CheckBoxShowOptionsOnStartup.TabIndex = 2
    Me.CheckBoxShowOptionsOnStartup.Text = "Show options on application startup"
    Me.CheckBoxShowOptionsOnStartup.UseVisualStyleBackColor = True
    '
    'TabControlOptions
    '
    Me.TabControlOptions.Controls.Add(Me.TabPage1)
    Me.TabControlOptions.Controls.Add(Me.TabPage2)
    Me.TabControlOptions.Location = New System.Drawing.Point(12, 12)
    Me.TabControlOptions.Name = "TabControlOptions"
    Me.TabControlOptions.SelectedIndex = 0
    Me.TabControlOptions.Size = New System.Drawing.Size(411, 256)
    Me.TabControlOptions.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(403, 230)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "General options"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(403, 230)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Vizrt options"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDownPreviewPort, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelHost, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.TextBoxVizrtHost, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelREPort, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDownPort, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelPreviewPort, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelSceneVersion, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxSceneVersion, 1, 3)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 7
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(397, 224)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'LabelHost
    '
    Me.LabelHost.AutoSize = True
    Me.LabelHost.Location = New System.Drawing.Point(3, 0)
    Me.LabelHost.Name = "LabelHost"
    Me.LabelHost.Size = New System.Drawing.Size(50, 13)
    Me.LabelHost.TabIndex = 0
    Me.LabelHost.Text = "Vizrt host"
    '
    'TextBoxVizrtHost
    '
    Me.TextBoxVizrtHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxVizrtHost.Location = New System.Drawing.Point(103, 3)
    Me.TextBoxVizrtHost.Name = "TextBoxVizrtHost"
    Me.TextBoxVizrtHost.Size = New System.Drawing.Size(291, 20)
    Me.TextBoxVizrtHost.TabIndex = 1
    '
    'LabelREPort
    '
    Me.LabelREPort.AutoSize = True
    Me.LabelREPort.Location = New System.Drawing.Point(3, 30)
    Me.LabelREPort.Name = "LabelREPort"
    Me.LabelREPort.Size = New System.Drawing.Size(43, 13)
    Me.LabelREPort.TabIndex = 2
    Me.LabelREPort.Text = "RE port"
    '
    'NumericUpDownPort
    '
    Me.NumericUpDownPort.Location = New System.Drawing.Point(103, 33)
    Me.NumericUpDownPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPort.Name = "NumericUpDownPort"
    Me.NumericUpDownPort.Size = New System.Drawing.Size(68, 20)
    Me.NumericUpDownPort.TabIndex = 3
    '
    'LabelPreviewPort
    '
    Me.LabelPreviewPort.AutoSize = True
    Me.LabelPreviewPort.Location = New System.Drawing.Point(3, 60)
    Me.LabelPreviewPort.Name = "LabelPreviewPort"
    Me.LabelPreviewPort.Size = New System.Drawing.Size(66, 13)
    Me.LabelPreviewPort.TabIndex = 4
    Me.LabelPreviewPort.Text = "Preview port"
    '
    'NumericUpDownPreviewPort
    '
    Me.NumericUpDownPreviewPort.Location = New System.Drawing.Point(103, 63)
    Me.NumericUpDownPreviewPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPreviewPort.Name = "NumericUpDownPreviewPort"
    Me.NumericUpDownPreviewPort.Size = New System.Drawing.Size(68, 20)
    Me.NumericUpDownPreviewPort.TabIndex = 5
    '
    'LabelSceneVersion
    '
    Me.LabelSceneVersion.AutoSize = True
    Me.LabelSceneVersion.Location = New System.Drawing.Point(3, 90)
    Me.LabelSceneVersion.Name = "LabelSceneVersion"
    Me.LabelSceneVersion.Size = New System.Drawing.Size(75, 13)
    Me.LabelSceneVersion.TabIndex = 6
    Me.LabelSceneVersion.Text = "Scene version"
    '
    'ComboBoxSceneVersion
    '
    Me.ComboBoxSceneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSceneVersion.FormattingEnabled = True
    Me.ComboBoxSceneVersion.Location = New System.Drawing.Point(103, 93)
    Me.ComboBoxSceneVersion.Name = "ComboBoxSceneVersion"
    Me.ComboBoxSceneVersion.Size = New System.Drawing.Size(192, 21)
    Me.ComboBoxSceneVersion.TabIndex = 7
    '
    'DialogOptions
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(435, 315)
    Me.Controls.Add(Me.TabControlOptions)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogOptions"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "DialogOptions"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TabControlOptions.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownPreviewPort, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents CheckBoxShowOptionsOnStartup As CheckBox
  Friend WithEvents TabControlOptions As TabControl
  Friend WithEvents TabPage1 As TabPage
  Friend WithEvents TabPage2 As TabPage
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents LabelHost As Label
  Friend WithEvents TextBoxVizrtHost As TextBox
  Friend WithEvents LabelREPort As Label
  Friend WithEvents NumericUpDownPort As NumericUpDown
  Friend WithEvents LabelPreviewPort As Label
  Friend WithEvents NumericUpDownPreviewPort As NumericUpDown
  Friend WithEvents LabelSceneVersion As Label
  Friend WithEvents ComboBoxSceneVersion As ComboBox
End Class
