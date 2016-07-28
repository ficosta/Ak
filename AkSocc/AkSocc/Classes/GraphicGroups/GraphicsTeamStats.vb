
Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsTeamStats

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsF5TeamStats"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F5, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

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

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()

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
          Scene = PrepareTeamStat(changeStep, "Yellow cards", Me.Match.HomeTeam.MatchStats.YellowCards.ValueText, Me.Match.AwayTeam.MatchStats.YellowCards.ValueText, eStatType.YellowCard)
        Case Step0.RedCards
          Scene = PrepareTeamStat(changeStep, "Red cards", Me.Match.HomeTeam.MatchStats.RedCards.ValueText, Me.Match.AwayTeam.MatchStats.RedCards.ValueText, eStatType.RedCard)
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
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Lower3rd"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Bottom_change_" & ((gSide + 1) Mod 2 + 1) & "_" & ((gSide) Mod 2 + 1)
    'changeAnim = "Bottom_change_1_2"

    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 75, DirectorAction.Dummy)

    scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose", "3")
    scene.SceneParameters.Add("Lower3rd_Player_Badge_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Control_OMO_GV_Choose", 2)

    Return scene
  End Function

  Private Enum eStatType
    Stat = 0
    YellowCard = 1
    RedCard = 2
  End Enum


  Private Function PrepareTeamStat(gSide As Integer, stat_name As String, home_team_value As String, away_team_value As String, Optional statType As eStatType = eStatType.Stat) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "LeftFramer_Title_Stats_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Dim nSubject As Integer = 1
    Try

      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_02", VizEncoding(Arabic(stat_name)))
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Control_OMO_GV_Choose ", "2")

      scene.SceneParameters.Add("Lower3rd_Data_Team_01_Name", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add("Lower3rd_Data_Team_02_Name", Me.Match.AwayTeam.Name)

      Select Case statType
        Case eStatType.Stat
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Left_Control_OMO_GV_Chosse", 0)
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Right_Control_OMO_GV_Chosse", 0)

          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Left_Score_Text", away_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Right_Score_Text", home_team_value)

        Case eStatType.YellowCard
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Left_Control_OMO_GV_Chosse", 1)
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Right_Control_OMO_GV_Chosse", 1)

          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Left_Yellow_Card_Number", away_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Right_Yellow_Card_Number", home_team_value)
        Case eStatType.RedCard
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Left_Control_OMO_GV_Chosse", 2)
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Subject_" & Strings.Format(nSubject, "00") & "_Right_Control_OMO_GV_Chosse", 2)

          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Left_Red_Card_Number", away_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Right_Red_Card_Number", home_team_value)
        Case Else
          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Left_Control_OMO_GV_Chosse", 3)
          scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Subject_01_Right_Control_OMO_GV_Chosse", 3)

          scene.SceneParameters.Add("Lower3rd_Side_1_Subject_01_Left_YellowRed_Card_Yellow_Number", away_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Subject_01_Left_YellowRed_Card_Red_Number", away_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Subject_01_Right_YellowRed_Card_Yellow_Number", home_team_value)
          scene.SceneParameters.Add("Lower3rd_Side_1_Subject_01_Right_YellowRed_Card_Red_Number", home_team_value)
      End Select



    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

