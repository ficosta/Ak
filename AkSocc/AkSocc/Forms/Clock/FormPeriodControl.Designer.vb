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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.UcPeriod4 = New AkSocc.UCPeriod()
    Me.TableLayoutPanelOtherOptions = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
    Me.MetroButtonOverwriteClock = New MetroFramework.Controls.MetroButton()
    Me.MetroButtonReloadDataBase = New MetroFramework.Controls.MetroButton()
    Me.UcPeriod3 = New AkSocc.UCPeriod()
    Me.UcPeriod2 = New AkSocc.UCPeriod()
    Me.UcPeriod1 = New AkSocc.UCPeriod()
    Me.msmPeriodControl = New MetroFramework.Components.MetroStyleManager(Me.components)
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanelOtherOptions.SuspendLayout()
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 5
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod4, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelOtherOptions, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod3, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod2, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.UcPeriod1, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 63)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(754, 104)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'UcPeriod4
    '
    Me.UcPeriod4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod4.Location = New System.Drawing.Point(453, 3)
    Me.UcPeriod4.Match = Nothing
    Me.UcPeriod4.Name = "UcPeriod4"
    Me.UcPeriod4.Period = Nothing
    Me.UcPeriod4.Size = New System.Drawing.Size(144, 98)
    Me.UcPeriod4.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod4.TabIndex = 3
    Me.UcPeriod4.UseSelectable = True
    '
    'TableLayoutPanelOtherOptions
    '
    Me.TableLayoutPanelOtherOptions.ColumnCount = 1
    Me.TableLayoutPanelOtherOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButton1, 0, 0)
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButtonOverwriteClock, 0, 1)
    Me.TableLayoutPanelOtherOptions.Controls.Add(Me.MetroButtonReloadDataBase, 0, 2)
    Me.TableLayoutPanelOtherOptions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelOtherOptions.Location = New System.Drawing.Point(603, 3)
    Me.TableLayoutPanelOtherOptions.Name = "TableLayoutPanelOtherOptions"
    Me.TableLayoutPanelOtherOptions.RowCount = 3
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelOtherOptions.Size = New System.Drawing.Size(148, 98)
    Me.TableLayoutPanelOtherOptions.TabIndex = 3
    '
    'MetroButton1
    '
    Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
    Me.MetroButton1.Location = New System.Drawing.Point(3, 3)
    Me.MetroButton1.Name = "MetroButton1"
    Me.MetroButton1.Size = New System.Drawing.Size(142, 26)
    Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Red
    Me.MetroButton1.TabIndex = 0
    Me.MetroButton1.Text = "Reset Match"
    Me.MetroButton1.UseSelectable = True
    '
    'MetroButtonOverwriteClock
    '
    Me.MetroButtonOverwriteClock.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonOverwriteClock.FontSize = MetroFramework.MetroButtonSize.Medium
    Me.MetroButtonOverwriteClock.Location = New System.Drawing.Point(3, 35)
    Me.MetroButtonOverwriteClock.Name = "MetroButtonOverwriteClock"
    Me.MetroButtonOverwriteClock.Size = New System.Drawing.Size(142, 26)
    Me.MetroButtonOverwriteClock.Style = MetroFramework.MetroColorStyle.Red
    Me.MetroButtonOverwriteClock.TabIndex = 1
    Me.MetroButtonOverwriteClock.Text = "Overwrite clock"
    Me.MetroButtonOverwriteClock.UseSelectable = True
    '
    'MetroButtonReloadDataBase
    '
    Me.MetroButtonReloadDataBase.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonReloadDataBase.FontSize = MetroFramework.MetroButtonSize.Medium
    Me.MetroButtonReloadDataBase.Location = New System.Drawing.Point(3, 67)
    Me.MetroButtonReloadDataBase.Name = "MetroButtonReloadDataBase"
    Me.MetroButtonReloadDataBase.Size = New System.Drawing.Size(142, 28)
    Me.MetroButtonReloadDataBase.Style = MetroFramework.MetroColorStyle.Red
    Me.MetroButtonReloadDataBase.TabIndex = 2
    Me.MetroButtonReloadDataBase.Text = "Reload data base"
    Me.MetroButtonReloadDataBase.UseSelectable = True
    '
    'UcPeriod3
    '
    Me.UcPeriod3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod3.Location = New System.Drawing.Point(303, 3)
    Me.UcPeriod3.Match = Nothing
    Me.UcPeriod3.Name = "UcPeriod3"
    Me.UcPeriod3.Period = Nothing
    Me.UcPeriod3.Size = New System.Drawing.Size(144, 98)
    Me.UcPeriod3.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod3.TabIndex = 2
    Me.UcPeriod3.UseSelectable = True
    '
    'UcPeriod2
    '
    Me.UcPeriod2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod2.Location = New System.Drawing.Point(153, 3)
    Me.UcPeriod2.Match = Nothing
    Me.UcPeriod2.Name = "UcPeriod2"
    Me.UcPeriod2.Period = Nothing
    Me.UcPeriod2.Size = New System.Drawing.Size(144, 98)
    Me.UcPeriod2.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod2.TabIndex = 1
    Me.UcPeriod2.UseSelectable = True
    '
    'UcPeriod1
    '
    Me.UcPeriod1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcPeriod1.Location = New System.Drawing.Point(3, 3)
    Me.UcPeriod1.Match = Nothing
    Me.UcPeriod1.Name = "UcPeriod1"
    Me.UcPeriod1.Period = Nothing
    Me.UcPeriod1.Size = New System.Drawing.Size(144, 98)
    Me.UcPeriod1.Style = MetroFramework.MetroColorStyle.White
    Me.UcPeriod1.TabIndex = 0
    Me.UcPeriod1.UseSelectable = True
    '
    'msmPeriodControl
    '
    Me.msmPeriodControl.Owner = Nothing
    '
    'FormPeriodControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 191)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormPeriodControl"
    Me.Resizable = False
    Me.Style = MetroFramework.MetroColorStyle.Orange
    Me.Text = "Match control"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanelOtherOptions.ResumeLayout(False)
    CType(Me.msmPeriodControl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents UcPeriod4 As UCPeriod
  Friend WithEvents UcPeriod3 As UCPeriod
  Friend WithEvents UcPeriod2 As UCPeriod
  Friend WithEvents UcPeriod1 As UCPeriod
  Friend WithEvents msmPeriodControl As MetroFramework.Components.MetroStyleManager
  Friend WithEvents TableLayoutPanelOtherOptions As TableLayoutPanel
  Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroButtonOverwriteClock As MetroFramework.Controls.MetroButton
  Friend WithEvents MetroButtonReloadDataBase As MetroFramework.Controls.MetroButton
End Class
