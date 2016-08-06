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
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFixtures))
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me.MetroGridMatches = New MetroFramework.Controls.MetroGrid()
    Me.MetroGridTeams = New MetroFramework.Controls.MetroGrid()
    Me.ColumnTeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
    Me.ColumnMatchesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesState = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MenuStrip1.SuspendLayout()
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerAll.Panel1.SuspendLayout()
    Me.SplitContainerAll.Panel2.SuspendLayout()
    Me.SplitContainerAll.SuspendLayout()
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridTeams, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
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
    Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
    Me.SplitContainerAll.Panel2.Controls.Add(Me.MetroGridTeams)
    Me.SplitContainerAll.Size = New System.Drawing.Size(916, 639)
    Me.SplitContainerAll.SplitterDistance = 406
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
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
    Me.MetroGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnMatchesID, Me.ColumnMatchesOptaID, Me.ColumnMatchesState, Me.ColumnHomeTeam, Me.ColumnMatchesScore, Me.ColumnAwayTeam})
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatches.DefaultCellStyle = DataGridViewCellStyle10
    Me.MetroGridMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridMatches.EnableHeadersVisualStyles = False
    Me.MetroGridMatches.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatches.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatches.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridMatches.Name = "MetroGridMatches"
    Me.MetroGridMatches.ReadOnly = True
    Me.MetroGridMatches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
    Me.MetroGridMatches.RowHeadersVisible = False
    Me.MetroGridMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatches.Size = New System.Drawing.Size(916, 406)
    Me.MetroGridMatches.TabIndex = 0
    '
    'MetroGridTeams
    '
    Me.MetroGridTeams.AllowUserToAddRows = False
    Me.MetroGridTeams.AllowUserToDeleteRows = False
    Me.MetroGridTeams.AllowUserToResizeRows = False
    Me.MetroGridTeams.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeams.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridTeams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeams.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
    Me.MetroGridTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridTeams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTeamID, Me.ColumnTeamOptaID, Me.ColumnTeamName})
    DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridTeams.DefaultCellStyle = DataGridViewCellStyle13
    Me.MetroGridTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridTeams.EnableHeadersVisualStyles = False
    Me.MetroGridTeams.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridTeams.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeams.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridTeams.Name = "MetroGridTeams"
    Me.MetroGridTeams.ReadOnly = True
    Me.MetroGridTeams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeams.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
    Me.MetroGridTeams.RowHeadersVisible = False
    Me.MetroGridTeams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridTeams.Size = New System.Drawing.Size(916, 229)
    Me.MetroGridTeams.TabIndex = 0
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
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.ColumnMatchesScore.DefaultCellStyle = DataGridViewCellStyle9
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
    'frmFixtures
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(916, 692)
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
    CType(Me.MetroGridTeams, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
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
  Friend WithEvents MetroGridTeams As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnTeamID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesState As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesScore As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayTeam As DataGridViewTextBoxColumn
End Class
