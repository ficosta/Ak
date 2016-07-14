Imports AkSocc
Imports MatchInfo
Imports VizCommands

Public Class ControlScoreSingleGoal
  Inherits GraphicGroup

  Public Property IsLocalTeam As Boolean = True
  Public Property Goal As MatchGoal

  Private _team As MatchInfo.Team
  Private _goalType As MatchGoal.eGoalType = MatchGoal.eGoalType.Normal
  Private _playerID As Integer

  Public Sub New(_match As MatchInfo.Match, goal As MatchGoal)
    MyBase.New(_match)

    MyBase.Name = "ControlScoreSingleGoal"
    Me.Goal = goal
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
    Dim gs As New GraphicStep(graphicStep, Me.Name)
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
              Case Step0.Goal
                _goalType = MatchGoal.eGoalType.Normal
                _team = IIf(Me.IsLocalTeam, Me.Match.HomeTeam, Me.Match.AwayTeam)
              Case Step0.PenaltyGoal
                _goalType = MatchGoal.eGoalType.Penalty
                _team = IIf(Me.IsLocalTeam, Me.Match.HomeTeam, Me.Match.AwayTeam)
              Case Step0.OwnGoal
                _goalType = MatchGoal.eGoalType.Own
                _team = IIf(Me.IsLocalTeam, Me.Match.AwayTeam, Me.Match.HomeTeam)
            End Select

            Dim players As New List(Of Player)
            For Each player As MatchInfo.Player In _team.MatchPlayers
              If Not player Is Nothing AndAlso player.Formation_Pos >= 0 Then
                While player.Formation_Pos > players.Count
                  players.Add(Nothing)
                End While
                players(player.Formation_Pos - 1) = player
              End If
            Next

            For Each player As MatchInfo.Player In players
              If Not player Is Nothing Then
                gs.GraphicSteps.Add(New GraphicStep(gs, player.ToString(), True, False))
              Else
                gs.GraphicSteps.Add(New GraphicStep(gs, "", "", False, False, True, False))
              End If
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
    Return Nothing

    Me.Scene = Nothing
    Me.graphicStep = graphicStep

    Try
      Dim player As MatchInfo.Player
      'If Me.IsLocalTeam Then
      '  MyBase.Match.home_goals += 1
      'Else
      '  MyBase.Match.away_goals += 1
      'End If
      For Each aux As MatchInfo.Player In _team.MatchPlayers
        If aux.ToString = graphicStep.Name Then
          'this is the player that scored
          player = aux
          _playerID = player.ID
          'player.MatchStats.Goals += 1
          Goal.PlayerID = _playerID
          Goal.GoalType = _goalType

          Match.UpdateGoal(Goal)
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function


  Public Overrides Function PreProcessingAction() As Boolean
    Return False
    Try
      Dim player As MatchInfo.Player = Nothing
      If Me.IsLocalTeam Then
        MyBase.Match.home_goals += 1
      Else
        MyBase.Match.away_goals += 1
      End If
      For Each aux As MatchInfo.Player In _team.MatchPlayers
        If aux.ToString = graphicStep.Name Then
          'this is the player that scored
          player = aux
          player.MatchStats.Goals += 1
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return MyBase.PostProcessingAction(Nothing)
  End Function

  Public Overrides Function PostProcessingAction(frm As MetroFramework.Forms.MetroForm) As Boolean
    Me.Scene = Nothing
    Me.graphicStep = graphicStep

    Try
      Dim player As MatchInfo.Player
      'If Me.IsLocalTeam Then
      '  MyBase.Match.home_goals += 1
      'Else
      '  MyBase.Match.away_goals += 1
      'End If
      For Each aux As MatchInfo.Player In Me._team.MatchPlayers
        If aux.ToString = graphicStep.Name Then
          'this is the player that scored
          player = aux
          _playerID = player.ID
          'player.MatchStats.Goals += 1
          Goal.PlayerID = _playerID
          Goal.GoalType = _goalType
          player.Goals = Me.Match.MatchGoals.GetGoalsByPlayer(player).Count
          Match.UpdateGoal(Goal)
        End If
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return True
  End Function
End Class
