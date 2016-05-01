<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogMatchSetup
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
    Me.TableLayoutPanelGlobal = New System.Windows.Forms.TableLayoutPanel()
    Me.grpSelectMatch = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.label77 = New System.Windows.Forms.Label()
    Me.cboMatch = New System.Windows.Forms.ComboBox()
    Me.cboCompetition = New System.Windows.Forms.ComboBox()
    Me.label76 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelGlobal.SuspendLayout()
    Me.grpSelectMatch.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(823, 467)
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
    'TableLayoutPanelGlobal
    '
    Me.TableLayoutPanelGlobal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanelGlobal.ColumnCount = 2
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelGlobal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelGlobal.Controls.Add(Me.grpSelectMatch, 0, 0)
    Me.TableLayoutPanelGlobal.Location = New System.Drawing.Point(12, 12)
    Me.TableLayoutPanelGlobal.Name = "TableLayoutPanelGlobal"
    Me.TableLayoutPanelGlobal.RowCount = 2
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelGlobal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelGlobal.Size = New System.Drawing.Size(957, 449)
    Me.TableLayoutPanelGlobal.TabIndex = 1
    '
    'grpSelectMatch
    '
    Me.TableLayoutPanelGlobal.SetColumnSpan(Me.grpSelectMatch, 2)
    Me.grpSelectMatch.Controls.Add(Me.TableLayoutPanel3)
    Me.grpSelectMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpSelectMatch.Location = New System.Drawing.Point(3, 3)
    Me.grpSelectMatch.Name = "grpSelectMatch"
    Me.grpSelectMatch.Size = New System.Drawing.Size(951, 44)
    Me.grpSelectMatch.TabIndex = 46
    Me.grpSelectMatch.TabStop = False
    Me.grpSelectMatch.Text = "Select Match"
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.label77, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.cboMatch, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.cboCompetition, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.label76, 2, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(945, 25)
    Me.TableLayoutPanel3.TabIndex = 6
    '
    'label77
    '
    Me.label77.AutoSize = True
    Me.label77.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label77.Location = New System.Drawing.Point(3, 0)
    Me.label77.Name = "label77"
    Me.label77.Size = New System.Drawing.Size(94, 25)
    Me.label77.TabIndex = 0
    Me.label77.Text = "Competition:"
    Me.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboMatch
    '
    Me.cboMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cboMatch.FormattingEnabled = True
    Me.cboMatch.Location = New System.Drawing.Point(575, 3)
    Me.cboMatch.Name = "cboMatch"
    Me.cboMatch.Size = New System.Drawing.Size(367, 21)
    Me.cboMatch.TabIndex = 5
    '
    'cboCompetition
    '
    Me.cboCompetition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cboCompetition.FormattingEnabled = True
    Me.cboCompetition.Location = New System.Drawing.Point(103, 3)
    Me.cboCompetition.Name = "cboCompetition"
    Me.cboCompetition.Size = New System.Drawing.Size(366, 21)
    Me.cboCompetition.TabIndex = 1
    '
    'label76
    '
    Me.label76.AutoSize = True
    Me.label76.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label76.Location = New System.Drawing.Point(475, 0)
    Me.label76.Name = "label76"
    Me.label76.Size = New System.Drawing.Size(94, 25)
    Me.label76.TabIndex = 4
    Me.label76.Text = "Match:"
    Me.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'DialogMatchSetup
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(981, 508)
    Me.Controls.Add(Me.TableLayoutPanelGlobal)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DialogMatchSetup"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "DialogMatchSetup"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelGlobal.ResumeLayout(False)
    Me.grpSelectMatch.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanelGlobal As TableLayoutPanel
  Private WithEvents grpSelectMatch As GroupBox
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Private WithEvents label77 As Label
  Private WithEvents cboMatch As ComboBox
  Private WithEvents cboCompetition As ComboBox
  Private WithEvents label76 As Label
End Class
