Public Class frmOtherMatches
#Region "Other matches"
  Private _otherMatches As OtherMatches
  Public Property OtherMatchas As OtherMatches
    Get
      Return _otherMatches
    End Get
    Set(value As OtherMatches)
      _otherMatches = value
    End Set
  End Property
#End Region

  Private _matchDays As New List(Of OtherMatches)

  Private Sub frmOtherMatches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If _otherMatches Is Nothing Then
      _otherMatches = New OtherMatches
      _otherMatches.LoadFromFile("")
      _matchDays = _otherMatches.GetMatchDays()
    End If
  End Sub
End Class