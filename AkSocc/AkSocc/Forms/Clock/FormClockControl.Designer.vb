<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClockControl
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
    Me.TableLayoutPanelControls = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonClockVisible = New System.Windows.Forms.Button()
    Me.ButtonShowRedCards = New System.Windows.Forms.Button()
    Me.ButtonShowSponsor = New System.Windows.Forms.Button()
    Me.ComboBoxSponsor = New System.Windows.Forms.ComboBox()
    Me.ButtonClockPosition = New System.Windows.Forms.Button()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanelTitle = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelTitle = New System.Windows.Forms.Label()
    Me.LabelClose = New System.Windows.Forms.Label()
    Me.TableLayoutPanelButtons.SuspendLayout()
    Me.TableLayoutPanelControls.SuspendLayout()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.TableLayoutPanelTitle.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelButtons
    '
    Me.TableLayoutPanelButtons.ColumnCount = 5
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonBottom, 2, 3)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonRight, 3, 2)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonUp, 2, 1)
    Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonLeft, 1, 2)
    Me.TableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelButtons.Location = New System.Drawing.Point(3, 276)
    Me.TableLayoutPanelButtons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons"
    Me.TableLayoutPanelButtons.RowCount = 5
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66667!))
    Me.TableLayoutPanelButtons.Size = New System.Drawing.Size(186, 142)
    Me.TableLayoutPanelButtons.TabIndex = 13
    '
    'ButtonBottom
    '
    Me.ButtonBottom.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonBottom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonBottom.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_down
    Me.ButtonBottom.Location = New System.Drawing.Point(76, 91)
    Me.ButtonBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonBottom.Name = "ButtonBottom"
    Me.ButtonBottom.Size = New System.Drawing.Size(34, 32)
    Me.ButtonBottom.TabIndex = 7
    Me.ButtonBottom.UseVisualStyleBackColor = True
    '
    'ButtonRight
    '
    Me.ButtonRight.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonRight.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonRight.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_right
    Me.ButtonRight.Location = New System.Drawing.Point(116, 51)
    Me.ButtonRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonRight.Name = "ButtonRight"
    Me.ButtonRight.Size = New System.Drawing.Size(34, 32)
    Me.ButtonRight.TabIndex = 6
    Me.ButtonRight.UseVisualStyleBackColor = True
    '
    'ButtonUp
    '
    Me.ButtonUp.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_up
    Me.ButtonUp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonUp.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_up
    Me.ButtonUp.Location = New System.Drawing.Point(76, 11)
    Me.ButtonUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonUp.Name = "ButtonUp"
    Me.ButtonUp.Size = New System.Drawing.Size(34, 32)
    Me.ButtonUp.TabIndex = 5
    Me.ButtonUp.UseVisualStyleBackColor = True
    '
    'ButtonLeft
    '
    Me.ButtonLeft.BackgroundImage = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonLeft.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonLeft.Image = Global.AkSocc.My.Resources.Resources.PS_Triangle_left
    Me.ButtonLeft.Location = New System.Drawing.Point(36, 51)
    Me.ButtonLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonLeft.Name = "ButtonLeft"
    Me.ButtonLeft.Size = New System.Drawing.Size(34, 32)
    Me.ButtonLeft.TabIndex = 4
    Me.ButtonLeft.UseVisualStyleBackColor = True
    '
    'TableLayoutPanelControls
    '
    Me.TableLayoutPanelControls.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanelControls.ColumnCount = 1
    Me.TableLayoutPanelControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelControls.Controls.Add(Me.ButtonClockVisible, 0, 0)
    Me.TableLayoutPanelControls.Controls.Add(Me.TableLayoutPanelButtons, 0, 6)
    Me.TableLayoutPanelControls.Controls.Add(Me.ButtonShowRedCards, 0, 2)
    Me.TableLayoutPanelControls.Controls.Add(Me.ButtonShowSponsor, 0, 3)
    Me.TableLayoutPanelControls.Controls.Add(Me.ComboBoxSponsor, 0, 4)
    Me.TableLayoutPanelControls.Controls.Add(Me.ButtonClockPosition, 0, 5)
    Me.TableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelControls.Location = New System.Drawing.Point(3, 34)
    Me.TableLayoutPanelControls.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelControls.Name = "TableLayoutPanelControls"
    Me.TableLayoutPanelControls.RowCount = 8
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelControls.Size = New System.Drawing.Size(192, 275)
    Me.TableLayoutPanelControls.TabIndex = 14
    '
    'ButtonClockVisible
    '
    Me.ButtonClockVisible.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonClockVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonClockVisible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonClockVisible.Location = New System.Drawing.Point(3, 4)
    Me.ButtonClockVisible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonClockVisible.Name = "ButtonClockVisible"
    Me.ButtonClockVisible.Size = New System.Drawing.Size(186, 52)
    Me.ButtonClockVisible.TabIndex = 18
    Me.ButtonClockVisible.Text = "Show / hide clock"
    Me.ButtonClockVisible.UseVisualStyleBackColor = True
    '
    'ButtonShowRedCards
    '
    Me.ButtonShowRedCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonShowRedCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonShowRedCards.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonShowRedCards.Location = New System.Drawing.Point(3, 84)
    Me.ButtonShowRedCards.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonShowRedCards.Name = "ButtonShowRedCards"
    Me.ButtonShowRedCards.Size = New System.Drawing.Size(186, 52)
    Me.ButtonShowRedCards.TabIndex = 14
    Me.ButtonShowRedCards.Text = "Show / hide red cards"
    Me.ButtonShowRedCards.UseVisualStyleBackColor = True
    '
    'ButtonShowSponsor
    '
    Me.ButtonShowSponsor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonShowSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonShowSponsor.Location = New System.Drawing.Point(3, 144)
    Me.ButtonShowSponsor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonShowSponsor.Name = "ButtonShowSponsor"
    Me.ButtonShowSponsor.Size = New System.Drawing.Size(186, 52)
    Me.ButtonShowSponsor.TabIndex = 15
    Me.ButtonShowSponsor.Text = "Show / hide sponsor"
    Me.ButtonShowSponsor.UseVisualStyleBackColor = True
    '
    'ComboBoxSponsor
    '
    Me.ComboBoxSponsor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBoxSponsor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSponsor.FormattingEnabled = True
    Me.ComboBoxSponsor.Location = New System.Drawing.Point(3, 204)
    Me.ComboBoxSponsor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBoxSponsor.Name = "ComboBoxSponsor"
    Me.ComboBoxSponsor.Size = New System.Drawing.Size(186, 25)
    Me.ComboBoxSponsor.TabIndex = 16
    '
    'ButtonClockPosition
    '
    Me.ButtonClockPosition.BackColor = System.Drawing.Color.WhiteSmoke
    Me.ButtonClockPosition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonClockPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonClockPosition.Location = New System.Drawing.Point(0, 239)
    Me.ButtonClockPosition.Margin = New System.Windows.Forms.Padding(0)
    Me.ButtonClockPosition.Name = "ButtonClockPosition"
    Me.ButtonClockPosition.Size = New System.Drawing.Size(192, 33)
    Me.ButtonClockPosition.TabIndex = 17
    Me.ButtonClockPosition.Text = "Clock position"
    Me.ButtonClockPosition.UseVisualStyleBackColor = False
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.TableLayoutPanelControls, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.TableLayoutPanelTitle, 0, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(198, 313)
    Me.TableLayoutPanelAll.TabIndex = 15
    '
    'TableLayoutPanelTitle
    '
    Me.TableLayoutPanelTitle.ColumnCount = 2
    Me.TableLayoutPanelTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelTitle.Controls.Add(Me.LabelTitle, 0, 0)
    Me.TableLayoutPanelTitle.Controls.Add(Me.LabelClose, 1, 0)
    Me.TableLayoutPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTitle.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanelTitle.Name = "TableLayoutPanelTitle"
    Me.TableLayoutPanelTitle.RowCount = 1
    Me.TableLayoutPanelTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelTitle.Size = New System.Drawing.Size(192, 24)
    Me.TableLayoutPanelTitle.TabIndex = 15
    '
    'LabelTitle
    '
    Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelTitle.Location = New System.Drawing.Point(3, 0)
    Me.LabelTitle.Name = "LabelTitle"
    Me.LabelTitle.Size = New System.Drawing.Size(156, 24)
    Me.LabelTitle.TabIndex = 0
    Me.LabelTitle.Text = "Title"
    Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelClose
    '
    Me.LabelClose.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelClose.Location = New System.Drawing.Point(165, 0)
    Me.LabelClose.Name = "LabelClose"
    Me.LabelClose.Size = New System.Drawing.Size(24, 24)
    Me.LabelClose.TabIndex = 1
    Me.LabelClose.Text = "X"
    Me.LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'FormClockControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Bisque
    Me.ClientSize = New System.Drawing.Size(198, 313)
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "FormClockControl"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Clock position"
    Me.TableLayoutPanelButtons.ResumeLayout(False)
    Me.TableLayoutPanelControls.ResumeLayout(False)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelTitle.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelButtons As TableLayoutPanel
  Friend WithEvents ButtonLeft As Button
  Friend WithEvents ButtonBottom As Button
  Friend WithEvents ButtonRight As Button
  Friend WithEvents ButtonUp As Button
  Friend WithEvents TableLayoutPanelControls As TableLayoutPanel
  Friend WithEvents ButtonShowRedCards As Button
  Friend WithEvents ButtonShowSponsor As Button
  Friend WithEvents ComboBoxSponsor As ComboBox
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents TableLayoutPanelTitle As TableLayoutPanel
  Friend WithEvents LabelTitle As Label
  Friend WithEvents LabelClose As Label
  Friend WithEvents ButtonClockPosition As Button
  Friend WithEvents ButtonClockVisible As Button
End Class
