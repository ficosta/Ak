<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubstitution
  Inherits MetroFramework.Forms.MetroForm

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelAdvanced = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridField = New MetroFramework.Controls.MetroGrid()
    Me.MetroGridBench = New MetroFramework.Controls.MetroGrid()
    Me.TableLayoutPanelAdvancedControls = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonAdvancedOK = New Button()
    Me.ButtonAdvancedCancel = New Button()
    Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
    Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelINPlayer = New MetroFramework.Controls.MetroLabel()
    Me.MetroLabelInfo = New MetroFramework.Controls.MetroLabel()
    Me.MetroTextBoxPlayers = New MetroFramework.Controls.MetroTextBox()
    Me.MetroLabelOUTPlayer = New MetroFramework.Controls.MetroLabel()
    Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanelAdvanced.SuspendLayout()
    CType(Me.MetroGridField, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridBench, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanelAdvancedControls.SuspendLayout()
    Me.MetroTabControl1.SuspendLayout()
    Me.MetroTabPage1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.MetroTabPage2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelAdvanced
    '
    Me.TableLayoutPanelAdvanced.ColumnCount = 2
    Me.TableLayoutPanelAdvanced.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvanced.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvanced.Controls.Add(Me.MetroGridField, 0, 0)
    Me.TableLayoutPanelAdvanced.Controls.Add(Me.MetroGridBench, 1, 0)
    Me.TableLayoutPanelAdvanced.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanelAdvanced.Name = "TableLayoutPanelAdvanced"
    Me.TableLayoutPanelAdvanced.RowCount = 1
    Me.TableLayoutPanelAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAdvanced.Size = New System.Drawing.Size(685, 316)
    Me.TableLayoutPanelAdvanced.TabIndex = 0
    '
    'MetroGridField
    '
    Me.MetroGridField.AllowUserToAddRows = False
    Me.MetroGridField.AllowUserToDeleteRows = False
    Me.MetroGridField.AllowUserToResizeColumns = False
    Me.MetroGridField.AllowUserToResizeRows = False
    Me.MetroGridField.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridField.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridField.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridField.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridField.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNumber, Me.ColumnName, Me.ColumnPosition})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridField.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridField.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridField.EnableHeadersVisualStyles = False
    Me.MetroGridField.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridField.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridField.Location = New System.Drawing.Point(3, 3)
    Me.MetroGridField.Name = "MetroGridField"
    Me.MetroGridField.ReadOnly = True
    Me.MetroGridField.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridField.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridField.RowHeadersVisible = False
    Me.MetroGridField.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridField.Size = New System.Drawing.Size(336, 310)
    Me.MetroGridField.TabIndex = 0
    '
    'MetroGridBench
    '
    Me.MetroGridBench.AllowUserToAddRows = False
    Me.MetroGridBench.AllowUserToDeleteRows = False
    Me.MetroGridBench.AllowUserToResizeColumns = False
    Me.MetroGridBench.AllowUserToResizeRows = False
    Me.MetroGridBench.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MetroGridBench.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridBench.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridBench.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridBench.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridBench.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridBench.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridBench.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridBench.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridBench.EnableHeadersVisualStyles = False
    Me.MetroGridBench.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridBench.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridBench.Location = New System.Drawing.Point(345, 3)
    Me.MetroGridBench.Name = "MetroGridBench"
    Me.MetroGridBench.ReadOnly = True
    Me.MetroGridBench.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridBench.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridBench.RowHeadersVisible = False
    Me.MetroGridBench.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridBench.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridBench.Size = New System.Drawing.Size(337, 310)
    Me.MetroGridBench.TabIndex = 1
    '
    'TableLayoutPanelAdvancedControls
    '
    Me.TableLayoutPanelAdvancedControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanelAdvancedControls.ColumnCount = 2
    Me.TableLayoutPanelAdvancedControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.Controls.Add(Me.ButtonAdvancedOK, 0, 0)
    Me.TableLayoutPanelAdvancedControls.Controls.Add(Me.ButtonAdvancedCancel, 1, 0)
    Me.TableLayoutPanelAdvancedControls.Location = New System.Drawing.Point(569, 429)
    Me.TableLayoutPanelAdvancedControls.Name = "TableLayoutPanelAdvancedControls"
    Me.TableLayoutPanelAdvancedControls.RowCount = 1
    Me.TableLayoutPanelAdvancedControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.Size = New System.Drawing.Size(146, 24)
    Me.TableLayoutPanelAdvancedControls.TabIndex = 1
    '
    'ButtonAdvancedOK
    '
    Me.ButtonAdvancedOK.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.ButtonAdvancedOK.Location = New System.Drawing.Point(3, 3)
    Me.ButtonAdvancedOK.Name = "ButtonAdvancedOK"
    Me.ButtonAdvancedOK.Size = New System.Drawing.Size(67, 18)
    Me.ButtonAdvancedOK.TabIndex = 0
    Me.ButtonAdvancedOK.Text = "OK"
    Me.ButtonAdvancedOK.FlatStyle = FlatStyle.Flat
    '
    'ButtonAdvancedCancel
    '
    Me.ButtonAdvancedCancel.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.ButtonAdvancedCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.ButtonAdvancedCancel.Location = New System.Drawing.Point(76, 3)
    Me.ButtonAdvancedCancel.Name = "ButtonAdvancedCancel"
    Me.ButtonAdvancedCancel.Size = New System.Drawing.Size(67, 18)
    Me.ButtonAdvancedCancel.TabIndex = 1
    Me.ButtonAdvancedCancel.Text = "Cancel"
    Me.ButtonAdvancedCancel.FlatStyle = FlatStyle.Flat
    '
    'MetroTabControl1
    '
    Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
    Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
    Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
    Me.MetroTabControl1.Name = "MetroTabControl1"
    Me.MetroTabControl1.SelectedIndex = 1
    Me.MetroTabControl1.Size = New System.Drawing.Size(699, 364)
    Me.MetroTabControl1.TabIndex = 1
    '
    'MetroTabPage1
    '
    Me.MetroTabPage1.Controls.Add(Me.TableLayoutPanel1)
    Me.MetroTabPage1.HorizontalScrollbarBarColor = True
    Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
    Me.MetroTabPage1.HorizontalScrollbarSize = 10
    Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
    Me.MetroTabPage1.Name = "MetroTabPage1"
    Me.MetroTabPage1.Size = New System.Drawing.Size(691, 322)
    Me.MetroTabPage1.TabIndex = 0
    Me.MetroTabPage1.Text = "Simple interface"
    Me.MetroTabPage1.VerticalScrollbarBarColor = True
    Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
    Me.MetroTabPage1.VerticalScrollbarSize = 10
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.MetroLabelINPlayer, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroLabelInfo, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroTextBoxPlayers, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroLabelOUTPlayer, 0, 2)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(685, 92)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'MetroLabelINPlayer
    '
    Me.MetroLabelINPlayer.AutoSize = True
    Me.MetroLabelINPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelINPlayer.Location = New System.Drawing.Point(345, 60)
    Me.MetroLabelINPlayer.Name = "MetroLabelINPlayer"
    Me.MetroLabelINPlayer.Size = New System.Drawing.Size(337, 32)
    Me.MetroLabelINPlayer.TabIndex = 5
    Me.MetroLabelINPlayer.Text = "IN Player"
    '
    'MetroLabelInfo
    '
    Me.MetroLabelInfo.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLabelInfo, 2)
    Me.MetroLabelInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelInfo.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelInfo.Name = "MetroLabelInfo"
    Me.MetroLabelInfo.Size = New System.Drawing.Size(679, 30)
    Me.MetroLabelInfo.TabIndex = 2
    Me.MetroLabelInfo.Text = "Enter player numbers separated by a space"
    Me.MetroLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroTextBoxPlayers
    '
    Me.TableLayoutPanel1.SetColumnSpan(Me.MetroTextBoxPlayers, 2)
    '
    '
    '
    Me.MetroTextBoxPlayers.CustomButton.Image = Nothing
    Me.MetroTextBoxPlayers.CustomButton.Location = New System.Drawing.Point(657, 2)
    Me.MetroTextBoxPlayers.CustomButton.Name = ""
    Me.MetroTextBoxPlayers.CustomButton.Size = New System.Drawing.Size(19, 19)
    Me.MetroTextBoxPlayers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.MetroTextBoxPlayers.CustomButton.TabIndex = 1
    Me.MetroTextBoxPlayers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.MetroTextBoxPlayers.CustomButton.FlatStyle = FlatStyle.Flat
    Me.MetroTextBoxPlayers.CustomButton.Visible = False
    Me.MetroTextBoxPlayers.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTextBoxPlayers.Lines = New String(-1) {}
    Me.MetroTextBoxPlayers.Location = New System.Drawing.Point(3, 33)
    Me.MetroTextBoxPlayers.MaxLength = 32767
    Me.MetroTextBoxPlayers.Name = "MetroTextBoxPlayers"
    Me.MetroTextBoxPlayers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.MetroTextBoxPlayers.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.MetroTextBoxPlayers.SelectedText = ""
    Me.MetroTextBoxPlayers.SelectionLength = 0
    Me.MetroTextBoxPlayers.SelectionStart = 0
    Me.MetroTextBoxPlayers.Size = New System.Drawing.Size(679, 24)
    Me.MetroTextBoxPlayers.TabIndex = 3
    Me.MetroTextBoxPlayers.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.MetroTextBoxPlayers.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'MetroLabelOUTPlayer
    '
    Me.MetroLabelOUTPlayer.AutoSize = True
    Me.MetroLabelOUTPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelOUTPlayer.Location = New System.Drawing.Point(3, 60)
    Me.MetroLabelOUTPlayer.Name = "MetroLabelOUTPlayer"
    Me.MetroLabelOUTPlayer.Size = New System.Drawing.Size(336, 32)
    Me.MetroLabelOUTPlayer.TabIndex = 4
    Me.MetroLabelOUTPlayer.Text = "OUT Player"
    '
    'MetroTabPage2
    '
    Me.MetroTabPage2.Controls.Add(Me.TableLayoutPanelAdvanced)
    Me.MetroTabPage2.HorizontalScrollbarBarColor = True
    Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
    Me.MetroTabPage2.HorizontalScrollbarSize = 10
    Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
    Me.MetroTabPage2.Name = "MetroTabPage2"
    Me.MetroTabPage2.Size = New System.Drawing.Size(691, 322)
    Me.MetroTabPage2.TabIndex = 1
    Me.MetroTabPage2.Text = "Advanced interface"
    Me.MetroTabPage2.VerticalScrollbarBarColor = True
    Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
    Me.MetroTabPage2.VerticalScrollbarSize = 10
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Visible = False
    '
    'ColumnNumber
    '
    Me.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnNumber.HeaderText = "#"
    Me.ColumnNumber.Name = "ColumnNumber"
    Me.ColumnNumber.ReadOnly = True
    Me.ColumnNumber.Width = 37
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnName.HeaderText = "Name"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    '
    'ColumnPosition
    '
    Me.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPosition.HeaderText = "Pos"
    Me.ColumnPosition.Name = "ColumnPosition"
    Me.ColumnPosition.ReadOnly = True
    Me.ColumnPosition.Visible = False
    Me.ColumnPosition.Width = 48
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.HeaderText = "#"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Width = 37
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.HeaderText = "Pos"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Visible = False
    Me.DataGridViewTextBoxColumn4.Width = 48
    '
    'FormSubstitution
    '
    Me.AcceptButton = Me.ButtonAdvancedOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.ButtonAdvancedCancel
    Me.ClientSize = New System.Drawing.Size(745, 464)
    Me.Controls.Add(Me.TableLayoutPanelAdvancedControls)
    Me.Controls.Add(Me.MetroTabControl1)
    Me.Name = "FormSubstitution"
    Me.Text = "Substitution"
    Me.TableLayoutPanelAdvanced.ResumeLayout(False)
    CType(Me.MetroGridField, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridBench, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanelAdvancedControls.ResumeLayout(False)
    Me.MetroTabControl1.ResumeLayout(False)
    Me.MetroTabPage1.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.MetroTabPage2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelAdvanced As TableLayoutPanel
  Friend WithEvents MetroGridField As MetroFramework.Controls.MetroGrid
  Friend WithEvents MetroGridBench As MetroFramework.Controls.MetroGrid
  Friend WithEvents TableLayoutPanelAdvancedControls As TableLayoutPanel
  Friend WithEvents ButtonAdvancedOK As Button
  Friend WithEvents ButtonAdvancedCancel As Button
  Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
  Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroLabelINPlayer As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroLabelInfo As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroTextBoxPlayers As MetroFramework.Controls.MetroTextBox
  Friend WithEvents MetroLabelOUTPlayer As MetroFramework.Controls.MetroLabel
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPosition As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
