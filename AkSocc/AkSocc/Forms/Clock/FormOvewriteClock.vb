Public Class FormOvewriteClock
  Public Property Minutes As Integer
    Get
      Return Me.NumericUpDownMinutes.Value
    End Get
    Set(value As Integer)
      Me.NumericUpDownMinutes.Value = value
    End Set
  End Property
  Public Property Seconds As Integer
    Get
      Return Me.NumericUpDownSeconds.Value
    End Get
    Set(value As Integer)
      Me.NumericUpDownSeconds.Value = value
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
End Class