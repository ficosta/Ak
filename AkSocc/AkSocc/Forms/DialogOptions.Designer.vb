<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogOptions
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
    Me.OK_Button = New Button()
    Me.Cancel_Button = New Button()
    Me.CheckBoxShowOptionsOnStartup = New MetroFramework.Controls.MetroCheckBox()
    Me.TabControlOptions = New MetroFramework.Controls.MetroTabControl()
    Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonOtherMatchesPath = New Button()
    Me.MetroTextBoxOtherMatchesFilePath = New MetroFramework.Controls.MetroTextBox()
    Me.MetroLabelOtherMatches = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabelDataBase = New MetroFramework.Controls.MetroLabel()
    Me.MetroTextBoxDataBase = New MetroFramework.Controls.MetroTextBox()
    Me.MetroButtonDataBase = New Button()
    Me.MetroCheckBoxUseArabicNames = New MetroFramework.Controls.MetroCheckBox()
    Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
    Me.MetroTextBoxRemotePreviewPath = New MetroFramework.Controls.MetroTextBox()
    Me.MetroButtonRemotePreviewPath = New Button()
    Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
    Me.MetroTextBoxLocalPreviewPath = New MetroFramework.Controls.MetroTextBox()
    Me.MetroButtonLocalPreviewPath = New Button()
    Me.NumericUpDownPreviewPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelHost = New MetroFramework.Controls.MetroLabel()
    Me.TextBoxVizrtHost = New MetroFramework.Controls.MetroTextBox()
    Me.LabelREPort = New MetroFramework.Controls.MetroLabel()
    Me.NumericUpDownPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelPreviewPort = New MetroFramework.Controls.MetroLabel()
    Me.LabelSceneVersion = New MetroFramework.Controls.MetroLabel()
    Me.ComboBoxSceneVersion = New MetroFramework.Controls.MetroComboBox()
    Me.OpenFileDialogDataBase = New System.Windows.Forms.OpenFileDialog()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.MetroTextBoxDefaultColorPath = New MetroFramework.Controls.MetroTextBox()
    Me.MetroTextBoxDefaultKitsPath = New MetroFramework.Controls.MetroTextBox()
    Me.MetroButtonDefaultColorsPath = New Button()
    Me.MetroButtonDefaultkitsPath = New Button()
    Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
    Me.FolderBrowserDialogPaths = New System.Windows.Forms.FolderBrowserDialog()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TabControlOptions.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownPreviewPort, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(609, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.FlatStyle = FlatStyle.Flat
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(689, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.FlatStyle = FlatStyle.Flat
    '
    'CheckBoxShowOptionsOnStartup
    '
    Me.CheckBoxShowOptionsOnStartup.AutoSize = True
    Me.CheckBoxShowOptionsOnStartup.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxShowOptionsOnStartup.Location = New System.Drawing.Point(3, 3)
    Me.CheckBoxShowOptionsOnStartup.Name = "CheckBoxShowOptionsOnStartup"
    Me.CheckBoxShowOptionsOnStartup.Size = New System.Drawing.Size(600, 23)
    Me.CheckBoxShowOptionsOnStartup.TabIndex = 2
    Me.CheckBoxShowOptionsOnStartup.Text = "Show options on application startup"
    Me.CheckBoxShowOptionsOnStartup.FlatStyle = FlatStyle.Flat
    '
    'TabControlOptions
    '
    Me.TabControlOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControlOptions.Controls.Add(Me.TabPage1)
    Me.TabControlOptions.Controls.Add(Me.TabPage2)
    Me.TabControlOptions.Location = New System.Drawing.Point(12, 12)
    Me.TabControlOptions.Name = "TabControlOptions"
    Me.TabControlOptions.SelectedIndex = 0
    Me.TabControlOptions.Size = New System.Drawing.Size(773, 355)
    Me.TabControlOptions.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
    Me.TabPage1.HorizontalScrollbarBarColor = True
    Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
    Me.TabPage1.HorizontalScrollbarSize = 10
    Me.TabPage1.Location = New System.Drawing.Point(4, 38)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(765, 313)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "General options"
    Me.TabPage1.UseVisualStyleBackColor = True
    Me.TabPage1.VerticalScrollbarBarColor = True
    Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
    Me.TabPage1.VerticalScrollbarSize = 10
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
    Me.TableLayoutPanel3.Controls.Add(Me.MetroTextBoxDataBase, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroButtonDataBase, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.MetroCheckBoxUseArabicNames, 1, 5)
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
    Me.MetroButtonOtherMatchesPath.Location = New System.Drawing.Point(727, 33)
    Me.MetroButtonOtherMatchesPath.Name = "MetroButtonOtherMatchesPath"
    Me.MetroButtonOtherMatchesPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonOtherMatchesPath.TabIndex = 5
    Me.MetroButtonOtherMatchesPath.Text = "..."
    Me.MetroButtonOtherMatchesPath.FlatStyle = FlatStyle.Flat
    '
    'MetroTextBoxOtherMatchesFilePath
    '
    '
    '
    '
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Image = Nothing
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Location = New System.Drawing.Point(541, 2)
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Name = ""
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.TabIndex = 1
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxOtherMatchesFilePath.CustomButton.Visible = False
    Me.MetroTextBoxOtherMatchesFilePath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxOtherMatchesFilePath.Lines = New String(-1) {}
    Me.MetroTextBoxOtherMatchesFilePath.Location = New System.Drawing.Point(158, 33)
    Me.MetroTextBoxOtherMatchesFilePath.MaxLength = 32767
    Me.MetroTextBoxOtherMatchesFilePath.Name = "MetroTextBoxOtherMatchesFilePath"
    Me.MetroTextBoxOtherMatchesFilePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxOtherMatchesFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxOtherMatchesFilePath.SelectedText = ""
    Me.MetroTextBoxOtherMatchesFilePath.SelectionLength = 0
    Me.MetroTextBoxOtherMatchesFilePath.SelectionStart = 0
    Me.MetroTextBoxOtherMatchesFilePath.Size = New System.Drawing.Size(563, 24)
    Me.MetroTextBoxOtherMatchesFilePath.TabIndex = 4
    Me.MetroTextBoxOtherMatchesFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxOtherMatchesFilePath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroLabelOtherMatches
    '
    Me.MetroLabelOtherMatches.AutoSize = True
    Me.MetroLabelOtherMatches.Dock = System.Windows.Forms.DockStyle.Fill
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
    Me.MetroLabelDataBase.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelDataBase.Name = "MetroLabelDataBase"
    Me.MetroLabelDataBase.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabelDataBase.TabIndex = 0
    Me.MetroLabelDataBase.Text = "Data base"
    Me.MetroLabelDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxDataBase
    '
    '
    '
    '
    Me.MetroTextBoxDataBase.CustomButton.Image = Nothing
    Me.MetroTextBoxDataBase.CustomButton.Location = New System.Drawing.Point(541, 2)
    Me.MetroTextBoxDataBase.CustomButton.Name = ""
    Me.MetroTextBoxDataBase.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxDataBase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxDataBase.CustomButton.TabIndex = 1
    Me.MetroTextBoxDataBase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxDataBase.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxDataBase.CustomButton.Visible = False
    Me.MetroTextBoxDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDataBase.Lines = New String(-1) {}
    Me.MetroTextBoxDataBase.Location = New System.Drawing.Point(158, 3)
    Me.MetroTextBoxDataBase.MaxLength = 32767
    Me.MetroTextBoxDataBase.Name = "MetroTextBoxDataBase"
    Me.MetroTextBoxDataBase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxDataBase.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxDataBase.SelectedText = ""
    Me.MetroTextBoxDataBase.SelectionLength = 0
    Me.MetroTextBoxDataBase.SelectionStart = 0
    Me.MetroTextBoxDataBase.Size = New System.Drawing.Size(563, 24)
    Me.MetroTextBoxDataBase.TabIndex = 1
    Me.MetroTextBoxDataBase.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxDataBase.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroButtonDataBase
    '
    Me.MetroButtonDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDataBase.Location = New System.Drawing.Point(727, 3)
    Me.MetroButtonDataBase.Name = "MetroButtonDataBase"
    Me.MetroButtonDataBase.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDataBase.TabIndex = 2
    Me.MetroButtonDataBase.Text = "..."
    Me.MetroButtonDataBase.FlatStyle = FlatStyle.Flat
    '
    'MetroCheckBoxUseArabicNames
    '
    Me.MetroCheckBoxUseArabicNames.AutoSize = True
    Me.MetroCheckBoxUseArabicNames.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxUseArabicNames.Location = New System.Drawing.Point(158, 153)
    Me.MetroCheckBoxUseArabicNames.Name = "MetroCheckBoxUseArabicNames"
    Me.MetroCheckBoxUseArabicNames.Size = New System.Drawing.Size(563, 24)
    Me.MetroCheckBoxUseArabicNames.TabIndex = 6
    Me.MetroCheckBoxUseArabicNames.Text = "Use arabic names"
    Me.MetroCheckBoxUseArabicNames.FlatStyle = FlatStyle.Flat
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
    Me.TabPage2.HorizontalScrollbarBarColor = True
    Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
    Me.TabPage2.HorizontalScrollbarSize = 10
    Me.TabPage2.Location = New System.Drawing.Point(4, 38)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(765, 313)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Vizrt options"
    Me.TabPage2.UseVisualStyleBackColor = True
    Me.TabPage2.VerticalScrollbarBarColor = True
    Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
    Me.TabPage2.VerticalScrollbarSize = 10
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 3
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel2, 0, 6)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTextBoxRemotePreviewPath, 0, 6)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroButtonRemotePreviewPath, 0, 6)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel1, 0, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTextBoxLocalPreviewPath, 0, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroButtonLocalPreviewPath, 0, 5)
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
    Me.TableLayoutPanel2.RowCount = 8
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(759, 307)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'MetroLabel2
    '
    Me.MetroLabel2.AutoSize = True
    Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel2.Location = New System.Drawing.Point(3, 160)
    Me.MetroLabel2.Name = "MetroLabel2"
    Me.MetroLabel2.Size = New System.Drawing.Size(145, 30)
    Me.MetroLabel2.TabIndex = 11
    Me.MetroLabel2.Text = "Remote preview path"
    Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxRemotePreviewPath
    '
    '
    '
    '
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Image = Nothing
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Location = New System.Drawing.Point(545, 2)
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Name = ""
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxRemotePreviewPath.CustomButton.TabIndex = 1
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxRemotePreviewPath.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxRemotePreviewPath.CustomButton.Visible = False
    Me.MetroTextBoxRemotePreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxRemotePreviewPath.Lines = New String(-1) {}
    Me.MetroTextBoxRemotePreviewPath.Location = New System.Drawing.Point(154, 163)
    Me.MetroTextBoxRemotePreviewPath.MaxLength = 32767
    Me.MetroTextBoxRemotePreviewPath.Name = "MetroTextBoxRemotePreviewPath"
    Me.MetroTextBoxRemotePreviewPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxRemotePreviewPath.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxRemotePreviewPath.SelectedText = ""
    Me.MetroTextBoxRemotePreviewPath.SelectionLength = 0
    Me.MetroTextBoxRemotePreviewPath.SelectionStart = 0
    Me.MetroTextBoxRemotePreviewPath.Size = New System.Drawing.Size(567, 24)
    Me.MetroTextBoxRemotePreviewPath.TabIndex = 12
    Me.MetroTextBoxRemotePreviewPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxRemotePreviewPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroButtonRemotePreviewPath
    '
    Me.MetroButtonRemotePreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonRemotePreviewPath.Location = New System.Drawing.Point(727, 163)
    Me.MetroButtonRemotePreviewPath.Name = "MetroButtonRemotePreviewPath"
    Me.MetroButtonRemotePreviewPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonRemotePreviewPath.TabIndex = 13
    Me.MetroButtonRemotePreviewPath.Text = "..."
    Me.MetroButtonRemotePreviewPath.FlatStyle = FlatStyle.Flat
    '
    'MetroLabel1
    '
    Me.MetroLabel1.AutoSize = True
    Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel1.Location = New System.Drawing.Point(3, 130)
    Me.MetroLabel1.Name = "MetroLabel1"
    Me.MetroLabel1.Size = New System.Drawing.Size(145, 30)
    Me.MetroLabel1.TabIndex = 8
    Me.MetroLabel1.Text = "Local preview path"
    Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxLocalPreviewPath
    '
    '
    '
    '
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Image = Nothing
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Location = New System.Drawing.Point(545, 2)
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Name = ""
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxLocalPreviewPath.CustomButton.TabIndex = 1
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxLocalPreviewPath.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxLocalPreviewPath.CustomButton.Visible = False
    Me.MetroTextBoxLocalPreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxLocalPreviewPath.Lines = New String(-1) {}
    Me.MetroTextBoxLocalPreviewPath.Location = New System.Drawing.Point(154, 133)
    Me.MetroTextBoxLocalPreviewPath.MaxLength = 32767
    Me.MetroTextBoxLocalPreviewPath.Name = "MetroTextBoxLocalPreviewPath"
    Me.MetroTextBoxLocalPreviewPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxLocalPreviewPath.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxLocalPreviewPath.SelectedText = ""
    Me.MetroTextBoxLocalPreviewPath.SelectionLength = 0
    Me.MetroTextBoxLocalPreviewPath.SelectionStart = 0
    Me.MetroTextBoxLocalPreviewPath.Size = New System.Drawing.Size(567, 24)
    Me.MetroTextBoxLocalPreviewPath.TabIndex = 9
    Me.MetroTextBoxLocalPreviewPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxLocalPreviewPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroButtonLocalPreviewPath
    '
    Me.MetroButtonLocalPreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonLocalPreviewPath.Location = New System.Drawing.Point(727, 133)
    Me.MetroButtonLocalPreviewPath.Name = "MetroButtonLocalPreviewPath"
    Me.MetroButtonLocalPreviewPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonLocalPreviewPath.TabIndex = 10
    Me.MetroButtonLocalPreviewPath.Text = "..."
    Me.MetroButtonLocalPreviewPath.FlatStyle = FlatStyle.Flat
    '
    'NumericUpDownPreviewPort
    '
    Me.NumericUpDownPreviewPort.Location = New System.Drawing.Point(154, 63)
    Me.NumericUpDownPreviewPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPreviewPort.Name = "NumericUpDownPreviewPort"
    Me.NumericUpDownPreviewPort.Size = New System.Drawing.Size(68, 20)
    Me.NumericUpDownPreviewPort.TabIndex = 5
    '
    'LabelHost
    '
    Me.LabelHost.AutoSize = True
    Me.LabelHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelHost.Location = New System.Drawing.Point(3, 0)
    Me.LabelHost.Name = "LabelHost"
    Me.LabelHost.Size = New System.Drawing.Size(145, 30)
    Me.LabelHost.TabIndex = 0
    Me.LabelHost.Text = "Vizrt host"
    Me.LabelHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxVizrtHost
    '
    '
    '
    '
    Me.TextBoxVizrtHost.CustomButton.Image = Nothing
    Me.TextBoxVizrtHost.CustomButton.Location = New System.Drawing.Point(545, 2)
    Me.TextBoxVizrtHost.CustomButton.Name = ""
    Me.TextBoxVizrtHost.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.TextBoxVizrtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.TextBoxVizrtHost.CustomButton.TabIndex = 1
    Me.TextBoxVizrtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.TextBoxVizrtHost.CustomButton.FlatStyle = FlatStyle.Flat
    Me.TextBoxVizrtHost.CustomButton.Visible = False
    Me.TextBoxVizrtHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxVizrtHost.Lines = New String(-1) {}
    Me.TextBoxVizrtHost.Location = New System.Drawing.Point(154, 3)
    Me.TextBoxVizrtHost.MaxLength = 32767
    Me.TextBoxVizrtHost.Name = "TextBoxVizrtHost"
    Me.TextBoxVizrtHost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.TextBoxVizrtHost.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.TextBoxVizrtHost.SelectedText = ""
    Me.TextBoxVizrtHost.SelectionLength = 0
    Me.TextBoxVizrtHost.SelectionStart = 0
    Me.TextBoxVizrtHost.Size = New System.Drawing.Size(567, 24)
    Me.TextBoxVizrtHost.TabIndex = 1
    Me.TextBoxVizrtHost.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.TextBoxVizrtHost.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'LabelREPort
    '
    Me.LabelREPort.AutoSize = True
    Me.LabelREPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelREPort.Location = New System.Drawing.Point(3, 30)
    Me.LabelREPort.Name = "LabelREPort"
    Me.LabelREPort.Size = New System.Drawing.Size(145, 30)
    Me.LabelREPort.TabIndex = 2
    Me.LabelREPort.Text = "RE port"
    Me.LabelREPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'NumericUpDownPort
    '
    Me.NumericUpDownPort.Location = New System.Drawing.Point(154, 33)
    Me.NumericUpDownPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPort.Name = "NumericUpDownPort"
    Me.NumericUpDownPort.Size = New System.Drawing.Size(68, 20)
    Me.NumericUpDownPort.TabIndex = 3
    '
    'LabelPreviewPort
    '
    Me.LabelPreviewPort.AutoSize = True
    Me.LabelPreviewPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelPreviewPort.Location = New System.Drawing.Point(3, 60)
    Me.LabelPreviewPort.Name = "LabelPreviewPort"
    Me.LabelPreviewPort.Size = New System.Drawing.Size(145, 30)
    Me.LabelPreviewPort.TabIndex = 4
    Me.LabelPreviewPort.Text = "Preview port"
    Me.LabelPreviewPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelSceneVersion
    '
    Me.LabelSceneVersion.AutoSize = True
    Me.LabelSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSceneVersion.Location = New System.Drawing.Point(3, 90)
    Me.LabelSceneVersion.Name = "LabelSceneVersion"
    Me.LabelSceneVersion.Size = New System.Drawing.Size(145, 30)
    Me.LabelSceneVersion.TabIndex = 6
    Me.LabelSceneVersion.Text = "Scene version"
    Me.LabelSceneVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ComboBoxSceneVersion
    '
    Me.ComboBoxSceneVersion.FormattingEnabled = True
    Me.ComboBoxSceneVersion.ItemHeight = 23
    Me.ComboBoxSceneVersion.Location = New System.Drawing.Point(154, 93)
    Me.ComboBoxSceneVersion.Name = "ComboBoxSceneVersion"
    Me.ComboBoxSceneVersion.Size = New System.Drawing.Size(192, 29)
    Me.ComboBoxSceneVersion.TabIndex = 7
    Me.ComboBoxSceneVersion.FlatStyle = FlatStyle.Flat
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
    'MetroTextBoxDefaultColorPath
    '
    '
    '
    '
    Me.MetroTextBoxDefaultColorPath.CustomButton.Image = Nothing
    Me.MetroTextBoxDefaultColorPath.CustomButton.Location = New System.Drawing.Point(541, 2)
    Me.MetroTextBoxDefaultColorPath.CustomButton.Name = ""
    Me.MetroTextBoxDefaultColorPath.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxDefaultColorPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxDefaultColorPath.CustomButton.TabIndex = 1
    Me.MetroTextBoxDefaultColorPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxDefaultColorPath.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxDefaultColorPath.CustomButton.Visible = False
    Me.MetroTextBoxDefaultColorPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDefaultColorPath.Lines = New String(-1) {}
    Me.MetroTextBoxDefaultColorPath.Location = New System.Drawing.Point(158, 63)
    Me.MetroTextBoxDefaultColorPath.MaxLength = 32767
    Me.MetroTextBoxDefaultColorPath.Name = "MetroTextBoxDefaultColorPath"
    Me.MetroTextBoxDefaultColorPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxDefaultColorPath.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxDefaultColorPath.SelectedText = ""
    Me.MetroTextBoxDefaultColorPath.SelectionLength = 0
    Me.MetroTextBoxDefaultColorPath.SelectionStart = 0
    Me.MetroTextBoxDefaultColorPath.Size = New System.Drawing.Size(563, 24)
    Me.MetroTextBoxDefaultColorPath.TabIndex = 7
    Me.MetroTextBoxDefaultColorPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxDefaultColorPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroTextBoxDefaultKitsPath
    '
    '
    '
    '
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Image = Nothing
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Location = New System.Drawing.Point(541, 2)
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Name = ""
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxDefaultKitsPath.CustomButton.TabIndex = 1
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxDefaultKitsPath.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxDefaultKitsPath.CustomButton.Visible = False
    Me.MetroTextBoxDefaultKitsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDefaultKitsPath.Lines = New String(-1) {}
    Me.MetroTextBoxDefaultKitsPath.Location = New System.Drawing.Point(158, 93)
    Me.MetroTextBoxDefaultKitsPath.MaxLength = 32767
    Me.MetroTextBoxDefaultKitsPath.Name = "MetroTextBoxDefaultKitsPath"
    Me.MetroTextBoxDefaultKitsPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxDefaultKitsPath.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxDefaultKitsPath.SelectedText = ""
    Me.MetroTextBoxDefaultKitsPath.SelectionLength = 0
    Me.MetroTextBoxDefaultKitsPath.SelectionStart = 0
    Me.MetroTextBoxDefaultKitsPath.Size = New System.Drawing.Size(563, 24)
    Me.MetroTextBoxDefaultKitsPath.TabIndex = 8
    Me.MetroTextBoxDefaultKitsPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxDefaultKitsPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroButtonDefaultColorsPath
    '
    Me.MetroButtonDefaultColorsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDefaultColorsPath.Location = New System.Drawing.Point(727, 63)
    Me.MetroButtonDefaultColorsPath.Name = "MetroButtonDefaultColorsPath"
    Me.MetroButtonDefaultColorsPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDefaultColorsPath.TabIndex = 9
    Me.MetroButtonDefaultColorsPath.Text = "..."
    Me.MetroButtonDefaultColorsPath.FlatStyle = FlatStyle.Flat
    '
    'MetroButtonDefaultkitsPath
    '
    Me.MetroButtonDefaultkitsPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDefaultkitsPath.Location = New System.Drawing.Point(727, 93)
    Me.MetroButtonDefaultkitsPath.Name = "MetroButtonDefaultkitsPath"
    Me.MetroButtonDefaultkitsPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDefaultkitsPath.TabIndex = 10
    Me.MetroButtonDefaultkitsPath.Text = "..."
    Me.MetroButtonDefaultkitsPath.FlatStyle = FlatStyle.Flat
    '
    'MetroLabel3
    '
    Me.MetroLabel3.AutoSize = True
    Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
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
    Me.MetroLabel4.Location = New System.Drawing.Point(3, 90)
    Me.MetroLabel4.Name = "MetroLabel4"
    Me.MetroLabel4.Size = New System.Drawing.Size(149, 30)
    Me.MetroLabel4.TabIndex = 12
    Me.MetroLabel4.Text = "Default kits path"
    Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'DialogOptions
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(797, 414)
    Me.Controls.Add(Me.TabControlOptions)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogOptions"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Options..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TabControlOptions.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    CType(Me.NumericUpDownPreviewPort, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents TextBoxVizrtHost As MetroFramework.Controls.MetroTextBox
  Friend WithEvents NumericUpDownPort As NumericUpDown
  Friend WithEvents NumericUpDownPreviewPort As NumericUpDown
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents MetroLabelDataBase As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroTextBoxDataBase As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroButtonDataBase As Button
  Friend WithEvents CheckBoxShowOptionsOnStartup As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents TabControlOptions As MetroFramework.Controls.MetroTabControl
  Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents LabelHost As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelREPort As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelPreviewPort As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelSceneVersion As MetroFramework.Controls.MetroLabel
  Friend WithEvents ComboBoxSceneVersion As MetroFramework.Controls.MetroComboBox
  Friend WithEvents OpenFileDialogDataBase As OpenFileDialog
  Friend WithEvents MetroTextBoxOtherMatchesFilePath As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroLabelOtherMatches As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroButtonOtherMatchesPath As Button
  Friend WithEvents OpenFileDialogXML As OpenFileDialog
  Friend WithEvents MetroCheckBoxUseArabicNames As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroTextBoxRemotePreviewPath As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroButtonRemotePreviewPath As Button
  Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroTextBoxLocalPreviewPath As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroButtonLocalPreviewPath As Button
  Friend WithEvents MetroTextBoxDefaultColorPath As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroTextBoxDefaultKitsPath As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroButtonDefaultColorsPath As Button
  Friend WithEvents MetroButtonDefaultkitsPath As Button
  Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
  Friend WithEvents FolderBrowserDialogPaths As FolderBrowserDialog
End Class
