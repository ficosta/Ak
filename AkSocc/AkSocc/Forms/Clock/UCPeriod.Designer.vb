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
    Me.NumericUpDownMinutes = New System.Windows.Forms.NumericUpDown()
    Me.LabelExtraHome = New MetroFramework.Controls.MetroLabel()
    Me.MetroButtonEndPeriod = New MetroFramework.Controls.MetroButton()
    Me.MetroButtonStart = New MetroFramework.Controls.MetroButton()
    Me.MetroTilePeriodName = New MetroFramework.Controls.MetroTile()
    Me.TableLayoutPanelControls.SuspendLayout()
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelControls
    '
    Me.TableLayoutPanelControls.BackColor = System.Drawing.Color.Transparent
    Me.TableLayoutPanelControls.ColumnCount = 2
    Me.TableLayoutPanelControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.Controls.Add(Me.NumericUpDownMinutes, 1, 3)
    Me.TableLayoutPanelControls.Controls.Add(Me.LabelExtraHome, 0, 3)
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroButtonEndPeriod, 0, 2)
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroButtonStart, 0, 1)
    Me.TableLayoutPanelControls.Controls.Add(Me.MetroTilePeriodName, 0, 0)
    Me.TableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelControls.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelControls.Name = "TableLayoutPanelControls"
    Me.TableLayoutPanelControls.RowCount = 4
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelControls.Size = New System.Drawing.Size(144, 126)
    Me.TableLayoutPanelControls.TabIndex = 0
    '
    'NumericUpDownMinutes
    '
    Me.NumericUpDownMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.NumericUpDownMinutes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownMinutes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumericUpDownMinutes.Location = New System.Drawing.Point(75, 98)
    Me.NumericUpDownMinutes.Name = "NumericUpDownMinutes"
    Me.NumericUpDownMinutes.Size = New System.Drawing.Size(66, 25)
    Me.NumericUpDownMinutes.TabIndex = 4
    '
    'LabelExtraHome
    '
    Me.LabelExtraHome.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelExtraHome.FontSize = MetroFramework.MetroLabelSize.Small
    Me.LabelExtraHome.Location = New System.Drawing.Point(3, 95)
    Me.LabelExtraHome.Name = "LabelExtraHome"
    Me.LabelExtraHome.Size = New System.Drawing.Size(66, 31)
    Me.LabelExtraHome.TabIndex = 3
    Me.LabelExtraHome.Text = "Extra time"
    Me.LabelExtraHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'MetroButtonEndPeriod
    '
    Me.TableLayoutPanelControls.SetColumnSpan(Me.MetroButtonEndPeriod, 2)
    Me.MetroButtonEndPeriod.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonEndPeriod.Location = New System.Drawing.Point(3, 63)
    Me.MetroButtonEndPeriod.Name = "MetroButtonEndPeriod"
    Me.MetroButtonEndPeriod.Size = New System.Drawing.Size(138, 29)
    Me.MetroButtonEndPeriod.TabIndex = 1
    Me.MetroButtonEndPeriod.Text = "END PERIOD"
    Me.MetroButtonEndPeriod.UseSelectable = True
    '
    'MetroButtonStart
    '
    Me.TableLayoutPanelControls.SetColumnSpan(Me.MetroButtonStart, 2)
    Me.MetroButtonStart.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonStart.Location = New System.Drawing.Point(3, 28)
    Me.MetroButtonStart.Name = "MetroButtonStart"
    Me.MetroButtonStart.Size = New System.Drawing.Size(138, 29)
    Me.MetroButtonStart.TabIndex = 0
    Me.MetroButtonStart.Text = "START PERIOD"
    Me.MetroButtonStart.UseSelectable = True
    '
    'MetroTilePeriodName
    '
    Me.MetroTilePeriodName.ActiveControl = Nothing
    Me.TableLayoutPanelControls.SetColumnSpan(Me.MetroTilePeriodName, 2)
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
    Me.Size = New System.Drawing.Size(144, 126)
    Me.TableLayoutPanelControls.ResumeLayout(False)
    CType(Me.NumericUpDownMinutes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelControls As TableLayoutPanel
  Friend WithEvents MetroButtonEndPeriod As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroButtonStart As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroTilePeriodName As MetroFramework.Controls.MetroTile
  Friend WithEvents LabelExtraHome As MetroFramework.Controls.MetroLabel
  Friend WithEvents NumericUpDownMinutes As NumericUpDown
End Class
