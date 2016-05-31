Public Class UCOtherMatch

  Public Event MoveUp(sender As UCOtherMatch)
  Public Event MoveDown(sender As UCOtherMatch)
  Public Event Delete(sender As UCOtherMatch)

#Region "Properties"
  Private WithEvents _otherMatch As OtherMatch
  Public Property OtherMatchInfo As OtherMatch
    Get
      Return _otherMatch
    End Get
    Set(value As OtherMatch)
      _otherMatch = value
    End Set
  End Property
#End Region

#Region "Buttons"
  Private Sub ButtonUP_Click(sender As Object, e As EventArgs) Handles ButtonUP.Click
    RaiseEvent MoveUp(Me)
  End Sub

  Private Sub ButtonDOWN_Click(sender As Object, e As EventArgs) Handles ButtonDOWN.Click
    RaiseEvent MoveDown(Me)
  End Sub

  Private Sub MetroButtonDelete_Click(sender As Object, e As EventArgs) Handles MetroButtonDelete.Click
    RaiseEvent Delete(Me)
  End Sub
#End Region

#Region "CheckBoxes"
  Private Sub MetroCheckBoxAddToCrawl_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBoxAddToCrawl.CheckedChanged

  End Sub

  Private Sub MetroCheckBoxAddToTable_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBoxAddToTable.CheckedChanged

  End Sub
#End Region

End Class
