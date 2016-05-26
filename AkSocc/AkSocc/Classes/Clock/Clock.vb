Imports VizCommands
Imports MatchInfo

Public Class Rellotge
  Implements ICloneable

  Public NomEquipLocal As String
  Public ResultatEquipLocal As Decimal = -1D
  Public ResultatEquipVisitant As Decimal = -1D
  Public NomEquipVisitant As String
  Public Part As String
  Public IDPart As Integer
  Public Temps As Long
  Public PartAfegit As String
  Public TempsAfegit As Long = -1
  Public TempsTotal As Long
  Public CPuScene As New Scene
  Public Visible As Boolean = False
  Public RequestVisible As Boolean = False
  Public FakeVisible As Boolean = False
  Public Active As Boolean = False
  Public AddedTimeVisible As Boolean = False
  Public AddedTimeVisibleAuto As Boolean = True
  Public AddedTimeTotalVisible As Boolean = False
  Public nPuOffsetTime As Long

  Public Property VizControl As VizCommands.VizControl

  Public Sub ActualitzarMarcador(ByVal CiPartit As Match, Optional ByVal biForceSend As Boolean = False)
    Dim COld As Rellotge
    If CiPartit Is Nothing Then Exit Sub
    COld = CType(Me.Clone, Rellotge)
    Static nLastClockSent1 As Integer
    Static nLastClockSent2 As Integer
    Static dLastTimeClockSent1 As Date
    Static dLastTimeClockSent2 As Date
    Static bBusy As Boolean = False

    If bBusy Then Exit Sub
    bBusy = True

    Try

      With Me

        .NomEquipLocal = UCase(CiPartit.HomeTeam.TeamAELTinyName)
        .NomEquipVisitant = UCase(CiPartit.AwayTeam.TeamAELTinyName)
        .ResultatEquipLocal = CiPartit.home_goals
        .ResultatEquipVisitant = CiPartit.away_goals

        'If Not CiPartit.MatchPeriods.CPiPeriodeActiu Is Nothing Then
        '  .IDPart = CiPartit.MatchPeriods.CPiPeriodeActiu.Part
        '  .Part = CiPartit.MatchPeriods.CPiPeriodeActiu.NomCurt
        '  .Temps = CiPartit.MatchPeriods.CPiPeriodeActiu.TempsJoc
        '  .TempsAfegit = CiPartit.MatchPeriods.CPiPeriodeActiu.Afegit
        '  .TempsTotal = CiPartit.MatchPeriods.CPiPeriodeActiu.TempsTotal
        '  nPuOffsetTime = CiPartit.MatchPeriods.CPiPeriodeActiu.nPuOffsetTempsJoc
        '  If .Visible = False And .RequestVisible = True Then
        '    'Me.VizControl.LoadScene(Me.CPuScene.Scene)
        '    .EnviarPossicio(gudtCnfg.ConfigMarcador)
        '    .VizControl.ActivateScene(Me.CPuScene.Scene, Me.CPuScene.VizLayer)
        '    .VizControl.DirectorRewindAll(Me.CPuScene.VizLayer)
        '    .VizControl.DirectorStart(Me.CPuScene.DirectorIn, Me.CPuScene.VizLayer)
        '    .AddedTimeTotalVisible = False
        '    .AddedTimeVisible = False
        '    .Visible = True

        '    If CiPartit.MatchPeriods.CPiPeriodeActiu.TempsJoc < CiPartit.MatchPeriods.CPiPeriodeActiu.TempsTotal Then
        '      CiPartit.MatchPeriods.CPiPeriodeActiu.LoadPart()
        '      .VizControl.ClockSet(1, CInt(CiPartit.MatchPeriods.CPiPeriodeActiu.TempsJoc))
        '      nLastClockSent1 = CInt(CiPartit.MatchPeriods.CPiPeriodeActiu.TempsJoc)
        '      dLastTimeClockSent1 = Now
        '      .VizControl.ClockStart(1)
        '    Else
        '      .VizControl.ClockStop(1)
        '      .VizControl.ClockSet(1, CInt(CiPartit.MatchPeriods.CPiPeriodeActiu.TempsTotal))
        '      nLastClockSent1 = CInt(CiPartit.MatchPeriods.CPiPeriodeActiu.TempsTotal)
        '      dLastTimeClockSent1 = Now
        '    End If

        '  ElseIf Me.Visible = True And .RequestVisible = False Then
        '    .VizControl.DirectorContinue(.CPuScene.DirectorIn, .CPuScene.VizLayer)
        '    If Me.AddedTimeVisible Then
        '      .VizControl.DirectorContinue("DIR_Added_Time", .CPuScene.VizLayer)
        '      Me.AddedTimeVisible = False
        '    End If
        '    If Me.AddedTimeTotalVisible Then
        '      .VizControl.DirectorContinue("Extra_Min", .CPuScene.VizLayer)
        '      Me.AddedTimeTotalVisible = False
        '    End If
        '    .Visible = False
        '  End If
        'Else
        '  If .Visible = True Then
        '    .VizControl.DirectorContinue(.CPuScene.DirectorIn, .CPuScene.VizLayer)
        '    If Me.AddedTimeVisible Then
        '      .VizControl.DirectorContinue("DIR_Added_Time", .CPuScene.VizLayer)
        '      Me.AddedTimeVisible = False
        '    End If
        '    If Me.AddedTimeTotalVisible Then
        '      .VizControl.DirectorContinue("Extra_Min", .CPuScene.VizLayer)
        '      Me.AddedTimeTotalVisible = False
        '    End If
        '    .Visible = False
        '  End If
        '  'Me.Part = ""
        '  'Me.Temps = 0
        '  'Me.TempsAfegit = 0
        'End If

        If .Active = False Then

          .VizControl.ActivateScene(.CPuScene.SceneName, .CPuScene.VizLayer)
          .VizControl.SetControlObjectValue("01_Home_Team", .NomEquipLocal, .CPuScene.VizLayer)
          .VizControl.SetControlObjectValue("03_Away_Team", .NomEquipVisitant, .CPuScene.VizLayer)
          .VizControl.SetControlObjectValue("02_Home_Score", CStr(.ResultatEquipLocal), .CPuScene.VizLayer)
          .VizControl.SetControlObjectValue("04_Away_Score", CStr(.ResultatEquipVisitant), .CPuScene.VizLayer)
          '.VizControl.SetControlObjectValue("QUARTER_NUMBER", .Part, .CPuScene.VizLayer)
          .VizControl.SetControlObjectValue("05_Half_Time", CStr(.Part), .CPuScene.VizLayer)
          .Active = True
          'Activem: que s'envii tot per si de cas!
          COld = New Rellotge
        End If

        If .Visible = False And .RequestVisible = True Then
          If Not CiPartit.MatchPeriods.ActivePeriod Is Nothing Then
            Me.VizControl.DirectorStart(.CPuScene.SceneDirector, .CPuScene.VizLayer)
            .Visible = True

            'Mostrem: que s'envii tot per si de cas!
            COld = New Rellotge
          End If
        End If
        If .Visible = True And .AddedTimeVisibleAuto = True And .AddedTimeVisible = False And COld.AddedTimeVisible = False And .Temps >= .TempsTotal And .TempsTotal > 0 Then
          'Mostrar el temps afegit!
          .AddedTimeVisible = True
          .VizControl.ClockStop(1)
          .VizControl.ClockSet(1, CInt(CiPartit.MatchPeriods.ActivePeriod.TotalTime))
          nLastClockSent1 = CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime)
          dLastTimeClockSent1 = Now
          .VizControl.ClockSet(2, CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime - CiPartit.MatchPeriods.ActivePeriod.TotalTime))
          nLastClockSent2 = CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime - CiPartit.MatchPeriods.ActivePeriod.TotalTime)
          dLastTimeClockSent2 = Now
          .VizControl.ClockStart(2)
          .VizControl.DirectorStart("DIR_Added_Time", .CPuScene.VizLayer)
        ElseIf .AddedTimeVisibleAuto = True And .AddedTimeVisible = True And COld.AddedTimeVisible = True And Not .Temps >= .TempsTotal And .TempsTotal > 0 Then
          'Ocultar el temps afegit!
          .AddedTimeVisible = False
          .VizControl.DirectorContinue("DIR_Added_Time", .CPuScene.VizLayer)
        End If

        'Això sempre!
        If .Visible And False Then
          If .Temps < .TempsTotal Then
            '.VizControl.a("07_Clock", SecondsToMMSS(.Temps) & ";")
            '.VizControl.SetControlObjectValue("07_Clock", "TIME SET " & SecondsToMMSS(.Temps), .CPuScene.VizLayer)
            .VizControl.ClockSet(1, CInt(.Temps))
            nLastClockSent1 = CInt(.Temps)
            dLastTimeClockSent1 = Now
            .VizControl.ClockStart(1)

            .VizControl.SendDataPoolValue("ADDED_CLOCK", SecondsToMMSS(0) & ";")

          Else
            .VizControl.SendDataPoolValue("MAIN_CLOCK", SecondsToMMSS(.TempsTotal) & ";")
            .VizControl.SendDataPoolValue("ADDED_CLOCK", SecondsToMMSS(.Temps - .TempsTotal) & ";")

          End If
          If .TempsAfegit = 0 Then
            If Me.AddedTimeTotalVisible = True Then
              Me.AddedTimeTotalVisible = False
              .VizControl.DirectorRewind("DIR_TOTAL_ADDED", .CPuScene.VizLayer)
            End If
          Else
            If Me.AddedTimeTotalVisible = False Then
              Me.AddedTimeTotalVisible = True
              .VizControl.DirectorStart("Extra_Min", .CPuScene.VizLayer)
            End If
          End If
        End If
        'Enviar només si hem canviat!
        If .NomEquipLocal <> COld.NomEquipLocal Or biForceSend Then
          .VizControl.SetControlObjectValue("01_Home_Team", .NomEquipLocal, .CPuScene.VizLayer)
        End If
        If .NomEquipVisitant <> COld.NomEquipVisitant Or biForceSend Then
          .VizControl.SetControlObjectValue("03_Away_Team", .NomEquipVisitant, .CPuScene.VizLayer)
        End If
        If .ResultatEquipLocal <> COld.ResultatEquipLocal Or biForceSend Then
          .VizControl.SetControlObjectValue("02_Home_Score", CStr(.ResultatEquipLocal), .CPuScene.VizLayer)
        End If
        If .ResultatEquipVisitant <> COld.ResultatEquipVisitant Or biForceSend Then
          .VizControl.SetControlObjectValue("04_Away_Score", CStr(.ResultatEquipVisitant), .CPuScene.VizLayer)
        End If
        If .TempsAfegit <> COld.TempsAfegit Or biForceSend Then
          If .TempsAfegit <> 0 Then
            .VizControl.SetControlObjectValue("06_Extra_Min", CStr(.TempsAfegit) & "'", .CPuScene.VizLayer)
            If .AddedTimeTotalVisible = False Then
              .VizControl.DirectorStart("Extra_Min", .CPuScene.VizLayer)
              .AddedTimeTotalVisible = True
            End If
          Else
            .VizControl.SetControlObjectValue("06_Extra_Min", "", .CPuScene.VizLayer)
            If .AddedTimeTotalVisible = True Then
              .VizControl.DirectorContinue("Extra_Min", .CPuScene.VizLayer)
              .AddedTimeTotalVisible = False
            End If
          End If
        End If
        If .Part <> COld.Part Or biForceSend Then
          Me.CPuScene.SceneParameters.Add("05_Half_Time", "1a pro")
          If .Part <> "1P" And .Part <> "2P" And .Part <> "3P" And .Part <> "4P" Then
            .VizControl.SetControlObjectValue("05_Half_Time", " ", .CPuScene.VizLayer)
            Me.CPuScene.SceneParameters.Add("05_Half_Time", " ")
          Else
            Select Case .Part
              Case "1P"
                Me.CPuScene.SceneParameters.Add("05_Half_Time", CStr(.Part))
              Case "2P"
                Me.CPuScene.SceneParameters.Add("05_Half_Time", CStr(.Part))
              Case "3P"
                '.VizControl.SetControlObjectValue("05_Half_Time", "1a pro", .CPuScene.VizLayer)
                Me.CPuScene.SceneParameters.Add("05_Half_Time", CStr(.Part))
              Case "4P"
                '.VizControl.SetControlObjectValue("05_Half_Time", "2a pro", .CPuScene.VizLayer)
                Me.CPuScene.SceneParameters.Add("05_Half_Time", CStr(.Part))
              Case Else
                '.VizControl.SetControlObjectValue("05_Half_Time", CStr(.Part), .CPuScene.VizLayer)
                Me.CPuScene.SceneParameters.Add("05_Half_Time", CStr(.Part))
            End Select
          End If
          Me.CPuScene.SendSceneToEngine(Me.VizControl)
        End If

        If .nPuOffsetTime <> COld.nPuOffsetTime Or biForceSend Then
          If Not CiPartit.MatchPeriods.ActivePeriod Is Nothing AndAlso CiPartit.MatchPeriods.ActivePeriod.PlayingTime < CiPartit.MatchPeriods.ActivePeriod.TotalTime Then
            If DateDiff(DateInterval.Second, dLastTimeClockSent1, Now) <> CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime) - nLastClockSent1 Then
              Debug.Print(DateDiff(DateInterval.Second, Now, dLastTimeClockSent1) & " " & CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime) - nLastClockSent1)
              CiPartit.MatchPeriods.ActivePeriod.LoadPart()
              .VizControl.ClockSet(1, CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime))
              nLastClockSent1 = CInt(CiPartit.MatchPeriods.ActivePeriod.PlayingTime)
              dLastTimeClockSent1 = Now
              .VizControl.ClockStart(1)
            End If
          Else
            .VizControl.ClockStop(1)
            If Not CiPartit.MatchPeriods.ActivePeriod Is Nothing Then
              .VizControl.ClockSet(1, CInt(CiPartit.MatchPeriods.ActivePeriod.TotalTime))
              nLastClockSent1 = CInt(CiPartit.MatchPeriods.ActivePeriod.TotalTime)
            End If
            dLastTimeClockSent1 = Now
          End If
        End If
      End With

    Catch ex As Exception

    End Try
    bBusy = False
  End Sub

  Public Sub New()
    CPuScene = New Scene
    With CPuScene
      .SceneName = "Marcador_Permanent"
      .SceneDirector = "DIR_Clock"
      .VizLayer = SceneLayer.Back
    End With
  End Sub

  Public Function Clone() As Object Implements System.ICloneable.Clone
    Dim CClone As New Rellotge

    Try
      With CClone
        .Active = Me.Active
        .VizControl = Me.VizControl
        .CPuScene = Me.CPuScene
        .NomEquipLocal = Me.NomEquipLocal
        .NomEquipVisitant = Me.NomEquipVisitant
        .Part = Me.Part
        .PartAfegit = Me.PartAfegit
        .ResultatEquipLocal = Me.ResultatEquipLocal
        .ResultatEquipVisitant = Me.ResultatEquipVisitant
        .Temps = Me.Temps
        .TempsAfegit = Me.TempsAfegit
        .Visible = Me.Visible
        .AddedTimeVisible = Me.AddedTimeVisible
        .AddedTimeVisibleAuto = Me.AddedTimeVisibleAuto
        .AddedTimeTotalVisible = Me.AddedTimeTotalVisible
      End With

    Catch ex As Exception
    End Try
    Return CClone
  End Function

  Public Sub IniciarRellotge(ByVal CiPartit As Match)
    Try
      Me.VizControl.LoadScene(Me.CPuScene.SceneName)
      Me.VizControl.ActivateScene(Me.CPuScene.SceneName, Me.CPuScene.VizLayer)
      Me.VizControl.DirectorRewindAll(Me.CPuScene.VizLayer)

      Me.Active = False
      Me.Visible = False
      Me.RequestVisible = False
      Me.AddedTimeVisible = False
      Me.AddedTimeVisibleAuto = True

      If Not CiPartit.MatchPeriods.ActivePeriod Is Nothing Then
        Me.ActualitzarMarcador(CiPartit)
        'Me.VizControl.DirectorStart(Me.CPuScene.DirectorIn, Me.CPuScene.VizLayer)
        Me.RequestVisible = True
      Else
      End If

    Catch ex As Exception

    End Try
  End Sub

End Class
