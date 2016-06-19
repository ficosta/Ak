Imports AkSocc
Imports VizCommands

Public Class GraphicGroupTeamCrawls
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCtlF1FullFramers"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly HomeTeam As Step0 = New Step0("Home team")
    Public Shared ReadOnly HomeTeamWithSubs As Step0 = New Step0("Home team with subs")
    Public Shared ReadOnly AwayTeam As Step0 = New Step0("Away team")
    Public Shared ReadOnly AwayTeamWithSubs As Step0 = New Step0("Away team with subs")
    Public Shared ReadOnly HomeAwayTeams As Step0 = New Step0("Home + Away teams")
    Public Shared ReadOnly HomeAwayTeamsWithSubs As Step0 = New Step0("Home + Awat teams with subs")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeam))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeTeamWithSubs))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeam))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AwayTeamWithSubs))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeAwayTeams))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HomeAwayTeamsWithSubs))
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
      Scene.SceneName = "cfx_Full_Frame_Work"
      Scene.SceneDirector = "DIR_MAIN"

      Select Case gs.ChildGraphicStep.Name
        Case 0
          Select Case graphicStep.Name
            Case Step0.HomeTeam
              Scene = PrepareSingleTeam(changeStep, True)
            Case Step0.HomeTeamWithSubs
            Case Step0.AwayTeam
            Case Step0.AwayTeamWithSubs
            Case Step0.HomeAwayTeams
            Case Step0.HomeAwayTeamsWithSubs

          End Select

      End Select

      Select Case gs.ChildGraphicStep.Name
        Case Step0.LeagueTableTop
          Scene = PrepareSingleTeam(changeStep, True)
        Case Step0.OtherMatchScores
          Dim matchDay As MatchDay = _otherMatchDays.GetMatchDay(graphicStep.UID)
          Scene = PrepareMatchScores(changeStep, matchDay)
        Case Step0.LeagueTableBottom
          Scene = PrepareSingleTeam(changeStep, False)
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
    scene.SceneName = "cfx_Full_Frame_Work"
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


  Public Function PrepareSingleTeam(team As Team, isTop As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Side_" & gStep & "_"
    Try
      scene.SceneParameters.Add(prefix & "Table_Vis.active", 1)
    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
