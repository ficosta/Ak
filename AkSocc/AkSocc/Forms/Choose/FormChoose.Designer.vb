<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChoose
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
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me._ucPreview = New VizCommands.UCPreview()
    Me.TableLayoutPanel1.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(962, 498)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 4
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
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 1
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(635, 429)
    Me.TableLayoutPanelAll.TabIndex = 6
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
    Me.SplitContainerAll.Size = New System.Drawing.Size(1082, 429)
    Me.SplitContainerAll.SplitterDistance = 635
    Me.SplitContainerAll.TabIndex = 7
    '
    '_ucPreview
    '
    Me._ucPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me._ucPreview.Location = New System.Drawing.Point(0, 0)
    Me._ucPreview.Name = "_ucPreview"
    Me._ucPreview.PreviewControl = Nothing
    Me._ucPreview.Scene = Nothing
    Me._ucPreview.ShowAdvancedControls = True
    Me._ucPreview.Size = New System.Drawing.Size(443, 429)
    Me._ucPreview.TabIndex = 0
    Me._ucPreview.Title = "Title"
    Me._ucPreview.VizControl = Nothing
    '
    'FormChoose
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(1131, 550)
    Me.Controls.Add(Me.SplitContainerAll)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "FormChoose"
    Me.Text = "Graphic options"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.SplitContainerAll.Panel1.ResumeLayout(False)
    Me.SplitContainerAll.Panel2.ResumeLayout(False)
    CType(Me.SplitContainerAll, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerAll.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents SplitContainerAll As SplitContainer
  Friend WithEvents _ucPreview As VizCommands.UCPreview
End Class
