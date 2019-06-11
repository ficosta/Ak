Imports MatchInfo

Namespace Tuboc
  Public Class ExtraInfo
    Inherits Tuboc.Graphic

    Private _showStreamData As Boolean = False

    Public Sub New()
      Me.Scene = New VizCommands.Scene
      Me.Scene.SceneName = "EXTRA_INFO"
      Me.Scene.VizLayer = VizCommands.SceneLayer.Middle
      Me.Scene.SceneDirectorsIn.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueNormal)
      Me.Scene.SceneDirectorsOut.Add("DIR_IN_OUT", 0, VizCommands.DirectorAction.ContinueReverse)
    End Sub

    Public Sub New(showStreamData As Boolean)
      Me.New
      _showStreamData = showStreamData
    End Sub

    Public Overrides Sub PrepareGraphic(match As Match, graphicData As GraphicData)
      Try
        Me.Scene.SceneLevel = 0
        'Me.Scene.SceneTargetDevices.Clear()

        If _showStreamData Then
          PrepareGraphicWithEngineData()
        Else
          Me.Scene.SceneParameters.Add("title", "<%device%>")

          'For i As Integer = 1 To 4
          '  Me.Scene.SceneParameters.Add("subject_0" & i & "_number", "number")
          '  Me.Scene.SceneParameters.Add("subject_0" & i & "_name", "name " & i)
          '  Me.Scene.SceneParameters.Add("subject_0" & i & "_team_short", "team " & i)

          '  Me.Scene.SceneParameters.Add("subject_0" & i & "_data_01", i)
          'Next

          Me.Scene.SceneParameters.Add("subject_01_number", "")
          Me.Scene.SceneParameters.Add("subject_01_name", "athletics")
          Me.Scene.SceneParameters.Add("subject_01_team_short", "ATHLETICS")
          Me.Scene.SceneParameters.Add("subject_01_data_01", "")

          Me.Scene.SceneParameters.Add("subject_02_number", "")
          Me.Scene.SceneParameters.Add("subject_02_name", "men's final")
          Me.Scene.SceneParameters.Add("subject_02_team_short", "MEN'S FINAL")
          Me.Scene.SceneParameters.Add("subject_02_data_01", "")

          Me.Scene.SceneParameters.Add("subject_03_number", "")
          Me.Scene.SceneParameters.Add("subject_03_name", "results")
          Me.Scene.SceneParameters.Add("subject_03_team_short", "RESULTS")
          Me.Scene.SceneParameters.Add("subject_03_data_01", "")

          Me.Scene.SceneParameters.Add("subject_04_number", "")
          Me.Scene.SceneParameters.Add("subject_04_name", "finish")
          Me.Scene.SceneParameters.Add("subject_04_team_short", "FINISH")
          Me.Scene.SceneParameters.Add("subject_04_data_01", "")
        End If

      Catch ex As Exception

      End Try
    End Sub

    Private Sub PrepareGraphicWithEngineData()
      Try
        Me.Scene.SceneLevel = 0
        'Me.Scene.SceneTargetDevices.Clear()

        Me.Scene.SceneParameters.Add("title", "<%device%>")

        Me.Scene.SceneParameters.Add("subject_01_number", "")
        Me.Scene.SceneParameters.Add("subject_01_name", "streamid")
        Me.Scene.SceneParameters.Add("subject_01_team_short", "<%stream%>")
        Me.Scene.SceneParameters.Add("subject_01_data_01", "")

        Me.Scene.SceneParameters.Add("subject_02_number", "")
        Me.Scene.SceneParameters.Add("subject_02_name", "level")
        Me.Scene.SceneParameters.Add("subject_02_team_short", "<%level%>")
        Me.Scene.SceneParameters.Add("subject_02_data_01", "")

        Me.Scene.SceneParameters.Add("subject_03_number", "")
        Me.Scene.SceneParameters.Add("subject_03_name", "language")
        Me.Scene.SceneParameters.Add("subject_03_team_short", "<%language%>")
        Me.Scene.SceneParameters.Add("subject_03_data_01", "")

        Me.Scene.SceneParameters.Add("subject_04_number", "")
        Me.Scene.SceneParameters.Add("subject_04_name", "machine")
        Me.Scene.SceneParameters.Add("subject_04_team_short", "<%machine%>")
        Me.Scene.SceneParameters.Add("subject_04_data_01", "")
      Catch ex As Exception

      End Try
    End Sub

    Public Overrides Function ICanDothis(graphicData As GraphicData) As Boolean
      Return True
    End Function
  End Class

End Namespace
