
Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsPlayerName

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match, player As Player)
    MyBase.New(_match)

    MyBase.Name = "GraphicsPlayerName"
    Me.Player = player
    MyBase.ID = 1
    If Not Me.Match Is Nothing And Not Me.Player Is Nothing Then
      Select Case Me.Player.TeamID
        Case Me.Match.HomeTeam.ID
          Me.Team = Me.Match.HomeTeam
        Case Me.Match.AwayTeam.ID
          Me.Team = Me.Match.AwayTeam
        Case Else
          Me.Team = Nothing
      End Select
    End If
  End Sub

  Public Property Player As Player
  Public Property Team As Team

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly NameAndTeam As Step0 = New Step0("Name and team")
    Public Shared ReadOnly YellowCard As Step0 = New Step0("Yellow card")
    Public Shared ReadOnly YellowCardMisses As Step0 = New Step0("Yellow card - misses next match")
    Public Shared ReadOnly YellowCard2 As Step0 = New Step0("Second yellow card")
    Public Shared ReadOnly RedCard As Step0 = New Step0("Red Card")
    Public Shared ReadOnly GoalsInMatch As Step0 = New Step0(" goals in match")
    Public Shared ReadOnly GoalsInSeasson As Step0 = New Step0(" goals in seasson")
    Public Shared ReadOnly ManOfTheMatch As Step0 = New Step0("Man of the match")

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

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.NameAndTeam, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCard, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCardMisses, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCard2, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.RedCard, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Player.MatchStats.Goals & " goals in match", Step0.GoalsInMatch, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Player.SeasonStats.Goals & " goals in season", Step0.GoalsInSeasson, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ManOfTheMatch, True, False))
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
        Case Step0.NameAndTeam
          Scene = PrepareNameAndTeam(changeStep)
        Case Step0.YellowCard
          Scene = PrepareYellowCard(changeStep, False)
        Case Step0.YellowCardMisses
          Scene = PrepareYellowCard(changeStep, True)
        Case Step0.YellowCard2
          Scene = Prepare2YellowCards(changeStep)
        Case Step0.RedCard
          Scene = PrepareRedCard(changeStep)
        Case Step0.GoalsInMatch
          Scene = PrepareGoals(changeStep, False)
        Case Step0.GoalsInSeasson
          Scene = PrepareGoals(changeStep, True)
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
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Bottom_change_1_2", 0, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add(New SceneDirector("DIR_MAIN$In_Out$Cards", 0, DirectorAction.Rewind))

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Bottom_change_" & ((gSide) Mod 2 + 1) & "_" & ((gSide + 1) Mod 2) + 1
    changeAnim = "Bottom_change_1_2"
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)


    'player data
    If Player Is Nothing Then
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", "")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name", "")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name_Cards ", "")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Number", "")
    Else
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & Team.BadgeName)
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name", Player.Name)
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name_Cards ", Player.Name)
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Number", Player.SquadNo)
    End If

    'team data
    If Team Is Nothing Then
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", "")
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", "")
    Else
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Team.BadgeName, paramType.Image)
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", Team.Name)
    End If

    scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose ", "1")
    scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Control_OMO_GV_Choose ", "0")

    Return scene
  End Function

  Private Function PrepareNameAndTeam(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      Dim team As Team = IIf(_Player.TeamID = Me.Match.home_team_id, Me.Match.HomeTeam, Me.Match.AwayTeam)

      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose", "0")
      If team Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", "")
      Else
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", team.Name)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareYellowCard(gSide As Integer, missesNextMatch As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose ", "1")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_Icon ", "0")
      If Not missesNextMatch Then
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("YELLOW CARD")))
      Else
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("MISSES NEXT MATCH")))
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function Prepare2YellowCards(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      scene.SceneDirectorsIn.Add(New SceneDirector("DIR_MAIN$In_Out$Cards", 50, DirectorAction.Start))
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose ", "2")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_Icon ", "1")
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("SECOND YELLOW CARD")))
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareRedCard(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      scene.SceneDirectorsIn.Add(New SceneDirector("DIR_MAIN$In_Out$Cards", 1, DirectorAction.JumpTo, 250))
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose ", "2")
      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_Icon ", "1")
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("RED CARD")))

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareGoals(gSide As Integer, seasonGoals As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      Dim goals As Integer
      Dim strGoals As String = Team.Name
      If seasonGoals = False Then
        goals = Player.Goals

        If goals = 0 Then
          strGoals = Team.Name
        ElseIf goals = 1 Then
          strGoals = Arabic("ONE GOAL IN THE MATCH")
        ElseIf goals <= 5 Then
          strGoals = Arabic(NumberToWord(goals) & " GOALS IN THE MATCH")
        Else
          strGoals = Team.Name
        End If
      Else
        goals = Player.Goals & Player.SeasonGoals

        If goals = 0 Then
          strGoals = Team.Name
        ElseIf goals = 1 Then
          strGoals = Arabic("ONE GOAL IN THE SEASON")
        ElseIf goals = 2 Then
          strGoals = Arabic("TWO GOALS IN THE SEASON")
        ElseIf goals <= 10 Then
          strGoals = Arabic(NumberToWord(goals)) & " " & Arabic("GOALS IN THE SEASON")
        ElseIf goals < 40 Then
          strGoals = Arabic(NumberToWord(goals)) & " " & Arabic("Goals for the season")
        Else
          strGoals = goals & " " & Arabic("Goals for the season")
        End If
      End If

      scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose", "0")
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01", strGoals)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function
#End Region
End Class

