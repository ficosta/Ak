
Imports MlSoccerClient
  Imports VizCommands

Public Class GraphicsTeamStatsL3
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsTeamStatsL3"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F10, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly MatchStats As Step0 = New Step0("Match stats")
    Public Shared ReadOnly SeasonStats As Step0 = New Step0("Season stats")

    Public Shared ReadOnly MatchesPlayed As Step0 = New Step0("Matches played")
    Public Shared ReadOnly HomeTeamWins As Step0 = New Step0("Home team wins")
    Public Shared ReadOnly DrawMatches As Step0 = New Step0("Draw matches")
    Public Shared ReadOnly AwayTeamWins As Step0 = New Step0("Away team wins")
    Public Shared ReadOnly HomeTeamSeasonRecord As Step0 = New Step0("Home Team Season Record")
    Public Shared ReadOnly AwayTeamSeasonRecord As Step0 = New Step0("Away Team Season Record")
    Public Shared ReadOnly HomeTeamSeasonPosition As Step0 = New Step0("Home Team Season Position")
    Public Shared ReadOnly AwayTeamSeasonPosition As Step0 = New Step0("Away Team Season Position")


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
        gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.SponsorLogo, False, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.NoLogo, False, False))
      Else
        Select Case graphicStep.Depth
          Case 1

            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.MatchStats, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.SeasonStats, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.MatchesPlayed, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamWins, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamWins, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamSeasonRecord, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamSeasonRecord, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamSeasonPosition, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamSeasonPosition, True, True))
          Case 2
            'graphic is ready

        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_ScoreLine"

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Return scene
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

      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.MatchStats))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.SeasonStats))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.MatchesPlayed))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamWins))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamWins))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamSeasonRecord))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamSeasonRecord))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamSeasonPosition))
      gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamSeasonPosition))


      Select Case gs.ChildGraphicStep.ChildGraphicStep.Name
        Case Step0.MatchStats
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Match stats", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.SeasonStats
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Season stats", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.MatchesPlayed
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Matches played", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.HomeTeamWins
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Home team wins", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.AwayTeamWins
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Away team wins", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.HomeTeamSeasonRecord
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Home tam season record", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.AwayTeamSeasonRecord
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Away team season record", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.HomeTeamSeasonPosition
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Home team season position", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)
        Case Step0.AwayTeamSeasonPosition
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Away team season position", gs.ChildGraphicStep.UID = StepMatch.SponsorLogo)

      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

  Private Sub PrepareResultScene(ByRef scene As Scene, home_Result As String, away_Result As String, period_Name As String, show_Logo As Boolean)
    Try
      Dim gSide As Integer = 2
      scene.SceneDirector = "DIR_MAIN$In_Out"
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
      'scene.SceneDirectorsIn.Add("Bottom_change", 80, DirectorAction.JumpTo)
      scene.SceneDirectorsIn.Add("Goals_Crawler", 0, DirectorAction.Rewind)

      If show_Logo Then
        scene.SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Start)
        scene.SceneDirectorsIn.Add("sponsor_in_out", 50, DirectorAction.Dummy)
      Else
        scene.SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)
      End If

      scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_period_Name", period_Name))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Data_Control_OMO_Data", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", period_Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_03_Text", ""))


    Catch ex As Exception

    End Try
  End Sub

  Private Sub PrepareResultSceneWithScorerCrawl(ByRef scene As Scene, home_Result As String, away_Result As String, show_Logo As Boolean)
    Try
      Dim gSide As Integer = 2
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


      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "1"))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_03_Text", ""))

      Dim goals As MatchInfo.MatchGoals = Me.Match.HomeTeam.MatchGoals
      goals.Sort()
      For i As Integer = 1 To 11
        Dim prefix As String = "Scoreline_Side_" & gSide & "_Sublines_Type_2_Goals_Left_"

        If i - 1 < goals.Count Then
          Dim goal As MatchInfo.MatchGoal = goals.Item(i - 1)
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", FormatRunningTime(goal.TimeSecond)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", goal.GoalType.ToString))
        Else
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", " "))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", " "))
        End If
      Next
      goals = Me.Match.AwayTeam.MatchGoals
      goals.Sort()
      For i As Integer = 1 To 11
        Dim prefix As String = "Scoreline_Side_" & gSide & "_Sublines_Type_2_Goals_Right_"
        If i - 1 < goals.Count Then
          Dim goal As MatchInfo.MatchGoal = goals.Item(i - 1)
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", FormatRunningTime(goal.TimeSecond)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", goal.GoalType.ToString))
        Else
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", " "))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", " "))
        End If
      Next



    Catch ex As Exception

    End Try
  End Sub
End Class
