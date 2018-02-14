Public Class FormOvewriteClock
  Public Property Minutes As Integer
    Get
      Return NoNullInt(Me.TextBoxMinutes.Text)
    End Get
    Set(value As Integer)
      Me.TextBoxMinutes.Text = value
    End Set
  End Property
  Public Property Seconds As Integer
    Get
      Return NoNullInt(Me.TextBoxSeconds.Text)
    End Get
    Set(value As Integer)
      Me.TextBoxSeconds.Text = value
    End Set
  End Property

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles TextBoxMinutes.GotFocus, TextBoxSeconds.GotFocus
    Try
      Dim txtBox As TextBox = CType(sender, TextBox)

      txtBox.SelectionStart = 0
      txtBox.SelectionLength = txtBox.Text.Length
    Catch ex As Exception

    End Try

  End Sub


  Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxMinutes.KeyPress, TextBoxSeconds.KeyPress
    Try
      Dim txtBox As TextBox = CType(sender, TextBox)

      If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
        e.Handled = True
      End If
      If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
        e.Handled = False
      End If
    Catch ex As Exception

    End Try

  End Sub

  Private Sub FormOvewriteClock_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Me.TextBoxMinutes.Focus()
  End Sub
End Class