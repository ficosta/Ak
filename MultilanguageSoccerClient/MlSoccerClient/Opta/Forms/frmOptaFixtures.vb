Imports System.IO
Imports System.Net
Imports MatchInfo
Imports MetroFramework.Controls


Public Class frmOptaFixtures
  Private _f1Helper As COptaF1Helper
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

  Public Property CompetitionId As Integer

  Private Sub UpdateInfo()
    Try
      _f1Helper.Update()
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
        For Each match As Match In _f1Helper.Matches
          If match.optaID > 0 Then
            Dim row As Integer = .Rows.Add("")
            .Rows(row).Cells(ColumnMatchesID.Index).Value = match.match_id
            .Rows(row).Cells(ColumnMatchesOptaID.Index).Value = match.optaID
            .Rows(row).Cells(ColumnMatchesState.Index).Value = match.state
            .Rows(row).Cells(ColumnMatchesMatchDay.Index).Value = match.matchday
            If match.state = "PreMatch" Then
              .Rows(row).Cells(ColumnMatchesScore.Index).Value = "X"
            Else
              .Rows(row).Cells(ColumnMatchesScore.Index).Value = match.optaHomeScore & "-" & match.optaAwayScore
            End If
            If Not match.HomeTeam Is Nothing Then .Rows(row).Cells(ColumnHomeTeam.Index).Value = match.HomeTeam.OptaName
            If Not match.AwayTeam Is Nothing Then .Rows(row).Cells(ColumnAwayTeam.Index).Value = match.AwayTeam.OptaName
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
      Dim file As String = "srml-" & AppSettings.Instance.OptaCompetitionID & "-" & AppSettings.Instance.OptaSeasonID & "-results.xml"
      file = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, file)
      _f1Helper = New COptaF1Helper(file, _matches)
      _f1Helper.Update()
      UpdateInfo()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    Try
      If Me.MetroGridMatches.SelectedRows.Count > 0 Then
        Dim optaID As Integer = Me.MetroGridMatches.SelectedRows(0).Cells(ColumnMatchesOptaID.Index).Value
        Me.MatchOptaID = optaID
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
      If Me.MetroGridMatches.SelectedRows.Count > 0 Then
        Dim row As Integer = Me.MetroGridMatches.SelectedRows(0).Index
        Dim optaID As Integer = Me.MetroGridMatches.Rows(row).Cells(ColumnMatchesOptaID.Index).Value
        Dim matchID As Integer = Me.MetroGridMatches.Rows(row).Cells(ColumnMatchesID.Index).Value

        Dim dlg As New frmLocalFixtures
        dlg.MatchID = matchID

        dlg.CompetitionId = Me.CompetitionId
        dlg.Matches = Matches.GetMatchesForCompetition(Me.CompetitionId)

        If dlg.ShowDialog(Me) = DialogResult.OK Then
          If dlg.MatchID > 0 Then
            Me.MetroGridMatches.Rows(row).Cells(ColumnMatchesID.Index).Value = dlg.MatchID
            Dim match As Match = _f1Helper.Matches.GetMatch(dlg.MatchID)
            match.optaID = optaID
            match.Update()
          End If
        End If
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub
End Class
