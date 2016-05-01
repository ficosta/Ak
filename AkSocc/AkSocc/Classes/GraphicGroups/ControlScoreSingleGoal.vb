Imports AkSocc
Imports VizCommands

Public Class ControlScoreSingleGoal
  Inherits GraphicGroup

  Public Property IsLocalTeam As Boolean = True

  Private _team As MatchInfo.Team

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "ControlScoreSingleGoal"
    MyBase.ID = 1000
  End Sub


  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Goal As Step0 = New Step0("Goal")
    Public Shared ReadOnly PenaltyGoal As Step0 = New Step0("Penalty goal")
    Public Shared ReadOnly OwnGoal As Step0 = New Step0("Own goal")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, "First step")
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.Goal))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.PenaltyGoal))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.OwnGoal))
      Else
        Select Case gs.Depth
          Case 0
            Select Case gs.Name
              Case Step0.Goal, Step0.PenaltyGoal
                _team = IIf(Me.IsLocalTeam, Me.Match.HomeTeam, Me.Match.AwayTeam)
              Case Step0.OwnGoal
                _team = IIf(Me.IsLocalTeam, Me.Match.AwayTeam, Me.Match.HomeTeam)
            End Select

            For Each player As MatchInfo.Player In _team.MatchPlayers
              gs.GraphicSteps.Add(New GraphicStep(gs, player.ToString(), True, False))
            Next
          Case 1
        End Select

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Try
      Dim player As MatchInfo.Player = Nothing
      If Me.IsLocalTeam Then
        MyBase.Match.home_goals += 1
        MyBase.Match.HomeTeam.MatchStats.Goals.Value += 1
      Else
        MyBase.Match.away_goals += 1
        MyBase.Match.AwayTeam.MatchStats.Goals.Value += 1
      End If
      For Each aux As MatchInfo.Player In _team.MatchPlayers
        If aux.ToString = graphicStep.ChildGraphicStep.Name Then
          'this is the player that scored
          player = aux
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Nothing
  End Function
End Class
