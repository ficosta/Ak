Public Class TeamClassificationForMatchDay
  Implements IComparable

  Public Property Team As MatchInfo.Team
  Public Property MatchDayIndex As Integer = 0
  Public Property Match As OtherMatch = Nothing

  Public Property Points As Integer = 0
  Public Property Position As Integer = 0
  Public Property GoalsFor As Integer = 0
  Public Property GoalsAgainst As Integer = 0
  Public Property MatchesWon As Integer = 0
  Public Property MatchesLost As Integer = 0
  Public Property MatchesDrawn As Integer = 0
  Public Property MatchesPlayed As Integer = 0

  Public ReadOnly Property GoalAverage As Integer
    Get
      Return GoalsFor - GoalsAgainst
    End Get
  End Property

  Public Sub New(team As MatchInfo.Team, matchDayIndex As Integer, match As OtherMatch)
    Try
      Me.Team = team
      Me.MatchDayIndex = matchDayIndex
      Me.Match = match
    Catch ex As Exception
    End Try
  End Sub

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Throw New NotImplementedException()
  End Function

End Class

Public Class TeamClassificationForCompetition
  Implements IComparable

  Public Property Team As MatchInfo.Team

  Public Sub New(team As MatchInfo.Team)
    Me.Team = team
  End Sub

  Public Property ClassificationsForMatchDay As New List(Of TeamClassificationForMatchDay)

#Region "Compare functions"
  Public Property ComparisionMatchDay As Integer

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      If ComparisionMatchDay >= 0 And ComparisionMatchDay < Me.ClassificationsForMatchDay.Count Then
        Me.ClassificationsForMatchDay(ComparisionMatchDay).CompareTo(CType(obj, TeamClassificationForMatchDay))
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function
#End Region

  Public Sub UpdateClassifications()
    Try
      For i As Integer = 0 To Me.ClassificationsForMatchDay.Count - 1
        UpdateClassification(i)
      Next
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub UpdateClassification(index As Integer)
    Try
      Dim current As TeamClassificationForMatchDay = Me.ClassificationsForMatchDay(index)
      Dim pointsForWonMatch As Integer = 3
      Dim pointsForTiedMatch As Integer = 1
      Dim pointsForLostMatch As Integer = 0

      If index > 0 Then
        Dim former As TeamClassificationForMatchDay = Me.ClassificationsForMatchDay(index - 1)
        current.GoalsAgainst = former.GoalsAgainst
        current.GoalsFor = former.GoalsFor
        current.MatchesDrawn = former.MatchesDrawn
        current.MatchesPlayed = former.MatchesPlayed
        current.MatchesWon = former.MatchesWon
        current.MatchesLost = former.MatchesLost
        current.Points = former.Points
      Else
        current.GoalsAgainst = 0
        current.GoalsFor = 0
        current.MatchesDrawn = 0
        current.MatchesPlayed = 0
        current.MatchesWon = 0
        current.MatchesLost = 0
        current.Points = 0
      End If

      If Not current.Match Is Nothing Then
        Select Case current.Match.MatchStatus
          Case OtherMatch.otherMatchStatus.Idle
            'nothing to add
          Case Else
            current.MatchesPlayed += 1
            Dim goalsFor As Integer = 0
            Dim goalsAgaint As Integer = 0
            If current.Match.Match.HomeTeam.ID = Me.Team.ID Then
              Integer.TryParse(current.Match.HomeScore, goalsFor)
              Integer.TryParse(current.Match.AwayScore, goalsAgaint)
            Else
              Integer.TryParse(current.Match.AwayScore, goalsFor)
              Integer.TryParse(current.Match.HomeScore, goalsAgaint)
            End If

            current.GoalsFor += goalsFor
            current.GoalsAgainst += goalsAgaint
            If goalsFor > goalsAgaint Then
              current.MatchesWon += 1
              current.Points += pointsForWonMatch
            ElseIf goalsFor < goalsAgaint Then
              current.MatchesLost += 1
              current.Points += pointsForLostMatch
            ElseIf goalsFor = goalsAgaint Then
              current.MatchesDrawn += 1
              current.Points += pointsForTiedMatch
            End If
        End Select
      End If



    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
End Class
