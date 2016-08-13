Imports System.IO
Imports System.Net
Imports MatchInfo
Imports MetroFramework.Controls


Public Class frmOptaTeams
  Private _f1Helper As COptaF1Helper
  Private WithEvents _matches As MatchInfo.Matches
  Private _localTeams As Teams


  Private Sub UpdateInfo()
    Try
      _f1Helper.Update()
      _localTeams = New Teams
      _localTeams.GetFromDB("")
      ShowTeams()
      UpdateLinkControls()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowTeams()
    ShowTeams(Me.MetroGridOpta, _f1Helper.Teams, True)
    ShowTeams(Me.MetroGridLocal, _localTeams, False)
  End Sub

  Private Sub ShowTeams(grid As MetroGrid, teams As Teams, isOpta As Boolean)
    Try
      With grid
        '.Rows.Clear()

        Dim mustShow As Boolean = False
        Dim row As Integer
        For Each team As Team In teams
          row = -1
          If isOpta Then
            mustShow = team.OptaID > 0
            For i As Integer = 0 To .Rows.Count - 1
              If .Rows(i).Cells(ColumnTeamOptaID.Index).Value = team.OptaID Then
                row = i
                Exit For
              End If
            Next
          Else
            mustShow = team.TeamID > 0
            For i As Integer = 0 To .Rows.Count - 1
              If .Rows(i).Cells(ColumnTeamID.Index).Value = team.TeamID Then
                row = i
                Exit For
              End If
            Next
          End If
          If mustShow Then
            If row = -1 Then row = .Rows.Add("")
            .Rows(row).Cells(ColumnTeamID.Index).Value = team.TeamID
            .Rows(row).Cells(ColumnTeamOptaName.Index).Value = team.OptaName
            .Rows(row).Cells(ColumnTeamName.Index).Value = team.TeamAELCaption1Name
            .Rows(row).Cells(ColumnTeamOptaID.Index).Value = team.OptaID
          End If
        Next
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub frmFixtures_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Dim file As String = "srml-" & AppSettings.Instance.OptaCompetitionID & "-" & AppSettings.Instance.OptaSeasonID & "-results.xml"
      file = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, file)
      _f1Helper = New COptaF1Helper(file, _matches)
      UpdateInfo()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "Link / unlink"
  Private _selectedOptaTeam As Team = Nothing
  Private _selectedLocalTeam As Team = Nothing

  Private Sub UpdateLinkControls()
    Try
      If Not _selectedLocalTeam Is Nothing And Not _selectedOptaTeam Is Nothing Then
        If _selectedLocalTeam.OptaID <> _selectedOptaTeam.OptaID Then
          Me.ButtonLink.Text = "Link"
        Else
          Me.ButtonLink.Text = "Break Link"
        End If
        Me.ButtonLink.Enabled = True
      Else
        Me.ButtonLink.Text = "-"
        Me.ButtonLink.Enabled = False
      End If
    Catch ex As Exception

    End Try

  End Sub

  Private Sub MetroGridTeamsOpta_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridOpta.SelectionChanged
    Try
      If Me.MetroGridOpta.SelectedRows.Count = 0 Then
        _selectedOptaTeam = Nothing
      Else
        Dim optaID As Integer = Me.MetroGridOpta.SelectedRows(0).Cells(ColumnTeamOptaID.Index).Value
        _selectedOptaTeam = _f1Helper.Teams.GetTeamByOptaID(optaID)
      End If

      Dim row As Integer = -1
      With Me.MetroGridLocal
        For i As Integer = 0 To .Rows.Count - 1
          If .Rows(i).Cells(ColumnTeamOptaID.Index).Value = _selectedOptaTeam.OptaID Then
            row = i
            Exit For
          End If
        Next
        If row <> -1 Then
          For i As Integer = 0 To .Rows.Count - 1
            .Rows(i).Selected = False
          Next

          .Rows(row).Selected = True
        End If
      End With

      Me.UpdateLinkControls()
    Catch ex As Exception
    End Try
  End Sub


  Private Sub MetroGridTeamsLocal_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridLocal.SelectionChanged
    Try
      If Me.MetroGridLocal.SelectedRows.Count = 0 Then
        _selectedLocalTeam = Nothing
      Else
        Dim teamID As Integer = Me.MetroGridLocal.SelectedRows(0).Cells(ColumnTeamID.Index).Value
        _selectedLocalTeam = _localTeams.GetTeam(teamID)
      End If
      Me.UpdateLinkControls()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ButtonLink_Click(sender As Object, e As EventArgs) Handles ButtonLink.Click
    Try
      If _selectedLocalTeam Is Nothing Or _selectedOptaTeam Is Nothing Then
        Exit Sub
      ElseIf _selectedLocalTeam.OptaID <> _selectedOptaTeam.OptaID Then
        For Each team As Team In _localTeams
          If team.OptaID = _selectedOptaTeam.OptaID Then
            team.OptaID = -1
            team.Update()
          End If
        Next
        _selectedLocalTeam.OptaID = _selectedOptaTeam.OptaID
        _selectedLocalTeam.Update()
        _selectedOptaTeam.TeamID = _selectedLocalTeam.TeamID
      Else
        _selectedLocalTeam.OptaID = 0
        _selectedLocalTeam.Update()
        _selectedOptaTeam.TeamID = 0
      End If
      Me.ShowTeams()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridOpta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridOpta.CellDoubleClick
    Try
      If Not _selectedLocalTeam Is Nothing And Not _selectedOptaTeam Is Nothing Then
        Dim dlg As New frmOptaPlayerLink
        dlg.LocalTeam = _selectedLocalTeam
        dlg.OptaTeam = _selectedOptaTeam
        dlg.ShowDialog(Me)
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
