Imports MatchInfo

Namespace Tuboc
  Public Class _1Subject1Data
    Inherits Tuboc.Graphic

    Public Sub New()
      Me.Scene = New VizCommands.Scene
      Me.Scene.SceneName = "1_SUBJECT_1_DATA"
      Me.Scene.SceneDirectorsIn.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueNormal)
      Me.Scene.SceneDirectorsOut.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueReverse)
    End Sub

    Public Overrides Sub PrepareGraphic(match As Match, graphicData As GraphicData)
      Try
        If Not match Is Nothing Then
          Dim player As Player = CType(graphicData.Subjects(0), Player)
          Dim team As Team

          Select Case player.TeamID
            Case match.home_team_id
              team = match.HomeTeam
            Case match.away_team_id
              team = match.AwayTeam
          End Select

          Me.Scene.SceneParameters.Add("subject_01_number", player.DomesticSquadNo)
          Me.Scene.SceneParameters.Add("subject_01_name", player.Name)
          Me.Scene.SceneParameters.Add("subject_01_team_short", team.Name)


          Dim stat As Stat = player.GetMatchStatByName(graphicData.StatNames(0))
          If Not stat Is Nothing Then
            Me.Scene.SceneParameters.Add("data_01_name", stat.StatTitle)
            Me.Scene.SceneParameters.Add("subject_01_data_01", stat.ValueText)

          End If
          
        End If
      Catch ex As Exception

      End Try
    End Sub

    Public Overrides Function ICanDothis(graphicData As GraphicData) As Boolean
      Dim res As Boolean = False
      If graphicData.Subjects.Count = 1 And graphicData.StatNames.Count = 1 Then
        If graphicData.Subjects(0).GetType.ToString = "Player" Then
          res = True
        End If
      End If
      Return res
    End Function
  End Class

End Namespace
