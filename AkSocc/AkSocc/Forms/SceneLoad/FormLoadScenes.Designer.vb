<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoadScenes
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
    Me.MetroCheckBoxCloseWhenDone = New MetroFramework.Controls.MetroCheckBox()
    Me.MetroGridScenes = New MetroFramework.Controls.MetroGrid()
    Me.ColumnScenesName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnSceneState = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.MetroGridScenes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MetroCheckBoxCloseWhenDone
    '
    Me.MetroCheckBoxCloseWhenDone.AutoSize = True
    Me.MetroCheckBoxCloseWhenDone.Checked = True
    Me.MetroCheckBoxCloseWhenDone.CheckState = System.Windows.Forms.CheckState.Checked
    Me.MetroCheckBoxCloseWhenDone.Location = New System.Drawing.Point(23, 417)
    Me.MetroCheckBoxCloseWhenDone.Name = "MetroCheckBoxCloseWhenDone"
    Me.MetroCheckBoxCloseWhenDone.Size = New System.Drawing.Size(114, 15)
    Me.MetroCheckBoxCloseWhenDone.TabIndex = 1
    Me.MetroCheckBoxCloseWhenDone.Text = "Close when done"
    Me.MetroCheckBoxCloseWhenDone.UseSelectable = True
    '
    'MetroGridScenes
    '
    Me.MetroGridScenes.AllowUserToAddRows = False
    Me.MetroGridScenes.AllowUserToDeleteRows = False
    Me.MetroGridScenes.AllowUserToResizeRows = False
    Me.MetroGridScenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MetroGridScenes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridScenes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridScenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridScenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridScenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridScenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridScenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnScenesName, Me.ColumnSceneState})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridScenes.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridScenes.EnableHeadersVisualStyles = False
    Me.MetroGridScenes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridScenes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridScenes.Location = New System.Drawing.Point(23, 12)
    Me.MetroGridScenes.Name = "MetroGridScenes"
    Me.MetroGridScenes.ReadOnly = True
    Me.MetroGridScenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridScenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridScenes.RowHeadersVisible = False
    Me.MetroGridScenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridScenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridScenes.Size = New System.Drawing.Size(586, 402)
    Me.MetroGridScenes.TabIndex = 2
    '
    'ColumnScenesName
    '
    Me.ColumnScenesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ColumnScenesName.HeaderText = "Scene"
    Me.ColumnScenesName.Name = "ColumnScenesName"
    Me.ColumnScenesName.ReadOnly = True
    Me.ColumnScenesName.Width = 60
    '
    'ColumnSceneState
    '
    Me.ColumnSceneState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnSceneState.HeaderText = "State"
    Me.ColumnSceneState.Name = "ColumnSceneState"
    Me.ColumnSceneState.ReadOnly = True
    '
    'FormLoadScenes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(621, 455)
    Me.Controls.Add(Me.MetroGridScenes)
    Me.Controls.Add(Me.MetroCheckBoxCloseWhenDone)
    Me.Name = "FormLoadScenes"
    Me.ShowIcon = False
    Me.Text = "Load scenes"
    CType(Me.MetroGridScenes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MetroCheckBoxCloseWhenDone As MetroFramework.Controls.MetroCheckBox
  Friend WithEvents MetroGridScenes As MetroFramework.Controls.MetroGrid
  Friend WithEvents ColumnScenesName As DataGridViewTextBoxColumn
  Friend WithEvents ColumnSceneState As DataGridViewTextBoxColumn
End Class
