<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiFileDownloader
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanelDownloaders = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroGridDownlodas = New MetroFramework.Controls.MetroGrid()
    Me.ColumnDownloadsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDownloadsURL = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDownloadsLocalFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDownloadsState = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDownloadsProgress = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanelMini = New System.Windows.Forms.TableLayoutPanel()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
    Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.FileDownloader3 = New Opta_get_data.FileDownloader()
    Me.FileDownloader1 = New Opta_get_data.FileDownloader()
    Me.FileDownloader2 = New Opta_get_data.FileDownloader()
    Me.TableLayoutPanelDownloaders.SuspendLayout()
    CType(Me.MetroGridDownlodas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanelMini.SuspendLayout()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelDownloaders
    '
    Me.TableLayoutPanelDownloaders.ColumnCount = 1
    Me.TableLayoutPanelDownloaders.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelDownloaders.Controls.Add(Me.FileDownloader3, 0, 2)
    Me.TableLayoutPanelDownloaders.Controls.Add(Me.FileDownloader1, 0, 0)
    Me.TableLayoutPanelDownloaders.Controls.Add(Me.FileDownloader2, 0, 1)
    Me.TableLayoutPanelDownloaders.Controls.Add(Me.MetroGridDownlodas, 0, 3)
    Me.TableLayoutPanelDownloaders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelDownloaders.Location = New System.Drawing.Point(3, 33)
    Me.TableLayoutPanelDownloaders.Name = "TableLayoutPanelDownloaders"
    Me.TableLayoutPanelDownloaders.RowCount = 4
    Me.TableLayoutPanelDownloaders.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelDownloaders.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelDownloaders.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelDownloaders.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelDownloaders.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelDownloaders.Size = New System.Drawing.Size(700, 339)
    Me.TableLayoutPanelDownloaders.TabIndex = 0
    '
    'MetroGridDownlodas
    '
    Me.MetroGridDownlodas.AllowUserToAddRows = False
    Me.MetroGridDownlodas.AllowUserToDeleteRows = False
    Me.MetroGridDownlodas.AllowUserToResizeRows = False
    Me.MetroGridDownlodas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridDownlodas.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridDownlodas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridDownlodas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridDownlodas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridDownlodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridDownlodas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDownloadsID, Me.ColumnDownloadsURL, Me.ColumnDownloadsLocalFile, Me.ColumnDownloadsState, Me.ColumnDownloadsProgress})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridDownlodas.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridDownlodas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridDownlodas.EnableHeadersVisualStyles = False
    Me.MetroGridDownlodas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridDownlodas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridDownlodas.Location = New System.Drawing.Point(3, 123)
    Me.MetroGridDownlodas.Name = "MetroGridDownlodas"
    Me.MetroGridDownlodas.ReadOnly = True
    Me.MetroGridDownlodas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridDownlodas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridDownlodas.RowHeadersVisible = False
    Me.MetroGridDownlodas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridDownlodas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridDownlodas.Size = New System.Drawing.Size(694, 213)
    Me.MetroGridDownlodas.TabIndex = 2
    '
    'ColumnDownloadsID
    '
    Me.ColumnDownloadsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDownloadsID.HeaderText = "ID"
    Me.ColumnDownloadsID.Name = "ColumnDownloadsID"
    Me.ColumnDownloadsID.ReadOnly = True
    Me.ColumnDownloadsID.Visible = False
    Me.ColumnDownloadsID.Width = 22
    '
    'ColumnDownloadsURL
    '
    Me.ColumnDownloadsURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDownloadsURL.HeaderText = "URL"
    Me.ColumnDownloadsURL.Name = "ColumnDownloadsURL"
    Me.ColumnDownloadsURL.ReadOnly = True
    Me.ColumnDownloadsURL.Width = 50
    '
    'ColumnDownloadsLocalFile
    '
    Me.ColumnDownloadsLocalFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnDownloadsLocalFile.HeaderText = "Download path"
    Me.ColumnDownloadsLocalFile.Name = "ColumnDownloadsLocalFile"
    Me.ColumnDownloadsLocalFile.ReadOnly = True
    '
    'ColumnDownloadsState
    '
    Me.ColumnDownloadsState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDownloadsState.HeaderText = "State"
    Me.ColumnDownloadsState.Name = "ColumnDownloadsState"
    Me.ColumnDownloadsState.ReadOnly = True
    Me.ColumnDownloadsState.Width = 56
    '
    'ColumnDownloadsProgress
    '
    Me.ColumnDownloadsProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnDownloadsProgress.HeaderText = "Progress"
    Me.ColumnDownloadsProgress.Name = "ColumnDownloadsProgress"
    Me.ColumnDownloadsProgress.ReadOnly = True
    Me.ColumnDownloadsProgress.Width = 74
    '
    'TableLayoutPanelMini
    '
    Me.TableLayoutPanelMini.ColumnCount = 3
    Me.TableLayoutPanelMini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelMini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanelMini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanelMini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelMini.Controls.Add(Me.ProgressBar1, 0, 0)
    Me.TableLayoutPanelMini.Controls.Add(Me.ProgressBar2, 1, 0)
    Me.TableLayoutPanelMini.Controls.Add(Me.ProgressBar3, 2, 0)
    Me.TableLayoutPanelMini.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelMini.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanelMini.Name = "TableLayoutPanelMini"
    Me.TableLayoutPanelMini.RowCount = 1
    Me.TableLayoutPanelMini.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelMini.Size = New System.Drawing.Size(700, 24)
    Me.TableLayoutPanelMini.TabIndex = 1
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ProgressBar1.Location = New System.Drawing.Point(3, 3)
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(227, 18)
    Me.ProgressBar1.TabIndex = 1
    '
    'ErrorProvider1
    '
    Me.ErrorProvider1.ContainerControl = Me
    '
    'ProgressBar2
    '
    Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ProgressBar2.Location = New System.Drawing.Point(236, 3)
    Me.ProgressBar2.Name = "ProgressBar2"
    Me.ProgressBar2.Size = New System.Drawing.Size(227, 18)
    Me.ProgressBar2.TabIndex = 2
    '
    'ProgressBar3
    '
    Me.ProgressBar3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ProgressBar3.Location = New System.Drawing.Point(469, 3)
    Me.ProgressBar3.Name = "ProgressBar3"
    Me.ProgressBar3.Size = New System.Drawing.Size(228, 18)
    Me.ProgressBar3.TabIndex = 3
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.TableLayoutPanelMini, 0, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.TableLayoutPanelDownloaders, 0, 1)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(706, 375)
    Me.TableLayoutPanelAll.TabIndex = 2
    '
    'FileDownloader3
    '
    Me.FileDownloader3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FileDownloader3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FileDownloader3.IsBusy = False
    Me.FileDownloader3.Location = New System.Drawing.Point(3, 84)
    Me.FileDownloader3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.FileDownloader3.Name = "FileDownloader3"
    Me.FileDownloader3.Size = New System.Drawing.Size(694, 32)
    Me.FileDownloader3.TabIndex = 3
    '
    'FileDownloader1
    '
    Me.FileDownloader1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FileDownloader1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FileDownloader1.IsBusy = False
    Me.FileDownloader1.Location = New System.Drawing.Point(3, 4)
    Me.FileDownloader1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.FileDownloader1.Name = "FileDownloader1"
    Me.FileDownloader1.Size = New System.Drawing.Size(694, 32)
    Me.FileDownloader1.TabIndex = 0
    '
    'FileDownloader2
    '
    Me.FileDownloader2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FileDownloader2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FileDownloader2.IsBusy = False
    Me.FileDownloader2.Location = New System.Drawing.Point(3, 44)
    Me.FileDownloader2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.FileDownloader2.Name = "FileDownloader2"
    Me.FileDownloader2.Size = New System.Drawing.Size(694, 32)
    Me.FileDownloader2.TabIndex = 1
    '
    'MultiFileDownloader
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "MultiFileDownloader"
    Me.Size = New System.Drawing.Size(706, 375)
    Me.TableLayoutPanelDownloaders.ResumeLayout(False)
    CType(Me.MetroGridDownlodas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanelMini.ResumeLayout(False)
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelDownloaders As TableLayoutPanel
  Friend WithEvents FileDownloader1 As FileDownloader
  Friend WithEvents FileDownloader2 As FileDownloader
  Friend WithEvents MetroGridDownlodas As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnDownloadsID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDownloadsURL As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDownloadsLocalFile As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDownloadsState As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDownloadsProgress As DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanelMini As TableLayoutPanel
  Friend WithEvents ProgressBar1 As ProgressBar
  Friend WithEvents ProgressBar2 As ProgressBar
  Friend WithEvents ProgressBar3 As ProgressBar
  Friend WithEvents ErrorProvider1 As ErrorProvider
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents FileDownloader3 As FileDownloader
End Class
