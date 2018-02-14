<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadScenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadScenes))
    Me.C1FlexGridEscenes = New C1.Win.C1FlexGrid.C1FlexGrid
    Me.LabelPercAllocated = New System.Windows.Forms.Label
    Me.ProgressBarAllocated = New System.Windows.Forms.ProgressBar
    Me.LabelUsed = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.LabelAllocated = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.LabelTotal = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.LabelPercUsed = New System.Windows.Forms.Label
    Me.LabelPerc = New System.Windows.Forms.Label
    Me.ProgressBarTotal = New System.Windows.Forms.ProgressBar
    Me.GroupBoxRender = New System.Windows.Forms.GroupBox
    Me.GroupBoxProjecte = New System.Windows.Forms.GroupBox
    Me.CheckBoxTancarAutomaticament = New System.Windows.Forms.CheckBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.LabelPathProjecte = New System.Windows.Forms.Label
    CType(Me.C1FlexGridEscenes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxRender.SuspendLayout()
    Me.GroupBoxProjecte.SuspendLayout()
    Me.SuspendLayout()
    '
    'C1FlexGridEscenes
    '
    Me.C1FlexGridEscenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.C1FlexGridEscenes.ColumnInfo = "10,1,0,0,0,90,Columns:"
    Me.C1FlexGridEscenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.C1FlexGridEscenes.Location = New System.Drawing.Point(12, 12)
    Me.C1FlexGridEscenes.Name = "C1FlexGridEscenes"
    Me.C1FlexGridEscenes.Size = New System.Drawing.Size(510, 353)
    Me.C1FlexGridEscenes.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("C1FlexGridEscenes.Styles"))
    Me.C1FlexGridEscenes.TabIndex = 0
    '
    'LabelPercAllocated
    '
    Me.LabelPercAllocated.AutoSize = True
    Me.LabelPercAllocated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelPercAllocated.Location = New System.Drawing.Point(198, 61)
    Me.LabelPercAllocated.Name = "LabelPercAllocated"
    Me.LabelPercAllocated.Size = New System.Drawing.Size(41, 13)
    Me.LabelPercAllocated.TabIndex = 22
    Me.LabelPercAllocated.Text = "100%"
    Me.LabelPercAllocated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ProgressBarAllocated
    '
    Me.ProgressBarAllocated.Location = New System.Drawing.Point(9, 86)
    Me.ProgressBarAllocated.Name = "ProgressBarAllocated"
    Me.ProgressBarAllocated.Size = New System.Drawing.Size(230, 19)
    Me.ProgressBarAllocated.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.ProgressBarAllocated.TabIndex = 21
    '
    'LabelUsed
    '
    Me.LabelUsed.AutoSize = True
    Me.LabelUsed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelUsed.Location = New System.Drawing.Point(134, 120)
    Me.LabelUsed.Name = "LabelUsed"
    Me.LabelUsed.Size = New System.Drawing.Size(27, 13)
    Me.LabelUsed.TabIndex = 20
    Me.LabelUsed.Text = "0%"
    Me.LabelUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(6, 120)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 13)
    Me.Label6.TabIndex = 19
    Me.Label6.Text = "Used memory"
    '
    'LabelAllocated
    '
    Me.LabelAllocated.AutoSize = True
    Me.LabelAllocated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelAllocated.Location = New System.Drawing.Point(134, 61)
    Me.LabelAllocated.Name = "LabelAllocated"
    Me.LabelAllocated.Size = New System.Drawing.Size(27, 13)
    Me.LabelAllocated.TabIndex = 18
    Me.LabelAllocated.Text = "0%"
    Me.LabelAllocated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(6, 61)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(92, 13)
    Me.Label4.TabIndex = 17
    Me.Label4.Text = "Allocated memory"
    '
    'LabelTotal
    '
    Me.LabelTotal.AutoSize = True
    Me.LabelTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelTotal.Location = New System.Drawing.Point(134, 38)
    Me.LabelTotal.Name = "LabelTotal"
    Me.LabelTotal.Size = New System.Drawing.Size(27, 13)
    Me.LabelTotal.TabIndex = 16
    Me.LabelTotal.Text = "0%"
    Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(6, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 15
    Me.Label2.Text = "Total memory"
    '
    'LabelPercUsed
    '
    Me.LabelPercUsed.AutoSize = True
    Me.LabelPercUsed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelPercUsed.Location = New System.Drawing.Point(198, 120)
    Me.LabelPercUsed.Name = "LabelPercUsed"
    Me.LabelPercUsed.Size = New System.Drawing.Size(41, 13)
    Me.LabelPercUsed.TabIndex = 14
    Me.LabelPercUsed.Text = "100%"
    Me.LabelPercUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'LabelPerc
    '
    Me.LabelPerc.AutoSize = True
    Me.LabelPerc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelPerc.Location = New System.Drawing.Point(6, 16)
    Me.LabelPerc.Name = "LabelPerc"
    Me.LabelPerc.Size = New System.Drawing.Size(72, 13)
    Me.LabelPerc.TabIndex = 13
    Me.LabelPerc.Text = "Used memory"
    '
    'ProgressBarTotal
    '
    Me.ProgressBarTotal.Location = New System.Drawing.Point(9, 145)
    Me.ProgressBarTotal.Name = "ProgressBarTotal"
    Me.ProgressBarTotal.Size = New System.Drawing.Size(230, 19)
    Me.ProgressBarTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.ProgressBarTotal.TabIndex = 12
    '
    'GroupBoxRender
    '
    Me.GroupBoxRender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBoxRender.Controls.Add(Me.LabelPerc)
    Me.GroupBoxRender.Controls.Add(Me.LabelPercAllocated)
    Me.GroupBoxRender.Controls.Add(Me.ProgressBarTotal)
    Me.GroupBoxRender.Controls.Add(Me.ProgressBarAllocated)
    Me.GroupBoxRender.Controls.Add(Me.LabelPercUsed)
    Me.GroupBoxRender.Controls.Add(Me.LabelUsed)
    Me.GroupBoxRender.Controls.Add(Me.Label2)
    Me.GroupBoxRender.Controls.Add(Me.Label6)
    Me.GroupBoxRender.Controls.Add(Me.LabelTotal)
    Me.GroupBoxRender.Controls.Add(Me.LabelAllocated)
    Me.GroupBoxRender.Controls.Add(Me.Label4)
    Me.GroupBoxRender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBoxRender.Location = New System.Drawing.Point(528, 184)
    Me.GroupBoxRender.Name = "GroupBoxRender"
    Me.GroupBoxRender.Size = New System.Drawing.Size(254, 174)
    Me.GroupBoxRender.TabIndex = 23
    Me.GroupBoxRender.TabStop = False
    Me.GroupBoxRender.Text = "Render status"
    '
    'GroupBoxProjecte
    '
    Me.GroupBoxProjecte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBoxProjecte.Controls.Add(Me.CheckBoxTancarAutomaticament)
    Me.GroupBoxProjecte.Controls.Add(Me.Label1)
    Me.GroupBoxProjecte.Controls.Add(Me.LabelPathProjecte)
    Me.GroupBoxProjecte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBoxProjecte.Location = New System.Drawing.Point(528, 12)
    Me.GroupBoxProjecte.Name = "GroupBoxProjecte"
    Me.GroupBoxProjecte.Size = New System.Drawing.Size(254, 141)
    Me.GroupBoxProjecte.TabIndex = 24
    Me.GroupBoxProjecte.TabStop = False
    Me.GroupBoxProjecte.Text = "Projecte"
    '
    'CheckBoxTancarAutomaticament
    '
    Me.CheckBoxTancarAutomaticament.AutoSize = True
    Me.CheckBoxTancarAutomaticament.Checked = True
    Me.CheckBoxTancarAutomaticament.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBoxTancarAutomaticament.Location = New System.Drawing.Point(19, 107)
    Me.CheckBoxTancarAutomaticament.Name = "CheckBoxTancarAutomaticament"
    Me.CheckBoxTancarAutomaticament.Size = New System.Drawing.Size(204, 17)
    Me.CheckBoxTancarAutomaticament.TabIndex = 2
    Me.CheckBoxTancarAutomaticament.Text = "Tancar finestra en finalitzar el procés"
    Me.CheckBoxTancarAutomaticament.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(28, 49)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(16, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "..."
    '
    'LabelPathProjecte
    '
    Me.LabelPathProjecte.AutoSize = True
    Me.LabelPathProjecte.Location = New System.Drawing.Point(6, 27)
    Me.LabelPathProjecte.Name = "LabelPathProjecte"
    Me.LabelPathProjecte.Size = New System.Drawing.Size(72, 13)
    Me.LabelPathProjecte.TabIndex = 0
    Me.LabelPathProjecte.Text = "Path projecte"
    '
    'frmLoadScenes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(794, 369)
    Me.Controls.Add(Me.GroupBoxProjecte)
    Me.Controls.Add(Me.GroupBoxRender)
    Me.Controls.Add(Me.C1FlexGridEscenes)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Name = "frmLoadScenes"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Carregant escenes..."
    CType(Me.C1FlexGridEscenes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxRender.ResumeLayout(False)
    Me.GroupBoxRender.PerformLayout()
    Me.GroupBoxProjecte.ResumeLayout(False)
    Me.GroupBoxProjecte.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents C1FlexGridEscenes As C1.Win.C1FlexGrid.C1FlexGrid
  Friend WithEvents LabelPercAllocated As System.Windows.Forms.Label
  Friend WithEvents ProgressBarAllocated As System.Windows.Forms.ProgressBar
  Friend WithEvents LabelUsed As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents LabelAllocated As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents LabelTotal As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents LabelPercUsed As System.Windows.Forms.Label
  Friend WithEvents LabelPerc As System.Windows.Forms.Label
  Friend WithEvents ProgressBarTotal As System.Windows.Forms.ProgressBar
  Friend WithEvents GroupBoxRender As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBoxProjecte As System.Windows.Forms.GroupBox
  Friend WithEvents LabelPathProjecte As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents CheckBoxTancarAutomaticament As System.Windows.Forms.CheckBox
End Class
