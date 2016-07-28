Imports AkSocc
Imports MatchInfo
Imports VizCommands

Public Class GraphicGroupCrawlTeams
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicGroupCrawlTeams"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F8, True, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly HomeTeam As Step0 = New Step0("Home team")
    Public Shared ReadOnly HomeTeamWithSubs As Step0 = New Step0("Home team with subs")
    Public Shared ReadOnly AwayTeam As Step0 = New Step0("Away team")
    Public Shared ReadOnly AwayTeamWithSubs As Step0 = New Step0("Away team with subs")
    Public Shared ReadOnly HomeAwayTeams As Step0 = New Step0("Home + Away teams")
    Public Shared ReadOnly HomeAwayTeamsWithSubs As Step0 = New Step0("Home + Away teams with subs")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub

    Public Sub New(key As String, name As String)
      MyBase.Key = key
      MyBase.Name = name
    End Sub
  End Class

  Private _otherMatchDays As OtherMatchDays

  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeam, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamWithSubs, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeam, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamWithSubs, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeAwayTeams, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeAwayTeamsWithSubs, True, False))
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


      Select Case graphicStep.Name
        Case Step0.HomeTeam
          Scene = PrepareSingleTeam(1, Me.Match.HomeTeam, False)
        Case Step0.HomeTeamWithSubs
          Scene = PrepareSingleTeam(1, Me.Match.HomeTeam, True)
        Case Step0.AwayTeam
          Scene = PrepareSingleTeam(1, Me.Match.AwayTeam, False)
        Case Step0.AwayTeamWithSubs
          Scene = PrepareSingleTeam(1, Me.Match.AwayTeam, True)
        Case Step0.HomeAwayTeams
          Scene = PrepareDoubleTeam(1, False)
        Case Step0.HomeAwayTeamsWithSubs
          Scene = PrepareDoubleTeam(1, True)

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
    scene.SceneName = "gfx_crawl"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Crawl_Change_1_2", 20, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 50, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 100, DirectorAction.Dummy)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("Change", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Crawll_Side_" & gSide & "_Control_OMO_GV_Choose", 2)

    Dim prefix As String = "Side_" & gSide
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_TeamList_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Double_teams_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Table_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Results_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Formation_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Stats_Vis.active", "0")

    prefix = "Crawll_Team_List_Side_1_"
    scene.SceneParameters.Add(prefix & "Team_A_Name", "")
    scene.SceneParameters.Add(prefix & "Team_B_Name", "")
    scene.SceneParameters.Add(prefix & "Team_A_Subtitutes_Title", "")
    scene.SceneParameters.Add(prefix & "Team_B_Subtitutes_Title", "")

    For i As Integer = 1 To 18
      prefix = "Crawll_Team_List_Side_" & gSide & "_Team_A_Player_" & i & "_"
      scene.SceneParameters.Add(prefix & "Name", "")
      scene.SceneParameters.Add(prefix & "Number", "")
      scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
      scene.SceneParameters.Add(prefix & "Control_OMO_Arrows", "0")


      prefix = "Crawll_Team_List_Side_" & gSide & "_Team_B_Player_" & i & "_"
      scene.SceneParameters.Add(prefix & "Name", "")
      scene.SceneParameters.Add(prefix & "Number", "")
      scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
      scene.SceneParameters.Add(prefix & "Control_OMO_Arrows", "0")
    Next

    Return scene
  End Function


  Public Function PrepareSingleTeam(gSide As Integer, team As Team, withSubs As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 1)
      prefix = "Crawll_Team_List_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Team_A_Name", team.Name)
      If withSubs Then
        scene.SceneParameters.Add(prefix & "Team_A_Subtitutes_Title", Arabic("SUBSTITUTES"))
      Else
        scene.SceneParameters.Add(prefix & "Team_A_Subtitutes_Title", "")
      End If


      For pos As Integer = 1 To 18
        Dim player As Player = team.GetPlayerByPosicio(pos)
        Dim paint As Boolean = False
        If Not player Is Nothing Then
          If pos < 12 Then
            paint = True
          ElseIf withSubs Then
            paint = True
          End If
        End If
        prefix = "Crawll_Team_List_Side_1_Team_A_Player_" & pos & "_"
        If paint Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.DomesticSquadNo)
          If player.RedCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 1 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "1")
          Else
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          End If
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        End If
      Next
    Catch ex As Exception

    End Try
    Return scene
  End Function

  Public Function PrepareDoubleTeam(gSide As Integer, withSubs As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 1)
      prefix = "Crawll_Team_List_Side_1_"
      scene.SceneParameters.Add(prefix & "Team_A_Name", Match.HomeTeam.Name)
      scene.SceneParameters.Add(prefix & "Team_B_Name", Match.AwayTeam.Name)
      If withSubs Then
        scene.SceneParameters.Add(prefix & "Team_A_Subtitutes_Title", Arabic("SUBSTITUTES"))
        scene.SceneParameters.Add(prefix & "Team_B_Subtitutes_Title", Arabic("SUBSTITUTES"))
      Else
        scene.SceneParameters.Add(prefix & "Team_A_Subtitutes_Title", "")
        scene.SceneParameters.Add(prefix & "Team_B_Subtitutes_Title", "")
      End If
      Dim player As Player
      Dim paint As Boolean

      For pos As Integer = 1 To 18
        player = Match.HomeTeam.GetPlayerByPosicio(pos)
        paint = False
        If Not player Is Nothing Then
          If pos < 12 Then
            paint = True
          ElseIf withSubs Then
            paint = True
          End If
        End If
        prefix = "Crawll_Team_List_Side_1_Team_A_Player_" & pos & "_"
        If paint Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.DomesticSquadNo)
          If player.RedCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 1 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "1")
          Else
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          End If
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        End If
      Next

      For pos As Integer = 1 To 18
        player = Match.AwayTeam.GetPlayerByPosicio(pos)
        paint = False
        If Not player Is Nothing Then
          If pos < 12 Then
            paint = True
          ElseIf withSubs Then
            paint = True
          End If
        End If
        prefix = "Crawll_Team_List_Side_1_Team_B_Player_" & pos & "_"
        If paint Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.DomesticSquadNo)
          If player.RedCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 1 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "2")
          ElseIf player.YellowCards > 0 Then
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "1")
          Else
            scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          End If
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Control_OMO_Cards", "0")
          scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "0")
        End If
      Next
    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
