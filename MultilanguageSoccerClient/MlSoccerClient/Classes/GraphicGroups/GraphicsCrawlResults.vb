﻿
Imports MlSoccerClient
  Imports MatchInfo
  Imports VizCommands

Public Class GraphicsCrawlResults
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCrawlResults"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(MyBase.Name, Keys.F12, True, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Sub New(_match As MatchInfo.Match, otherMatchDays As OtherMatchDays)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCrawlResults"
    Me.OtherMatchDays = otherMatchDays
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(MyBase.Name, Keys.F8, False, True, False, False)
  End Sub

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
        For Each matchDays As OtherMatchDay In Me.OtherMatchDays
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(matchDays.MatchDayID, matchDays.MatchDayName), True, False))
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

      Dim matchDay As OtherMatchDay = Me.OtherMatchDays.GetMatchDay(graphicStep.UID)
      Scene = PrepareMatchScores(changeStep, matchDay)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_crawl"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("Crawl_Change_1_2", 20, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 50, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 100, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gSide, 0, DirectorAction.Start)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Crawll_Side_" & gSide & "_Control_OMO_GV_Choose", 2)

    Return scene
  End Function


  Public Function PrepareMatchScores(gSide As Integer, matchDay As OtherMatchDay) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = "Crawll_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Dim matchIndex As Integer = 0
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 2)
      prefix = "Crawll_Results_Side_" & gSide & "_"


      If Not matchDay Is Nothing Then
        scene.SceneParameters.Add(prefix & "Title", Translate(matchDay.MatchDayName))
        For Each match As OtherMatch In matchDay.OtherMatches
          If match.IsCrawl Then
            matchIndex += 1
            subjectPrefix = prefix & "Match_" & (matchIndex) & "_"
            If Not match.Match Is Nothing Then
              scene.SceneParameters.Add(subjectPrefix & "Team_A_Name", match.Match.HomeTeam.Name)
              scene.SceneParameters.Add(subjectPrefix & "Team_B_Name", match.Match.AwayTeam.Name)
            Else
              scene.SceneParameters.Add(subjectPrefix & "Team_A_Name", "")
              scene.SceneParameters.Add(subjectPrefix & "Team_B_Name", "")
            End If
            scene.SceneParameters.Add(subjectPrefix & "Score", match.AwayScore & "-" & match.HomeScore)
          End If
        Next
      End If

      For index As Integer = matchIndex To 20
        subjectPrefix = prefix & "Match_" & (index) & "_"
        scene.SceneParameters.Add(subjectPrefix & "Team_A_Name", "")
        scene.SceneParameters.Add(subjectPrefix & "Team_B_Name", "")
        scene.SceneParameters.Add(subjectPrefix & "Score", "")
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

