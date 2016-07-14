Imports MatchInfo

Public Class Classification
  Public Property ClassificationForMatchDays As New List(Of ClassificationForMatchDay)
  Public Property TeamClassificationsForCompetition As New List(Of TeamClassificationForCompetition)
  Public Property Matches As Matches

  Private _teams As New Teams

  Public Sub New(matches As Matches)
    Me.Matches = matches
    InitializeCollections()
  End Sub

#Region "Functions"
  Public Sub InitializeCollections()
    Try
      Matches.Sort()
      _teams.Clear()
      For Each match As Match In _Matches
        If Not match Is Nothing Then
          If Not _teams.Contains(match.HomeTeam) Then _teams.Add(match.HomeTeam)
          If Not _teams.Contains(match.AwayTeam) Then _teams.Add(match.AwayTeam)
        End If
      Next

      Me.CalculateClassification()

    Catch ex As Exception

    End Try
  End Sub

  Public Sub CalculateClassification()
    Try
      'create classifications for each day
      Me.ClassificationForMatchDays.Clear()

      For iMatchDay As Integer = 1 To 2 * (_teams.Count - 1)
        ClassificationForMatchDays.Add(New AkSocc.ClassificationForMatchDay(iMatchDay))
      Next
      'for each team
      Dim teamClassifications As New List(Of TeamClassificationForCompetition)
      For Each team As Team In _teams
        'for each match day
        'get the classification for that match day
        Dim tcfc As TeamClassificationForCompetition = OneVersusAll(team)
        For i As Integer = 0 To tcfc.ClassificationsForMatchDay.Count - 1
          ClassificationForMatchDays(i).TeamClassificationList.Add(tcfc.ClassificationsForMatchDay(i))
        Next
      Next
      'now, for each match day, sort it
      For i As Integer = 0 To ClassificationForMatchDays.Count - 1
        ClassificationForMatchDays(i).TeamClassificationList.Sort()
      Next

      'now, show the classification for the last available match day
      Dim aux As ClassificationForMatchDay = Me.LastAvailableClassificationForMatchDay
      If Not aux Is Nothing Then
        For i As Integer = 0 To aux.TeamClassificationList.Count - 1
          Dim tcfmd As TeamClassificationForMatchDay = aux.TeamClassificationList(i)
          tcfmd.Position = i + 1
          Debug.Print(tcfmd.Position & "   " & tcfmd.Team.TeamAELCaption1Name & "   " & tcfmd.MatchesPlayed & "    " & tcfmd.Points & "    " & tcfmd.GoalsFor & "    " & tcfmd.GoalsAgainst & "    " & tcfmd.GoalsFor - tcfmd.GoalsAgainst)
        Next
      End If

    Catch ex As Exception

    End Try
  End Sub

  Public Function LastAvailableClassificationForMatchDay() As ClassificationForMatchDay
    Dim res As ClassificationForMatchDay = Nothing
    Try
      For i As Integer = Me.ClassificationForMatchDays.Count - 1 To 0 Step -1
        If Me.ClassificationForMatchDays(i).TeamClassificationList.Count > 0 Then
          res = Me.ClassificationForMatchDays(i)
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function
#End Region

#Region "One versus all"
  Public Function OneVersusAll(team As Team) As TeamClassificationForCompetition
    Dim res As New TeamClassificationForCompetition(team)
    Try
      'get all matches for this team
      Dim matches As List(Of Match) = _Matches.GetMatchesForTeam(team.ID)
      'sort by date
      matches.Sort()
      Dim current As TeamClassificationForMatchDay
      Dim former As TeamClassificationForMatchDay = Nothing
      For i As Integer = 0 To matches.Count - 1
        current = UpdateClassification(team, i, matches(i), former)
        former = current
        res.ClassificationsForMatchDay.Add(current)
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function UpdateClassification(team As Team, index As Integer, match As Match, former As TeamClassificationForMatchDay) As TeamClassificationForMatchDay
    Dim current As New TeamClassificationForMatchDay(team, index, match)

    Try
      Dim pointsForWonMatch As Integer = 3
      Dim pointsForTiedMatch As Integer = 1
      Dim pointsForLostMatch As Integer = 0

      If Not former Is Nothing Then
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
        Select Case current.Match.home_goals
          Case -1
            'nothing to add
          Case Else
            current.MatchesPlayed += 1
            Dim goalsFor As Integer = 0
            Dim goalsAgainst As Integer = 0
            If current.Match.HomeTeam.ID = team.ID Then
              goalsFor = current.Match.home_goals
              goalsAgainst = current.Match.away_goals
            Else
              goalsAgainst = current.Match.home_goals
              goalsFor = current.Match.away_goals
            End If

            current.GoalsFor += goalsFor
            current.GoalsAgainst += goalsAgainst
            If goalsFor > goalsAgainst Then
              current.MatchesWon += 1
              current.Points += pointsForWonMatch
            ElseIf goalsFor < goalsAgainst Then
              current.MatchesLost += 1
              current.Points += pointsForLostMatch
            ElseIf goalsFor = goalsAgainst Then
              current.MatchesDrawn += 1
              current.Points += pointsForTiedMatch
            End If
        End Select
      End If



    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return current
  End Function

#End Region
End Class
