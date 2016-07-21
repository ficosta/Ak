<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Me.MetroGridControlObjects = New MetroFramework.Controls.MetroGrid()
    Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.ComboBoxAnimations = New System.Windows.Forms.ComboBox()
    Me.LabelSceneName = New System.Windows.Forms.Label()
    Me.ButtonRW = New System.Windows.Forms.Button()
    Me.ButtonPlay = New System.Windows.Forms.Button()
    Me.ButtonContinue = New System.Windows.Forms.Button()
    CType(Me.MetroGridControlObjects, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'MetroGridControlObjects
    '
    Me.MetroGridControlObjects.AllowUserToAddRows = False
    Me.MetroGridControlObjects.AllowUserToDeleteRows = False
    Me.MetroGridControlObjects.AllowUserToResizeRows = False
    Me.MetroGridControlObjects.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridControlObjects.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridControlObjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridControlObjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridControlObjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridControlObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridControlObjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnName, Me.ColumnType, Me.ColumnValue})
    Me.TableLayoutPanelAll.SetColumnSpan(Me.MetroGridControlObjects, 4)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridControlObjects.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridControlObjects.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridControlObjects.EnableHeadersVisualStyles = False
    Me.MetroGridControlObjects.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridControlObjects.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridControlObjects.Location = New System.Drawing.Point(3, 37)
    Me.MetroGridControlObjects.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MetroGridControlObjects.Name = "MetroGridControlObjects"
    Me.MetroGridControlObjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridControlObjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridControlObjects.RowHeadersVisible = False
    Me.MetroGridControlObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridControlObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridControlObjects.Size = New System.Drawing.Size(813, 441)
    Me.MetroGridControlObjects.TabIndex = 0
    '
    'ColumnName
    '
    Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnName.HeaderText = "Name"
    Me.ColumnName.Name = "ColumnName"
    Me.ColumnName.ReadOnly = True
    Me.ColumnName.Width = 59
    '
    'ColumnType
    '
    Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnType.HeaderText = "Type"
    Me.ColumnType.Name = "ColumnType"
    Me.ColumnType.ReadOnly = True
    Me.ColumnType.Width = 53
    '
    'ColumnValue
    '
    Me.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnValue.HeaderText = "Value"
    Me.ColumnValue.Name = "ColumnValue"
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 4
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
    Me.TableLayoutPanelAll.Controls.Add(Me.MetroGridControlObjects, 0, 1)
    Me.TableLayoutPanelAll.Controls.Add(Me.ComboBoxAnimations, 0, 2)
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelSceneName, 0, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.ButtonRW, 1, 2)
    Me.TableLayoutPanelAll.Controls.Add(Me.ButtonPlay, 2, 2)
    Me.TableLayoutPanelAll.Controls.Add(Me.ButtonContinue, 3, 2)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 3
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(819, 515)
    Me.TableLayoutPanelAll.TabIndex = 1
    '
    'ComboBoxAnimations
    '
    Me.ComboBoxAnimations.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBoxAnimations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxAnimations.FormattingEnabled = True
    Me.ComboBoxAnimations.Location = New System.Drawing.Point(3, 486)
    Me.ComboBoxAnimations.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBoxAnimations.Name = "ComboBoxAnimations"
    Me.ComboBoxAnimations.Size = New System.Drawing.Size(403, 25)
    Me.ComboBoxAnimations.TabIndex = 1
    '
    'LabelSceneName
    '
    Me.LabelSceneName.AutoSize = True
    Me.TableLayoutPanelAll.SetColumnSpan(Me.LabelSceneName, 4)
    Me.LabelSceneName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSceneName.Location = New System.Drawing.Point(3, 0)
    Me.LabelSceneName.Name = "LabelSceneName"
    Me.LabelSceneName.Size = New System.Drawing.Size(813, 33)
    Me.LabelSceneName.TabIndex = 2
    Me.LabelSceneName.Text = "LabelSceneName"
    Me.LabelSceneName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ButtonRW
    '
    Me.ButtonRW.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonRW.Location = New System.Drawing.Point(412, 485)
    Me.ButtonRW.Name = "ButtonRW"
    Me.ButtonRW.Size = New System.Drawing.Size(130, 27)
    Me.ButtonRW.TabIndex = 3
    Me.ButtonRW.Text = "RW"
    Me.ButtonRW.UseVisualStyleBackColor = True
    '
    'ButtonPlay
    '
    Me.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonPlay.Location = New System.Drawing.Point(548, 485)
    Me.ButtonPlay.Name = "ButtonPlay"
    Me.ButtonPlay.Size = New System.Drawing.Size(130, 27)
    Me.ButtonPlay.TabIndex = 4
    Me.ButtonPlay.Text = "Play"
    Me.ButtonPlay.UseVisualStyleBackColor = True
    '
    'ButtonContinue
    '
    Me.ButtonContinue.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonContinue.Location = New System.Drawing.Point(684, 485)
    Me.ButtonContinue.Name = "ButtonContinue"
    Me.ButtonContinue.Size = New System.Drawing.Size(132, 27)
    Me.ButtonContinue.TabIndex = 5
    Me.ButtonContinue.Text = "Continue"
    Me.ButtonContinue.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(819, 515)
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmMain"
    Me.Text = "Form1"
    CType(Me.MetroGridControlObjects, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents MetroGridControlObjects As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnValue As DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents ComboBoxAnimations As ComboBox
  Friend WithEvents LabelSceneName As Label
  Friend WithEvents ButtonRW As Button
  Friend WithEvents ButtonPlay As Button
  Friend WithEvents ButtonContinue As Button
End Class
