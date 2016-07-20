<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlTactica
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelTot = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridPlayers = New MetroFramework.Controls.MetroGrid()
    Me.ColumnPlayersID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayersNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayersFormationPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerFormationX = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayerFormationY = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroGridTeamAll = New MetroFramework.Controls.MetroGrid()
    Me.ColumnAllID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAllNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAllName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PanelCanvas = New System.Windows.Forms.Panel()
    Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
    Me.ContextMenuStripPlayers = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.LabelSelectedPlayer = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.ButtonRandom = New System.Windows.Forms.Button()
    Me.MetroComboBoxFormation = New MetroFramework.Controls.MetroComboBox()
    Me.ToolTipDrag = New System.Windows.Forms.ToolTip(Me.components)
    Me.TableLayoutPanelTot.SuspendLayout()
    CType(Me.MetroGridPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridTeamAll, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelCanvas.SuspendLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelTot
    '
    Me.TableLayoutPanelTot.ColumnCount = 4
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTot.Controls.Add(Me.MetroGridPlayers, 3, 0)
    Me.TableLayoutPanelTot.Controls.Add(Me.MetroGridTeamAll, 0, 0)
    Me.TableLayoutPanelTot.Controls.Add(Me.PanelCanvas, 1, 0)
    Me.TableLayoutPanelTot.Controls.Add(Me.LabelSelectedPlayer, 1, 2)
    Me.TableLayoutPanelTot.Controls.Add(Me.TableLayoutPanel1, 1, 1)
    Me.TableLayoutPanelTot.Controls.Add(Me.MetroComboBoxFormation, 2, 2)
    Me.TableLayoutPanelTot.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTot.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelTot.Name = "TableLayoutPanelTot"
    Me.TableLayoutPanelTot.RowCount = 3
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
    Me.TableLayoutPanelTot.Size = New System.Drawing.Size(1050, 423)
    Me.TableLayoutPanelTot.TabIndex = 1
    '
    'MetroGridPlayers
    '
    Me.MetroGridPlayers.AllowUserToAddRows = False
    Me.MetroGridPlayers.AllowUserToDeleteRows = False
    Me.MetroGridPlayers.AllowUserToResizeColumns = False
    Me.MetroGridPlayers.AllowUserToResizeRows = False
    Me.MetroGridPlayers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPlayers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPlayersID, Me.ColumnPlayersNumber, Me.ColumnPlayersName, Me.ColumnPlayersFormationPos, Me.ColumnPlayerFormationX, Me.ColumnPlayerFormationY})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridPlayers.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridPlayers.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridPlayers.EnableHeadersVisualStyles = False
    Me.MetroGridPlayers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridPlayers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPlayers.Location = New System.Drawing.Point(768, 3)
    Me.MetroGridPlayers.MultiSelect = False
    Me.MetroGridPlayers.Name = "MetroGridPlayers"
    Me.MetroGridPlayers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPlayers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridPlayers.RowHeadersWidth = 10
    Me.MetroGridPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTot.SetRowSpan(Me.MetroGridPlayers, 2)
    Me.MetroGridPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridPlayers.ShowCellErrors = False
    Me.MetroGridPlayers.ShowCellToolTips = False
    Me.MetroGridPlayers.ShowEditingIcon = False
    Me.MetroGridPlayers.ShowRowErrors = False
    Me.MetroGridPlayers.Size = New System.Drawing.Size(279, 384)
    Me.MetroGridPlayers.TabIndex = 49
    '
    'ColumnPlayersID
    '
    Me.ColumnPlayersID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayersID.HeaderText = "ID"
    Me.ColumnPlayersID.Name = "ColumnPlayersID"
    Me.ColumnPlayersID.ReadOnly = True
    Me.ColumnPlayersID.Width = 47
    '
    'ColumnPlayersNumber
    '
    Me.ColumnPlayersNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayersNumber.HeaderText = "#"
    Me.ColumnPlayersNumber.Name = "ColumnPlayersNumber"
    Me.ColumnPlayersNumber.Width = 41
    '
    'ColumnPlayersName
    '
    Me.ColumnPlayersName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayersName.HeaderText = "Name"
    Me.ColumnPlayersName.Name = "ColumnPlayersName"
    Me.ColumnPlayersName.ReadOnly = True
    Me.ColumnPlayersName.Width = 72
    '
    'ColumnPlayersFormationPos
    '
    Me.ColumnPlayersFormationPos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayersFormationPos.HeaderText = "Pos"
    Me.ColumnPlayersFormationPos.Name = "ColumnPlayersFormationPos"
    Me.ColumnPlayersFormationPos.ReadOnly = True
    Me.ColumnPlayersFormationPos.Width = 55
    '
    'ColumnPlayerFormationX
    '
    Me.ColumnPlayerFormationX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPlayerFormationX.HeaderText = "X"
    Me.ColumnPlayerFormationX.Name = "ColumnPlayerFormationX"
    Me.ColumnPlayerFormationX.ReadOnly = True
    Me.ColumnPlayerFormationX.Width = 41
    '
    'ColumnPlayerFormationY
    '
    Me.ColumnPlayerFormationY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnPlayerFormationY.HeaderText = "Y"
    Me.ColumnPlayerFormationY.Name = "ColumnPlayerFormationY"
    Me.ColumnPlayerFormationY.ReadOnly = True
    '
    'MetroGridTeamAll
    '
    Me.MetroGridTeamAll.AllowUserToAddRows = False
    Me.MetroGridTeamAll.AllowUserToDeleteRows = False
    Me.MetroGridTeamAll.AllowUserToResizeColumns = False
    Me.MetroGridTeamAll.AllowUserToResizeRows = False
    Me.MetroGridTeamAll.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamAll.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridTeamAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridTeamAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamAll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridTeamAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridTeamAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnAllID, Me.ColumnAllNumber, Me.ColumnAllName})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridTeamAll.DefaultCellStyle = DataGridViewCellStyle5
    Me.MetroGridTeamAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridTeamAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridTeamAll.EnableHeadersVisualStyles = False
    Me.MetroGridTeamAll.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridTeamAll.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridTeamAll.Location = New System.Drawing.Point(3, 3)
    Me.MetroGridTeamAll.MultiSelect = False
    Me.MetroGridTeamAll.Name = "MetroGridTeamAll"
    Me.MetroGridTeamAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridTeamAll.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridTeamAll.RowHeadersWidth = 10
    Me.MetroGridTeamAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.TableLayoutPanelTot.SetRowSpan(Me.MetroGridTeamAll, 2)
    Me.MetroGridTeamAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridTeamAll.ShowCellErrors = False
    Me.MetroGridTeamAll.ShowCellToolTips = False
    Me.MetroGridTeamAll.ShowEditingIcon = False
    Me.MetroGridTeamAll.ShowRowErrors = False
    Me.MetroGridTeamAll.Size = New System.Drawing.Size(279, 384)
    Me.MetroGridTeamAll.TabIndex = 48
    '
    'ColumnAllID
    '
    Me.ColumnAllID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnAllID.HeaderText = "ID"
    Me.ColumnAllID.Name = "ColumnAllID"
    Me.ColumnAllID.ReadOnly = True
    Me.ColumnAllID.Width = 47
    '
    'ColumnAllNumber
    '
    Me.ColumnAllNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnAllNumber.HeaderText = "#"
    Me.ColumnAllNumber.Name = "ColumnAllNumber"
    Me.ColumnAllNumber.Width = 41
    '
    'ColumnAllName
    '
    Me.ColumnAllName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnAllName.HeaderText = "Name"
    Me.ColumnAllName.Name = "ColumnAllName"
    Me.ColumnAllName.ReadOnly = True
    '
    'PanelCanvas
    '
    Me.TableLayoutPanelTot.SetColumnSpan(Me.PanelCanvas, 2)
    Me.PanelCanvas.Controls.Add(Me.PictureBoxCanvas)
    Me.PanelCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelCanvas.Location = New System.Drawing.Point(288, 3)
    Me.PanelCanvas.Name = "PanelCanvas"
    Me.PanelCanvas.Size = New System.Drawing.Size(474, 334)
    Me.PanelCanvas.TabIndex = 1
    '
    'PictureBoxCanvas
    '
    Me.PictureBoxCanvas.ContextMenuStrip = Me.ContextMenuStripPlayers
    Me.PictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxCanvas.Location = New System.Drawing.Point(0, 0)
    Me.PictureBoxCanvas.Name = "PictureBoxCanvas"
    Me.PictureBoxCanvas.Size = New System.Drawing.Size(474, 334)
    Me.PictureBoxCanvas.TabIndex = 1
    Me.PictureBoxCanvas.TabStop = False
    Me.ToolTipDrag.SetToolTip(Me.PictureBoxCanvas, "feels like it should")
    '
    'ContextMenuStripPlayers
    '
    Me.ContextMenuStripPlayers.Name = "ContextMenuStripPlayers"
    Me.ContextMenuStripPlayers.Size = New System.Drawing.Size(61, 4)
    '
    'LabelSelectedPlayer
    '
    Me.LabelSelectedPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSelectedPlayer.Location = New System.Drawing.Point(288, 390)
    Me.LabelSelectedPlayer.Name = "LabelSelectedPlayer"
    Me.LabelSelectedPlayer.Size = New System.Drawing.Size(234, 33)
    Me.LabelSelectedPlayer.TabIndex = 2
    Me.LabelSelectedPlayer.Text = "Selected player..."
    Me.LabelSelectedPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 9
    Me.TableLayoutPanelTot.SetColumnSpan(Me.TableLayoutPanel1, 2)
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label5, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label6, 6, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label7, 7, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.ButtonRandom, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(288, 343)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 44)
    Me.TableLayoutPanel1.TabIndex = 27
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(65, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 44)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = " "
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(115, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 44)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = " "
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(165, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(44, 44)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = " "
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(215, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(44, 44)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = " "
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(265, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(44, 44)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = " "
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(315, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(44, 44)
    Me.Label6.TabIndex = 12
    Me.Label6.Text = " "
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(365, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(44, 44)
    Me.Label7.TabIndex = 13
    Me.Label7.Text = " "
    '
    'ButtonRandom
    '
    Me.ButtonRandom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonRandom.Location = New System.Drawing.Point(3, 3)
    Me.ButtonRandom.Name = "ButtonRandom"
    Me.ButtonRandom.Size = New System.Drawing.Size(56, 38)
    Me.ButtonRandom.TabIndex = 14
    Me.ButtonRandom.Text = "Random"
    Me.ButtonRandom.UseVisualStyleBackColor = True
    '
    'MetroComboBoxFormation
    '
    Me.MetroComboBoxFormation.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroComboBoxFormation.FormattingEnabled = True
    Me.MetroComboBoxFormation.ItemHeight = 23
    Me.MetroComboBoxFormation.Location = New System.Drawing.Point(528, 393)
    Me.MetroComboBoxFormation.Name = "MetroComboBoxFormation"
    Me.MetroComboBoxFormation.Size = New System.Drawing.Size(234, 29)
    Me.MetroComboBoxFormation.TabIndex = 50
    Me.MetroComboBoxFormation.FlatStyle = FlatStyle.Flat
    '
    'UserControlTactica
    '
    Me.AllowDrop = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelTot)
    Me.Name = "UserControlTactica"
    Me.Size = New System.Drawing.Size(1050, 423)
    Me.TableLayoutPanelTot.ResumeLayout(False)
    CType(Me.MetroGridPlayers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridTeamAll, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelCanvas.ResumeLayout(False)
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanelTot As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents PanelCanvas As System.Windows.Forms.Panel
  Friend WithEvents PictureBoxCanvas As System.Windows.Forms.PictureBox
  Friend WithEvents LabelSelectedPlayer As System.Windows.Forms.Label
  Friend WithEvents ContextMenuStripPlayers As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents ToolTipDrag As System.Windows.Forms.ToolTip
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroGridTeamAll As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnAllID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAllNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAllName As DataGridViewTextBoxColumn
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents MetroGridPlayers As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnPlayersID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayersNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayersName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayersFormationPos As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerFormationX As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayerFormationY As DataGridViewTextBoxColumn
  Friend WithEvents ButtonRandom As Button
  Friend WithEvents MetroComboBoxFormation As MetroFramework.Controls.MetroComboBox
End Class
