<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlTactica
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.TableLayoutPanelTot = New System.Windows.Forms.TableLayoutPanel()
    Me.PanelCanvas = New System.Windows.Forms.Panel()
    Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
    Me.ContextMenuStripPlayers = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.LabelSelectedPlayer = New System.Windows.Forms.Label()
    Me.ListViewTeam = New System.Windows.Forms.ListView()
    Me.ColumnHeaderDorsal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeaderNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ToolTipDrag = New System.Windows.Forms.ToolTip(Me.components)
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.PictureBox3 = New System.Windows.Forms.PictureBox()
    Me.PictureBox4 = New System.Windows.Forms.PictureBox()
    Me.PictureBox5 = New System.Windows.Forms.PictureBox()
    Me.PictureBox6 = New System.Windows.Forms.PictureBox()
    Me.PictureBox7 = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanelTot.SuspendLayout()
    Me.PanelCanvas.SuspendLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelTot
    '
    Me.TableLayoutPanelTot.ColumnCount = 2
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
    Me.TableLayoutPanelTot.Controls.Add(Me.PanelCanvas, 1, 0)
    Me.TableLayoutPanelTot.Controls.Add(Me.LabelSelectedPlayer, 1, 2)
    Me.TableLayoutPanelTot.Controls.Add(Me.ListViewTeam, 0, 0)
    Me.TableLayoutPanelTot.Controls.Add(Me.TableLayoutPanel1, 1, 1)
    Me.TableLayoutPanelTot.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelTot.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelTot.Name = "TableLayoutPanelTot"
    Me.TableLayoutPanelTot.RowCount = 3
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelTot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelTot.Size = New System.Drawing.Size(696, 423)
    Me.TableLayoutPanelTot.TabIndex = 1
    '
    'PanelCanvas
    '
    Me.PanelCanvas.Controls.Add(Me.PictureBoxCanvas)
    Me.PanelCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelCanvas.Location = New System.Drawing.Point(219, 3)
    Me.PanelCanvas.Name = "PanelCanvas"
    Me.PanelCanvas.Size = New System.Drawing.Size(474, 337)
    Me.PanelCanvas.TabIndex = 1
    '
    'PictureBoxCanvas
    '
    Me.PictureBoxCanvas.ContextMenuStrip = Me.ContextMenuStripPlayers
    Me.PictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxCanvas.Location = New System.Drawing.Point(0, 0)
    Me.PictureBoxCanvas.Name = "PictureBoxCanvas"
    Me.PictureBoxCanvas.Size = New System.Drawing.Size(474, 337)
    Me.PictureBoxCanvas.TabIndex = 1
    Me.PictureBoxCanvas.TabStop = False
    Me.ToolTipDrag.SetToolTip(Me.PictureBoxCanvas, "feels like it should")
    '
    'ContextMenuStripPlayers
    '
    Me.ContextMenuStripPlayers.Name = "ContextMenuStripPlayers"
    Me.ContextMenuStripPlayers.Size = New System.Drawing.Size(61, 4)
    '
    'LabelSelectedPlayer
    '
    Me.LabelSelectedPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSelectedPlayer.Location = New System.Drawing.Point(219, 393)
    Me.LabelSelectedPlayer.Name = "LabelSelectedPlayer"
    Me.LabelSelectedPlayer.Size = New System.Drawing.Size(474, 30)
    Me.LabelSelectedPlayer.TabIndex = 2
    Me.LabelSelectedPlayer.Text = "Selected player..."
    Me.LabelSelectedPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ListViewTeam
    '
    Me.ListViewTeam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListViewTeam.AutoArrange = False
    Me.ListViewTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListViewTeam.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDorsal, Me.ColumnHeaderNom})
    Me.ListViewTeam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListViewTeam.FullRowSelect = True
    Me.ListViewTeam.GridLines = True
    Me.ListViewTeam.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.ListViewTeam.HideSelection = False
    Me.ListViewTeam.Location = New System.Drawing.Point(3, 3)
    Me.ListViewTeam.Name = "ListViewTeam"
    Me.TableLayoutPanelTot.SetRowSpan(Me.ListViewTeam, 2)
    Me.ListViewTeam.Size = New System.Drawing.Size(210, 387)
    Me.ListViewTeam.TabIndex = 26
    Me.ListViewTeam.UseCompatibleStateImageBehavior = False
    Me.ListViewTeam.View = System.Windows.Forms.View.Details
    '
    'ColumnHeaderDorsal
    '
    Me.ColumnHeaderDorsal.Text = "#"
    Me.ColumnHeaderDorsal.Width = 35
    '
    'ColumnHeaderNom
    '
    Me.ColumnHeaderNom.Text = "Nom"
    Me.ColumnHeaderNom.Width = 150
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 9
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 6, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBox7, 7, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(219, 346)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 44)
    Me.TableLayoutPanel1.TabIndex = 27
    '
    'PictureBox1
    '
    Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Location = New System.Drawing.Point(100, 3)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'PictureBox2
    '
    Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox2.Location = New System.Drawing.Point(140, 3)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox2.TabIndex = 1
    Me.PictureBox2.TabStop = False
    '
    'PictureBox3
    '
    Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox3.Location = New System.Drawing.Point(180, 3)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox3.TabIndex = 2
    Me.PictureBox3.TabStop = False
    '
    'PictureBox4
    '
    Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox4.Location = New System.Drawing.Point(220, 3)
    Me.PictureBox4.Name = "PictureBox4"
    Me.PictureBox4.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox4.TabIndex = 3
    Me.PictureBox4.TabStop = False
    '
    'PictureBox5
    '
    Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox5.Location = New System.Drawing.Point(260, 3)
    Me.PictureBox5.Name = "PictureBox5"
    Me.PictureBox5.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox5.TabIndex = 4
    Me.PictureBox5.TabStop = False
    '
    'PictureBox6
    '
    Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox6.Location = New System.Drawing.Point(300, 3)
    Me.PictureBox6.Name = "PictureBox6"
    Me.PictureBox6.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox6.TabIndex = 5
    Me.PictureBox6.TabStop = False
    '
    'PictureBox7
    '
    Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox7.Location = New System.Drawing.Point(340, 3)
    Me.PictureBox7.Name = "PictureBox7"
    Me.PictureBox7.Size = New System.Drawing.Size(34, 38)
    Me.PictureBox7.TabIndex = 6
    Me.PictureBox7.TabStop = False
    '
    'UserControlTactica
    '
    Me.AllowDrop = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelTot)
    Me.Name = "UserControlTactica"
    Me.Size = New System.Drawing.Size(696, 423)
    Me.TableLayoutPanelTot.ResumeLayout(False)
    Me.PanelCanvas.ResumeLayout(False)
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanelTot As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents PanelCanvas As System.Windows.Forms.Panel
  Friend WithEvents PictureBoxCanvas As System.Windows.Forms.PictureBox
  Friend WithEvents LabelSelectedPlayer As System.Windows.Forms.Label
  Friend WithEvents ContextMenuStripPlayers As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents ListViewTeam As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeaderDorsal As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeaderNom As System.Windows.Forms.ColumnHeader
  Friend WithEvents ToolTipDrag As System.Windows.Forms.ToolTip
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents PictureBox1 As PictureBox
  Friend WithEvents PictureBox2 As PictureBox
  Friend WithEvents PictureBox3 As PictureBox
  Friend WithEvents PictureBox4 As PictureBox
  Friend WithEvents PictureBox5 As PictureBox
  Friend WithEvents PictureBox6 As PictureBox
  Friend WithEvents PictureBox7 As PictureBox
End Class
