<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherMatches
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New MetroFramework.Controls.MetroButton()
    Me.Cancel_Button = New MetroFramework.Controls.MetroButton()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.MetroGridOtherMatches = New MetroFramework.Controls.MetroGrid()
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.MetroGridOtherMatches, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 504)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1002, 29)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(848, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    Me.OK_Button.UseSelectable = True
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(928, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    Me.Cancel_Button.UseSelectable = True
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Location = New System.Drawing.Point(23, 63)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.MetroGridOtherMatches)
    Me.SplitContainer1.Size = New System.Drawing.Size(1002, 435)
    Me.SplitContainer1.SplitterDistance = 252
    Me.SplitContainer1.TabIndex = 2
    '
    'MetroGridOtherMatches
    '
    Me.MetroGridOtherMatches.AllowUserToAddRows = False
    Me.MetroGridOtherMatches.AllowUserToDeleteRows = False
    Me.MetroGridOtherMatches.AllowUserToResizeColumns = False
    Me.MetroGridOtherMatches.AllowUserToResizeRows = False
    Me.MetroGridOtherMatches.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOtherMatches.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridOtherMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridOtherMatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOtherMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridOtherMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridOtherMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColumnDescription})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridOtherMatches.DefaultCellStyle = DataGridViewCellStyle2
    Me.MetroGridOtherMatches.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridOtherMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.MetroGridOtherMatches.EnableHeadersVisualStyles = False
    Me.MetroGridOtherMatches.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridOtherMatches.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridOtherMatches.Location = New System.Drawing.Point(0, 0)
    Me.MetroGridOtherMatches.MultiSelect = False
    Me.MetroGridOtherMatches.Name = "MetroGridOtherMatches"
    Me.MetroGridOtherMatches.ReadOnly = True
    Me.MetroGridOtherMatches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridOtherMatches.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridOtherMatches.RowHeadersWidth = 10
    Me.MetroGridOtherMatches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridOtherMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridOtherMatches.ShowCellErrors = False
    Me.MetroGridOtherMatches.ShowCellToolTips = False
    Me.MetroGridOtherMatches.ShowEditingIcon = False
    Me.MetroGridOtherMatches.ShowRowErrors = False
    Me.MetroGridOtherMatches.Size = New System.Drawing.Size(252, 435)
    Me.MetroGridOtherMatches.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroGridOtherMatches.TabIndex = 48
    '
    'Column1
    '
    Me.Column1.HeaderText = "ColumnID"
    Me.Column1.Name = "Column1"
    Me.Column1.ReadOnly = True
    Me.Column1.Visible = False
    Me.Column1.Width = 60
    '
    'ColumnDescription
    '
    Me.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnDescription.HeaderText = "Description"
    Me.ColumnDescription.Name = "ColumnDescription"
    Me.ColumnDescription.ReadOnly = True
    '
    'frmOtherMatches
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1048, 556)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmOtherMatches"
    Me.Text = "Other matches"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.MetroGridOtherMatches, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents OK_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents Cancel_Button As MetroFramework.Controls.MetroButton
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents MetroGridOtherMatches As MetroFramework.Controls.MetroGrid
  Friend WithEvents Column1 As DataGridViewTextBoxColumn
  Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
End Class
