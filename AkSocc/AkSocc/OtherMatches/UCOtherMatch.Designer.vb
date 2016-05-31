<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOtherMatch
  Inherits MetroFramework.Controls.MetroUserControl

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
    Me.TableLayoutPanelMatch = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTextBoxScoreAway = New MetroFramework.Controls.MetroTextBox()
    Me.MetroTileMatch = New MetroFramework.Controls.MetroTile()
    Me.MetroTileScore = New MetroFramework.Controls.MetroTile()
    Me.MetroTileLogo = New MetroFramework.Controls.MetroTile()
    Me.MetroTileMatchStatus = New MetroFramework.Controls.MetroTile()
    Me.MetroComboBoxChannelLogo = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxMatchStatus = New MetroFramework.Controls.MetroComboBox()
    Me.MetroComboBoxMatch = New MetroFramework.Controls.MetroComboBox()
    Me.MetroTextBoxScoreHome = New MetroFramework.Controls.MetroTextBox()
    Me.TableLayoutPanelArrows = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonUP = New System.Windows.Forms.Button()
    Me.ButtonDOWN = New System.Windows.Forms.Button()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.TabPageBlank = New System.Windows.Forms.TabPage()
    Me.TabPageMatch = New System.Windows.Forms.TabPage()
    Me.TabPageTitle = New System.Windows.Forms.TabPage()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PanelSection = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroCheckBoxAddToTable = New MetroFramework.Controls.MetroCheckBox()
    Me.MetroCheckBoxAddToCrawl = New MetroFramework.Controls.MetroCheckBox()
    Me.MetroButtonDelete = New MetroFramework.Controls.MetroButton()
    Me.TableLayoutPanelMatch.SuspendLayout()
    Me.TableLayoutPanelArrows.SuspendLayout()
    Me.MetroTabControl1.SuspendLayout()
    Me.TabPageMatch.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.PanelSection.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelMatch
    '
    Me.TableLayoutPanelMatch.ColumnCount = 5
    Me.TableLayoutPanelMatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelMatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanelMatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelMatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTextBoxScoreAway, 2, 1)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTileMatch, 0, 0)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTileScore, 1, 0)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTileLogo, 3, 0)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTileMatchStatus, 3, 1)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroComboBoxChannelLogo, 4, 0)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroComboBoxMatchStatus, 4, 1)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroComboBoxMatch, 0, 1)
    Me.TableLayoutPanelMatch.Controls.Add(Me.MetroTextBoxScoreHome, 1, 1)
    Me.TableLayoutPanelMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelMatch.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelMatch.Name = "TableLayoutPanelMatch"
    Me.TableLayoutPanelMatch.RowCount = 2
    Me.TableLayoutPanelMatch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelMatch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelMatch.Size = New System.Drawing.Size(705, 69)
    Me.TableLayoutPanelMatch.TabIndex = 0
    '
    'MetroTextBoxScoreAway
    '
    '
    '
    '
    Me.MetroTextBoxScoreAway.CustomButton.Image = Nothing
    Me.MetroTextBoxScoreAway.CustomButton.Location = New System.Drawing.Point(26, 1)
    Me.MetroTextBoxScoreAway.CustomButton.Name = ""
    Me.MetroTextBoxScoreAway.CustomButton.Size = New System.Drawing.Size(27, 27)
    Me.MetroTextBoxScoreAway.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxScoreAway.CustomButton.TabIndex = 1
    Me.MetroTextBoxScoreAway.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxScoreAway.CustomButton.UseSelectable = True
    Me.MetroTextBoxScoreAway.CustomButton.Visible = False
    Me.MetroTextBoxScoreAway.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxScoreAway.FontSize = MetroFramework.MetroTextBoxSize.Tall
    Me.MetroTextBoxScoreAway.Lines = New String() {"0"}
    Me.MetroTextBoxScoreAway.Location = New System.Drawing.Point(448, 37)
    Me.MetroTextBoxScoreAway.MaxLength = 32767
    Me.MetroTextBoxScoreAway.Name = "MetroTextBoxScoreAway"
    Me.MetroTextBoxScoreAway.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxScoreAway.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxScoreAway.SelectedText = ""
    Me.MetroTextBoxScoreAway.SelectionLength = 0
    Me.MetroTextBoxScoreAway.SelectionStart = 0
    Me.MetroTextBoxScoreAway.Size = New System.Drawing.Size(54, 29)
    Me.MetroTextBoxScoreAway.TabIndex = 8
    Me.MetroTextBoxScoreAway.Text = "0"
    Me.MetroTextBoxScoreAway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.MetroTextBoxScoreAway.UseSelectable = True
    Me.MetroTextBoxScoreAway.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxScoreAway.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroTileMatch
    '
    Me.MetroTileMatch.ActiveControl = Nothing
    Me.MetroTileMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileMatch.Location = New System.Drawing.Point(3, 3)
    Me.MetroTileMatch.Name = "MetroTileMatch"
    Me.MetroTileMatch.Size = New System.Drawing.Size(379, 28)
    Me.MetroTileMatch.TabIndex = 0
    Me.MetroTileMatch.Text = "Match"
    Me.MetroTileMatch.UseSelectable = True
    '
    'MetroTileScore
    '
    Me.MetroTileScore.ActiveControl = Nothing
    Me.TableLayoutPanelMatch.SetColumnSpan(Me.MetroTileScore, 2)
    Me.MetroTileScore.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileScore.Location = New System.Drawing.Point(388, 3)
    Me.MetroTileScore.Name = "MetroTileScore"
    Me.MetroTileScore.Size = New System.Drawing.Size(114, 28)
    Me.MetroTileScore.TabIndex = 1
    Me.MetroTileScore.Text = "Score"
    Me.MetroTileScore.UseSelectable = True
    '
    'MetroTileLogo
    '
    Me.MetroTileLogo.ActiveControl = Nothing
    Me.MetroTileLogo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileLogo.Location = New System.Drawing.Point(508, 3)
    Me.MetroTileLogo.Name = "MetroTileLogo"
    Me.MetroTileLogo.Size = New System.Drawing.Size(94, 28)
    Me.MetroTileLogo.TabIndex = 2
    Me.MetroTileLogo.Text = "Channel logo"
    Me.MetroTileLogo.UseSelectable = True
    '
    'MetroTileMatchStatus
    '
    Me.MetroTileMatchStatus.ActiveControl = Nothing
    Me.MetroTileMatchStatus.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileMatchStatus.Location = New System.Drawing.Point(508, 37)
    Me.MetroTileMatchStatus.Name = "MetroTileMatchStatus"
    Me.MetroTileMatchStatus.Size = New System.Drawing.Size(94, 29)
    Me.MetroTileMatchStatus.TabIndex = 3
    Me.MetroTileMatchStatus.Text = "Match status"
    Me.MetroTileMatchStatus.UseSelectable = True
    '
    'MetroComboBoxChannelLogo
    '
    Me.MetroComboBoxChannelLogo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxChannelLogo.FormattingEnabled = True
    Me.MetroComboBoxChannelLogo.ItemHeight = 23
    Me.MetroComboBoxChannelLogo.Location = New System.Drawing.Point(608, 3)
    Me.MetroComboBoxChannelLogo.Name = "MetroComboBoxChannelLogo"
    Me.MetroComboBoxChannelLogo.Size = New System.Drawing.Size(94, 29)
    Me.MetroComboBoxChannelLogo.TabIndex = 4
    Me.MetroComboBoxChannelLogo.UseSelectable = True
    '
    'MetroComboBoxMatchStatus
    '
    Me.MetroComboBoxMatchStatus.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxMatchStatus.FormattingEnabled = True
    Me.MetroComboBoxMatchStatus.ItemHeight = 23
    Me.MetroComboBoxMatchStatus.Location = New System.Drawing.Point(608, 37)
    Me.MetroComboBoxMatchStatus.Name = "MetroComboBoxMatchStatus"
    Me.MetroComboBoxMatchStatus.Size = New System.Drawing.Size(94, 29)
    Me.MetroComboBoxMatchStatus.TabIndex = 5
    Me.MetroComboBoxMatchStatus.UseSelectable = True
    '
    'MetroComboBoxMatch
    '
    Me.MetroComboBoxMatch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxMatch.FormattingEnabled = True
    Me.MetroComboBoxMatch.ItemHeight = 23
    Me.MetroComboBoxMatch.Location = New System.Drawing.Point(3, 37)
    Me.MetroComboBoxMatch.Name = "MetroComboBoxMatch"
    Me.MetroComboBoxMatch.Size = New System.Drawing.Size(379, 29)
    Me.MetroComboBoxMatch.TabIndex = 6
    Me.MetroComboBoxMatch.UseSelectable = True
    '
    'MetroTextBoxScoreHome
    '
    '
    '
    '
    Me.MetroTextBoxScoreHome.CustomButton.Image = Nothing
    Me.MetroTextBoxScoreHome.CustomButton.Location = New System.Drawing.Point(26, 1)
    Me.MetroTextBoxScoreHome.CustomButton.Name = ""
    Me.MetroTextBoxScoreHome.CustomButton.Size = New System.Drawing.Size(27, 27)
    Me.MetroTextBoxScoreHome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxScoreHome.CustomButton.TabIndex = 1
    Me.MetroTextBoxScoreHome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxScoreHome.CustomButton.UseSelectable = True
    Me.MetroTextBoxScoreHome.CustomButton.Visible = False
    Me.MetroTextBoxScoreHome.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxScoreHome.FontSize = MetroFramework.MetroTextBoxSize.Tall
    Me.MetroTextBoxScoreHome.Lines = New String() {"0"}
    Me.MetroTextBoxScoreHome.Location = New System.Drawing.Point(388, 37)
    Me.MetroTextBoxScoreHome.MaxLength = 32767
    Me.MetroTextBoxScoreHome.Name = "MetroTextBoxScoreHome"
    Me.MetroTextBoxScoreHome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxScoreHome.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxScoreHome.SelectedText = ""
    Me.MetroTextBoxScoreHome.SelectionLength = 0
    Me.MetroTextBoxScoreHome.SelectionStart = 0
    Me.MetroTextBoxScoreHome.Size = New System.Drawing.Size(54, 29)
    Me.MetroTextBoxScoreHome.TabIndex = 7
    Me.MetroTextBoxScoreHome.Text = "0"
    Me.MetroTextBoxScoreHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.MetroTextBoxScoreHome.UseSelectable = True
    Me.MetroTextBoxScoreHome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxScoreHome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'TableLayoutPanelArrows
    '
    Me.TableLayoutPanelArrows.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanelArrows.ColumnCount = 1
    Me.TableLayoutPanelArrows.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelArrows.Controls.Add(Me.ButtonUP, 0, 1)
    Me.TableLayoutPanelArrows.Controls.Add(Me.ButtonDOWN, 0, 2)
    Me.TableLayoutPanelArrows.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelArrows.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanelArrows.Name = "TableLayoutPanelArrows"
    Me.TableLayoutPanelArrows.RowCount = 3
    Me.TableLayoutPanelArrows.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelArrows.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelArrows.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelArrows.Size = New System.Drawing.Size(44, 117)
    Me.TableLayoutPanelArrows.TabIndex = 0
    '
    'ButtonUP
    '
    Me.ButtonUP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonUP.Location = New System.Drawing.Point(3, 38)
    Me.ButtonUP.Name = "ButtonUP"
    Me.ButtonUP.Size = New System.Drawing.Size(38, 35)
    Me.ButtonUP.TabIndex = 0
    Me.ButtonUP.Text = "UP"
    Me.ButtonUP.UseVisualStyleBackColor = True
    '
    'ButtonDOWN
    '
    Me.ButtonDOWN.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonDOWN.Location = New System.Drawing.Point(3, 79)
    Me.ButtonDOWN.Name = "ButtonDOWN"
    Me.ButtonDOWN.Size = New System.Drawing.Size(38, 35)
    Me.ButtonDOWN.TabIndex = 1
    Me.ButtonDOWN.Text = "DOWN"
    Me.ButtonDOWN.UseVisualStyleBackColor = True
    '
    'MetroTabControl1
    '
    Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MetroTabControl1.Controls.Add(Me.TabPageBlank)
    Me.MetroTabControl1.Controls.Add(Me.TabPageMatch)
    Me.MetroTabControl1.Controls.Add(Me.TabPageTitle)
    Me.MetroTabControl1.Location = New System.Drawing.Point(3, 3)
    Me.MetroTabControl1.Name = "MetroTabControl1"
    Me.MetroTabControl1.SelectedIndex = 1
    Me.MetroTabControl1.Size = New System.Drawing.Size(713, 111)
    Me.MetroTabControl1.TabIndex = 1
    Me.MetroTabControl1.UseSelectable = True
    '
    'TabPageBlank
    '
    Me.TabPageBlank.Location = New System.Drawing.Point(4, 38)
    Me.TabPageBlank.Name = "TabPageBlank"
    Me.TabPageBlank.Size = New System.Drawing.Size(705, 69)
    Me.TabPageBlank.TabIndex = 0
    Me.TabPageBlank.Text = "Blank"
    '
    'TabPageMatch
    '
    Me.TabPageMatch.Controls.Add(Me.TableLayoutPanelMatch)
    Me.TabPageMatch.Location = New System.Drawing.Point(4, 38)
    Me.TabPageMatch.Name = "TabPageMatch"
    Me.TabPageMatch.Size = New System.Drawing.Size(705, 69)
    Me.TabPageMatch.TabIndex = 1
    Me.TabPageMatch.Text = "Match"
    '
    'TabPageTitle
    '
    Me.TabPageTitle.Location = New System.Drawing.Point(4, 38)
    Me.TabPageTitle.Name = "TabPageTitle"
    Me.TabPageTitle.Size = New System.Drawing.Size(705, 69)
    Me.TabPageTitle.TabIndex = 2
    Me.TabPageTitle.Text = "Title"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelArrows, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PanelSection, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(775, 123)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'PanelSection
    '
    Me.PanelSection.BackColor = System.Drawing.Color.White
    Me.PanelSection.Controls.Add(Me.TableLayoutPanel2)
    Me.PanelSection.Controls.Add(Me.MetroTabControl1)
    Me.PanelSection.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelSection.Location = New System.Drawing.Point(53, 3)
    Me.PanelSection.Name = "PanelSection"
    Me.PanelSection.Size = New System.Drawing.Size(719, 117)
    Me.PanelSection.TabIndex = 2
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel2.ColumnCount = 3
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroCheckBoxAddToTable, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroCheckBoxAddToCrawl, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroButtonDelete, 2, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(410, 5)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(301, 30)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'MetroCheckBoxAddToTable
    '
    Me.MetroCheckBoxAddToTable.AutoSize = True
    Me.MetroCheckBoxAddToTable.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxAddToTable.Location = New System.Drawing.Point(103, 3)
    Me.MetroCheckBoxAddToTable.Name = "MetroCheckBoxAddToTable"
    Me.MetroCheckBoxAddToTable.Size = New System.Drawing.Size(94, 24)
    Me.MetroCheckBoxAddToTable.TabIndex = 1
    Me.MetroCheckBoxAddToTable.Text = "Add to table"
    Me.MetroCheckBoxAddToTable.UseSelectable = True
    '
    'MetroCheckBoxAddToCrawl
    '
    Me.MetroCheckBoxAddToCrawl.AutoSize = True
    Me.MetroCheckBoxAddToCrawl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroCheckBoxAddToCrawl.Location = New System.Drawing.Point(3, 3)
    Me.MetroCheckBoxAddToCrawl.Name = "MetroCheckBoxAddToCrawl"
    Me.MetroCheckBoxAddToCrawl.Size = New System.Drawing.Size(94, 24)
    Me.MetroCheckBoxAddToCrawl.TabIndex = 0
    Me.MetroCheckBoxAddToCrawl.Text = "Add to crawl"
    Me.MetroCheckBoxAddToCrawl.UseSelectable = True
    '
    'MetroButtonDelete
    '
    Me.MetroButtonDelete.BackColor = System.Drawing.Color.Maroon
    Me.MetroButtonDelete.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonDelete.Location = New System.Drawing.Point(203, 3)
    Me.MetroButtonDelete.Name = "MetroButtonDelete"
    Me.MetroButtonDelete.Size = New System.Drawing.Size(95, 24)
    Me.MetroButtonDelete.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroButtonDelete.TabIndex = 2
    Me.MetroButtonDelete.Text = "Delete"
    Me.MetroButtonDelete.UseSelectable = True
    '
    'UCOtherMatch
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "UCOtherMatch"
    Me.Size = New System.Drawing.Size(775, 123)
    Me.TableLayoutPanelMatch.ResumeLayout(False)
    Me.TableLayoutPanelArrows.ResumeLayout(False)
    Me.MetroTabControl1.ResumeLayout(False)
    Me.TabPageMatch.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.PanelSection.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelMatch As TableLayoutPanel
  Friend WithEvents TableLayoutPanelArrows As TableLayoutPanel
  Friend WithEvents ButtonUP As Button
  Friend WithEvents ButtonDOWN As Button
  Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
  Friend WithEvents TabPageBlank As TabPage
  Friend WithEvents TabPageMatch As TabPage
  Friend WithEvents TabPageTitle As TabPage
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroTileMatch As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroTileScore As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroTileLogo As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroTileMatchStatus As MetroFramework.Controls.MetroTile
  Friend WithEvents MetroComboBoxChannelLogo As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroComboBoxMatchStatus As MetroFramework.Controls.MetroComboBox
  Friend WithEvents MetroComboBoxMatch As MetroFramework.Controls.MetroComboBox
  Friend WithEvents PanelSection As Panel
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents MetroCheckBoxAddToTable As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroCheckBoxAddToCrawl As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroButtonDelete As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroTextBoxScoreAway As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroTextBoxScoreHome As MetroFramework.Controls.MetroTextBox
End Class
