Imports MatchInfo

Public Class FormSubstitutions
  Private _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      ShowSubstitutions
    End Set
  End Property

  Private _initializing As Boolean = False
  Private _substitution As Substitution = Nothing

  Private Sub ShowSubstitutions(Optional selected As Substitution = Nothing)
    Try
      _initializing = True
      With Me.MetroGridSubstitutions
        .Rows.Clear()
        Dim substitutions As Substitutions = _match.Substitutions
        substitutions.Sort()
        For Each subst As Substitution In substitutions
          Dim item As Integer = .Rows.Add(subst.PlayerIn.Name)
          .Rows(item).Cells(ColumnInPlayer.Index).Value = subst.PlayerIn.ToString
          .Rows(item).Cells(ColumnOutPlayer.Index).Value = subst.PlayerOut.ToString
          .Rows(item).Cells(ColumnTeam.Index).Value = subst.Team.TeamAELCaption1Name
          .Rows(item).Cells(ColumnTime.Index).Value = subst.part & "p " & subst.timeInSeconds & "s"
          .Rows(item).Cells(ColumnPlayerInID.Index).Value = subst.PlayerIn.PlayerID
          .Rows(item).Cells(ColumnPlayerOutID.Index).Value = subst.PlayerOut.PlayerID
          If Not _substitution Is Nothing Then
            .Rows(item).Selected = (subst.ToString = _substitution.ToString)
          Else
            .Rows(item).Selected = False
          End If
        Next
      End With
      ShowSelecteSubstitiution()
    Catch ex As Exception

    End Try
    _initializing = False
  End Sub

#Region "Buttons"
  Private Sub MetroButtonAddHomeTeamSubstitition_Click(sender As Object, e As EventArgs) Handles MetroButtonAddHomeTeamSubstitition.Click
    Me.AddSubstitution(_match.AwayTeam)
  End Sub

  Private Sub MetroButtonRemoveSubstitution_Click(sender As Object, e As EventArgs) Handles MetroButtonRemoveSubstitution.Click

  End Sub

  Private Sub MetroButtonAddAwayTeamSubstitition_Click(sender As Object, e As EventArgs) Handles MetroButtonAddAwayTeamSubstitition.Click
    Me.AddSubstitution(_match.HomeTeam)
  End Sub

  Private Function AddSubstitution(team As Team) As Substitution
    Try
      Dim dlg As New FormSubstitution()
      dlg.Team = team
      If dlg.ShowDialog(Me) = DialogResult.OK Then
        Dim subs As New Substitution() With {.Team = team, .PlayerIn = dlg.PlayerIn, .PlayerOut = dlg.PlayerOut, .part = _match.MatchPeriods.ActivePeriod.Part, .timeInSeconds = _match.MatchPeriods.ActivePeriod.PlayingTime}
        Dim aux As Integer = subs.PlayerIn.Formation_Pos
        subs.PlayerIn.Formation_Pos = subs.PlayerOut.Formation_Pos
        subs.PlayerOut.Formation_Pos = aux
        _substitution = subs
        Me.ShowSubstitutions()
        ' _match.CreateEvent("substitution", team.TeamID, subs.PlayerIn.PlayerID, _match.MatchPeriods.ActivePeriod.PlayingTime, subs.PlayerOut.PlayerID)
        subs.PlayerIn.IsSubstitution = True
        subs.PlayerOut.IsSubstitution = True
        team.AddSubstitution(subs)
        Me.ShowSubstitutions()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Nothing
  End Function

  Private Sub FormSubstitutions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ShowSelecteSubstitiution
  End Sub

  Private Sub MetroButtonShowSelectedSubstitution_Click(sender As Object, e As EventArgs) Handles MetroButtonShowSelectedSubstitution.Click
    If _substitution Is Nothing Then Exit Sub
    Try
      Dim graphic As New ClockSubstitution()
      graphic.ShowSubstitution(_substitution)
      'frmWaitForInput.ShowWaitDialog(Me, "Waiting")
      'graphic.HideSubstitution()

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub

  Private Sub MetroGridSubstitutions_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridSubstitutions.SelectionChanged
    If _initializing Then Exit Sub
    Dim inID As Integer = CType(Me.MetroGridSubstitutions.Rows(Me.MetroGridSubstitutions.SelectedRows(0).Index).Cells(ColumnPlayerInID.Index).Value, Integer)
    Dim outID As Integer = CType(Me.MetroGridSubstitutions.Rows(Me.MetroGridSubstitutions.SelectedRows(0).Index).Cells(ColumnPlayerOutID.Index).Value, Integer)
    _substitution = _match.Substitutions.GetSubstitutionByPlayers(inID, outID)

    ShowSelecteSubstitiution()
  End Sub

  Private Sub ShowSelecteSubstitiution()

    If Not _substitution Is Nothing Then
      Me.MetroButtonShowSelectedSubstitution.Text = _substitution.ToString
      Me.MetroButtonShowSelectedSubstitution.Enabled = True
    Else
      Me.MetroButtonShowSelectedSubstitution.Text = "Nothing to show"
      Me.MetroButtonShowSelectedSubstitution.Enabled = False
    End If
  End Sub
#End Region
End Class