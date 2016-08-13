Imports AkSocc
Imports VizCommands

Public Class GraphicGroupFullFramers
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicGroupFullFramers"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F1, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
    Me.CantHaveClock = True
  End Sub

  Public Sub New(_match As MatchInfo.Match, otherMatchDays As OtherMatchDays)
    MyBase.New(_match)

    MyBase.Name = "GraphicGroupFullFramers"
    Me.OtherMatchDays = otherMatchDays
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F1, False, True, False, False)
    Me.CantHaveClock = True
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

  Class StepLogos
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly YesLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Show sponsor")
    Public Shared ReadOnly NoLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No sponsor")
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LeagueComparison, True, True))
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
              Case Step0.FullFrameStats
                gs.GraphicSteps.Add(New GraphicStep(gs, StepLogos.YesLogo, True, True))
                gs.GraphicSteps.Add(New GraphicStep(gs, StepLogos.NoLogo, True, True))

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
          Scene = PrepareFullFrameStats(changeStep, graphicStep.Name = StepLogos.YesLogo)
        Case Step0.LeagueComparison
          Scene = PrepareLeagueComparisson(changeStep)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"
  Private Function InitDefaultScene(gSide As Integer) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Full_Frame"
    scene.SceneDirector = "anim_Full_Frame$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    If GraphicVersions.Instance.SelectedGraphicVersion.UseLongPreview Then
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 90, DirectorAction.Dummy)
    Else
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 105, DirectorAction.Dummy)
    End If
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("Title_change_1_2", 0, DirectorAction.Rewind)


    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneDirectorsChangeIn.Add("Change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change_1_2", 200, DirectorAction.Dummy)
    scene.SceneDirectorsChangeIn.Add("Title_change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Title_change_1_2", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Veil_On_Off_Vis.active", "1")
    scene.SceneParameters.Add("Title_Sponsor_Vis", "0")
    scene.SceneParameters.Add("Veil_Left_Vis ", "0")
    scene.SceneParameters.Add("Veil_Right_Vis ", "0")

    scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", "")
    scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
    scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
    scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
    scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
    scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

    scene.SceneParameters.Add("Stats_Side_" & gSide & "_Bottom_Text", "")

    Dim prefix As String = "Side_" & gSide
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_TeamList_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Double_teams_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Table_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Results_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Formation_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Stats_Vis.active", "0")

    Return scene
  End Function

  Public Function PrepareMatchIdent(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "TeamList_Step_" & gSide & "_"
    scene.SceneParameters.Add("Side_" & gSide & "_Match_Ident_Vis.active", "1")
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_Control_Omo", 0)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareTeamList(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "TeamList_Step_" & gSide & "_"
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_TeamList_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "TeamList_Vis.active", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareDoubleTeams(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "TeamList_Step_" & gSide & "_"
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_Double_teams_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "Double_teams_Vis.active", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Private _classificationUpdated As Boolean = False
  Private _classification As Classification
  Private Sub ComputeClassification()
    If Me.Match Is Nothing Then Exit Sub
    If _classificationUpdated = False Then
      Dim _matches As MatchInfo.Matches
      _matches = MatchInfo.Matches.GetMatchesForCompetition(Me.Match.competition_id)
      _classification = New Classification(_matches)
    End If
    _classificationUpdated = True

  End Sub

  Public Function PrepareLeagueTable(gSide As Integer, isTop As Boolean, showArrows As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Side_" & gSide & "_"
    Dim posIndex As Integer = 0
    Dim linesPerPage As Integer = 7
    Try

      ComputeClassification()

      scene.SceneParameters.Add("Side_" & gSide & "_Table_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "Table_Vis.active", 1)

      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Text", Arabic("LEAGUE TABLE"))
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "1")

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "0")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      scene.SceneParameters.Add("Veil_Left_Vis ", "0")
      scene.SceneParameters.Add("Veil_Right_Vis ", "0")

      Dim classificationForDay As ClassificationForMatchDay = _classification.LastAvailableClassificationForMatchDay


      For index As Integer = 0 To linesPerPage - 1
        posIndex = linesPerPage * IIf(isTop, 0, 1) + index
        Dim teamClassification As TeamClassificationForMatchDay = classificationForDay.TeamClassificationList(posIndex)
        prefix = "Table_Side_" & gSide & "_Subject_" & Strings.Format(index + 1, "00") & "_"

        scene.SceneParameters.Add(prefix & "Number", (posIndex + 1))
        scene.SceneParameters.Add(prefix & "Name", teamClassification.Team.Name)
        '0 down
        '1 up
        '2 line
        If showArrows Then
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", CInt(teamClassification.PositionChange))
        Else
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "3")
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

  Public Function PrepareMatchScores(gSide As Integer, matchDay As MatchDay) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Results_Vis.active", "1")

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "0")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "0")


      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", Arabic(matchDay.MatchDayName))
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", "", paramType.Geometry)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", "", paramType.Geometry)

      prefix = "Results_Side_" & gSide & "_"

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

  Public Function PrepareFormation(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Side_" & gSide & "_"
    Try
      scene.SceneParameters.Add(prefix & "Formation_Vis.active", "1")
    Catch ex As Exception

    End Try
    Return scene
  End Function


  Public Function PrepareFullFrameStats(gSide As Integer, show_sponsor As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Stats_Side_" & gSide & "_"
    Dim posIndex As Integer = 0
    Dim linesPerPage As Integer = 7
    Try

      scene.SceneParameters.Add("Side_" & gSide & "_Stats_Vis.active", "1")

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "1")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "1")

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.AwayTeam.BadgeName)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.AwayTeam.BadgeName)


      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", Me.Match.AwayTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")

      If show_sponsor Then
        scene.SceneParameters.Add("Title_Sponsor_Vis ", "1")
      Else
        scene.SceneParameters.Add("Title_Sponsor_Vis ", "0")
      End If

      Dim statNames() As String = {"Shots", "Shots_on_target", "Corners", "Offsides", "Fouls", "Cards", "Possession"}
      Dim stat As MatchInfo.Stat

      For i As Integer = 0 To statNames.Count - 1
        Dim subjectPrefix As String = prefix & "Subject_0" & (i + 1) & "_"

        scene.SceneParameters.Add(subjectPrefix & "Team_Name", statNames(i))

        Select Case statNames(i)
          Case "Cards"

            scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("CARDS"))

            scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "3")
            scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "3")

            scene.SceneParameters.Add(subjectPrefix & "Right_YellowRed_Card_Yellow_Number", Match.HomeTeam.YellowCards)
            scene.SceneParameters.Add(subjectPrefix & "Right_YellowRed_Card_Red_Number", Match.HomeTeam.RedCards)

            scene.SceneParameters.Add(subjectPrefix & "Left_YellowRed_Card_Yellow_Number", Match.AwayTeam.YellowCards)
            scene.SceneParameters.Add(subjectPrefix & "Left_YellowRed_Card_Red_Number", Match.AwayTeam.RedCards)
          Case Else

            scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
            scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")

            stat = Me.Match.HomeTeam.GetMatchStatByName(statNames(i))
            If Not stat Is Nothing Then
              scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic(stat.StatTitle))

              scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", stat.ValueText)
            End If

            stat = Me.Match.AwayTeam.GetMatchStatByName(statNames(i))
            If Not stat Is Nothing Then
              scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", stat.ValueText)
            End If
        End Select
      Next

      For i As Integer = statNames.Count To 10
        Dim subjectPrefix As String = prefix & "Subject_0" & (i + 1)
        scene.SceneParameters.Add(subjectPrefix & "Team_Name", "")

        scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
        scene.SceneParameters.Add(subjectPrefix & "Right_Yellow_Card_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Right_Red_Card_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Right_YellowRed_Card_Yellow_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Right_YellowRed_Card_Red_Number", "xx")

        scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
        scene.SceneParameters.Add(subjectPrefix & "Left_Yellow_Card_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Left_Red_Card_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Left_YellowRed_Card_Yellow_Number", "xx")
        scene.SceneParameters.Add(subjectPrefix & "Left_YellowRed_Card_Red_Number", "xx")
      Next
      'scene.SceneParameters.Add(prefix & "Table_Vis.active", 1)

      'scene.SceneParameters.Add(prefix & "Centre_Text", Arabic("LEAGUE TABLE")) '0 full bar, 1 split bar
      'scene.SceneParameters.Add(prefix & "Right_Text", "") '0 full bar, 1 split bar
      'scene.SceneParameters.Add(prefix & "Left_Text", "") '0 full bar, 1 split bar

      'scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "0")
      'scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      'scene.SceneParameters.Add("Veil_Left_Vis ", "0")
      'scene.SceneParameters.Add("Veil_Right_Vis ", "0")


    Catch ex As Exception

    End Try
    Return scene
  End Function


  Public Function PrepareLeagueComparisson(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Stats_Side_" & gSide & "_"
    Dim posIndex As Integer = 0
    Dim linesPerPage As Integer = 7
    Try

      scene.SceneParameters.Add("Side_" & gSide & "_Stats_Vis.active", "1")

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "1")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "1")

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.AwayTeam.BadgeName)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.AwayTeam.BadgeName)



      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", "") ' Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", Me.Match.AwayTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      ComputeClassification()

      Dim homeTeamClassification As TeamClassificationForMatchDay = Nothing
      Dim awayTeamClassification As TeamClassificationForMatchDay = Nothing

      For index As Integer = 0 To _classification.LastAvailableClassificationForMatchDay.TeamClassificationList.Count - 1
        Dim teamClassification As TeamClassificationForMatchDay = _classification.LastAvailableClassificationForMatchDay.TeamClassificationList(index)
        Select Case teamClassification.Team.ID
          Case Match.HomeTeam.TeamID
            homeTeamClassification = teamClassification
          Case Match.AwayTeam.TeamID
            awayTeamClassification = teamClassification
        End Select
      Next

      Dim subjectPrefix As String
      'Position
      subjectPrefix = prefix & "Subject_01_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("POSITION"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.Position)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.Position)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'GAmes played
      subjectPrefix = prefix & "Subject_02_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("GAMES"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.MatchesPlayed)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.MatchesPlayed)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'Wins
      subjectPrefix = prefix & "Subject_03_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("WINS"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.MatchesWon)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.MatchesWon)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'Draws
      subjectPrefix = prefix & "Subject_04_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("DRAWS"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.MatchesDrawn)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.MatchesDrawn)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'Lost
      subjectPrefix = prefix & "Subject_05_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("LOST"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.MatchesLost)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.MatchesLost)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'Goal difference
      subjectPrefix = prefix & "Subject_06_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("GOAL DIFFERENCE"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.GoalAverage)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.GoalAverage)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")
      'points
      subjectPrefix = prefix & "Subject_07_"
      scene.SceneParameters.Add(subjectPrefix & "Team_Name", Arabic("POINTS"))
      scene.SceneParameters.Add(subjectPrefix & "Right_Score_Text", homeTeamClassification.Points)
      scene.SceneParameters.Add(subjectPrefix & "Left_Score_Text", awayTeamClassification.Points)
      scene.SceneParameters.Add(subjectPrefix & "Right_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(subjectPrefix & "Left_Control_OMO_GV_Chosse", "0")


    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
