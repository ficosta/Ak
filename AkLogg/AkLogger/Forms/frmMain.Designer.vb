<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.TableLayoutPanelTeams = New System.Windows.Forms.TableLayoutPanel()
    Me.grpControls = New System.Windows.Forms.GroupBox()
    Me.tableLayoutPanelPeriodes = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelPeriodName = New System.Windows.Forms.Label()
    Me.MetroLabelPeriodTime = New System.Windows.Forms.Label()
    Me.rdbExtra2 = New MetroFramework.Controls.MetroRadioButton()
    Me.btnClockReset = New System.Windows.Forms.Button()
    Me.rdbExtra1 = New MetroFramework.Controls.MetroRadioButton()
    Me.btnOverwriteClock = New System.Windows.Forms.Button()
    Me.txtClock = New System.Windows.Forms.Label()
    Me.rdb2ndHalf = New MetroFramework.Controls.MetroRadioButton()
    Me.rdb1stHalf = New MetroFramework.Controls.MetroRadioButton()
    Me.StopClock = New System.Windows.Forms.Button()
    Me.StartClock = New System.Windows.Forms.Button()
    Me.grpPossession = New System.Windows.Forms.GroupBox()
    Me.txtOutOfPlay = New System.Windows.Forms.TextBox()
    Me.lblOutOfPlay = New System.Windows.Forms.Label()
    Me.lblPossessionLast10Away = New System.Windows.Forms.Label()
    Me.lblPossessionLast5Away = New System.Windows.Forms.Label()
    Me.lblPossession2ndAway = New System.Windows.Forms.Label()
    Me.lblPossession1stAway = New System.Windows.Forms.Label()
    Me.lblPossessionAwayAttk = New System.Windows.Forms.Label()
    Me.lblPossessionAwayMidF = New System.Windows.Forms.Label()
    Me.lblPossessionAwayOwnF = New System.Windows.Forms.Label()
    Me.lblPossessionMatchAway = New System.Windows.Forms.Label()
    Me.txtPossessionAwayAttk = New System.Windows.Forms.TextBox()
    Me.txtPossessionAwayMidF = New System.Windows.Forms.TextBox()
    Me.txtPossessionAwayOwnT = New System.Windows.Forms.TextBox()
    Me.lblAwayTeam3 = New System.Windows.Forms.Label()
    Me.lblPossessionLast10Home = New System.Windows.Forms.Label()
    Me.lblPossessionLast5Home = New System.Windows.Forms.Label()
    Me.lblPossession2ndHome = New System.Windows.Forms.Label()
    Me.lblPossession1stHome = New System.Windows.Forms.Label()
    Me.lblPossessionHomeAttk = New System.Windows.Forms.Label()
    Me.lblPossessionHomeMidF = New System.Windows.Forms.Label()
    Me.lblPossessionHomeOwnF = New System.Windows.Forms.Label()
    Me.lblPossessionMatchHome = New System.Windows.Forms.Label()
    Me.txtPossessionHomeAttk = New System.Windows.Forms.TextBox()
    Me.txtPossessionHomeMidF = New System.Windows.Forms.TextBox()
    Me.txtPossessionHomeOwnT = New System.Windows.Forms.TextBox()
    Me.label65 = New System.Windows.Forms.Label()
    Me.label66 = New System.Windows.Forms.Label()
    Me.label64 = New System.Windows.Forms.Label()
    Me.label63 = New System.Windows.Forms.Label()
    Me.label62 = New System.Windows.Forms.Label()
    Me.label61 = New System.Windows.Forms.Label()
    Me.label60 = New System.Windows.Forms.Label()
    Me.label59 = New System.Windows.Forms.Label()
    Me.label58 = New System.Windows.Forms.Label()
    Me.label57 = New System.Windows.Forms.Label()
    Me.lblHomeTeam3 = New System.Windows.Forms.Label()
    Me.lblPossessionAttk = New System.Windows.Forms.Label()
    Me.lblPossessionMidF = New System.Windows.Forms.Label()
    Me.lblPossessionOwnT = New System.Windows.Forms.Label()
    Me.label52 = New System.Windows.Forms.Label()
    Me.groupBox2 = New System.Windows.Forms.GroupBox()
    Me.MetroGridEvents = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnImage = New System.Windows.Forms.DataGridViewImageColumn()
    Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.imglstEvents = New System.Windows.Forms.ImageList(Me.components)
    Me.groupBox1 = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.lblHomeTeam2 = New System.Windows.Forms.Label()
    Me.label91 = New System.Windows.Forms.Label()
    Me.label90 = New System.Windows.Forms.Label()
    Me.label89 = New System.Windows.Forms.Label()
    Me.lblAwayTeam2 = New System.Windows.Forms.Label()
    Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
    Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButtonSettings = New System.Windows.Forms.ToolStripButton()
    Me.TableLayoutPanelBottom = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelAppVersion = New System.Windows.Forms.Label()
    Me.TeamControlHome = New AkLogger.TeamControl()
    Me.TeamControlAway = New AkLogger.TeamControl()
    Me.SingleStatControlHomeCorners = New AkLogger.SingleStatControl()
    Me.SingleStatControlHomeOffsides = New AkLogger.SingleStatControl()
    Me.SingleStatControlHomeWood = New AkLogger.SingleStatControl()
    Me.SingleStatControlAwayCorners = New AkLogger.SingleStatControl()
    Me.SingleStatControlAwayOffsides = New AkLogger.SingleStatControl()
    Me.SingleStatControlAwayWood = New AkLogger.SingleStatControl()
    Me.TableLayoutPanelTeams.SuspendLayout()
    Me.grpControls.SuspendLayout()
    Me.tableLayoutPanelPeriodes.SuspendLayout()
    Me.grpPossession.SuspendLayout()
    Me.groupBox2.SuspendLayout()
    CType(Me.MetroGridEvents, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.groupBox1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.TableLayoutPanelBottom.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelTeams
    '
    Me.TableLayoutPanelTeams.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanelTeams.ColumnCount = 2
    Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanelTeams, 3)
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelTeams.Controls.Add(Me.TeamControlHome, 0, 0)
    Me.TableLayoutPanelTeams.Controls.Add(Me.TeamControlAway, 1, 0)
    Me.TableLayoutPanelTeams.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTeams.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanelTeams.Name = "TableLayoutPanelTeams"
    Me.TableLayoutPanelTeams.RowCount = 1
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 531.0!))
    Me.TableLayoutPanelTeams.Size = New System.Drawing.Size(984, 491)
    Me.TableLayoutPanelTeams.TabIndex = 379
    '
    'grpControls
    '
    Me.grpControls.Controls.Add(Me.tableLayoutPanelPeriodes)
    Me.grpControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpControls.Location = New System.Drawing.Point(993, 3)
    Me.grpControls.Name = "grpControls"
    Me.grpControls.Size = New System.Drawing.Size(160, 491)
    Me.grpControls.TabIndex = 375
    Me.grpControls.TabStop = False
    Me.grpControls.Text = "Controls"
    '
    'tableLayoutPanelPeriodes
    '
    Me.tableLayoutPanelPeriodes.ColumnCount = 2
    Me.tableLayoutPanelPeriodes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tableLayoutPanelPeriodes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.MetroLabelPeriodName, 0, 1)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.MetroLabelPeriodTime, 0, 0)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.rdbExtra2, 1, 7)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.btnClockReset, 0, 9)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.rdbExtra1, 1, 6)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.btnOverwriteClock, 0, 8)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.txtClock, 0, 2)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.rdb2ndHalf, 1, 5)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.rdb1stHalf, 1, 4)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.StopClock, 1, 3)
    Me.tableLayoutPanelPeriodes.Controls.Add(Me.StartClock, 0, 3)
    Me.tableLayoutPanelPeriodes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tableLayoutPanelPeriodes.Location = New System.Drawing.Point(3, 16)
    Me.tableLayoutPanelPeriodes.Name = "tableLayoutPanelPeriodes"
    Me.tableLayoutPanelPeriodes.RowCount = 10
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89199!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.91891!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89125!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04964!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.208037!))
    Me.tableLayoutPanelPeriodes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.tableLayoutPanelPeriodes.Size = New System.Drawing.Size(154, 472)
    Me.tableLayoutPanelPeriodes.TabIndex = 238
    '
    'MetroLabelPeriodName
    '
    Me.MetroLabelPeriodName.AutoSize = True
    Me.MetroLabelPeriodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.tableLayoutPanelPeriodes.SetColumnSpan(Me.MetroLabelPeriodName, 2)
    Me.MetroLabelPeriodName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelPeriodName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabelPeriodName.Location = New System.Drawing.Point(3, 60)
    Me.MetroLabelPeriodName.Name = "MetroLabelPeriodName"
    Me.MetroLabelPeriodName.Size = New System.Drawing.Size(148, 37)
    Me.MetroLabelPeriodName.TabIndex = 241
    Me.MetroLabelPeriodName.Text = "1st half"
    Me.MetroLabelPeriodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'MetroLabelPeriodTime
    '
    Me.MetroLabelPeriodTime.AutoSize = True
    Me.MetroLabelPeriodTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.tableLayoutPanelPeriodes.SetColumnSpan(Me.MetroLabelPeriodTime, 2)
    Me.MetroLabelPeriodTime.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelPeriodTime.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabelPeriodTime.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelPeriodTime.Name = "MetroLabelPeriodTime"
    Me.MetroLabelPeriodTime.Size = New System.Drawing.Size(148, 60)
    Me.MetroLabelPeriodTime.TabIndex = 240
    Me.MetroLabelPeriodTime.Text = "00:00"
    Me.MetroLabelPeriodTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'rdbExtra2
    '
    Me.rdbExtra2.AutoCheck = False
    Me.rdbExtra2.AutoSize = True
    Me.rdbExtra2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rdbExtra2.Location = New System.Drawing.Point(80, 332)
    Me.rdbExtra2.Name = "rdbExtra2"
    Me.rdbExtra2.Size = New System.Drawing.Size(71, 37)
    Me.rdbExtra2.TabIndex = 239
    Me.rdbExtra2.Text = "e2"
    Me.rdbExtra2.UseSelectable = True
    Me.rdbExtra2.UseVisualStyleBackColor = True
    '
    'btnClockReset
    '
    Me.btnClockReset.BackColor = System.Drawing.Color.OrangeRed
    Me.tableLayoutPanelPeriodes.SetColumnSpan(Me.btnClockReset, 2)
    Me.btnClockReset.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnClockReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnClockReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClockReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
    Me.btnClockReset.Location = New System.Drawing.Point(3, 427)
    Me.btnClockReset.Name = "btnClockReset"
    Me.btnClockReset.Size = New System.Drawing.Size(148, 42)
    Me.btnClockReset.TabIndex = 237
    Me.btnClockReset.Text = "DATA RESET"
    Me.btnClockReset.UseVisualStyleBackColor = False
    '
    'rdbExtra1
    '
    Me.rdbExtra1.AutoCheck = False
    Me.rdbExtra1.AutoSize = True
    Me.rdbExtra1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rdbExtra1.Location = New System.Drawing.Point(80, 289)
    Me.rdbExtra1.Name = "rdbExtra1"
    Me.rdbExtra1.Size = New System.Drawing.Size(71, 37)
    Me.rdbExtra1.TabIndex = 236
    Me.rdbExtra1.Text = "e1"
    Me.rdbExtra1.UseSelectable = True
    Me.rdbExtra1.UseVisualStyleBackColor = True
    '
    'btnOverwriteClock
    '
    Me.btnOverwriteClock.BackColor = System.Drawing.Color.LightCoral
    Me.tableLayoutPanelPeriodes.SetColumnSpan(Me.btnOverwriteClock, 2)
    Me.btnOverwriteClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnOverwriteClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnOverwriteClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOverwriteClock.Location = New System.Drawing.Point(3, 375)
    Me.btnOverwriteClock.Name = "btnOverwriteClock"
    Me.btnOverwriteClock.Size = New System.Drawing.Size(148, 46)
    Me.btnOverwriteClock.TabIndex = 4
    Me.btnOverwriteClock.Text = "OVERWRITE CLOCK"
    Me.btnOverwriteClock.UseVisualStyleBackColor = False
    '
    'txtClock
    '
    Me.txtClock.BackColor = System.Drawing.Color.DarkOrange
    Me.txtClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.tableLayoutPanelPeriodes.SetColumnSpan(Me.txtClock, 2)
    Me.txtClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtClock.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtClock.Location = New System.Drawing.Point(3, 97)
    Me.txtClock.Name = "txtClock"
    Me.txtClock.Size = New System.Drawing.Size(148, 60)
    Me.txtClock.TabIndex = 233
    Me.txtClock.Text = "100:00"
    Me.txtClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.txtClock.Visible = False
    '
    'rdb2ndHalf
    '
    Me.rdb2ndHalf.AutoCheck = False
    Me.rdb2ndHalf.AutoSize = True
    Me.rdb2ndHalf.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rdb2ndHalf.Location = New System.Drawing.Point(80, 246)
    Me.rdb2ndHalf.Name = "rdb2ndHalf"
    Me.rdb2ndHalf.Size = New System.Drawing.Size(71, 37)
    Me.rdb2ndHalf.TabIndex = 235
    Me.rdb2ndHalf.Text = "2nd"
    Me.rdb2ndHalf.UseSelectable = True
    Me.rdb2ndHalf.UseVisualStyleBackColor = True
    '
    'rdb1stHalf
    '
    Me.rdb1stHalf.AutoCheck = False
    Me.rdb1stHalf.AutoSize = True
    Me.rdb1stHalf.Checked = True
    Me.rdb1stHalf.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rdb1stHalf.Location = New System.Drawing.Point(80, 203)
    Me.rdb1stHalf.Name = "rdb1stHalf"
    Me.rdb1stHalf.Size = New System.Drawing.Size(71, 37)
    Me.rdb1stHalf.TabIndex = 234
    Me.rdb1stHalf.TabStop = True
    Me.rdb1stHalf.Text = "1st"
    Me.rdb1stHalf.UseSelectable = True
    Me.rdb1stHalf.UseVisualStyleBackColor = True
    '
    'StopClock
    '
    Me.StopClock.BackColor = System.Drawing.Color.OrangeRed
    Me.StopClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.StopClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.StopClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.StopClock.ForeColor = System.Drawing.SystemColors.ControlLightLight
    Me.StopClock.Location = New System.Drawing.Point(80, 160)
    Me.StopClock.Name = "StopClock"
    Me.StopClock.Size = New System.Drawing.Size(71, 37)
    Me.StopClock.TabIndex = 5
    Me.StopClock.Text = "STOP"
    Me.StopClock.UseVisualStyleBackColor = False
    '
    'StartClock
    '
    Me.StartClock.BackColor = System.Drawing.Color.MediumAquamarine
    Me.StartClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.StartClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.StartClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.StartClock.Location = New System.Drawing.Point(3, 160)
    Me.StartClock.Name = "StartClock"
    Me.StartClock.Size = New System.Drawing.Size(71, 37)
    Me.StartClock.TabIndex = 4
    Me.StartClock.Text = "START"
    Me.StartClock.UseVisualStyleBackColor = False
    '
    'grpPossession
    '
    Me.grpPossession.Controls.Add(Me.txtOutOfPlay)
    Me.grpPossession.Controls.Add(Me.lblOutOfPlay)
    Me.grpPossession.Controls.Add(Me.lblPossessionLast10Away)
    Me.grpPossession.Controls.Add(Me.lblPossessionLast5Away)
    Me.grpPossession.Controls.Add(Me.lblPossession2ndAway)
    Me.grpPossession.Controls.Add(Me.lblPossession1stAway)
    Me.grpPossession.Controls.Add(Me.lblPossessionAwayAttk)
    Me.grpPossession.Controls.Add(Me.lblPossessionAwayMidF)
    Me.grpPossession.Controls.Add(Me.lblPossessionAwayOwnF)
    Me.grpPossession.Controls.Add(Me.lblPossessionMatchAway)
    Me.grpPossession.Controls.Add(Me.txtPossessionAwayAttk)
    Me.grpPossession.Controls.Add(Me.txtPossessionAwayMidF)
    Me.grpPossession.Controls.Add(Me.txtPossessionAwayOwnT)
    Me.grpPossession.Controls.Add(Me.lblAwayTeam3)
    Me.grpPossession.Controls.Add(Me.lblPossessionLast10Home)
    Me.grpPossession.Controls.Add(Me.lblPossessionLast5Home)
    Me.grpPossession.Controls.Add(Me.lblPossession2ndHome)
    Me.grpPossession.Controls.Add(Me.lblPossession1stHome)
    Me.grpPossession.Controls.Add(Me.lblPossessionHomeAttk)
    Me.grpPossession.Controls.Add(Me.lblPossessionHomeMidF)
    Me.grpPossession.Controls.Add(Me.lblPossessionHomeOwnF)
    Me.grpPossession.Controls.Add(Me.lblPossessionMatchHome)
    Me.grpPossession.Controls.Add(Me.txtPossessionHomeAttk)
    Me.grpPossession.Controls.Add(Me.txtPossessionHomeMidF)
    Me.grpPossession.Controls.Add(Me.txtPossessionHomeOwnT)
    Me.grpPossession.Controls.Add(Me.label65)
    Me.grpPossession.Controls.Add(Me.label66)
    Me.grpPossession.Controls.Add(Me.label64)
    Me.grpPossession.Controls.Add(Me.label63)
    Me.grpPossession.Controls.Add(Me.label62)
    Me.grpPossession.Controls.Add(Me.label61)
    Me.grpPossession.Controls.Add(Me.label60)
    Me.grpPossession.Controls.Add(Me.label59)
    Me.grpPossession.Controls.Add(Me.label58)
    Me.grpPossession.Controls.Add(Me.label57)
    Me.grpPossession.Controls.Add(Me.lblHomeTeam3)
    Me.grpPossession.Controls.Add(Me.lblPossessionAttk)
    Me.grpPossession.Controls.Add(Me.lblPossessionMidF)
    Me.grpPossession.Controls.Add(Me.lblPossessionOwnT)
    Me.grpPossession.Controls.Add(Me.label52)
    Me.grpPossession.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpPossession.Location = New System.Drawing.Point(3, 500)
    Me.grpPossession.Name = "grpPossession"
    Me.grpPossession.Size = New System.Drawing.Size(620, 141)
    Me.grpPossession.TabIndex = 372
    Me.grpPossession.TabStop = False
    Me.grpPossession.Text = "Possession and Territory"
    '
    'txtOutOfPlay
    '
    Me.txtOutOfPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtOutOfPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOutOfPlay.Location = New System.Drawing.Point(127, 118)
    Me.txtOutOfPlay.Name = "txtOutOfPlay"
    Me.txtOutOfPlay.ReadOnly = True
    Me.txtOutOfPlay.Size = New System.Drawing.Size(126, 20)
    Me.txtOutOfPlay.TabIndex = 188
    Me.txtOutOfPlay.Text = "0"
    Me.txtOutOfPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblOutOfPlay
    '
    Me.lblOutOfPlay.BackColor = System.Drawing.Color.LawnGreen
    Me.lblOutOfPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblOutOfPlay.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblOutOfPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOutOfPlay.Location = New System.Drawing.Point(6, 118)
    Me.lblOutOfPlay.Name = "lblOutOfPlay"
    Me.lblOutOfPlay.Size = New System.Drawing.Size(115, 20)
    Me.lblOutOfPlay.TabIndex = 187
    Me.lblOutOfPlay.Text = "Out of Play"
    Me.lblOutOfPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionLast10Away
    '
    Me.lblPossessionLast10Away.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionLast10Away.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionLast10Away.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionLast10Away.Location = New System.Drawing.Point(568, 95)
    Me.lblPossessionLast10Away.Name = "lblPossessionLast10Away"
    Me.lblPossessionLast10Away.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionLast10Away.TabIndex = 186
    Me.lblPossessionLast10Away.Text = "50 %"
    Me.lblPossessionLast10Away.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionLast5Away
    '
    Me.lblPossessionLast5Away.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionLast5Away.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionLast5Away.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionLast5Away.Location = New System.Drawing.Point(527, 95)
    Me.lblPossessionLast5Away.Name = "lblPossessionLast5Away"
    Me.lblPossessionLast5Away.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionLast5Away.TabIndex = 185
    Me.lblPossessionLast5Away.Text = "50 %"
    Me.lblPossessionLast5Away.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossession2ndAway
    '
    Me.lblPossession2ndAway.BackColor = System.Drawing.Color.Gray
    Me.lblPossession2ndAway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossession2ndAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossession2ndAway.Location = New System.Drawing.Point(480, 95)
    Me.lblPossession2ndAway.Name = "lblPossession2ndAway"
    Me.lblPossession2ndAway.Size = New System.Drawing.Size(42, 20)
    Me.lblPossession2ndAway.TabIndex = 184
    Me.lblPossession2ndAway.Text = "50 %"
    Me.lblPossession2ndAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossession1stAway
    '
    Me.lblPossession1stAway.BackColor = System.Drawing.Color.Gray
    Me.lblPossession1stAway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossession1stAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossession1stAway.Location = New System.Drawing.Point(438, 95)
    Me.lblPossession1stAway.Name = "lblPossession1stAway"
    Me.lblPossession1stAway.Size = New System.Drawing.Size(42, 20)
    Me.lblPossession1stAway.TabIndex = 183
    Me.lblPossession1stAway.Text = "50 %"
    Me.lblPossession1stAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionAwayAttk
    '
    Me.lblPossessionAwayAttk.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionAwayAttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionAwayAttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionAwayAttk.Location = New System.Drawing.Point(390, 95)
    Me.lblPossessionAwayAttk.Name = "lblPossessionAwayAttk"
    Me.lblPossessionAwayAttk.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionAwayAttk.TabIndex = 182
    Me.lblPossessionAwayAttk.Text = "50 %"
    Me.lblPossessionAwayAttk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionAwayMidF
    '
    Me.lblPossessionAwayMidF.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionAwayMidF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionAwayMidF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionAwayMidF.Location = New System.Drawing.Point(349, 95)
    Me.lblPossessionAwayMidF.Name = "lblPossessionAwayMidF"
    Me.lblPossessionAwayMidF.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionAwayMidF.TabIndex = 181
    Me.lblPossessionAwayMidF.Text = "50 %"
    Me.lblPossessionAwayMidF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionAwayOwnF
    '
    Me.lblPossessionAwayOwnF.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionAwayOwnF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionAwayOwnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionAwayOwnF.Location = New System.Drawing.Point(308, 95)
    Me.lblPossessionAwayOwnF.Name = "lblPossessionAwayOwnF"
    Me.lblPossessionAwayOwnF.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionAwayOwnF.TabIndex = 180
    Me.lblPossessionAwayOwnF.Text = "50 %"
    Me.lblPossessionAwayOwnF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionMatchAway
    '
    Me.lblPossessionMatchAway.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionMatchAway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionMatchAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionMatchAway.Location = New System.Drawing.Point(260, 95)
    Me.lblPossessionMatchAway.Name = "lblPossessionMatchAway"
    Me.lblPossessionMatchAway.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionMatchAway.TabIndex = 179
    Me.lblPossessionMatchAway.Text = "50 %"
    Me.lblPossessionMatchAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtPossessionAwayAttk
    '
    Me.txtPossessionAwayAttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionAwayAttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionAwayAttk.Location = New System.Drawing.Point(211, 95)
    Me.txtPossessionAwayAttk.Name = "txtPossessionAwayAttk"
    Me.txtPossessionAwayAttk.ReadOnly = True
    Me.txtPossessionAwayAttk.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionAwayAttk.TabIndex = 178
    Me.txtPossessionAwayAttk.Text = "0"
    Me.txtPossessionAwayAttk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtPossessionAwayMidF
    '
    Me.txtPossessionAwayMidF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionAwayMidF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionAwayMidF.Location = New System.Drawing.Point(169, 95)
    Me.txtPossessionAwayMidF.Name = "txtPossessionAwayMidF"
    Me.txtPossessionAwayMidF.ReadOnly = True
    Me.txtPossessionAwayMidF.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionAwayMidF.TabIndex = 177
    Me.txtPossessionAwayMidF.Text = "0"
    Me.txtPossessionAwayMidF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtPossessionAwayOwnT
    '
    Me.txtPossessionAwayOwnT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionAwayOwnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionAwayOwnT.Location = New System.Drawing.Point(127, 95)
    Me.txtPossessionAwayOwnT.Name = "txtPossessionAwayOwnT"
    Me.txtPossessionAwayOwnT.ReadOnly = True
    Me.txtPossessionAwayOwnT.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionAwayOwnT.TabIndex = 176
    Me.txtPossessionAwayOwnT.Text = "0"
    Me.txtPossessionAwayOwnT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblAwayTeam3
    '
    Me.lblAwayTeam3.BackColor = System.Drawing.Color.Black
    Me.lblAwayTeam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblAwayTeam3.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblAwayTeam3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAwayTeam3.ForeColor = System.Drawing.Color.White
    Me.lblAwayTeam3.Location = New System.Drawing.Point(6, 95)
    Me.lblAwayTeam3.Name = "lblAwayTeam3"
    Me.lblAwayTeam3.Size = New System.Drawing.Size(115, 20)
    Me.lblAwayTeam3.TabIndex = 175
    Me.lblAwayTeam3.Text = "??"
    Me.lblAwayTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionLast10Home
    '
    Me.lblPossessionLast10Home.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionLast10Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionLast10Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionLast10Home.Location = New System.Drawing.Point(568, 72)
    Me.lblPossessionLast10Home.Name = "lblPossessionLast10Home"
    Me.lblPossessionLast10Home.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionLast10Home.TabIndex = 174
    Me.lblPossessionLast10Home.Text = "50 %"
    Me.lblPossessionLast10Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionLast5Home
    '
    Me.lblPossessionLast5Home.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionLast5Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionLast5Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionLast5Home.Location = New System.Drawing.Point(527, 72)
    Me.lblPossessionLast5Home.Name = "lblPossessionLast5Home"
    Me.lblPossessionLast5Home.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionLast5Home.TabIndex = 173
    Me.lblPossessionLast5Home.Text = "50 %"
    Me.lblPossessionLast5Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossession2ndHome
    '
    Me.lblPossession2ndHome.BackColor = System.Drawing.Color.Gray
    Me.lblPossession2ndHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossession2ndHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossession2ndHome.Location = New System.Drawing.Point(480, 72)
    Me.lblPossession2ndHome.Name = "lblPossession2ndHome"
    Me.lblPossession2ndHome.Size = New System.Drawing.Size(42, 20)
    Me.lblPossession2ndHome.TabIndex = 172
    Me.lblPossession2ndHome.Text = "50 %"
    Me.lblPossession2ndHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossession1stHome
    '
    Me.lblPossession1stHome.BackColor = System.Drawing.Color.Gray
    Me.lblPossession1stHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossession1stHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossession1stHome.Location = New System.Drawing.Point(438, 72)
    Me.lblPossession1stHome.Name = "lblPossession1stHome"
    Me.lblPossession1stHome.Size = New System.Drawing.Size(42, 20)
    Me.lblPossession1stHome.TabIndex = 171
    Me.lblPossession1stHome.Text = "50 %"
    Me.lblPossession1stHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionHomeAttk
    '
    Me.lblPossessionHomeAttk.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionHomeAttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionHomeAttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionHomeAttk.Location = New System.Drawing.Point(390, 72)
    Me.lblPossessionHomeAttk.Name = "lblPossessionHomeAttk"
    Me.lblPossessionHomeAttk.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionHomeAttk.TabIndex = 170
    Me.lblPossessionHomeAttk.Text = "50 %"
    Me.lblPossessionHomeAttk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionHomeMidF
    '
    Me.lblPossessionHomeMidF.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionHomeMidF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionHomeMidF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionHomeMidF.Location = New System.Drawing.Point(349, 72)
    Me.lblPossessionHomeMidF.Name = "lblPossessionHomeMidF"
    Me.lblPossessionHomeMidF.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionHomeMidF.TabIndex = 169
    Me.lblPossessionHomeMidF.Text = "50 %"
    Me.lblPossessionHomeMidF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionHomeOwnF
    '
    Me.lblPossessionHomeOwnF.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionHomeOwnF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionHomeOwnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionHomeOwnF.Location = New System.Drawing.Point(308, 72)
    Me.lblPossessionHomeOwnF.Name = "lblPossessionHomeOwnF"
    Me.lblPossessionHomeOwnF.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionHomeOwnF.TabIndex = 168
    Me.lblPossessionHomeOwnF.Text = "50 %"
    Me.lblPossessionHomeOwnF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionMatchHome
    '
    Me.lblPossessionMatchHome.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionMatchHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionMatchHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblPossessionMatchHome.Location = New System.Drawing.Point(260, 72)
    Me.lblPossessionMatchHome.Name = "lblPossessionMatchHome"
    Me.lblPossessionMatchHome.Size = New System.Drawing.Size(42, 20)
    Me.lblPossessionMatchHome.TabIndex = 167
    Me.lblPossessionMatchHome.Text = "50 %"
    Me.lblPossessionMatchHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtPossessionHomeAttk
    '
    Me.txtPossessionHomeAttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionHomeAttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionHomeAttk.Location = New System.Drawing.Point(211, 72)
    Me.txtPossessionHomeAttk.Name = "txtPossessionHomeAttk"
    Me.txtPossessionHomeAttk.ReadOnly = True
    Me.txtPossessionHomeAttk.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionHomeAttk.TabIndex = 166
    Me.txtPossessionHomeAttk.Text = "0"
    Me.txtPossessionHomeAttk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtPossessionHomeMidF
    '
    Me.txtPossessionHomeMidF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionHomeMidF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionHomeMidF.Location = New System.Drawing.Point(169, 72)
    Me.txtPossessionHomeMidF.Name = "txtPossessionHomeMidF"
    Me.txtPossessionHomeMidF.ReadOnly = True
    Me.txtPossessionHomeMidF.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionHomeMidF.TabIndex = 165
    Me.txtPossessionHomeMidF.Text = "0"
    Me.txtPossessionHomeMidF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtPossessionHomeOwnT
    '
    Me.txtPossessionHomeOwnT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPossessionHomeOwnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPossessionHomeOwnT.Location = New System.Drawing.Point(127, 72)
    Me.txtPossessionHomeOwnT.Name = "txtPossessionHomeOwnT"
    Me.txtPossessionHomeOwnT.ReadOnly = True
    Me.txtPossessionHomeOwnT.Size = New System.Drawing.Size(42, 20)
    Me.txtPossessionHomeOwnT.TabIndex = 164
    Me.txtPossessionHomeOwnT.Text = "0"
    Me.txtPossessionHomeOwnT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'label65
    '
    Me.label65.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label65.Location = New System.Drawing.Point(568, 40)
    Me.label65.Name = "label65"
    Me.label65.Size = New System.Drawing.Size(42, 29)
    Me.label65.TabIndex = 163
    Me.label65.Text = "Last 10"
    Me.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label66
    '
    Me.label66.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label66.Location = New System.Drawing.Point(527, 40)
    Me.label66.Name = "label66"
    Me.label66.Size = New System.Drawing.Size(42, 29)
    Me.label66.TabIndex = 162
    Me.label66.Text = " Last  5"
    Me.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label64
    '
    Me.label64.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label64.Location = New System.Drawing.Point(390, 54)
    Me.label64.Name = "label64"
    Me.label64.Size = New System.Drawing.Size(42, 15)
    Me.label64.TabIndex = 161
    Me.label64.Text = "Attack"
    Me.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label63
    '
    Me.label63.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label63.Location = New System.Drawing.Point(349, 54)
    Me.label63.Name = "label63"
    Me.label63.Size = New System.Drawing.Size(42, 15)
    Me.label63.TabIndex = 160
    Me.label63.Text = "Mid"
    Me.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label62
    '
    Me.label62.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label62.Location = New System.Drawing.Point(308, 54)
    Me.label62.Name = "label62"
    Me.label62.Size = New System.Drawing.Size(42, 15)
    Me.label62.TabIndex = 159
    Me.label62.Text = "Own"
    Me.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label61
    '
    Me.label61.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label61.Location = New System.Drawing.Point(308, 40)
    Me.label61.Name = "label61"
    Me.label61.Size = New System.Drawing.Size(124, 14)
    Me.label61.TabIndex = 158
    Me.label61.Text = "of witch"
    Me.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label60
    '
    Me.label60.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label60.Location = New System.Drawing.Point(480, 40)
    Me.label60.Name = "label60"
    Me.label60.Size = New System.Drawing.Size(42, 29)
    Me.label60.TabIndex = 157
    Me.label60.Text = "2nd Half"
    Me.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label59
    '
    Me.label59.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label59.Location = New System.Drawing.Point(439, 40)
    Me.label59.Name = "label59"
    Me.label59.Size = New System.Drawing.Size(42, 29)
    Me.label59.TabIndex = 156
    Me.label59.Text = "1st Half"
    Me.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label58
    '
    Me.label58.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label58.Location = New System.Drawing.Point(260, 40)
    Me.label58.Name = "label58"
    Me.label58.Size = New System.Drawing.Size(42, 29)
    Me.label58.TabIndex = 155
    Me.label58.Text = "Match"
    Me.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label57
    '
    Me.label57.BackColor = System.Drawing.Color.Gray
    Me.label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label57.Location = New System.Drawing.Point(260, 16)
    Me.label57.Name = "label57"
    Me.label57.Size = New System.Drawing.Size(350, 21)
    Me.label57.TabIndex = 154
    Me.label57.Text = "Possession"
    Me.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblHomeTeam3
    '
    Me.lblHomeTeam3.BackColor = System.Drawing.Color.Black
    Me.lblHomeTeam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblHomeTeam3.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblHomeTeam3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHomeTeam3.ForeColor = System.Drawing.Color.White
    Me.lblHomeTeam3.Location = New System.Drawing.Point(6, 72)
    Me.lblHomeTeam3.Name = "lblHomeTeam3"
    Me.lblHomeTeam3.Size = New System.Drawing.Size(115, 20)
    Me.lblHomeTeam3.TabIndex = 153
    Me.lblHomeTeam3.Text = "??"
    Me.lblHomeTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionAttk
    '
    Me.lblPossessionAttk.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionAttk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionAttk.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblPossessionAttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPossessionAttk.Location = New System.Drawing.Point(211, 40)
    Me.lblPossessionAttk.Name = "lblPossessionAttk"
    Me.lblPossessionAttk.Size = New System.Drawing.Size(42, 29)
    Me.lblPossessionAttk.TabIndex = 152
    Me.lblPossessionAttk.Text = "Attack Thrid"
    Me.lblPossessionAttk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionMidF
    '
    Me.lblPossessionMidF.BackColor = System.Drawing.Color.LawnGreen
    Me.lblPossessionMidF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionMidF.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblPossessionMidF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPossessionMidF.Location = New System.Drawing.Point(169, 40)
    Me.lblPossessionMidF.Name = "lblPossessionMidF"
    Me.lblPossessionMidF.Size = New System.Drawing.Size(42, 29)
    Me.lblPossessionMidF.TabIndex = 151
    Me.lblPossessionMidF.Text = "Mid Field"
    Me.lblPossessionMidF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPossessionOwnT
    '
    Me.lblPossessionOwnT.BackColor = System.Drawing.Color.Gray
    Me.lblPossessionOwnT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblPossessionOwnT.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblPossessionOwnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPossessionOwnT.Location = New System.Drawing.Point(127, 40)
    Me.lblPossessionOwnT.Name = "lblPossessionOwnT"
    Me.lblPossessionOwnT.Size = New System.Drawing.Size(42, 29)
    Me.lblPossessionOwnT.TabIndex = 150
    Me.lblPossessionOwnT.Text = "Own Thrid"
    Me.lblPossessionOwnT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label52
    '
    Me.label52.BackColor = System.Drawing.Color.Gray
    Me.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label52.Location = New System.Drawing.Point(127, 16)
    Me.label52.Name = "label52"
    Me.label52.Size = New System.Drawing.Size(126, 21)
    Me.label52.TabIndex = 149
    Me.label52.Text = "WHERE?"
    Me.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'groupBox2
    '
    Me.TableLayoutPanel3.SetColumnSpan(Me.groupBox2, 2)
    Me.groupBox2.Controls.Add(Me.MetroGridEvents)
    Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.groupBox2.Location = New System.Drawing.Point(872, 500)
    Me.groupBox2.Name = "groupBox2"
    Me.groupBox2.Size = New System.Drawing.Size(281, 141)
    Me.groupBox2.TabIndex = 374
    Me.groupBox2.TabStop = False
    Me.groupBox2.Text = "Match Events"
    '
    'MetroGridEvents
    '
    Me.MetroGridEvents.AllowUserToAddRows = False
    Me.MetroGridEvents.AllowUserToDeleteRows = False
    Me.MetroGridEvents.AllowUserToResizeRows = False
    Me.MetroGridEvents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnImage, Me.ColumnType, Me.ColumnTime, Me.ColumnPlayer})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridEvents.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridEvents.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridEvents.EnableHeadersVisualStyles = False
    Me.MetroGridEvents.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridEvents.Location = New System.Drawing.Point(3, 16)
    Me.MetroGridEvents.Name = "MetroGridEvents"
    Me.MetroGridEvents.ReadOnly = True
    Me.MetroGridEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridEvents.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridEvents.RowHeadersVisible = False
    Me.MetroGridEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridEvents.Size = New System.Drawing.Size(275, 122)
    Me.MetroGridEvents.TabIndex = 1
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Visible = False
    '
    'ColumnImage
    '
    Me.ColumnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnImage.HeaderText = "Type"
    Me.ColumnImage.Name = "ColumnImage"
    Me.ColumnImage.ReadOnly = True
    Me.ColumnImage.Width = 34
    '
    'ColumnType
    '
    Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnType.HeaderText = "Type"
    Me.ColumnType.Name = "ColumnType"
    Me.ColumnType.ReadOnly = True
    Me.ColumnType.Width = 53
    '
    'ColumnTime
    '
    Me.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnTime.HeaderText = "Time"
    Me.ColumnTime.Name = "ColumnTime"
    Me.ColumnTime.ReadOnly = True
    Me.ColumnTime.Width = 53
    '
    'ColumnPlayer
    '
    Me.ColumnPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnPlayer.HeaderText = "Player"
    Me.ColumnPlayer.Name = "ColumnPlayer"
    Me.ColumnPlayer.ReadOnly = True
    '
    'imglstEvents
    '
    Me.imglstEvents.ImageStream = CType(resources.GetObject("imglstEvents.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imglstEvents.TransparentColor = System.Drawing.Color.Transparent
    Me.imglstEvents.Images.SetKeyName(0, "GOAL")
    Me.imglstEvents.Images.SetKeyName(1, "YELLOWCARD")
    Me.imglstEvents.Images.SetKeyName(2, "REDCARD")
    Me.imglstEvents.Images.SetKeyName(3, "SUBS_IN")
    Me.imglstEvents.Images.SetKeyName(4, "SUBS_OUT")
    Me.imglstEvents.Images.SetKeyName(5, "OFFSIDES")
    Me.imglstEvents.Images.SetKeyName(6, "CORNERS")
    Me.imglstEvents.Images.SetKeyName(7, "SAVES")
    Me.imglstEvents.Images.SetKeyName(8, "SHOTS")
    Me.imglstEvents.Images.SetKeyName(9, "SHOTS_ON_TARGET")
    Me.imglstEvents.Images.SetKeyName(10, "FOULS")
    Me.imglstEvents.Images.SetKeyName(11, "ASSIS")
    Me.imglstEvents.Images.SetKeyName(12, "WOOD_HITS")
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.TableLayoutPanel2)
    Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.groupBox1.Location = New System.Drawing.Point(629, 500)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(237, 141)
    Me.groupBox1.TabIndex = 373
    Me.groupBox1.TabStop = False
    Me.groupBox1.Text = "Team Stats"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 4
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.lblHomeTeam2, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.label91, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.label90, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.label89, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.lblAwayTeam2, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlHomeCorners, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlHomeOffsides, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlHomeWood, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlAwayCorners, 3, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlAwayOffsides, 3, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.SingleStatControlAwayWood, 3, 3)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 5
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(231, 122)
    Me.TableLayoutPanel2.TabIndex = 535
    '
    'lblHomeTeam2
    '
    Me.lblHomeTeam2.BackColor = System.Drawing.Color.Black
    Me.lblHomeTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel2.SetColumnSpan(Me.lblHomeTeam2, 2)
    Me.lblHomeTeam2.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblHomeTeam2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblHomeTeam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHomeTeam2.ForeColor = System.Drawing.Color.White
    Me.lblHomeTeam2.Location = New System.Drawing.Point(3, 0)
    Me.lblHomeTeam2.Name = "lblHomeTeam2"
    Me.lblHomeTeam2.Size = New System.Drawing.Size(109, 30)
    Me.lblHomeTeam2.TabIndex = 154
    Me.lblHomeTeam2.Text = "??"
    Me.lblHomeTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label91
    '
    Me.label91.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel2.SetColumnSpan(Me.label91, 2)
    Me.label91.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label91.Location = New System.Drawing.Point(80, 90)
    Me.label91.Name = "label91"
    Me.label91.Size = New System.Drawing.Size(70, 30)
    Me.label91.TabIndex = 179
    Me.label91.Text = "Wood Hits"
    Me.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label90
    '
    Me.label90.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel2.SetColumnSpan(Me.label90, 2)
    Me.label90.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label90.Location = New System.Drawing.Point(80, 60)
    Me.label90.Name = "label90"
    Me.label90.Size = New System.Drawing.Size(70, 30)
    Me.label90.TabIndex = 178
    Me.label90.Text = "Offsides"
    Me.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label89
    '
    Me.label89.BackColor = System.Drawing.Color.MediumTurquoise
    Me.label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel2.SetColumnSpan(Me.label89, 2)
    Me.label89.Dock = System.Windows.Forms.DockStyle.Fill
    Me.label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label89.Location = New System.Drawing.Point(80, 30)
    Me.label89.Name = "label89"
    Me.label89.Size = New System.Drawing.Size(70, 30)
    Me.label89.TabIndex = 177
    Me.label89.Text = "Corners"
    Me.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblAwayTeam2
    '
    Me.lblAwayTeam2.BackColor = System.Drawing.Color.Black
    Me.lblAwayTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel2.SetColumnSpan(Me.lblAwayTeam2, 2)
    Me.lblAwayTeam2.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblAwayTeam2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblAwayTeam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAwayTeam2.ForeColor = System.Drawing.Color.White
    Me.lblAwayTeam2.Location = New System.Drawing.Point(118, 0)
    Me.lblAwayTeam2.Name = "lblAwayTeam2"
    Me.lblAwayTeam2.Size = New System.Drawing.Size(110, 30)
    Me.lblAwayTeam2.TabIndex = 176
    Me.lblAwayTeam2.Text = "??"
    Me.lblAwayTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tmrRefresh
    '
    Me.tmrRefresh.Enabled = True
    '
    'tmrClock
    '
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 626.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.groupBox2, 2, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.groupBox1, 1, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanelTeams, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.grpPossession, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.grpControls, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanelBottom, 0, 2)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 28)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 3
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(1156, 674)
    Me.TableLayoutPanel3.TabIndex = 381
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSettings})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(1180, 25)
    Me.ToolStrip1.TabIndex = 382
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'ToolStripButtonSettings
    '
    Me.ToolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.ToolStripButtonSettings.Image = CType(resources.GetObject("ToolStripButtonSettings.Image"), System.Drawing.Image)
    Me.ToolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButtonSettings.Name = "ToolStripButtonSettings"
    Me.ToolStripButtonSettings.Size = New System.Drawing.Size(53, 22)
    Me.ToolStripButtonSettings.Text = "Settings"
    '
    'TableLayoutPanelBottom
    '
    Me.TableLayoutPanelBottom.ColumnCount = 2
    Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanelBottom, 4)
    Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelBottom.Controls.Add(Me.LabelAppVersion, 0, 0)
    Me.TableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelBottom.Location = New System.Drawing.Point(0, 644)
    Me.TableLayoutPanelBottom.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanelBottom.Name = "TableLayoutPanelBottom"
    Me.TableLayoutPanelBottom.RowCount = 1
    Me.TableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelBottom.Size = New System.Drawing.Size(1156, 30)
    Me.TableLayoutPanelBottom.TabIndex = 380
    '
    'LabelAppVersion
    '
    Me.LabelAppVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelAppVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelAppVersion.Location = New System.Drawing.Point(3, 0)
    Me.LabelAppVersion.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
    Me.LabelAppVersion.Name = "LabelAppVersion"
    Me.LabelAppVersion.Size = New System.Drawing.Size(74, 27)
    Me.LabelAppVersion.TabIndex = 5
    Me.LabelAppVersion.Text = "App version"
    Me.LabelAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TeamControlHome
    '
    Me.TeamControlHome.BackColor = System.Drawing.Color.White
    Me.TeamControlHome.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TeamControlHome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TeamControlHome.Location = New System.Drawing.Point(3, 3)
    Me.TeamControlHome.Name = "TeamControlHome"
    Me.TeamControlHome.Size = New System.Drawing.Size(486, 485)
    Me.TeamControlHome.TabIndex = 378
    Me.TeamControlHome.Team = Nothing
    '
    'TeamControlAway
    '
    Me.TeamControlAway.BackColor = System.Drawing.Color.White
    Me.TeamControlAway.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TeamControlAway.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TeamControlAway.Location = New System.Drawing.Point(495, 3)
    Me.TeamControlAway.Name = "TeamControlAway"
    Me.TeamControlAway.Size = New System.Drawing.Size(486, 485)
    Me.TeamControlAway.TabIndex = 379
    Me.TeamControlAway.Team = Nothing
    '
    'SingleStatControlHomeCorners
    '
    Me.SingleStatControlHomeCorners.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlHomeCorners.Location = New System.Drawing.Point(3, 33)
    Me.SingleStatControlHomeCorners.Name = "SingleStatControlHomeCorners"
    Me.SingleStatControlHomeCorners.Size = New System.Drawing.Size(71, 24)
    Me.SingleStatControlHomeCorners.Stat = Nothing
    Me.SingleStatControlHomeCorners.StatSubject = Nothing
    Me.SingleStatControlHomeCorners.TabIndex = 535
    '
    'SingleStatControlHomeOffsides
    '
    Me.SingleStatControlHomeOffsides.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlHomeOffsides.Location = New System.Drawing.Point(3, 63)
    Me.SingleStatControlHomeOffsides.Name = "SingleStatControlHomeOffsides"
    Me.SingleStatControlHomeOffsides.Size = New System.Drawing.Size(71, 24)
    Me.SingleStatControlHomeOffsides.Stat = Nothing
    Me.SingleStatControlHomeOffsides.StatSubject = Nothing
    Me.SingleStatControlHomeOffsides.TabIndex = 536
    '
    'SingleStatControlHomeWood
    '
    Me.SingleStatControlHomeWood.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlHomeWood.Location = New System.Drawing.Point(3, 93)
    Me.SingleStatControlHomeWood.Name = "SingleStatControlHomeWood"
    Me.SingleStatControlHomeWood.Size = New System.Drawing.Size(71, 24)
    Me.SingleStatControlHomeWood.Stat = Nothing
    Me.SingleStatControlHomeWood.StatSubject = Nothing
    Me.SingleStatControlHomeWood.TabIndex = 537
    '
    'SingleStatControlAwayCorners
    '
    Me.SingleStatControlAwayCorners.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlAwayCorners.Location = New System.Drawing.Point(156, 33)
    Me.SingleStatControlAwayCorners.Name = "SingleStatControlAwayCorners"
    Me.SingleStatControlAwayCorners.Size = New System.Drawing.Size(72, 24)
    Me.SingleStatControlAwayCorners.Stat = Nothing
    Me.SingleStatControlAwayCorners.StatSubject = Nothing
    Me.SingleStatControlAwayCorners.TabIndex = 538
    '
    'SingleStatControlAwayOffsides
    '
    Me.SingleStatControlAwayOffsides.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlAwayOffsides.Location = New System.Drawing.Point(156, 63)
    Me.SingleStatControlAwayOffsides.Name = "SingleStatControlAwayOffsides"
    Me.SingleStatControlAwayOffsides.Size = New System.Drawing.Size(72, 24)
    Me.SingleStatControlAwayOffsides.Stat = Nothing
    Me.SingleStatControlAwayOffsides.StatSubject = Nothing
    Me.SingleStatControlAwayOffsides.TabIndex = 539
    '
    'SingleStatControlAwayWood
    '
    Me.SingleStatControlAwayWood.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlAwayWood.Location = New System.Drawing.Point(156, 93)
    Me.SingleStatControlAwayWood.Name = "SingleStatControlAwayWood"
    Me.SingleStatControlAwayWood.Size = New System.Drawing.Size(72, 24)
    Me.SingleStatControlAwayWood.Stat = Nothing
    Me.SingleStatControlAwayWood.StatSubject = Nothing
    Me.SingleStatControlAwayWood.TabIndex = 540
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(1180, 702)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.TableLayoutPanel3)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmMain"
    Me.Text = "AlKamel soccer logger"
    Me.TableLayoutPanelTeams.ResumeLayout(False)
    Me.grpControls.ResumeLayout(False)
    Me.tableLayoutPanelPeriodes.ResumeLayout(False)
    Me.tableLayoutPanelPeriodes.PerformLayout()
    Me.grpPossession.ResumeLayout(False)
    Me.grpPossession.PerformLayout()
    Me.groupBox2.ResumeLayout(False)
    CType(Me.MetroGridEvents, System.ComponentModel.ISupportInitialize).EndInit()
    Me.groupBox1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.TableLayoutPanelBottom.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents grpControls As GroupBox
  Private WithEvents tableLayoutPanelPeriodes As TableLayoutPanel
  Private WithEvents rdbExtra2 As MetroFramework.Controls.MetroRadioButton
  Private WithEvents rdbExtra1 As MetroFramework.Controls.MetroRadioButton
  Private WithEvents rdb2ndHalf As MetroFramework.Controls.MetroRadioButton
  Private WithEvents rdb1stHalf As MetroFramework.Controls.MetroRadioButton
  Private WithEvents btnClockReset As Button
  Private WithEvents txtClock As Label
  Private WithEvents btnOverwriteClock As Button
  Private WithEvents StartClock As Button
  Private WithEvents StopClock As Button
  Private WithEvents grpPossession As GroupBox
  Private WithEvents txtOutOfPlay As TextBox
  Private WithEvents lblOutOfPlay As Label
  Private WithEvents lblPossessionLast10Away As Label
  Private WithEvents lblPossessionLast5Away As Label
  Private WithEvents lblPossession2ndAway As Label
  Private WithEvents lblPossession1stAway As Label
  Private WithEvents lblPossessionAwayAttk As Label
  Private WithEvents lblPossessionAwayMidF As Label
  Private WithEvents lblPossessionAwayOwnF As Label
  Private WithEvents lblPossessionMatchAway As Label
  Private WithEvents txtPossessionAwayAttk As TextBox
  Private WithEvents txtPossessionAwayMidF As TextBox
  Private WithEvents txtPossessionAwayOwnT As TextBox
  Private WithEvents lblAwayTeam3 As Label
  Private WithEvents lblPossessionLast10Home As Label
  Private WithEvents lblPossessionLast5Home As Label
  Private WithEvents lblPossession2ndHome As Label
  Private WithEvents lblPossession1stHome As Label
  Private WithEvents lblPossessionHomeAttk As Label
  Private WithEvents lblPossessionHomeMidF As Label
  Private WithEvents lblPossessionHomeOwnF As Label
  Private WithEvents lblPossessionMatchHome As Label
  Private WithEvents txtPossessionHomeAttk As TextBox
  Private WithEvents txtPossessionHomeMidF As TextBox
  Private WithEvents txtPossessionHomeOwnT As TextBox
  Private WithEvents label65 As Label
  Private WithEvents label66 As Label
  Private WithEvents label64 As Label
  Private WithEvents label63 As Label
  Private WithEvents label62 As Label
  Private WithEvents label61 As Label
  Private WithEvents label60 As Label
  Private WithEvents label59 As Label
  Private WithEvents label58 As Label
  Private WithEvents label57 As Label
  Private WithEvents lblHomeTeam3 As Label
  Private WithEvents lblPossessionAttk As Label
  Private WithEvents lblPossessionMidF As Label
  Private WithEvents lblPossessionOwnT As Label
  Private WithEvents label52 As Label
  Private WithEvents groupBox2 As GroupBox
  Private WithEvents groupBox1 As GroupBox
  Private WithEvents label91 As Label
  Private WithEvents label90 As Label
  Private WithEvents label89 As Label
  Private WithEvents lblAwayTeam2 As Label
  Private WithEvents lblHomeTeam2 As Label
  Friend WithEvents tmrRefresh As Timer
  Friend WithEvents tmrClock As Timer
  Friend WithEvents TeamControlHome As TeamControl
  Friend WithEvents TableLayoutPanelTeams As TableLayoutPanel
  Friend WithEvents TeamControlAway As TeamControl
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents SingleStatControlHomeCorners As SingleStatControl
  Friend WithEvents SingleStatControlHomeOffsides As SingleStatControl
  Friend WithEvents SingleStatControlHomeWood As SingleStatControl
  Friend WithEvents SingleStatControlAwayCorners As SingleStatControl
  Friend WithEvents SingleStatControlAwayOffsides As SingleStatControl
  Friend WithEvents SingleStatControlAwayWood As SingleStatControl
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Private WithEvents imglstEvents As ImageList
  Friend WithEvents MetroGridEvents As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnImage As DataGridViewImageColumn
  Friend WithEvents ColumnType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTime As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayer As DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip1 As ToolStrip
  Friend WithEvents ToolStripButtonSettings As ToolStripButton
  Friend WithEvents MetroLabelPeriodName As Label
  Friend WithEvents MetroLabelPeriodTime As Label
  Friend WithEvents TableLayoutPanelBottom As TableLayoutPanel
  Friend WithEvents LabelAppVersion As Label
End Class
