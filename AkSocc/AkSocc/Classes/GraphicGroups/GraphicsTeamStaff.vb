

Imports AkSocc
  Imports MatchInfo
  Imports VizCommands


Public Class GraphicsTeamStaff
  Inherits GraphicGroup

  Public Property Team As Team

  Public Sub New(_match As MatchInfo.Match, team As Team)
    MyBase.New(_match)

    MyBase.Name = "GraphicsTeamStaff"
    Me.team = team
    MyBase.ID = 1
  End Sub

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
      Scene = InitDefaultScene()

      Dim staff As TeamStaff = _teamStaffs.GetStaff(CInt(graphicStep.UID))
      Scene = PrepareMatchScores(changeStep, staff)

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

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("BottomChange", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("BottomChange", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Lower3rd_Data_Single_Subject_Control_OMO_Icon", "1")
    scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Control_OMO_GV_Choose", "0")

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


  Public Function PrepareMatchScores(gSide As Integer, teamStaff As TeamStaff) As Scene
    Dim scene As Scene = InitDefaultScene()
    Dim prefix As String = "Lower3rd_Side_1" & gSide & "_"
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add(prefix & "Control_OMO_GV_Choose", 2)
      prefix = "Lower3rd_Side_" & gSide & "_"

      If Not teamStaff Is Nothing Then
        scene.SceneParameters.Add("Lower3rd_Single_Text_Subject_Name", teamStaff.ArabicStaffTitle)
        scene.SceneParameters.Add(prefix & "Bottom_Bar_Text_Text_01", teamStaff.ArabicName)
        scene.SceneParameters.Add("Lower3rd_Side_1_Bottom_Bar_Text_Text_01", teamStaff.ArabicName)
        scene.SceneParameters.Add("Lower3rd_Side_2_Bottom_Bar_Text_Text_01", teamStaff.ArabicName)
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class

