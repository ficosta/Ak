Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsTeamCaptions

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GrapchisTeamCaptions"
    MyBase.ID = 1

  End Sub

  Public Property _teamStaffs As TeamStaffs

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Home11AndSubs As Step0 = New Step0("Home 11 and subs")
    Public Shared ReadOnly Home11MiniFormation As Step0 = New Step0("Home 11 and mini-formation")
    Public Shared ReadOnly Home11Formation As Step0 = New Step0("Home full frame formation")

    Public Shared ReadOnly Away11AndSubs As Step0 = New Step0("Away 11 and subs")
    Public Shared ReadOnly Away11MiniFormation As Step0 = New Step0("Away 11 and mini-formation")
    Public Shared ReadOnly Away11Formation As Step0 = New Step0("Away full frame formation")

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
          Scene = PrepareTeam(changeStep, Me.Match.HomeTeam)
        Case Step0.Away11AndSubs
          Scene = PrepareTeam(changeStep, Me.Match.AwayTeam)
        Case Step0.Home11Formation
          Scene = PrepareTeamFormation(changeStep, Me.Match.HomeTeam)
        Case Step0.Away11Formation
          Scene = PrepareTeamFormation(changeStep, Me.Match.AwayTeam)
        Case Else
          Scene = PrepareTeam(changeStep, Me.Match.HomeTeam)
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
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 130, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("Change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change_1_2", 200, DirectorAction.Dummy)

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

  Public Function PrepareTeam(gSide As Integer, team As Team) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_TeamList_Vis.active", "1")
      scene.SceneParameters.Add("TeamList_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))


      For i As Integer = 1 To 11
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "TeamList_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis", "0")
      Next

      For i As Integer = 12 To 18
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "TeamList_Side_" & gSide & "_Substitutes_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis", "0")
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareTeamFormation(gSide As Integer, team As Team) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_Formation_Vis.active", "1")
      scene.SceneParameters.Add("Formation_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))


      For i As Integer = 1 To 11
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "Formation_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis", "0")
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

