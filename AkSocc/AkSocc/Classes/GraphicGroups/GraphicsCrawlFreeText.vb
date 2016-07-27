
Imports AkSocc
Imports MatchInfo
Imports VizCommands

Public Class GraphicsCrawlFreeText
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCrawlFreeText"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F2, False, False, True, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Private _crawlTexts As FreeTexts

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
        _crawlTexts = New FreeTexts
        For Each freeText As FreeText In _crawlTexts.FreeTextList
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(freeText.UID, freeText.EnglishDescription), True, False))
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
      Dim freeText As FreeText = _crawlTexts.GetByUID(graphicStep.UID)
      Scene = PrepareFreeTexts(changeStep, freeText)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_crawl"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gStep, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Crawl_Change_1_2", 20, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 50, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gStep, 100, DirectorAction.Dummy)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Crawll_Side_" & gStep & "_Control_OMO_GV_Choose", 0)
    Dim prefix As String
    For i As Integer = 1 To 4
      prefix = "Crawll_Free_Text_Side_" & gStep & "_Field_" & i & "_"

      scene.SceneParameters.Add(prefix & "Text", "")
      scene.SceneParameters.Add(prefix & "Title", "")
      scene.SceneParameters.Add(prefix & "Logo_1_Vis", "")
      scene.SceneParameters.Add(prefix & "Logo_2_Vis", "")
      scene.SceneParameters.Add(prefix & "Logo_3_Vis", "")
      scene.SceneParameters.Add(prefix & "Logo_4_Vis", "")
    Next

    Return scene
  End Function


  Public Function PrepareFreeTexts(gSide As Integer, freeText As FreeText) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try

      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 0)
      prefix = "Crawll_Results_Side_" & gSide & "_"
      prefix = "Crawll_Free_Text_Side_" & gSide & "_Field_1_"

      If Not freeText Is Nothing Then
        scene.SceneParameters.Add(prefix & "Title", freeText.CrawlHeader)
        scene.SceneParameters.Add(prefix & "Text", freeText.CrawlText)
        scene.SceneParameters.Add(prefix & "Logo_1_Vis", "")
        scene.SceneParameters.Add(prefix & "Logo_2_Vis", "")
        scene.SceneParameters.Add(prefix & "Logo_3_Vis", "")
        scene.SceneParameters.Add(prefix & "Logo_4_Vis", "")
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

