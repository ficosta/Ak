<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatchSetup
  Inherits MetroFramework.Forms.MetroForm

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelGlobal = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridMatches = New MetroFramework.Controls.MetroGrid()
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cboCompetition = New MetroFramework.Controls.MetroComboBox()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.TabPageMatchSetup = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTileMatchInfo = New MetroFramework.Controls.MetroTile()
    Me.MetroLabelSceneVersion = New MetroFramework.Controls.MetroLabel()
    Me.MetroComboBoxSceneVersion = New MetroFramework.Controls.MetroComboBox()
    Me.MetroTileReferees = New MetroFramework.Controls.MetroTile()
    Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
    Me.MetroComboBoxReferee1 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxReferee2 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxReferee3 = New MetroFramework.Controls.MetroComboBox()
    Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBoxClockUp = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockLeft = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockRight = New System.Windows.Forms.PictureBox()
    Me.PictureBoxClockDown = New System.Windows.Forms.PictureBox()
    Me.TabPageHome = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupHome = New AkSocc.UCTeamMatchSetup()
    Me.TabPageAway = New System.Windows.Forms.TabPage()
    Me.UcTeamMatchSetupAway = New AkSocc.UCTeamMatchSetup()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.TableLayoutPanelGlobal.SuspendLayout()
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MetroTabControl1.SuspendLayout()
    Me.TabPageMatchSetup.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    CType(Me.PictureBoxClockUp, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockLeft, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockRight, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBoxClockDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanelGlobal.ColumnCount = 2
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.36876!))
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.63123!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroGridMatches, 0, 1)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.cboCompetition, 0, 0)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroTabControl1, 1, 0)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(8, 64)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 2
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(1357, 530)
    Me.TableLayoutPanelGlobal.TabIndex = 2
    '
    'MetroGridMatches
    '
    Me.MetroGridMatches.AllowUserToAddRows = False
    Me.MetroGridMatches.AllowUserToDeleteRows = False
    Me.MetroGridMatches.AllowUserToResizeColumns = False
    Me.MetroGridMatches.AllowUserToResizeRows = False
    Me.MetroGridMatches.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatches.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridMatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColumnDate, Me.ColumnDescription, Me.ColumnResult})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatches.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridMatches.EnableHeadersVisualStyles = False
    Me.MetroGridMatches.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatches.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatches.Location = New System.Drawing.Point(3, 38)
    Me.MetroGridMatches.MultiSelect = False
    Me.MetroGridMatches.Name = "MetroGridMatches"
    Me.MetroGridMatches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridMatches.RowHeadersWidth = 10
    Me.MetroGridMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatches.ShowCellErrors = False
    Me.MetroGridMatches.ShowCellToolTips = False
    Me.MetroGridMatches.ShowEditingIcon = False
    Me.MetroGridMatches.ShowRowErrors = False
    Me.MetroGridMatches.Size = New System.Drawing.Size(406, 489)
    Me.MetroGridMatches.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroGridMatches.TabIndex = 47
    '
    'Column1
    '
    Me.Column1.HeaderText = "ColumnID"
    Me.Column1.Name = "Column1"
    Me.Column1.Visible = False
    Me.Column1.Width = 60
    '
    'ColumnDate
    '
    Me.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDate.HeaderText = "Date"
    Me.ColumnDate.Name = "ColumnDate"
    Me.ColumnDate.Width = 64
    '
    'ColumnDescription
    '
    Me.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDescription.HeaderText = "Description"
    Me.ColumnDescription.Name = "ColumnDescription"
    Me.ColumnDescription.Width = 108
    '
    'ColumnResult
    '
    Me.ColumnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnResult.HeaderText = "Result"
    Me.ColumnResult.Name = "ColumnResult"
    '
    'cboCompetition
    '
    Me.cboCompetition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cboCompetition.FormattingEnabled = True
    Me.cboCompetition.ItemHeight = 23
    Me.cboCompetition.Location = New System.Drawing.Point(3, 3)
    Me.cboCompetition.Name = "cboCompetition"
    Me.cboCompetition.Size = New System.Drawing.Size(406, 29)
    Me.cboCompetition.TabIndex = 1
    Me.cboCompetition.UseSelectable = True
    '
    'MetroTabControl1
    '
    Me.MetroTabControl1.Controls.Add(Me.TabPageMatchSetup)
    Me.MetroTabControl1.Controls.Add(Me.TabPageHome)
    Me.MetroTabControl1.Controls.Add(Me.TabPageAway)
    Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTabControl1.Location = New System.Drawing.Point(415, 3)
    Me.MetroTabControl1.Name = "MetroTabControl1"
    Me.TableLayoutPanelGlobal.SetRowSpan(Me.MetroTabControl1, 2)
    Me.MetroTabControl1.SelectedIndex = 0
    Me.MetroTabControl1.Size = New System.Drawing.Size(939, 524)
    Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTabControl1.TabIndex = 48
    Me.MetroTabControl1.UseSelectable = True
    '
    'TabPageMatchSetup
    '
    Me.TabPageMatchSetup.Controls.Add(Me.TableLayoutPanel2)
    Me.TabPageMatchSetup.Location = New System.Drawing.Point(4, 38)
    Me.TabPageMatchSetup.Name = "TabPageMatchSetup"
    Me.TabPageMatchSetup.Size = New System.Drawing.Size(931, 482)
    Me.TabPageMatchSetup.TabIndex = 2
    Me.TabPageMatchSetup.Text = "Match setup"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel4, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileMatchInfo, 0, 4)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabelSceneVersion, 0, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxSceneVersion, 1, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileReferees, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel1, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel3, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee1, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee2, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroComboBoxReferee3, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel2, 0, 6)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 6)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 11
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(931, 482)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'MetroTileMatchInfo
    '
    Me.MetroTileMatchInfo.ActiveControl = Nothing
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroTileMatchInfo, 2)
    Me.MetroTileMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileMatchInfo.Location = New System.Drawing.Point(3, 148)
    Me.MetroTileMatchInfo.Name = "MetroTileMatchInfo"
    Me.MetroTileMatchInfo.Size = New System.Drawing.Size(925, 34)
    Me.MetroTileMatchInfo.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileMatchInfo.TabIndex = 0
    Me.MetroTileMatchInfo.Text = "General match info"
    Me.MetroTileMatchInfo.UseSelectable = True
    '
    'MetroLabelSceneVersion
    '
    Me.MetroLabelSceneVersion.AutoSize = True
    Me.MetroLabelSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelSceneVersion.Location = New System.Drawing.Point(3, 185)
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
    Me.MetroComboBoxSceneVersion.Location = New System.Drawing.Point(203, 188)
    Me.MetroComboBoxSceneVersion.Name = "MetroComboBoxSceneVersion"
    Me.MetroComboBoxSceneVersion.Size = New System.Drawing.Size(725, 29)
    Me.MetroComboBoxSceneVersion.TabIndex = 2
    Me.MetroComboBoxSceneVersion.UseSelectable = True
    '
    'MetroTileReferees
    '
    Me.MetroTileReferees.ActiveControl = Nothing
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroTileReferees, 2)
    Me.MetroTileReferees.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileReferees.Location = New System.Drawing.Point(3, 3)
    Me.MetroTileReferees.Name = "MetroTileReferees"
    Me.MetroTileReferees.Size = New System.Drawing.Size(925, 34)
    Me.MetroTileReferees.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileReferees.TabIndex = 3
    Me.MetroTileReferees.Text = "Referees"
    Me.MetroTileReferees.UseSelectable = True
    '
    'MetroLabel1
    '
    Me.MetroLabel1.AutoSize = True
    Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel1.Location = New System.Drawing.Point(3, 40)
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
    Me.MetroLabel3.Location = New System.Drawing.Point(3, 75)
    Me.MetroLabel3.Name = "MetroLabel3"
    Me.MetroLabel3.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel3.TabIndex = 6
    Me.MetroLabel3.Text = "Assistant referee #1"
    Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroLabel4
    '
    Me.MetroLabel4.AutoSize = True
    Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel4.Location = New System.Drawing.Point(3, 110)
    Me.MetroLabel4.Name = "MetroLabel4"
    Me.MetroLabel4.Size = New System.Drawing.Size(194, 35)
    Me.MetroLabel4.TabIndex = 7
    Me.MetroLabel4.Text = "Assistant referee #2"
    Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroComboBoxReferee1
    '
    Me.MetroComboBoxReferee1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee1.FormattingEnabled = True
    Me.MetroComboBoxReferee1.ItemHeight = 23
    Me.MetroComboBoxReferee1.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee1.Location = New System.Drawing.Point(203, 43)
    Me.MetroComboBoxReferee1.Name = "MetroComboBoxReferee1"
    Me.MetroComboBoxReferee1.Size = New System.Drawing.Size(725, 29)
    Me.MetroComboBoxReferee1.TabIndex = 8
    Me.MetroComboBoxReferee1.UseSelectable = True
    '
    'MetroComboBoxReferee2
    '
    Me.MetroComboBoxReferee2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee2.FormattingEnabled = True
    Me.MetroComboBoxReferee2.ItemHeight = 23
    Me.MetroComboBoxReferee2.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee2.Location = New System.Drawing.Point(203, 78)
    Me.MetroComboBoxReferee2.Name = "MetroComboBoxReferee2"
    Me.MetroComboBoxReferee2.Size = New System.Drawing.Size(725, 29)
    Me.MetroComboBoxReferee2.TabIndex = 9
    Me.MetroComboBoxReferee2.UseSelectable = True
    '
    'MetroComboBoxReferee3
    '
    Me.MetroComboBoxReferee3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxReferee3.FormattingEnabled = True
    Me.MetroComboBoxReferee3.ItemHeight = 23
    Me.MetroComboBoxReferee3.Items.AddRange(New Object() {"Varcas Adam", "Abdul aziz Al funaitar", "Khaled Al Threes"})
    Me.MetroComboBoxReferee3.Location = New System.Drawing.Point(203, 113)
    Me.MetroComboBoxReferee3.Name = "MetroComboBoxReferee3"
    Me.MetroComboBoxReferee3.Size = New System.Drawing.Size(725, 29)
    Me.MetroComboBoxReferee3.TabIndex = 10
    Me.MetroComboBoxReferee3.UseSelectable = True
    '
    'MetroLabel2
    '
    Me.MetroLabel2.AutoSize = True
    Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabel2.Location = New System.Drawing.Point(3, 220)
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
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(203, 223)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 4
    Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel3, 2)
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(725, 179)
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
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MetroTabControl1.ResumeLayout(False)
    Me.TabPageMatchSetup.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    CType(Me.PictureBoxClockUp, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockLeft, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockRight, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBoxClockDown, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPageHome.ResumeLayout(False)
    Me.TabPageAway.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Private WithEvents cboCompetition As MetroFramework.Controls.MetroComboBox
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroGridMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents Column1 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDate As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
  Friend WithEvents ColumnResult As DataGridViewTextBoxColumn
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
End Class
