Imports VizCommands

Public Class ClockOtherScores
  Inherits GraphicGroup

  Private _otherMatchDays As OtherMatchDays
  Private _otherMatchDay As MatchDay
  Private _otherMatch As OtherMatch

  Public Sub New(match As MatchInfo.Match)
    MyBase.New(match)

    _otherMatchDays = New OtherMatchDays
    DesserializeObjectFromFile(My.Settings.OtherMatchesPath, _otherMatchDays)
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Dummy As Step0 = New Step0("Dummy")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Dummy, True, False))
        For Each matchDays As MatchDay In _otherMatchDays
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(matchDays.MatchDayID, matchDays.MatchDayName), False, False))
        Next
      Else
        Select Case graphicStep.Depth
          Case 0
            _otherMatchDay = _otherMatchDays.GetMatchDay(graphicStep.UID)
            If Not _otherMatchDay Is Nothing Then
              For Each match As OtherMatch In _otherMatchDay.OtherMatches
                If match.LineType = OtherMatch.eOtherMatchLineType.Result Then
                  gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(match.OtherMatchID, match.ToString), True, true))
                End If
              Next
            End If
          Case 1
        End Select

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

        .SceneDirectorsIn.Add("anim_OtherScores", 50, DirectorAction.Dummy)
        .SceneDirectorsIn.Add("anim_OtherScores", 0, DirectorAction.Start)

        .SceneDirectorsOut.Add("anim_OtherScores", 0, DirectorAction.ContinueNormal)

        .SceneDirectorsChangeOut.Add("anim_OtherScores", 0, DirectorAction.ContinueNormal)
        .SceneDirectorsChangeOut.Add("anim_OtherScores", 25, DirectorAction.Dummy)
        .SceneDirectorsChangeIn.Add("anim_OtherScores", 0, DirectorAction.Start)
        .SceneDirectorsChangeIn.Add("anim_OtherScores", 25, DirectorAction.Dummy)

        If _otherMatchDays Is Nothing Then Return Me.Scene
        If _otherMatchDay Is Nothing Then Return Me.Scene
        _otherMatch = _otherMatchDay.GetMatch(graphicStep.UID)
        If _otherMatch Is Nothing Then Return Me.Scene



        .SceneParameters.Add("Clock_Other_Scores_Title", MatchInfo.EnglishToArabicTranslator.Instance.ToArabic(_otherMatchDay.MatchDayName))
        .SceneParameters.Add("Clock_Other_Scores_Home_Team_Name", _otherMatch.Match.HomeTeam.Name)
        .SceneParameters.Add("Clock_Other_Scores_Home_Team_Score", _otherMatch.HomeScore)
        .SceneParameters.Add("Clock_Other_Scores_Away_Team_Name", _otherMatch.Match.AwayTeam.Name)
        .SceneParameters.Add("Clock_Other_Scores_Away_Team_Score", _otherMatch.AwayScore)

      End With

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function
End Class
