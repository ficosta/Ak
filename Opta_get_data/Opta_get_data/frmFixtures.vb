Imports System.IO
Imports System.Net
Imports MatchInfo
Imports MetroFramework.Controls

Public Class frmFixtures
  Private _f1Helper As COptaF1Helper
  Private WithEvents _matches As MatchInfo.Matches
  Private _localTeams As Teams


  Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
    Try
      If Me.OpenFileDialogXML.ShowDialog() = DialogResult.OK Then
        Me.ToolStripButtonRefresh.Enabled = False
        _matches = New Matches
        _f1Helper = New COptaF1Helper(Me.OpenFileDialogXML.FileName, _matches)
        _f1Helper.Update()
        _localTeams = New Teams()
        _localTeams.GetFromDB("")
        ' _f9Helper.InitializeData()
        UpdateInfo()
        Me.ToolStripButtonRefresh.Enabled = True
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateInfo()
    Try
      _f1Helper.Update()
      ShowMatches()
      ShowTeams()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ToolStripButtonRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRefresh.Click
    UpdateInfo()
  End Sub

  Private Sub ShowMatches()
    Try
      With Me.MetroGridMatches
        .Rows.Clear()

        For Each match As Match In _f1Helper.Matches
          Dim row As Integer = .Rows.Add("")
          .Rows(row).Cells(ColumnMatchesID.Index).Value = match.match_id
          .Rows(row).Cells(ColumnMatchesOptaID.Index).Value = match.optaID
          .Rows(row).Cells(ColumnMatchesState.Index).Value = match.state
          If match.state = "PreMatch" Then
            .Rows(row).Cells(ColumnMatchesScore.Index).Value = "X"
          Else
            .Rows(row).Cells(ColumnMatchesScore.Index).Value = match.optaHomeScore & "-" & match.optaAwayScore
          End If
          If Not match.HomeTeam Is Nothing Then .Rows(row).Cells(ColumnHomeTeam.Index).Value = match.HomeTeam.OptaName
          If Not match.AwayTeam Is Nothing Then .Rows(row).Cells(ColumnAwayTeam.Index).Value = match.AwayTeam.OptaName
        Next
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowTeams()
    ShowTeams(Me.MetroGridTeamsOpta, _f1Helper.Teams)
    ShowTeams(Me.MetroGridTeamsLocal, _localTeams)
  End Sub

  Private Sub ShowTeams(grid As MetroGrid, teams As Teams)
    Try
      With grid
        .Rows.Clear()

        For Each team As Team In teams
          Dim row As Integer = .Rows.Add("")
          .Rows(row).Cells(ColumnTeamID.Index).Value = team.TeamID
          .Rows(row).Cells(ColumnTeamName.Index).Value = team.OptaName
          .Rows(row).Cells(ColumnTeamOptaID.Index).Value = team.OptaID
        Next
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub frmFixtures_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    With Me.MetroGridMatches
      For i As Integer = 1 To 10
        .Rows.Add("Item " & i)
      Next

      .MultiSelect = False
      For row As Integer = 0 To .Rows.Count - 1
        .Rows(row).Selected = False
      Next
      .Rows(5).Selected = True
    End With
  End Sub
End Class
