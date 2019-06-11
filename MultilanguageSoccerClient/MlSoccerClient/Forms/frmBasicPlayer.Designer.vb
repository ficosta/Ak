<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBasicPlayer
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelVizEngine = New System.Windows.Forms.Label()
    Me.MenuStrip1.SuspendLayout()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(855, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'SettingsToolStripMenuItem
    '
    Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
    Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.SettingsToolStripMenuItem.Text = "Settings..."
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
    '
    'CloseToolStripMenuItem
    '
    Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
    Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.CloseToolStripMenuItem.Text = "Close"
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 5
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelVizEngine, 0, 3)
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(124, 42)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 4
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(370, 133)
    Me.TableLayoutPanelAll.TabIndex = 1
    '
    'LabelVizEngine
    '
    Me.LabelVizEngine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelVizEngine.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelVizEngine.Location = New System.Drawing.Point(3, 93)
    Me.LabelVizEngine.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
    Me.LabelVizEngine.Name = "LabelVizEngine"
    Me.LabelVizEngine.Size = New System.Drawing.Size(114, 37)
    Me.LabelVizEngine.TabIndex = 6
    Me.LabelVizEngine.Text = "Viz engine"
    Me.LabelVizEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'frmBasicPlayer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(855, 261)
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "frmBasicPlayer"
    Me.Text = "frmBasicPlayer"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
  Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents LabelVizEngine As Label
End Class
