

Imports MlSoccerClient
  Imports MatchInfo
  Imports VizCommands


Public Class GraphicsTeamStaff
  Inherits GraphicGroup


  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsTeamStaff"
    MyBase.ID = 1
    'MyBase.KeyCombination = New KeyCombination(Description, Keys.F7, False, False, False, False)
  End Sub


  Public Sub New(_match As MatchInfo.Match, team As Team)
    MyBase.New(_match)

    MyBase.Name = "GraphicsTeamStaff"
    Me.Team = team
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F7, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property
  Public Property _teamStaffs As TeamStaffs

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
      _teamStaffs = New TeamStaffs
      _teamStaffs.GetFromDB("WHERE StaffTeamID = " & Me.Team.ID)

      If graphicStep Is Nothing Then
        For Each name As TeamStaff In _teamStaffs
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(name.StaffID, name.StaffFullName & " " & name.StaffTitle), True, False))
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

      Dim staff As TeamStaff = _teamStaffs.GetStaff(CInt(graphicStep.UID))
      Scene = PrepareMatchScores(changeStep, staff)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Lower 3rd"
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

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("BottomChange", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("BottomChange", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon", "1")
    scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Data_Control_OMO_GV_Choose", "2")
    scene.SceneParameters.Add("Lower3rd_Player_Badge_Control_OMO_GV_Choose ", "0")
    Return scene
  End Function


  Public Function PrepareMatchScores(gSide As Integer, teamStaff As TeamStaff) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      prefix = "Lower3rd_Side_" & gSide & "_"

      If Not teamStaff Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Subject_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Team.BadgeName, paramType.Image)
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Subject_Logo3D.geom", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Team.BadgeName, paramType.Geometry)
        scene.SceneParameters.Add("Lower3rd_Player_Badge_Subject_Name", teamStaff.ArabicName)
        scene.SceneParameters.Add(prefix & "Bottom_Bar_Text_Text_01", teamStaff.ArabicStaffTitle)
        scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Text_Text_01", teamStaff.ArabicStaffTitle)
        scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Text_Text_01", teamStaff.ArabicStaffTitle)
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

