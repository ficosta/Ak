<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownloader
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
    Me.Button1 = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.MultiFileDownloader1 = New Opta_get_data.MultiFileDownloader()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(3, 3)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(144, 29)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.MultiFileDownloader1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(835, 499)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'MultiFileDownloader1
    '
    Me.TableLayoutPanel1.SetColumnSpan(Me.MultiFileDownloader1, 2)
    Me.MultiFileDownloader1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MultiFileDownloader1.DownloadEnabled = False
    Me.MultiFileDownloader1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MultiFileDownloader1.HideFinishedDownloads = False
    Me.MultiFileDownloader1.LayoutType = Opta_get_data.MultiFileDownloader.eLayoutType.Both
    Me.MultiFileDownloader1.Location = New System.Drawing.Point(3, 38)
    Me.MultiFileDownloader1.Name = "MultiFileDownloader1"
    Me.MultiFileDownloader1.Size = New System.Drawing.Size(829, 458)
    Me.MultiFileDownloader1.TabIndex = 3
    '
    'frmDownloader
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(835, 499)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.DoubleBuffered = True
    Me.Name = "frmDownloader"
    Me.Text = "frmDownloader"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Button1 As Button
  Friend WithEvents MultiFileDownloader1 As MultiFileDownloader
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
