<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogOptions
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.CheckBoxShowOptionsOnStartup = New MetroFramework.Controls.MetroCheckBox()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonOtherMatchesPath = New System.Windows.Forms.Button()
    Me.MetroTextBoxOtherMatchesFilePath = New System.Windows.Forms.TextBox()
    Me.MetroLabelOtherMatches = New System.Windows.Forms.Label()
    Me.MetroLabelDataBase = New System.Windows.Forms.Label()
    Me.MetroTextBoxDefaultColorPath = New System.Windows.Forms.TextBox()
    Me.MetroTextBoxDefaultKitsPath = New System.Windows.Forms.TextBox()
    Me.MetroButtonDefaultColorsPath = New System.Windows.Forms.Button()
    Me.MetroButtonDefaultkitsPath = New System.Windows.Forms.Button()
    Me.MetroLabel3 = New System.Windows.Forms.Label()
    Me.MetroLabel4 = New System.Windows.Forms.Label()
    Me.MetroButtonDataBase = New System.Windows.Forms.Button()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelDatabase = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.NumericUpDownLogger = New System.Windows.Forms.NumericUpDown()
    Me.MetroTextBoxDataBase = New System.Windows.Forms.TextBox()
    Me.OpenFileDialogDataBase = New System.Windows.Forms.OpenFileDialog()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.FolderBrowserDialogPaths = New System.Windows.Forms.FolderBrowserDialog()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    CType(Me.NumericUpDownLogger, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxShowOptionsOnStartup, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 373)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(601, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(681, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'CheckBoxShowOptionsOnStartup
    '
    Me.CheckBoxShowOptionsOnStartup.AutoSize = True
    Me.CheckBoxShowOptionsOnStartup.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxShowOptionsOnStartup.Location = New System.Drawing.Point(3, 3)
    Me.CheckBoxShowOptionsOnStartup.Name = "CheckBoxShowOptionsOnStartup"
    Me.CheckBoxShowOptionsOnStartup.Size = New System.Drawing.Size(592, 23)
    Me.CheckBoxShowOptionsOnStartup.TabIndex = 2
    Me.CheckBoxShowOptionsOnStartup.Text = "Show options on application startup"
    Me.CheckBoxShowOptionsOnStartup.UseSelectable = True
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 3
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.MetroButtonOtherMatchesPath, 2, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroTextBoxOtherMatchesFilePath, 1, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabelOtherMatches, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabelDataBase, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroTextBoxDefaultColorPath, 1, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroTextBoxDefaultKitsPath, 1, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroButtonDefaultColorsPath, 2, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroButtonDefaultkitsPath, 2, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel3, 0, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroLabel4, 0, 3)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 7
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(759, 307)
    Me.TableLayoutPanel3.TabIndex = 2
    '
    'MetroButtonOtherMatchesPath
    '
    Me.MetroButtonOtherMatchesPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonOtherMatchesPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonOtherMatchesPath.Location = New System.Drawing.Point(727, 33)
    Me.MetroButtonOtherMatchesPath.Name = "MetroButtonOtherMatchesPath"
    Me.MetroButtonOtherMatchesPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonOtherMatchesPath.TabIndex = 5
    Me.MetroButtonOtherMatchesPath.Text = "..."
    '
    'MetroTextBoxOtherMatchesFilePath
    '
    Me.MetroTextBoxOtherMatchesFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxOtherMatchesFilePath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxOtherMatchesFilePath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxOtherMatchesFilePath.Location = New System.Drawing.Point(158, 33)
    Me.MetroTextBoxOtherMatchesFilePath.Name = "MetroTextBoxOtherMatchesFilePath"
    Me.MetroTextBoxOtherMatchesFilePath.Size = New System.Drawing.Size(563, 23)
    Me.MetroTextBoxOtherMatchesFilePath.TabIndex = 4
    '
    'MetroLabelOtherMatches
    '
    Me.MetroLabelOtherMatches.AutoSize = True
    Me.MetroLabelOtherMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelOtherMatches.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabelOtherMatches.Location = New System.Drawing.Point(3, 30)
    Me.MetroLabelOtherMatches.Name = "MetroLabelOtherMatches"
    Me.MetroLabelOtherMatches.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabelOtherMatches.TabIndex = 3
    Me.MetroLabelOtherMatches.Text = "Other matches file path"
    Me.MetroLabelOtherMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroLabelDataBase
    '
    Me.MetroLabelDataBase.AutoSize = True
    Me.MetroLabelDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelDataBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabelDataBase.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelDataBase.Name = "MetroLabelDataBase"
    Me.MetroLabelDataBase.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabelDataBase.TabIndex = 0
    Me.MetroLabelDataBase.Text = "Data base"
    Me.MetroLabelDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxDefaultColorPath
    '
    Me.MetroTextBoxDefaultColorPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxDefaultColorPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDefaultColorPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxDefaultColorPath.Location = New System.Drawing.Point(158, 63)
    Me.MetroTextBoxDefaultColorPath.Name = "MetroTextBoxDefaultColorPath"
    Me.MetroTextBoxDefaultColorPath.Size = New System.Drawing.Size(563, 23)
    Me.MetroTextBoxDefaultColorPath.TabIndex = 7
    '
    'MetroTextBoxDefaultKitsPath
    '
    Me.MetroTextBoxDefaultKitsPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxDefaultKitsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDefaultKitsPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxDefaultKitsPath.Location = New System.Drawing.Point(158, 93)
    Me.MetroTextBoxDefaultKitsPath.Name = "MetroTextBoxDefaultKitsPath"
    Me.MetroTextBoxDefaultKitsPath.Size = New System.Drawing.Size(563, 23)
    Me.MetroTextBoxDefaultKitsPath.TabIndex = 8
    '
    'MetroButtonDefaultColorsPath
    '
    Me.MetroButtonDefaultColorsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDefaultColorsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonDefaultColorsPath.Location = New System.Drawing.Point(727, 63)
    Me.MetroButtonDefaultColorsPath.Name = "MetroButtonDefaultColorsPath"
    Me.MetroButtonDefaultColorsPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDefaultColorsPath.TabIndex = 9
    Me.MetroButtonDefaultColorsPath.Text = "..."
    '
    'MetroButtonDefaultkitsPath
    '
    Me.MetroButtonDefaultkitsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDefaultkitsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonDefaultkitsPath.Location = New System.Drawing.Point(727, 93)
    Me.MetroButtonDefaultkitsPath.Name = "MetroButtonDefaultkitsPath"
    Me.MetroButtonDefaultkitsPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDefaultkitsPath.TabIndex = 10
    Me.MetroButtonDefaultkitsPath.Text = "..."
    '
    'MetroLabel3
    '
    Me.MetroLabel3.AutoSize = True
    Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabel3.Location = New System.Drawing.Point(3, 60)
    Me.MetroLabel3.Name = "MetroLabel3"
    Me.MetroLabel3.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabel3.TabIndex = 11
    Me.MetroLabel3.Text = "Default colors path"
    Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroLabel4
    '
    Me.MetroLabel4.AutoSize = True
    Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabel4.Location = New System.Drawing.Point(3, 90)
    Me.MetroLabel4.Name = "MetroLabel4"
    Me.MetroLabel4.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabel4.TabIndex = 12
    Me.MetroLabel4.Text = "Default kits path"
    Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroButtonDataBase
    '
    Me.MetroButtonDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonDataBase.Location = New System.Drawing.Point(726, 3)
    Me.MetroButtonDataBase.Name = "MetroButtonDataBase"
    Me.MetroButtonDataBase.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDataBase.TabIndex = 2
    Me.MetroButtonDataBase.Text = "..."
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.ColumnCount = 3
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.LabelDatabase, 0, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.MetroButtonDataBase, 2, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 1)
    Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDownLogger, 1, 1)
    Me.TableLayoutPanel4.Controls.Add(Me.MetroTextBoxDataBase, 1, 0)
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(19, 63)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 8
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(758, 304)
    Me.TableLayoutPanel4.TabIndex = 1
    '
    'LabelDatabase
    '
    Me.LabelDatabase.AutoSize = True
    Me.LabelDatabase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelDatabase.Location = New System.Drawing.Point(3, 0)
    Me.LabelDatabase.Name = "LabelDatabase"
    Me.LabelDatabase.Size = New System.Drawing.Size(145, 30)
    Me.LabelDatabase.TabIndex = 4
    Me.LabelDatabase.Text = "Database path"
    Me.LabelDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(3, 30)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(145, 30)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Logger port"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'NumericUpDownLogger
    '
    Me.NumericUpDownLogger.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownLogger.Location = New System.Drawing.Point(154, 33)
    Me.NumericUpDownLogger.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownLogger.Name = "NumericUpDownLogger"
    Me.NumericUpDownLogger.Size = New System.Drawing.Size(68, 25)
    Me.NumericUpDownLogger.TabIndex = 3
    '
    'MetroTextBoxDataBase
    '
    Me.MetroTextBoxDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDataBase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxDataBase.Location = New System.Drawing.Point(154, 3)
    Me.MetroTextBoxDataBase.Name = "MetroTextBoxDataBase"
    Me.MetroTextBoxDataBase.Size = New System.Drawing.Size(566, 23)
    Me.MetroTextBoxDataBase.TabIndex = 1
    '
    'OpenFileDialogDataBase
    '
    Me.OpenFileDialogDataBase.FileName = "OpenFileDialog1"
    Me.OpenFileDialogDataBase.Title = "Data base"
    '
    'OpenFileDialogXML
    '
    Me.OpenFileDialogXML.FileName = "Matches file path"
    '
    'DialogOptions
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(789, 414)
    Me.Controls.Add(Me.TableLayoutPanel4)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogOptions"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Options..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.TableLayoutPanel4.PerformLayout()
    CType(Me.NumericUpDownLogger, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents MetroLabelDataBase As System.Windows.Forms.Label
  Friend WithEvents MetroTextBoxDataBase As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonDataBase As Button
  Friend WithEvents OpenFileDialogDataBase As OpenFileDialog
  Friend WithEvents MetroTextBoxOtherMatchesFilePath As System.Windows.Forms.TextBox
  Friend WithEvents MetroLabelOtherMatches As System.Windows.Forms.Label
  Friend WithEvents MetroButtonOtherMatchesPath As Button
  Friend WithEvents OpenFileDialogXML As OpenFileDialog
  Friend WithEvents MetroTextBoxDefaultColorPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroTextBoxDefaultKitsPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonDefaultColorsPath As Button
  Friend WithEvents MetroButtonDefaultkitsPath As Button
  Friend WithEvents MetroLabel3 As System.Windows.Forms.Label
  Friend WithEvents MetroLabel4 As System.Windows.Forms.Label
  Friend WithEvents FolderBrowserDialogPaths As FolderBrowserDialog
  Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
  Friend WithEvents Label4 As Label
  Friend WithEvents NumericUpDownLogger As NumericUpDown
  Private WithEvents CheckBoxShowOptionsOnStartup As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents LabelDatabase As Label
End Class
