Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsReferee
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsReferee"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F6, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Official1 As Step0 = New Step0("Official1")
    Public Shared ReadOnly Official2 As Step0 = New Step0("Official2")
    Public Shared ReadOnly Official3 As Step0 = New Step0("Official3")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub

    Public Sub New(key As String, name As String)
      MyBase.Key = key
      MyBase.Name = name
    End Sub
  End Class

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()

      If graphicStep Is Nothing Then
        If Not Me.Match.Official1 Is Nothing Then gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.Official1.ToString, Step0.Official1, True, False))
        If Not Me.Match.Official2 Is Nothing Then gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.Official2.ToString, Step0.Official2, True, False))
        If Not Me.Match.Official3 Is Nothing Then gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.Official3.ToString, Step0.Official3, True, False))
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
    Dim official As Official = Nothing
    Try
      Scene = InitDefaultScene()

      Select Case graphicStep.UID
        Case Step0.Official1
          official = Me.Match.Official1
        Case Step0.Official2
          official = Me.Match.Official2
        Case Step0.Official3
          official = Me.Match.Official3
      End Select
      If Not official Is Nothing Then
        Scene = PrepareReferees(changeStep, official)
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Lower3rd"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("BottomChange", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneDirectorsChangeIn.Add("BottomChange", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("BottomChange", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon", "1")
    scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Control_OMO_GV_Choose", "0")

    scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose ", "0")
    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon ", "0")
    Return scene
  End Function


  Public Function PrepareReferees(gSide As Integer, official As Official) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Lower3rd_Side_1" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 2)
      prefix = "Lower3rd_Side_" & gSide & "_"

      If Not official Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Single_Text_Subject_Name", official.OfficialArabicName)
        scene.SceneParameters.Add(prefix & "Bottom_Bar_Text_Text_01", Arabic("REFEREE"))
        scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Text_Text_01", Arabic("REFEREE"))
        scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Text_Text_01", Arabic("REFEREE"))
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class


