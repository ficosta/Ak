<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatchInfo
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatchInfo))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me.MetroGridMatchInfo = New MetroFramework.Controls.MetroGrid()
    Me.ColumnInfoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnInfoName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnInfoValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanelStats = New System.Windows.Forms.TableLayoutPanel()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
    Me.OptaTeamViewerAwayTeam = New Opta_get_data.OptaTeamViewer()
    Me.OptaTeamViewerHomeTeam = New Opta_get_data.OptaTeamViewer()
    Me.MenuStrip1.SuspendLayout()
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerAll.Panel1.SuspendLayout()
    Me.SplitContainerAll.Panel2.SuspendLayout()
    Me.SplitContainerAll.SuspendLayout()
    CType(Me.MetroGridMatchInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanelStats.SuspendLayout()
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
    Me.SplitContainerAll.Panel1.Controls.Add(Me.MetroGridMatchInfo)
    '
    'SplitContainerAll.Panel2
    '
    Me.SplitContainerAll.Panel2.Controls.Add(Me.TableLayoutPanelStats)
    Me.SplitContainerAll.Size = New System.Drawing.Size(916, 639)
    Me.SplitContainerAll.SplitterDistance = 92
    Me.SplitContainerAll.TabIndex = 2
    '
    'MetroGridMatchInfo
    '
    Me.MetroGridMatchInfo.AllowUserToAddRows = False
    Me.MetroGridMatchInfo.AllowUserToDeleteRows = False
    Me.MetroGridMatchInfo.AllowUserToResizeRows = False
    Me.MetroGridMatchInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatchInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridMatchInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridMatchInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridMatchInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatchInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnInfoID, Me.ColumnInfoName, Me.ColumnInfoValue})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatchInfo.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridMatchInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridMatchInfo.EnableHeadersVisualStyles = False
    Me.MetroGridMatchInfo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatchInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatchInfo.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridMatchInfo.Name = "MetroGridMatchInfo"
    Me.MetroGridMatchInfo.ReadOnly = True
    Me.MetroGridMatchInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridMatchInfo.RowHeadersVisible = False
    Me.MetroGridMatchInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatchInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatchInfo.Size = New System.Drawing.Size(916, 92)
    Me.MetroGridMatchInfo.TabIndex = 0
    '
    'ColumnInfoID
    '
    Me.ColumnInfoID.HeaderText = "ID"
    Me.ColumnInfoID.Name = "ColumnInfoID"
    Me.ColumnInfoID.ReadOnly = True
    '
    'ColumnInfoName
    '
    Me.ColumnInfoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnInfoName.HeaderText = "Information"
    Me.ColumnInfoName.Name = "ColumnInfoName"
    Me.ColumnInfoName.ReadOnly = True
    Me.ColumnInfoName.Width = 91
    '
    'ColumnInfoValue
    '
    Me.ColumnInfoValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnInfoValue.HeaderText = "Value"
    Me.ColumnInfoValue.Name = "ColumnInfoValue"
    Me.ColumnInfoValue.ReadOnly = True
    '
    'TableLayoutPanelStats
    '
    Me.TableLayoutPanelStats.ColumnCount = 1
    Me.TableLayoutPanelStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelStats.Controls.Add(Me.OptaTeamViewerAwayTeam, 0, 1)
    Me.TableLayoutPanelStats.Controls.Add(Me.OptaTeamViewerHomeTeam, 0, 0)
    Me.TableLayoutPanelStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelStats.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelStats.Name = "TableLayoutPanelStats"
    Me.TableLayoutPanelStats.RowCount = 2
    Me.TableLayoutPanelStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelStats.Size = New System.Drawing.Size(916, 543)
    Me.TableLayoutPanelStats.TabIndex = 0
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
    'OptaTeamViewerAwayTeam
    '
    Me.OptaTeamViewerAwayTeam.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OptaTeamViewerAwayTeam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.OptaTeamViewerAwayTeam.Location = New System.Drawing.Point(3, 275)
    Me.OptaTeamViewerAwayTeam.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.OptaTeamViewerAwayTeam.Name = "OptaTeamViewerAwayTeam"
    Me.OptaTeamViewerAwayTeam.Size = New System.Drawing.Size(910, 264)
    Me.OptaTeamViewerAwayTeam.TabIndex = 1
    Me.OptaTeamViewerAwayTeam.Team = Nothing
    '
    'OptaTeamViewerHomeTeam
    '
    Me.OptaTeamViewerHomeTeam.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OptaTeamViewerHomeTeam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.OptaTeamViewerHomeTeam.Location = New System.Drawing.Point(3, 4)
    Me.OptaTeamViewerHomeTeam.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.OptaTeamViewerHomeTeam.Name = "OptaTeamViewerHomeTeam"
    Me.OptaTeamViewerHomeTeam.Size = New System.Drawing.Size(910, 263)
    Me.OptaTeamViewerHomeTeam.TabIndex = 0
    Me.OptaTeamViewerHomeTeam.Team = Nothing
    '
    'frmMain
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
    Me.Name = "frmMain"
    Me.Text = "Opta explorer"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.SplitContainerAll.Panel1.ResumeLayout(False)
    Me.SplitContainerAll.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerAll.ResumeLayout(False)
    CType(Me.MetroGridMatchInfo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanelStats.ResumeLayout(False)
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
    Friend WithEvents MetroGridMatchInfo As MetroFramework.Controls.MetroGrid
    Friend WithEvents ColumnInfoID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnInfoName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnInfoValue As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanelStats As TableLayoutPanel
    Friend WithEvents OptaTeamViewerAwayTeam As OptaTeamViewer
    Friend WithEvents OptaTeamViewerHomeTeam As OptaTeamViewer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonRefresh As ToolStripButton
End Class
