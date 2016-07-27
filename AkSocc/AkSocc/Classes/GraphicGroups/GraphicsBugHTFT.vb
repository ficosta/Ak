Imports AkSocc
Imports MatchInfo
  Imports VizCommands


  Public Class GraphicsBugHTFT
    Inherits GraphicGroup

    Public Sub New(_match As MatchInfo.Match)
      MyBase.New(_match)

      MyBase.Name = "GraphicsBugHTFT"
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

    Public Shared ReadOnly HalfTime As Step0 = New Step0("HALF TIME", "With 'Half time'")
    Public Shared ReadOnly FullTime As Step0 = New Step0("FULL TIME", "With 'Full time'")
    Public Shared ReadOnly ExtraTime As Step0 = New Step0("EXTRA TIME", "With 'Extra time'")
    Public Shared ReadOnly HalfTimeExtraTima As Step0 = New Step0("With 'Half time of Extra time'")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HalfTime, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullTime, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ExtraTime, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HalfTimeExtraTima, True, False))
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
      Scene = PrepareBugs(changeStep, graphicStep.UID)
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
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 80, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gStep, 0, DirectorAction.Start)
      scene.SceneDirectorsIn.Add("Popout", 0, DirectorAction.Rewind)

      scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Bugs_Control_OMO_GV_Choose", "0")
    Return scene
    End Function


  Public Function PrepareBugs(gSide As Integer, text As String) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      scene.SceneParameters.Add("Bugs_Bottom_Bar_Text", Arabic(text))

      scene.SceneParameters.Add("Bugs_Home_Team_Name", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add("Bugs_Away_Team_Name", Me.Match.AwayTeam.Name)
      scene.SceneParameters.Add("Bugs_Home_Team_Score", Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Bugs_Away_Team_Score", Me.Match.AwayTeam.Goals)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

