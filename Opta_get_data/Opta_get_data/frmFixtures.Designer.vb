<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFixtures
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFixtures))
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me.MetroGridMatches = New MetroFramework.Controls.MetroGrid()
    Me.ColumnMatchesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesState = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroGridTeamsOpta = New MetroFramework.Controls.MetroGrid()
    Me.ColumnTeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
    Me.TableLayoutPanelTeams = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.LabelOptaTeams = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.MetroGridTeamsLocal = New MetroFramework.Controls.MetroGrid()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MenuStrip1.SuspendLayout()
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerAll.Panel1.SuspendLayout()
    Me.SplitContainerAll.Panel2.SuspendLayout()
    Me.SplitContainerAll.SuspendLayout()
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridTeamsOpta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.TableLayoutPanelTeams.SuspendLayout()
    CType(Me.MetroGridTeamsLocal, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
    Me.MenuStrip1.Size = New System.Drawing.Size(916, 25)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'OpenFileToolStripMenuItem
    '
    Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
    Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
    Me.OpenFileToolStripMenuItem.Text = "Open file..."
    '
    'OpenFileDialogXML
    '
    Me.OpenFileDialogXML.FileName = "Open xml"
    Me.OpenFileDialogXML.Filter = "XML files|*.xml|All files|*.*"
    '
    'SplitContainerAll
    '
    Me.SplitContainerAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainerAll.Location = New System.Drawing.Point(0, 53)
    Me.SplitContainerAll.Name = "SplitContainerAll"
    Me.SplitContainerAll.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainerAll.Panel1
    '
    Me.SplitContainerAll.Panel1.Controls.Add(Me.MetroGridMatches)
    '
    'SplitContainerAll.Panel2
    '
    Me.SplitContainerAll.Panel2.Controls.Add(Me.TableLayoutPanelTeams)
    Me.SplitContainerAll.Size = New System.Drawing.Size(916, 636)
    Me.SplitContainerAll.SplitterDistance = 404
    Me.SplitContainerAll.TabIndex = 2
    '
    'MetroGridMatches
    '
    Me.MetroGridMatches.AllowUserToAddRows = False
    Me.MetroGridMatches.AllowUserToDeleteRows = False
    Me.MetroGridMatches.AllowUserToResizeRows = False
    Me.MetroGridMatches.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatches.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridMatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnMatchesID, Me.ColumnMatchesOptaID, Me.ColumnMatchesState, Me.ColumnHomeTeam, Me.ColumnMatchesScore, Me.ColumnAwayTeam})
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatches.DefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridMatches.EnableHeadersVisualStyles = False
    Me.MetroGridMatches.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatches.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatches.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridMatches.Name = "MetroGridMatches"
    Me.MetroGridMatches.ReadOnly = True
    Me.MetroGridMatches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridMatches.RowHeadersVisible = False
    Me.MetroGridMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatches.Size = New System.Drawing.Size(916, 404)
    Me.MetroGridMatches.TabIndex = 0
    '
    'ColumnMatchesID
    '
    Me.ColumnMatchesID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnMatchesID.HeaderText = "MatchID"
    Me.ColumnMatchesID.Name = "ColumnMatchesID"
    Me.ColumnMatchesID.ReadOnly = True
    Me.ColumnMatchesID.Width = 73
    '
    'ColumnMatchesOptaID
    '
    Me.ColumnMatchesOptaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnMatchesOptaID.HeaderText = "OptaID"
    Me.ColumnMatchesOptaID.Name = "ColumnMatchesOptaID"
    Me.ColumnMatchesOptaID.ReadOnly = True
    Me.ColumnMatchesOptaID.Width = 67
    '
    'ColumnMatchesState
    '
    Me.ColumnMatchesState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnMatchesState.HeaderText = "State"
    Me.ColumnMatchesState.Name = "ColumnMatchesState"
    Me.ColumnMatchesState.ReadOnly = True
    Me.ColumnMatchesState.Width = 56
    '
    'ColumnHomeTeam
    '
    Me.ColumnHomeTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnHomeTeam.HeaderText = "Home team"
    Me.ColumnHomeTeam.Name = "ColumnHomeTeam"
    Me.ColumnHomeTeam.ReadOnly = True
    Me.ColumnHomeTeam.Width = 88
    '
    'ColumnMatchesScore
    '
    Me.ColumnMatchesScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.ColumnMatchesScore.DefaultCellStyle = DataGridViewCellStyle2
    Me.ColumnMatchesScore.HeaderText = "Score"
    Me.ColumnMatchesScore.Name = "ColumnMatchesScore"
    Me.ColumnMatchesScore.ReadOnly = True
    Me.ColumnMatchesScore.Width = 58
    '
    'ColumnAwayTeam
    '
    Me.ColumnAwayTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnAwayTeam.HeaderText = "Away team"
    Me.ColumnAwayTeam.Name = "ColumnAwayTeam"
    Me.ColumnAwayTeam.ReadOnly = True
    '
    'MetroGridTeamsOpta
    '
    Me.MetroGridTeamsOpta.AllowUserToAddRows = False
    Me.MetroGridTeamsOpta.AllowUserToDeleteRows = False
    Me.MetroGridTeamsOpta.AllowUserToResizeRows = False
    Me.MetroGridTeamsOpta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamsOpta.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridTeamsOpta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridTeamsOpta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamsOpta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
    Me.MetroGridTeamsOpta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridTeamsOpta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTeamID, Me.ColumnTeamOptaID, Me.ColumnTeamName})
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridTeamsOpta.DefaultCellStyle = DataGridViewCellStyle9
    Me.MetroGridTeamsOpta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridTeamsOpta.EnableHeadersVisualStyles = False
    Me.MetroGridTeamsOpta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridTeamsOpta.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamsOpta.Location = New System.Drawing.Point(3, 33)
    Me.MetroGridTeamsOpta.Name = "MetroGridTeamsOpta"
    Me.MetroGridTeamsOpta.ReadOnly = True
    Me.MetroGridTeamsOpta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamsOpta.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
    Me.MetroGridTeamsOpta.RowHeadersVisible = False
    Me.MetroGridTeamsOpta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridTeamsOpta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridTeamsOpta.Size = New System.Drawing.Size(452, 192)
    Me.MetroGridTeamsOpta.TabIndex = 0
    '
    'ColumnTeamID
    '
    Me.ColumnTeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamID.HeaderText = "TeamID"
    Me.ColumnTeamID.Name = "ColumnTeamID"
    Me.ColumnTeamID.ReadOnly = True
    Me.ColumnTeamID.Width = 67
    '
    'ColumnTeamOptaID
    '
    Me.ColumnTeamOptaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamOptaID.HeaderText = "OptaID"
    Me.ColumnTeamOptaID.Name = "ColumnTeamOptaID"
    Me.ColumnTeamOptaID.ReadOnly = True
    Me.ColumnTeamOptaID.Width = 67
    '
    'ColumnTeamName
    '
    Me.ColumnTeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnTeamName.HeaderText = "Name"
    Me.ColumnTeamName.Name = "ColumnTeamName"
    Me.ColumnTeamName.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonRefresh})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(916, 25)
    Me.ToolStrip1.TabIndex = 3
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'ToolStripButtonRefresh
    '
    Me.ToolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.ToolStripButtonRefresh.Enabled = False
    Me.ToolStripButtonRefresh.Image = CType(resources.GetObject("ToolStripButtonRefresh.Image"), System.Drawing.Image)
    Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
    Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(50, 22)
    Me.ToolStripButtonRefresh.Text = "Refresh"
    '
    'TableLayoutPanelTeams
    '
    Me.TableLayoutPanelTeams.ColumnCount = 2
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.Controls.Add(Me.MetroGridTeamsLocal, 1, 1)
    Me.TableLayoutPanelTeams.Controls.Add(Me.Label2, 1, 0)
    Me.TableLayoutPanelTeams.Controls.Add(Me.MetroGridTeamsOpta, 0, 1)
    Me.TableLayoutPanelTeams.Controls.Add(Me.LabelOptaTeams, 0, 0)
    Me.TableLayoutPanelTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTeams.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelTeams.Name = "TableLayoutPanelTeams"
    Me.TableLayoutPanelTeams.RowCount = 2
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTeams.Size = New System.Drawing.Size(916, 228)
    Me.TableLayoutPanelTeams.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 17)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Label1"
    '
    'LabelOptaTeams
    '
    Me.LabelOptaTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOptaTeams.Location = New System.Drawing.Point(3, 0)
    Me.LabelOptaTeams.Name = "LabelOptaTeams"
    Me.LabelOptaTeams.Size = New System.Drawing.Size(452, 30)
    Me.LabelOptaTeams.TabIndex = 1
    Me.LabelOptaTeams.Text = "Opta teams"
    Me.LabelOptaTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Location = New System.Drawing.Point(461, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(452, 30)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Local teams"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroGridTeamsLocal
    '
    Me.MetroGridTeamsLocal.AllowUserToAddRows = False
    Me.MetroGridTeamsLocal.AllowUserToDeleteRows = False
    Me.MetroGridTeamsLocal.AllowUserToResizeRows = False
    Me.MetroGridTeamsLocal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamsLocal.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridTeamsLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridTeamsLocal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamsLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridTeamsLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridTeamsLocal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridTeamsLocal.DefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridTeamsLocal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridTeamsLocal.EnableHeadersVisualStyles = False
    Me.MetroGridTeamsLocal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridTeamsLocal.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamsLocal.Location = New System.Drawing.Point(461, 33)
    Me.MetroGridTeamsLocal.Name = "MetroGridTeamsLocal"
    Me.MetroGridTeamsLocal.ReadOnly = True
    Me.MetroGridTeamsLocal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamsLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.MetroGridTeamsLocal.RowHeadersVisible = False
    Me.MetroGridTeamsLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridTeamsLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridTeamsLocal.Size = New System.Drawing.Size(452, 192)
    Me.MetroGridTeamsLocal.TabIndex = 3
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.HeaderText = "TeamID"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = 67
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.HeaderText = "OptaID"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Width = 67
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'frmFixtures
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(916, 692)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.SplitContainerAll)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmFixtures"
    Me.Text = "Opta explorer"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.SplitContainerAll.Panel1.ResumeLayout(False)
    Me.SplitContainerAll.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerAll.ResumeLayout(False)
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridTeamsOpta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.TableLayoutPanelTeams.ResumeLayout(False)
    CType(Me.MetroGridTeamsLocal, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents OpenFileDialogXML As OpenFileDialog
  Friend WithEvents SplitContainerAll As SplitContainer
  Friend WithEvents MetroGridMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents ToolStrip1 As ToolStrip
  Friend WithEvents ToolStripButtonRefresh As ToolStripButton
  Friend WithEvents MetroGridTeamsOpta As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnTeamID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesState As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesScore As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayTeam As DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanelTeams As TableLayoutPanel
  Friend WithEvents MetroGridTeamsLocal As MetroFramework.Controls.MetroGrid
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents Label2 As Label
  Friend WithEvents LabelOptaTeams As Label
  Friend WithEvents Label1 As Label
End Class
