Imports MatchInfo

Public Class OptaTeamViewer

  Private WithEvents _team As Team
  Public Property Team As Team
    Get
      Return _team
    End Get
    Set(value As Team)
      _team = value
      ShowMatch()
    End Set
  End Property

  Public Sub ShowMatch()
    If Me.InvokeRequired Then
      Me.Invoke(New MethodInvoker(AddressOf ShowMatch))
    Else
      Try
        Me.LabelTeamName.Text = _team.OptaName
        Me.LabelScore.Text = _team.optaScore

        Me.MetroGridStats.Rows.Clear()

        For Each player As Player In _team.MatchPlayers
          AddPlayerToGrid(player)
        Next
        AddTeamToGrid(_team)

      Catch ex As Exception

      End Try
    End If

  End Sub

  Private Sub AddTeamToGrid(team As Team)
    Try
      With Me.MetroGridStats

        Dim row As Integer = 0
        .Rows.Insert(row, "") ' .Rows.Add("")

        .Rows(row).Cells(ColumnTeamID.Index).Value = team.OptaID
        .Rows(row).Cells(ColumnPlayerID.Index).Value = ""
        .Rows(row).Cells(ColumnName.Index).Value = team.OptaName
        .Rows(row).Cells(ColumnStat0.Index).Value = "Stats"
        For i As Integer = 0 To team.optaStatValueNames.Count - 1
          AddStatToGrid(row, team.optaStatValueNames(i), team.optaStatValues(i))
        Next
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub AddPlayerToGrid(player As Player)
    Try
      With Me.MetroGridStats
        Dim row As Integer = .Rows.Add("")
        .Rows(row).Cells(ColumnTeamID.Index).Value = player.optaTeamID
        .Rows(row).Cells(ColumnPlayerID.Index).Value = player.PlayerID
        .Rows(row).Cells(ColumnPlayerOpdaID.Index).Value = player.optaID
        .Rows(row).Cells(ColumnPlayerNumber.Index).Value = player.OptaSquadNumber
        .Rows(row).Cells(ColumnName.Index).Value = player.optaName
        .Rows(row).Cells(ColumnStat0.Index).Value = "Stats"
        For i As Integer = 0 To player.optaStatValueNames.Count - 1
          AddStatToGrid(row, player.optaStatValueNames(i), player.optaStatValues(i))
        Next
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub AddStatToGrid(row As Integer, name As String, value As String)
    Try
      Dim found As Boolean = False
      With Me.MetroGridStats
        For col As Integer = ColumnStat0.Index To .ColumnCount - 1
          If .Columns(col).Name = name Then
            .Rows(row).Cells(col).Value = value
            found = True
            Exit For
          End If
        Next
        If found = False Then
          Dim col As Integer = .Columns.Add(name, name)
          .Columns(col).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
          .Rows(row).Cells(col).Value = value
        End If

      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonEditTeam_Click(sender As Object, e As EventArgs) Handles ButtonEditTeam.Click
    Try
      Dim dlg As New frmOptaPlayerLink
      dlg.OptaTeam = _team
      dlg.ShowDialog(Me)
    Catch ex As Exception

    End Try
  End Sub
End Class
