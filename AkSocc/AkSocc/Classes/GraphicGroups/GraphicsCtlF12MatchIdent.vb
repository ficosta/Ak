Imports AkSocc
Imports VizCommands

Public Class GraphicsCtlF12MatchIdent
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCtlF1FullFramers"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly NoLogo As Step0 = New Step0("No logo")
    Public Shared ReadOnly Logo1 As Step0 = New Step0("Logo 1")
    Public Shared ReadOnly Logo2 As Step0 = New Step0("Logo 2")
    Public Shared ReadOnly Logo3 As Step0 = New Step0("Logo 3")
    Public Shared ReadOnly Logo4 As Step0 = New Step0("Logo 4")
    Public Shared ReadOnly Logo5 As Step0 = New Step0("Logo 5")
    Public Shared ReadOnly Logo6 As Step0 = New Step0("Logo 6")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class


  Class StepArrows
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Arrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Arrows")
    Public Shared ReadOnly NoArrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No arrows")
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.NoLogo, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo1, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo2, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo3, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo4, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo5, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo6, True, False))

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs

  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = New Scene
    Dim gs As GraphicStep = graphicStep.RootGraphicStep
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "cfx_Full_Frame_Work"
      Scene.SceneDirector = "anim_Full_Frame$In_Out"

      Select Case gs.ChildGraphicStep.Name
        Case Step0.NoLogo
          Scene = PrepareMatchIdent(1)
        Case Else
          Scene = PrepareMatchIdent(1)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"
  Private Function InitDefaultScene() As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "cfx_Full_Frame_Work"
    scene.SceneDirector = "anim_Full_Frame$In_Out"

    Return scene
  End Function
  Public Function PrepareMatchIdent(gStep As Integer) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Match_Ident_Side_" & gStep & "_"
    Try
      scene.SceneParameters.Add("Side_" & gStep & "_Control_Omo", 0)

      scene.SceneParameters.Add(prefix & "Header_Text", "Header text")
      scene.SceneParameters.Add(prefix & "SUB_Header_Text", "SUB Header text")

      scene.SceneParameters.Add(prefix & "Subject_01_Name", Match.HomeTeam.ArabicCaption1Name)
      scene.SceneParameters.Add(prefix & "Subject_01_Geometry_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Match.HomeTeam.BadgeName)

      scene.SceneParameters.Add(prefix & "Subject_02_Name", Match.AwayTeam.ArabicCaption1Name)
      scene.SceneParameters.Add(prefix & "Subject_02_Geometry_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Match.AwayTeam.BadgeName)

    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
