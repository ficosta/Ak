<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChoose
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelTitle = New System.Windows.Forms.Label()
    Me.SplitContainerAll = New System.Windows.Forms.SplitContainer()
    Me._ucPreview = New VizCommands.UCPreview()
    Me.UserControlChoose4 = New AkSocc.UserControlChoose()
    Me.UserControlChoose3 = New AkSocc.UserControlChoose()
    Me.UserControlChoose2 = New AkSocc.UserControlChoose()
    Me.UserControlChoose1 = New AkSocc.UserControlChoose()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelAll.SuspendLayout()
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
    Me.TableLayoutPanelAll.ColumnCount = 4
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.UserControlChoose4, 3, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.UserControlChoose3, 2, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.UserControlChoose2, 1, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.UserControlChoose1, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroLabelTitle, 0, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(494, 472)
    Me.TableLayoutPanelAll.TabIndex = 6
    '
    'MetroLabelTitle
    '
    Me.MetroLabelTitle.AutoSize = True
    Me.TableLayoutPanelAll.SetColumnSpan(Me.MetroLabelTitle, 4)
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
    'UserControlChoose4
    '
    Me.UserControlChoose4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UserControlChoose4.GraphicStep = Nothing
    Me.UserControlChoose4.Index = 3
    Me.UserControlChoose4.Location = New System.Drawing.Point(373, 45)
    Me.UserControlChoose4.Name = "UserControlChoose4"
    Me.UserControlChoose4.Size = New System.Drawing.Size(117, 423)
    Me.UserControlChoose4.TabIndex = 3
    '
    'UserControlChoose3
    '
    Me.UserControlChoose3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UserControlChoose3.GraphicStep = Nothing
    Me.UserControlChoose3.Index = 2
    Me.UserControlChoose3.Location = New System.Drawing.Point(250, 45)
    Me.UserControlChoose3.Name = "UserControlChoose3"
    Me.UserControlChoose3.Size = New System.Drawing.Size(116, 423)
    Me.UserControlChoose3.TabIndex = 2
    '
    'UserControlChoose2
    '
    Me.UserControlChoose2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UserControlChoose2.GraphicStep = Nothing
    Me.UserControlChoose2.Index = 1
    Me.UserControlChoose2.Location = New System.Drawing.Point(127, 45)
    Me.UserControlChoose2.Name = "UserControlChoose2"
    Me.UserControlChoose2.Size = New System.Drawing.Size(116, 423)
    Me.UserControlChoose2.TabIndex = 1
    '
    'UserControlChoose1
    '
    Me.UserControlChoose1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UserControlChoose1.GraphicStep = Nothing
    Me.UserControlChoose1.Index = 0
    Me.UserControlChoose1.Location = New System.Drawing.Point(4, 45)
    Me.UserControlChoose1.Name = "UserControlChoose1"
    Me.UserControlChoose1.Size = New System.Drawing.Size(116, 423)
    Me.UserControlChoose1.TabIndex = 0
    '
    'FormChoose
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1230, 593)
    Me.Controls.Add(Me.SplitContainerAll)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "FormChoose"
    Me.Text = "Graphic options"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
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
  Friend WithEvents UserControlChoose4 As UserControlChoose
  Friend WithEvents UserControlChoose3 As UserControlChoose
  Friend WithEvents UserControlChoose2 As UserControlChoose
  Friend WithEvents UserControlChoose1 As UserControlChoose
  Friend WithEvents MetroLabelTitle As System.Windows.Forms.Label
End Class
