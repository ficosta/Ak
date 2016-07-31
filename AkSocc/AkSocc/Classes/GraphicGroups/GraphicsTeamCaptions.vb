Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsTeamCaptions

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GrapchisTeamCaptions"
    MyBase.ID = 1
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F9, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
    Me.CantHaveClock = True

  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Public Property _teamStaffs As TeamStaffs

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Home11AndSubs As Step0 = New Step0("Home 11 and subs")
    Public Shared ReadOnly Home11MiniFormation As Step0 = New Step0("Home 11 and mini-formation")
    Public Shared ReadOnly Home11Formation As Step0 = New Step0("Home full frame formation")

    Public Shared ReadOnly Away11AndSubs As Step0 = New Step0("Away 11 and subs")
    Public Shared ReadOnly Away11MiniFormation As Step0 = New Step0("Away 11 and mini-formation")
    Public Shared ReadOnly Away11Formation As Step0 = New Step0("Away full frame formation")

    Public Shared ReadOnly DoubleTeams As Step0 = New Step0("Double teams")
    Public Shared ReadOnly DoubleSubs As Step0 = New Step0("Double subs")

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

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.HomeTeam.TeamAELCaption1Name & " 11 ans subs", Step0.Home11AndSubs, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.HomeTeam.TeamAELCaption1Name & " 11 mini formation", Step0.Home11MiniFormation, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.HomeTeam.TeamAELCaption1Name & " 11 formation", Step0.Home11Formation, True, True))

        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.AwayTeam.TeamAELCaption1Name & " 11 ans subs", Step0.Away11AndSubs, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.AwayTeam.TeamAELCaption1Name & " 11 mini formation", Step0.Away11MiniFormation, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Me.Match.AwayTeam.TeamAELCaption1Name & " 11 formation", Step0.Away11Formation, True, True))

        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.DoubleTeams, True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.DoubleSubs, True, True))

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
      Select Case gs.ChildGraphicStep.UID
        Case Step0.Home11AndSubs
          Scene = PrepareTeam(changeStep, Me.Match.HomeTeam)
        Case Step0.Away11AndSubs
          Scene = PrepareTeam(changeStep, Me.Match.AwayTeam)
        Case Step0.Home11Formation
          Scene = PrepareTeamFormation(changeStep, Me.Match.HomeTeam)
        Case Step0.Away11Formation
          Scene = PrepareTeamFormation(changeStep, Me.Match.AwayTeam)
        Case Step0.Home11MiniFormation
          Scene = PrepareTeamMiniFormation(changeStep, Me.Match.HomeTeam)
        Case Step0.Away11MiniFormation
          Scene = PrepareTeamMiniFormation(changeStep, Me.Match.AwayTeam)
        Case Step0.DoubleTeams
          Scene = PrepareDoubleTeam(changeStep, False)
        Case Step0.DoubleSubs
          Scene = PrepareDoubleTeam(changeStep, True)
        Case Else
          Scene = PrepareTeam(changeStep, Me.Match.HomeTeam)
      End Select

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

#Region "Team scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_Full_Frame"
    scene.SceneDirector = "anim_Full_Frame$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    If GraphicVersions.Instance.SelectedGraphicVersion.UseLongPreview Then
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 90, DirectorAction.Dummy)
    Else
      scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 105, DirectorAction.Dummy)
    End If
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)
    scene.SceneDirectorsIn.Add("Title_change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    ' scene.SceneDirectorsChangeOut.Add("Change", 0, DirectorAction.Rewind)

    scene.SceneDirectorsChangeIn.Add("Change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Change_1_2", 200, DirectorAction.Dummy)
    scene.SceneDirectorsChangeIn.Add("Title_change_1_2", 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add("Title_change_1_2", 200, DirectorAction.Dummy)

    scene.SceneParameters.Add("Veil_On_Off_Vis.active", "1")
    scene.SceneParameters.Add("Title_Sponsor_Vis.active", "1")


    If Not Me.Match Is Nothing Then
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & Me.Match.AwayTeam.BadgeName)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.HomeTeam.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Match.AwayTeam.BadgeName)

    End If

    scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
    scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "1")

    scene.SceneParameters.Add("Veil_Left_Vis ", "1")
    scene.SceneParameters.Add("Veil_Right_Vis ", "1")

    scene.SceneParameters.Add("Stats_Side_" & gSide & "_Bottom_Text", "")



    Dim prefix As String = "Side_" & gSide
    scene.SceneParameters.Add(prefix & "_Match_Ident_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_TeamList_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Double_teams_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Table_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Results_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Formation_Vis.active", "0")
    scene.SceneParameters.Add(prefix & "_Stats_Vis.active", "0")

    Return scene
  End Function

  Public Function PrepareTeam(gSide As Integer, team As Team) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_TeamList_Vis.active", "1")
      scene.SceneParameters.Add("TeamList_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Left", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & team.BadgeName, paramType.Image)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Right", "", paramType.Image)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)


      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", team.Name) ' Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "0")
      scene.SceneParameters.Add("Veil_On_Off_Vis.active", "1")
      scene.SceneParameters.Add("TeamList_Side_" & gSide & "_Control_OMO_GV_Choose", "0")


      For i As Integer = 1 To 11
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "TeamList_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
          scene.SceneParameters.Add(prefix & "Card_Vis.active", IIf(player.YellowCards = 1, "1", "0"))
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
        End If
      Next

      For i As Integer = 12 To 18
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "TeamList_Side_" & gSide & "_Substitutes_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
          scene.SceneParameters.Add(prefix & "Card_Vis.active", IIf(player.YellowCards = 1, "1", "0"))
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareTeamFormation(gSide As Integer, team As Team) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_Formation_Vis.active", "1")
      scene.SceneParameters.Add("Formation_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Left", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & team.BadgeName, paramType.Image)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Right", "", paramType.Image)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "0")

      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", team.Name) ' Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      For i As Integer = 1 To 11
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "Formation_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
          If player.Formation_Pos = 1 Then
            scene.SceneParameters.Add(prefix & "TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & team.GoalKeeperJersey, paramType.Image)
          Else
            scene.SceneParameters.Add(prefix & "TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & team.PlayerJersey, paramType.Image)
          End If
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
        Dim pos As PosicioTactic = team.Tactic.GetPosicioByID(i)
        If Not pos Is Nothing Then
          Dim NewY As Double = player.Formation_Y  ' (((165 * player.Formation_Y) / 280) + 9) * -1
          Dim NewX As Double = player.Formation_X   ' ((170 * player.Formation_X) / 280) - 195

          NewX = NewX / 2.8
          NewY = NewY / 2.8

          scene.SceneParameters.Add(prefix & "Position.position ", CInt(NewX) & " " & CInt(NewY) & " 0")

          NewX = player.Formation_X / 1.8 + 10
          NewY = player.Formation_Y / 1.5 - 80

          scene.SceneParameters.Add(prefix & "Position_Cup.position ", CInt(NewX) & " " & CInt(NewY) & " 0")
        End If


      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareTeamMiniFormation(gSide As Integer, team As Team) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_TeamList_Vis.active", "1")
      scene.SceneParameters.Add("Formation_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Left", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & team.BadgeName, paramType.Image)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Right", "", paramType.Image)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo3D.geom ", GraphicVersions.Instance.SelectedGraphicVersion.Path3DBadges & team.BadgeName, paramType.Geometry)

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_02_Logo ", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & team.BadgeName)

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "0")

      scene.SceneParameters.Add("Veil_Left_Vis ", "1")
      scene.SceneParameters.Add("Veil_Right_Vis ", "0")

      scene.SceneParameters.Add("TeamList_Side_" & gSide & "_Control_OMO_GV_Choose", "1")

      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", team.Name) ' Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      For i As Integer = 1 To 11
        Dim player As Player = team.MatchPlayers.GetPlayerByPosition(i)
        prefix = "Formation_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        prefix = "TeamList_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
        Dim pos As PosicioTactic = team.Tactic.GetPosicioByID(i)
        If Not pos Is Nothing Then
          scene.SceneParameters.Add(prefix & "Position.positio n", CInt(pos.X) & " " & CInt(pos.Y) & " 0")
        End If

        prefix = "Formation_Side_" & gSide & "_Subject_" & Strings.Format(i, "00") & "_"
        prefix = "TeamList_Side_" & gSide & "_Formation_Subject_" & i & "_"
        If Not player Is Nothing Then
          scene.SceneParameters.Add(prefix & "Name", player.Name)
          scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
          If player.Formation_Pos = 1 Then
            scene.SceneParameters.Add(prefix & "TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & team.GoalKeeperJersey, paramType.Image)
          Else
            scene.SceneParameters.Add(prefix & "TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & team.PlayerJersey, paramType.Image)
          End If
        Else
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
        End If
        scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
        If Not pos Is Nothing Then
          Dim NewY As Double = player.Formation_Y  ' (((165 * player.Formation_Y) / 280) + 9) * -1
          Dim NewX As Double = player.Formation_X   ' ((170 * player.Formation_X) / 280) - 195

          NewX = -NewX / 3
          NewY = -NewY / 3 + 20
          scene.SceneParameters.Add(prefix & "Position.position ", CInt(NewX) & " " & CInt(NewY) & " 0")
        End If


      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

  Public Function PrepareDoubleTeam(gSide As Integer, subst As Boolean) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Dim prefix As String = ""
    Dim subjectPrefix As String = ""
    Try
      scene.SceneParameters.Add("Side_" & gSide & "_Double_teams_Vis.active", "1")
      scene.SceneParameters.Add("Double_teams_Side_" & gSide & "_Substitutes_Title", Arabic("Substitutes"))

      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Left", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & Match.AwayTeam.BadgeName, paramType.Image)
      scene.SceneParameters.Add("Badge_Side_" & gSide & "_Subject_01_Geometry_Logo_Right", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & "\" & Match.HomeTeam.BadgeName, paramType.Image)

      scene.SceneParameters.Add("Badge_Left_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Badge_Right_Side_" & gSide & "_Vis.active ", "1")

      Dim teams() As Team = {Me.Match.HomeTeam, Me.Match.AwayTeam}
      Dim sideName() As String = {"Right", "Left"}


      scene.SceneParameters.Add("Title_Side_" & gSide & "_Vis.active ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Control_OMO_GV_Choose ", "1")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Centre_Text", "") ' Me.Match.AwayTeam.Goals & " - " & Me.Match.HomeTeam.Goals)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Right_Text", Me.Match.HomeTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Left_Text", Me.Match.AwayTeam.Name)
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Right_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Team_Left_Text", "")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")
      scene.SceneParameters.Add("Title_Side_" & gSide & "_Table_Vis.active", "0")

      Dim nMin As Integer
      Dim nMax As Integer
      If subst = False Then
        nMin = 1
        nMax = 11
      Else
        nMin = 12
        nMax = 18
      End If
      For iTeam As Integer = 0 To teams.Count - 1
        Dim team As Team = teams(iTeam)
        Dim index As Integer = 1
        For nSubject As Integer = nMin To nMax
          Dim player As Player = team.MatchPlayers.GetPlayerByPosition(nSubject)
          prefix = "Double_teams_" & sideName(iTeam) & "_Side_" & gSide & "_Subject_" & Microsoft.VisualBasic.Strings.Format(index, "00") & "_"
          If Not player Is Nothing Then
            scene.SceneParameters.Add(prefix & "Name", player.Name)
            scene.SceneParameters.Add(prefix & "Number", player.SquadNo)
          Else
            scene.SceneParameters.Add(prefix & "Name", "")
            scene.SceneParameters.Add(prefix & "Number", "")
          End If
          scene.SceneParameters.Add(prefix & "Card_Vis.active", IIf(player.YellowCards = 1, "1", "0"))
          scene.SceneParameters.Add(prefix & "Vis.active", "1")
          index += 1
        Next
        For nSubject = index To 11
          prefix = "Double_teams_" & sideName(iTeam) & "_Side_" & gSide & "_Subject_" & Microsoft.VisualBasic.Strings.Format(index, "00") & "_"
          scene.SceneParameters.Add(prefix & "Name", "")
          scene.SceneParameters.Add(prefix & "Number", "")
          scene.SceneParameters.Add(prefix & "Card_Vis.active", "0")
          scene.SceneParameters.Add(prefix & "Vis.active", "0")
          index += 1

        Next
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function


#End Region
End Class

