<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogOptions
  Inherits System.Windows.Forms.Form
  'Inherits System.Windows.Forms.Form


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
    Me.TabControlOptions = New MetroFramework.Controls.MetroTabControl()
    Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonOtherMatchesPath = New System.Windows.Forms.Button()
    Me.MetroTextBoxOtherMatchesFilePath = New System.Windows.Forms.TextBox()
    Me.MetroLabelOtherMatches = New System.Windows.Forms.Label()
    Me.MetroLabelDataBase = New System.Windows.Forms.Label()
    Me.MetroTextBoxDataBase = New System.Windows.Forms.TextBox()
    Me.MetroButtonDataBase = New System.Windows.Forms.Button()
    Me.MetroCheckBoxUseArabicNames = New MetroFramework.Controls.MetroCheckBox()
    Me.MetroTextBoxDefaultColorPath = New System.Windows.Forms.TextBox()
    Me.MetroTextBoxDefaultKitsPath = New System.Windows.Forms.TextBox()
    Me.MetroButtonDefaultColorsPath = New System.Windows.Forms.Button()
    Me.MetroButtonDefaultkitsPath = New System.Windows.Forms.Button()
    Me.MetroLabel3 = New System.Windows.Forms.Label()
    Me.MetroLabel4 = New System.Windows.Forms.Label()
    Me.MetroCheckBoxUseMultiLanguage = New MetroFramework.Controls.MetroCheckBox()
    Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabel2 = New System.Windows.Forms.Label()
    Me.MetroTextBoxRemotePreviewPath = New System.Windows.Forms.TextBox()
    Me.MetroButtonRemotePreviewPath = New System.Windows.Forms.Button()
    Me.MetroLabel1 = New System.Windows.Forms.Label()
    Me.MetroTextBoxLocalPreviewPath = New System.Windows.Forms.TextBox()
    Me.MetroButtonLocalPreviewPath = New System.Windows.Forms.Button()
    Me.NumericUpDownPreviewPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelHost = New System.Windows.Forms.Label()
    Me.TextBoxVizrtHost = New System.Windows.Forms.TextBox()
    Me.LabelREPort = New System.Windows.Forms.Label()
    Me.NumericUpDownPort = New System.Windows.Forms.NumericUpDown()
    Me.LabelPreviewPort = New System.Windows.Forms.Label()
    Me.LabelSceneVersion = New System.Windows.Forms.Label()
    Me.ComboBoxSceneVersion = New System.Windows.Forms.ComboBox()
    Me.TabPageLogger = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanelLogger = New System.Windows.Forms.TableLayoutPanel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TextBoxLoggerHost = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.NumericUpDownLogger = New System.Windows.Forms.NumericUpDown()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroCheckBoxUseOptaData = New MetroFramework.Controls.MetroCheckBox()
    Me.MetroCheckBoxOptaAutoUpdate = New MetroFramework.Controls.MetroCheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TextBoxOptaLocalPath = New System.Windows.Forms.TextBox()
    Me.ButtonOptaLocalPath = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextBoxFTPServer = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.TextBoxFTPUser = New System.Windows.Forms.TextBox()
    Me.TextBoxFTPPassword = New System.Windows.Forms.TextBox()
    Me.LabelOptaCompetitionId = New System.Windows.Forms.Label()
    Me.LabelOptaSearonId = New System.Windows.Forms.Label()
    Me.TextBoxOptaCompetitionId = New System.Windows.Forms.TextBox()
    Me.TextBoxOptaSeasonId = New System.Windows.Forms.TextBox()
    Me.TabPageSettings = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection = New MetroFramework.Controls.MetroCheckBox()
    Me.OpenFileDialogDataBase = New System.Windows.Forms.OpenFileDialog()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.FolderBrowserDialogPaths = New System.Windows.Forms.FolderBrowserDialog()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TabControlOptions.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownPreviewPort, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPageLogger.SuspendLayout()
    Me.TableLayoutPanelLogger.SuspendLayout()
    CType(Me.NumericUpDownLogger, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage3.SuspendLayout()
    Me.TableLayoutPanel5.SuspendLayout()
    Me.TabPageSettings.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 326)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(609, 3)
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
    Me.Cancel_Button.Location = New System.Drawing.Point(689, 3)
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
    Me.CheckBoxShowOptionsOnStartup.Size = New System.Drawing.Size(600, 23)
    Me.CheckBoxShowOptionsOnStartup.TabIndex = 2
    Me.CheckBoxShowOptionsOnStartup.Text = "Show options on application startup"
    Me.CheckBoxShowOptionsOnStartup.UseSelectable = True
    '
    'TabControlOptions
    '
    Me.TabControlOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControlOptions.Controls.Add(Me.TabPage1)
    Me.TabControlOptions.Controls.Add(Me.TabPage2)
    Me.TabControlOptions.Controls.Add(Me.TabPageLogger)
    Me.TabControlOptions.Controls.Add(Me.TabPage3)
    Me.TabControlOptions.Controls.Add(Me.TabPageSettings)
    Me.TabControlOptions.Location = New System.Drawing.Point(12, 12)
    Me.TabControlOptions.Name = "TabControlOptions"
    Me.TabControlOptions.SelectedIndex = 0
    Me.TabControlOptions.Size = New System.Drawing.Size(773, 307)
    Me.TabControlOptions.TabIndex = 1
    Me.TabControlOptions.UseSelectable = True
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
    Me.TabPage1.Size = New System.Drawing.Size(765, 265)
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
    Me.TableLayoutPanel3.Controls.Add(Me.MetroCheckBoxUseMultiLanguage, 1, 4)
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
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(759, 259)
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
    'MetroTextBoxDataBase
    '
    Me.MetroTextBoxDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxDataBase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxDataBase.Location = New System.Drawing.Point(158, 3)
    Me.MetroTextBoxDataBase.Name = "MetroTextBoxDataBase"
    Me.MetroTextBoxDataBase.Size = New System.Drawing.Size(563, 23)
    Me.MetroTextBoxDataBase.TabIndex = 1
    '
    'MetroButtonDataBase
    '
    Me.MetroButtonDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonDataBase.Location = New System.Drawing.Point(727, 3)
    Me.MetroButtonDataBase.Name = "MetroButtonDataBase"
    Me.MetroButtonDataBase.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonDataBase.TabIndex = 2
    Me.MetroButtonDataBase.Text = "..."
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
    Me.MetroCheckBoxUseArabicNames.UseSelectable = True
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
    'MetroCheckBoxUseMultiLanguage
    '
    Me.MetroCheckBoxUseMultiLanguage.AutoSize = True
    Me.MetroCheckBoxUseMultiLanguage.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxUseMultiLanguage.Location = New System.Drawing.Point(158, 123)
    Me.MetroCheckBoxUseMultiLanguage.Name = "MetroCheckBoxUseMultiLanguage"
    Me.MetroCheckBoxUseMultiLanguage.Size = New System.Drawing.Size(563, 24)
    Me.MetroCheckBoxUseMultiLanguage.TabIndex = 13
    Me.MetroCheckBoxUseMultiLanguage.Text = "Multilanguage output"
    Me.MetroCheckBoxUseMultiLanguage.UseSelectable = True
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
    Me.TabPage2.Size = New System.Drawing.Size(765, 265)
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
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(759, 259)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'MetroLabel2
    '
    Me.MetroLabel2.AutoSize = True
    Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabel2.Location = New System.Drawing.Point(3, 160)
    Me.MetroLabel2.Name = "MetroLabel2"
    Me.MetroLabel2.Size = New System.Drawing.Size(145, 30)
    Me.MetroLabel2.TabIndex = 11
    Me.MetroLabel2.Text = "Remote preview path"
    Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxRemotePreviewPath
    '
    Me.MetroTextBoxRemotePreviewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxRemotePreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxRemotePreviewPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxRemotePreviewPath.Location = New System.Drawing.Point(154, 163)
    Me.MetroTextBoxRemotePreviewPath.Name = "MetroTextBoxRemotePreviewPath"
    Me.MetroTextBoxRemotePreviewPath.Size = New System.Drawing.Size(567, 25)
    Me.MetroTextBoxRemotePreviewPath.TabIndex = 12
    '
    'MetroButtonRemotePreviewPath
    '
    Me.MetroButtonRemotePreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonRemotePreviewPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonRemotePreviewPath.Location = New System.Drawing.Point(727, 163)
    Me.MetroButtonRemotePreviewPath.Name = "MetroButtonRemotePreviewPath"
    Me.MetroButtonRemotePreviewPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonRemotePreviewPath.TabIndex = 13
    Me.MetroButtonRemotePreviewPath.Text = "..."
    '
    'MetroLabel1
    '
    Me.MetroLabel1.AutoSize = True
    Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabel1.Location = New System.Drawing.Point(3, 130)
    Me.MetroLabel1.Name = "MetroLabel1"
    Me.MetroLabel1.Size = New System.Drawing.Size(145, 30)
    Me.MetroLabel1.TabIndex = 8
    Me.MetroLabel1.Text = "Local preview path"
    Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxLocalPreviewPath
    '
    Me.MetroTextBoxLocalPreviewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.MetroTextBoxLocalPreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxLocalPreviewPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroTextBoxLocalPreviewPath.Location = New System.Drawing.Point(154, 133)
    Me.MetroTextBoxLocalPreviewPath.Name = "MetroTextBoxLocalPreviewPath"
    Me.MetroTextBoxLocalPreviewPath.Size = New System.Drawing.Size(567, 25)
    Me.MetroTextBoxLocalPreviewPath.TabIndex = 9
    '
    'MetroButtonLocalPreviewPath
    '
    Me.MetroButtonLocalPreviewPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonLocalPreviewPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonLocalPreviewPath.Location = New System.Drawing.Point(727, 133)
    Me.MetroButtonLocalPreviewPath.Name = "MetroButtonLocalPreviewPath"
    Me.MetroButtonLocalPreviewPath.Size = New System.Drawing.Size(29, 24)
    Me.MetroButtonLocalPreviewPath.TabIndex = 10
    Me.MetroButtonLocalPreviewPath.Text = "..."
    '
    'NumericUpDownPreviewPort
    '
    Me.NumericUpDownPreviewPort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownPreviewPort.Location = New System.Drawing.Point(154, 63)
    Me.NumericUpDownPreviewPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPreviewPort.Name = "NumericUpDownPreviewPort"
    Me.NumericUpDownPreviewPort.Size = New System.Drawing.Size(68, 25)
    Me.NumericUpDownPreviewPort.TabIndex = 5
    '
    'LabelHost
    '
    Me.LabelHost.AutoSize = True
    Me.LabelHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelHost.Location = New System.Drawing.Point(3, 0)
    Me.LabelHost.Name = "LabelHost"
    Me.LabelHost.Size = New System.Drawing.Size(145, 30)
    Me.LabelHost.TabIndex = 0
    Me.LabelHost.Text = "Vizrt host"
    Me.LabelHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxVizrtHost
    '
    Me.TextBoxVizrtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxVizrtHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxVizrtHost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxVizrtHost.Location = New System.Drawing.Point(154, 3)
    Me.TextBoxVizrtHost.Name = "TextBoxVizrtHost"
    Me.TextBoxVizrtHost.Size = New System.Drawing.Size(567, 25)
    Me.TextBoxVizrtHost.TabIndex = 1
    '
    'LabelREPort
    '
    Me.LabelREPort.AutoSize = True
    Me.LabelREPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelREPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelREPort.Location = New System.Drawing.Point(3, 30)
    Me.LabelREPort.Name = "LabelREPort"
    Me.LabelREPort.Size = New System.Drawing.Size(145, 30)
    Me.LabelREPort.TabIndex = 2
    Me.LabelREPort.Text = "RE port"
    Me.LabelREPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'NumericUpDownPort
    '
    Me.NumericUpDownPort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownPort.Location = New System.Drawing.Point(154, 33)
    Me.NumericUpDownPort.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.NumericUpDownPort.Name = "NumericUpDownPort"
    Me.NumericUpDownPort.Size = New System.Drawing.Size(68, 25)
    Me.NumericUpDownPort.TabIndex = 3
    '
    'LabelPreviewPort
    '
    Me.LabelPreviewPort.AutoSize = True
    Me.LabelPreviewPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelPreviewPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
    Me.LabelSceneVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelSceneVersion.Location = New System.Drawing.Point(3, 90)
    Me.LabelSceneVersion.Name = "LabelSceneVersion"
    Me.LabelSceneVersion.Size = New System.Drawing.Size(145, 30)
    Me.LabelSceneVersion.TabIndex = 6
    Me.LabelSceneVersion.Text = "Scene version"
    Me.LabelSceneVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ComboBoxSceneVersion
    '
    Me.ComboBoxSceneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSceneVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxSceneVersion.FormattingEnabled = True
    Me.ComboBoxSceneVersion.ItemHeight = 17
    Me.ComboBoxSceneVersion.Location = New System.Drawing.Point(154, 93)
    Me.ComboBoxSceneVersion.Name = "ComboBoxSceneVersion"
    Me.ComboBoxSceneVersion.Size = New System.Drawing.Size(192, 25)
    Me.ComboBoxSceneVersion.TabIndex = 7
    '
    'TabPageLogger
    '
    Me.TabPageLogger.Controls.Add(Me.TableLayoutPanelLogger)
    Me.TabPageLogger.Location = New System.Drawing.Point(4, 38)
    Me.TabPageLogger.Name = "TabPageLogger"
    Me.TabPageLogger.Size = New System.Drawing.Size(765, 265)
    Me.TabPageLogger.TabIndex = 2
    Me.TabPageLogger.Text = "Logger"
    '
    'TableLayoutPanelLogger
    '
    Me.TableLayoutPanelLogger.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanelLogger.ColumnCount = 3
    Me.TableLayoutPanelLogger.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
    Me.TableLayoutPanelLogger.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelLogger.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelLogger.Controls.Add(Me.Label3, 0, 0)
    Me.TableLayoutPanelLogger.Controls.Add(Me.TextBoxLoggerHost, 1, 0)
    Me.TableLayoutPanelLogger.Controls.Add(Me.Label4, 0, 1)
    Me.TableLayoutPanelLogger.Controls.Add(Me.NumericUpDownLogger, 1, 1)
    Me.TableLayoutPanelLogger.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelLogger.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelLogger.Name = "TableLayoutPanelLogger"
    Me.TableLayoutPanelLogger.RowCount = 8
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelLogger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelLogger.Size = New System.Drawing.Size(765, 265)
    Me.TableLayoutPanelLogger.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(145, 30)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Logger host"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxLoggerHost
    '
    Me.TextBoxLoggerHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanelLogger.SetColumnSpan(Me.TextBoxLoggerHost, 2)
    Me.TextBoxLoggerHost.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxLoggerHost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxLoggerHost.Location = New System.Drawing.Point(154, 3)
    Me.TextBoxLoggerHost.Name = "TextBoxLoggerHost"
    Me.TextBoxLoggerHost.Size = New System.Drawing.Size(608, 25)
    Me.TextBoxLoggerHost.TabIndex = 1
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
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.TableLayoutPanel5)
    Me.TabPage3.Location = New System.Drawing.Point(4, 38)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Size = New System.Drawing.Size(765, 265)
    Me.TabPage3.TabIndex = 3
    Me.TabPage3.Text = "Opta"
    '
    'TableLayoutPanel5
    '
    Me.TableLayoutPanel5.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel5.ColumnCount = 3
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel5.Controls.Add(Me.MetroCheckBoxUseOptaData, 1, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.MetroCheckBoxOptaAutoUpdate, 1, 8)
    Me.TableLayoutPanel5.Controls.Add(Me.Label1, 0, 1)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxOptaLocalPath, 1, 1)
    Me.TableLayoutPanel5.Controls.Add(Me.ButtonOptaLocalPath, 2, 1)
    Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 2)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxFTPServer, 1, 2)
    Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 3)
    Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 4)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxFTPUser, 1, 3)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxFTPPassword, 1, 4)
    Me.TableLayoutPanel5.Controls.Add(Me.LabelOptaCompetitionId, 0, 6)
    Me.TableLayoutPanel5.Controls.Add(Me.LabelOptaSearonId, 0, 7)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxOptaCompetitionId, 1, 6)
    Me.TableLayoutPanel5.Controls.Add(Me.TextBoxOptaSeasonId, 1, 7)
    Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
    Me.TableLayoutPanel5.RowCount = 10
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.Size = New System.Drawing.Size(765, 265)
    Me.TableLayoutPanel5.TabIndex = 2
    '
    'MetroCheckBoxUseOptaData
    '
    Me.MetroCheckBoxUseOptaData.AutoSize = True
    Me.MetroCheckBoxUseOptaData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxUseOptaData.Location = New System.Drawing.Point(154, 3)
    Me.MetroCheckBoxUseOptaData.Name = "MetroCheckBoxUseOptaData"
    Me.MetroCheckBoxUseOptaData.Size = New System.Drawing.Size(573, 24)
    Me.MetroCheckBoxUseOptaData.TabIndex = 8
    Me.MetroCheckBoxUseOptaData.Text = "Use opta data"
    Me.MetroCheckBoxUseOptaData.UseSelectable = True
    '
    'MetroCheckBoxOptaAutoUpdate
    '
    Me.MetroCheckBoxOptaAutoUpdate.AutoSize = True
    Me.MetroCheckBoxOptaAutoUpdate.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxOptaAutoUpdate.Location = New System.Drawing.Point(154, 223)
    Me.MetroCheckBoxOptaAutoUpdate.Name = "MetroCheckBoxOptaAutoUpdate"
    Me.MetroCheckBoxOptaAutoUpdate.Size = New System.Drawing.Size(573, 24)
    Me.MetroCheckBoxOptaAutoUpdate.TabIndex = 7
    Me.MetroCheckBoxOptaAutoUpdate.Text = "Auto update match results from opta data"
    Me.MetroCheckBoxOptaAutoUpdate.UseSelectable = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(3, 30)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(145, 30)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Local path"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxOptaLocalPath
    '
    Me.TextBoxOptaLocalPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxOptaLocalPath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxOptaLocalPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxOptaLocalPath.Location = New System.Drawing.Point(154, 33)
    Me.TextBoxOptaLocalPath.Name = "TextBoxOptaLocalPath"
    Me.TextBoxOptaLocalPath.Size = New System.Drawing.Size(573, 25)
    Me.TextBoxOptaLocalPath.TabIndex = 1
    '
    'ButtonOptaLocalPath
    '
    Me.ButtonOptaLocalPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonOptaLocalPath.Location = New System.Drawing.Point(733, 33)
    Me.ButtonOptaLocalPath.Name = "ButtonOptaLocalPath"
    Me.ButtonOptaLocalPath.Size = New System.Drawing.Size(29, 24)
    Me.ButtonOptaLocalPath.TabIndex = 4
    Me.ButtonOptaLocalPath.Text = "..."
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(3, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(145, 30)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "FTP Server"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxFTPServer
    '
    Me.TextBoxFTPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxFTPServer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxFTPServer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxFTPServer.Location = New System.Drawing.Point(154, 63)
    Me.TextBoxFTPServer.Name = "TextBoxFTPServer"
    Me.TextBoxFTPServer.Size = New System.Drawing.Size(573, 25)
    Me.TextBoxFTPServer.TabIndex = 6
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(3, 90)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(145, 30)
    Me.Label5.TabIndex = 5
    Me.Label5.Text = "FTP User"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(3, 120)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(145, 30)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "FTP Password"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxFTPUser
    '
    Me.TextBoxFTPUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxFTPUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxFTPUser.Location = New System.Drawing.Point(154, 93)
    Me.TextBoxFTPUser.Name = "TextBoxFTPUser"
    Me.TextBoxFTPUser.Size = New System.Drawing.Size(138, 25)
    Me.TextBoxFTPUser.TabIndex = 6
    '
    'TextBoxFTPPassword
    '
    Me.TextBoxFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxFTPPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxFTPPassword.Location = New System.Drawing.Point(154, 123)
    Me.TextBoxFTPPassword.Name = "TextBoxFTPPassword"
    Me.TextBoxFTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.TextBoxFTPPassword.Size = New System.Drawing.Size(138, 25)
    Me.TextBoxFTPPassword.TabIndex = 6
    '
    'LabelOptaCompetitionId
    '
    Me.LabelOptaCompetitionId.AutoSize = True
    Me.LabelOptaCompetitionId.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOptaCompetitionId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelOptaCompetitionId.Location = New System.Drawing.Point(3, 160)
    Me.LabelOptaCompetitionId.Name = "LabelOptaCompetitionId"
    Me.LabelOptaCompetitionId.Size = New System.Drawing.Size(145, 30)
    Me.LabelOptaCompetitionId.TabIndex = 5
    Me.LabelOptaCompetitionId.Text = "Competition Id"
    Me.LabelOptaCompetitionId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelOptaSearonId
    '
    Me.LabelOptaSearonId.AutoSize = True
    Me.LabelOptaSearonId.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOptaSearonId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelOptaSearonId.Location = New System.Drawing.Point(3, 190)
    Me.LabelOptaSearonId.Name = "LabelOptaSearonId"
    Me.LabelOptaSearonId.Size = New System.Drawing.Size(145, 30)
    Me.LabelOptaSearonId.TabIndex = 5
    Me.LabelOptaSearonId.Text = "Season Id"
    Me.LabelOptaSearonId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxOptaCompetitionId
    '
    Me.TextBoxOptaCompetitionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxOptaCompetitionId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxOptaCompetitionId.Location = New System.Drawing.Point(154, 163)
    Me.TextBoxOptaCompetitionId.Name = "TextBoxOptaCompetitionId"
    Me.TextBoxOptaCompetitionId.Size = New System.Drawing.Size(138, 25)
    Me.TextBoxOptaCompetitionId.TabIndex = 6
    '
    'TextBoxOptaSeasonId
    '
    Me.TextBoxOptaSeasonId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBoxOptaSeasonId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxOptaSeasonId.Location = New System.Drawing.Point(154, 193)
    Me.TextBoxOptaSeasonId.Name = "TextBoxOptaSeasonId"
    Me.TextBoxOptaSeasonId.Size = New System.Drawing.Size(138, 25)
    Me.TextBoxOptaSeasonId.TabIndex = 6
    '
    'TabPageSettings
    '
    Me.TabPageSettings.Controls.Add(Me.TableLayoutPanel4)
    Me.TabPageSettings.HorizontalScrollbarBarColor = True
    Me.TabPageSettings.HorizontalScrollbarHighlightOnWheel = False
    Me.TabPageSettings.HorizontalScrollbarSize = 10
    Me.TabPageSettings.Location = New System.Drawing.Point(4, 38)
    Me.TabPageSettings.Name = "TabPageSettings"
    Me.TabPageSettings.Size = New System.Drawing.Size(765, 265)
    Me.TabPageSettings.TabIndex = 4
    Me.TabPageSettings.Text = "App settings"
    Me.TabPageSettings.VerticalScrollbarBarColor = True
    Me.TabPageSettings.VerticalScrollbarHighlightOnWheel = False
    Me.TabPageSettings.VerticalScrollbarSize = 10
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel4.ColumnCount = 3
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.MetroCheckBoxOpenPlayerDescriptionOnSelection, 1, 0)
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 1)
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
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(761, 261)
    Me.TableLayoutPanel4.TabIndex = 2
    '
    'MetroCheckBoxOpenPlayerDescriptionOnSelection
    '
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.AutoSize = True
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.Location = New System.Drawing.Point(154, 3)
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.Name = "MetroCheckBoxOpenPlayerDescriptionOnSelection"
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.Size = New System.Drawing.Size(569, 24)
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.TabIndex = 9
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.Text = "Open description graphic on player selection"
    Me.MetroCheckBoxOpenPlayerDescriptionOnSelection.UseSelectable = True
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
    Me.ClientSize = New System.Drawing.Size(797, 366)
    Me.Controls.Add(Me.TabControlOptions)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogOptions"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Options..."
    Me.TopMost = True
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
    Me.TabPageLogger.ResumeLayout(False)
    Me.TableLayoutPanelLogger.ResumeLayout(False)
    Me.TableLayoutPanelLogger.PerformLayout()
    CType(Me.NumericUpDownLogger, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage3.ResumeLayout(False)
    Me.TableLayoutPanel5.ResumeLayout(False)
    Me.TableLayoutPanel5.PerformLayout()
    Me.TabPageSettings.ResumeLayout(False)
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.TableLayoutPanel4.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents TextBoxVizrtHost As System.Windows.Forms.TextBox
  Friend WithEvents NumericUpDownPort As NumericUpDown
  Friend WithEvents NumericUpDownPreviewPort As NumericUpDown
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents MetroLabelDataBase As System.Windows.Forms.Label
  Friend WithEvents MetroTextBoxDataBase As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonDataBase As Button
  Friend WithEvents CheckBoxShowOptionsOnStartup As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents TabControlOptions As MetroFramework.Controls.MetroTabControl
  Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents LabelHost As System.Windows.Forms.Label
  Friend WithEvents LabelREPort As System.Windows.Forms.Label
  Friend WithEvents LabelPreviewPort As System.Windows.Forms.Label
  Friend WithEvents LabelSceneVersion As System.Windows.Forms.Label
  Friend WithEvents ComboBoxSceneVersion As System.Windows.Forms.ComboBox
  Friend WithEvents OpenFileDialogDataBase As OpenFileDialog
  Friend WithEvents MetroTextBoxOtherMatchesFilePath As System.Windows.Forms.TextBox
  Friend WithEvents MetroLabelOtherMatches As System.Windows.Forms.Label
  Friend WithEvents MetroButtonOtherMatchesPath As Button
  Friend WithEvents OpenFileDialogXML As OpenFileDialog
  Friend WithEvents MetroCheckBoxUseArabicNames As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroLabel2 As System.Windows.Forms.Label
  Friend WithEvents MetroTextBoxRemotePreviewPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonRemotePreviewPath As Button
  Friend WithEvents MetroLabel1 As System.Windows.Forms.Label
  Friend WithEvents MetroTextBoxLocalPreviewPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonLocalPreviewPath As Button
  Friend WithEvents MetroTextBoxDefaultColorPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroTextBoxDefaultKitsPath As System.Windows.Forms.TextBox
  Friend WithEvents MetroButtonDefaultColorsPath As Button
  Friend WithEvents MetroButtonDefaultkitsPath As Button
  Friend WithEvents MetroLabel3 As System.Windows.Forms.Label
  Friend WithEvents MetroLabel4 As System.Windows.Forms.Label
  Friend WithEvents FolderBrowserDialogPaths As FolderBrowserDialog
  Friend WithEvents TabPageLogger As TabPage
  Friend WithEvents TableLayoutPanelLogger As TableLayoutPanel
  Friend WithEvents Label3 As Label
  Friend WithEvents TextBoxLoggerHost As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents NumericUpDownLogger As NumericUpDown
  Friend WithEvents TabPage3 As TabPage
  Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
  Friend WithEvents Label1 As Label
  Friend WithEvents TextBoxOptaLocalPath As TextBox
  Friend WithEvents ButtonOptaLocalPath As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents TextBoxFTPServer As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents TextBoxFTPUser As TextBox
  Friend WithEvents TextBoxFTPPassword As TextBox
  Friend WithEvents LabelOptaCompetitionId As Label
  Friend WithEvents LabelOptaSearonId As Label
  Friend WithEvents TextBoxOptaCompetitionId As TextBox
  Friend WithEvents TextBoxOptaSeasonId As TextBox
  Friend WithEvents MetroCheckBoxOptaAutoUpdate As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroCheckBoxUseOptaData As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents TabPageSettings As MetroFramework.Controls.MetroTabPage
  Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
  Friend WithEvents MetroCheckBoxOpenPlayerDescriptionOnSelection As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroCheckBoxUseMultiLanguage As MetroFramework.Controls.MetroCheckBox
End Class
