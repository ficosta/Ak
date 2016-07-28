Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsBugs
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

  Public Property _bugs As BugDotTexts

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
      _bugs = New BugDotTexts
      _bugs.GetFromDB("WHERE Priority > 0")

      If graphicStep Is Nothing Then
        For Each name As BugDotText In _bugs
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(name.ID, name.EnglishDescription), True, False))
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
      Scene = InitDefaultScene(changeStep)


      Dim bug As BugDotText = _bugs.GetName(CInt(graphicStep.UID))
      Scene = PrepareBugs(changeStep, bug)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_bugs"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Popout", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Bugs_Control_OMO_GV_Choose", "1")
    Return scene
  End Function


  Public Function PrepareBugs(gSide As Integer, bugDotText As BugDotText) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      If Not bugDotText Is Nothing Then
        scene.SceneParameters.Add("Bugs_Full_Bar_Text", VizEncoding(bugDotText.ArabicTopLineText))
        scene.SceneParameters.Add("Bugs_Bottom_Bar_Text", VizEncoding(bugDotText.ArabicSubLineText))
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

