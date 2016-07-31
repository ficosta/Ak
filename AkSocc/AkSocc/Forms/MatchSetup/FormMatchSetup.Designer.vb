<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMatchSetup
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
    Me.TableLayoutPanelGlobal = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.TabPageMatchSetup = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanelMatchInfo = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTileGeneralMatchInfo = New MetroFramework.Controls.MetroTile()
    Me.MetroLabel4 = New System.Windows.Forms.Label()
    Me.MetroTileMatchInfo = New MetroFramework.Controls.MetroTile()
    Me.MetroLabelSceneVersion = New System.Windows.Forms.Label()
    Me.MetroComboBoxSceneVersion = New System.Windows.Forms.ComboBox()
    Me.MetroTileReferees = New MetroFramework.Controls.MetroTile()
    Me.MetroLabel1 = New System.Windows.Forms.Label()
    Me.MetroLabel3 = New System.Windows.Forms.Label()
    Me.MetroComboBoxReferee1 = New System.Windows.Forms.ComboBox()
    Me.MetroComboBoxReferee2 = New System.Windows.Forms.ComboBox()
    Me.MetroComboBoxReferee3 = New System.Windows.Forms.ComboBox()
    Me.MetroLabel2 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelAwayTeam = New System.Windows.Forms.Label()
    Me.imgAwayClockColour = New System.Windows.Forms.PictureBox()
    Me.label199 = New System.Windows.Forms.Label()
    Me.lblAwayClockColour = New System.Windows.Forms.Label()
    Me.imgAwayPlayerJersey = New System.Windows.Forms.PictureBox()
    Me.imgAwayGoalKeeperJersey = New System.Windows.Forms.PictureBox()
    Me.label97 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelHomeTeam = New System.Windows.Forms.Label()
    Me.imgHomeClockColour = New System.Windows.Forms.PictureBox()
    Me.lblHomeClockColour = New System.Windows.Forms.Label()
    Me.label200 = New System.Windows.Forms.Label()
    Me.imgHomeGoalKeeperJersey = New System.Windows.Forms.PictureBox()
    Me.label198 = New System.Windows.Forms.Label()
    Me.imgHomePlayerJersey = New System.Windows.Forms.PictureBox()
    Me.TabPageHome = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupHome = New AkSocc.UCTeamMatchSetup()
    Me.TabPageAway = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupAway = New AkSocc.UCTeamMatchSetup()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.ofdSelectFile = New System.Windows.Forms.OpenFileDialog()
    Me.TableLayoutPanelGlobal.SuspendLayout()
    Me.MetroTabControl1.SuspendLayout()
    Me.TabPageMatchSetup.SuspendLayout()
    Me.TableLayoutPanelMatchInfo.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    Me.TableLayoutPanel6.SuspendLayout()
    CType(Me.imgAwayClockColour, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.imgAwayPlayerJersey, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.imgAwayGoalKeeperJersey, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.imgHomeClockColour, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.imgHomeGoalKeeperJersey, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.imgHomePlayerJersey, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPageHome.SuspendLayout()
    Me.TabPageAway.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelGlobal
    '
    Me.TableLayoutPanelGlobal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanelGlobal.ColumnCount = 1
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroTabControl1, 0, 0)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(9, 12)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 2
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(1076, 555)
    Me.TableLayoutPanelGlobal.TabIndex = 2
    '
    'MetroTabControl1
    '
    Me.MetroTabControl1.Controls.Add(Me.TabPageMatchSetup)
    Me.MetroTabControl1.Controls.Add(Me.TabPageHome)
    Me.MetroTabControl1.Controls.Add(Me.TabPageAway)
    Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTabControl1.Location = New System.Drawing.Point(3, 3)
    Me.MetroTabControl1.Name = "MetroTabControl1"
    Me.TableLayoutPanelGlobal.SetRowSpan(Me.MetroTabControl1, 2)
    Me.MetroTabControl1.SelectedIndex = 0
    Me.MetroTabControl1.Size = New System.Drawing.Size(1070, 549)
    Me.MetroTabControl1.TabIndex = 48
    Me.MetroTabControl1.UseSelectable = True
    '
    'TabPageMatchSetup
    '
    Me.TabPageMatchSetup.Controls.Add(Me.TableLayoutPanelMatchInfo)
    Me.TabPageMatchSetup.Location = New System.Drawing.Point(4, 38)
    Me.TabPageMatchSetup.Name = "TabPageMatchSetup"
    Me.TabPageMatchSetup.Size = New System.Drawing.Size(1062, 507)
    Me.TabPageMatchSetup.TabIndex = 2
    Me.TabPageMatchSetup.Text = "Match setup"
    '
    'TableLayoutPanelMatchInfo
    '
    Me.TableLayoutPanelMatchInfo.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanelMatchInfo.ColumnCount = 2
    Me.TableLayoutPanelMatchInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
    Me.TableLayoutPanelMatchInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroTileGeneralMatchInfo, 0, 0)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroLabel4, 0, 5)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroTileMatchInfo, 0, 6)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroLabelSceneVersion, 0, 7)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroComboBoxSceneVersion, 1, 7)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroTileReferees, 0, 2)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroLabel1, 0, 3)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroLabel3, 0, 4)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroComboBoxReferee1, 1, 3)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroComboBoxReferee2, 1, 4)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroComboBoxReferee3, 1, 5)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.MetroLabel2, 0, 8)
    Me.TableLayoutPanelMatchInfo.Controls.Add(Me.TableLayoutPanel4, 1, 1)
    Me.TableLayoutPanelMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelMatchInfo.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelMatchInfo.Name = "TableLayoutPanelMatchInfo"
    Me.TableLayoutPanelMatchInfo.RowCount = 13
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanelMatchInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMatchInfo.Size = New System.Drawing.Size(1062, 507)
    Me.TableLayoutPanelMatchInfo.TabIndex = 0
    '
    'MetroTileGeneralMatchInfo
    '
    Me.MetroTileGeneralMatchInfo.ActiveControl = Nothing
    Me.TableLayoutPanelMatchInfo.SetColumnSpan(Me.MetroTileGeneralMatchInfo, 2)
    Me.MetroTileGeneralMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileGeneralMatchInfo.Location = New System.Drawing.Point(3, 3)
    Me.MetroTileGeneralMatchInfo.Name = "MetroTileGeneralMatchInfo"
    Me.MetroTileGeneralMatchInfo.Size = New System.Drawing.Size(1056, 23)
    Me.MetroTileGeneralMatchInfo.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileGeneralMatchInfo.TabIndex = 13
    Me.MetroTileGeneralMatchInfo.Text = "GeneralMatchInfo"
    Me.MetroTileGeneralMatchInfo.UseSelectable = True
    '
    'MetroLabel4
    '
    Me.MetroLabel4.AutoSize = True
    Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel4.Location = New System.Drawing.Point(3, 300)
    Me.MetroLabel4.Name = "MetroLabel4"
    Me.MetroLabel4.Size = New System.Drawing.Size(227, 40)
    Me.MetroLabel4.TabIndex = 7
    Me.MetroLabel4.Text = "Assistant referee #2"
    Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTileMatchInfo
    '
    Me.MetroTileMatchInfo.ActiveControl = Nothing
    Me.TableLayoutPanelMatchInfo.SetColumnSpan(Me.MetroTileMatchInfo, 2)
    Me.MetroTileMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileMatchInfo.Location = New System.Drawing.Point(3, 343)
    Me.MetroTileMatchInfo.Name = "MetroTileMatchInfo"
    Me.MetroTileMatchInfo.Size = New System.Drawing.Size(1056, 23)
    Me.MetroTileMatchInfo.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileMatchInfo.TabIndex = 0
    Me.MetroTileMatchInfo.Text = "General match info"
    Me.MetroTileMatchInfo.UseSelectable = True
    '
    'MetroLabelSceneVersion
    '
    Me.MetroLabelSceneVersion.AutoSize = True
    Me.MetroLabelSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelSceneVersion.Location = New System.Drawing.Point(3, 369)
    Me.MetroLabelSceneVersion.Name = "MetroLabelSceneVersion"
    Me.MetroLabelSceneVersion.Size = New System.Drawing.Size(227, 40)
    Me.MetroLabelSceneVersion.TabIndex = 1
    Me.MetroLabelSceneVersion.Text = "Scene version"
    Me.MetroLabelSceneVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.MetroLabelSceneVersion.Visible = False
    '
    'MetroComboBoxSceneVersion
    '
    Me.MetroComboBoxSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxSceneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.MetroComboBoxSceneVersion.FormattingEnabled = True
    Me.MetroComboBoxSceneVersion.ItemHeight = 15
    Me.MetroComboBoxSceneVersion.Items.AddRange(New Object() {"Saudi league", "Cup"})
    Me.MetroComboBoxSceneVersion.Location = New System.Drawing.Point(236, 372)
    Me.MetroComboBoxSceneVersion.Name = "MetroComboBoxSceneVersion"
    Me.MetroComboBoxSceneVersion.Size = New System.Drawing.Size(823, 23)
    Me.MetroComboBoxSceneVersion.TabIndex = 2
    Me.MetroComboBoxSceneVersion.Visible = False
    '
    'MetroTileReferees
    '
    Me.MetroTileReferees.ActiveControl = Nothing
    Me.TableLayoutPanelMatchInfo.SetColumnSpan(Me.MetroTileReferees, 2)
    Me.MetroTileReferees.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileReferees.Location = New System.Drawing.Point(3, 194)
    Me.MetroTileReferees.Name = "MetroTileReferees"
    Me.MetroTileReferees.Size = New System.Drawing.Size(1056, 23)
    Me.MetroTileReferees.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileReferees.TabIndex = 3
    Me.MetroTileReferees.Text = "Referees"
    Me.MetroTileReferees.UseSelectable = True
    '
    'MetroLabel1
    '
    Me.MetroLabel1.AutoSize = True
    Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel1.Location = New System.Drawing.Point(3, 220)
    Me.MetroLabel1.Name = "MetroLabel1"
    Me.MetroLabel1.Size = New System.Drawing.Size(227, 40)
    Me.MetroLabel1.TabIndex = 4
    Me.MetroLabel1.Text = "Main referee"
    Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroLabel3
    '
    Me.MetroLabel3.AutoSize = True
    Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel3.Location = New System.Drawing.Point(3, 260)
    Me.MetroLabel3.Name = "MetroLabel3"
    Me.MetroLabel3.Size = New System.Drawing.Size(227, 40)
    Me.MetroLabel3.TabIndex = 6
    Me.MetroLabel3.Text = "Assistant referee #1"
    Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroComboBoxReferee1
    '
    Me.MetroComboBoxReferee1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.MetroComboBoxReferee1.FormattingEnabled = True
    Me.MetroComboBoxReferee1.ItemHeight = 15
    Me.MetroComboBoxReferee1.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee1.Location = New System.Drawing.Point(236, 223)
    Me.MetroComboBoxReferee1.Name = "MetroComboBoxReferee1"
    Me.MetroComboBoxReferee1.Size = New System.Drawing.Size(823, 23)
    Me.MetroComboBoxReferee1.TabIndex = 8
    '
    'MetroComboBoxReferee2
    '
    Me.MetroComboBoxReferee2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.MetroComboBoxReferee2.FormattingEnabled = True
    Me.MetroComboBoxReferee2.ItemHeight = 15
    Me.MetroComboBoxReferee2.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee2.Location = New System.Drawing.Point(236, 263)
    Me.MetroComboBoxReferee2.Name = "MetroComboBoxReferee2"
    Me.MetroComboBoxReferee2.Size = New System.Drawing.Size(823, 23)
    Me.MetroComboBoxReferee2.TabIndex = 9
    '
    'MetroComboBoxReferee3
    '
    Me.MetroComboBoxReferee3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.MetroComboBoxReferee3.FormattingEnabled = True
    Me.MetroComboBoxReferee3.ItemHeight = 15
    Me.MetroComboBoxReferee3.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee3.Location = New System.Drawing.Point(236, 303)
    Me.MetroComboBoxReferee3.Name = "MetroComboBoxReferee3"
    Me.MetroComboBoxReferee3.Size = New System.Drawing.Size(823, 23)
    Me.MetroComboBoxReferee3.TabIndex = 10
    '
    'MetroLabel2
    '
    Me.MetroLabel2.AutoSize = True
    Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel2.Location = New System.Drawing.Point(3, 409)
    Me.MetroLabel2.Name = "MetroLabel2"
    Me.MetroLabel2.Size = New System.Drawing.Size(227, 40)
    Me.MetroLabel2.TabIndex = 11
    Me.MetroLabel2.Text = "On air clocks position"
    Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.MetroLabel2.Visible = False
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.ColumnCount = 2
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 0, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(236, 32)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(823, 156)
    Me.TableLayoutPanel4.TabIndex = 14
    '
    'TableLayoutPanel6
    '
    Me.TableLayoutPanel6.ColumnCount = 5
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel6.Controls.Add(Me.MetroLabelAwayTeam, 0, 0)
    Me.TableLayoutPanel6.Controls.Add(Me.imgAwayClockColour, 1, 1)
    Me.TableLayoutPanel6.Controls.Add(Me.label199, 3, 2)
    Me.TableLayoutPanel6.Controls.Add(Me.lblAwayClockColour, 1, 2)
    Me.TableLayoutPanel6.Controls.Add(Me.imgAwayPlayerJersey, 3, 1)
    Me.TableLayoutPanel6.Controls.Add(Me.imgAwayGoalKeeperJersey, 2, 1)
    Me.TableLayoutPanel6.Controls.Add(Me.label97, 2, 2)
    Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel6.Location = New System.Drawing.Point(414, 3)
    Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
    Me.TableLayoutPanel6.RowCount = 3
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel6.Size = New System.Drawing.Size(406, 150)
    Me.TableLayoutPanel6.TabIndex = 3
    '
    'MetroLabelAwayTeam
    '
    Me.MetroLabelAwayTeam.AutoSize = True
    Me.MetroLabelAwayTeam.BackColor = System.Drawing.Color.Silver
    Me.TableLayoutPanel6.SetColumnSpan(Me.MetroLabelAwayTeam, 5)
    Me.MetroLabelAwayTeam.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelAwayTeam.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelAwayTeam.Name = "MetroLabelAwayTeam"
    Me.MetroLabelAwayTeam.Size = New System.Drawing.Size(400, 29)
    Me.MetroLabelAwayTeam.TabIndex = 3
    Me.MetroLabelAwayTeam.Text = "AWAY TEAM"
    Me.MetroLabelAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'imgAwayClockColour
    '
    Me.imgAwayClockColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgAwayClockColour.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgAwayClockColour.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgAwayClockColour.Location = New System.Drawing.Point(14, 32)
    Me.imgAwayClockColour.Name = "imgAwayClockColour"
    Me.imgAwayClockColour.Size = New System.Drawing.Size(122, 63)
    Me.imgAwayClockColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgAwayClockColour.TabIndex = 0
    Me.imgAwayClockColour.TabStop = False
    '
    'label199
    '
    Me.label199.AutoSize = True
    Me.label199.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label199.Location = New System.Drawing.Point(270, 98)
    Me.label199.Name = "label199"
    Me.label199.Size = New System.Drawing.Size(122, 52)
    Me.label199.TabIndex = 85
    Me.label199.Text = "Player Jersey"
    Me.label199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblAwayClockColour
    '
    Me.lblAwayClockColour.AutoSize = True
    Me.lblAwayClockColour.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblAwayClockColour.Location = New System.Drawing.Point(14, 98)
    Me.lblAwayClockColour.Name = "lblAwayClockColour"
    Me.lblAwayClockColour.Size = New System.Drawing.Size(122, 52)
    Me.lblAwayClockColour.TabIndex = 78
    Me.lblAwayClockColour.Text = "Clock Colour"
    Me.lblAwayClockColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'imgAwayPlayerJersey
    '
    Me.imgAwayPlayerJersey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgAwayPlayerJersey.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgAwayPlayerJersey.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgAwayPlayerJersey.Location = New System.Drawing.Point(270, 32)
    Me.imgAwayPlayerJersey.Name = "imgAwayPlayerJersey"
    Me.imgAwayPlayerJersey.Size = New System.Drawing.Size(122, 63)
    Me.imgAwayPlayerJersey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgAwayPlayerJersey.TabIndex = 83
    Me.imgAwayPlayerJersey.TabStop = False
    '
    'imgAwayGoalKeeperJersey
    '
    Me.imgAwayGoalKeeperJersey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgAwayGoalKeeperJersey.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgAwayGoalKeeperJersey.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgAwayGoalKeeperJersey.Location = New System.Drawing.Point(142, 32)
    Me.imgAwayGoalKeeperJersey.Name = "imgAwayGoalKeeperJersey"
    Me.imgAwayGoalKeeperJersey.Size = New System.Drawing.Size(122, 63)
    Me.imgAwayGoalKeeperJersey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgAwayGoalKeeperJersey.TabIndex = 79
    Me.imgAwayGoalKeeperJersey.TabStop = False
    '
    'label97
    '
    Me.label97.AutoSize = True
    Me.label97.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label97.Location = New System.Drawing.Point(142, 98)
    Me.label97.Name = "label97"
    Me.label97.Size = New System.Drawing.Size(122, 52)
    Me.label97.TabIndex = 81
    Me.label97.Text = "Goal Keeper Jersey"
    Me.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 5
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabelHomeTeam, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.imgHomeClockColour, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.lblHomeClockColour, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.label200, 3, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.imgHomeGoalKeeperJersey, 2, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.label198, 2, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.imgHomePlayerJersey, 3, 1)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 3
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(405, 150)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'MetroLabelHomeTeam
    '
    Me.MetroLabelHomeTeam.AutoSize = True
    Me.MetroLabelHomeTeam.BackColor = System.Drawing.Color.Silver
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroLabelHomeTeam, 5)
    Me.MetroLabelHomeTeam.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelHomeTeam.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelHomeTeam.Name = "MetroLabelHomeTeam"
    Me.MetroLabelHomeTeam.Size = New System.Drawing.Size(399, 29)
    Me.MetroLabelHomeTeam.TabIndex = 1
    Me.MetroLabelHomeTeam.Text = "HOME TEAM"
    Me.MetroLabelHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'imgHomeClockColour
    '
    Me.imgHomeClockColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgHomeClockColour.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgHomeClockColour.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgHomeClockColour.Location = New System.Drawing.Point(13, 32)
    Me.imgHomeClockColour.Name = "imgHomeClockColour"
    Me.imgHomeClockColour.Size = New System.Drawing.Size(122, 63)
    Me.imgHomeClockColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgHomeClockColour.TabIndex = 0
    Me.imgHomeClockColour.TabStop = False
    '
    'lblHomeClockColour
    '
    Me.lblHomeClockColour.AutoSize = True
    Me.lblHomeClockColour.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblHomeClockColour.Location = New System.Drawing.Point(13, 98)
    Me.lblHomeClockColour.Name = "lblHomeClockColour"
    Me.lblHomeClockColour.Size = New System.Drawing.Size(122, 52)
    Me.lblHomeClockColour.TabIndex = 78
    Me.lblHomeClockColour.Text = "Clock Colour"
    Me.lblHomeClockColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label200
    '
    Me.label200.AutoSize = True
    Me.label200.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label200.Location = New System.Drawing.Point(269, 98)
    Me.label200.Name = "label200"
    Me.label200.Size = New System.Drawing.Size(122, 52)
    Me.label200.TabIndex = 86
    Me.label200.Text = "Player Jersey"
    Me.label200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'imgHomeGoalKeeperJersey
    '
    Me.imgHomeGoalKeeperJersey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgHomeGoalKeeperJersey.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgHomeGoalKeeperJersey.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgHomeGoalKeeperJersey.Location = New System.Drawing.Point(141, 32)
    Me.imgHomeGoalKeeperJersey.Name = "imgHomeGoalKeeperJersey"
    Me.imgHomeGoalKeeperJersey.Size = New System.Drawing.Size(122, 63)
    Me.imgHomeGoalKeeperJersey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgHomeGoalKeeperJersey.TabIndex = 80
    Me.imgHomeGoalKeeperJersey.TabStop = False
    '
    'label198
    '
    Me.label198.AutoSize = True
    Me.label198.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label198.Location = New System.Drawing.Point(141, 98)
    Me.label198.Name = "label198"
    Me.label198.Size = New System.Drawing.Size(122, 52)
    Me.label198.TabIndex = 82
    Me.label198.Text = "Goal Keeper Jersey"
    Me.label198.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'imgHomePlayerJersey
    '
    Me.imgHomePlayerJersey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.imgHomePlayerJersey.Cursor = System.Windows.Forms.Cursors.Hand
    Me.imgHomePlayerJersey.Dock = System.Windows.Forms.DockStyle.Fill
    Me.imgHomePlayerJersey.Location = New System.Drawing.Point(269, 32)
    Me.imgHomePlayerJersey.Name = "imgHomePlayerJersey"
    Me.imgHomePlayerJersey.Size = New System.Drawing.Size(122, 63)
    Me.imgHomePlayerJersey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.imgHomePlayerJersey.TabIndex = 84
    Me.imgHomePlayerJersey.TabStop = False
    '
    'TabPageHome
    '
    Me.TabPageHome.Controls.Add(Me.UcTeamMatchSetupHome)
    Me.TabPageHome.Location = New System.Drawing.Point(4, 38)
    Me.TabPageHome.Name = "TabPageHome"
    Me.TabPageHome.Size = New System.Drawing.Size(1062, 507)
    Me.TabPageHome.TabIndex = 0
    Me.TabPageHome.Text = "Home team"
    '
    'UcTeamMatchSetupHome
    '
    Me.UcTeamMatchSetupHome.Color = System.Drawing.Color.AliceBlue
    Me.UcTeamMatchSetupHome.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcTeamMatchSetupHome.IsLocalTeam = True
    Me.UcTeamMatchSetupHome.Location = New System.Drawing.Point(0, 0)
    Me.UcTeamMatchSetupHome.Name = "UcTeamMatchSetupHome"
    Me.UcTeamMatchSetupHome.Size = New System.Drawing.Size(1062, 507)
    Me.UcTeamMatchSetupHome.TabIndex = 0
    Me.UcTeamMatchSetupHome.Tactic = Nothing
    Me.UcTeamMatchSetupHome.Team = Nothing
    '
    'TabPageAway
    '
    Me.TabPageAway.Controls.Add(Me.UcTeamMatchSetupAway)
    Me.TabPageAway.Location = New System.Drawing.Point(4, 38)
    Me.TabPageAway.Name = "TabPageAway"
    Me.TabPageAway.Size = New System.Drawing.Size(1062, 507)
    Me.TabPageAway.TabIndex = 1
    Me.TabPageAway.Text = "Away team"
    '
    'UcTeamMatchSetupAway
    '
    Me.UcTeamMatchSetupAway.Color = System.Drawing.Color.AliceBlue
    Me.UcTeamMatchSetupAway.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcTeamMatchSetupAway.IsLocalTeam = True
    Me.UcTeamMatchSetupAway.Location = New System.Drawing.Point(0, 0)
    Me.UcTeamMatchSetupAway.Name = "UcTeamMatchSetupAway"
    Me.UcTeamMatchSetupAway.Size = New System.Drawing.Size(1062, 507)
    Me.UcTeamMatchSetupAway.TabIndex = 0
    Me.UcTeamMatchSetupAway.Tactic = Nothing
    Me.UcTeamMatchSetupAway.Team = Nothing
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(906, 573)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(78, 27)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(88, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(78, 27)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'ofdSelectFile
    '
    Me.ofdSelectFile.FileName = "OpenFileDialog1"
    '
    'FormMatchSetup
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(1103, 633)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanelGlobal)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "FormMatchSetup"
    Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Match setup"
    Me.TableLayoutPanelGlobal.ResumeLayout(False)
    Me.MetroTabControl1.ResumeLayout(False)
    Me.TabPageMatchSetup.ResumeLayout(False)
    Me.TableLayoutPanelMatchInfo.ResumeLayout(False)
    Me.TableLayoutPanelMatchInfo.PerformLayout()
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.TableLayoutPanel6.ResumeLayout(False)
    Me.TableLayoutPanel6.PerformLayout()
    CType(Me.imgAwayClockColour, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.imgAwayPlayerJersey, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.imgAwayGoalKeeperJersey, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    CType(Me.imgHomeClockColour, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.imgHomeGoalKeeperJersey, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.imgHomePlayerJersey, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPageHome.ResumeLayout(False)
    Me.TabPageAway.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
  Friend WithEvents TabPageHome As TabPage
  Friend WithEvents TabPageAway As TabPage
  Friend WithEvents UcTeamMatchSetupHome As UCTeamMatchSetup
  Friend WithEvents UcTeamMatchSetupAway As UCTeamMatchSetup
  Friend WithEvents TabPageMatchSetup As TabPage
  Friend WithEvents TableLayoutPanelMatchInfo As TableLayoutPanel
  Friend WithEvents MetroTileMatchInfo As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroLabelSceneVersion As System.Windows.Forms.Label
  Friend WithEvents MetroComboBoxSceneVersion As System.Windows.Forms.ComboBox
  Friend WithEvents MetroTileReferees As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroLabel1 As System.Windows.Forms.Label
  Friend WithEvents MetroLabel3 As System.Windows.Forms.Label
  Friend WithEvents MetroLabel4 As System.Windows.Forms.Label
  Friend WithEvents MetroComboBoxReferee1 As System.Windows.Forms.ComboBox
  Friend WithEvents MetroComboBoxReferee2 As System.Windows.Forms.ComboBox
  Friend WithEvents MetroComboBoxReferee3 As System.Windows.Forms.ComboBox
  Friend WithEvents MetroLabel2 As System.Windows.Forms.Label
  Friend WithEvents MetroTileGeneralMatchInfo As MetroFramework.Controls.MetroTile
  Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
  Private WithEvents label199 As Label
  Private WithEvents label200 As Label
  Private WithEvents imgAwayPlayerJersey As PictureBox
  Private WithEvents imgHomePlayerJersey As PictureBox
  Private WithEvents label97 As Label
  Private WithEvents label198 As Label
  Private WithEvents imgAwayGoalKeeperJersey As PictureBox
  Private WithEvents imgHomeGoalKeeperJersey As PictureBox
  Private WithEvents lblAwayClockColour As Label
  Private WithEvents lblHomeClockColour As Label
  Private WithEvents imgAwayClockColour As PictureBox
  Private WithEvents imgHomeClockColour As PictureBox
  Friend WithEvents ofdSelectFile As OpenFileDialog
  Friend WithEvents MetroLabelAwayTeam As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents MetroLabelHomeTeam As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
End Class
