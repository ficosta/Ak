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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.MetroGridField = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroGridBench = New MetroFramework.Controls.MetroGrid()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.MetroGridField, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridBench, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroGridField, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroGridBench, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 63)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 378)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(550, 351)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 24)
    Me.TableLayoutPanel2.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 18)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.UseSelectable = True
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 18)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
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
    Me.MetroGridField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnName, Me.ColumnNumber, Me.ColumnPosition})
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
    Me.MetroGridField.Size = New System.Drawing.Size(343, 342)
    Me.MetroGridField.TabIndex = 0
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.Visible = False
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnName.HeaderText = "Name"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    '
    'ColumnNumber
    '
    Me.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnNumber.HeaderText = "#"
    Me.ColumnNumber.Name = "ColumnNumber"
    Me.ColumnNumber.ReadOnly = True
    Me.ColumnNumber.Width = 37
    '
    'ColumnPosition
    '
    Me.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnPosition.HeaderText = "Pos"
    Me.ColumnPosition.Name = "ColumnPosition"
    Me.ColumnPosition.Width = 48
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
    Me.MetroGridBench.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
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
    Me.MetroGridBench.Location = New System.Drawing.Point(352, 3)
    Me.MetroGridBench.Name = "MetroGridBench"
    Me.MetroGridBench.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridBench.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.MetroGridBench.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridBench.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridBench.Size = New System.Drawing.Size(344, 342)
    Me.MetroGridBench.TabIndex = 1
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.HeaderText = "#"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Width = 37
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.HeaderText = "Pos"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.Width = 48
    '
    'FormSubstitution
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(745, 464)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "FormSubstitution"
    Me.Text = "Substitution"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.MetroGridField, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridBench, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroGridField As MetroFramework.Controls.MetroGrid
  Friend WithEvents MetroGridBench As MetroFramework.Controls.MetroGrid
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnNumber As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPosition As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
