<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogPreview
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanelPreview = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelTitle = New System.Windows.Forms.Label()
    Me.SplitContainerPreview = New System.Windows.Forms.SplitContainer()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DataGridViewParameters = New System.Windows.Forms.DataGridView()
    Me.ButtonPreview = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelPreview.SuspendLayout()
    CType(Me.SplitContainerPreview, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerPreview.Panel1.SuspendLayout()
    Me.SplitContainerPreview.Panel2.SuspendLayout()
    Me.SplitContainerPreview.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.DataGridViewParameters, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(563, 421)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
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
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'TableLayoutPanelPreview
    '
    Me.TableLayoutPanelPreview.ColumnCount = 1
    Me.TableLayoutPanelPreview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelPreview.Controls.Add(Me.LabelTitle, 0, 0)
    Me.TableLayoutPanelPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelPreview.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelPreview.Name = "TableLayoutPanelPreview"
    Me.TableLayoutPanelPreview.RowCount = 2
    Me.TableLayoutPanelPreview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPreview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPreview.Size = New System.Drawing.Size(400, 403)
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
    'SplitContainerPreview
    '
    Me.SplitContainerPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainerPreview.Location = New System.Drawing.Point(12, 12)
    Me.SplitContainerPreview.Name = "SplitContainerPreview"
    '
    'SplitContainerPreview.Panel1
    '
    Me.SplitContainerPreview.Panel1.Controls.Add(Me.TableLayoutPanelPreview)
    '
    'SplitContainerPreview.Panel2
    '
    Me.SplitContainerPreview.Panel2.Controls.Add(Me.TableLayoutPanel2)
    Me.SplitContainerPreview.Size = New System.Drawing.Size(697, 403)
    Me.SplitContainerPreview.SplitterDistance = 400
    Me.SplitContainerPreview.TabIndex = 2
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.DataGridViewParameters, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonPreview, 0, 3)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(293, 403)
    Me.TableLayoutPanel2.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Label1"
    '
    'DataGridViewParameters
    '
    Me.DataGridViewParameters.AllowUserToAddRows = False
    Me.DataGridViewParameters.AllowUserToDeleteRows = False
    Me.DataGridViewParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridViewParameters, 2)
    Me.DataGridViewParameters.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewParameters.Location = New System.Drawing.Point(3, 63)
    Me.DataGridViewParameters.Name = "DataGridViewParameters"
    Me.DataGridViewParameters.Size = New System.Drawing.Size(287, 307)
    Me.DataGridViewParameters.TabIndex = 8
    '
    'ButtonPreview
    '
    Me.ButtonPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonPreview.Location = New System.Drawing.Point(3, 376)
    Me.ButtonPreview.Name = "ButtonPreview"
    Me.ButtonPreview.Size = New System.Drawing.Size(114, 24)
    Me.ButtonPreview.TabIndex = 9
    Me.ButtonPreview.Text = "Preview"
    Me.ButtonPreview.UseVisualStyleBackColor = True
    '
    'DialogPreview
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(721, 462)
    Me.Controls.Add(Me.SplitContainerPreview)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogPreview"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "DialogPreview"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelPreview.ResumeLayout(False)
    Me.TableLayoutPanelPreview.PerformLayout()
    Me.SplitContainerPreview.Panel1.ResumeLayout(False)
    Me.SplitContainerPreview.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerPreview.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    CType(Me.DataGridViewParameters, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanelPreview As TableLayoutPanel
  Friend WithEvents LabelTitle As Label
  Friend WithEvents SplitContainerPreview As SplitContainer
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents Label1 As Label
  Friend WithEvents DataGridViewParameters As DataGridView
  Friend WithEvents ButtonPreview As Button
End Class
