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
    Me.SplitContainerPreview = New System.Windows.Forms.SplitContainer()
    Me.TableLayoutPanelPreview = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelTitle = New MetroFramework.Controls.MetroLabel()
    Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.DataGridViewParameters = New MetroFramework.Controls.MetroGrid()
    Me.ButtonPreview = New MetroFramework.Controls.MetroButton()
    CType(Me.SplitContainerPreview, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerPreview.Panel1.SuspendLayout()
    Me.SplitContainerPreview.Panel2.SuspendLayout()
    Me.SplitContainerPreview.SuspendLayout()
    Me.TableLayoutPanelPreview.SuspendLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.DataGridViewParameters, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.DataGridViewParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridViewParameters, 2)
    Me.DataGridViewParameters.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewParameters.Location = New System.Drawing.Point(3, 3)
    Me.DataGridViewParameters.Name = "DataGridViewParameters"
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
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents SplitContainerPreview As System.Windows.Forms.SplitContainer
  Friend WithEvents TableLayoutPanelPreview As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelTitle As MetroFramework.Controls.MetroLabel
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents DataGridViewParameters As MetroFramework.Controls.MetroGrid
  Friend WithEvents ButtonPreview As MetroFramework.Controls.MetroButton
  Friend WithEvents PictureBoxCanvas As System.Windows.Forms.PictureBox
End Class
