Imports VizCommands

Public Class ClockPlayerCard
  Inherits GraphicGroup

  Public Sub New(match As MatchInfo.Match)
    MyBase.New(match)
    Me.MustHavePlayer = True
    Me.MustHaveClock = True
    MyBase.KeyCombination = New KeyCombination(Description, Keys.F10, True, False, False, False)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly YellowCard As Step0 = New Step0("Name and Yellow card")
    Public Shared ReadOnly SecondYellowCard As Step0 = New Step0("Name and Second Yellow card")
    Public Shared ReadOnly RedCard As Step0 = New Step0("Name and Red card")

    Public Sub New(key As String)
      MyBase.Key = key
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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.YellowCard, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.SecondYellowCard, True, False))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.RedCard, True, False))
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = ClockControl.GetClockBaseScene()
    Try
      With Me.Scene
        'Directors
        .SceneDirectorsIn.Add("anim_Clock_Substitute", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Player_Card", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Match_Statistics", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Generic_Straps", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Penalties", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_OtherScores", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("anim_Clock_Player_Card", 50, DirectorAction.Dummy)
        .SceneDirectorsIn.Add("anim_Clock_Player_Card", 0, DirectorAction.Start)

        .SceneDirectorsOut.Add("anim_Clock_Player_Card", 0, DirectorAction.ContinueNormal)



        .SceneParameters.Add("Clock_Player_Card_Subject_01_Number", Me.Player.SquadNo)
        .SceneParameters.Add("Clock_Player_Card_Subject_01_Name", Me.Player.Name)
        .SceneParameters.Add("Clock_Player_Card_Subject_01_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Me.Team.BadgeName, paramType.Image)

        Select Case graphicStep.UID
          Case "Name and Yellow card"
            .SceneParameters.Add("Clock_Player_Card_Data_01_Text", Translate("YELLOW CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_02_Text", Translate("YELLOW CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_01_Control_OMO_Cards", "1")
          Case "Name and Second Yellow card"
            .SceneParameters.Add("Clock_Player_Card_Data_01_Text", Translate("SECOND YELLOW CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_02_Text", Translate("RED CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_01_Control_OMO_Cards", "2")
          Case "Name and Red card"
            .SceneParameters.Add("Clock_Player_Card_Data_01_Text", Translate("RED CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_02_Text", Translate("RED CARD"))
            .SceneParameters.Add("Clock_Player_Card_Data_01_Control_OMO_Cards", "3")
        End Select

      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function
End Class
