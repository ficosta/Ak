Imports System.IO
Imports System.Net
Imports MatchInfo

Public Class frmMatchInfo
  Private _f9Helper As COptaF9Helper
  Private WithEvents _match As MatchInfo.Match

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

  Private Sub ShowMatch()
    Try
      Me.OptaTeamViewerHomeTeam.Team = _match.HomeTeam
      Me.OptaTeamViewerAwayTeam.Team = _match.AwayTeam
    Catch ex As Exception

    End Try
  End Sub

  Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
    Try
      If Me.OpenFileDialogXML.ShowDialog() = DialogResult.OK Then
        Me.ToolStripButtonRefresh.Enabled = False
        _match = New Match
        _f9Helper = New COptaF9Helper(Me.OpenFileDialogXML.FileName, _match)
        _f9Helper.PreviewMatchInfo(True)
        ' _f9Helper.InitializeData()
        UpdateInfo()
        Me.ToolStripButtonRefresh.Enabled = True
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateInfo()
    Try
      _f9Helper.UpdateValors()
      ShowMatch()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ToolStripButtonRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRefresh.Click
    UpdateInfo()
  End Sub
End Class
