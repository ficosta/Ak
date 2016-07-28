<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeriodControl_new
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.UcPeriod4 = New AkSocc.UCPeriod()
    Me.TableLayoutPanelOtherOptions = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonResetMatch = New System.Windows.Forms.Button()
    Me.MetroButtonOverwriteClock = New System.Windows.Forms.Button()
    Me.MetroButtonReloadDataBase = New System.Windows.Forms.Button()
    Me.UcPeriod3 = New AkSocc.UCPeriod()
    Me.UcPeriod2 = New AkSocc.UCPeriod()
    Me.UcPeriod1 = New AkSocc.UCPeriod()
    Me.msmPeriodControl = New MetroFramework.Components.MetroStyleManager(Me.components)
    Me.MetroGridPeriods = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnText = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelOverTime = New System.Windows.Forms.Label()
    Me.NumericUpDownMinutes = New System.Windows.Forms.NumericUpDown()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelOtherOptions.SuspendLayout()
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridPeriods, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 5
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod4, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelOtherOptions, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod3, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod2, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod1, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(293, 63)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(484, 104)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'UcPeriod4
    '
    Me.UcPeriod4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod4.Location = New System.Drawing.Point(291, 3)
    Me.UcPeriod4.Match = Nothing
    Me.UcPeriod4.Name = "UcPeriod4"
    Me.UcPeriod4.Period = Nothing
    Me.UcPeriod4.Size = New System.Drawing.Size(90, 98)
    Me.UcPeriod4.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod4.TabIndex = 3
    Me.UcPeriod4.UseSelectable = True
    '
    'TableLayoutPanelOtherOptions
    '
    Me.TableLayoutPanelOtherOptions.ColumnCount = 1
    Me.TableLayoutPanelOtherOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButtonResetMatch, 0, 0)
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButtonOverwriteClock, 0, 1)
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButtonReloadDataBase, 0, 2)
    Me.TableLayoutPanelOtherOptions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelOtherOptions.Location = New System.Drawing.Point(387, 3)
    Me.TableLayoutPanelOtherOptions.Name = "TableLayoutPanelOtherOptions"
    Me.TableLayoutPanelOtherOptions.RowCount = 3
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.Size = New System.Drawing.Size(94, 98)
    Me.TableLayoutPanelOtherOptions.TabIndex = 3
    '
    'MetroButtonResetMatch
    '
    Me.MetroButtonResetMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonResetMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonResetMatch.Location = New System.Drawing.Point(3, 3)
    Me.MetroButtonResetMatch.Name = "MetroButtonResetMatch"
    Me.MetroButtonResetMatch.Size = New System.Drawing.Size(88, 26)
    Me.MetroButtonResetMatch.TabIndex = 0
    Me.MetroButtonResetMatch.Text = "Reset Match"
    '
    'MetroButtonOverwriteClock
    '
    Me.MetroButtonOverwriteClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonOverwriteClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonOverwriteClock.Location = New System.Drawing.Point(3, 35)
    Me.MetroButtonOverwriteClock.Name = "MetroButtonOverwriteClock"
    Me.MetroButtonOverwriteClock.Size = New System.Drawing.Size(88, 26)
    Me.MetroButtonOverwriteClock.TabIndex = 1
    Me.MetroButtonOverwriteClock.Text = "Overwrite clock"
    '
    'MetroButtonReloadDataBase
    '
    Me.MetroButtonReloadDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonReloadDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonReloadDataBase.Location = New System.Drawing.Point(3, 67)
    Me.MetroButtonReloadDataBase.Name = "MetroButtonReloadDataBase"
    Me.MetroButtonReloadDataBase.Size = New System.Drawing.Size(88, 28)
    Me.MetroButtonReloadDataBase.TabIndex = 2
    Me.MetroButtonReloadDataBase.Text = "Reload data base"
    '
    'UcPeriod3
    '
    Me.UcPeriod3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod3.Location = New System.Drawing.Point(195, 3)
    Me.UcPeriod3.Match = Nothing
    Me.UcPeriod3.Name = "UcPeriod3"
    Me.UcPeriod3.Period = Nothing
    Me.UcPeriod3.Size = New System.Drawing.Size(90, 98)
    Me.UcPeriod3.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod3.TabIndex = 2
    Me.UcPeriod3.UseSelectable = True
    '
    'UcPeriod2
    '
    Me.UcPeriod2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod2.Location = New System.Drawing.Point(99, 3)
    Me.UcPeriod2.Match = Nothing
    Me.UcPeriod2.Name = "UcPeriod2"
    Me.UcPeriod2.Period = Nothing
    Me.UcPeriod2.Size = New System.Drawing.Size(90, 98)
    Me.UcPeriod2.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod2.TabIndex = 1
    Me.UcPeriod2.UseSelectable = True
    '
    'UcPeriod1
    '
    Me.UcPeriod1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod1.Location = New System.Drawing.Point(3, 3)
    Me.UcPeriod1.Match = Nothing
    Me.UcPeriod1.Name = "UcPeriod1"
    Me.UcPeriod1.Period = Nothing
    Me.UcPeriod1.Size = New System.Drawing.Size(90, 98)
    Me.UcPeriod1.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod1.TabIndex = 0
    Me.UcPeriod1.UseSelectable = True
    '
    'msmPeriodControl
    '
    Me.msmPeriodControl.Owner = Nothing
    '
    'MetroGridPeriods
    '
    Me.MetroGridPeriods.AllowUserToAddRows = False
    Me.MetroGridPeriods.AllowUserToDeleteRows = False
    Me.MetroGridPeriods.AllowUserToResizeRows = False
    Me.MetroGridPeriods.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPeriods.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridPeriods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridPeriods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle73.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle73.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPeriods.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle73
    Me.MetroGridPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridPeriods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnType, Me.ColumnText})
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroGridPeriods, 2)
    DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle74.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle74.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle74.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle74.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridPeriods.DefaultCellStyle = DataGridViewCellStyle74
    Me.MetroGridPeriods.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridPeriods.EnableHeadersVisualStyles = False
    Me.MetroGridPeriods.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridPeriods.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPeriods.Location = New System.Drawing.Point(3, 3)
    Me.MetroGridPeriods.Name = "MetroGridPeriods"
    Me.MetroGridPeriods.ReadOnly = True
    Me.MetroGridPeriods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle75.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle75.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPeriods.RowHeadersDefaultCellStyle = DataGridViewCellStyle75
    Me.MetroGridPeriods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridPeriods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridPeriods.Size = New System.Drawing.Size(258, 343)
    Me.MetroGridPeriods.TabIndex = 3
    '
    'ColumnID
    '
    Me.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Width = 41
    '
    'ColumnType
    '
    Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnType.HeaderText = "Type"
    Me.ColumnType.Name = "ColumnType"
    Me.ColumnType.ReadOnly = True
    Me.ColumnType.Width = 53
    '
    'ColumnText
    '
    Me.ColumnText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnText.HeaderText = "Text"
    Me.ColumnText.Name = "ColumnText"
    Me.ColumnText.ReadOnly = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.LabelOverTime, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroGridPeriods, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDownMinutes, 1, 1)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 63)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 2
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 384)
    Me.TableLayoutPanel2.TabIndex = 4
    '
    'LabelOverTime
    '
    Me.LabelOverTime.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOverTime.Location = New System.Drawing.Point(3, 349)
    Me.LabelOverTime.Name = "LabelOverTime"
    Me.LabelOverTime.Size = New System.Drawing.Size(126, 35)
    Me.LabelOverTime.TabIndex = 5
    Me.LabelOverTime.Text = "Over time"
    Me.LabelOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'NumericUpDownMinutes
    '
    Me.NumericUpDownMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownMinutes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownMinutes.Location = New System.Drawing.Point(135, 352)
    Me.NumericUpDownMinutes.Name = "NumericUpDownMinutes"
    Me.NumericUpDownMinutes.Size = New System.Drawing.Size(126, 25)
    Me.NumericUpDownMinutes.TabIndex = 6
    '
    'FormPeriodControl_new
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 470)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormPeriodControl_new"
    Me.Resizable = False
    Me.Style = MetroFramework.MetroColorStyle.Orange
    Me.Text = "Match control"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelOtherOptions.ResumeLayout(False)
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridPeriods, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents UcPeriod4 As UCPeriod
  Friend WithEvents UcPeriod3 As UCPeriod
  Friend WithEvents UcPeriod2 As UCPeriod
  Friend WithEvents UcPeriod1 As UCPeriod
  Friend WithEvents msmPeriodControl As MetroFramework.Components.MetroStyleManager
  Friend WithEvents TableLayoutPanelOtherOptions As TableLayoutPanel
  Friend WithEvents MetroButtonResetMatch As Button
  Friend WithEvents MetroButtonOverwriteClock As Button
  Friend WithEvents MetroButtonReloadDataBase As Button
  Friend WithEvents MetroGridPeriods As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnText As DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents LabelOverTime As System.Windows.Forms.Label
  Friend WithEvents NumericUpDownMinutes As NumericUpDown
End Class
