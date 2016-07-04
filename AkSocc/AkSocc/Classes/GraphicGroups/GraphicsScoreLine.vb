Imports AkSocc
Imports VizCommands

Public Class GraphicsScoreLine
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsScoreLine"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly FirstHalf As Step0 = New Step0("First half")
    Public Shared ReadOnly HalfTime As Step0 = New Step0("Half time")
    Public Shared ReadOnly SecondHalf As Step0 = New Step0("Second half")
    Public Shared ReadOnly FullTime As Step0 = New Step0("Full time")

    Public Shared ReadOnly ETFirstHalf As Step0 = New Step0("First half (extra time)")
    Public Shared ReadOnly ETHalfTime As Step0 = New Step0("Half time (extra time)")
    Public Shared ReadOnly ETSecondHalf As Step0 = New Step0("Second half (extra time)")
    Public Shared ReadOnly ETFullTime As Step0 = New Step0("Full time (extra time)")


    Public Shared ReadOnly WithLastScorer As Step0 = New Step0("With last scorer")
    Public Shared ReadOnly WithIDentDescription As Step0 = New Step0("With ident description")
    Public Shared ReadOnly WithhAllScorers As Step0 = New Step0("With all scorers")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FirstHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HalfTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.SecondHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Extra time", False, False, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFirstHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETHalfTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETSecondHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFullTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Oher stats", False, False, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithLastScorer))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithIDentDescription))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithhAllScorers))
      Else
        Select Case graphicStep.Depth
          Case 0
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.SponsorLogo, True, False))
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.NoLogo, True, False))
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
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "gfx_Scoreline"

      ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

      Scene.SceneDirectorsChangeIn.Add("Change", 0, DirectorAction.Start)
      Scene.SceneDirectorsChangeIn.Add("Change", 200, DirectorAction.Dummy)

      Select Case gs.ChildGraphicStep.Name
        Case Step0.FirstHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.SecondHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.HalfTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.FullTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETFirstHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETSecondHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETHalfTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETFullTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.WithhAllScorers
          PrepareResultSceneWithScorerCrawl(Scene, Match.home_goals, Match.away_goals, gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)

      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

  Private Sub PrepareResultScene(ByRef scene As Scene, home_Result As String, away_Result As String, period_Name As String, show_Logo As Boolean)
    Try
      scene.SceneDirector = "DIR_MAIN$In_Out"
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
      'scene.SceneDirectorsIn.Add("Bottom_change", 80, DirectorAction.JumpTo)
      scene.SceneDirectorsIn.Add("Goals_Crawler", 0, DirectorAction.Rewind)
      scene.SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)

      scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_period_Name", period_Name))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Control_OMO_Subline_Type_Base", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Data_Control_OMO_Data", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_01_Text", period_Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_03_Text", ""))

      If show_Logo Then
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "1"))
        scene.SceneDirectorsIn.Add("sponsor_in_out", 100, DirectorAction.Start)
      Else
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "0"))
        scene.SceneDirectorsIn.Add("sponsor_in_out", 100, DirectorAction.Dummy)
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub PrepareResultSceneWithScorerCrawl(ByRef scene As Scene, home_Result As String, away_Result As String, show_Logo As Boolean)
    Try
      scene.SceneDirector = "DIR_MAIN$In_Out"
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
      'scene.SceneDirectorsIn.Add("Bottom_change", 0, DirectorAction.Rewind)
      scene.SceneDirectorsIn.Add("Goals_Crawler", 0, DirectorAction.Rewind)
      scene.SceneDirectorsIn.Add("Goals_Crawler", 100, DirectorAction.Start)
      scene.SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)

      scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))


      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Control_OMO_Subline_Type_Base", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Data_Control_OMO_Data", "1"))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_01_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_1_Bottom_Sublines_Type_1_Data_03_Text", ""))

      Dim goals As MatchInfo.MatchGoals = Me.Match.MatchGoals

      goals.Sort()

      For i As Integer = 1 To 11
        If i - 1 < goals.Count Then
          Dim goal As MatchInfo.MatchGoal = goals.Item(i - 1)
        End If
        scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_2_Sublines_Type_2_Goals_Left_" & i & "_Score_A", "jojo " & i))
        scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_2_Sublines_Type_2_Goals_Left_" & i & "_Text_01", "jaja " & i))

        scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_2_Sublines_Type_2_Goals_Right_" & i & "_Score_A", "jojo " & i))
        scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_2_Sublines_Type_2_Goals_Right_" & i & "_Text_01", "jaja " & i))
      Next


      If show_Logo Then
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "1"))
        scene.SceneDirectorsIn.Add("sponsor_in_out", 100, DirectorAction.Start)
      Else
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "0"))
        scene.SceneDirectorsIn.Add("sponsor_in_out", 100, DirectorAction.Dummy)
      End If

    Catch ex As Exception

    End Try
  End Sub
End Class
