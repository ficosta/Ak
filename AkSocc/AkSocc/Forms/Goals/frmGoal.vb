Imports MatchInfo
Imports MatchInfo.MatchGoal

Public Class frmGoal
  Private _updating As Boolean = False

  Public Property Match As Match

  Private _goalType As eGoalType
  Private _playerID As Integer
  Private _time As Integer


  Private _matchGoal As MatchGoal
  Public Property MatchGoal As MatchGoal
    Get
      Return _matchGoal
    End Get
    Set(value As MatchGoal)
      _matchGoal = value
      _updating = True
      If Not _matchGoal Is Nothing Then
        _goalType = _matchGoal.GoalType
        _playerID = _matchGoal.PlayerID
        UpdateInterface()
      End If
      _updating = False
    End Set
  End Property

  Private Sub UpdateInterface()
    Try

      Me.MetroRadioButtonNormal.Checked = (_goalType = MatchGoal.eGoalType.Normal)
      Me.MetroRadioButtonOwnGoal.Checked = (_goalType = MatchGoal.eGoalType.Own)
      Me.MetroRadioButtonPenalty.Checked = (_goalType = MatchGoal.eGoalType.Penalty)

      Me.NumericUpDownMinutes.Value = _matchGoal.TimeSecond \ 60
      Me.NumericUpDownSeconds.Value = _matchGoal.TimeSecond Mod 60

      Dim team As Team
      If _matchGoal.TeamGoalID = Me.Match.HomeTeam.ID And _goalType <> eGoalType.Own Then
        team = Me.Match.HomeTeam
      Else
        team = Me.Match.AwayTeam
      End If
      Me.MetroComboBoxPlayer.Items.Clear()
      Dim index As Integer = 0
      For Each player As Player In team.MatchPlayers
        Me.MetroComboBoxPlayer.Items.Add(player)
        If player.ID = _playerID Then
          index = Me.MetroComboBoxPlayer.Items.Count - 1
        End If
      Next
      Me.MetroComboBoxPlayer.SelectedIndex = index
    Catch ex As Exception

    End Try
  End Sub


  Private Sub UpdateComboPlayers()
    Try

    Catch ex As Exception

    End Try
  End Sub

  Public Sub New(match As Match, matchGoal As MatchGoal)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.Match = match
    Me.MatchGoal = matchGoal
  End Sub


  Private Sub frmGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub


  Private Sub MetroRadioButtonNormal_Click(sender As Object, e As EventArgs) Handles MetroRadioButtonNormal.Click
    If _updating Then Exit Sub
    _goalType = eGoalType.Normal
    UpdateInterface()
  End Sub

  Private Sub MetroRadioButtonOwnGoal_Click(sender As Object, e As EventArgs) Handles MetroRadioButtonOwnGoal.Click
    If _updating Then Exit Sub
    _goalType = eGoalType.Own
    UpdateInterface()
  End Sub

  Private Sub MetroRadioButtonPenalty_Click(sender As Object, e As EventArgs) Handles MetroRadioButtonPenalty.Click
    If _updating Then Exit Sub
    _goalType = eGoalType.Penalty
    UpdateInterface()
  End Sub

#Region "Accept / cancel"
  Private Function Apply() As Boolean
    Try
      _matchGoal.PlayerID = CType(Me.MetroComboBoxPlayer.SelectedItem, Player).PlayerID
      _matchGoal.GoalType = _goalType
      _matchGoal.TimeSecond = Me.NumericUpDownMinutes.Value * 60 + Me.NumericUpDownSeconds.Value
      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    If Apply() Then
      Me.DialogResult = DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    If Apply() Then
      Me.DialogResult = DialogResult.OK
      Me.Close()
    End If
  End Sub
#End Region

End Class