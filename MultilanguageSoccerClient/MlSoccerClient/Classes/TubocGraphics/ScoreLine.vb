Imports MatchInfo

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
        Me.Scene.SceneTargetDevices.Add("VIZRT@MSI")
        Me.Scene.SceneTargetDevices.Clear()

        Me.Scene.SceneParameters.Add("title", "<%device%>")

        For i As Integer = 1 To 4
          Me.Scene.SceneParameters.Add("subject_0" & i & "_number", "number")
          Me.Scene.SceneParameters.Add("subject_01_name", "name " & i)
          Me.Scene.SceneParameters.Add("subject_01_team_short", "team " & i)

          Me.Scene.SceneParameters.Add("subject_0" & i & "_data_01", i)
        Next
      Catch ex As Exception

      End Try
    End Sub

    Public Overrides Function ICanDothis(graphicData As GraphicData) As Boolean
      Return True
    End Function
  End Class

End Namespace
