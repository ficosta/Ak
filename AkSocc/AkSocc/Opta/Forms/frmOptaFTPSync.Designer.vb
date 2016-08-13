<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptaFTPSync
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
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.MultiFileDownloaderAll = New AkSocc.MultiFileDownloader()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 1
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.MultiFileDownloaderAll, 0, 1)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(662, 441)
    Me.TableLayoutPanelAll.TabIndex = 0
    '
    'MultiFileDownloaderAll
    '
    Me.MultiFileDownloaderAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MultiFileDownloaderAll.DownloadEnabled = False
    Me.MultiFileDownloaderAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MultiFileDownloaderAll.HideFinishedDownloads = False
    Me.MultiFileDownloaderAll.LayoutType = AkSocc.MultiFileDownloader.eLayoutType.Both
    Me.MultiFileDownloaderAll.Location = New System.Drawing.Point(3, 38)
    Me.MultiFileDownloaderAll.Name = "MultiFileDownloaderAll"
    Me.MultiFileDownloaderAll.Size = New System.Drawing.Size(656, 400)
    Me.MultiFileDownloaderAll.TabIndex = 1
    '
    'frmOptaFTPSync
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(662, 441)
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Name = "frmOptaFTPSync"
    Me.Text = "OPTA FTP Sync"
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents MultiFileDownloaderAll As MultiFileDownloader
End Class
