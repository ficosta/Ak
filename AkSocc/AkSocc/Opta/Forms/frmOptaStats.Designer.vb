<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptaStats
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanelButtons = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
    Me.MetroGridTeamStats = New MetroFramework.Controls.MetroGrid()
    Me.ColumnOptaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnOptaAppName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnOptaShowInFullFrame = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ColumnOptaShowInLower3rd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
    Me.MetroGridPlayerStats = New MetroFramework.Controls.MetroGrid()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelButtons.SuspendLayout()
    Me.MetroTabControl1.SuspendLayout()
    Me.MetroTabPage1.SuspendLayout()
    CType(Me.MetroGridTeamStats, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MetroTabPage2.SuspendLayout()
    CType(Me.MetroGridPlayerStats, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelButtons, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroTabControl1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 407)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'TableLayoutPanelButtons
    '
    Me.TableLayoutPanelButtons.ColumnCount = 4
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanelButtons.Controls.Add(Me.OK_Button, 2, 0)
    Me.TableLayoutPanelButtons.Controls.Add(Me.Cancel_Button, 3, 0)
    Me.TableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelButtons.Location = New System.Drawing.Point(3, 375)
    Me.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons"
    Me.TableLayoutPanelButtons.RowCount = 1
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelButtons.Size = New System.Drawing.Size(847, 29)
    Me.TableLayoutPanelButtons.TabIndex = 2
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(690, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(770, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'MetroTabControl1
    '
    Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
    Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
    Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTabControl1.Location = New System.Drawing.Point(3, 3)
    Me.MetroTabControl1.Name = "MetroTabControl1"
    Me.MetroTabControl1.SelectedIndex = 0
    Me.MetroTabControl1.Size = New System.Drawing.Size(847, 366)
    Me.MetroTabControl1.TabIndex = 3
    Me.MetroTabControl1.UseSelectable = True
    '
    'MetroTabPage1
    '
    Me.MetroTabPage1.Controls.Add(Me.MetroGridTeamStats)
    Me.MetroTabPage1.HorizontalScrollbarBarColor = True
    Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
    Me.MetroTabPage1.HorizontalScrollbarSize = 10
    Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
    Me.MetroTabPage1.Name = "MetroTabPage1"
    Me.MetroTabPage1.Size = New System.Drawing.Size(839, 324)
    Me.MetroTabPage1.TabIndex = 0
    Me.MetroTabPage1.Text = "Team stats"
    Me.MetroTabPage1.VerticalScrollbarBarColor = True
    Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
    Me.MetroTabPage1.VerticalScrollbarSize = 10
    '
    'MetroGridTeamStats
    '
    Me.MetroGridTeamStats.AllowUserToDeleteRows = False
    Me.MetroGridTeamStats.AllowUserToResizeRows = False
    Me.MetroGridTeamStats.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamStats.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridTeamStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridTeamStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamStats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridTeamStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridTeamStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnOptaName, Me.ColumnOptaAppName, Me.ColumnOptaShowInFullFrame, Me.ColumnOptaShowInLower3rd})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridTeamStats.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridTeamStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridTeamStats.EnableHeadersVisualStyles = False
    Me.MetroGridTeamStats.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridTeamStats.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamStats.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridTeamStats.Name = "MetroGridTeamStats"
    Me.MetroGridTeamStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamStats.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridTeamStats.RowHeadersVisible = False
    Me.MetroGridTeamStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridTeamStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridTeamStats.Size = New System.Drawing.Size(839, 324)
    Me.MetroGridTeamStats.TabIndex = 2
    '
    'ColumnOptaName
    '
    Me.ColumnOptaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnOptaName.HeaderText = "OptaName"
    Me.ColumnOptaName.Name = "ColumnOptaName"
    Me.ColumnOptaName.ReadOnly = True
    Me.ColumnOptaName.Width = 85
    '
    'ColumnOptaAppName
    '
    Me.ColumnOptaAppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnOptaAppName.HeaderText = "App name"
    Me.ColumnOptaAppName.Name = "ColumnOptaAppName"
    '
    'ColumnOptaShowInFullFrame
    '
    Me.ColumnOptaShowInFullFrame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnOptaShowInFullFrame.HeaderText = "Show in full frame"
    Me.ColumnOptaShowInFullFrame.Name = "ColumnOptaShowInFullFrame"
    Me.ColumnOptaShowInFullFrame.Width = 68
    '
    'ColumnOptaShowInLower3rd
    '
    Me.ColumnOptaShowInLower3rd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnOptaShowInLower3rd.HeaderText = "Show in lower 3rd"
    Me.ColumnOptaShowInLower3rd.Name = "ColumnOptaShowInLower3rd"
    Me.ColumnOptaShowInLower3rd.Width = 79
    '
    'MetroTabPage2
    '
    Me.MetroTabPage2.Controls.Add(Me.MetroGridPlayerStats)
    Me.MetroTabPage2.HorizontalScrollbarBarColor = True
    Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
    Me.MetroTabPage2.HorizontalScrollbarSize = 10
    Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
    Me.MetroTabPage2.Name = "MetroTabPage2"
    Me.MetroTabPage2.Size = New System.Drawing.Size(839, 324)
    Me.MetroTabPage2.TabIndex = 1
    Me.MetroTabPage2.Text = "Player stats"
    Me.MetroTabPage2.VerticalScrollbarBarColor = True
    Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
    Me.MetroTabPage2.VerticalScrollbarSize = 10
    '
    'MetroGridPlayerStats
    '
    Me.MetroGridPlayerStats.AllowUserToDeleteRows = False
    Me.MetroGridPlayerStats.AllowUserToResizeRows = False
    Me.MetroGridPlayerStats.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPlayerStats.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridPlayerStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridPlayerStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPlayerStats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridPlayerStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridPlayerStats.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridPlayerStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridPlayerStats.EnableHeadersVisualStyles = False
    Me.MetroGridPlayerStats.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridPlayerStats.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPlayerStats.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridPlayerStats.Name = "MetroGridPlayerStats"
    Me.MetroGridPlayerStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPlayerStats.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridPlayerStats.RowHeadersVisible = False
    Me.MetroGridPlayerStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridPlayerStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridPlayerStats.Size = New System.Drawing.Size(839, 324)
    Me.MetroGridPlayerStats.TabIndex = 3
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.HeaderText = "OptaName"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = 85
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.HeaderText = "App name"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewCheckBoxColumn1
    '
    Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewCheckBoxColumn1.HeaderText = "Show in full frame"
    Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
    Me.DataGridViewCheckBoxColumn1.Width = 68
    '
    'DataGridViewCheckBoxColumn2
    '
    Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewCheckBoxColumn2.HeaderText = "Show in lower 3rd"
    Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
    Me.DataGridViewCheckBoxColumn2.Width = 79
    '
    'frmOptaStats
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(853, 407)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmOptaStats"
    Me.Text = "Opta stats"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelButtons.ResumeLayout(False)
    Me.MetroTabControl1.ResumeLayout(False)
    Me.MetroTabPage1.ResumeLayout(False)
    CType(Me.MetroGridTeamStats, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MetroTabPage2.ResumeLayout(False)
    CType(Me.MetroGridPlayerStats, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents TableLayoutPanelButtons As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
  Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents MetroGridTeamStats As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnOptaName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnOptaAppName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnOptaShowInFullFrame As DataGridViewCheckBoxColumn
  Friend WithEvents ColumnOptaShowInLower3rd As DataGridViewCheckBoxColumn
  Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents MetroGridPlayerStats As MetroFramework.Controls.MetroGrid
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
