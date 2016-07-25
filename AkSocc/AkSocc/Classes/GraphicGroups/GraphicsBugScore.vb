Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsBugScore
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsBugs"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F8, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

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
        Dim goals As MatchGoals = Me.Match.MatchGoals
        goals.Sort()

        For Each goal As MatchGoal In goals
          Dim player As Player = Me.Match.GetPlayerById(goal.PlayerID)
          If Not player Is Nothing Then
            gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(goal.GoalID, (goal.TimeSecond \ 60) & "' " & player.ToString), True, False))
          End If
        Next

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
      Scene = InitDefaultScene()

      Dim goal As MatchGoal = Match.MatchGoals.GetGoal(CInt(graphicStep.UID))
      Scene = PrepareBugs(changeStep, goal)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_bugs"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 50, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gStep, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Popout", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Bugs_Control_OMO_GV_Choose", "1")
    scene.SceneParameters.Add("Bugs_Popout_Bar_Text", "")
    Return scene
  End Function


  Public Function PrepareBugs(gSide As Integer, goal As MatchGoal) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      If Not goal Is Nothing Then
        Dim player As Player = Me.Match.GetPlayerById(goal.PlayerID)
        scene.SceneParameters.Add("Bugs_Full_Bar_Text", (goal.TimeSecond \ 60) & "' " & player.ArabicName)
        scene.SceneParameters.Add("Bugs_Bottom_Bar_Text", "")
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

