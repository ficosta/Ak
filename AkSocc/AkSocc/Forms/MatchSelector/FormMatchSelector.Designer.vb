<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMatchSelector
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
    Me.TableLayoutPanelGlobal = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridMatches = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cboCompetition = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ComboBoxSceneVersion = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanelGlobal.SuspendLayout()
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelGlobal
    '
    Me.TableLayoutPanelGlobal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanelGlobal.ColumnCount = 2
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroGridMatches, 0, 1)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.cboCompetition, 0, 0)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.Label1, 0, 2)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.ComboBoxSceneVersion, 1, 2)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(8, 12)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 3
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(805, 576)
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
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnDate, Me.ColumnDescription, Me.ColumnHomeTeam, Me.ColumnAwayTeam, Me.ColumnResult})
    Me.TableLayoutPanelGlobal.SetColumnSpan(Me.MetroGridMatches, 2)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
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
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatches.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridMatches.RowHeadersVisible = False
    Me.MetroGridMatches.RowHeadersWidth = 10
    Me.MetroGridMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatches.ShowCellErrors = False
    Me.MetroGridMatches.ShowCellToolTips = False
    Me.MetroGridMatches.ShowEditingIcon = False
    Me.MetroGridMatches.ShowRowErrors = False
    Me.MetroGridMatches.Size = New System.Drawing.Size(799, 500)
    Me.MetroGridMatches.TabIndex = 47
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Width = 60
    '
    'ColumnDate
    '
    Me.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDate.HeaderText = "Date"
    Me.ColumnDate.Name = "ColumnDate"
    Me.ColumnDate.ReadOnly = True
    Me.ColumnDate.Width = 64
    '
    'ColumnDescription
    '
    Me.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDescription.HeaderText = "Description"
    Me.ColumnDescription.Name = "ColumnDescription"
    Me.ColumnDescription.ReadOnly = True
    Me.ColumnDescription.Visible = False
    '
    'ColumnHomeTeam
    '
    Me.ColumnHomeTeam.HeaderText = "Home team"
    Me.ColumnHomeTeam.Name = "ColumnHomeTeam"
    Me.ColumnHomeTeam.ReadOnly = True
    '
    'ColumnAwayTeam
    '
    Me.ColumnAwayTeam.HeaderText = "Away team"
    Me.ColumnAwayTeam.Name = "ColumnAwayTeam"
    Me.ColumnAwayTeam.ReadOnly = True
    '
    'ColumnResult
    '
    Me.ColumnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnResult.HeaderText = "Result"
    Me.ColumnResult.Name = "ColumnResult"
    Me.ColumnResult.ReadOnly = True
    '
    'cboCompetition
    '
    Me.TableLayoutPanelGlobal.SetColumnSpan(Me.cboCompetition, 2)
    Me.cboCompetition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cboCompetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCompetition.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCompetition.FormattingEnabled = True
    Me.cboCompetition.ItemHeight = 17
    Me.cboCompetition.Location = New System.Drawing.Point(3, 3)
    Me.cboCompetition.Name = "cboCompetition"
    Me.cboCompetition.Size = New System.Drawing.Size(799, 25)
    Me.cboCompetition.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(3, 541)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(144, 35)
    Me.Label1.TabIndex = 48
    Me.Label1.Text = "Scene version"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ComboBoxSceneVersion
    '
    Me.ComboBoxSceneVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBoxSceneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSceneVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxSceneVersion.FormattingEnabled = True
    Me.ComboBoxSceneVersion.Location = New System.Drawing.Point(153, 544)
    Me.ComboBoxSceneVersion.Name = "ComboBoxSceneVersion"
    Me.ComboBoxSceneVersion.Size = New System.Drawing.Size(649, 25)
    Me.ComboBoxSceneVersion.TabIndex = 49
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(656, 594)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 35)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 29)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 29)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'FormMatchSelector
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(825, 652)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanelGlobal)
    Me.Name = "FormMatchSelector"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Match selector"
    Me.TableLayoutPanelGlobal.ResumeLayout(False)
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Private WithEvents cboCompetition As System.Windows.Forms.ComboBox
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents MetroGridMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDate As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnResult As DataGridViewTextBoxColumn
  Friend WithEvents Label1 As Label
  Friend WithEvents ComboBoxSceneVersion As ComboBox
End Class
