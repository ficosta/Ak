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

  Public Shared Function GetClockBaseScene() As Scene
    Dim scene As New Scene
    With scene
      .SceneName = "gfx_Clock"
      .SceneDirector = "DIR_MAIN"
      .VizLayer = SceneLayer.Back
    End With
    Return scene
  End Function

  Private Sub InitScene()
    Me.Scene = GetClockBaseScene()
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

#Region "Visibility control"

  Private _request As Boolean = False
  Private _clockVisible As Boolean = False
  Private _clockOnAir As Boolean = False

  Public Property ClockVisible As Boolean
    Get
      Return _clockVisible
    End Get
    Set(value As Boolean)
      _clockVisible = value
      UpdateClockVisibility()
    End Set
  End Property

  Public ReadOnly Property ClockOnAir As Boolean
    Get
      Return _clockOnAir
    End Get
  End Property

  Public Sub UpdateClockVisibility()
    Try
      If _match.MatchPeriods.ActivePeriod Is Nothing Then
        _request = False
      ElseIf _match.MatchPeriods.ActivePeriod.Activa Then
        _request = True
      Else
        _request = False
      End If

      If _clockOnAir <> _request Then
        'we must do something
        If _clockOnAir Then
          'we must hide it
          Me.HideIdentClock()
        Else
          'we must show it
          Me.ShowIdentClock()
        End If
      End If

    Catch ex As Exception

    End Try
  End Sub

#End Region

#Region "Scene functions"
  Public Sub ShowIdentClock()
    Try
      UpdateAndSendScene()
      '_vizControl.DirectorStart("DIR_MAIN", Me.Scene.VizLayer)
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideIdentClock()
    Try

      '_vizControl.DirectorContinue("DIR_MAIN", Me.Scene.VizLayer)  
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateRunningClock()
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub

      Dim clockIndex As Integer = 0

      _vizControl.ClockSet(clockIndex, _match.MatchPeriods.ActivePeriod.PlayingTime + _match.MatchPeriods.ActivePeriod.StartOffset)
      If _match.MatchPeriods.ActivePeriod.Activa Then
        _vizControl.ClockStart(clockIndex)
      Else
        _vizControl.ClockStop(clockIndex)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateScene()
    Try
      With Me.Scene
        'Directors
        .SceneDirectorsIn.Add("DIR_MAIN", 0, DirectorAction.Start)

        .SceneDirectorsIn.Add("Added_Time_Text", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("Added_Time_Clock", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("Team_Left_Cards", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("Team_Right_Cards", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)
        
        .SceneDirectorsIn.Add("anim_Clock_Substitute", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Player_Card", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Match_Statistics", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Generic_Straps", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Penalties", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_OtherScores", 0, DirectorAction.Rewind)

        .SceneDirectorsOut.Add("DIR_MAIN", 0, DirectorAction.ContinueNormal)

        'Control objects
        .SceneParameters.Add("Clock_Home_Team_Name", _match.HomeTeam.Name)
        .SceneParameters.Add("Clock_Away_Team_Name", _match.AwayTeam.Name)

        .SceneParameters.Add("Clock_Home_Team_Score", _match.home_goals)
        .SceneParameters.Add("Clock_Away_Team_Score", _match.away_goals)

        .SceneParameters.Add("Clock_Home_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.HomeTeam.BadgeName, paramType.Image)
        .SceneParameters.Add("Clock_Away_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.AwayTeam.BadgeName, paramType.Image)

        Dim sTime As String = ""
        If _match.MatchPeriods.ActivePeriod Is Nothing Then
          sTime = ""
        Else
          sTime = EnglishToArabicTranslator.Instance.ToArabic(_match.MatchPeriods.ActivePeriod.Nom)
        End If

        .SceneParameters.Add("Clock_Half_Indicator_Text", sTime)

        'clock control
        UpdateRunningClock()
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
