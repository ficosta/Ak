Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GrapchicsTeamCaptions

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GrapchisTeamCaptions"
    MyBase.ID = 1
  End Sub

  Public Property _teamStaffs As TeamStaffs

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Home11AndSubs As Step0 = New Step0(" 11 and subs")
    Public Shared ReadOnly Home11MiniFormation As Step0 = New Step0(" 11 and mini-formation")
    Public Shared ReadOnly Home11Formation As Step0 = New Step0("11 full frame formation")

    Public Shared ReadOnly Away11AndSubs As Step0 = New Step0(" 11 and subs")
    Public Shared ReadOnly Away11MiniFormation As Step0 = New Step0(" 11 and mini-formation")
    Public Shared ReadOnly Away11Formation As Step0 = New Step0("11 full frame formation")

    Public Shared ReadOnly DoubleTeams As Step0 = New Step0("Double teams")
    Public Shared ReadOnly DoubleSubs As Step0 = New Step0("Double subs")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Home11AndSubs, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Home11MiniFormation, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Home11Formation, True, True))

        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Away11AndSubs, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Away11MiniFormation, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Away11Formation, True, True))

        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.DoubleTeams, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.DoubleSubs, True, True))

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
        Case Step0.Home11AndSubs
          Scene = PrepareTeam(changeStep, "Attempts on Goal", Me.Match.HomeTeam.MatchStats.Shots.ValueText, Me.Match.AwayTeam.MatchStats.Shots.ValueText)
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
    scene.SceneName = "gfx_Full_Frame"
    scene.SceneDirector = "anim_Full_Frame$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Change", 0, DirectorAction.Rewind)
    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("Change", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Veil_On_Off_Vis", "1")
    scene.SceneParameters.Add("Title_Sponsor_Vis", "1")

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


  Public Function PrepareTeam(gSide As Integer, stat_name As String, home_team_value As String, away_team_value As String) As Scene
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

#End Region
End Class

