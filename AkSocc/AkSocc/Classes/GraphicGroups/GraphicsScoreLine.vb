Imports AkSocc
Imports VizCommands

Public Class GraphicsScoreLine
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsScoreLine"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F1, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1, False)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property


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
        gs.GraphicSteps.Add(New GraphicStep(gs, "Extra time", "ET", False, False, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFirstHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETHalfTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETSecondHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFullTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Oher stats", "OS", False, False, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithLastScorer))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithIDentDescription))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithhAllScorers))
      Else
        Select Case graphicStep.Depth
          Case 1
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.SponsorLogo, True, False))
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.NoLogo, True, False))
          Case 2
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
      Scene.SceneName = "gfx_ScoreLine"

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
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half-time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETFullTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.WithhAllScorers
          PrepareResultSceneWithScorerCrawl(Scene, Match.home_goals, Match.away_goals, gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.WithIDentDescription
          PrepareResultSceneWithIdent(Scene, Match.home_goals, Match.away_goals, gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.WithLastScorer
          PrepareResultSceneWithLastScorer(Scene, Match.home_goals, Match.away_goals, gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

  Private Function InitDefaultScene(gSide As Integer, show_logo As Boolean) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_ScoreLine"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
    'scene.SceneDirectorsIn.Add("Bottom_change", 80, DirectorAction.JumpTo)
    scene.SceneDirectorsIn.Add("Goals_Crawler", 0, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("Bottom_change", 0, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("Change_commentators ", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Change_commentators ", 1, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)


    If show_logo Then
      If GraphicVersions.Instance.SelectedGraphicVersion.UseLongPreview Then
        scene.SceneDirectorsIn.Add("sponsor_in_out", 80, DirectorAction.Start)
        scene.SceneDirectorsIn.Add("sponsor_in_out", 90, DirectorAction.Dummy)
      Else
        scene.SceneDirectorsIn.Add("sponsor_in_out", 50, DirectorAction.Start)
        scene.SceneDirectorsIn.Add("sponsor_in_out", 55, DirectorAction.Dummy)
      End If
      scene.SceneDirectorsOut.Add("sponsor_in_out", 0, DirectorAction.ContinueNormal)
    Else
      scene.SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)
    End If

    For i As Integer = 1 To 11
      Dim prefix As String = "Scoreline_Side_" & gSide & "_Sublines_Type_2_Goals_"
      For j = 1 To 12
        scene.SceneParameters.Add(New SceneParameter(prefix & "Left_" & i & "_Text_" & Microsoft.VisualBasic.Strings.Format(j, "00"), " "))
        scene.SceneParameters.Add(New SceneParameter(prefix & "Right_" & i & "_Text_" & Microsoft.VisualBasic.Strings.Format(j, "00"), " "))
      Next j
    Next i

    Return scene
  End Function

  Private Sub PrepareResultScene(ByRef scene As Scene, home_Result As String, away_Result As String, period_Name As String, show_Logo As Boolean)
    scene = InitDefaultScene(1, show_Logo)

    Try
      Dim gSide As Integer = 1



      scene.SceneParameters.Add("Scoreline_Control_OMO_Score", "1")
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base ", "1")


      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_period_Name", Arabic(period_Name)))
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", Arabic(period_Name))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Data_Control_OMO_Data", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))

      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", Arabic(period_Name)))
      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_03_Text", ""))


    Catch ex As Exception

    End Try
  End Sub

  Private Sub PrepareResultSceneWithIdent(ByRef scene As Scene, home_Result As String, away_Result As String, show_Logo As Boolean)
    scene = InitDefaultScene(1, show_Logo)

    Try
      Dim gSide As Integer = 1


      scene.SceneParameters.Add("Scoreline_Control_OMO_Score", "1")
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base ", "1")

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_period_Name", Me.Match.ArabicMatchDescription))
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", Me.Match.ArabicMatchDescription)

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Data_Control_OMO_Data", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "0"))

      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", Arabic(period_Name)))
      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      'scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_03_Text", ""))


    Catch ex As Exception

    End Try
  End Sub

  Private Sub PrepareResultSceneWithLastScorer(ByRef scene As Scene, home_Result As String, away_Result As String, show_Logo As Boolean)
    scene = InitDefaultScene(1, show_Logo)
    Dim gside As Integer = 1

    Try
      scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Bottom_Control_OMO_Subline_Type_Base ", "1")
      scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Bottom_Sublines_Data_Control_OMO_Data ", "2")
      scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "0")

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_1_Data_01_Text", "")

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Control_OMO_Subline_Type_Base", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Control_OMO_Subline_Type_Base", "1"))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_1_Data_01_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gside & "_Bottom_Sublines_Type_1_Data_03_Text", ""))

      For i As Integer = 1 To 11
        scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_Left_" & i & "_Score_A ", "")
        scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_Right_" & i & "_Score_A ", "")
        For j As Integer = 1 To 12
          scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_Left_" & i & "_Text_" & Strings.Format(j, "00"), "")
          scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_Right_" & i & "_Text_" & Strings.Format(j, "00"), "")
        Next
      Next

      Dim goals As MatchInfo.MatchGoals = Me.Match.MatchGoals
      If goals.Count > 0 Then
        goals.Sort()
        Dim teamSide As String = ""
        Dim i As Integer = 1
        If goals(0).TeamGoalID = Me.Match.home_team_id Then
          teamSide = "Right"
        Else
          teamSide = "Left"
        End If

        scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_" & teamSide & "_" & i & "_Score_A ", GetGoalTime(goals(0)))
        scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_" & teamSide & "_" & i & "_Text_01", GetGoalPlayer(goals(0)))
        scene.SceneParameters.Add("Scoreline_Side_" & gside & "_Sublines_Type_2_Goals_" & teamSide & "_" & i & "_Text_02", GetGoalDescription(goals(0)))
      End If

    Catch ex As Exception

    End Try

  End Sub

  Private Sub PrepareResultSceneWithScorerCrawl(ByRef scene As Scene, home_Result As String, away_Result As String, show_Logo As Boolean)
    scene = InitDefaultScene(1, show_Logo)

    Try
      Dim gSide As Integer = 1
      scene.SceneDirectorsIn.Add("Goals_Crawler", 0, DirectorAction.Rewind)

      scene.SceneParameters.Add("Scoreline_Control_OMO_Score", "1")
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base ", "1")
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Sublines_Data_Control_OMO_Data ", "2")
      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "0")

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", "")

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "1"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_2_Control_OMO_GV_Choose", "0"))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Control_OMO_Subline_Type_Base", "1"))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_01_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_02_Text", ""))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Side_" & gSide & "_Bottom_Sublines_Type_1_Data_03_Text", ""))

      Dim goals As MatchInfo.MatchGoals = Me.Match.HomeTeam.MatchGoals
      goals.Sort()
      For i As Integer = 1 To 11
        Dim prefix As String = "Scoreline_Side_" & gSide & "_Sublines_Type_2_Goals_Right_"

        If i - 1 < goals.Count Then
          Dim goal As MatchInfo.MatchGoal = goals.Item(i - 1)
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", GetGoalTime(goal)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", GetGoalPlayer(goal)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_02", GetGoalDescription(goal)))
        Else
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", " "))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", " "))
        End If
      Next
      goals = Me.Match.AwayTeam.MatchGoals
      goals.Sort()
      For i As Integer = 1 To 11
        Dim prefix As String = "Scoreline_Side_" & gSide & "_Sublines_Type_2_Goals_Left_"
        If i - 1 < goals.Count Then
          Dim goal As MatchInfo.MatchGoal = goals.Item(i - 1)
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", GetGoalTime(goal)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", GetGoalPlayer(goal)))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_02", GetGoalDescription(goal)))
        Else
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Score_A", " "))
          scene.SceneParameters.Add(New SceneParameter(prefix & i & "_Text_01", " "))
        End If
      Next

      Dim nMax As Integer = Math.Max(Match.HomeTeam.Goals, Match.AwayTeam.Goals)
      Dim nPages As Integer = (nMax - 1) / 2
      Dim nTimePerPage As Integer = 200

      If nPages > 0 Then
        scene.SceneDirectorsIn.Add("Goals_Crawler", nTimePerPage, DirectorAction.Start)
        For i As Integer = 1 To nPages - 1
          scene.SceneDirectorsIn.Add("Goals_Crawler", (i + 1) * nTimePerPage, DirectorAction.ContinueNormal)
        Next

      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Function GetGoalTime(goal As MatchInfo.MatchGoal) As String
    Dim goalTime As String = ""
    Try
      Dim minute As Integer = goal.TimeSecond \ 60 + 1
      If goal.IsExtraTime = False Then
        goalTime = (minute) & "'"
      Else
        If minute > 120 Then
          goalTime = "120+" & (minute - 120) & "'"
        ElseIf minute > 105 Then
          goalTime = "105+" & (minute - 105) & "'"
        ElseIf minute > 90 Then
          goalTime = "90+" & (minute - 90) & "'"
        ElseIf minute > 45 Then
          goalTime = "45+" & (minute - 45) & "'"
        End If
      End If
    Catch ex As Exception

    End Try
    Return goalTime
  End Function

  Private Function GetGoalDescription(goal As MatchInfo.MatchGoal) As String
    Dim goalDescription As String = ""

    Try
      Select Case (goal.GoalType)
        Case MatchInfo.MatchGoal.eGoalType.Normal
          goalDescription = ""
        Case MatchInfo.MatchGoal.eGoalType.Own
          goalDescription = (Arabic("OWN GOAL"))
        Case MatchInfo.MatchGoal.eGoalType.Penalty
          goalDescription = (Arabic("PENALTY"))
      End Select
      goalDescription = goalDescription.Replace("(", "~")
      goalDescription = goalDescription.Replace(")", "( ")
      goalDescription = goalDescription.Replace("~", " )")
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return goalDescription
  End Function

  Private Function GetGoalPlayer(goal As MatchInfo.MatchGoal) As String
    Dim text As String = ""

    Try
      Dim player As MatchInfo.Player = Me.Match.GetPlayerById(goal.PlayerID)
      If Not player Is Nothing Then
        text = player.Name
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return text
  End Function
End Class
