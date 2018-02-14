Imports MlSoccerClient
Imports VizCommands

Public Class GraphicsAsItStands
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsAsItStands"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F11, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
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

    Public Shared ReadOnly LeagueTableTop As Step0 = New Step0("League table top")
    Public Shared ReadOnly LeagueTableBottom As Step0 = New Step0("League table bottom")

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
      Else
        Select Case graphicStep.Depth
          Case 1
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
    Dim changeStep As Integer = 1
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "gfx_Full_Frame"
      Scene.SceneDirector = "DIR_MAIN"

      Select Case gs.ChildGraphicStep.Name
        Case Step0.LeagueTableTop
          Scene = PrepareLeagueTable(changeStep, True, graphicStep.Name = StepArrows.Arrows)
        Case Step0.LeagueTableBottom
          Scene = PrepareLeagueTable(changeStep, False, graphicStep.Name = StepArrows.Arrows)
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
    scene.SceneName = "gfx_leftframer"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Change_" & ((gSide) Mod 2 + 1) & "_" & ((gSide + 1) Mod 2) + 1
    changeAnim = "Change_1_2"
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneParameters.Add("LeftFramer_Y_Position", "0")

    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gSide & "_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gSide & "_Title_Type", "1")
    scene.SceneParameters.Add("LeftFramer_Table_Vis.active", "1")
    scene.SceneParameters.Add("LeftFramer_Stats_Vis.active", "0")

    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Center", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Left", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Right", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Left", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Right", "")


    Dim prefix As String = ""
    For i As Integer = 1 To 7
      scene.SceneParameters.Add("LeftFramer_Stats_Side_" & gSide & "_Line_" & i & "_Vis.active", "0")

      prefix = "LeftFramer_Stats_Side_" & gSide & "_Subject_0" & i & "_"


      scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", "0")
      scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", "0")

      scene.SceneParameters.Add(prefix & "Left_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Left_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Right_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Stat_Name", "stat_name")
      scene.SceneParameters.Add(prefix & "Team_Name", "team name " & i)
    Next

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

      scene.SceneParameters.Add("LeftFramer_Y_Position.position", "0 0 0 ")

      ComputeClassification()

      scene.SceneParameters.Add("Side_" & gSide & "_Table_Vis.active", "1")
      scene.SceneParameters.Add(prefix & "Table_Vis.active", 1)

      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Centre_Text", "")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Table_Text", Translate("LEAGUE TABLE"))
      scene.SceneParameters.Add("LeftFramer_Title_Table_Side_" & gSide & "_Text_01", Translate("LEAGUE TABLE"))
      scene.SceneParameters.Add("LeftFramer_Side_" & gSide & "_Table_Vis.active", "1")

      Dim classificationForDay As ClassificationForMatchDay = _classification.LastAvailableClassificationForMatchDay


      For index As Integer = 0 To linesPerPage - 1
        posIndex = linesPerPage * IIf(isTop, 0, 1) + index
        Dim teamClassification As TeamClassificationForMatchDay = classificationForDay.TeamClassificationList(posIndex)
        prefix = "LeftFramer_Table_Side_" & gSide & "_Subject_" & Strings.Format(index + 1, "00") & "_"
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
#End Region
End Class
