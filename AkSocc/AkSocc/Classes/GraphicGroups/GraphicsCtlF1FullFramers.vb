Imports AkSocc
Imports VizCommands

Public Class GraphicGroupCtlF1FullFramers
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCtlF1FullFramers"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly MatchIdent As Step0 = New Step0("League comparison")
    Public Shared ReadOnly LeagueTableTop As Step0 = New Step0("League table top")
    Public Shared ReadOnly LeagueTableBottom As Step0 = New Step0("League table bottom")
    Public Shared ReadOnly OtherMatchScores As Step0 = New Step0("Other match scores")
    Public Shared ReadOnly FullFrameStats As Step0 = New Step0("Full frame stats")
    Public Shared ReadOnly LeagueComparison As Step0 = New Step0("League comparison")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class


  Class StepArrows
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Arrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Arrows")
    Public Shared ReadOnly NoArrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No arrows")
  End Class


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueTableTop))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueTableBottom))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.OtherMatchScores, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullFrameStats, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueComparison, True, False))
      Else
        Select Case graphicStep.Depth
          Case 0
            Select Case graphicStep.Name
              Case Step0.LeagueTableTop, Step0.LeagueTableBottom
                gs.GraphicSteps.Add(New GraphicStep(gs, StepArrows.Arrows, True, True))
                gs.GraphicSteps.Add(New GraphicStep(gs, StepArrows.NoArrows, True, True))
            End Select

        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = New Scene
    Dim gs As GraphicStep = graphicStep.RootGraphicStep
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "cfx_Full_Frame_Work"
      Scene.SceneDirector = "DIR_MAIN"

      Select Case gs.ChildGraphicStep.Name
        Case Step0.LeagueTableTop
          Scene = PrepareLeagueTable(1, True)
        Case Step0.OtherMatchScores
          Scene = PrepareLeagueTable(1, True)
        Case Step0.LeagueTableBottom
          Scene = PrepareLeagueTable(1, False)
        Case Step0.FullFrameStats
        Case Step0.LeagueComparison
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"
  Private Function InitDefaultScene() As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "cfx_Full_Frame_Work"
    scene.SceneDirector = "anim_Full_Frame$In_Out"

    Return scene
  End Function
  Public Function PrepareMatchIdent(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 0)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareTeamList(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 0)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareDoubleTeams(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareLeagueTable(gStep As Integer, isTop As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 2)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareMatchScores(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 3)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareFormation(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 4)
    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
