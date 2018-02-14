Imports System.IO
Imports System.Net
Imports MatchInfo

Public Class frmOptaMatchStats
  Private WithEvents _f9Helper As COptaF9Helper
  Public Property f9Helper As COptaF9Helper
    Get
      Return _f9Helper
    End Get
    Set(value As COptaF9Helper)
      _f9Helper = value
      Me.MatchOpta = _f9Helper.Match
      ShowMatch()
    End Set
  End Property

  Private WithEvents _match As MatchInfo.Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      ShowMatch()
    End Set
  End Property

  Private WithEvents _matchOpta As MatchInfo.Match
  Public Property MatchOpta As Match
    Get
      Return _matchOpta
    End Get
    Set(value As Match)
      _matchOpta = value
    End Set
  End Property

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
      Me.OptaTeamViewerHomeTeam.Team = _matchOpta.HomeTeam
      Me.OptaTeamViewerAwayTeam.Team = _matchOpta.AwayTeam
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

  Private Sub ToolStripButtonRefresh_Click(sender As Object, e As EventArgs)
    UpdateInfo()
  End Sub

  Private Sub frmOptaMatchStats_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      If _match Is Nothing Then Exit Sub
      If _f9Helper Is Nothing Then Exit Sub

      _f9Helper.PreviewMatchInfo(True)
      ' _f9Helper.InitializeData()
      UpdateInfo()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub frmOptaMatchStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub _f9Helper_Updated() Handles _f9Helper.Updated
    If Me.InvokeRequired Then
      Me.Invoke(New MethodInvoker(AddressOf _f9Helper_Updated))
    Else
      Me.OptaTeamViewerHomeTeam.ShowMatch()
      Me.OptaTeamViewerAwayTeam.ShowMatch()
      Me.LabelState.Text = "Last update: " & Now.ToString
    End If
  End Sub
End Class
