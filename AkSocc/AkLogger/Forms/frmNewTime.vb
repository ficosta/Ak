
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class frmNewTime
  Inherits Form
  Private myTime As String = "00:00"
  Public ReadOnly Property Time() As String
    Get
      Return myTime
    End Get
  End Property


  Private Sub btnCancel_Click(sender As Object, e As EventArgs)
    Me.Close()
  End Sub

  Private Sub btnOk_Click(sender As Object, e As EventArgs)
    'myTime = Utils.TwoChars(Utils.Val(txtHour.Text)) + ":" + Utils.TwoChars(Utils.Val(txtMinute.Text))
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub
End Class
