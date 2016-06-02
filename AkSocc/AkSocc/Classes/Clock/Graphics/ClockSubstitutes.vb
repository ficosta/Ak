Imports AkSocc
Imports VizCommands

Public Class ClockSubstitutes
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "ClockSubstitutes"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly HomeTeam As Step0 = New Step0("Home team")
    Public Shared ReadOnly AwayTeam As Step0 = New Step0("Away team")
    Public Shared ReadOnly AlreadyComitted As Step0 = New Step0("Already comitted")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class

  Class StepMatch
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly SponsorLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Sponsor logo")
    Public Shared ReadOnly NoLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No logo")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeam))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeam))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AlreadyComitted))
      Else
        Select Case graphicStep.Depth
          Case 0
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.SponsorLogo, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.NoLogo, True, True))
          Case 1
            'graphic is ready

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
      Scene.VizLayer = SceneLayer.Front
      Scene.SceneName = "gfx_Clock"
      Scene.SceneDirector = "anim_Clock_Substitute"
      Select Case gs.ChildGraphicStep.Name
        Case Step0.HomeTeam
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.AlreadyComitted
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.AwayTeam
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

  Private Sub PrepareResultScene(ByRef scene As Scene, home_result As String, away_result As String, period_name As String, show_logo As Boolean)
    Try
      scene.SceneDirectorsIn.Add("anim_Clock_Substitute", 0, DirectorAction.Start)
      scene.SceneDirectorsOut.Add("anim_Clock_Substitute", 0, DirectorAction.Start)

      scene.SceneParameters.Add(New SceneParameter("home_team_name", Match.HomeTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("away_team_name", Match.AwayTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("home_team_logo", Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("away_team_logo", Match.HomeTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("home_team_result", home_result))
      scene.SceneParameters.Add(New SceneParameter("away_team_result", away_result))

      scene.SceneParameters.Add(New SceneParameter("period_name", period_name))

      If show_logo Then
        scene.SceneParameters.Add(New SceneParameter("show_logo", "1"))
      Else
        scene.SceneParameters.Add(New SceneParameter("show_logo", "0"))
      End If

    Catch ex As Exception

    End Try
  End Sub
End Class
