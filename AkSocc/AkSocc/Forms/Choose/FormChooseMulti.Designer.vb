<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChooseMulti
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridStats = New MetroFramework.Controls.MetroGrid()
    Me.ColumnStatsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnStatsName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroGridSelected = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnMoveUp = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.ColumnMoveDown = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.ColumnRemove = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.MetroLabelTitle = New System.Windows.Forms.Label()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me._ucPreview = New VizCommands.UCPreview()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelAll.SuspendLayout()
    CType(Me.MetroGridStats, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridSelected, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerAll.Panel1.SuspendLayout()
    Me.SplitContainerAll.Panel2.SuspendLayout()
    Me.SplitContainerAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(1061, 541)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroGridStats, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroGridSelected, 0, 2)
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroLabelTitle, 0, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 3
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(494, 472)
    Me.TableLayoutPanelAll.TabIndex = 6
    '
    'MetroGridStats
    '
    Me.MetroGridStats.AllowUserToAddRows = False
    Me.MetroGridStats.AllowUserToDeleteRows = False
    Me.MetroGridStats.AllowUserToResizeColumns = False
    Me.MetroGridStats.AllowUserToResizeRows = False
    Me.MetroGridStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.MetroGridStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
    Me.MetroGridStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnStatsID, Me.ColumnStatsName})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridStats.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridStats.EnableHeadersVisualStyles = False
    Me.MetroGridStats.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridStats.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridStats.HighLightPercentage = 50.0!
    Me.MetroGridStats.Location = New System.Drawing.Point(4, 45)
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
    Me.MetroGridStats.RowHeadersWidth = 10
    Me.MetroGridStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridStats.ShowCellErrors = False
    Me.MetroGridStats.ShowCellToolTips = False
    Me.MetroGridStats.ShowEditingIcon = False
    Me.MetroGridStats.ShowRowErrors = False
    Me.MetroGridStats.Size = New System.Drawing.Size(486, 238)
    Me.MetroGridStats.TabIndex = 11
    '
    'ColumnStatsID
    '
    Me.ColumnStatsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnStatsID.HeaderText = "ColumnID"
    Me.ColumnStatsID.Name = "ColumnStatsID"
    Me.ColumnStatsID.ReadOnly = True
    Me.ColumnStatsID.Visible = False
    '
    'ColumnStatsName
    '
    Me.ColumnStatsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnStatsName.HeaderText = "Option"
    Me.ColumnStatsName.Name = "ColumnStatsName"
    Me.ColumnStatsName.ReadOnly = True
    '
    'MetroGridSelected
    '
    Me.MetroGridSelected.AllowUserToAddRows = False
    Me.MetroGridSelected.AllowUserToDeleteRows = False
    Me.MetroGridSelected.AllowUserToResizeColumns = False
    Me.MetroGridSelected.AllowUserToResizeRows = False
    Me.MetroGridSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.MetroGridSelected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.MetroGridSelected.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridSelected.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridSelected.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridSelected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnName, Me.ColumnMoveUp, Me.ColumnMoveDown, Me.ColumnRemove})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridSelected.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridSelected.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridSelected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridSelected.EnableHeadersVisualStyles = False
    Me.MetroGridSelected.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridSelected.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridSelected.HighLightPercentage = 50.0!
    Me.MetroGridSelected.Location = New System.Drawing.Point(4, 290)
    Me.MetroGridSelected.Name = "MetroGridSelected"
    Me.MetroGridSelected.ReadOnly = True
    Me.MetroGridSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridSelected.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridSelected.RowHeadersVisible = False
    Me.MetroGridSelected.RowHeadersWidth = 10
    Me.MetroGridSelected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridSelected.ShowCellErrors = False
    Me.MetroGridSelected.ShowCellToolTips = False
    Me.MetroGridSelected.ShowEditingIcon = False
    Me.MetroGridSelected.ShowRowErrors = False
    Me.MetroGridSelected.Size = New System.Drawing.Size(486, 178)
    Me.MetroGridSelected.TabIndex = 10
    '
    'ColumnID
    '
    Me.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnID.HeaderText = "ColumnID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Visible = False
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnName.HeaderText = "Option"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    '
    'ColumnMoveUp
    '
    Me.ColumnMoveUp.HeaderText = "Move up"
    Me.ColumnMoveUp.Name = "ColumnMoveUp"
    Me.ColumnMoveUp.ReadOnly = True
    Me.ColumnMoveUp.Visible = False
    Me.ColumnMoveUp.Width = 56
    '
    'ColumnMoveDown
    '
    Me.ColumnMoveDown.HeaderText = "Down"
    Me.ColumnMoveDown.Name = "ColumnMoveDown"
    Me.ColumnMoveDown.ReadOnly = True
    Me.ColumnMoveDown.Visible = False
    Me.ColumnMoveDown.Width = 42
    '
    'ColumnRemove
    '
    Me.ColumnRemove.HeaderText = "Remove"
    Me.ColumnRemove.Name = "ColumnRemove"
    Me.ColumnRemove.ReadOnly = True
    Me.ColumnRemove.Width = 51
    '
    'MetroLabelTitle
    '
    Me.MetroLabelTitle.AutoSize = True
    Me.MetroLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelTitle.Location = New System.Drawing.Point(4, 1)
    Me.MetroLabelTitle.Name = "MetroLabelTitle"
    Me.MetroLabelTitle.Size = New System.Drawing.Size(486, 40)
    Me.MetroLabelTitle.TabIndex = 4
    '
    'SplitContainerAll
    '
    Me.SplitContainerAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainerAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
    Me.SplitContainerAll.Location = New System.Drawing.Point(23, 63)
    Me.SplitContainerAll.Name = "SplitContainerAll"
    '
    'SplitContainerAll.Panel1
    '
    Me.SplitContainerAll.Panel1.Controls.Add(Me.TableLayoutPanelAll)
    '
    'SplitContainerAll.Panel2
    '
    Me.SplitContainerAll.Panel2.Controls.Add(Me._ucPreview)
    Me.SplitContainerAll.Size = New System.Drawing.Size(1181, 472)
    Me.SplitContainerAll.SplitterDistance = 494
    Me.SplitContainerAll.TabIndex = 7
    '
    '_ucPreview
    '
    Me._ucPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me._ucPreview.Location = New System.Drawing.Point(0, 0)
    Me._ucPreview.Name = "_ucPreview"
    Me._ucPreview.PreviewControl = Nothing
    Me._ucPreview.Scene = Nothing
    Me._ucPreview.ShowAdvancedControls = False
    Me._ucPreview.Size = New System.Drawing.Size(683, 472)
    Me._ucPreview.TabIndex = 0
    Me._ucPreview.Title = "Title"
    Me._ucPreview.VizControl = Nothing
    '
    'FormChooseMulti
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1230, 593)
    Me.Controls.Add(Me.SplitContainerAll)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "FormChooseMulti"
    Me.Text = "Graphic options"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    CType(Me.MetroGridStats, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridSelected, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerAll.Panel1.ResumeLayout(False)
    Me.SplitContainerAll.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerAll.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents SplitContainerAll As SplitContainer
  Friend WithEvents _ucPreview As VizCommands.UCPreview
  Friend WithEvents MetroLabelTitle As System.Windows.Forms.Label
  Friend WithEvents MetroGridSelected As MetroFramework.Controls.MetroGrid
  Friend WithEvents MetroGridStats As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnStatsID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnStatsName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnMoveUp As DataGridViewButtonColumn
  Friend WithEvents ColumnMoveDown As DataGridViewButtonColumn
  Friend WithEvents ColumnRemove As DataGridViewButtonColumn
End Class
