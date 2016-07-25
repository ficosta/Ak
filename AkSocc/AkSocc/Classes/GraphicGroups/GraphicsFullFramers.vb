﻿Imports AkSocc
Imports VizCommands

Public Class GraphicGroupFullFramers
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicGroupFullFramers"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F1, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Sub New(_match As MatchInfo.Match, otherMatchDays As OtherMatchDays)
    MyBase.New(_match)

    MyBase.Name = "GraphicGroupFullFramers"
    Me.OtherMatchDays = otherMatchDays
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F1, False, True, False, False)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

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

    Public Sub New(key As String, name As String)
      MyBase.Key = key
      MyBase.Name = name
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.OtherMatchScores))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullFrameStats, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueComparison, True, False))
      Else
        Select Case graphicStep.Depth
          Case 1
            Select Case graphicStep.Name
              Case Step0.LeagueTableTop, Step0.LeagueTableBottom
                gs.GraphicSteps.Add(New GraphicStep(gs, StepArrows.Arrows, True, True))
                gs.GraphicSteps.Add(New GraphicStep(gs, StepArrows.NoArrows, True, True))
              Case Step0.OtherMatchScores
                For Each matchDays As MatchDay In Me.OtherMatchDays
                  gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(matchDays.MatchDayID, matchDays.MatchDayName), True, True))
                Next
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
    Dim changeStep As Integer = 1
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "gfx_Full_Frame"
      Scene.SceneDirector = "DIR_MAIN"

      Select Case gs.ChildGraphicStep.Name
        Case Step0.LeagueTableTop
          Scene = PrepareLeagueTable(changeStep, True, graphicStep.Name = StepArrows.Arrows)
        Case Step0.OtherMatchScores
          Dim matchDay As MatchDay = Me.OtherMatchDays.GetMatchDay(graphicStep.UID)
          Scene = PrepareMatchScores(changeStep, matchDay)
        Case Step0.LeagueTableBottom
          Scene = PrepareLeagueTable(changeStep, False, graphicStep.Name = StepArrows.Arrows)
        Case Step0.FullFrameStats
        Case Step0.LeagueComparison
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Full_Frame"
    scene.SceneDirector = "anim_Full_Frame$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 95, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("Change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change_1_2", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Veil_On_Off_Vis.active", "1")
    scene.SceneParameters.Add("Title_Sponsor_Vis", "1")
    scene.SceneParameters.Add("Veil_Left_Vis.active ", "0")
    scene.SceneParameters.Add("Veil_Right_Vis.active ", "0")


    Dim prefix As String = "Side_" & gStep
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_TeamList_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Double_teams_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Table_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Results_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Formation_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Stats_Vis.active", "0")

    Return scene
  End Function

  Public Function PrepareMatchIdent(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    scene.SceneParameters.Add("Side_" & gStep & "_ _Match_Ident_Vis.active", "1")
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
      scene.SceneParameters.Add("Side_" & gStep & "_TeamList_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "TeamList_Vis.active", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareDoubleTeams(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "TeamList_Step_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Double_teams_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "Double_teams_Vis.active", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Private _classification As Classification = Nothing
  Private Sub ComputeClassification()
    If Me.Match Is Nothing Then Exit Sub
    If _classification Is Nothing Then
      Dim _matches As MatchInfo.Matches
      _matches = MatchInfo.Matches.GetMatchesForCompetition(Me.Match.competition_id)
      _classification = New Classification(_matches)
    End If

  End Sub

  Public Function PrepareLeagueTable(gStep As Integer, isTop As Boolean, showArrows As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Side_" & gStep & "_"
    Dim posIndex As Integer = 0
    Dim linesPerPage As Integer = 7
    Try

      ComputeClassification()

      scene.SceneParameters.Add("Side_" & gStep & "_Table_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "Table_Vis.active", 1)

      scene.SceneParameters.Add(prefix & "Centre_Text", Arabic("LEAGUE TABLE")) '0 full bar, 1 split bar
      scene.SceneParameters.Add(prefix & "Right_Text", "") '0 full bar, 1 split bar
      scene.SceneParameters.Add(prefix & "Left_Text", "") '0 full bar, 1 split bar

      For index As Integer = 0 To linesPerPage - 1
        posIndex = linesPerPage * IIf(isTop, 0, 1) + index
        Dim teamClassification As TeamClassificationForMatchDay = _classification.LastAvailableClassificationForMatchDay.TeamClassificationList(posIndex)
        prefix = "Table_Side_" & gStep & "_Subject_" & Strings.Format(index + 1, "00") & "_"

        scene.SceneParameters.Add(prefix & "Number", (posIndex + 1))
        scene.SceneParameters.Add(prefix & "Name", teamClassification.Team.Name)
        '0 down
        '1 up
        '2 line
        If showArrows Then
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "2")
        Else
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "2")
        End If
        scene.SceneParameters.Add(prefix & "Data_01_Text", teamClassification.MatchesPlayed)
        scene.SceneParameters.Add(prefix & "Data_02_Text", teamClassification.MatchesWon)
        scene.SceneParameters.Add(prefix & "Data_03_Text", teamClassification.MatchesDrawn)
        scene.SceneParameters.Add(prefix & "Data_04_Text", teamClassification.MatchesLost)
        scene.SceneParameters.Add(prefix & "Data_05_Text", teamClassification.GoalAverage)
        scene.SceneParameters.Add(prefix & "Data_06_Text", teamClassification.Points)
      Next
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareMatchScores(gStep As Integer, matchDay As MatchDay) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Side_" & gStep & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Results_Vis.active", "1")

      prefix = "Title_Side_" & gStep & "_"
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", "0") '0 full bar, 1 split bar
      scene.SceneParameters.Add(prefix & "Centre_Text", Arabic(matchDay.MatchDayName)) '0 full bar, 1 split bar
      scene.SceneParameters.Add(prefix & "Right_Text", "") '0 full bar, 1 split bar
      scene.SceneParameters.Add(prefix & "Left_Text", "") '0 full bar, 1 split bar

      scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_02_Logo3D.geom ", "", paramType.Geometry)
      scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_01_Logo3D.geom ", "", paramType.Geometry)

      prefix = "Results_Side_" & gStep & "_"

      If Not matchDay Is Nothing Then
        Dim matchIndex As Integer = 1
        For Each match As OtherMatch In matchDay.OtherMatches
          If match.IsTable Then

            subjectPrefix = prefix & "Subject_0" & (matchIndex) & "_"
            Select Case match.LineType
              Case OtherMatch.eOtherMatchLineType.Blank
                scene.SceneParameters.Add(subjectPrefix & "Control_OMO_GV_Choose", "0")
              Case OtherMatch.eOtherMatchLineType.Result
                scene.SceneParameters.Add(subjectPrefix & "Control_OMO_GV_Choose", "1")
              Case OtherMatch.eOtherMatchLineType.Title
                scene.SceneParameters.Add(subjectPrefix & "Control_OMO_GV_Choose", "0")
            End Select
            scene.SceneParameters.Add(subjectPrefix & "Title", match.MatchTitle)

            scene.SceneParameters.Add(subjectPrefix & "Control_OMO_TV_Channel", match.LogoChannel)
            Select Case match.MatchStatus
              Case OtherMatch.otherMatchStatus.Idle
                scene.SceneParameters.Add(subjectPrefix & "Control_OMO_Score", "0")
                scene.SceneParameters.Add(subjectPrefix & "No_Score_Text", "X")
              Case Else
                scene.SceneParameters.Add(subjectPrefix & "Control_OMO_Score", "1")
                scene.SceneParameters.Add(subjectPrefix & "No_Score_Text", "")
            End Select

            If match.LineType = OtherMatch.eOtherMatchLineType.Result And Not match.Match Is Nothing Then
              match.Match.GetMatch()
              scene.SceneParameters.Add(subjectPrefix & "Home_Team_Name", match.Match.HomeTeam.Name)
              scene.SceneParameters.Add(subjectPrefix & "Away_Team_Name", match.Match.AwayTeam.Name)
            Else
              scene.SceneParameters.Add(subjectPrefix & "Home_Team_Name", "")
              scene.SceneParameters.Add(subjectPrefix & "Away_Team_Name", "")
            End If
            scene.SceneParameters.Add(subjectPrefix & "Home_Team_Score", match.HomeScore)
            scene.SceneParameters.Add(subjectPrefix & "Away_Team_Score", match.AwayScore)

            scene.SceneParameters.Add(subjectPrefix & "Visible.active", "1")

            matchIndex += 1
          End If
        Next
        For index As Integer = matchIndex To 10
          subjectPrefix = prefix & "Subject_0" & (index) & "_"
          scene.SceneParameters.Add(subjectPrefix & "Visible.active", "0")
        Next
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareFormation(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Side_" & gStep & "_"
    Try
      scene.SceneParameters.Add(prefix & "Formation_Vis.active", "1")
    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
