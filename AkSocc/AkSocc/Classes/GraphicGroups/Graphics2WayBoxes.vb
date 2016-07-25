Imports AkSocc
Imports MatchInfo
Imports VizCommands

Public Class Graphics2WayBoxes
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "Graphics2WayBoxes"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F4, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property


  Public Property _reporters As NameDotTexts

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Symmetric As Step0 = New Step0("Symmetric windows")
    Public Shared ReadOnly Asymmetric As Step0 = New Step0("Asymmetric windows")

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
      _reporters = New NameDotTexts
      _reporters.GetFromDB("WHERE Priority > 0")

      If graphicStep Is Nothing Then
        For Each name As NameDotText In _reporters
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(name.ID, name.EnglishDescription), False, True))
        Next
      ElseIf graphicStep.RootGraphicStep.Depth = 1 Then
        For Each name As NameDotText In _reporters
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(name.ID, name.EnglishDescription), False, True))
        Next
      Else

        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Symmetric, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Asymmetric, True, False))

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
      Me.Scene = InitDefaultScene()

      Dim reporter As NameDotText = _reporters.GetName(CInt(graphicStep.UID))
      Scene = PrepareReporters(changeStep, reporter, reporter, True)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_2way_box"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 120, DirectorAction.Dummy)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("2WayBox_Simetry_Control_OMO", "0")
    scene.SceneParameters.Add("Text_01", "")
    scene.SceneParameters.Add("Text_02", "")

    Return scene
  End Function


  Public Function PrepareReporters(gSide As Integer, nameDotText1 As NameDotText, nameDotText2 As NameDotText, isSimetric As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      scene.SceneParameters.Add("2WayBox_Simetry_Control_OMO ", IIf(isSimetric, "1", "0"))

      If Not nameDotText1 Is Nothing Then
        scene.SceneParameters.Add("Text_01", VizEncoding(nameDotText1.ArabicTopLineText))
      End If
      If Not nameDotText2 Is Nothing Then
        scene.SceneParameters.Add("Text_02", VizEncoding(nameDotText2.ArabicTopLineText))
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

