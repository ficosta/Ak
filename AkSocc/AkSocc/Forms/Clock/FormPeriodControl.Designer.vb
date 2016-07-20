<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeriodControl
  Inherits MetroFramework.Forms.MetroForm

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
    Me.msmPeriodControl = New MetroFramework.Components.MetroStyleManager(Me.components)
    Me.MetroGridPeriods = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnText = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelOverTime = New MetroFramework.Controls.MetroLabel()
    Me.NumericUpDownMinutes = New System.Windows.Forms.NumericUpDown()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MetroGridPeriods, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'msmPeriodControl
    '
    Me.msmPeriodControl.Owner = Nothing
    '
    'MetroGridPeriods
    '
    Me.MetroGridPeriods.AllowUserToAddRows = False
    Me.MetroGridPeriods.AllowUserToDeleteRows = False
    Me.MetroGridPeriods.AllowUserToResizeColumns = False
    Me.MetroGridPeriods.AllowUserToResizeRows = False
    Me.MetroGridPeriods.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPeriods.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridPeriods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridPeriods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPeriods.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridPeriods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnType, Me.ColumnText})
    Me.TableLayoutPanel2.SetColumnSpan(Me.MetroGridPeriods, 2)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridPeriods.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridPeriods.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridPeriods.EnableHeadersVisualStyles = False
    Me.MetroGridPeriods.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridPeriods.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridPeriods.Location = New System.Drawing.Point(3, 3)
    Me.MetroGridPeriods.MultiSelect = False
    Me.MetroGridPeriods.Name = "MetroGridPeriods"
    Me.MetroGridPeriods.ReadOnly = True
    Me.MetroGridPeriods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridPeriods.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridPeriods.RowHeadersVisible = False
    Me.MetroGridPeriods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridPeriods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridPeriods.Size = New System.Drawing.Size(350, 371)
    Me.MetroGridPeriods.TabIndex = 3
    '
    'ColumnID
    '
    Me.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnID.HeaderText = "ID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    Me.ColumnID.Visible = False
    '
    'ColumnType
    '
    Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnType.HeaderText = "Type"
    Me.ColumnType.Name = "ColumnType"
    Me.ColumnType.ReadOnly = True
    Me.ColumnType.Visible = False
    '
    'ColumnText
    '
    Me.ColumnText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnText.HeaderText = "Clock control actions"
    Me.ColumnText.Name = "ColumnText"
    Me.ColumnText.ReadOnly = True
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.LabelOverTime, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroGridPeriods, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDownMinutes, 1, 1)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 63)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 2
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(356, 412)
    Me.TableLayoutPanel2.TabIndex = 4
    '
    'LabelOverTime
    '
    Me.LabelOverTime.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelOverTime.FontSize = MetroFramework.MetroLabelSize.Small
    Me.LabelOverTime.Location = New System.Drawing.Point(3, 377)
    Me.LabelOverTime.Name = "LabelOverTime"
    Me.LabelOverTime.Size = New System.Drawing.Size(172, 35)
    Me.LabelOverTime.TabIndex = 5
    Me.LabelOverTime.Text = "Over time"
    Me.LabelOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'NumericUpDownMinutes
    '
    Me.NumericUpDownMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownMinutes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownMinutes.Location = New System.Drawing.Point(181, 380)
    Me.NumericUpDownMinutes.Name = "NumericUpDownMinutes"
    Me.NumericUpDownMinutes.Size = New System.Drawing.Size(172, 25)
    Me.NumericUpDownMinutes.TabIndex = 6
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(219, 481)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(160, 29)
    Me.TableLayoutPanel1.TabIndex = 5
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(74, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.UseSelectable = True
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(83, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
    '
    'FormPeriodControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(402, 551)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormPeriodControl"
    Me.Resizable = False
    Me.Style = MetroFramework.MetroColorStyle.Orange
    Me.Text = "Match control"
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MetroGridPeriods, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents msmPeriodControl As MetroFramework.Components.MetroStyleManager
  Friend WithEvents MetroGridPeriods As MetroFramework.Controls.MetroGrid
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents LabelOverTime As MetroFramework.Controls.MetroLabel
  Friend WithEvents NumericUpDownMinutes As NumericUpDown
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnText As DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
End Class
