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

        'Me.MetroGridStats.Rows.Clear()
        AddTeamToGrid(_team)
        For Each player As Player In _team.MatchPlayers
          AddPlayerToGrid(player)
        Next

      Catch ex As Exception

      End Try
    End If

  End Sub

  Private Sub AddTeamToGrid(team As Team)
    Try
      With Me.MetroGridStats

        Dim row As Integer = 0
        If .Rows.Count < 1 Then
          .Rows.Insert(row, "") ' .Rows.Add("")
        End If

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
        If .Columns.Count = 0 Then
          .Columns.Add("TeamID", "TeamID")
          .Columns.Add("ColumnPlayerID", "ColumnPlayerID")
          .Columns.Add("ColumnPlayerOpdaID", "ColumnPlayerOpdaID")
          .Columns.Add("ColumnPlayerNumber", "ColumnPlayerNumber")
          .Columns.Add("ColumnName", "ColumnName")
          .Columns.Add("ColumnStat0", "ColumnStat0")
        End If

        Dim row As Integer = -1
        For i As Integer = 0 To .Rows.Count - 1
          If .Rows(i).Cells(ColumnPlayerOpdaID.Index).Value = player.optaID Then
            row = i
          End If
        Next
        If row = -1 Then
          row = .Rows.Add("")
        End If

        .Rows(row).Cells(ColumnTeamID.Index).Value = player.optaTeamID
        .Rows(row).Cells(ColumnPlayerID.Index).Value = player.PlayerID
        .Rows(row).Cells(ColumnPlayerOpdaID.Index).Value = player.optaID
        .Rows(row).Cells(ColumnPlayerNumber.Index).Value = player.OptaSquadNumber
        .Rows(row).Cells(ColumnName.Index).Value = player.optaName
        .Rows(row).Cells(ColumnStat0.Index).Value = "Stats"
        For i As Integer = 0 To player.optaStatValues.Count - 1
          AddStatToGrid(row, player.optaStatValues(i).Name, player.optaStatValues(i).Value)
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
            Dim formerValue As String = NoNullString(.Rows(row).Cells(col).Value)
            formerValue = formerValue.Replace(">", "")
            formerValue = formerValue.Replace("<", "")
            If value <> formerValue Then
              .Rows(row).Cells(col).Value = ">" & value & "<"
            Else
              .Rows(row).Cells(col).Value = value
            End If
            found = True
            Exit For
          End If
        Next
        If found = False Then
          Dim col As Integer = .Columns.Add(name, name)
          .Columns(col).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
          .Rows(row).Cells(col).Value = ">" & value & "<"
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
