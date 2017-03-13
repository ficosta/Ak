<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenMain
  Inherits System.Windows.Forms.Form

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
  Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
  Friend WithEvents Version As System.Windows.Forms.Label
  Friend WithEvents Copyright As System.Windows.Forms.Label
  Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenMain))
    Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    Me.Version = New System.Windows.Forms.Label()
    Me.Copyright = New System.Windows.Forms.Label()
    Me.ApplicationTitle = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
    Me.DetailsLayoutPanel.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DetailsLayoutPanel
    '
    Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
    Me.DetailsLayoutPanel.ColumnCount = 1
    Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
    Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
    Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
    Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
    Me.DetailsLayoutPanel.Location = New System.Drawing.Point(553, 291)
    Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
    Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
    Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
    Me.DetailsLayoutPanel.Size = New System.Drawing.Size(202, 49)
    Me.DetailsLayoutPanel.TabIndex = 1
    '
    'Version
    '
    Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Version.BackColor = System.Drawing.Color.Transparent
    Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Version.Location = New System.Drawing.Point(3, 2)
    Me.Version.Name = "Version"
    Me.Version.Size = New System.Drawing.Size(241, 20)
    Me.Version.TabIndex = 1
    Me.Version.Text = "Version {0}.{1:00}"
    '
    'Copyright
    '
    Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Copyright.BackColor = System.Drawing.Color.Transparent
    Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Copyright.Location = New System.Drawing.Point(3, 24)
    Me.Copyright.Name = "Copyright"
    Me.Copyright.Size = New System.Drawing.Size(241, 25)
    Me.Copyright.TabIndex = 2
    Me.Copyright.Text = "Copyright"
    '
    'ApplicationTitle
    '
    Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
    Me.ApplicationTitle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ApplicationTitle.Location = New System.Drawing.Point(3, 288)
    Me.ApplicationTitle.Name = "ApplicationTitle"
    Me.ApplicationTitle.Size = New System.Drawing.Size(544, 55)
    Me.ApplicationTitle.TabIndex = 0
    Me.ApplicationTitle.Text = "Application Title"
    Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBoxLogo, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.ApplicationTitle, 0, 1)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 343)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'PictureBoxLogo
    '
    Me.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxLogo.Image = Global.AkSocc.My.Resources.Resources.alkamel_2012
    Me.PictureBoxLogo.InitialImage = CType(resources.GetObject("PictureBoxLogo.InitialImage"), System.Drawing.Image)
    Me.PictureBoxLogo.Location = New System.Drawing.Point(3, 3)
    Me.PictureBoxLogo.Name = "PictureBoxLogo"
    Me.PictureBoxLogo.Size = New System.Drawing.Size(544, 282)
    Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBoxLogo.TabIndex = 0
    Me.PictureBoxLogo.TabStop = False
    '
    'SplashScreenMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(781, 362)
    Me.ControlBox = False
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "SplashScreenMain"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.DetailsLayoutPanel.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents PictureBoxLogo As PictureBox
End Class
