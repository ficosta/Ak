<Serializable()> Public Class OtherMatch
  Implements IComparable

  Public Enum otherMatchStatus
    Idle
    HalfTime
    FullTime
    LatestResult
  End Enum
  Public Property OtherMatchID As Integer

  Public Property MatchTitle As String
  Public Property MatchDay As Integer
  Public Property MatchDate As Date
  Public Property MatchIndex As Integer

  Public Property HomeTeamID As Integer
  Public Property AwayTeamID As Integer
  Public Property HomeTeamName As String
  Public Property AwayTeamName As String
  Public Property HomeTeamScore As Integer
  Public Property AwayTeamScore As Integer

  Public Property LogoChannel As Integer = 0
  Public Property MatchStatus As otherMatchStatus = otherMatchStatus.Idle

  Public Sub New()
  End Sub
  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As OtherMatch = CType(obj, OtherMatch)
    If aux.MatchDay > Me.MatchDay Then
      Return 1
    ElseIf aux.MatchDay < Me.MatchDay Then
      Return -1
    ElseIf aux.MatchIndex > Me.MatchIndex Then
      Return 1
    ElseIf aux.MatchIndex < Me.MatchIndex Then
      Return -1
    Else
      Return 0
    End If
  End Function
End Class
