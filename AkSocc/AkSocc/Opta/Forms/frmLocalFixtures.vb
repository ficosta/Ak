Imports System.IO
Imports System.Net
Imports MatchInfo
Imports MetroFramework.Controls


Public Class frmLocalFixtures

  Public Property CompetitionId As Integer

  Private WithEvents _matches As MatchInfo.Matches
  Public Property Matches As Matches
    Get
      Return _matches
    End Get
    Set(value As Matches)
      _matches = value
    End Set
  End Property

  Public Property MatchID As Integer
  Public Property MatchOptaID As Integer

  Private Sub UpdateInfo()
    Try
      ShowMatches()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ShowMatches()
    Try
      With Me.MetroGridMatches
        .Rows.Clear()
        Dim selectedRow As Integer = 0
        For Each match As Match In Me.Matches
          If match.match_id > 0 Then
            Dim row As Integer = .Rows.Add("")
            .Rows(row).Cells(ColumnMatchesID.Index).Value = match.match_id
            .Rows(row).Cells(ColumnMatchesOptaID.Index).Value = match.optaID
            .Rows(row).Cells(ColumnMatchesState.Index).Value = match.state
            .Rows(row).Cells(ColumnMatchesMatchDay.Index).Value = match.matchday
            If match.home_goals = -1 Then
              .Rows(row).Cells(ColumnMatchesScore.Index).Value = "X"
            Else
              .Rows(row).Cells(ColumnMatchesScore.Index).Value = match.home_goals & "-" & match.away_goals
            End If
            If Not match.HomeTeam Is Nothing Then .Rows(row).Cells(ColumnHomeTeam.Index).Value = match.HomeTeam.TeamAELCaption1Name
            If Not match.AwayTeam Is Nothing Then .Rows(row).Cells(ColumnAwayTeam.Index).Value = match.AwayTeam.TeamAELCaption1Name
            If match.optaID = Me.MatchOptaID Then
              .Rows(row).Selected = True
              selectedRow = row
            Else
              .Rows(row).Selected = False
            End If
          End If
        Next
        EnsureRowIsVisible(Me.MetroGridMatches, selectedRow)
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub frmFixtures_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try

      UpdateInfo()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    Try
      If Me.MetroGridMatches.SelectedRows.Count > 0 Then
        Dim matchID As Integer = Me.MetroGridMatches.SelectedRows(0).Cells(ColumnMatchesID.Index).Value
        Me.MatchID = matchID
        Me.DialogResult = DialogResult.OK
        Me.Close()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Try
      Me.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ButtonEditTeamLinks_Click(sender As Object, e As EventArgs) Handles ButtonEditTeamLinks.Click
    Try
      Dim dlg As New frmOptaTeams()
      dlg.ShowDialog(Me)
      Me.UpdateInfo()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridMatches_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridMatches.CellDoubleClick
    Try
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub
End Class
