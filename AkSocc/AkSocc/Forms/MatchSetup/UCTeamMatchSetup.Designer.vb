<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTeamMatchSetup
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
    Me.UserControlTactica1 = New AkSocc.UserControlTactica()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.UserControlTactica1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(991, 489)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'UserControlTactica1
    '
    Me.UserControlTactica1.AllowDrop = True
    Me.UserControlTactica1.Color = System.Drawing.Color.Turquoise
    Me.UserControlTactica1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UserControlTactica1.IsLocalTeam = True
    Me.UserControlTactica1.Location = New System.Drawing.Point(3, 3)
    Me.UserControlTactica1.Name = "UserControlTactica1"
    Me.UserControlTactica1.SelectedPosicio = Nothing
    Me.UserControlTactica1.Size = New System.Drawing.Size(694, 483)
    Me.UserControlTactica1.TabIndex = 0
    Me.UserControlTactica1.Tactic = Nothing
    Me.UserControlTactica1.Team = Nothing
    '
    'UCTeamMatchSetup
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "UCTeamMatchSetup"
    Me.Size = New System.Drawing.Size(991, 489)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents UserControlTactica1 As UserControlTactica
End Class
