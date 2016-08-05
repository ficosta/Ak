<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDownloader
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    Me.LabelState = New System.Windows.Forms.Label()
    Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.LabelState, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 50)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ProgressBar1.Location = New System.Drawing.Point(3, 4)
    Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(44, 42)
    Me.ProgressBar1.TabIndex = 0
    '
    'LabelState
    '
    Me.LabelState.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelState.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelState.Location = New System.Drawing.Point(53, 0)
    Me.LabelState.Name = "LabelState"
    Me.LabelState.Size = New System.Drawing.Size(144, 50)
    Me.LabelState.TabIndex = 1
    Me.LabelState.Text = "State"
    Me.LabelState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MetroProgressBar1
    '
    Me.MetroProgressBar1.BackColor = System.Drawing.Color.DimGray
    Me.MetroProgressBar1.Location = New System.Drawing.Point(0, 0)
    Me.MetroProgressBar1.Name = "MetroProgressBar1"
    Me.MetroProgressBar1.TabIndex = 0
    '
    'FileDownloader
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.DoubleBuffered = True
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "FileDownloader"
    Me.Size = New System.Drawing.Size(200, 50)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents ProgressBar1 As ProgressBar
  Friend WithEvents LabelState As Label
  Private WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
End Class
