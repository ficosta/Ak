<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWaitingForDirector
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroLabelPrompt = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.MetroLabelPrompt, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(448, 133)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'MetroLabelPrompt
    '
    Me.MetroLabelPrompt.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLabelPrompt, 3)
    Me.MetroLabelPrompt.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroLabelPrompt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroLabelPrompt.Location = New System.Drawing.Point(3, 0)
    Me.MetroLabelPrompt.Name = "MetroLabelPrompt"
    Me.MetroLabelPrompt.Size = New System.Drawing.Size(442, 94)
    Me.MetroLabelPrompt.TabIndex = 2
    Me.MetroLabelPrompt.Text = "Waiting for director to end"
    Me.MetroLabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'FormWaitingForDirector
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(448, 133)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormWaitingForDirector"
    Me.Opacity = 0.85R
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Waiting for director"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents MetroLabelPrompt As Label
End Class
