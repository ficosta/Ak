<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStreamControl
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
    Me.TableLayoutPanelAllControls = New System.Windows.Forms.TableLayoutPanel()
    Me.NumericUpDownLevel = New System.Windows.Forms.NumericUpDown()
    Me.MetroLabelLevel = New MetroFramework.Controls.MetroLabel()
    Me.MetroGridDevices = New MetroFramework.Controls.MetroGrid()
    Me.DeviceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IsTargeted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.IsBanned = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ContextMenuStripDevices = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.AddDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RemoveDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TableLayoutPanelAllControls.SuspendLayout()
    CType(Me.NumericUpDownLevel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridDevices, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStripDevices.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelAllControls
    '
    Me.TableLayoutPanelAllControls.ColumnCount = 2
    Me.TableLayoutPanelAllControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelAllControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAllControls.Controls.Add(Me.NumericUpDownLevel, 1, 0)
    Me.TableLayoutPanelAllControls.Controls.Add(Me.MetroLabelLevel, 0, 0)
    Me.TableLayoutPanelAllControls.Controls.Add(Me.MetroGridDevices, 0, 1)
    Me.TableLayoutPanelAllControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAllControls.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAllControls.Margin = New System.Windows.Forms.Padding(2)
    Me.TableLayoutPanelAllControls.Name = "TableLayoutPanelAllControls"
    Me.TableLayoutPanelAllControls.RowCount = 2
    Me.TableLayoutPanelAllControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.TableLayoutPanelAllControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAllControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelAllControls.Size = New System.Drawing.Size(838, 415)
    Me.TableLayoutPanelAllControls.TabIndex = 4
    '
    'NumericUpDownLevel
    '
    Me.NumericUpDownLevel.Location = New System.Drawing.Point(102, 2)
    Me.NumericUpDownLevel.Margin = New System.Windows.Forms.Padding(2)
    Me.NumericUpDownLevel.Name = "NumericUpDownLevel"
    Me.NumericUpDownLevel.Size = New System.Drawing.Size(97, 20)
    Me.NumericUpDownLevel.TabIndex = 1
    '
    'MetroLabelLevel
    '
    Me.MetroLabelLevel.AutoSize = True
    Me.MetroLabelLevel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelLevel.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelLevel.Name = "MetroLabelLevel"
    Me.MetroLabelLevel.Size = New System.Drawing.Size(94, 23)
    Me.MetroLabelLevel.TabIndex = 2
    Me.MetroLabelLevel.Text = "Level"
    '
    'MetroGridDevices
    '
    Me.MetroGridDevices.AllowUserToAddRows = False
    Me.MetroGridDevices.AllowUserToDeleteRows = False
    Me.MetroGridDevices.AllowUserToResizeRows = False
    Me.MetroGridDevices.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridDevices.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridDevices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridDevices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridDevices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeviceID, Me.IsTargeted, Me.IsBanned})
    Me.TableLayoutPanelAllControls.SetColumnSpan(Me.MetroGridDevices, 2)
    Me.MetroGridDevices.ContextMenuStrip = Me.ContextMenuStripDevices
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridDevices.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridDevices.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridDevices.EnableHeadersVisualStyles = False
    Me.MetroGridDevices.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridDevices.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridDevices.Location = New System.Drawing.Point(3, 26)
    Me.MetroGridDevices.Name = "MetroGridDevices"
    Me.MetroGridDevices.ReadOnly = True
    Me.MetroGridDevices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridDevices.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridDevices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridDevices.Size = New System.Drawing.Size(832, 386)
    Me.MetroGridDevices.TabIndex = 3
    '
    'DeviceID
    '
    Me.DeviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DeviceID.HeaderText = "Device external ID"
    Me.DeviceID.Name = "DeviceID"
    Me.DeviceID.ReadOnly = True
    Me.DeviceID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    '
    'IsTargeted
    '
    Me.IsTargeted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.IsTargeted.HeaderText = "Targeted"
    Me.IsTargeted.Name = "IsTargeted"
    Me.IsTargeted.ReadOnly = True
    Me.IsTargeted.Width = 55
    '
    'IsBanned
    '
    Me.IsBanned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.IsBanned.HeaderText = "Banned"
    Me.IsBanned.Name = "IsBanned"
    Me.IsBanned.ReadOnly = True
    Me.IsBanned.Width = 51
    '
    'ContextMenuStripDevices
    '
    Me.ContextMenuStripDevices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDeviceToolStripMenuItem, Me.RemoveDeviceToolStripMenuItem})
    Me.ContextMenuStripDevices.Name = "ContextMenuStripDevices"
    Me.ContextMenuStripDevices.Size = New System.Drawing.Size(164, 70)
    '
    'AddDeviceToolStripMenuItem
    '
    Me.AddDeviceToolStripMenuItem.Name = "AddDeviceToolStripMenuItem"
    Me.AddDeviceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.AddDeviceToolStripMenuItem.Text = "Add device..."
    '
    'RemoveDeviceToolStripMenuItem
    '
    Me.RemoveDeviceToolStripMenuItem.Name = "RemoveDeviceToolStripMenuItem"
    Me.RemoveDeviceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.RemoveDeviceToolStripMenuItem.Text = "Remove device..."
    '
    'UCStreamControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelAllControls)
    Me.Name = "UCStreamControl"
    Me.Size = New System.Drawing.Size(838, 415)
    Me.TableLayoutPanelAllControls.ResumeLayout(False)
    Me.TableLayoutPanelAllControls.PerformLayout()
    CType(Me.NumericUpDownLevel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridDevices, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStripDevices.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelAllControls As TableLayoutPanel
  Friend WithEvents NumericUpDownLevel As NumericUpDown
  Friend WithEvents MetroLabelLevel As MetroFramework.Controls.MetroLabel
  Friend WithEvents MetroGridDevices As MetroFramework.Controls.MetroGrid
  Friend WithEvents DeviceID As DataGridViewTextBoxColumn
  Friend WithEvents IsTargeted As DataGridViewCheckBoxColumn
  Friend WithEvents IsBanned As DataGridViewCheckBoxColumn
  Friend WithEvents ContextMenuStripDevices As ContextMenuStrip
  Friend WithEvents AddDeviceToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents RemoveDeviceToolStripMenuItem As ToolStripMenuItem
End Class
