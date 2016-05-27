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

    Public Shared ReadOnly LeagueTableTop As Step0 = New Step0("First half")
    Public Shared ReadOnly LeagueTableBottom As Step0 = New Step0("Half time")
    Public Shared ReadOnly OtherMatchScores As Step0 = New Step0("Second half")
    Public Shared ReadOnly FullFrameStats As Step0 = New Step0("Full time")
    Public Shared ReadOnly LeagueComparison As Step0 = New Step0("First half (extra time)")


    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class


  Class StepArrows
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Arrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Sponsor logo")
    Public Shared ReadOnly NoArrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No logo")
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.OtherMatchScores))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullFrameStats))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueComparison))
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
      Scene.SceneName = "gfx_Scoreline"
      Scene.SceneDirector = "DIR_MAIN"
      Select Case gs.ChildGraphicStep.Name
        Case Step0.LeagueTableTop
    '      PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepArrows.Arrows)
        Case Step0.OtherMatchScores
     '     PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepArrows.Arrows)
        Case Step0.LeagueTableBottom
      '    PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepArrows.Arrows)
        Case Step0.FullFrameStats
       '   PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepArrows.Arrows)
        Case Step0.LeagueComparison
          '  PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepArrows.Arrows)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"

#End Region
End Class
