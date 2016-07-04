Imports MatchInfo

Public Class frmGoals
  Private _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      ShowGoals()
    End Set
  End Property

#Region "Functions"

  Private _initializing As Boolean = False
  Private _substitution As Substitution = Nothing

  Private Sub ShowGoals(Optional selected As MatchGoal = Nothing)
    Try
      _initializing = True
      With Me.MetroGridGoals
        .Rows.Clear()
        Dim goals As MatchGoals = _match.MatchGoals
        goals.Sort()
        For Each goal As MatchGoal In goals
          Dim item As Integer = .Rows.Add(CStr(goal.GoalID))
          Dim team As Team = IIf(_match.HomeTeam.ID = goal.TeamGoalID, _match.HomeTeam, _match.AwayTeam)
          .Rows(item).Cells(ColumnTime.Index).Value = FormatRunningTime(goal.Minute) '(goal.Minute \ 60) & ":" & Strings.Format(goal.Minute Mod 60, "00")
          If _match.HomeTeam.ID = goal.TeamGoalID Then
            team = _match.HomeTeam
            Dim player As Player = IIf(goal.PlayerID <> 0, team.GetPlayerById(goal.PlayerID), Nothing)
            .Rows(item).Cells(ColumnHomeGoal.Index).Value = "goal"
            .Rows(item).Cells(ColumnHomeType.Index).Value = goal.GoalType.ToString
            If Not player Is Nothing Then
              .Rows(item).Cells(ColumnHomePlayer.Index).Value = player.ToString
            Else
              .Rows(item).Cells(ColumnHomePlayer.Index).Value = ""
            End If
            .Rows(item).Cells(ColumnAwayGoal.Index).Value = ""
            .Rows(item).Cells(ColumnAwayPlayer.Index).Value = ""
            .Rows(item).Cells(ColumnAwayType.Index).Value = ""
          Else
            team = _match.AwayTeam
            Dim player As Player = IIf(goal.PlayerID <> 0, team.GetPlayerById(goal.PlayerID), Nothing)
            .Rows(item).Cells(ColumnAwayGoal.Index).Value = "goal"
            .Rows(item).Cells(ColumnAwayType.Index).Value = goal.GoalType.ToString
            If Not player Is Nothing Then
              .Rows(item).Cells(ColumnAwayPlayer.Index).Value = player.ToString
            Else
              .Rows(item).Cells(ColumnAwayPlayer.Index).Value = ""
            End If
            .Rows(item).Cells(ColumnHomeGoal.Index).Value = ""
            .Rows(item).Cells(ColumnHomePlayer.Index).Value = ""
            .Rows(item).Cells(ColumnHomeType.Index).Value = ""
          End If
          '.Rows(item).Cells(ColumnOutPlayer.Index).Value = subst.PlayerOut.ToString
          '.Rows(item).Cells(ColumnTeam.Index).Value = subst.Team.ToString
          '.Rows(item).Cells(ColumnTime.Index).Value = subst.part & "p " & subst.timeInSeconds & "s"
          '.Rows(item).Cells(ColumnPlayerInID.Index).Value = subst.PlayerIn.PlayerID
          '.Rows(item).Cells(ColumnPlayerOutID.Index).Value = subst.PlayerOut.PlayerID
          'If Not _substitution Is Nothing Then
          '  .Rows(item).Selected = (subst.ToString = _substitution.ToString)
          'Else
          '  .Rows(item).Selected = False
          'End If
        Next
      End With
      'ShowSelecteSubstitiution()
    Catch ex As Exception

    End Try
    _initializing = False
  End Sub

  Private Sub MetroGridGoals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridGoals.CellDoubleClick
    Try
      Dim goal As MatchGoal
      goal = Me.Match.MatchGoals.GetGoal(CInt(MetroGridGoals.Rows(e.RowIndex).Cells(ColumnID.Index).Value))
      If Not goal Is Nothing Then
        Dim frm As New frmGoal(Me.Match, goal)
        If frm.ShowDialog(Me) = DialogResult.OK Then
          'do something
          Me.ShowGoals()
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class