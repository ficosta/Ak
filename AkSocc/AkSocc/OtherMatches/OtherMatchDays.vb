<Serializable()> Public Class OtherMatchDays
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(MatchDay As MatchDay) As Integer
    Try
      If Not MatchDay Is Nothing Then
        Me.List.Add(MatchDay)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As MatchDay
    Get
      Return DirectCast(List(Index), MatchDay)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchDays() As List(Of MatchDay)
    Dim res As New List(Of MatchDay)
    Try
      For Each match As OtherMatch In Me.InnerList
        For Each matchDay As MatchDay In res

        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchDay(matchDay As String) As MatchDay
    Dim res As MatchDay = Nothing
    Try
      For Each match As MatchDay In Me.InnerList
        If match.MatchDayName = matchDay Or match.MatchDayID = matchDay Then
          res = match
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

#Region "Classification"
  Public Property Classification As Classification

  Public Sub ComputeClassification()
    Try
      Classification = New Classification
      'order by match day
      Me.Sort()

      'Get all the teams
      Dim _teams As New MatchInfo.Teams()
      For Each matchDay As MatchDay In Me.List
        For Each match As OtherMatch In matchDay.OtherMatches
          If Not match.Match Is Nothing Then
            If Not _teams.Contains(match.Match.HomeTeam) Then _teams.Add(match.Match.HomeTeam)
            If Not _teams.Contains(match.Match.AwayTeam) Then _teams.Add(match.Match.AwayTeam)
          End If
        Next
      Next

      'for each team, populate its helper class
      For Each team As MatchInfo.Team In _teams
        Dim teamForCompetition As New TeamClassificationForCompetition(team)
        For Each matchDay As MatchDay In Me.List
          Dim teamClassificationForMatchDay As New TeamClassificationForMatchDay(team, matchDay.Index, Nothing)
          For Each match As OtherMatch In matchDay.OtherMatches
            If Not match.Match Is Nothing Then
              If match.Match.HomeTeam.ID = team.ID Or match.Match.AwayTeam.ID = team.ID Then
                teamClassificationForMatchDay.Match = match
              End If
            End If
          Next
          teamForCompetition.ClassificationsForMatchDay.Add(teamClassificationForMatchDay)
        Next
        Classification.TeamClassificationsForCompetition.Add(teamForCompetition)
      Next

      'for each helper class, calculate
      For Each teamForCompetition As TeamClassificationForCompetition In Classification.TeamClassificationsForCompetition
        teamForCompetition.UpdateClassifications()
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#End Region
End Class
