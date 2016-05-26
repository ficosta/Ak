<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPeriod
  Inherits MetroFramework.Controls.MetroUserControl

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
    Me.TableLayoutPanelControls = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonStart = New MetroFramework.Controls.MetroButton()
    Me.MetroButtonEndPeriod = New MetroFramework.Controls.MetroButton()
    Me.MetroTilePeriodName = New MetroFramework.Controls.MetroTile()
    Me.TableLayoutPanelControls.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelControls
    '
    Me.TableLayoutPanelControls.BackColor = System.Drawing.Color.Transparent
    Me.TableLayoutPanelControls.ColumnCount = 1
    Me.TableLayoutPanelControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroButtonEndPeriod, 0, 2)
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroButtonStart, 0, 1)
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroTilePeriodName, 0, 0)
    Me.TableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelControls.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelControls.Name = "TableLayoutPanelControls"
    Me.TableLayoutPanelControls.RowCount = 3
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.Size = New System.Drawing.Size(144, 96)
    Me.TableLayoutPanelControls.TabIndex = 0
    '
    'MetroButtonStart
    '
    Me.MetroButtonStart.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonStart.Location = New System.Drawing.Point(3, 28)
    Me.MetroButtonStart.Name = "MetroButtonStart"
    Me.MetroButtonStart.Size = New System.Drawing.Size(138, 29)
    Me.MetroButtonStart.TabIndex = 0
    Me.MetroButtonStart.Text = "START PERIOD"
    Me.MetroButtonStart.UseSelectable = True
    '
    'MetroButtonEndPeriod
    '
    Me.MetroButtonEndPeriod.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonEndPeriod.Location = New System.Drawing.Point(3, 63)
    Me.MetroButtonEndPeriod.Name = "MetroButtonEndPeriod"
    Me.MetroButtonEndPeriod.Size = New System.Drawing.Size(138, 30)
    Me.MetroButtonEndPeriod.TabIndex = 1
    Me.MetroButtonEndPeriod.Text = "END PERIOD"
    Me.MetroButtonEndPeriod.UseSelectable = True
    '
    'MetroTilePeriodName
    '
    Me.MetroTilePeriodName.ActiveControl = Nothing
    Me.MetroTilePeriodName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTilePeriodName.Location = New System.Drawing.Point(3, 3)
    Me.MetroTilePeriodName.Name = "MetroTilePeriodName"
    Me.MetroTilePeriodName.Size = New System.Drawing.Size(138, 19)
    Me.MetroTilePeriodName.TabIndex = 2
    Me.MetroTilePeriodName.Text = "Period name"
    Me.MetroTilePeriodName.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.MetroTilePeriodName.UseSelectable = True
    '
    'UCPeriod
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelControls)
    Me.Name = "UCPeriod"
    Me.Size = New System.Drawing.Size(144, 96)
    Me.TableLayoutPanelControls.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelControls As TableLayoutPanel
  Friend WithEvents MetroButtonEndPeriod As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroButtonStart As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroTilePeriodName As MetroFramework.Controls.MetroTile
End Class
