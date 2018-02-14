<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPreview
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.SplitContainerPreview = New System.Windows.Forms.SplitContainer()
    Me.TableLayoutPanelPreview = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelTitle = New System.Windows.Forms.Label()
    Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.DataGridViewParameters = New MetroFramework.Controls.MetroGrid()
    Me.ButtonPreview = New System.Windows.Forms.Button()
    Me.ContextMenuStripParameters = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.CopyParameterNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.CopyParameterValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.SplitContainerPreview, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerPreview.Panel1.SuspendLayout()
    Me.SplitContainerPreview.Panel2.SuspendLayout()
    Me.SplitContainerPreview.SuspendLayout()
    Me.TableLayoutPanelPreview.SuspendLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.DataGridViewParameters, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStripParameters.SuspendLayout()
    Me.SuspendLayout()
    '
    'SplitContainerPreview
    '
    Me.SplitContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainerPreview.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainerPreview.Name = "SplitContainerPreview"
    Me.SplitContainerPreview.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainerPreview.Panel1
    '
    Me.SplitContainerPreview.Panel1.Controls.Add(Me.TableLayoutPanelPreview)
    '
    'SplitContainerPreview.Panel2
    '
    Me.SplitContainerPreview.Panel2.Controls.Add(Me.TableLayoutPanel2)
    Me.SplitContainerPreview.Size = New System.Drawing.Size(822, 431)
    Me.SplitContainerPreview.SplitterDistance = 261
    Me.SplitContainerPreview.TabIndex = 3
    '
    'TableLayoutPanelPreview
    '
    Me.TableLayoutPanelPreview.ColumnCount = 1
    Me.TableLayoutPanelPreview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelPreview.Controls.Add(Me.LabelTitle, 0, 0)
    Me.TableLayoutPanelPreview.Controls.Add(Me.PictureBoxCanvas, 0, 1)
    Me.TableLayoutPanelPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelPreview.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelPreview.Name = "TableLayoutPanelPreview"
    Me.TableLayoutPanelPreview.RowCount = 2
    Me.TableLayoutPanelPreview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPreview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPreview.Size = New System.Drawing.Size(822, 261)
    Me.TableLayoutPanelPreview.TabIndex = 1
    '
    'LabelTitle
    '
    Me.LabelTitle.AutoSize = True
    Me.LabelTitle.Location = New System.Drawing.Point(3, 0)
    Me.LabelTitle.Name = "LabelTitle"
    Me.LabelTitle.Size = New System.Drawing.Size(27, 13)
    Me.LabelTitle.TabIndex = 0
    Me.LabelTitle.Text = "Title"
    '
    'PictureBoxCanvas
    '
    Me.PictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxCanvas.Location = New System.Drawing.Point(3, 43)
    Me.PictureBoxCanvas.Name = "PictureBoxCanvas"
    Me.PictureBoxCanvas.Size = New System.Drawing.Size(816, 215)
    Me.PictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxCanvas.TabIndex = 1
    Me.PictureBoxCanvas.TabStop = False
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.DataGridViewParameters, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonPreview, 0, 1)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 2
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(822, 166)
    Me.TableLayoutPanel2.TabIndex = 7
    '
    'DataGridViewParameters
    '
    Me.DataGridViewParameters.AllowUserToAddRows = False
    Me.DataGridViewParameters.AllowUserToDeleteRows = False
    Me.DataGridViewParameters.AllowUserToResizeRows = False
    Me.DataGridViewParameters.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.DataGridViewParameters.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.DataGridViewParameters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.DataGridViewParameters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewParameters.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridViewParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridViewParameters, 2)
    Me.DataGridViewParameters.ContextMenuStrip = Me.ContextMenuStripParameters
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewParameters.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridViewParameters.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewParameters.EnableHeadersVisualStyles = False
    Me.DataGridViewParameters.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.DataGridViewParameters.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.DataGridViewParameters.Location = New System.Drawing.Point(3, 3)
    Me.DataGridViewParameters.Name = "DataGridViewParameters"
    Me.DataGridViewParameters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewParameters.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridViewParameters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.DataGridViewParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewParameters.Size = New System.Drawing.Size(816, 130)
    Me.DataGridViewParameters.TabIndex = 8
    '
    'ButtonPreview
    '
    Me.ButtonPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonPreview.Location = New System.Drawing.Point(3, 139)
    Me.ButtonPreview.Name = "ButtonPreview"
    Me.ButtonPreview.Size = New System.Drawing.Size(114, 24)
    Me.ButtonPreview.TabIndex = 9
    Me.ButtonPreview.Text = "Preview"
    '
    'ContextMenuStripParameters
    '
    Me.ContextMenuStripParameters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyParameterNameToolStripMenuItem, Me.CopyParameterValueToolStripMenuItem})
    Me.ContextMenuStripParameters.Name = "ContextMenuStripParameters"
    Me.ContextMenuStripParameters.Size = New System.Drawing.Size(193, 48)
    '
    'CopyParameterNameToolStripMenuItem
    '
    Me.CopyParameterNameToolStripMenuItem.Name = "CopyParameterNameToolStripMenuItem"
    Me.CopyParameterNameToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.CopyParameterNameToolStripMenuItem.Text = "Copy parameter name"
    '
    'CopyParameterValueToolStripMenuItem
    '
    Me.CopyParameterValueToolStripMenuItem.Name = "CopyParameterValueToolStripMenuItem"
    Me.CopyParameterValueToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.CopyParameterValueToolStripMenuItem.Text = "Copy parameter value"
    '
    'UCPreview
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.SplitContainerPreview)
    Me.Name = "UCPreview"
    Me.Size = New System.Drawing.Size(822, 431)
    Me.SplitContainerPreview.Panel1.ResumeLayout(False)
    Me.SplitContainerPreview.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerPreview.ResumeLayout(False)
    Me.TableLayoutPanelPreview.ResumeLayout(False)
    Me.TableLayoutPanelPreview.PerformLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.DataGridViewParameters, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStripParameters.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents SplitContainerPreview As System.Windows.Forms.SplitContainer
  Friend WithEvents TableLayoutPanelPreview As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelTitle As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents DataGridViewParameters As MetroFramework.Controls.MetroGrid
  Friend WithEvents ButtonPreview As System.Windows.Forms.Button
  Friend WithEvents PictureBoxCanvas As System.Windows.Forms.PictureBox
  Friend WithEvents ContextMenuStripParameters As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents CopyParameterNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CopyParameterValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
