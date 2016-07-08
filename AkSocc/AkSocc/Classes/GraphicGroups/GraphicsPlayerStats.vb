Imports AkSocc
Imports MatchInfo
  Imports VizCommands


Public Class GraphicsPlayerStats

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match, player As Player)
    MyBase.New(_match)

    MyBase.Name = "GraphicsPlayerStats"
    Me.Player = player
    MyBase.ID = 1
  End Sub

  Public Property Player As Player

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition


    Public Shared ReadOnly AttemptsOnGoal As Step0 = New Step0("Attempts On Goal")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.AttemptsOnGoal, True, True))
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
      Select Case gs.ChildGraphicStep.Name
        Case Step0.AttemptsOnGoal
          Scene = PrepareTeamStat(changeStep, "Attempts on Goal", Me.Match.HomeTeam.MatchStats.Shots.ValueText, Me.Match.AwayTeam.MatchStats.Shots.ValueText)
      End Select

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Lower3rd"
    scene.SceneDirector = "anim_lower3rd$In_Out"
    scene.SceneDirectorsIn.Add("anim_lower3rd$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("anim_lower3rd$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Crawl_Side_" & gStep, 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("BottomChange", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("anim_lower3rd$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneDirectorsChangeIn.Add("BottomChange", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("BottomChange", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon", "1")
    scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Control_OMO_GV_Choose", "0")

    Return scene
  End Function


  Public Function PrepareTeamStat(gSide As Integer, stat_name As String, home_team_value As String, away_team_value As String) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "LeftFramer_Title_Stats_Side_" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      prefix = "LeftFramer_Title_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Text_Center", stat_name)
      scene.SceneParameters.Add(prefix & "Text_Right", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add(prefix & "Text_Left", Me.Match.AwayTeam.Name)

      prefix = "LeftFramer_Stats_Side_" & gSide & "_"

      scene.SceneParameters.Add(prefix & "Subject_01_Left_Control_OMO_GV_Chosse", 0)
      scene.SceneParameters.Add(prefix & "Subject_01_Left_Score_Text", away_team_value)

      scene.SceneParameters.Add(prefix & "Subject_01_Right_Control_OMO_GV_Chosse", 0)
      scene.SceneParameters.Add(prefix & "Subject_01_Right_Score_Text", away_team_value)

      scene.SceneParameters.Add(prefix & "Subject_01_Team_Name", stat_name)

      For i As Integer = 2 To 7
        scene.SceneParameters.Add(prefix & "Text_0" & i, "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Control_OMO_GV_Chosse", 0)
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Left_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Right_Score_Text", "")
        scene.SceneParameters.Add(prefix & "Subject_0" & i & "_Team_Name", "r")
      Next
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

