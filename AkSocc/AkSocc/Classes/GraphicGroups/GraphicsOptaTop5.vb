Imports AkSocc
Imports MatchInfo
Imports VizCommands


Public Class GraphicsOptaTop5

  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsOptaTop5"
    MyBase.ID = 1
    MyBase.MustHaveOPTA = True
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F11, False, False, False, False)
    Me.Scene = Me.InitDefaultScene(1)
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
        For Each aux As Opta_Term_Stat In AppSettings.Instance.OptaStatsPlayer
          If aux.AppName <> "" And aux.ShowInLower Then
            gs.GraphicSteps.Add(New GraphicStep(gs, aux.AppName, aux.AppName, True, True))
          End If
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
      Dim statAppName As String = graphicStep.UID

      For Each aux As Opta_Term_Stat In AppSettings.Instance.OptaStatsPlayer
        If aux.AppName = statAppName Then
          'gs.GraphicSteps.Add(New GraphicStep(gs, aux.AppName, aux.AppName, True, True))
          Me.Scene = Me.PrepareRanking(changeStep, aux)
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function



#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_leftframer"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Change_" & ((gSide) Mod 2 + 1) & "_" & ((gSide + 1) Mod 2) + 1
    changeAnim = "Change_1_2"
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneParameters.Add("LeftFramer_Y_Position", "0")

    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gSide & "_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gSide & "_Title_Type", "0")
    scene.SceneParameters.Add("LeftFramer_Table_Vis.active", "1")
    scene.SceneParameters.Add("LeftFramer_Stats_Vis.active", "0")


    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Center", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Left", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Right", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Left", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Right", "")


    Dim prefix As String = ""
    For i As Integer = 1 To 7
      scene.SceneParameters.Add("LeftFramer_Stats_Side_" & gSide & "_Line_" & i & "_Vis.active", "0")

      prefix = "LeftFramer_Stats_Side_" & gSide & "_Subject_0" & i & "_"


      scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", 0)
      scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", 0)

      scene.SceneParameters.Add(prefix & "Left_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Left_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Right_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Stat_Name", "stat_name")
      scene.SceneParameters.Add(prefix & "Team_Name", "team name " & i)
    Next

    Return scene
  End Function


  Private Function PrepareRanking(gSide As Integer, optaStat As Opta_Term_Stat) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      Dim players As New List(Of Player)
      Dim prefix As String = ""
      Dim count As Integer = 0

      For Each player As Player In Me.Match.HomeTeam.MatchPlayers
        players.Add(player)
      Next
      For Each player As Player In Me.Match.AwayTeam.MatchPlayers
        players.Add(player)
      Next
      
      Config.Instance.PlayerSortType = Config.ePlayerSortType.OptaStat
      Config.Instance.PlayerSortStatName = optaStat.OPTAName

      players.Sort()
      scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Right", Arabic(optaStat.AppName))

      Debug.Print("Ranking " & optaStat.AppName & " (" & optaStat.OPTAName & ")")
      count = 0
      For i As Integer = 0 To Math.Min(5, players.Count) - 1
        Dim player As Player = players(i)
        prefix = "LeftFramer_Table_Side_" & gSide & "_Subject_" & Strings.Format(i + 1, "00") & "_"

        scene.SceneParameters.Add(prefix & "Number", (i + 1))
        scene.SceneParameters.Add(prefix & "Name", player.Name)
        scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "3")

        For j As Integer = 1 To 6
          scene.SceneParameters.Add(prefix & "Data_0" & j & "_Text", "")
        Next
        If player.optaGetValue(optaStat.OPTAName) <> "0" And player.optaGetValue(optaStat.OPTAName) <> "" Then
          Debug.Print(vbTab & (i + 1) & ". " & player.ToString & vbTab & player.optaGetValue(optaStat.OPTAName))
          scene.SceneParameters.Add(prefix & "Data_06_Text", player.optaGetValue(optaStat.OPTAName))
          scene.SceneParameters.Add("LeftFramer_Table_Side_" & gSide & "_Line_" & (i + 1) & "_Vis.active", "1")
          count += 1
        Else
          scene.SceneParameters.Add(prefix & "Data_06_Text", "")
          scene.SceneParameters.Add("LeftFramer_Table_Side_" & gSide & "_Line_" & (i + 1) & "_Vis.active", "0")
        End If
      Next
      For i As Integer = count To 7
        prefix = "LeftFramer_Table_Side_" & gSide & "_Subject_" & Strings.Format(i + 1, "00") & "_"
        scene.SceneParameters.Add(prefix & "Number", "")
        scene.SceneParameters.Add(prefix & "Name", "")
        scene.SceneParameters.Add(prefix & "Control_OMO_Arrow", "3")

        For j As Integer = 1 To 6
          scene.SceneParameters.Add(prefix & "Data_0" & j & "_Text", "")
        Next

        scene.SceneParameters.Add("LeftFramer_Table_Side_" & gSide & "_Line_" & (i + 1) & "_Vis.active", "0")
      Next
      scene.SceneParameters.Add("LeftFramer_Table_Side_" & gSide & "_Control_OMO_GV_Choose", count)

      Dim y_position As Double
      Dim min_y_position As Double = 100


      'We only send this the first time!
      y_position = 0 - min_y_position + count * (min_y_position / 7)
      scene.SceneParameters.Add("LeftFramer_Y_Position.position", "0 " & CInt(y_position) & " 0 ")

    Catch ex As Exception

    End Try
    Return scene
  End Function

#End Region
End Class

