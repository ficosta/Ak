<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatchDay_new
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.MetroGridMatchDay = New MetroFramework.Controls.MetroGrid()
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ContextMenuStripMatchDays = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.NewMatchDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.DeleteMatchDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TableLayoutPanelUCOtherMatches = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 737)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1323, 29)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(1169, 3)
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
    Me.Cancel_Button.Location = New System.Drawing.Point(1249, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(23, 63)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.MetroGridMatchDay)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanelUCOtherMatches)
    Me.SplitContainer1.Size = New System.Drawing.Size(1323, 668)
    Me.SplitContainer1.SplitterDistance = 264
    Me.SplitContainer1.TabIndex = 2
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
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchDay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridMatchDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridMatchDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColumnDescription})
    Me.MetroGridMatchDay.ContextMenuStrip = Me.ContextMenuStripMatchDays
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridMatchDay.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridMatchDay.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridMatchDay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
    Me.MetroGridMatchDay.EnableHeadersVisualStyles = False
    Me.MetroGridMatchDay.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridMatchDay.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridMatchDay.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridMatchDay.MultiSelect = False
    Me.MetroGridMatchDay.Name = "MetroGridMatchDay"
    Me.MetroGridMatchDay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridMatchDay.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridMatchDay.RowHeadersVisible = False
    Me.MetroGridMatchDay.RowHeadersWidth = 10
    Me.MetroGridMatchDay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridMatchDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridMatchDay.ShowCellErrors = False
    Me.MetroGridMatchDay.ShowCellToolTips = False
    Me.MetroGridMatchDay.ShowRowErrors = False
    Me.MetroGridMatchDay.Size = New System.Drawing.Size(264, 668)
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
    'TableLayoutPanelUCOtherMatches
    '
    Me.TableLayoutPanelUCOtherMatches.AutoScroll = True
    Me.TableLayoutPanelUCOtherMatches.AutoSize = True
    Me.TableLayoutPanelUCOtherMatches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.TableLayoutPanelUCOtherMatches.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanelUCOtherMatches.ColumnCount = 1
    Me.TableLayoutPanelUCOtherMatches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label9, 0, 8)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label8, 0, 7)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label7, 0, 6)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label6, 0, 5)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label5, 0, 4)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label4, 0, 3)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label3, 0, 2)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label2, 0, 1)
    Me.TableLayoutPanelUCOtherMatches.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanelUCOtherMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelUCOtherMatches.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelUCOtherMatches.Name = "TableLayoutPanelUCOtherMatches"
    Me.TableLayoutPanelUCOtherMatches.RowCount = 10
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
    Me.TableLayoutPanelUCOtherMatches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelUCOtherMatches.Size = New System.Drawing.Size(1055, 668)
    Me.TableLayoutPanelUCOtherMatches.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(4, 1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1047, 73)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Label1"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Location = New System.Drawing.Point(4, 75)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(1047, 73)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Label2"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Location = New System.Drawing.Point(4, 149)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(1047, 73)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Label3"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label4.Location = New System.Drawing.Point(4, 223)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(1047, 73)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Label4"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label5.Location = New System.Drawing.Point(4, 297)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(1047, 73)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Label5"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label6.Location = New System.Drawing.Point(4, 371)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(1047, 73)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "Label6"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label7.Location = New System.Drawing.Point(4, 445)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(1047, 73)
    Me.Label7.TabIndex = 6
    Me.Label7.Text = "Label7"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label8.Location = New System.Drawing.Point(4, 519)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(1047, 73)
    Me.Label8.TabIndex = 7
    Me.Label8.Text = "Label8"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label9.Location = New System.Drawing.Point(4, 593)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(1047, 73)
    Me.Label9.TabIndex = 8
    Me.Label9.Text = "Label9"
    '
    'frmMatchDay_new
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1369, 789)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmMatchDay_new"
    Me.Resizable = False
    Me.Text = "Other matches"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.MetroGridMatchDay, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStripMatchDays.ResumeLayout(False)
    Me.TableLayoutPanelUCOtherMatches.ResumeLayout(False)
    Me.TableLayoutPanelUCOtherMatches.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents MetroGridMatchDay As MetroFramework.Controls.MetroGrid
  Friend WithEvents Column1 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
  Friend WithEvents ContextMenuStripMatchDays As ContextMenuStrip
  Friend WithEvents NewMatchDayToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents DeleteMatchDayToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TableLayoutPanelUCOtherMatches As TableLayoutPanel
  Friend WithEvents Label9 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
