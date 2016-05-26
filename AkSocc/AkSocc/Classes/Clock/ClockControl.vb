Imports VizCommands
Imports MatchInfo

Public NotInheritable Class ClockControl
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of ClockControl)(Function() New ClockControl(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()
    Me.InitScene()
  End Sub

  Public Shared ReadOnly Property Instance() As ClockControl
    Get

      Return _instance.Value
    End Get
  End Property
#End Region

#Region "Properties"
  Private WithEvents _vizControl As VizControl
  Public Property VizControl As VizControl
    Get
      Return _vizControl
    End Get
    Set(value As VizControl)
      _vizControl = value
    End Set
  End Property

  Private WithEvents _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      _matchPeriod = _match.MatchPeriods.ActivePeriod
    End Set
  End Property

  Private WithEvents _matchPeriod As Period

  Public Property ResultatEquipLocal As Decimal = -1D
  Public Property ResultatEquipVisitant As Decimal = -1D
  Public Property Part As String
  Public Property IDPart As Integer
  Public Property Temps As Long
  Public Property PartAfegit As String
  Public Property TempsAfegit As Long = -1
  Public Property TempsTotal As Long
  Public Property Scene As New Scene
  Public Property Visible As Boolean = False
  Public Property RequestVisible As Boolean = False
  Public Property Active As Boolean = False
  Public Property AddedTimeVisible As Boolean = False
  Public Property AddedTimeVisibleAuto As Boolean = True
  Public Property AddedTimeTotalVisible As Boolean = False
  Public Property nPuOffsetTime As Long

  Public Property ShowRedCards As Boolean = False

#End Region



#Region "Initialization"

  Private Sub InitScene()
    Scene = New Scene
    With Scene
      .SceneName = "gfx_Clock"
      .SceneDirector = "DIR_MAIN"
      .VizLayer = SceneLayer.Back
    End With
  End Sub
#End Region

#Region "Period Functions"
  Public Function StartPeriod(part As Integer, Optional startTime As Integer = 0) As Period
    Dim res As Period = Nothing
    Try
      _match.MatchPeriods.StartPeriod(part, startTime)

    Catch ex As Exception

    End Try
    Return _match.MatchPeriods.ActivePeriod
  End Function

  Public Function EndPeriod(part As Integer) As Period
    Try
      _match.MatchPeriods.EndPeriod(part)
    Catch ex As Exception

    End Try
    Return _match.MatchPeriods.ActivePeriod
  End Function

  Private Sub _matchPeriod_ActiveStateChanged(sender As Period) Handles _matchPeriod.ActiveStateChanged

  End Sub
#End Region

#Region "Scene functions"
  Public Sub ShowIdentClock()
    Try
      UpdateAndSendScene()
      _vizControl.DirectorStart("DIR_MAIN", Me.Scene.VizLayer)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideIdentClock()
    Try

      _vizControl.DirectorContinue("DIR_MAIN", Me.Scene.VizLayer)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateScene()
    Try
      With Me.Scene
        .SceneParameters.Add("Clock_Home_Team_Name", _match.HomeTeam.TeamAELCaption1Name)
        .SceneParameters.Add("Clock_Away_Team_Name", _match.AwayTeam.TeamAELCaption1Name)

        .SceneParameters.Add("Clock_Home_Team_Score", _match.home_goals)
        .SceneParameters.Add("Clock_Away_Team_Score", _match.away_goals)

        .SceneParameters.Add("Clock_Home_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.HomeTeam.BadgeName, paramType.Image)
        .SceneParameters.Add("Clock_Away_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.AwayTeam.BadgeName, paramType.Image)

        .SceneParameters.Add("Clock_Half_Indicator_Text", "time")
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateAndSendScene()
    UpdateScene()
    Me.Scene.SendSceneToEngine(_vizControl)
  End Sub

  Private Sub _match_ScoreChanged() Handles _match.ScoreChanged
    UpdateAndSendScene()
  End Sub

#End Region
End Class
