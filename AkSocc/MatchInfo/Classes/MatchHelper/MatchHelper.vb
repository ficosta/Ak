Imports MatchInfo

Public Class MatchHelper
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of MatchHelper)(Function() New MatchHelper(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Public Shared ReadOnly Property Instance() As MatchHelper
    Get
      Return _instance.Value
    End Get
  End Property

  Private Sub New()
    _match = New Match()
  End Sub

  Private Sub _match_ActivePeriodStateChanged(period As Period) Handles _match.ActivePeriodStateChanged

  End Sub

  Private Sub _match_ScoreChanged() Handles _match.ScoreChanged

  End Sub

  Private Sub _match_TeamStatValueChanged(team As Team, stat As Stat) Handles _match.TeamStatValueChanged

  End Sub
#End Region

  Private WithEvents _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
    End Set
  End Property

End Class
