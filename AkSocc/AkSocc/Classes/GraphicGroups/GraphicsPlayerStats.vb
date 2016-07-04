
Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsPlayerStats

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match, player As Player)
    MyBase.New(_match)

    MyBase.Name = "GraphicsPlayerStats"
    Me.Player = player
    MyBase.ID = 1
  End Sub

  Public Property Player As Player

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly NameAndTeam As Step0 = New Step0("Name and team")
    Public Shared ReadOnly YellowCard As Step0 = New Step0("Yellow card")
    Public Shared ReadOnly YellowCardMisses As Step0 = New Step0("Yellow card - misses next match")
    Public Shared ReadOnly YellowCard2 As Step0 = New Step0("Second yellow card")
    Public Shared ReadOnly RedCard As Step0 = New Step0("Red Card")
    Public Shared ReadOnly GoalsInMatch As Step0 = New Step0(" goals in match")
    Public Shared ReadOnly GoalsInSeasson As Step0 = New Step0(" goals in seasson")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.NameAndTeam, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCard, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCardMisses, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCard2, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.RedCard, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.GoalsInMatch, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.GoalsInSeasson, True, True))
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
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_lower_third"
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

    'player data
    scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", "")
    scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name", Player.Name)
    scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Number", Player.SquadNo)

    Return scene
  End Function

  Private Function PrepareNameAndTeam(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareYellowCard(gSide As Integer, missesNextMatch As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function Prepare2YellowCards(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareRedCard(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Private Function PrepareGoals(gSide As Integer, seasonGoals As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function
#End Region
End Class

