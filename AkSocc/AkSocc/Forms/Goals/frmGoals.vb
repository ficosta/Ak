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
        ' goals.Sort()
        For Each goal As MatchGoal In goals
          Dim item As Integer = .Rows.Add(goal.GoalID)
          '.Rows(item).Cells(ColumnInPlayer.Index).Value = subst.PlayerIn.ToString
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

#End Region
End Class