Imports AkSocc
Imports VizCommands

Public Class GraphicsMatchIdent
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCtlF1FullFramers"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F12, False, True, False, False)
    Me.Scene = Me.InitDefaultScene(1)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly NoLogo As Step0 = New Step0("No logo")
    Public Shared ReadOnly Logo1 As Step0 = New Step0("Logo 1")
    Public Shared ReadOnly Logo2 As Step0 = New Step0("Logo 2")
    Public Shared ReadOnly Logo3 As Step0 = New Step0("Logo 3")
    Public Shared ReadOnly Logo4 As Step0 = New Step0("Logo 4")
    Public Shared ReadOnly Logo5 As Step0 = New Step0("Logo 5")
    Public Shared ReadOnly Logo6 As Step0 = New Step0("Logo 6")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class


  Class StepArrows
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Arrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Arrows")
    Public Shared ReadOnly NoArrows As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No arrows")
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.NoLogo, 0, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo1, 1, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo2, 2, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo3, 3, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo4, 4, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo5, 5, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Logo6, 6, True, False))

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs

  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = New Scene
    Dim gs As GraphicStep = graphicStep.RootGraphicStep
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "gfx_Full_Frame"
      Scene.SceneDirector = "anim_Full_Frame$In_Out"

      Scene.SceneDirectorsIn.Add(New SceneDirector("anim_Full_Frame$In_Out", 0, DirectorAction.Start))
      Scene.SceneDirectorsIn.Add(New SceneDirector("anim_Full_Frame$In_Out", 100, DirectorAction.Dummy))

      Scene.SceneDirectorsOut.Add(New SceneDirector("anim_Full_Frame$In_Out", 0, DirectorAction.ContinueNormal))



      Scene.SceneDirector = "anim_Full_Frame$In_Out"

      Scene = PrepareMatchIdent(1, CInt(gs.ChildGraphicStep.UID))
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Full frame scenes"
  Private Function InitDefaultScene(Optional gStep As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Full_Frame"
    scene.SceneDirector = "anim_Full_Frame$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 100, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    scene.SceneParameters.Add("Title_Sponsor_Vis", "1")

    scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_02_Logo3D.geom ", "")
    scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_01_Logo3D.geom ", "")

    scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_02_Logo ", "")
    scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_01_Logo ", "")

    scene.SceneParameters.Add("Veil_Left_Vis.active ", "0")
    scene.SceneParameters.Add("Veil_Right_Vis.active ", "0")
    scene.SceneParameters.Add("Veil_On_Off_Vis.active ", "0")



    Dim prefix As String = "Side_" & gStep
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "1")
    scene.SceneParameters.Add(prefix & "_TeamList_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Double_teams_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Table_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Results_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Formation_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Stats_Vis.active", "0")

    Return scene
  End Function

  Public Function PrepareMatchIdent(gStep As Integer, logo As Integer) As Scene
    Dim scene As Scene = InitDefaultScene(gStep)
    Dim prefix As String = "Match_Ident_Side_" & gStep & "_"
    Try

      scene.SceneParameters.Add(prefix & "Vis.active", "1")
      scene.SceneParameters.Add("Side_" & gStep & "_" & "_Match_Ident_Vis.active", "1")

      scene.SceneParameters.Add(prefix & "Header_Text", "Header text")
      scene.SceneParameters.Add(prefix & "SUB_Header_Text", Match.ArabicMatchDescription)

      scene.SceneParameters.Add(prefix & "Subject_01_Name", Match.HomeTeam.Name)
      scene.SceneParameters.Add(prefix & "Subject_01_Geometry_Logo3D.geom", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Match.HomeTeam.BadgeName, paramType.Geometry)

      scene.SceneParameters.Add(prefix & "Subject_02_Name", Match.AwayTeam.Name)
      scene.SceneParameters.Add(prefix & "Subject_02_Geometry_Logo3D.geom", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Match.AwayTeam.BadgeName, paramType.Geometry)

      scene.SceneParameters.Add(prefix & "Header_Control_OMO_TVLOGO", logo)


      'scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.HomeTeam.BadgeName)
      'scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.AwayTeam.BadgeName)

      'scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.HomeTeam.BadgeName)
      'scene.SceneParameters.Add("Badge_Side_" & gStep & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.AwayTeam.BadgeName)

      'scene.SceneParameters.Add("Veil_Left_Vis.active ", "1")
      'scene.SceneParameters.Add("Veil_Right_Vis.active ", "1")

    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region
End Class
