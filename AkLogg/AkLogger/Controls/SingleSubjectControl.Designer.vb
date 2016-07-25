<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleSubjectControl
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
    Me.TableLayoutStats = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelSubjectName = New System.Windows.Forms.Label()
    Me.SingleStatControlSaves = New AkLogger.SingleStatControl()
    Me.SingleStatControlShots = New AkLogger.SingleStatControl()
    Me.SingleStatControlShotsOn = New AkLogger.SingleStatControl()
    Me.SingleStatControlFouls = New AkLogger.SingleStatControl()
    Me.SingleStatControlYCards = New AkLogger.SingleStatControl()
    Me.SingleStatControlRCards = New AkLogger.SingleStatControl()
    Me.SingleStatControlAssists = New AkLogger.SingleStatControl()
    Me.LabelSubjectNumber = New System.Windows.Forms.Label()
    Me.TableLayoutStats.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutStats.ColumnCount = 10
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutStats.Controls.Add(Me.LabelSubjectNumber, 0, 0)
    Me.TableLayoutStats.Controls.Add(Me.LabelSubjectName, 1, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlSaves, 2, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlShots, 3, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlShotsOn, 4, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlFouls, 6, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlYCards, 7, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlRCards, 8, 0)
    Me.TableLayoutStats.Controls.Add(Me.SingleStatControlAssists, 9, 0)
    Me.TableLayoutStats.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutStats.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutStats.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutStats.Name = "TableLayoutPanel1"
    Me.TableLayoutStats.RowCount = 1
    Me.TableLayoutStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutStats.Size = New System.Drawing.Size(881, 42)
    Me.TableLayoutStats.TabIndex = 0
    '
    'LabelSubjectName
    '
    Me.LabelSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSubjectName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSubjectName.Location = New System.Drawing.Point(43, 0)
    Me.LabelSubjectName.Name = "LabelSubjectName"
    Me.LabelSubjectName.Size = New System.Drawing.Size(244, 42)
    Me.LabelSubjectName.TabIndex = 0
    Me.LabelSubjectName.Text = "Subject name"
    Me.LabelSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'SingleStatControlSaves
    '
    Me.SingleStatControlSaves.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlSaves.Location = New System.Drawing.Point(291, 1)
    Me.SingleStatControlSaves.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlSaves.Name = "SingleStatControlSaves"
    Me.SingleStatControlSaves.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlSaves.Stat = Nothing
    Me.SingleStatControlSaves.StatSubject = Nothing
    Me.SingleStatControlSaves.TabIndex = 1
    '
    'SingleStatControlShots
    '
    Me.SingleStatControlShots.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlShots.Location = New System.Drawing.Point(374, 1)
    Me.SingleStatControlShots.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlShots.Name = "SingleStatControlShots"
    Me.SingleStatControlShots.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlShots.Stat = Nothing
    Me.SingleStatControlShots.StatSubject = Nothing
    Me.SingleStatControlShots.TabIndex = 2
    '
    'SingleStatControlShotsOn
    '
    Me.SingleStatControlShotsOn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlShotsOn.Location = New System.Drawing.Point(457, 1)
    Me.SingleStatControlShotsOn.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlShotsOn.Name = "SingleStatControlShotsOn"
    Me.SingleStatControlShotsOn.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlShotsOn.Stat = Nothing
    Me.SingleStatControlShotsOn.StatSubject = Nothing
    Me.SingleStatControlShotsOn.TabIndex = 3
    '
    'SingleStatControlFouls
    '
    Me.SingleStatControlFouls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlFouls.Location = New System.Drawing.Point(546, 1)
    Me.SingleStatControlFouls.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlFouls.Name = "SingleStatControlFouls"
    Me.SingleStatControlFouls.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlFouls.Stat = Nothing
    Me.SingleStatControlFouls.StatSubject = Nothing
    Me.SingleStatControlFouls.TabIndex = 4
    '
    'SingleStatControlYCards
    '
    Me.SingleStatControlYCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlYCards.Location = New System.Drawing.Point(629, 1)
    Me.SingleStatControlYCards.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlYCards.Name = "SingleStatControlYCards"
    Me.SingleStatControlYCards.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlYCards.Stat = Nothing
    Me.SingleStatControlYCards.StatSubject = Nothing
    Me.SingleStatControlYCards.TabIndex = 5
    '
    'SingleStatControlRCards
    '
    Me.SingleStatControlRCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlRCards.Location = New System.Drawing.Point(712, 1)
    Me.SingleStatControlRCards.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlRCards.Name = "SingleStatControlRCards"
    Me.SingleStatControlRCards.Size = New System.Drawing.Size(81, 40)
    Me.SingleStatControlRCards.Stat = Nothing
    Me.SingleStatControlRCards.StatSubject = Nothing
    Me.SingleStatControlRCards.TabIndex = 6
    '
    'SingleStatControlAssists
    '
    Me.SingleStatControlAssists.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SingleStatControlAssists.Location = New System.Drawing.Point(795, 1)
    Me.SingleStatControlAssists.Margin = New System.Windows.Forms.Padding(1)
    Me.SingleStatControlAssists.Name = "SingleStatControlAssists"
    Me.SingleStatControlAssists.Size = New System.Drawing.Size(85, 40)
    Me.SingleStatControlAssists.Stat = Nothing
    Me.SingleStatControlAssists.StatSubject = Nothing
    Me.SingleStatControlAssists.TabIndex = 7
    '
    'LabelSubjectNumber
    '
    Me.LabelSubjectNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSubjectNumber.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSubjectNumber.Location = New System.Drawing.Point(3, 0)
    Me.LabelSubjectNumber.Name = "LabelSubjectNumber"
    Me.LabelSubjectNumber.Size = New System.Drawing.Size(34, 42)
    Me.LabelSubjectNumber.TabIndex = 8
    Me.LabelSubjectNumber.Text = "Subject name"
    Me.LabelSubjectNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'SingleSubjectControl
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.Controls.Add(Me.TableLayoutStats)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(0)
    Me.Name = "SingleSubjectControl"
    Me.Size = New System.Drawing.Size(881, 42)
    Me.TableLayoutStats.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutStats As TableLayoutPanel
  Friend WithEvents LabelSubjectName As Label
  Friend WithEvents SingleStatControlSaves As SingleStatControl
  Friend WithEvents SingleStatControlShots As SingleStatControl
  Friend WithEvents SingleStatControlShotsOn As SingleStatControl
  Friend WithEvents SingleStatControlFouls As SingleStatControl
  Friend WithEvents SingleStatControlYCards As SingleStatControl
  Friend WithEvents SingleStatControlRCards As SingleStatControl
  Friend WithEvents SingleStatControlAssists As SingleStatControl
  Friend WithEvents LabelSubjectNumber As Label
End Class
