
Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsTeamStats

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsF5TeamStats"
    MyBase.ID = 1
  End Sub

  Public Property _teamStaffs As TeamStaffs

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition


    Public Shared ReadOnly AttemptsOnGoal As Step0 = New Step0("Attempts On Goal")
    Public Shared ReadOnly AttempsOntarget As Step0 = New Step0("Attempts On target")
    Public Shared ReadOnly YellowCards As Step0 = New Step0("Yellow cards")
    Public Shared ReadOnly RedCards As Step0 = New Step0("Red Cards")
    Public Shared ReadOnly Offisdes As Step0 = New Step0("Offsides")
    Public Shared ReadOnly FoulsComitted As Step0 = New Step0("Fouls committed")
    Public Shared ReadOnly Corners As Step0 = New Step0("Corners")
    Public Shared ReadOnly Possession As Step0 = New Step0("Possession")
    Public Shared ReadOnly LastPossessions As Step0 = New Step0("Last 5 Minutes Possession")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub

    Public Sub New(key As String, name As String)
      MyBase.Key = key
      MyBase.Name = name
    End Sub
  End Class


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()
      _teamStaffs = New TeamStaffs

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AttemptsOnGoal, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AttempsOntarget, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCards, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.RedCards, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Offisdes, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FoulsComitted, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Corners, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Possession, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.LastPossessions, True, True))
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
      Select Case gs.ChildGraphicStep.Name
        Case Step0.AttemptsOnGoal
          Scene = PrepareTeamStat(changeStep, "Attempts on Goal", Me.Match.HomeTeam.MatchStats.Shots.ValueText, Me.Match.AwayTeam.MatchStats.Shots.ValueText)
        Case Step0.AttempsOntarget
          Scene = PrepareTeamStat(changeStep, "Attempts on target", Me.Match.HomeTeam.MatchStats.ShotsOn.ValueText, Me.Match.AwayTeam.MatchStats.ShotsOn.ValueText)
        Case Step0.YellowCards
          Scene = PrepareTeamCards(changeStep)
        Case Step0.RedCards
          Scene = PrepareTeamStat(changeStep, "Red cards", Me.Match.HomeTeam.MatchStats.RedCards.ValueText, Me.Match.AwayTeam.MatchStats.RedCards.ValueText)
        Case Step0.Offisdes
          Scene = PrepareTeamStat(changeStep, "Offsides", Me.Match.HomeTeam.MatchStats.Offsides.ValueText, Me.Match.AwayTeam.MatchStats.Offsides.ValueText)
        Case Step0.FoulsComitted
          Scene = PrepareTeamStat(changeStep, "Fouls comitted", Me.Match.HomeTeam.MatchStats.Fouls.ValueText, Me.Match.AwayTeam.MatchStats.Fouls.ValueText)
        Case Step0.Corners
          Scene = PrepareTeamStat(changeStep, "Corners", Me.Match.HomeTeam.MatchStats.Corners.ValueText, Me.Match.AwayTeam.MatchStats.Corners.ValueText)
        Case Step0.Possession
          Scene = PrepareTeamStat(changeStep, "Possession", Me.Match.HomeTeam.MatchStats.Possession.ValueText, Me.Match.AwayTeam.MatchStats.Possession.ValueText)
        Case Step0.LastPossessions
          Scene = PrepareTeamStat(changeStep, "Last 5 minutes possession", Me.Match.HomeTeam.MatchStats.LastPossessions.ValueText, Me.Match.AwayTeam.MatchStats.LastPossessions.ValueText)
      End Select

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_leftframer"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_2_1", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Change_" & ((gStep) Mod 2 + 1) & "_" & ((gStep + 1) Mod 2) + 1
    changeAnim = "Change_1_2"

    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)


    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gStep & "_Control_OMO_GV_Choose", "1")

    Dim prefix As String = "LeftFramer_Title_Bar_Side_1_Control_OMO_GV_Choose" & gStep
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "0")

    Return scene
  End Function


  Public Function PrepareTeamStat(gSide As Integer, stat_name As String, home_team_value As String, away_team_value As String) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "LeftFramer_Title_Stats_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      prefix = "LeftFramer_Title_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Text_Center", stat_name)
      scene.SceneParameters.Add(prefix & "Text_Right", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add(prefix & "Text_Left", Me.Match.AwayTeam.Name)

      prefix = "LeftFramer_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Subject_01_Left_Control_OMO_GV_Chosse", 0)
      scene.SceneParameters.Add(prefix & "Subject_01_Left_Score_Text", away_team_value)

      scene.SceneParameters.Add(prefix & "Subject_01_Right_Control_OMO_GV_Chosse", 0)
      scene.SceneParameters.Add(prefix & "Subject_01_Right_Score_Text", away_team_value)

      scene.SceneParameters.Add(prefix & "Subject_01_Team_Name", stat_name)

      For i As Integer = 2 To 7
        scene.SceneParameters.Add(prefix & "Text_0" & i, "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Team_Name", "r")
      Next
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareTeamCards(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "LeftFramer_Title_Stats_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      prefix = "LeftFramer_Title_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Text_Center", "cards")
      scene.SceneParameters.Add(prefix & "Text_Right", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add(prefix & "Text_Left", Me.Match.AwayTeam.Name)

      prefix = "LeftFramer_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Subject_01_Left_Control_OMO_GV_Chosse", 2)
      scene.SceneParameters.Add(prefix & "Subject_01_Left_Score_Text", Me.Match.AwayTeam.MatchStats.YellowCards.ValueText)

      scene.SceneParameters.Add(prefix & "Subject_01_Right_Control_OMO_GV_Chosse", 2)
      scene.SceneParameters.Add(prefix & "Subject_01_Left_Score_Text", Me.Match.HomeTeam.MatchStats.YellowCards.ValueText)

      scene.SceneParameters.Add(prefix & "Subject_01_Team_Name", "stat name")

      For i As Integer = 2 To 7
        scene.SceneParameters.Add(prefix & "Text_0" & i, "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Team_Name", "r")
      Next
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

