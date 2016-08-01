<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubstitutionPreSelection
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanelAdvancedControls = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonAdvancedOK = New System.Windows.Forms.Button()
    Me.ButtonAdvancedCancel = New System.Windows.Forms.Button()
    Me.MetroGridOptions = New MetroFramework.Controls.MetroGrid()
    Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnOption = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelAdvancedControls.SuspendLayout()
    CType(Me.MetroGridOptions, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelAdvancedControls, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroGridOptions, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(486, 201)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'TableLayoutPanelAdvancedControls
    '
    Me.TableLayoutPanelAdvancedControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanelAdvancedControls.ColumnCount = 2
    Me.TableLayoutPanelAdvancedControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.Controls.Add(Me.ButtonAdvancedOK, 0, 0)
    Me.TableLayoutPanelAdvancedControls.Controls.Add(Me.ButtonAdvancedCancel, 1, 0)
    Me.TableLayoutPanelAdvancedControls.Location = New System.Drawing.Point(313, 159)
    Me.TableLayoutPanelAdvancedControls.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelAdvancedControls.Name = "TableLayoutPanelAdvancedControls"
    Me.TableLayoutPanelAdvancedControls.RowCount = 1
    Me.TableLayoutPanelAdvancedControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelAdvancedControls.Size = New System.Drawing.Size(170, 38)
    Me.TableLayoutPanelAdvancedControls.TabIndex = 2
    '
    'ButtonAdvancedOK
    '
    Me.ButtonAdvancedOK.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonAdvancedOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonAdvancedOK.Location = New System.Drawing.Point(3, 4)
    Me.ButtonAdvancedOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonAdvancedOK.Name = "ButtonAdvancedOK"
    Me.ButtonAdvancedOK.Size = New System.Drawing.Size(79, 30)
    Me.ButtonAdvancedOK.TabIndex = 0
    Me.ButtonAdvancedOK.Text = "OK"
    '
    'ButtonAdvancedCancel
    '
    Me.ButtonAdvancedCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.ButtonAdvancedCancel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonAdvancedCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ButtonAdvancedCancel.Location = New System.Drawing.Point(88, 4)
    Me.ButtonAdvancedCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ButtonAdvancedCancel.Name = "ButtonAdvancedCancel"
    Me.ButtonAdvancedCancel.Size = New System.Drawing.Size(79, 30)
    Me.ButtonAdvancedCancel.TabIndex = 1
    Me.ButtonAdvancedCancel.Text = "Cancel"
    '
    'MetroGridOptions
    '
    Me.MetroGridOptions.AllowUserToAddRows = False
    Me.MetroGridOptions.AllowUserToDeleteRows = False
    Me.MetroGridOptions.AllowUserToResizeRows = False
    Me.MetroGridOptions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOptions.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridOptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridOptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridOptions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnType, Me.ColumnOption})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridOptions.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridOptions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridOptions.EnableHeadersVisualStyles = False
    Me.MetroGridOptions.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridOptions.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOptions.Location = New System.Drawing.Point(3, 4)
    Me.MetroGridOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroGridOptions.MultiSelect = False
    Me.MetroGridOptions.Name = "MetroGridOptions"
    Me.MetroGridOptions.ReadOnly = True
    Me.MetroGridOptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOptions.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridOptions.RowHeadersVisible = False
    Me.MetroGridOptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridOptions.Size = New System.Drawing.Size(480, 147)
    Me.MetroGridOptions.TabIndex = 3
    '
    'ColumnType
    '
    Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnType.HeaderText = "Type"
    Me.ColumnType.Name = "ColumnType"
    Me.ColumnType.ReadOnly = True
    Me.ColumnType.Width = 53
    '
    'ColumnOption
    '
    Me.ColumnOption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnOption.HeaderText = "Option"
    Me.ColumnOption.Name = "ColumnOption"
    Me.ColumnOption.ReadOnly = True
    '
    'FormSubstitutionPreSelection
    '
    Me.AcceptButton = Me.ButtonAdvancedOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.CancelButton = Me.ButtonAdvancedCancel
    Me.ClientSize = New System.Drawing.Size(486, 201)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormSubstitutionPreSelection"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Substitutions"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelAdvancedControls.ResumeLayout(False)
    CType(Me.MetroGridOptions, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents TableLayoutPanelAdvancedControls As TableLayoutPanel
  Friend WithEvents ButtonAdvancedOK As Button
  Friend WithEvents ButtonAdvancedCancel As Button
  Friend WithEvents MetroGridOptions As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnOption As DataGridViewTextBoxColumn
End Class
