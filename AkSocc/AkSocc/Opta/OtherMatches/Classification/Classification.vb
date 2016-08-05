Imports MatchInfo

Public Class Classification
  Public Property ClassificationForMatchDays As New List(Of ClassificationForMatchDay)
  Public Property TeamClassificationsForCompetition As New List(Of TeamClassificationForCompetition)
  Public Property Matches As Matches

  Private _teams As New Teams

  Public Sub New(matches As Matches)
    InitializeCollections(matches)
  End Sub

#Region "Functions"
  Public Sub InitializeCollections(myMatches As Matches)
    Try
      Matches = myMatches
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
        For i As Integer = tcfc.ClassificationsForMatchDay.Count To 2 * (_teams.Count - 1) - 1
          Dim tcfmd As New TeamClassificationForMatchDay(team, i, Nothing)

          If tcfc.ClassificationsForMatchDay.Count > 0 Then
            tcfmd.FormerPosition = 0
            tcfmd.GoalsAgainst = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).GoalsAgainst
            tcfmd.GoalsFor = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).GoalsFor
            tcfmd.Match = Nothing
            tcfmd.MatchDayIndex = i
            tcfmd.MatchesDrawn = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).MatchesDrawn
            tcfmd.MatchesLost = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).MatchesLost
            tcfmd.MatchesPlayed = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).MatchesPlayed
            tcfmd.MatchesWon = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).MatchesWon
            tcfmd.Points = tcfc.ClassificationsForMatchDay(tcfc.ClassificationsForMatchDay.Count - 1).Points
            tcfmd.Position = 0
            tcfmd.PositionChange = TeamClassificationForMatchDay.ePositionChange.Equal
          End If

          ClassificationForMatchDays(i).TeamClassificationList.Add(tcfmd)
          Next
      Next
      'now, for each match day, sort it
      For i As Integer = 0 To ClassificationForMatchDays.Count - 1
        UpdateArrowsForMatchDay(ClassificationForMatchDays(i))
      Next

      'now, show the classification for the last available match day
      Dim aux As ClassificationForMatchDay = Me.LastAvailableClassificationForMatchDay
      If Not aux Is Nothing Then
        Me.Sort(aux, eSortField.Points)
        For i As Integer = 0 To aux.TeamClassificationList.Count - 1
          Dim tcfmd As TeamClassificationForMatchDay = aux.TeamClassificationList(i)
          tcfmd.Position = i + 1
          Debug.Print(tcfmd.ToString)
        Next
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateArrows(classMatchDay As ClassificationForMatchDay)
    Try
      'classMatchDay.Sort()
      'Break ties!
      For i As Integer = 1 To classMatchDay.TeamClassificationList.Count - 1

      Next
    Catch ex As Exception

    End Try
  End Sub

  Public Function LastAvailableClassificationForMatchDay() As ClassificationForMatchDay
    Dim res As ClassificationForMatchDay = Nothing
    Try
      For i As Integer = Me.ClassificationForMatchDays.Count - 1 To 0 Step -1
        If Me.ClassificationForMatchDays(i).HasResults Then
          res = Me.ClassificationForMatchDays(i)
          Exit For
        End If
      Next
      If Not res Is Nothing Then
        Me.UpdateArrowsForMatchDay(res.MatchDay)
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetClassificationForMatchDay(matchDay As Integer) As ClassificationForMatchDay
    Dim res As ClassificationForMatchDay = Nothing
    Try
      For i As Integer = Me.ClassificationForMatchDays.Count - 1 To 0 Step -1
        If Me.ClassificationForMatchDays(i).MatchDay = matchDay Then
          res = Me.ClassificationForMatchDays(i)
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function


  Public Sub UpdateArrowsForMatchDay(matchDay As Integer)
    Try
      UpdateArrowsForMatchDay(Me.GetClassificationForMatchDay(matchDay))
    Catch ex As Exception

    End Try
  End Sub

  Private Sub BreakTies(teams As List(Of TeamClassificationForMatchDay), sortFieldIndex As Integer)
    Try
      If sortFieldIndex > _sortFields.Count - 1 Then Exit Sub
      If teams.Count <= 1 Then Exit Sub 'nothing to do

      Dim tieGroups As New List(Of List(Of TeamClassificationForMatchDay))
      Dim tiesToBreak As Boolean = False

      'detect ties: first, we sort by position
      Test_QuickSort(teams, eSortField.Position)

      'Detect the ties by position
      Dim tieGroup As New List(Of TeamClassificationForMatchDay)
      tieGroup.Add(teams(0))
      Dim pos As Integer = 1
      For i As Integer = 1 To teams.Count - 1
        'there's a tie
        pos += 1
        If teams(i - 1).Position = teams(i).Position Then
          'add current item to tie group
          teams(i).Position = teams(i - 1).Position
          tieGroup.Add(teams(i))
        Else
          'if the last tie group has more then 1 item, it was a group, else it was just 1 item
          If tieGroup.Count > 1 Then tieGroups.Add(tieGroup)
          tieGroup = New List(Of TeamClassificationForMatchDay)
          teams(i).Position = pos
          tieGroup.Add(teams(i))
        End If
      Next

      'nobody is counting with the last tie group... was there a tie?
      If tieGroup.Count > 1 Then tieGroups.Add(tieGroup)

      'Now, lets break those ties
      For Each tieGroup In tieGroups
        'sort it with the selected field, break ties with next field
        Test_QuickSort(tieGroup, _sortFields(sortFieldIndex))
        pos = tieGroup(0).Position
        tiesToBreak = False
        'update the positions
        For i As Integer = 1 To tieGroup.Count - 1
          pos += 1
          If Me.GetSortField(tieGroup(i - 1), _sortFields(sortFieldIndex)) = Me.GetSortField(tieGroup(i), _sortFields(sortFieldIndex)) Then
            'there's a tie
            tieGroup(i).Position = tieGroup(i - 1).Position
            tiesToBreak = True
          Else
            'no tie, the value that corresponds to it
            tieGroup(i).Position = pos
          End If
        Next


      Next
      'let's sort our team collection by position
      Test_QuickSort(teams, eSortField.Position)

      If tiesToBreak Then
        'lets break the ties with the next available field
        BreakTies(teams, sortFieldIndex + 1)
      End If
    Catch ex As Exception

    End Try

  End Sub

  Public Sub UpdateArrowsForMatchDay(matchDay As ClassificationForMatchDay)
    Try
      If Not matchDay Is Nothing Then
        'to force the sort method to work
        For Each team As TeamClassificationForMatchDay In matchDay.TeamClassificationList
          team.Position = 1
        Next
        BreakTies(matchDay.TeamClassificationList, 0)

        'Me.Sort(matchDay.TeamClassificationList, eSortField.Points)
        Dim mDayFormer As ClassificationForMatchDay = Me.GetClassificationForMatchDay(matchDay.MatchDay - 1)
        If mDayFormer Is Nothing Then
          For Each team As TeamClassificationForMatchDay In matchDay.TeamClassificationList
            team.PositionChange = TeamClassificationForMatchDay.ePositionChange.Equal
            team.FormerPosition = team.Position
          Next
        Else
          For Each teamClass As TeamClassificationForMatchDay In matchDay.TeamClassificationList
            Dim formerTeamClass As TeamClassificationForMatchDay = mDayFormer.getTeamClassificationForMatchDay(teamClass.Team.TeamID)
            If formerTeamClass Is Nothing Then
              teamClass.PositionChange = TeamClassificationForMatchDay.ePositionChange.Equal
              teamClass.FormerPosition = teamClass.Position
            Else
              teamClass.FormerPosition = formerTeamClass.Position
              If teamClass.Position > formerTeamClass.Position Then
                teamClass.PositionChange = TeamClassificationForMatchDay.ePositionChange.Down
              ElseIf teamClass.Position < formerTeamClass.Position Then
                teamClass.PositionChange = TeamClassificationForMatchDay.ePositionChange.Up
              Else
                teamClass.PositionChange = TeamClassificationForMatchDay.ePositionChange.Equal
              End If
            End If
          Next
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region

#Region "Team functions"
  Public Function GetMatchesBetweenTeams(team1 As Team, team2 As Team) As Matches
    Dim res As New Matches
    Try
      res = GetMatchesBetweenTeams(team1.TeamID, team2.TeamID)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchesBetweenTeams(team1Id As Integer, team2Id As Integer) As Matches
    Dim res As New Matches
    Try
      For Each match As Match In Me.Matches
        If (match.HomeTeam.TeamID = team1Id And match.AwayTeam.TeamID = team2Id) Or (match.HomeTeam.TeamID = team2Id And match.AwayTeam.TeamID = team1Id) Then
          res.Add(match)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchesForTeam(team As Team) As Matches
    Dim res As New Matches
    Try
      res = Me.GetMatchesForTeam(team.TeamID)
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetMatchesForTeam(teamID As Integer) As Matches
    Dim res As New Matches
    Try
      For Each match As Match In Me.Matches
        If match.HomeTeam.TeamID = teamID Or match.AwayTeam.TeamID = teamID Then
          res.Add(match)
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
      'For i As Integer = matches.Count To 2 * (_teams.Count - 1)
      '  'for the rest of the league, add an empty match!
      '  current = UpdateClassification(team, i, Nothing, former)
      '  former = current
      '  res.ClassificationsForMatchDay.Add(current)
      'Next
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


#Region "sort classificatin methods"
  Private _sortFields() As eSortField = {eSortField.Points, eSortField.Wins, eSortField.Draws, eSortField.GoalAverage, eSortField.GoalsScored, eSortField.HeadToHead}
  Private _inverseSortFields() As eSortField = {eSortField.Position, eSortField.FormerPosition, eSortField.Loses, eSortField.GoalsReceived}

  Public Sub Sort(classForMatchDay As ClassificationForMatchDay, sortField As eSortField)
    Try

      Me.Sort(classForMatchDay.TeamClassificationList, sortField)

      If classForMatchDay.TeamClassificationList.Count > 0 Then
        classForMatchDay.TeamClassificationList.Sort()
        Dim prevTeamClass As TeamClassificationForMatchDay = classForMatchDay.TeamClassificationList(0)
        Dim pos As Integer = 1
        prevTeamClass.Position = pos

        For i As Integer = 1 To classForMatchDay.TeamClassificationList.Count - 1
          If classForMatchDay.TeamClassificationList(i).Points <> prevTeamClass.Points Then
            classForMatchDay.TeamClassificationList(i).Position = pos
          Else
            classForMatchDay.TeamClassificationList(i).Position = prevTeamClass.Position
          End If
          prevTeamClass = classForMatchDay.TeamClassificationList(i)
          pos += 1
        Next

        'they are sorted by points, with all the ones with the same amount of points at the same position. let's break the ties
        prevTeamClass = classForMatchDay.TeamClassificationList(0)
        Dim tiedTeams As New List(Of TeamClassificationForMatchDay)
        tiedTeams.Add(prevTeamClass)
        For i As Integer = 1 To classForMatchDay.TeamClassificationList.Count - 1
          If classForMatchDay.TeamClassificationList(i).Points <> prevTeamClass.Points Then
            BreakTie(tiedTeams, sortField)
            tiedTeams.Clear()
          End If
          tiedTeams.Add(classForMatchDay.TeamClassificationList(i))
          prevTeamClass = classForMatchDay.TeamClassificationList(i)
          pos += 1
        Next
      End If
      Debug.Print("Sort done")
    Catch ex As Exception
    End Try
  End Sub

  Private Sub BreakTie(teams As List(Of TeamClassificationForMatchDay), sortFields As eSortField)
    Try
      If teams.Count <= 1 Then Exit Sub

      'now... let's get to work!
      Me.Sort(teams, sortFields)
    Catch ex As Exception
    End Try
  End Sub

  'Private Sub initsort(matchDay As ClassificationForMatchDay)
  '  Me.InitSort(matchDay.TeamClassificationList)
  'End Sub

  Private Sub Sort(teams As List(Of TeamClassificationForMatchDay), sortField As eSortField)
    Dim K As Long, Q As Long


    ' sort the array
    QuickSort(teams, 0, teams.Count - 1, sortField)

    ' print the sorted string to the immediate window
    Debug.Print(vbNewLine & "Sorted teams:")
    For K = 0 To teams.Count - 1
      Debug.Print(teams(K).ToString)
    Next K
  End Sub

  Public Enum eSortField
    Position = 0
    FormerPosition
    Points
    Wins
    Draws
    Loses
    GoalsScored
    GoalsReceived
    GoalAverage
    HeadToHead
  End Enum

  Private Function GetSortField(team As TeamClassificationForMatchDay, sortField As eSortField) As Integer
    Dim res As Integer = 0
    Try
      Select Case sortField
        Case eSortField.Position
          res = team.Position
        Case eSortField.FormerPosition
          res = team.FormerPosition
        Case eSortField.Draws
          res = team.MatchesDrawn
        Case eSortField.GoalAverage
          res = team.GoalAverage
        Case eSortField.GoalsScored
          res = team.GoalsFor
        Case eSortField.GoalsReceived
          res = team.GoalsAgainst
        Case eSortField.HeadToHead
          res = 0
        Case eSortField.Loses
          res = team.MatchesLost
        Case eSortField.Points
          res = team.Points
        Case eSortField.Wins
          res = team.MatchesWon
        Case Else
      End Select
    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Sub QuickSort(C As List(Of TeamClassificationForMatchDay), ByVal First As Long, ByVal Last As Long, sortField As eSortField)
    Dim Low As Long, High As Long
    Dim MidValue As TeamClassificationForMatchDay

    Low = First
    High = Last
    MidValue = C((First + Last) \ 2)

    Do
      While Me.GetSortField(C(Low), sortField) > Me.GetSortField(MidValue, sortField)
        Low = Low + 1
      End While

      While Me.GetSortField(C(High), sortField) < Me.GetSortField(MidValue, sortField)
        High = High - 1
      End While

      If Low <= High Then
        Swap(C(Low), C(High))
        Low = Low + 1
        High = High - 1
      End If
    Loop While Low <= High

    If First > High Then QuickSort(C, First, High, sortField)
    If Low > Last Then QuickSort(C, Low, Last, sortField)
  End Sub

  Private Sub Swap(ByRef A As TeamClassificationForMatchDay, ByRef B As TeamClassificationForMatchDay)
    Dim T As TeamClassificationForMatchDay

    T = A
    A = B
    B = T
  End Sub
#End Region

#Region "QuickSort"
  Private Sub Test_QuickSort(matchDayClass As List(Of TeamClassificationForMatchDay), sortField As eSortField)
    Dim K As Long, Q As Long

    ' sort the array
    QuickSortValues(matchDayClass, 0, matchDayClass.Count - 1, sortField)
  End Sub

  Private Sub QuickSortValues(C As List(Of TeamClassificationForMatchDay), ByVal First As Long, ByVal Last As Long, sortField As eSortField)
    Dim Low As Long, High As Long
    Dim MidValue As TeamClassificationForMatchDay

    Low = First
    High = Last
    MidValue = C((First + Last) \ 2)

    Do
      If _inverseSortFields.Contains(sortField) Then
        While Me.GetSortField(C(Low), sortField) < Me.GetSortField(MidValue, sortField)
          Low = Low + 1
        End While

        While Me.GetSortField(C(High), sortField) > Me.GetSortField(MidValue, sortField)
          High = High - 1
        End While
      Else
        While Me.GetSortField(C(Low), sortField) > Me.GetSortField(MidValue, sortField)
          Low = Low + 1
        End While

        While Me.GetSortField(C(High), sortField) < Me.GetSortField(MidValue, sortField)
          High = High - 1
        End While
      End If

      If Low <= High Then
        SwapValues(C(Low), C(High))
        Low = Low + 1
        High = High - 1
      End If
    Loop While Low <= High

    If First < High Then QuickSortValues(C, First, High, sortField)
    If Low < Last Then QuickSortValues(C, Low, Last, sortField)
  End Sub

  Private Sub SwapValues(ByRef A As TeamClassificationForMatchDay, ByRef B As TeamClassificationForMatchDay)
    Dim T As TeamClassificationForMatchDay

    T = A
    A = B
    B = T
  End Sub
#End Region
End Class
