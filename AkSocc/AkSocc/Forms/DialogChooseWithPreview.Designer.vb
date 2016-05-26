<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogChooseWithPreview
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.SplitContainerOptions = New System.Windows.Forms.SplitContainer()
    Me.ListViewOptions = New System.Windows.Forms.ListView()
    Me.lstColOptions1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.lstColOptions2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.lstColOptions3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.lstColOptions4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.PictureBoxPreview = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainerOptions, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerOptions.Panel1.SuspendLayout()
    Me.SplitContainerOptions.Panel2.SuspendLayout()
    Me.SplitContainerOptions.SuspendLayout()
    CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(702, 377)
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
    'SplitContainerOptions
    '
    Me.SplitContainerOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainerOptions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
    Me.SplitContainerOptions.Location = New System.Drawing.Point(12, 12)
    Me.SplitContainerOptions.Name = "SplitContainerOptions"
    '
    'SplitContainerOptions.Panel1
    '
    Me.SplitContainerOptions.Panel1.Controls.Add(Me.ListViewOptions)
    '
    'SplitContainerOptions.Panel2
    '
    Me.SplitContainerOptions.Panel2.Controls.Add(Me.PictureBoxPreview)
    Me.SplitContainerOptions.Size = New System.Drawing.Size(836, 359)
    Me.SplitContainerOptions.SplitterDistance = 452
    Me.SplitContainerOptions.TabIndex = 1
    '
    'ListViewOptions
    '
    Me.ListViewOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstColOptions1, Me.lstColOptions2, Me.lstColOptions3, Me.lstColOptions4})
    Me.ListViewOptions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ListViewOptions.FullRowSelect = True
    Me.ListViewOptions.GridLines = True
    Me.ListViewOptions.Location = New System.Drawing.Point(0, 0)
    Me.ListViewOptions.MultiSelect = False
    Me.ListViewOptions.Name = "ListViewOptions"
    Me.ListViewOptions.Size = New System.Drawing.Size(452, 359)
    Me.ListViewOptions.TabIndex = 5
    Me.ListViewOptions.UseCompatibleStateImageBehavior = False
    Me.ListViewOptions.View = System.Windows.Forms.View.Details
    '
    'lstColOptions1
    '
    Me.lstColOptions1.Text = ""
    Me.lstColOptions1.Width = 180
    '
    'lstColOptions2
    '
    Me.lstColOptions2.Text = ""
    Me.lstColOptions2.Width = 180
    '
    'lstColOptions3
    '
    Me.lstColOptions3.Text = ""
    '
    'lstColOptions4
    '
    Me.lstColOptions4.Text = ""
    Me.lstColOptions4.Width = 0
    '
    'PictureBoxPreview
    '
    Me.PictureBoxPreview.BorderStyle = FormBorderStyle.FixedSingle
    Me.PictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxPreview.Location = New System.Drawing.Point(0, 0)
    Me.PictureBoxPreview.Name = "PictureBoxPreview"
    Me.PictureBoxPreview.Size = New System.Drawing.Size(380, 359)
    Me.PictureBoxPreview.TabIndex = 0
    Me.PictureBoxPreview.TabStop = False
    '
    'DialogChooseWithPreview
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(860, 418)
    Me.Controls.Add(Me.SplitContainerOptions)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogChooseWithPreview"
    Me.ShowInTaskbar = False
    Me.StartPosition = FormStartPosition.CenterParent
    Me.Text = "DialogChooseWithPreview"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.SplitContainerOptions.Panel1.ResumeLayout(False)
    Me.SplitContainerOptions.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerOptions, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerOptions.ResumeLayout(False)
    CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents SplitContainerOptions As SplitContainer
  Private WithEvents ListViewOptions As ListView
  Private WithEvents lstColOptions1 As ColumnHeader
  Private WithEvents lstColOptions2 As ColumnHeader
  Private WithEvents lstColOptions3 As ColumnHeader
  Private WithEvents lstColOptions4 As ColumnHeader
  Friend WithEvents PictureBoxPreview As PictureBox
End Class
