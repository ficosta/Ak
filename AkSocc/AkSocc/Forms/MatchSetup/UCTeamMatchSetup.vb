Imports MatchInfo

Public Class UCTeamMatchSetup
  Private _team
  Public Property Team As Team
    Get
      Return _team
    End Get
    Set(value As Team)
      _team = value
      Me.UserControlTactica1.Team = _team
    End Set
  End Property

  Public _tactic As Tactic = New Tactic
  Public Property Tactic As Tactic
    Get
      Return _tactic
    End Get
    Set(value As Tactic)
      _tactic = value
      Me.UserControlTactica1.Tactic = _tactic
    End Set
  End Property

  Public _isLocalTeam As Boolean = True
  Public Property IsLocalTeam As Boolean
    Get
      Return _isLocalTeam
    End Get
    Set(value As Boolean)
      _isLocalTeam = value
      Me.UserControlTactica1.islocalteam = value
    End Set
  End Property


  Private _color As Color = Color.AliceBlue
  Public Property Color() As Color
    Get
      Return _color
    End Get
    Set(ByVal value As Color)
      _color = value
      Me.UserControlTactica1.Color = value
    End Set
  End Property

  Public Sub Save()
    Me.UserControlTactica1.save
  End Sub
End Class

