Imports MatchInfo
Imports VizCommands


Public Class GraphicsPlayerNameNoNumber

    Inherits GraphicGroup

    Public Sub New(_match As Match)
    MyBase.New(_match)
    Me.MustHavePlayer = True

    MyBase.KeyCombination = New KeyCombination(Description, Keys.F6, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

    Public Sub New(_match As MatchInfo.Match, player As Player)
    MyBase.New(_match)
    Me.MustHavePlayer = True

    MyBase.Name = "GraphicsPlayerNameNoNumber"
    Me.Player = player
      MyBase.ID = 1
      If Not Me.Match Is Nothing And Not Me.Player Is Nothing Then
        Select Case Me.Player.TeamID
          Case Me.Match.HomeTeam.ID
            Me.Team = Me.Match.HomeTeam
          Case Me.Match.AwayTeam.ID
            Me.Team = Me.Match.AwayTeam
          Case Else
            Me.Team = Nothing
        End Select
      End If
    End Sub

    Public Overloads Shared ReadOnly Property Description As String
      Get
        Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
      End Get
    End Property

    Class Step0
      Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly NameAndTeam As Step0 = New Step0("Name and team")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.NameAndTeam, True, False))
      End If
      Catch ex As Exception
        WriteToErrorLog(ex)
      End Try
      Return gs
    End Function

    Private _lastPreparedStep As GraphicStep = Nothing

    Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
      Me.Scene = New Scene
      Dim gs As GraphicStep = graphicStep.RootGraphicStep
      Dim changeStep As Integer = 1
      Try
        Select Case gs.ChildGraphicStep.Name
          Case Step0.NameAndTeam
          Scene = PrepareNameAndTeam(changeStep)
      End Select
        _lastPreparedStep = graphicStep
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
      scene.SceneDirectorsIn.Add("Bottom_change_1_2", 0, DirectorAction.Rewind)
      scene.SceneDirectorsIn.Add(New SceneDirector("DIR_MAIN$In_Out$Cards", 0, DirectorAction.Rewind))

      scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

      Dim changeAnim As String = "Bottom_change_" & ((gSide) Mod 2 + 1) & "_" & ((gSide + 1) Mod 2) + 1
      changeAnim = "Bottom_change_1_2"
      'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
      'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

      scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
      scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)


      'player data
      If Player Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", "")
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name", "")
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name_Cards ", "")
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Number", "")
      Else
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & Team.BadgeName)
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name", Player.Name)
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Name_Cards ", Player.Name)
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Number", Player.SquadNo)
      End If

      'team data
      If Team Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", "")
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", "")
      Else
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Subject_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Team.BadgeName, paramType.Image)
        scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", Team.Name)
      End If

      scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose ", "1")
      scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Control_OMO_GV_Choose ", "0")

      Return scene
    End Function

    Private Function PrepareNameAndTeam(gSide As Integer) As Scene
      Dim scene As Scene = InitDefaultScene(gSide)
      Try
        Dim team As Team = IIf(Player.TeamID = Me.Match.home_team_id, Me.Match.HomeTeam, Me.Match.AwayTeam)

        scene.SceneParameters.Add("Lower3rd_Player_Badge_Number_Control_OMO_GV_Choose", "0")
        If team Is Nothing Then
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", "")
        Else
          scene.SceneParameters.Add("Lower3rd_Side_" & gSide & "_Bottom_Bar_Text_Text_01 ", team.Name)
        End If
      Catch ex As Exception
        WriteToErrorLog(ex)
      End Try
      Return scene
    End Function

#End Region
End Class

