Public Class GlobalProperties
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of GlobalProperties)(Function() New GlobalProperties(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()

  End Sub

  Public Shared ReadOnly Property Instance() As GlobalProperties
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

  Public Property HomePlayers As String
  Public Property AwayPlayers As String
  Public Property HomeTeam As String
  Public Property AwayTeam As String

  Public Property Possession As String

  Public Function Player(name As String) As MatchInfo.Player
    Return Nothing
  End Function

  Public Function Team(name As String) As MatchInfo.Team
    Return Nothing
  End Function
End Class
