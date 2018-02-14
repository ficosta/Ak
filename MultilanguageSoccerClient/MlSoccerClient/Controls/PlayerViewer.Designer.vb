<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerViewer
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.TableLayoutPanelPlayer = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelGoals = New MetroFramework.Controls.MetroLabel()
    Me.MetroContextMenuPlayer = New MetroFramework.Controls.MetroContextMenu(Me.components)
    Me.CardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.YellowCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SecondYellowCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.RedCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RemoveGoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.LabelName = New MetroFramework.Controls.MetroLabel()
    Me.LabelDorsal = New MetroFramework.Controls.MetroLabel()
    Me.PictureBoxCards = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanelPlayer.SuspendLayout()
    Me.MetroContextMenuPlayer.SuspendLayout()
    CType(Me.PictureBoxCards, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelPlayer
    '
    Me.TableLayoutPanelPlayer.ColumnCount = 4
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelGoals, 2, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelName, 1, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelDorsal, 0, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.PictureBoxCards, 3, 0)
    Me.TableLayoutPanelPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelPlayer.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelPlayer.Name = "TableLayoutPanelPlayer"
    Me.TableLayoutPanelPlayer.RowCount = 1
    Me.TableLayoutPanelPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.TabIndex = 0
    '
    'LabelGoals
    '
    Me.LabelGoals.BackColor = System.Drawing.Color.White
    Me.LabelGoals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelGoals.ContextMenuStrip = Me.MetroContextMenuPlayer
    Me.LabelGoals.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelGoals.Location = New System.Drawing.Point(685, 3)
    Me.LabelGoals.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelGoals.Name = "LabelGoals"
    Me.LabelGoals.Size = New System.Drawing.Size(34, 26)
    Me.LabelGoals.TabIndex = 5
    Me.LabelGoals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'MetroContextMenuPlayer
    '
    Me.MetroContextMenuPlayer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardsToolStripMenuItem, Me.GoalToolStripMenuItem, Me.RemoveGoalToolStripMenuItem})
    Me.MetroContextMenuPlayer.Name = "MetroContextMenuPlayer"
    Me.MetroContextMenuPlayer.Size = New System.Drawing.Size(144, 70)
    '
    'CardsToolStripMenuItem
    '
    Me.CardsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YellowCardToolStripMenuItem, Me.SecondYellowCardToolStripMenuItem, Me.ToolStripMenuItem1, Me.RedCardToolStripMenuItem})
    Me.CardsToolStripMenuItem.Name = "CardsToolStripMenuItem"
    Me.CardsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
    Me.CardsToolStripMenuItem.Text = "Cards"
    '
    'YellowCardToolStripMenuItem
    '
    Me.YellowCardToolStripMenuItem.CheckOnClick = True
    Me.YellowCardToolStripMenuItem.Name = "YellowCardToolStripMenuItem"
    Me.YellowCardToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
    Me.YellowCardToolStripMenuItem.Text = "Yellow card"
    '
    'SecondYellowCardToolStripMenuItem
    '
    Me.SecondYellowCardToolStripMenuItem.CheckOnClick = True
    Me.SecondYellowCardToolStripMenuItem.Name = "SecondYellowCardToolStripMenuItem"
    Me.SecondYellowCardToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
    Me.SecondYellowCardToolStripMenuItem.Text = "Second yellow card"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
    '
    'RedCardToolStripMenuItem
    '
    Me.RedCardToolStripMenuItem.CheckOnClick = True
    Me.RedCardToolStripMenuItem.Name = "RedCardToolStripMenuItem"
    Me.RedCardToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
    Me.RedCardToolStripMenuItem.Text = "Red card"
    '
    'GoalToolStripMenuItem
    '
    Me.GoalToolStripMenuItem.Name = "GoalToolStripMenuItem"
    Me.GoalToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
    Me.GoalToolStripMenuItem.Text = "Goal!"
    '
    'RemoveGoalToolStripMenuItem
    '
    Me.RemoveGoalToolStripMenuItem.Name = "RemoveGoalToolStripMenuItem"
    Me.RemoveGoalToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
    Me.RemoveGoalToolStripMenuItem.Text = "Remove goal"
    '
    'LabelName
    '
    Me.LabelName.BackColor = System.Drawing.Color.White
    Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelName.ContextMenuStrip = Me.MetroContextMenuPlayer
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(43, 3)
    Me.LabelName.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(636, 26)
    Me.LabelName.TabIndex = 1
    Me.LabelName.Text = "PLAYER NAME"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelDorsal
    '
    Me.LabelDorsal.BackColor = System.Drawing.Color.White
    Me.LabelDorsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelDorsal.ContextMenuStrip = Me.MetroContextMenuPlayer
    Me.LabelDorsal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelDorsal.Location = New System.Drawing.Point(3, 3)
    Me.LabelDorsal.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelDorsal.Name = "LabelDorsal"
    Me.LabelDorsal.Size = New System.Drawing.Size(34, 26)
    Me.LabelDorsal.TabIndex = 0
    Me.LabelDorsal.Text = "00"
    Me.LabelDorsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'PictureBoxCards
    '
    Me.PictureBoxCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxCards.Location = New System.Drawing.Point(725, 3)
    Me.PictureBoxCards.Name = "PictureBoxCards"
    Me.PictureBoxCards.Size = New System.Drawing.Size(34, 26)
    Me.PictureBoxCards.TabIndex = 4
    Me.PictureBoxCards.TabStop = False
    '
    'PlayerViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelPlayer)
    Me.Name = "PlayerViewer"
    Me.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.ResumeLayout(False)
    Me.MetroContextMenuPlayer.ResumeLayout(False)
    CType(Me.PictureBoxCards, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelPlayer As TableLayoutPanel
  Friend WithEvents LabelName As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelDorsal As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroContextMenuPlayer As MetroFramework.Controls.MetroContextMenu
  Friend WithEvents CardsToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents YellowCardToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents SecondYellowCardToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
  Friend WithEvents RedCardToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents GoalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents RemoveGoalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents PictureBoxCards As PictureBox
  Friend WithEvents LabelGoals As MetroFramework.Controls.MetroLabel
End Class
