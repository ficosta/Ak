<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassification
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
    Me.ComboBoxMatchDays = New System.Windows.Forms.ComboBox()
    Me.MetroGridClassification = New MetroFramework.Controls.MetroGrid()
    Me.ColumnPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPlayed = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnWon = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDraw = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnLost = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnGoalsScored = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnGoalsReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnGoalAverage = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnPoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.MetroGridClassification, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxMatchDays, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.MetroGridClassification, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(935, 308)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'ComboBoxMatchDays
    '
    Me.ComboBoxMatchDays.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBoxMatchDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxMatchDays.FormattingEnabled = True
    Me.ComboBoxMatchDays.Location = New System.Drawing.Point(3, 3)
    Me.ComboBoxMatchDays.Name = "ComboBoxMatchDays"
    Me.ComboBoxMatchDays.Size = New System.Drawing.Size(929, 21)
    Me.ComboBoxMatchDays.TabIndex = 0
    '
    'MetroGridClassification
    '
    Me.MetroGridClassification.AllowUserToAddRows = False
    Me.MetroGridClassification.AllowUserToDeleteRows = False
    Me.MetroGridClassification.AllowUserToResizeRows = False
    Me.MetroGridClassification.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridClassification.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridClassification.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridClassification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridClassification.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridClassification.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPosition, Me.ColumnName, Me.ColumnPlayed, Me.ColumnWon, Me.ColumnDraw, Me.ColumnLost, Me.ColumnGoalsScored, Me.ColumnGoalsReceived, Me.ColumnGoalAverage, Me.ColumnPoints})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridClassification.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridClassification.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridClassification.EnableHeadersVisualStyles = False
    Me.MetroGridClassification.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridClassification.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridClassification.Location = New System.Drawing.Point(3, 33)
    Me.MetroGridClassification.Name = "MetroGridClassification"
    Me.MetroGridClassification.ReadOnly = True
    Me.MetroGridClassification.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridClassification.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridClassification.RowHeadersVisible = False
    Me.MetroGridClassification.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridClassification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridClassification.Size = New System.Drawing.Size(929, 272)
    Me.MetroGridClassification.TabIndex = 1
    '
    'ColumnPosition
    '
    Me.ColumnPosition.HeaderText = "#"
    Me.ColumnPosition.Name = "ColumnPosition"
    Me.ColumnPosition.ReadOnly = True
    Me.ColumnPosition.Width = 40
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnName.HeaderText = "Team"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    '
    'ColumnPlayed
    '
    Me.ColumnPlayed.HeaderText = "Played"
    Me.ColumnPlayed.Name = "ColumnPlayed"
    Me.ColumnPlayed.ReadOnly = True
    Me.ColumnPlayed.Width = 40
    '
    'ColumnWon
    '
    Me.ColumnWon.HeaderText = "Won"
    Me.ColumnWon.Name = "ColumnWon"
    Me.ColumnWon.ReadOnly = True
    Me.ColumnWon.Width = 40
    '
    'ColumnDraw
    '
    Me.ColumnDraw.HeaderText = "Draw"
    Me.ColumnDraw.Name = "ColumnDraw"
    Me.ColumnDraw.ReadOnly = True
    Me.ColumnDraw.Width = 40
    '
    'ColumnLost
    '
    Me.ColumnLost.HeaderText = "Lost"
    Me.ColumnLost.Name = "ColumnLost"
    Me.ColumnLost.ReadOnly = True
    Me.ColumnLost.Width = 40
    '
    'ColumnGoalsScored
    '
    Me.ColumnGoalsScored.HeaderText = "Goals"
    Me.ColumnGoalsScored.Name = "ColumnGoalsScored"
    Me.ColumnGoalsScored.ReadOnly = True
    Me.ColumnGoalsScored.Width = 40
    '
    'ColumnGoalsReceived
    '
    Me.ColumnGoalsReceived.HeaderText = "Goals"
    Me.ColumnGoalsReceived.Name = "ColumnGoalsReceived"
    Me.ColumnGoalsReceived.ReadOnly = True
    Me.ColumnGoalsReceived.Width = 40
    '
    'ColumnGoalAverage
    '
    Me.ColumnGoalAverage.HeaderText = "Avg."
    Me.ColumnGoalAverage.Name = "ColumnGoalAverage"
    Me.ColumnGoalAverage.ReadOnly = True
    Me.ColumnGoalAverage.Width = 40
    '
    'ColumnPoints
    '
    Me.ColumnPoints.HeaderText = "Points"
    Me.ColumnPoints.Name = "ColumnPoints"
    Me.ColumnPoints.ReadOnly = True
    Me.ColumnPoints.Width = 40
    '
    'FormClassification
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(935, 308)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "FormClassification"
    Me.Text = "FormClassification"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.MetroGridClassification, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents ComboBoxMatchDays As ComboBox
  Friend WithEvents MetroGridClassification As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnPosition As DataGridViewTextBoxColumn
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPlayed As DataGridViewTextBoxColumn
  Friend WithEvents ColumnWon As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDraw As DataGridViewTextBoxColumn
  Friend WithEvents ColumnLost As DataGridViewTextBoxColumn
  Friend WithEvents ColumnGoalsScored As DataGridViewTextBoxColumn
  Friend WithEvents ColumnGoalsReceived As DataGridViewTextBoxColumn
  Friend WithEvents ColumnGoalAverage As DataGridViewTextBoxColumn
  Friend WithEvents ColumnPoints As DataGridViewTextBoxColumn
End Class
