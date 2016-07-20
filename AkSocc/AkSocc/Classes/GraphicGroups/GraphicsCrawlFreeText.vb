
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

  Private _crawlTexts As New FreeTexts()

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
        For Each freeText As FreeText In _crawlTexts.FreeTextList
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(freeText.EnglishDescription, freeText.EnglishDescription), True, True))
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

      Dim freeText As FreeText = _crawlTexts.GetByUID(graphicStep.UID)
      Scene = PrepareMatchScores(changeStep, freeText)

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


  Public Function PrepareMatchScores(gSide As Integer, freeText As FreeText) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 2)
      prefix = "Crawll_Results_Side_" & gSide & "_"


      If Not freeText Is Nothing Then
        scene.SceneParameters.Add(prefix & "Title", freeText.CrawlHeader)
        scene.SceneParameters.Add(prefix & "Title", freeText.CrawlText)
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

