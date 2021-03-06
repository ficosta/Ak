﻿Imports MatchInfo

Namespace Tuboc
  Public Class ScoreLine
    Inherits Tuboc.Graphic

    Public Sub New()
      Me.Scene = New VizCommands.Scene
      Me.Scene.SceneName = "SCORE_MAIN"
      Me.Scene.SceneDirectorsIn.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueNormal)
      Me.Scene.SceneDirectorsOut.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueReverse)
    End Sub

    Public Overrides Sub PrepareGraphic(match As Match, graphicData As GraphicData)
      Try

        Me.Scene.SceneLevel = 1


        If Not match Is Nothing Then
          Me.Scene.SceneParameters.Add("home_team_name", match.HomeTeam.Name)
          Me.Scene.SceneParameters.Add("home_team_score", match.home_goals)

          Me.Scene.SceneParameters.Add("away_team_name", match.AwayTeam.Name)
          Me.Scene.SceneParameters.Add("away_team_score", match.away_goals)

          Me.Scene.SceneParameters.Add("match_state", match.state)
        End If
      Catch ex As Exception

      End Try
    End Sub

    Public Overrides Function ICanDothis(graphicData As GraphicData) As Boolean
      Return True
    End Function
  End Class

End Namespace
