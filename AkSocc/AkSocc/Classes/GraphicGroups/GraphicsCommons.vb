Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsCommons
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCommons"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F7, True, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Commons As Step0 = New Step0("Commons")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Commons, True, False))
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
      Scene = PrepareCommons(changeStep)

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
    scene.SceneDirectorsIn.Add("BottomChange", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon", "1")
    scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Control_OMO_GV_Choose", "0")

    scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose ", "0")
    'scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Single_Text_Subject_Name ", "xxxxxxxxxxxx")
    scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Text_Text_01", "yyyyyyyyyyyyyyyyy")

    Return scene
  End Function


  Public Function PrepareCommons(gSide As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Lower3rd_Side_1" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose ", "0")
      prefix = "Lower3rd_Side_" & gSide & "_"

      scene.SceneParameters.Add("Lower3rd_Single_Text_Subject_Name", VizEncoding(Match.ArabicMatchCommentators))
      scene.SceneParameters.Add(prefix & "Bottom_Bar_Text_Text_01", VizEncoding(Arabic("COMMENTATORS")))
      scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("COMMENTATORS")))
      scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Text_Text_01", VizEncoding(Arabic("COMMENTATORS")))
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", VizEncoding(Arabic("COMMENTATORS")))

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

