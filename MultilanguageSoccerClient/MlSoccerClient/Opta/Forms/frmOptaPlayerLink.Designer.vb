<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptaPlayerLink
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
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelTeams = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridLocal = New MetroFramework.Controls.MetroGrid()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LabelLocalPlayers = New System.Windows.Forms.Label()
    Me.MetroGridOpta = New MetroFramework.Controls.MetroGrid()
    Me.ColumnTeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LabelOptaTeams = New System.Windows.Forms.Label()
    Me.ButtonLink = New System.Windows.Forms.Button()
    Me.TableLayoutPanelTeams.SuspendLayout()
    CType(Me.MetroGridLocal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridOpta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelTeams
    '
    Me.TableLayoutPanelTeams.ColumnCount = 3
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.Controls.Add(Me.MetroGridLocal, 2, 1)
    Me.TableLayoutPanelTeams.Controls.Add(Me.LabelLocalPlayers, 2, 0)
    Me.TableLayoutPanelTeams.Controls.Add(Me.MetroGridOpta, 0, 1)
    Me.TableLayoutPanelTeams.Controls.Add(Me.LabelOptaTeams, 0, 0)
    Me.TableLayoutPanelTeams.Controls.Add(Me.ButtonLink, 1, 2)
    Me.TableLayoutPanelTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTeams.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelTeams.Name = "TableLayoutPanelTeams"
    Me.TableLayoutPanelTeams.RowCount = 4
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelTeams.Size = New System.Drawing.Size(845, 437)
    Me.TableLayoutPanelTeams.TabIndex = 1
    '
    'MetroGridLocal
    '
    Me.MetroGridLocal.AllowUserToAddRows = False
    Me.MetroGridLocal.AllowUserToDeleteRows = False
    Me.MetroGridLocal.AllowUserToResizeRows = False
    Me.MetroGridLocal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridLocal.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridLocal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.MetroGridLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridLocal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridLocal.DefaultCellStyle = DataGridViewCellStyle8
    Me.MetroGridLocal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridLocal.EnableHeadersVisualStyles = False
    Me.MetroGridLocal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridLocal.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridLocal.Location = New System.Drawing.Point(475, 33)
    Me.MetroGridLocal.MultiSelect = False
    Me.MetroGridLocal.Name = "MetroGridLocal"
    Me.MetroGridLocal.ReadOnly = True
    Me.MetroGridLocal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
    Me.MetroGridLocal.RowHeadersVisible = False
    Me.MetroGridLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTeams.SetRowSpan(Me.MetroGridLocal, 3)
    Me.MetroGridLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridLocal.Size = New System.Drawing.Size(367, 401)
    Me.MetroGridLocal.TabIndex = 5
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.HeaderText = "LocalID"
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
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.HeaderText = "#"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Width = 37
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.HeaderText = "#"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Width = 37
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn6.HeaderText = "OptaName"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'LabelLocalPlayers
    '
    Me.LabelLocalPlayers.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelLocalPlayers.Location = New System.Drawing.Point(475, 0)
    Me.LabelLocalPlayers.Name = "LabelLocalPlayers"
    Me.LabelLocalPlayers.Size = New System.Drawing.Size(367, 30)
    Me.LabelLocalPlayers.TabIndex = 2
    Me.LabelLocalPlayers.Text = "Local database players for selected team"
    Me.LabelLocalPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroGridOpta
    '
    Me.MetroGridOpta.AllowUserToAddRows = False
    Me.MetroGridOpta.AllowUserToDeleteRows = False
    Me.MetroGridOpta.AllowUserToResizeRows = False
    Me.MetroGridOpta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOpta.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridOpta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridOpta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOpta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
    Me.MetroGridOpta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridOpta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTeamID, Me.ColumnTeamOptaID, Me.ColumnTeamNumber, Me.ColumnTeamName, Me.ColumnTeamOptaNumber, Me.ColumnTeamOptaName})
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridOpta.DefaultCellStyle = DataGridViewCellStyle11
    Me.MetroGridOpta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridOpta.EnableHeadersVisualStyles = False
    Me.MetroGridOpta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridOpta.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOpta.Location = New System.Drawing.Point(3, 33)
    Me.MetroGridOpta.MultiSelect = False
    Me.MetroGridOpta.Name = "MetroGridOpta"
    Me.MetroGridOpta.ReadOnly = True
    Me.MetroGridOpta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOpta.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
    Me.MetroGridOpta.RowHeadersVisible = False
    Me.MetroGridOpta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTeams.SetRowSpan(Me.MetroGridOpta, 3)
    Me.MetroGridOpta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridOpta.Size = New System.Drawing.Size(366, 401)
    Me.MetroGridOpta.TabIndex = 0
    '
    'ColumnTeamID
    '
    Me.ColumnTeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamID.HeaderText = "LocalID"
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
    'ColumnTeamNumber
    '
    Me.ColumnTeamNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamNumber.HeaderText = "#"
    Me.ColumnTeamNumber.Name = "ColumnTeamNumber"
    Me.ColumnTeamNumber.ReadOnly = True
    Me.ColumnTeamNumber.Width = 37
    '
    'ColumnTeamName
    '
    Me.ColumnTeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnTeamName.HeaderText = "Name"
    Me.ColumnTeamName.Name = "ColumnTeamName"
    Me.ColumnTeamName.ReadOnly = True
    '
    'ColumnTeamOptaNumber
    '
    Me.ColumnTeamOptaNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTeamOptaNumber.HeaderText = "#"
    Me.ColumnTeamOptaNumber.Name = "ColumnTeamOptaNumber"
    Me.ColumnTeamOptaNumber.ReadOnly = True
    Me.ColumnTeamOptaNumber.Width = 37
    '
    'ColumnTeamOptaName
    '
    Me.ColumnTeamOptaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnTeamOptaName.HeaderText = "OptaName"
    Me.ColumnTeamOptaName.Name = "ColumnTeamOptaName"
    Me.ColumnTeamOptaName.ReadOnly = True
    '
    'LabelOptaTeams
    '
    Me.LabelOptaTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOptaTeams.Location = New System.Drawing.Point(3, 0)
    Me.LabelOptaTeams.Name = "LabelOptaTeams"
    Me.LabelOptaTeams.Size = New System.Drawing.Size(366, 30)
    Me.LabelOptaTeams.TabIndex = 1
    Me.LabelOptaTeams.Text = "Opta players"
    Me.LabelOptaTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ButtonLink
    '
    Me.ButtonLink.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonLink.Location = New System.Drawing.Point(375, 211)
    Me.ButtonLink.Name = "ButtonLink"
    Me.ButtonLink.Size = New System.Drawing.Size(94, 44)
    Me.ButtonLink.TabIndex = 4
    Me.ButtonLink.Text = "Link"
    Me.ButtonLink.UseVisualStyleBackColor = True
    '
    'frmOptaPlayerLink
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(845, 437)
    Me.Controls.Add(Me.TableLayoutPanelTeams)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmOptaPlayerLink"
    Me.Text = "Players opta link"
    Me.TableLayoutPanelTeams.ResumeLayout(False)
    CType(Me.MetroGridLocal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridOpta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelTeams As TableLayoutPanel
  Friend WithEvents LabelLocalPlayers As Label
  Friend WithEvents MetroGridOpta As MetroFramework.Controls.MetroGrid
  Friend WithEvents LabelOptaTeams As Label
  Friend WithEvents ButtonLink As Button
  Friend WithEvents MetroGridLocal As MetroFramework.Controls.MetroGrid
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaName As DataGridViewTextBoxColumn
End Class
