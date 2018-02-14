<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocalFixtures
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptaFixtures))
    Me.MetroGridMatches = New MetroFramework.Controls.MetroGrid()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.ButtonEditTeamLinks = New System.Windows.Forms.Button()
    Me.ColumnMatchesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesOptaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesState = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesMatchDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMatchesScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
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
    Me.MetroGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnMatchesID, Me.ColumnMatchesOptaID, Me.ColumnMatchesState, Me.ColumnMatchesMatchDay, Me.ColumnHomeTeam, Me.ColumnMatchesScore, Me.ColumnAwayTeam})
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
    Me.MetroGridMatches.Location = New System.Drawing.Point(3, 3)
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
    Me.MetroGridMatches.Size = New System.Drawing.Size(791, 342)
    Me.MetroGridMatches.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroGridMatches, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(797, 388)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 4
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 3, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonEditTeamLinks, 0, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 351)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(791, 34)
    Me.TableLayoutPanel2.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(634, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 28)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(714, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 28)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'ButtonEditTeamLinks
    '
    Me.ButtonEditTeamLinks.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonEditTeamLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonEditTeamLinks.Location = New System.Drawing.Point(3, 3)
    Me.ButtonEditTeamLinks.Name = "ButtonEditTeamLinks"
    Me.ButtonEditTeamLinks.Size = New System.Drawing.Size(154, 28)
    Me.ButtonEditTeamLinks.TabIndex = 2
    Me.ButtonEditTeamLinks.Text = "Link teams..."
    Me.ButtonEditTeamLinks.UseVisualStyleBackColor = True
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
    'ColumnMatchesMatchDay
    '
    Me.ColumnMatchesMatchDay.HeaderText = "Match day"
    Me.ColumnMatchesMatchDay.Name = "ColumnMatchesMatchDay"
    Me.ColumnMatchesMatchDay.ReadOnly = True
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
    'frmOptaFixtures
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(797, 388)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmOptaFixtures"
    Me.Text = "Opta explorer"
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents MetroGridMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents ButtonEditTeamLinks As Button
  Friend WithEvents ColumnMatchesID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesOptaID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesState As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesMatchDay As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMatchesScore As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayTeam As DataGridViewTextBoxColumn
End Class
