<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClockPosition
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
    Me.TableLayoutPanelButtons = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonBottom = New System.Windows.Forms.Button()
    Me.ButtonRight = New System.Windows.Forms.Button()
    Me.ButtonUp = New System.Windows.Forms.Button()
    Me.ButtonLeft = New System.Windows.Forms.Button()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonShowRedCards = New System.Windows.Forms.Button()
    Me.TableLayoutPanelButtons.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelButtons
    '
    Me.TableLayoutPanelButtons.ColumnCount = 4
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonBottom, 1, 2)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonRight, 2, 1)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonUp, 1, 0)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonLeft, 0, 1)
    Me.TableLayoutPanelButtons.Location = New System.Drawing.Point(3, 107)
    Me.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons"
    Me.TableLayoutPanelButtons.RowCount = 4
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelButtons.Size = New System.Drawing.Size(145, 144)
    Me.TableLayoutPanelButtons.TabIndex = 13
    '
    'ButtonBottom
    '
    Me.ButtonBottom.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonBottom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonBottom.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_down
    Me.ButtonBottom.Location = New System.Drawing.Point(49, 95)
    Me.ButtonBottom.Name = "ButtonBottom"
    Me.ButtonBottom.Size = New System.Drawing.Size(40, 40)
    Me.ButtonBottom.TabIndex = 7
    Me.ButtonBottom.UseVisualStyleBackColor = True
    '
    'ButtonRight
    '
    Me.ButtonRight.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonRight.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonRight.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_right
    Me.ButtonRight.Location = New System.Drawing.Point(95, 49)
    Me.ButtonRight.Name = "ButtonRight"
    Me.ButtonRight.Size = New System.Drawing.Size(40, 40)
    Me.ButtonRight.TabIndex = 6
    Me.ButtonRight.UseVisualStyleBackColor = True
    '
    'ButtonUp
    '
    Me.ButtonUp.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_up
    Me.ButtonUp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonUp.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_up
    Me.ButtonUp.Location = New System.Drawing.Point(49, 3)
    Me.ButtonUp.Name = "ButtonUp"
    Me.ButtonUp.Size = New System.Drawing.Size(40, 40)
    Me.ButtonUp.TabIndex = 5
    Me.ButtonUp.UseVisualStyleBackColor = True
    '
    'ButtonLeft
    '
    Me.ButtonLeft.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonLeft.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonLeft.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonLeft.Location = New System.Drawing.Point(3, 49)
    Me.ButtonLeft.Name = "ButtonLeft"
    Me.ButtonLeft.Size = New System.Drawing.Size(40, 40)
    Me.ButtonLeft.TabIndex = 4
    Me.ButtonLeft.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 1
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanelButtons, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonShowRedCards, 0, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 3
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(151, 254)
    Me.TableLayoutPanel2.TabIndex = 14
    '
    'ButtonShowRedCards
    '
    Me.ButtonShowRedCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonShowRedCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonShowRedCards.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonShowRedCards.Location = New System.Drawing.Point(3, 3)
    Me.ButtonShowRedCards.Name = "ButtonShowRedCards"
    Me.ButtonShowRedCards.Size = New System.Drawing.Size(145, 78)
    Me.ButtonShowRedCards.TabIndex = 14
    Me.ButtonShowRedCards.Text = "Show / hide red cards"
    Me.ButtonShowRedCards.UseVisualStyleBackColor = True
    '
    'FormClockPosition
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(151, 254)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "FormClockPosition"
    Me.Text = "Clock position"
    Me.TableLayoutPanelButtons.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelButtons As TableLayoutPanel
  Friend WithEvents ButtonLeft As Button
  Friend WithEvents ButtonBottom As Button
  Friend WithEvents ButtonRight As Button
  Friend WithEvents ButtonUp As Button
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents ButtonShowRedCards As Button
End Class
