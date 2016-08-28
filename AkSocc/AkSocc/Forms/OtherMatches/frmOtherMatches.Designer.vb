<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatchDay
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.TableLayoutPanelMatchDays = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridMatchDay = New MetroFramework.Controls.MetroGrid()
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ContextMenuStripMatchDays = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.NewMatchDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.DeleteMatchDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ComboBoxCompetitions = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanelUCOtherMatches = New System.Windows.Forms.TableLayoutPanel()
    Me.UcOtherMatch9 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch8 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch7 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch6 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch5 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch4 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch3 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch2 = New AkSocc.UCOtherMatch()
    Me.UcOtherMatch1 = New AkSocc.UCOtherMatch()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.TableLayoutPanelMatchDays.SuspendLayout()
    CType(Me.MetroGridMatchDay, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStripMatchDays.SuspendLayout()
    Me.TableLayoutPanelUCOtherMatches.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 618)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1133, 29)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.OK_Button.Location = New System.Drawing.Point(979, 3)
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
    Me.Cancel_Button.Location = New System.Drawing.Point(1059, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(23, 12)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanelMatchDays)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanelUCOtherMatches)
    Me.SplitContainer1.Size = New System.Drawing.Size(1133, 600)
    Me.SplitContainer1.SplitterDistance = 181
    Me.SplitContainer1.TabIndex = 2
    '
    'TableLayoutPanelMatchDays
    '
    Me.TableLayoutPanelMatchDays.ColumnCount = 1
    Me.TableLayoutPanelMatchDays.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMatchDays.Controls.Add(Me.MetroGridMatchDay, 0, 1)
    Me.TableLayoutPanelMatchDays.Controls.Add(Me.ComboBoxCompetitions, 0, 0)
    Me.TableLayoutPanelMatchDays.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelMatchDays.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelMatchDays.Name = "TableLayoutPanelMatchDays"
    Me.TableLayoutPanelMatchDays.RowCount = 2
    Me.TableLayoutPanelMatchDays.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelMatchDays.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMatchDays.Size = New System.Drawing.Size(181, 600)
    Me.TableLayoutPanelMatchDays.TabIndex = 49
    '
    'MetroGridMatchDay
    '
    Me.MetroGridMatchDay.AllowUserToAddRows = False
    Me.MetroGridMatchDay.AllowUserToDeleteRows = False
    Me.MetroGridMatchDay.AllowUserToResizeColumns = False
    Me.MetroGridMatchDay.AllowUserToResizeRows = False
    Me.MetroGridMatchDay.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatchDay.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridMatchDay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridMatchDay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchDay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridMatchDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatchDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColumnDescription})
    Me.MetroGridMatchDay.ContextMenuStrip = Me.ContextMenuStripMatchDays
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatchDay.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridMatchDay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
    Me.MetroGridMatchDay.EnableHeadersVisualStyles = False
    Me.MetroGridMatchDay.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatchDay.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatchDay.Location = New System.Drawing.Point(3, 38)
    Me.MetroGridMatchDay.MultiSelect = False
    Me.MetroGridMatchDay.Name = "MetroGridMatchDay"
    Me.MetroGridMatchDay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchDay.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridMatchDay.RowHeadersVisible = False
    Me.MetroGridMatchDay.RowHeadersWidth = 10
    Me.MetroGridMatchDay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatchDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatchDay.ShowCellErrors = False
    Me.MetroGridMatchDay.ShowCellToolTips = False
    Me.MetroGridMatchDay.ShowRowErrors = False
    Me.MetroGridMatchDay.Size = New System.Drawing.Size(175, 559)
    Me.MetroGridMatchDay.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroGridMatchDay.TabIndex = 48
    '
    'Column1
    '
    Me.Column1.HeaderText = "ColumnID"
    Me.Column1.Name = "Column1"
    Me.Column1.Visible = False
    Me.Column1.Width = 60
    '
    'ColumnDescription
    '
    Me.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnDescription.HeaderText = "Description"
    Me.ColumnDescription.Name = "ColumnDescription"
    '
    'ContextMenuStripMatchDays
    '
    Me.ContextMenuStripMatchDays.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMatchDayToolStripMenuItem, Me.DeleteMatchDayToolStripMenuItem})
    Me.ContextMenuStripMatchDays.Name = "ContextMenuStripMatchDays"
    Me.ContextMenuStripMatchDays.Size = New System.Drawing.Size(176, 48)
    '
    'NewMatchDayToolStripMenuItem
    '
    Me.NewMatchDayToolStripMenuItem.Name = "NewMatchDayToolStripMenuItem"
    Me.NewMatchDayToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
    Me.NewMatchDayToolStripMenuItem.Text = "New match day..."
    '
    'DeleteMatchDayToolStripMenuItem
    '
    Me.DeleteMatchDayToolStripMenuItem.Name = "DeleteMatchDayToolStripMenuItem"
    Me.DeleteMatchDayToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
    Me.DeleteMatchDayToolStripMenuItem.Text = "Delete match day..."
    '
    'ComboBoxCompetitions
    '
    Me.ComboBoxCompetitions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBoxCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxCompetitions.Enabled = False
    Me.ComboBoxCompetitions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxCompetitions.FormattingEnabled = True
    Me.ComboBoxCompetitions.Location = New System.Drawing.Point(3, 3)
    Me.ComboBoxCompetitions.Name = "ComboBoxCompetitions"
    Me.ComboBoxCompetitions.Size = New System.Drawing.Size(175, 25)
    Me.ComboBoxCompetitions.TabIndex = 49
    '
    'TableLayoutPanelUCOtherMatches
    '
    Me.TableLayoutPanelUCOtherMatches.AutoScroll = True
    Me.TableLayoutPanelUCOtherMatches.AutoSize = True
    Me.TableLayoutPanelUCOtherMatches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.TableLayoutPanelUCOtherMatches.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanelUCOtherMatches.ColumnCount = 1
    Me.TableLayoutPanelUCOtherMatches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch9, 0, 8)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch8, 0, 7)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch7, 0, 6)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch6, 0, 5)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch5, 0, 4)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch4, 0, 3)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch3, 0, 2)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch2, 0, 1)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.UcOtherMatch1, 0, 0)
    Me.TableLayoutPanelUCOtherMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelUCOtherMatches.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelUCOtherMatches.Name = "TableLayoutPanelUCOtherMatches"
    Me.TableLayoutPanelUCOtherMatches.RowCount = 10
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelUCOtherMatches.Size = New System.Drawing.Size(948, 600)
    Me.TableLayoutPanelUCOtherMatches.TabIndex = 0
    '
    'UcOtherMatch9
    '
    Me.UcOtherMatch9.ArrowDownVisible = True
    Me.UcOtherMatch9.ArrowUpVisible = True
    Me.UcOtherMatch9.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch9.Competition = Nothing
    Me.UcOtherMatch9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch9.Location = New System.Drawing.Point(4, 604)
    Me.UcOtherMatch9.Matches = Nothing
    Me.UcOtherMatch9.Name = "UcOtherMatch9"
    Me.UcOtherMatch9.OtherMatchInfo = Nothing
    Me.UcOtherMatch9.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch9.TabIndex = 8
    Me.UcOtherMatch9.UseSelectable = True
    '
    'UcOtherMatch8
    '
    Me.UcOtherMatch8.ArrowDownVisible = True
    Me.UcOtherMatch8.ArrowUpVisible = True
    Me.UcOtherMatch8.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch8.Competition = Nothing
    Me.UcOtherMatch8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch8.Location = New System.Drawing.Point(4, 529)
    Me.UcOtherMatch8.Matches = Nothing
    Me.UcOtherMatch8.Name = "UcOtherMatch8"
    Me.UcOtherMatch8.OtherMatchInfo = Nothing
    Me.UcOtherMatch8.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch8.TabIndex = 7
    Me.UcOtherMatch8.UseSelectable = True
    '
    'UcOtherMatch7
    '
    Me.UcOtherMatch7.ArrowDownVisible = True
    Me.UcOtherMatch7.ArrowUpVisible = True
    Me.UcOtherMatch7.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch7.Competition = Nothing
    Me.UcOtherMatch7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch7.Location = New System.Drawing.Point(4, 454)
    Me.UcOtherMatch7.Matches = Nothing
    Me.UcOtherMatch7.Name = "UcOtherMatch7"
    Me.UcOtherMatch7.OtherMatchInfo = Nothing
    Me.UcOtherMatch7.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch7.TabIndex = 6
    Me.UcOtherMatch7.UseSelectable = True
    '
    'UcOtherMatch6
    '
    Me.UcOtherMatch6.ArrowDownVisible = True
    Me.UcOtherMatch6.ArrowUpVisible = True
    Me.UcOtherMatch6.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch6.Competition = Nothing
    Me.UcOtherMatch6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch6.Location = New System.Drawing.Point(4, 379)
    Me.UcOtherMatch6.Matches = Nothing
    Me.UcOtherMatch6.Name = "UcOtherMatch6"
    Me.UcOtherMatch6.OtherMatchInfo = Nothing
    Me.UcOtherMatch6.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch6.TabIndex = 5
    Me.UcOtherMatch6.UseSelectable = True
    '
    'UcOtherMatch5
    '
    Me.UcOtherMatch5.ArrowDownVisible = True
    Me.UcOtherMatch5.ArrowUpVisible = True
    Me.UcOtherMatch5.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch5.Competition = Nothing
    Me.UcOtherMatch5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch5.Location = New System.Drawing.Point(4, 304)
    Me.UcOtherMatch5.Matches = Nothing
    Me.UcOtherMatch5.Name = "UcOtherMatch5"
    Me.UcOtherMatch5.OtherMatchInfo = Nothing
    Me.UcOtherMatch5.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch5.TabIndex = 4
    Me.UcOtherMatch5.UseSelectable = True
    '
    'UcOtherMatch4
    '
    Me.UcOtherMatch4.ArrowDownVisible = True
    Me.UcOtherMatch4.ArrowUpVisible = True
    Me.UcOtherMatch4.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch4.Competition = Nothing
    Me.UcOtherMatch4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch4.Location = New System.Drawing.Point(4, 229)
    Me.UcOtherMatch4.Matches = Nothing
    Me.UcOtherMatch4.Name = "UcOtherMatch4"
    Me.UcOtherMatch4.OtherMatchInfo = Nothing
    Me.UcOtherMatch4.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch4.TabIndex = 3
    Me.UcOtherMatch4.UseSelectable = True
    '
    'UcOtherMatch3
    '
    Me.UcOtherMatch3.ArrowDownVisible = True
    Me.UcOtherMatch3.ArrowUpVisible = True
    Me.UcOtherMatch3.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch3.Competition = Nothing
    Me.UcOtherMatch3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch3.Location = New System.Drawing.Point(4, 154)
    Me.UcOtherMatch3.Matches = Nothing
    Me.UcOtherMatch3.Name = "UcOtherMatch3"
    Me.UcOtherMatch3.OtherMatchInfo = Nothing
    Me.UcOtherMatch3.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch3.TabIndex = 2
    Me.UcOtherMatch3.UseSelectable = True
    '
    'UcOtherMatch2
    '
    Me.UcOtherMatch2.ArrowDownVisible = True
    Me.UcOtherMatch2.ArrowUpVisible = True
    Me.UcOtherMatch2.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch2.Competition = Nothing
    Me.UcOtherMatch2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch2.Location = New System.Drawing.Point(4, 79)
    Me.UcOtherMatch2.Matches = Nothing
    Me.UcOtherMatch2.Name = "UcOtherMatch2"
    Me.UcOtherMatch2.OtherMatchInfo = Nothing
    Me.UcOtherMatch2.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch2.TabIndex = 1
    Me.UcOtherMatch2.UseSelectable = True
    '
    'UcOtherMatch1
    '
    Me.UcOtherMatch1.ArrowDownVisible = True
    Me.UcOtherMatch1.ArrowUpVisible = True
    Me.UcOtherMatch1.ButtonActionEnum = AkSocc.UCOtherMatch.eButtonAction.AddNew
    Me.UcOtherMatch1.Competition = Nothing
    Me.UcOtherMatch1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOtherMatch1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UcOtherMatch1.Location = New System.Drawing.Point(4, 4)
    Me.UcOtherMatch1.Matches = Nothing
    Me.UcOtherMatch1.Name = "UcOtherMatch1"
    Me.UcOtherMatch1.OtherMatchInfo = Nothing
    Me.UcOtherMatch1.Size = New System.Drawing.Size(940, 68)
    Me.UcOtherMatch1.TabIndex = 0
    Me.UcOtherMatch1.UseSelectable = True
    '
    'frmMatchDay
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(1179, 670)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmMatchDay"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Other matches"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.TableLayoutPanelMatchDays.ResumeLayout(False)
    CType(Me.MetroGridMatchDay, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStripMatchDays.ResumeLayout(False)
    Me.TableLayoutPanelUCOtherMatches.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As Button
  Friend WithEvents Cancel_Button As Button
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents MetroGridMatchDay As MetroFramework.Controls.MetroGrid
  Friend WithEvents Column1 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
  Friend WithEvents ContextMenuStripMatchDays As ContextMenuStrip
  Friend WithEvents NewMatchDayToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents DeleteMatchDayToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TableLayoutPanelUCOtherMatches As TableLayoutPanel
  Friend WithEvents UcOtherMatch1 As UCOtherMatch
  Friend WithEvents UcOtherMatch9 As UCOtherMatch
  Friend WithEvents UcOtherMatch8 As UCOtherMatch
  Friend WithEvents UcOtherMatch7 As UCOtherMatch
  Friend WithEvents UcOtherMatch6 As UCOtherMatch
  Friend WithEvents UcOtherMatch5 As UCOtherMatch
  Friend WithEvents UcOtherMatch4 As UCOtherMatch
  Friend WithEvents UcOtherMatch3 As UCOtherMatch
  Friend WithEvents UcOtherMatch2 As UCOtherMatch
  Friend WithEvents TableLayoutPanelMatchDays As TableLayoutPanel
  Friend WithEvents ComboBoxCompetitions As ComboBox
End Class
