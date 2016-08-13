<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOptaTeams
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptaTeams))
    Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
    Me.TableLayoutPanelTeams = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridLocal = New MetroFramework.Controls.MetroGrid()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.MetroGridOpta = New MetroFramework.Controls.MetroGrid()
    Me.ColumnTeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeamOptaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LabelOptaTeams = New System.Windows.Forms.Label()
    Me.ButtonLink = New System.Windows.Forms.Button()
    Me.TableLayoutPanelTeams.SuspendLayout()
    CType(Me.MetroGridLocal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridOpta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'OpenFileDialogXML
    '
    Me.OpenFileDialogXML.FileName = "Open xml"
    Me.OpenFileDialogXML.Filter = "XML files|*.xml|All files|*.*"
    '
    'TableLayoutPanelTeams
    '
    Me.TableLayoutPanelTeams.ColumnCount = 3
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.Controls.Add(Me.MetroGridLocal, 2, 1)
    Me.TableLayoutPanelTeams.Controls.Add(Me.Label2, 2, 0)
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
    Me.TableLayoutPanelTeams.Size = New System.Drawing.Size(916, 425)
    Me.TableLayoutPanelTeams.TabIndex = 0
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
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridLocal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridLocal.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridLocal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridLocal.EnableHeadersVisualStyles = False
    Me.MetroGridLocal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridLocal.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridLocal.Location = New System.Drawing.Point(511, 33)
    Me.MetroGridLocal.MultiSelect = False
    Me.MetroGridLocal.Name = "MetroGridLocal"
    Me.MetroGridLocal.ReadOnly = True
    Me.MetroGridLocal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridLocal.RowHeadersVisible = False
    Me.MetroGridLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTeams.SetRowSpan(Me.MetroGridLocal, 3)
    Me.MetroGridLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridLocal.Size = New System.Drawing.Size(402, 389)
    Me.MetroGridLocal.TabIndex = 3
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
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.HeaderText = "OptaName"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'Label2
    '
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Location = New System.Drawing.Point(511, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(402, 30)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Local teams"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOpta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridOpta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridOpta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTeamID, Me.ColumnTeamOptaID, Me.ColumnTeamName, Me.ColumnTeamOptaName})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridOpta.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridOpta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridOpta.EnableHeadersVisualStyles = False
    Me.MetroGridOpta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridOpta.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOpta.Location = New System.Drawing.Point(3, 33)
    Me.MetroGridOpta.MultiSelect = False
    Me.MetroGridOpta.Name = "MetroGridOpta"
    Me.MetroGridOpta.ReadOnly = True
    Me.MetroGridOpta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOpta.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridOpta.RowHeadersVisible = False
    Me.MetroGridOpta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTeams.SetRowSpan(Me.MetroGridOpta, 3)
    Me.MetroGridOpta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridOpta.Size = New System.Drawing.Size(402, 389)
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
    'ColumnTeamName
    '
    Me.ColumnTeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnTeamName.HeaderText = "Name"
    Me.ColumnTeamName.Name = "ColumnTeamName"
    Me.ColumnTeamName.ReadOnly = True
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
    Me.LabelOptaTeams.Size = New System.Drawing.Size(402, 30)
    Me.LabelOptaTeams.TabIndex = 1
    Me.LabelOptaTeams.Text = "Opta teams"
    Me.LabelOptaTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ButtonLink
    '
    Me.ButtonLink.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonLink.Location = New System.Drawing.Point(411, 205)
    Me.ButtonLink.Name = "ButtonLink"
    Me.ButtonLink.Size = New System.Drawing.Size(94, 44)
    Me.ButtonLink.TabIndex = 4
    Me.ButtonLink.Text = "Link"
    Me.ButtonLink.UseVisualStyleBackColor = True
    '
    'frmOptaTeams
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(916, 425)
    Me.Controls.Add(Me.TableLayoutPanelTeams)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmOptaTeams"
    Me.Text = "Opta explorer"
    Me.TableLayoutPanelTeams.ResumeLayout(False)
    CType(Me.MetroGridLocal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridOpta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OpenFileDialogXML As OpenFileDialog
  Friend WithEvents MetroGridOpta As MetroFramework.Controls.MetroGrid
  Friend WithEvents TableLayoutPanelTeams As TableLayoutPanel
  Friend WithEvents Label2 As Label
  Friend WithEvents LabelOptaTeams As Label
  Friend WithEvents MetroGridLocal As MetroFramework.Controls.MetroGrid
  Friend WithEvents ButtonLink As Button
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeamOptaName As DataGridViewTextBoxColumn
End Class
