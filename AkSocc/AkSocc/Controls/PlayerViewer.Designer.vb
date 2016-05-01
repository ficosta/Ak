<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerViewer
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
    Me.TableLayoutPanelPlayer = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelCards = New System.Windows.Forms.Label()
    Me.LabelName = New System.Windows.Forms.Label()
    Me.LabelDorsal = New System.Windows.Forms.Label()
    Me.TableLayoutPanelPlayer.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelPlayer
    '
    Me.TableLayoutPanelPlayer.ColumnCount = 3
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelCards, 2, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelName, 1, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelDorsal, 0, 0)
    Me.TableLayoutPanelPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelPlayer.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelPlayer.Name = "TableLayoutPanelPlayer"
    Me.TableLayoutPanelPlayer.RowCount = 1
    Me.TableLayoutPanelPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.TabIndex = 0
    '
    'LabelCards
    '
    Me.LabelCards.BackColor = System.Drawing.Color.White
    Me.LabelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelCards.Location = New System.Drawing.Point(725, 0)
    Me.LabelCards.Name = "LabelCards"
    Me.LabelCards.Size = New System.Drawing.Size(34, 32)
    Me.LabelCards.TabIndex = 2
    Me.LabelCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelName
    '
    Me.LabelName.BackColor = System.Drawing.Color.White
    Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelName.Location = New System.Drawing.Point(43, 0)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(676, 32)
    Me.LabelName.TabIndex = 1
    Me.LabelName.Text = "PLAYER NAME"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelDorsal
    '
    Me.LabelDorsal.BackColor = System.Drawing.Color.White
    Me.LabelDorsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelDorsal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelDorsal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelDorsal.Location = New System.Drawing.Point(3, 0)
    Me.LabelDorsal.Name = "LabelDorsal"
    Me.LabelDorsal.Size = New System.Drawing.Size(34, 32)
    Me.LabelDorsal.TabIndex = 0
    Me.LabelDorsal.Text = "00"
    Me.LabelDorsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'PlayerViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelPlayer)
    Me.Name = "PlayerViewer"
    Me.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelPlayer As TableLayoutPanel
  Friend WithEvents LabelCards As Label
  Friend WithEvents LabelName As Label
  Friend WithEvents LabelDorsal As Label
End Class
