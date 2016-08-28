<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptaTeamViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.LabelScore = New System.Windows.Forms.Label()
    Me.LabelTeamName = New System.Windows.Forms.Label()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridStats = New MetroFramework.Controls.MetroGrid()
    Me.ColumnTeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerOpdaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnStat0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ButtonEditTeam = New System.Windows.Forms.Button()
    Me.TableLayoutPanelAll.SuspendLayout()
    CType(Me.MetroGridStats, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelScore
    '
    Me.LabelScore.AutoSize = True
    Me.LabelScore.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelScore.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelScore.Location = New System.Drawing.Point(635, 0)
    Me.LabelScore.Name = "LabelScore"
    Me.LabelScore.Size = New System.Drawing.Size(54, 46)
    Me.LabelScore.TabIndex = 1
    Me.LabelScore.Text = "00"
    Me.LabelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelTeamName
    '
    Me.LabelTeamName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelTeamName.Location = New System.Drawing.Point(3, 0)
    Me.LabelTeamName.Name = "LabelTeamName"
    Me.LabelTeamName.Size = New System.Drawing.Size(506, 46)
    Me.LabelTeamName.TabIndex = 0
    Me.LabelTeamName.Text = "Team name"
    Me.LabelTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 3
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelTeamName, 0, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelScore, 2, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroGridStats, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.ButtonEditTeam, 1, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(692, 560)
    Me.TableLayoutPanelAll.TabIndex = 0
    '
    'MetroGridStats
    '
    Me.MetroGridStats.AllowUserToAddRows = False
    Me.MetroGridStats.AllowUserToDeleteRows = False
    Me.MetroGridStats.AllowUserToResizeRows = False
    Me.MetroGridStats.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridStats.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridStats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTeamID, Me.ColumnPlayerID, Me.ColumnPlayerOpdaID, Me.ColumnPlayerNumber, Me.ColumnName, Me.ColumnStat0})
    Me.TableLayoutPanelAll.SetColumnSpan(Me.MetroGridStats, 3)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridStats.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridStats.EnableHeadersVisualStyles = False
    Me.MetroGridStats.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridStats.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridStats.Location = New System.Drawing.Point(3, 49)
    Me.MetroGridStats.Name = "MetroGridStats"
    Me.MetroGridStats.ReadOnly = True
    Me.MetroGridStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridStats.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridStats.RowHeadersVisible = False
    Me.MetroGridStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridStats.Size = New System.Drawing.Size(686, 508)
    Me.MetroGridStats.TabIndex = 2
    '
    'ColumnTeamID
    '
    Me.ColumnTeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamID.HeaderText = "TeamID"
    Me.ColumnTeamID.Name = "ColumnTeamID"
    Me.ColumnTeamID.ReadOnly = True
    Me.ColumnTeamID.Width = 67
    '
    'ColumnPlayerID
    '
    Me.ColumnPlayerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayerID.HeaderText = "PlayerID"
    Me.ColumnPlayerID.Name = "ColumnPlayerID"
    Me.ColumnPlayerID.ReadOnly = True
    Me.ColumnPlayerID.Width = 71
    '
    'ColumnPlayerOpdaID
    '
    Me.ColumnPlayerOpdaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayerOpdaID.HeaderText = "Player opta ID"
    Me.ColumnPlayerOpdaID.Name = "ColumnPlayerOpdaID"
    Me.ColumnPlayerOpdaID.ReadOnly = True
    Me.ColumnPlayerOpdaID.Width = 83
    '
    'ColumnPlayerNumber
    '
    Me.ColumnPlayerNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayerNumber.HeaderText = "#"
    Me.ColumnPlayerNumber.Name = "ColumnPlayerNumber"
    Me.ColumnPlayerNumber.ReadOnly = True
    Me.ColumnPlayerNumber.Width = 37
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnName.HeaderText = "Name"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    Me.ColumnName.Width = 59
    '
    'ColumnStat0
    '
    Me.ColumnStat0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnStat0.HeaderText = "Stat0"
    Me.ColumnStat0.Name = "ColumnStat0"
    Me.ColumnStat0.ReadOnly = True
    Me.ColumnStat0.Width = 56
    '
    'ButtonEditTeam
    '
    Me.ButtonEditTeam.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonEditTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonEditTeam.Location = New System.Drawing.Point(515, 3)
    Me.ButtonEditTeam.Name = "ButtonEditTeam"
    Me.ButtonEditTeam.Size = New System.Drawing.Size(114, 40)
    Me.ButtonEditTeam.TabIndex = 3
    Me.ButtonEditTeam.Text = "Team players..."
    Me.ButtonEditTeam.UseVisualStyleBackColor = True
    '
    'OptaTeamViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "OptaTeamViewer"
    Me.Size = New System.Drawing.Size(692, 560)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    CType(Me.MetroGridStats, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents LabelScore As Label
    Friend WithEvents LabelTeamName As Label
    Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
    Friend WithEvents MetroGridStats As MetroFramework.Controls.MetroGrid
  Friend WithEvents ButtonEditTeam As Button
  Friend WithEvents ColumnTeamID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerOpdaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnStat0 As DataGridViewTextBoxColumn
End Class
