Imports AkSocc
Imports VizCommands

Public Class ClockMatchStatistics
  Inherits GraphicGroup

  Public Sub New(match As MatchInfo.Match)
    MyBase.New(match)
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Dummy As Step0 = New Step0("Dummy")

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
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Dummy, True, False))

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

        .SceneDirectorsIn.Add("anim_Clock_Match_Statistics", 0, DirectorAction.Start)

        .SceneDirectorsOut.Add("anim_Clock_Match_Statistics", 0, DirectorAction.ContinueNormal)

      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function
End Class
