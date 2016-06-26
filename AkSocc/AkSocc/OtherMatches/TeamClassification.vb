Public Class TeamClassificationForMatchDay
  Implements IComparable

  Public Property Team As MatchInfo.Team
  Public Property MatchDay As MatchDay

  Public Property Points As Integer = 0
  Public Property Position As Integer = 0
  Public Property GoalsFor As Integer = 0
  Public Property GoalsAgainst As Integer = 0
  Public Property MatchesWon As Integer = 0
  Public Property MathcesLost As Integer = 0
  Public Property MatchesDrawn As Integer = 0

  Public ReadOnly Property GoalAverage As Integer
    Get
      Return GoalsFor - GoalsAgainst
    End Get
  End Property


  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Throw New NotImplementedException()
  End Function
End Class
