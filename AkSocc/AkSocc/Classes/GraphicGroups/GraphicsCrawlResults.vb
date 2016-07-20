
Imports AkSocc
  Imports MatchInfo
  Imports VizCommands

Public Class GraphicsCrawlResults
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCrawlResults"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(MyBase.Name, Keys.F8, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Sub New(_match As MatchInfo.Match, otherMatchDays As OtherMatchDays)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCrawlResults"
    Me.OtherMatchDays = otherMatchDays
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(MyBase.Name, Keys.F8, False, True, False, False)
  End Sub

  Private _otherMatchDays As OtherMatchDays
  Public Property OtherMatchDays As OtherMatchDays
    Get
      Return _otherMatchDays
    End Get
    Set(value As OtherMatchDays)
      _otherMatchDays = value
    End Set
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
        For Each matchDays As MatchDay In _otherMatchDays
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(matchDays.MatchDayID, matchDays.MatchDayName), True, True))
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

      Dim matchDay As MatchDay = _otherMatchDays.GetMatchDay(graphicStep.UID)
      Scene = PrepareMatchScores(changeStep, matchDay)

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


  Public Function PrepareMatchScores(gSide As Integer, matchDay As MatchDay) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Cho  ose", 2)
      prefix = "Crawll_Results_Side_" & gSide & "_"


      If Not matchDay Is Nothing Then
        scene.SceneParameters.Add(prefix & "Title", matchDay.Name)

        For Each match As OtherMatch In matchDay.OtherMatches
          subjectPrefix = prefix & "Match_" & (match.MatchIndex + 1) & "_"
          If Not match.Match Is Nothing Then
            scene.SceneParameters.Add(subjectPrefix & "Team_A_Name", match.Match.HomeTeam.Name)
            scene.SceneParameters.Add(subjectPrefix & "Team_B_Name", match.Match.AwayTeam.Name)
          Else
            scene.SceneParameters.Add(subjectPrefix & "Team_A_Name", "")
            scene.SceneParameters.Add(subjectPrefix & "Team_B_Name", "")
          End If
          scene.SceneParameters.Add(subjectPrefix & "Score", match.AwayScore & "-" & match.HomeScore)
        Next
        For index As Integer = matchDay.OtherMatches.Count To 10
          subjectPrefix = prefix & "Subject_0" & index & "_"
          scene.SceneParameters.Add(subjectPrefix & "Title", "no match to show")
        Next
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

