<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubstitutions
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelData = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridSubstitutions = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnInPlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnOutPlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerInID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerOutID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroButtonAddAwayTeamSubstitition = New System.Windows.Forms.Button()
    Me.MetroButtonRemoveSubstitution = New System.Windows.Forms.Button()
    Me.MetroButtonAddHomeTeamSubstitition = New System.Windows.Forms.Button()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTileGraphics = New MetroFramework.Controls.MetroTile()
    Me.MetroButtonShowSelectedSubstitution = New System.Windows.Forms.Button()
    Me.MetroTileData = New MetroFramework.Controls.MetroTile()
    Me.TableLayoutPanelData.SuspendLayout()
    CType(Me.MetroGridSubstitutions, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelData
    '
    Me.TableLayoutPanelData.ColumnCount = 2
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanelData.Controls.Add(Me.MetroGridSubstitutions, 0, 2)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonAddAwayTeamSubstitition, 1, 0)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonRemoveSubstitution, 0, 1)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonAddHomeTeamSubstitition, 1, 1)
    Me.TableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelData.Location = New System.Drawing.Point(3, 43)
    Me.TableLayoutPanelData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelData.Name = "TableLayoutPanelData"
    Me.TableLayoutPanelData.RowCount = 3
    Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelData.Size = New System.Drawing.Size(795, 235)
    Me.TableLayoutPanelData.TabIndex = 1
    '
    'MetroGridSubstitutions
    '
    Me.MetroGridSubstitutions.AllowUserToAddRows = False
    Me.MetroGridSubstitutions.AllowUserToDeleteRows = False
    Me.MetroGridSubstitutions.AllowUserToResizeColumns = False
    Me.MetroGridSubstitutions.AllowUserToResizeRows = False
    Me.MetroGridSubstitutions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridSubstitutions.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridSubstitutions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridSubstitutions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridSubstitutions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridSubstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridSubstitutions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnTime, Me.ColumnInPlayer, Me.ColumnOutPlayer, Me.ColumnPlayerInID, Me.ColumnPlayerOutID, Me.ColumnTeam})
    Me.TableLayoutPanelData.SetColumnSpan(Me.MetroGridSubstitutions, 2)
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridSubstitutions.DefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridSubstitutions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridSubstitutions.EnableHeadersVisualStyles = False
    Me.MetroGridSubstitutions.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridSubstitutions.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridSubstitutions.Location = New System.Drawing.Point(3, 96)
    Me.MetroGridSubstitutions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroGridSubstitutions.MultiSelect = False
    Me.MetroGridSubstitutions.Name = "MetroGridSubstitutions"
    Me.MetroGridSubstitutions.ReadOnly = True
    Me.MetroGridSubstitutions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridSubstitutions.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridSubstitutions.RowHeadersVisible = False
    Me.MetroGridSubstitutions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroGridSubstitutions.RowsDefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridSubstitutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridSubstitutions.Size = New System.Drawing.Size(789, 135)
    Me.MetroGridSubstitutions.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroGridSubstitutions.TabIndex = 4
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ColumnID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Visible = False
    '
    'ColumnTime
    '
    Me.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTime.HeaderText = "Time"
    Me.ColumnTime.Name = "ColumnTime"
    Me.ColumnTime.ReadOnly = True
    Me.ColumnTime.Width = 53
    '
    'ColumnInPlayer
    '
    Me.ColumnInPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnInPlayer.HeaderText = "IN"
    Me.ColumnInPlayer.Name = "ColumnInPlayer"
    Me.ColumnInPlayer.ReadOnly = True
    Me.ColumnInPlayer.Width = 41
    '
    'ColumnOutPlayer
    '
    Me.ColumnOutPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnOutPlayer.HeaderText = "OUT"
    Me.ColumnOutPlayer.Name = "ColumnOutPlayer"
    Me.ColumnOutPlayer.ReadOnly = True
    '
    'ColumnPlayerInID
    '
    Me.ColumnPlayerInID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnPlayerInID.HeaderText = "In ID"
    Me.ColumnPlayerInID.Name = "ColumnPlayerInID"
    Me.ColumnPlayerInID.ReadOnly = True
    Me.ColumnPlayerInID.Visible = False
    '
    'ColumnPlayerOutID
    '
    Me.ColumnPlayerOutID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.ColumnPlayerOutID.DefaultCellStyle = DataGridViewCellStyle2
    Me.ColumnPlayerOutID.HeaderText = "Out ID"
    Me.ColumnPlayerOutID.Name = "ColumnPlayerOutID"
    Me.ColumnPlayerOutID.ReadOnly = True
    Me.ColumnPlayerOutID.Visible = False
    '
    'ColumnTeam
    '
    Me.ColumnTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnTeam.HeaderText = "Team"
    Me.ColumnTeam.Name = "ColumnTeam"
    Me.ColumnTeam.ReadOnly = True
    '
    'MetroButtonAddAwayTeamSubstitition
    '
    Me.MetroButtonAddAwayTeamSubstitition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonAddAwayTeamSubstitition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonAddAwayTeamSubstitition.Location = New System.Drawing.Point(400, 4)
    Me.MetroButtonAddAwayTeamSubstitition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroButtonAddAwayTeamSubstitition.Name = "MetroButtonAddAwayTeamSubstitition"
    Me.MetroButtonAddAwayTeamSubstitition.Size = New System.Drawing.Size(392, 38)
    Me.MetroButtonAddAwayTeamSubstitition.TabIndex = 3
    Me.MetroButtonAddAwayTeamSubstitition.Text = "Add home team substitution"
    '
    'MetroButtonRemoveSubstitution
    '
    Me.MetroButtonRemoveSubstitution.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.MetroButtonRemoveSubstitution.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonRemoveSubstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonRemoveSubstitution.Location = New System.Drawing.Point(3, 50)
    Me.MetroButtonRemoveSubstitution.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroButtonRemoveSubstitution.Name = "MetroButtonRemoveSubstitution"
    Me.MetroButtonRemoveSubstitution.Size = New System.Drawing.Size(391, 38)
    Me.MetroButtonRemoveSubstitution.TabIndex = 2
    Me.MetroButtonRemoveSubstitution.Text = "Remove substitution"
    Me.MetroButtonRemoveSubstitution.UseVisualStyleBackColor = False
    '
    'MetroButtonAddHomeTeamSubstitition
    '
    Me.MetroButtonAddHomeTeamSubstitition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonAddHomeTeamSubstitition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonAddHomeTeamSubstitition.Location = New System.Drawing.Point(400, 50)
    Me.MetroButtonAddHomeTeamSubstitition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroButtonAddHomeTeamSubstitition.Name = "MetroButtonAddHomeTeamSubstitition"
    Me.MetroButtonAddHomeTeamSubstitition.Size = New System.Drawing.Size(392, 38)
    Me.MetroButtonAddHomeTeamSubstitition.TabIndex = 1
    Me.MetroButtonAddHomeTeamSubstitition.Text = "Add away team substitution"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 1
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileGraphics, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanelData, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroButtonShowSelectedSubstitution, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileData, 0, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(801, 367)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'MetroTileGraphics
    '
    Me.MetroTileGraphics.ActiveControl = Nothing
    Me.MetroTileGraphics.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileGraphics.Location = New System.Drawing.Point(3, 286)
    Me.MetroTileGraphics.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroTileGraphics.Name = "MetroTileGraphics"
    Me.MetroTileGraphics.Size = New System.Drawing.Size(795, 31)
    Me.MetroTileGraphics.TabIndex = 0
    Me.MetroTileGraphics.Text = "Graphics"
    Me.MetroTileGraphics.UseSelectable = True
    '
    'MetroButtonShowSelectedSubstitution
    '
    Me.MetroButtonShowSelectedSubstitution.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonShowSelectedSubstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonShowSelectedSubstitution.Location = New System.Drawing.Point(3, 325)
    Me.MetroButtonShowSelectedSubstitution.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroButtonShowSelectedSubstitution.Name = "MetroButtonShowSelectedSubstitution"
    Me.MetroButtonShowSelectedSubstitution.Size = New System.Drawing.Size(795, 38)
    Me.MetroButtonShowSelectedSubstitution.TabIndex = 1
    Me.MetroButtonShowSelectedSubstitution.Text = "Selected substitution..."
    '
    'MetroTileData
    '
    Me.MetroTileData.ActiveControl = Nothing
    Me.MetroTileData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileData.Location = New System.Drawing.Point(3, 4)
    Me.MetroTileData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroTileData.Name = "MetroTileData"
    Me.MetroTileData.Size = New System.Drawing.Size(795, 31)
    Me.MetroTileData.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileData.TabIndex = 2
    Me.MetroTileData.Text = "Data"
    Me.MetroTileData.UseSelectable = True
    '
    'FormSubstitutions
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(801, 367)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "FormSubstitutions"
    Me.ShowIcon = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Substitutions"
    Me.TableLayoutPanelData.ResumeLayout(False)
    CType(Me.MetroGridSubstitutions, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanelData As TableLayoutPanel
  Friend WithEvents MetroButtonAddAwayTeamSubstitition As Button
  Friend WithEvents MetroButtonRemoveSubstitution As Button
  Friend WithEvents MetroButtonAddHomeTeamSubstitition As Button
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents MetroTileGraphics As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroButtonShowSelectedSubstitution As Button
  Friend WithEvents MetroTileData As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroGridSubstitutions As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTime As DataGridViewTextBoxColumn
  Friend WithEvents ColumnInPlayer As DataGridViewTextBoxColumn
  Friend WithEvents ColumnOutPlayer As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerInID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerOutID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTeam As DataGridViewTextBoxColumn
End Class
