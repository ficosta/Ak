<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMatchSetup
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
    Me.TableLayoutPanelGlobal = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.TabPageMatchSetup = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTileGeneralMatchInfo = New MetroFramework.Controls.MetroTile()
    Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
    Me.MetroTileMatchInfo = New MetroFramework.Controls.MetroTile()
    Me.MetroLabelSceneVersion = New MetroFramework.Controls.MetroLabel()
    Me.MetroComboBoxSceneVersion = New MetroFramework.Controls.MetroComboBox()
    Me.MetroTileReferees = New MetroFramework.Controls.MetroTile()
    Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
    Me.MetroComboBoxReferee1 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxReferee2 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxReferee3 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBoxClockUp = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockLeft = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockRight = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockDown = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelAwayTeam = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabelHomeTeam = New MetroFramework.Controls.MetroLabel()
    Me.TabPageHome = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupHome = New AkSocc.UCTeamMatchSetup()
    Me.TabPageAway = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupAway = New AkSocc.UCTeamMatchSetup()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.TableLayoutPanelGlobal.SuspendLayout()
    Me.MetroTabControl1.SuspendLayout()
    Me.TabPageMatchSetup.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    CType(Me.PictureBoxClockUp, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockLeft, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockRight, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockDown, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel4.SuspendLayout()
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
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroTabControl1, 0, 0)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(8, 64)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 2
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(1357, 530)
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
    Me.MetroTabControl1.Size = New System.Drawing.Size(1351, 524)
    Me.MetroTabControl1.TabIndex = 48
    Me.MetroTabControl1.UseSelectable = True
    '
    'TabPageMatchSetup
    '
    Me.TabPageMatchSetup.Controls.Add(Me.TableLayoutPanel2)
    Me.TabPageMatchSetup.Location = New System.Drawing.Point(4, 38)
    Me.TabPageMatchSetup.Name = "TabPageMatchSetup"
    Me.TabPageMatchSetup.Size = New System.Drawing.Size(1343, 482)
    Me.TabPageMatchSetup.TabIndex = 2
    Me.TabPageMatchSetup.Text = "Match setup"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileGeneralMatchInfo, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel4, 0, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileMatchInfo, 0, 6)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabelSceneVersion, 0, 7)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxSceneVersion, 1, 7)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileReferees, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel1, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel3, 0, 4)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee1, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee2, 1, 4)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee3, 1, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel2, 0, 8)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 8)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 1)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 13
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(1343, 482)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'MetroTileGeneralMatchInfo
    '
    Me.MetroTileGeneralMatchInfo.ActiveControl = Nothing
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroTileGeneralMatchInfo, 2)
    Me.MetroTileGeneralMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileGeneralMatchInfo.Location = New System.Drawing.Point(3, 3)
    Me.MetroTileGeneralMatchInfo.Name = "MetroTileGeneralMatchInfo"
    Me.MetroTileGeneralMatchInfo.Size = New System.Drawing.Size(1337, 19)
    Me.MetroTileGeneralMatchInfo.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileGeneralMatchInfo.TabIndex = 13
    Me.MetroTileGeneralMatchInfo.Text = "GeneralMatchInfo"
    Me.MetroTileGeneralMatchInfo.UseSelectable = True
    '
    'MetroLabel4
    '
    Me.MetroLabel4.AutoSize = True
    Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel4.Location = New System.Drawing.Point(3, 155)
    Me.MetroLabel4.Name = "MetroLabel4"
    Me.MetroLabel4.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel4.TabIndex = 7
    Me.MetroLabel4.Text = "Assistant referee #2"
    Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTileMatchInfo
    '
    Me.MetroTileMatchInfo.ActiveControl = Nothing
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroTileMatchInfo, 2)
    Me.MetroTileMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileMatchInfo.Location = New System.Drawing.Point(3, 193)
    Me.MetroTileMatchInfo.Name = "MetroTileMatchInfo"
    Me.MetroTileMatchInfo.Size = New System.Drawing.Size(1337, 19)
    Me.MetroTileMatchInfo.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileMatchInfo.TabIndex = 0
    Me.MetroTileMatchInfo.Text = "General match info"
    Me.MetroTileMatchInfo.UseSelectable = True
    '
    'MetroLabelSceneVersion
    '
    Me.MetroLabelSceneVersion.AutoSize = True
    Me.MetroLabelSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelSceneVersion.Location = New System.Drawing.Point(3, 215)
    Me.MetroLabelSceneVersion.Name = "MetroLabelSceneVersion"
    Me.MetroLabelSceneVersion.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabelSceneVersion.TabIndex = 1
    Me.MetroLabelSceneVersion.Text = "Scene version"
    Me.MetroLabelSceneVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroComboBoxSceneVersion
    '
    Me.MetroComboBoxSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxSceneVersion.FormattingEnabled = True
    Me.MetroComboBoxSceneVersion.ItemHeight = 23
    Me.MetroComboBoxSceneVersion.Items.AddRange(New Object() {"Saudi league", "Cup"})
    Me.MetroComboBoxSceneVersion.Location = New System.Drawing.Point(203, 218)
    Me.MetroComboBoxSceneVersion.Name = "MetroComboBoxSceneVersion"
    Me.MetroComboBoxSceneVersion.Size = New System.Drawing.Size(1137, 29)
    Me.MetroComboBoxSceneVersion.TabIndex = 2
    Me.MetroComboBoxSceneVersion.UseSelectable = True
    '
    'MetroTileReferees
    '
    Me.MetroTileReferees.ActiveControl = Nothing
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroTileReferees, 2)
    Me.MetroTileReferees.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileReferees.Location = New System.Drawing.Point(3, 63)
    Me.MetroTileReferees.Name = "MetroTileReferees"
    Me.MetroTileReferees.Size = New System.Drawing.Size(1337, 19)
    Me.MetroTileReferees.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileReferees.TabIndex = 3
    Me.MetroTileReferees.Text = "Referees"
    Me.MetroTileReferees.UseSelectable = True
    '
    'MetroLabel1
    '
    Me.MetroLabel1.AutoSize = True
    Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel1.Location = New System.Drawing.Point(3, 85)
    Me.MetroLabel1.Name = "MetroLabel1"
    Me.MetroLabel1.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel1.TabIndex = 4
    Me.MetroLabel1.Text = "Main referee"
    Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroLabel3
    '
    Me.MetroLabel3.AutoSize = True
    Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel3.Location = New System.Drawing.Point(3, 120)
    Me.MetroLabel3.Name = "MetroLabel3"
    Me.MetroLabel3.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel3.TabIndex = 6
    Me.MetroLabel3.Text = "Assistant referee #1"
    Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroComboBoxReferee1
    '
    Me.MetroComboBoxReferee1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee1.FormattingEnabled = True
    Me.MetroComboBoxReferee1.ItemHeight = 23
    Me.MetroComboBoxReferee1.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee1.Location = New System.Drawing.Point(203, 88)
    Me.MetroComboBoxReferee1.Name = "MetroComboBoxReferee1"
    Me.MetroComboBoxReferee1.Size = New System.Drawing.Size(1137, 29)
    Me.MetroComboBoxReferee1.TabIndex = 8
    Me.MetroComboBoxReferee1.UseSelectable = True
    '
    'MetroComboBoxReferee2
    '
    Me.MetroComboBoxReferee2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee2.FormattingEnabled = True
    Me.MetroComboBoxReferee2.ItemHeight = 23
    Me.MetroComboBoxReferee2.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee2.Location = New System.Drawing.Point(203, 123)
    Me.MetroComboBoxReferee2.Name = "MetroComboBoxReferee2"
    Me.MetroComboBoxReferee2.Size = New System.Drawing.Size(1137, 29)
    Me.MetroComboBoxReferee2.TabIndex = 9
    Me.MetroComboBoxReferee2.UseSelectable = True
    '
    'MetroComboBoxReferee3
    '
    Me.MetroComboBoxReferee3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee3.FormattingEnabled = True
    Me.MetroComboBoxReferee3.ItemHeight = 23
    Me.MetroComboBoxReferee3.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee3.Location = New System.Drawing.Point(203, 158)
    Me.MetroComboBoxReferee3.Name = "MetroComboBoxReferee3"
    Me.MetroComboBoxReferee3.Size = New System.Drawing.Size(1137, 29)
    Me.MetroComboBoxReferee3.TabIndex = 10
    Me.MetroComboBoxReferee3.UseSelectable = True
    '
    'MetroLabel2
    '
    Me.MetroLabel2.AutoSize = True
    Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel2.Location = New System.Drawing.Point(3, 250)
    Me.MetroLabel2.Name = "MetroLabel2"
    Me.MetroLabel2.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel2.TabIndex = 11
    Me.MetroLabel2.Text = "On air clocks position"
    Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.MetroLabel2.Visible = False
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.PictureBoxClockUp, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.PictureBoxClockLeft, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.PictureBoxClockRight, 2, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.PictureBoxClockDown, 1, 2)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(203, 253)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 4
    Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel3, 2)
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(1137, 179)
    Me.TableLayoutPanel3.TabIndex = 12
    Me.TableLayoutPanel3.Visible = False
    '
    'PictureBoxClockUp
    '
    Me.PictureBoxClockUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxClockUp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxClockUp.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_up
    Me.PictureBoxClockUp.Location = New System.Drawing.Point(53, 3)
    Me.PictureBoxClockUp.Name = "PictureBoxClockUp"
    Me.PictureBoxClockUp.Size = New System.Drawing.Size(44, 44)
    Me.PictureBoxClockUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxClockUp.TabIndex = 0
    Me.PictureBoxClockUp.TabStop = False
    '
    'PictureBoxClockLeft
    '
    Me.PictureBoxClockLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxClockLeft.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxClockLeft.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.PictureBoxClockLeft.Location = New System.Drawing.Point(3, 53)
    Me.PictureBoxClockLeft.Name = "PictureBoxClockLeft"
    Me.PictureBoxClockLeft.Size = New System.Drawing.Size(44, 44)
    Me.PictureBoxClockLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxClockLeft.TabIndex = 1
    Me.PictureBoxClockLeft.TabStop = False
    '
    'PictureBoxClockRight
    '
    Me.PictureBoxClockRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxClockRight.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxClockRight.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_right
    Me.PictureBoxClockRight.Location = New System.Drawing.Point(103, 53)
    Me.PictureBoxClockRight.Name = "PictureBoxClockRight"
    Me.PictureBoxClockRight.Size = New System.Drawing.Size(44, 44)
    Me.PictureBoxClockRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxClockRight.TabIndex = 2
    Me.PictureBoxClockRight.TabStop = False
    '
    'PictureBoxClockDown
    '
    Me.PictureBoxClockDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxClockDown.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxClockDown.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_down
    Me.PictureBoxClockDown.Location = New System.Drawing.Point(53, 103)
    Me.PictureBoxClockDown.Name = "PictureBoxClockDown"
    Me.PictureBoxClockDown.Size = New System.Drawing.Size(44, 44)
    Me.PictureBoxClockDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxClockDown.TabIndex = 3
    Me.PictureBoxClockDown.TabStop = False
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.ColumnCount = 3
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel4.Controls.Add(Me.MetroLabelAwayTeam, 1, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.MetroLabelHomeTeam, 0, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(203, 28)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(1137, 29)
    Me.TableLayoutPanel4.TabIndex = 14
    '
    'MetroLabelAwayTeam
    '
    Me.MetroLabelAwayTeam.AutoSize = True
    Me.MetroLabelAwayTeam.Location = New System.Drawing.Point(382, 0)
    Me.MetroLabelAwayTeam.Name = "MetroLabelAwayTeam"
    Me.MetroLabelAwayTeam.Size = New System.Drawing.Size(87, 19)
    Me.MetroLabelAwayTeam.TabIndex = 1
    Me.MetroLabelAwayTeam.Text = "AWAY TEAM"
    '
    'MetroLabelHomeTeam
    '
    Me.MetroLabelHomeTeam.AutoSize = True
    Me.MetroLabelHomeTeam.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelHomeTeam.Name = "MetroLabelHomeTeam"
    Me.MetroLabelHomeTeam.Size = New System.Drawing.Size(87, 19)
    Me.MetroLabelHomeTeam.TabIndex = 0
    Me.MetroLabelHomeTeam.Text = "HOME TEAM"
    '
    'TabPageHome
    '
    Me.TabPageHome.Controls.Add(Me.UcTeamMatchSetupHome)
    Me.TabPageHome.Location = New System.Drawing.Point(4, 38)
    Me.TabPageHome.Name = "TabPageHome"
    Me.TabPageHome.Size = New System.Drawing.Size(931, 482)
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
    Me.UcTeamMatchSetupHome.Size = New System.Drawing.Size(931, 482)
    Me.UcTeamMatchSetupHome.TabIndex = 0
    Me.UcTeamMatchSetupHome.Tactic = Nothing
    Me.UcTeamMatchSetupHome.Team = Nothing
    '
    'TabPageAway
    '
    Me.TabPageAway.Controls.Add(Me.UcTeamMatchSetupAway)
    Me.TabPageAway.Location = New System.Drawing.Point(4, 38)
    Me.TabPageAway.Name = "TabPageAway"
    Me.TabPageAway.Size = New System.Drawing.Size(931, 482)
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
    Me.UcTeamMatchSetupAway.Size = New System.Drawing.Size(931, 482)
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(1219, 600)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.UseSelectable = True
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
    '
    'FormMatchSetup
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1388, 652)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanelGlobal)
    Me.Name = "FormMatchSetup"
    Me.Style = MetroFramework.MetroColorStyle.Orange
    Me.Text = "Match setup"
    Me.TableLayoutPanelGlobal.ResumeLayout(False)
    Me.MetroTabControl1.ResumeLayout(False)
    Me.TabPageMatchSetup.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    CType(Me.PictureBoxClockUp, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockLeft, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockRight, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockDown, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.TableLayoutPanel4.PerformLayout()
    Me.TabPageHome.ResumeLayout(False)
    Me.TabPageAway.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
  Friend WithEvents TabPageHome As TabPage
  Friend WithEvents TabPageAway As TabPage
  Friend WithEvents UcTeamMatchSetupHome As UCTeamMatchSetup
  Friend WithEvents UcTeamMatchSetupAway As UCTeamMatchSetup
  Friend WithEvents TabPageMatchSetup As TabPage
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents MetroTileMatchInfo As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroLabelSceneVersion As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroComboBoxSceneVersion As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroTileReferees As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroComboBoxReferee1 As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroComboBoxReferee2 As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroComboBoxReferee3 As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents PictureBoxClockUp As PictureBox
  Friend WithEvents PictureBoxClockLeft As PictureBox
  Friend WithEvents PictureBoxClockRight As PictureBox
  Friend WithEvents PictureBoxClockDown As PictureBox
  Friend WithEvents MetroTileGeneralMatchInfo As MetroFramework.Controls.MetroTile
  Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
  Friend WithEvents MetroLabelAwayTeam As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroLabelHomeTeam As MetroFramework.Controls.MetroLabel
End Class
