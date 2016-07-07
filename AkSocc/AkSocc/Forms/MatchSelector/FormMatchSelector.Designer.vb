<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMatchSelector
  Inherits MetroFramework.Forms.MetroForm

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
    Me.cboCompetition = New MetroFramework.Controls.MetroComboBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.TableLayoutPanelGlobal.ColumnCount = 1
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.MetroGridMatches, 0, 1)
    Me.TableLayoutPanelGlobal.Controls.Add(Me.cboCompetition, 0, 0)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(8, 64)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 2
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(794, 530)
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
    Me.MetroGridMatches.RowHeadersWidth = 10
    Me.MetroGridMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatches.ShowCellErrors = False
    Me.MetroGridMatches.ShowCellToolTips = False
    Me.MetroGridMatches.ShowEditingIcon = False
    Me.MetroGridMatches.ShowRowErrors = False
    Me.MetroGridMatches.Size = New System.Drawing.Size(788, 489)
    Me.MetroGridMatches.TabIndex = 47
    '
    'cboCompetition
    '
    Me.cboCompetition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cboCompetition.FormattingEnabled = True
    Me.cboCompetition.ItemHeight = 23
    Me.cboCompetition.Location = New System.Drawing.Point(3, 3)
    Me.cboCompetition.Name = "cboCompetition"
    Me.cboCompetition.Size = New System.Drawing.Size(788, 29)
    Me.cboCompetition.TabIndex = 1
    Me.cboCompetition.UseSelectable = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(656, 600)
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
    Me.ColumnDescription.Width = 108
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
    'FormMatchSelector
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(825, 652)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanelGlobal)
    Me.Name = "FormMatchSelector"
    Me.Style = MetroFramework.MetroColorStyle.Orange
    Me.Text = "Match selector"
    Me.TableLayoutPanelGlobal.ResumeLayout(False)
    CType(Me.MetroGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Private WithEvents cboCompetition As MetroFramework.Controls.MetroComboBox
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroGridMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDate As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayTeam As DataGridViewTextBoxColumn
  Friend WithEvents ColumnResult As DataGridViewTextBoxColumn
End Class
