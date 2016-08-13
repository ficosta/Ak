Imports System.ComponentModel
Imports System.IO
Imports AkSocc
Imports AkSocc.FTPSyncManager
Imports MatchInfo
Imports VizCommands

Public Class frmMain
#Region "Properties and variables"
  Private WithEvents _match As MatchInfo.Match
  Public ReadOnly Property Match As Match
    Get
      Return _match
    End Get
  End Property

  Private WithEvents _F9Helper As COptaF9Helper

  Private WithEvents _optaMatches As Matches
  Private WithEvents _F26Helper As COptaF26Helper

  Private WithEvents _statGraphic As GraphicStep
  Private WithEvents _dlgChoosWithPreview As FormChoose
  Private WithEvents _vizControl As VizCommands.VizControl
  Private WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _keyCapture As KeyCapture
  Private _scenes As New List(Of String)

  Private WithEvents _otherMatchDays As New OtherMatchDays

  Private WithEvents _clockControl As ClockControl = ClockControl.Instance

  Private WithEvents _asyncStatWriter As AsyncStatWriter = AsyncStatWriter.Instance
  Private WithEvents _notifier As GlobalNotifier = GlobalNotifier.Instance

  Private _selectedPlayer As Player = Nothing
  Public ReadOnly Property SelectedPlayer As Player
    Get
      Return _selectedPlayer
    End Get
  End Property

  Private _selectedTeam As Team = Nothing
  Public ReadOnly Property SelectedTeam As Team
    Get
      Return _selectedTeam
    End Get
  End Property

  Private WithEvents _loggerComm As LoggerComm = LoggerComm.Instance

  Private WithEvents _ftpSyncManager As FTPSyncManager = FTPSyncManager.Instance
#End Region

#Region "Constructor"

#End Region

#Region "Interface functions"

#End Region

#Region "Form events"
  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.LabelAppVersion.Text = "v " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "   "
  End Sub

  Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Me.Cursor = Cursors.WaitCursor
      Application.DoEvents()

      If AppSettings.Instance.ShowSettingsOnStartup Then
        ShowOptions(Me)
      End If

      Application.DoEvents()


      InitializeConnectionStrings()
      InitControls()
      SelectMatch()
      _otherMatchDays.LoadOthers()
      InitializeKeyCapture()
      InitRender()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.Cursor = Cursors.Default

  End Sub
#End Region

#Region "Initialize functions"
  Private Sub InitControls()
    Try
      InitPlayerControls()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.UpdateStatusLabel()
  End Sub

  Private Sub InitRender()
    Try
      If _checkSocketConnection Is Nothing Then
        _checkSocketConnection = New CheckSocketConnection
        _checkSocketConnection.CheckConnection(AppSettings.Instance.VizrtHost, AppSettings.Instance.VizrtPort)
      ElseIf _checkSocketConnection.LastSocketState = CheckSocketConnection.eSocketCheckState.Connected Then
        'the connection is good
        If Not _vizControl Is Nothing Then _vizControl.CloseSockets()
        Me.UpdateStatusLabel()
        _vizControl = New VizCommands.VizControl
        _vizControl.Config = New VizCommands.tyConfigVizrt
        _vizControl.Config.TCPHost = AppSettings.Instance.VizrtHost
        _vizControl.Config.TCPPort = AppSettings.Instance.VizrtPort
        _vizControl.Config.SceneBasePath = AppSettings.Instance.ScenePath
        _vizControl.InitializeSockets()

        Dim pvwConfig As New VizCommands.tyConfigVizrt
        pvwConfig.TCPHost = AppSettings.Instance.VizrtHost
        pvwConfig.TCPPort = AppSettings.Instance.VizrtPreviewPort
        pvwConfig.SceneBasePath = AppSettings.Instance.ScenePath

        _previewControl = New VizCommands.PreviewControl(pvwConfig, AppSettings.Instance.PreviewLocalPath, AppSettings.Instance.PreviewRemotePath)

        _clockControl.VizControl = _vizControl
      Else
        'no connection or we dind't check it out yet!
        If TimerVizrtConnection.Enabled = True Then
          'we are already on it, nothing to do
        Else
          TimerVizrtConnection.Interval = 5000
          TimerVizrtConnection.Enabled = True
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.UpdateStatusLabel()
  End Sub
#End Region

#Region "Tool strip"
  Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click
    Try
      If ShowOptions(Me) Then
        ' Me.InitRender()
        UpdateConfig()
      End If
      Me.UpdateStatusLabel()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ToolStripButtonSelectMatch_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSelectMatch.Click
    SelectMatch()
  End Sub

  Private Sub ToolStripButtonMatchSetup_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMatchSetup.Click
    MatchSetup()
  End Sub


  Private Sub ToolStripButtonMatchDay_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMatchDay.Click
    Try
      ShowOtherMatches()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ToolStripButtonClassification_Click(sender As Object, e As EventArgs) Handles ToolStripButtonClassification.Click
    Try
      Dim frm As New FormClassification(_match.competition_id)
      frm.Show(Me)


      If _match Is Nothing Then Exit Sub
      Dim _matches As New Matches()
      _matches = Matches.GetMatchesForCompetition(_match.competition_id)
      Dim classification As New Classification(_matches)

      For Each team As TeamClassificationForMatchDay In classification.LastAvailableClassificationForMatchDay.TeamClassificationList
        Debug.Print(team.ToString)
      Next

    Catch ex As Exception

    End Try

  End Sub

  Private Sub UpdateToolStrip()

  End Sub
#End Region

#Region "Match functions"
  Public Function SelectMatch() As Boolean
    Dim cursor = Me.Cursor
    Me.Cursor = Cursors.WaitCursor
    Try
      Config.Instance.Silent = True
      Config.Instance.AsyncDataWrites = False
      _updating = True
      Dim dlg As New FormMatchSelector
      'Dim aux As MetroFramework.Forms.MetroForm = TryCast(Me, MetroFramework.Forms.MetroForm)
      Dim aux As System.Windows.Forms.Form = TryCast(Me, System.Windows.Forms.Form)
      If dlg.ShowDialog(Me) = DialogResult.OK Then
        'match selected!
        InitMatchInfo(dlg.SelectedMatchId)
        MatchSetup()
        UpdateConfig()
        If _match.optaID > 0 Then
          Dim file As String = "srml-" & AppSettings.Instance.OptaCompetitionID & "-" & AppSettings.Instance.OptaSeasonID & "-f" & _match.optaID & "-matchresults.xml"
          file = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, file)
          _F9Helper = New COptaF9Helper(file, _match)
        Else
          _F9Helper = Nothing
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Config.Instance.Silent = False
    UpdateStatusLabel()
    _updating = False
    Me.Cursor = cursor
    Return True
  End Function

  Private Sub UpdateConfig()
    Try
      Me.InitRender()

      If Not _vizControl Is Nothing Then
        _vizControl.Config.SceneBasePath = GraphicVersions.Instance.SelectedGraphicVersion.Path
      End If
      If Not _previewControl Is Nothing Then

        Dim pvwConfig As New VizCommands.tyConfigVizrt
        pvwConfig.TCPHost = AppSettings.Instance.VizrtHost
        pvwConfig.TCPPort = AppSettings.Instance.VizrtPreviewPort
        pvwConfig.SceneBasePath = AppSettings.Instance.ScenePath

        _previewControl.Config = pvwConfig
      End If

      FTPSyncManager.Instance.Initialize(AppSettings.Instance.OptaFTPServer, AppSettings.Instance.OptaFTPPath, AppSettings.Instance.OptaFTPUser, AppSettings.Instance.OptaFTPPassword, AppSettings.Instance.OptaDefaultFolder)
      FTPSyncManager.Instance.Enabled = True

      _optaMatches = New Matches()
      _F26Helper = New COptaF26Helper(AppSettings.Instance.OptaDefaultFolder, _optaMatches)

    Catch ex As Exception

    End Try
  End Sub

  Public Function MatchSetup() As Boolean
    Try

      If _match Is Nothing Then Return False
      Dim dlg As New FormMatchSetup(_match)
      'Dim aux As MetroFramework.Forms.MetroForm = TryCast(Me, MetroFramework.Forms.MetroForm)
      Dim aux As System.Windows.Forms.Form = TryCast(Me, System.Windows.Forms.Form)

      If dlg.ShowDialog(Me) = DialogResult.OK Then
        InitMatchInfo(_match)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return True
  End Function

  Private Sub InitMatchInfo(id As Integer)
    Me.Cursor = Cursors.WaitCursor
    Try
      'Dim matches As New MatchInfo.Matches()

      Dim match As New Match(id) ' = matches.GetMatch(id)
      match.GetMatch()

      match.HomeTeam.GetFullMatchData()
      match.AwayTeam.GetFullMatchData()

      InitMatchInfo(match)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub InitMatchInfo(match As MatchInfo.Match)
    Me.Cursor = Cursors.WaitCursor
    Try

      If Not _match Is Nothing AndAlso _match.match_id <> match.match_id Then
        ReleaseDataBinding()
      End If

      _match = match
      If Not _match Is Nothing Then
        _match.HomeTeam.GetDataFromDB()
        _match.AwayTeam.GetDataFromDB()


        _match.GetMatchEventsFromDB()

        InitTeamPlayerControls(_match.HomeTeam, _homePlayerControls)
        InitTeamPlayerControls(_match.AwayTeam, _awayPlayerControls)

        Me.LabelAwayTeamName.Text = _match.AwayTeam.TeamAELCaption1Name
        Me.LabelHomeTeamName.Text = _match.HomeTeam.TeamAELCaption1Name

        Me.LabelAwayTeamShortName.Text = _match.AwayTeam.TeamAELTinyName
        Me.LabelHomeTeamShortName.Text = _match.HomeTeam.TeamAELTinyName

        Me.MetroLabelPeriodTime.Text = ""
        Me.MetroLabelPeriodName.Text = ""

        EngageDataBinding()

        _match.SaveToDBEnabled = True
      Else
        Me.LabelAwayTeamName.Text = ""
        Me.LabelHomeTeamName.Text = ""

      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub ReleaseDataBinding()
    Try
      ' Me.LabelHomeTeamResult.DataBindings.Clear()
      ' Me.LabelAwayTeamResult.DataBindings.Clear()
      Me.LabelHomeTeamResult.Text = ""
      Me.LabelAwayTeamResult.Text = ""
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub EngageDataBinding()
    Try
      ' Me.LabelHomeTeamResult.DataBindings.Clear()
      'Me.LabelAwayTeamResult.DataBindings.Clear()

      ' Me.LabelHomeTeamResult.DataBindings.Add("Text", _match.HomeTeam.MatchStats.GoalStat, "Value")
      ' Me.LabelAwayTeamResult.DataBindings.Add("Text", _match.AwayTeam.MatchStats.GoalStat, "Value")
      Me.LabelHomeTeamResult.Text = _match.home_goals
      Me.LabelAwayTeamResult.Text = _match.away_goals

      _clockControl = ClockControl.Instance
      _clockControl.VizControl = _vizControl
      _clockControl.Match = _match
      UpdateClockInterface()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Status label"
  Private Sub UpdateStatusLabel()
    Try
      If _vizControl Is Nothing Then
        Me.LabelVizEngine.BackColor = Color.Red
      Else
        Select Case _vizControl.SocketStateTCP
          Case VizCommands.eSocketState.Connected
            Me.LabelVizEngine.BackColor = Color.Green
          Case VizCommands.eSocketState.Connecting
            Me.LabelVizEngine.BackColor = Color.Orange
          Case VizCommands.eSocketState.Disconnected
            Me.LabelVizEngine.BackColor = Color.Red
          Case VizCommands.eSocketState.ErrorState
            Me.LabelVizEngine.BackColor = Color.Red
        End Select
      End If
      Me.LabelGraphicVersion.Text = GraphicVersions.Instance.SelectedGraphicVersion.Name
      If _match Is Nothing Then
        Me.ButtonOptaID.Text = "NO MATCH"
        ButtonOptaID.Enabled = False
        Me.ButtonOptaID.BackColor = Color.LightGray
      ElseIf _match.optaID > 0 Then
        Me.ButtonOptaID.Text = "OPTA ID " & _match.optaID
        Me.ButtonOptaID.BackColor = Color.LightGreen
        ButtonOptaID.Enabled = True
      Else
        Me.ButtonOptaID.Text = "undefined OPTA ID"
        Me.ButtonOptaID.BackColor = Color.LightSalmon
        ButtonOptaID.Enabled = True
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub ButtonOptaID_Click(sender As Object, e As EventArgs) Handles ButtonOptaID.Click
    Try
      If _match Is Nothing Then Exit Sub

      Dim dlg As New frmOptaFixtures
      dlg.MatchOptaID = _match.optaID
      If dlg.ShowDialog(Me) = DialogResult.OK Then
        _match.optaID = dlg.MatchOptaID
        _match.Update()

        Dim file As String = "srml-" & AppSettings.Instance.OptaCompetitionID & "-" & AppSettings.Instance.OptaSeasonID & "-f" & _match.optaID & "-matchresults.xml"
        file = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, file)
        _F9Helper = New COptaF9Helper(file, _match)
      End If
      UpdateStatusLabel()
    Catch ex As Exception

    End Try
  End Sub
#End Region

#Region "Team / player"
  Private _updating As Boolean

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.StyleManager = msmMain
    msmMain.Theme = MetroFramework.MetroThemeStyle.Light

  End Sub

  Private Sub TeamViewer1_SelectedPlayerChanged(sender As TeamViewer, player As Player)
    If _updating Then Exit Sub
    _updating = True

    'TeamViewerAway.SelectedPlayer = Nothing
    _updating = False

  End Sub

  Private Sub TeamViewer2_SelectedPlayerChanged(sender As TeamViewer, player As Player)
    If _updating Then Exit Sub
    _updating = True

    'TeamViewerHome.SelectedPlayer = Nothing
    _updating = False
  End Sub

#End Region

#Region "Graphics"

  Private Sub StartGraphic(statGraphic As GraphicGroup)
    Try
      _dlgChoosWithPreview = New FormChoose(_vizControl, _previewControl, statGraphic)

      If _dlgChoosWithPreview.ShowDialog(Me) Then
        ''what you gonna do?
        '_dlgChoosWithPreview.GraphicGroup.PreProcessingAction()
        ''send scene to engine, play animations
        'Dim scene As VizCommands.Scene = _dlgChoosWithPreview.GraphicGroup.PrepareScene(_dlgChoosWithPreview.GraphicGroup.graphicStep)
        'scene.SendSceneToEngine(_vizControl)
        'scene.StartSceneDirectors(_vizControl, VizCommands.Scene.TypeOfDirectors.InDirectors)
        ''What are we gonna do next?
        '_dlgChoosWithPreview.GraphicGroup.PostProcessingAction()

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Graphic buttons"
  Private Function StartGraphic(name As String) As Boolean
    Dim res As Boolean = False
    Dim cursor As Cursor = Me.Cursor
    Me.Cursor = Cursors.WaitCursor
    Try
      Select Case name
        Case "ToggleClockControl"
          Me.ToggleClockControl()
        Case Else
          'this may be a graphic 
          For Each myType As Type In GraphicGroup.GetMyAllSubclassesOf()
            If myType.Name = name Then
              Dim instance As GraphicGroup = CType(Activator.CreateInstance(myType, _match), GraphicGroup)
              If instance.MustHavePlayer And _selectedPlayer Is Nothing Then
                frmWaitForInput.ShowWaitDialog(Me, "You must choose a player first", _match.ToString, MessageBoxButtons.OK)
              ElseIf instance.MustHaveClock And _clockControl.ClockVisible = False Then
                frmWaitForInput.ShowWaitDialog(Me, "This action requires the clock to be visible", _match.ToString, MessageBoxButtons.OK)
              ElseIf instance.CantHaveClock And _clockControl.ClockVisible = True Then
                frmWaitForInput.ShowWaitDialog(Me, "This action requires the clock to be retired", _match.ToString, MessageBoxButtons.OK)
              Else
                instance.Match = _match
                instance.Player = _selectedPlayer
                instance.Team = _selectedTeam
                instance.OtherMatchDays = _otherMatchDays
                Me.StartGraphic(instance)
                res = True
              End If
            End If
          Next
      End Select

    Catch ex As Exception
      res = False
      WriteToErrorLog(ex)
    End Try
    Me.Cursor = cursor
    Return res
  End Function



  Private Sub ButtonF1ScoreLine_Click(sender As Object, e As EventArgs) Handles ButtonF1ScoreLine.Click
    StartGraphic(GraphicsScoreLine.Description)
  End Sub

  Private Sub ButtonF2NameReporter_Click(sender As Object, e As EventArgs) Handles ButtonF2NameReporter.Click
    StartGraphic(GraphicsReporter.Description)
  End Sub

  Private Sub ButtonF3L3Subs_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonF4ClockSubs_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonF5TeamMatchStats_Click(sender As Object, e As EventArgs) Handles ButtonF5TeamMatchStats.Click
    StartGraphic(GraphicsTeamStats.Description)
  End Sub

  Private Sub ButtonF6PlayerName_Click(sender As Object, e As EventArgs) Handles ButtonF6PlayerName.Click
    If _selectedPlayer Is Nothing Then
      frmWaitForInput.ShowWaitDialog(Me, "You must choose a player first", "Player name")
    Else
      StartGraphic(GraphicsPlayerName.Description)
    End If
  End Sub

  Private Sub ButtonF7FirstTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF7FirstTeamStuff.Click
    If Not _match Is Nothing Then
      _selectedTeam = _match.HomeTeam
      StartGraphic(GraphicsTeamStaff.Description)
    End If
  End Sub

  Private Sub ButtonF8SecondTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF8SecondTeamStuff.Click
    If Not _match Is Nothing Then
      _selectedTeam = _match.AwayTeam
      StartGraphic(GraphicsTeamStaff.Description)
    End If
  End Sub

  Private Sub ButtonF9TeamCaptions_Click(sender As Object, e As EventArgs) Handles ButtonF9TeamCaptions.Click
    StartGraphic(GraphicsTeamCaptions.Description)
  End Sub

  Private Sub ButtonF10IdentClock_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonF11OptaTop5_Click(sender As Object, e As EventArgs) Handles ButtonF11OptaTop5.Click

  End Sub

  Private Sub ButtonF12VideoTalkThroughts_Click(sender As Object, e As EventArgs) Handles ButtonF12VideoTalkThroughts.Click

  End Sub

  Private Sub ButtonCtlF1FullFramers_Click(sender As Object, e As EventArgs) Handles ButtonCtlF1FullFramers.Click
    StartGraphic(GraphicGroupFullFramers.Description)
  End Sub

  Private Sub ButtonCtlF2PlayerStatsCtrlF2_Click(sender As Object, e As EventArgs) Handles ButtonCtlF2PlayerStatsCtrlF2.Click
    If _selectedPlayer Is Nothing Then
      frmWaitForInput.ShowWaitDialog(Me, "You must choose a player first", "Player name")
    Else
      StartGraphic(GraphicsPlayerStats.Description)
    End If
  End Sub

  Private Sub ButtonCtlF3ClockDropDown_Click(sender As Object, e As EventArgs) Handles ButtonCtlF3ClockDropDown.Click

  End Sub

  Private Sub ButtonCtlF4TwoWayBoxes_Click(sender As Object, e As EventArgs) Handles ButtonCtlF4TwoWayBoxes.Click
    StartGraphic(Graphics2WayBoxes.Description)
  End Sub

  Private Sub ButtonCtlF5PlayerBio_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonCtlF6Referee_Click(sender As Object, e As EventArgs) Handles ButtonCtlF6Referee.Click
    StartGraphic(GraphicsReferee.Description)
  End Sub

  Private Sub ButtonCtlF7ScoreBugs_Click(sender As Object, e As EventArgs) Handles ButtonCtlF7ScoreBugs.Click
    Me.StartGraphic(GraphicsBugScore.Description)
  End Sub

  Private Sub ButtonCtlF8Bugs_Click(sender As Object, e As EventArgs) Handles ButtonCtlF8Bugs.Click
    Me.StartGraphic(GraphicsBugs.Description)
  End Sub

  Private Sub ButtonCtlF9AddedTree_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonCtlF10L3TeamStatsDb_Click(sender As Object, e As EventArgs) Handles ButtonCtlF10L3TeamStatsDb.Click
    StartGraphic(GraphicsTeamStatsL3.Description)
  End Sub

  Private Sub ButtonCtlF11AsItStands_Click(sender As Object, e As EventArgs) Handles ButtonCtlF11AsItStands.Click
    StartGraphic(GraphicsAsItStands.Description)
  End Sub

  Private Sub ButtonCtlF12FFIdent_Click(sender As Object, e As EventArgs) Handles ButtonCtlF12FFIdent.Click
    StartGraphic(GraphicsMatchIdent.Description)
  End Sub

#Region "Penalties"
  Private WithEvents _frmPenalties As frmPenalties


  Private Sub ButtonShftF1PenaltyShootOut_Click(sender As Object, e As EventArgs) Handles ButtonShftF1PenaltyShootOut.Click
    If _match Is Nothing Then Exit Sub

    Try
      Dim animateIn As Boolean = frmWaitForInput.ShowWaitDialog(Me, "Animate in Penalty Shoot Out Caption?", "Penalty shootout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
      Dim bClearResults As Boolean = frmWaitForInput.ShowWaitDialog(Me, "Reset match penalties?", "Penalties", MessageBoxButtons.YesNo) = DialogResult.Yes

      If bClearResults Then
        _frmPenalties = Nothing
      End If

      If _frmPenalties Is Nothing Then
        Dim bHomeFirst As Boolean = (MessageBox.Show(_match.HomeTeam.TeamAELCaption1Name & " shoots first?", "Penalty shootout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
        _frmPenalties = New frmPenalties(_vizControl, _match.HomeTeam.TeamAELCaption1Name, _match.AwayTeam.TeamAELCaption1Name, bHomeFirst)
      End If
      _frmPenalties.Match = _match
      _frmPenalties.StartOnShow = animateIn
      _frmPenalties.ShowDialog()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub _frmPenalties_Closing(sender As Object, e As CancelEventArgs) Handles _frmPenalties.Closing
    Try
      e.Cancel = True
      _frmPenalties.Hide()
    Catch ex As Exception

    End Try

  End Sub
#End Region


  Private Sub ButtonShftF2Interview_Click(sender As Object, e As EventArgs) Handles ButtonShftF2Interview.Click
    StartGraphic(GraphicsInterviews.Description)
  End Sub

  Private Sub ButtonShftF3NameNoNumber_Click(sender As Object, e As EventArgs) Handles ButtonShftF3NameNoNumber.Click
    If _selectedPlayer Is Nothing Then
      frmWaitForInput.ShowWaitDialog(Me, "You must choose a player first", "Player name")
    Else
      StartGraphic(GraphicsPlayerNameNoNumber.Description)
    End If
  End Sub

  Private Sub ButtonTeamListsCrawl_Click(sender As Object, e As EventArgs) Handles ButtonTeamListsCrawl.Click

  End Sub

  Private Sub ButtonShftF5TeamStatsMultiline_Click(sender As Object, e As EventArgs) Handles ButtonShftF5TeamStatsMultiline.Click
    If _match Is Nothing Then Exit Sub
    Dim frm As New FormChooseMulti(_match, _vizControl, _previewControl)
    frm.ShowDialog(Me)
  End Sub

  Private Sub ButtonShftF7L3Commons_Click(sender As Object, e As EventArgs) Handles ButtonShftF7L3Commons.Click
    StartGraphic(GraphicsCommons.Description)
  End Sub

  Private Sub ButtonShftF8TeamListsCrawlSF8_Click(sender As Object, e As EventArgs) Handles ButtonShftF8TeamListsCrawlSF8.Click
    StartGraphic(GraphicGroupCrawlTeams.Description)
  End Sub

  Private Sub ButtonShftF9OtherScores_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonShftF10ClockCard_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonShftF11ActionAreas_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub ButtonShftF12MatchScoresCrawl_Click(sender As Object, e As EventArgs) Handles ButtonShftF12MatchScoresCrawl.Click
    StartGraphic(GraphicsCrawlResults.Description)
  End Sub

  Private Sub ButtonAltF2FreeTextCrawl_Click(sender As Object, e As EventArgs) Handles ButtonAltF2FreeTextCrawl.Click
    StartGraphic(GraphicsCrawlFreeText.Description)
  End Sub

  Private Sub ButtonAltF6HtFtBug_Click(sender As Object, e As EventArgs) Handles ButtonAltF6HtFtBug.Click
    StartGraphic(GraphicsBugHTFT.Description)
  End Sub

#End Region

#Region "Vizcontrol"
  Private Sub _vizControl_TCPSocketConnected() Handles _vizControl.TCPSocketConnected
    Me.UpdateStatusLabel()
    LoadAllScenes()
  End Sub

  Private Sub _vizControl_TCPSocketDisconnected() Handles _vizControl.TCPSocketDisconnected
    Me.UpdateStatusLabel()
    _vizControl = Nothing

    TimerVizrtConnection.Enabled = True
  End Sub

  Private Sub LoadAllScenes()
    Try
      _scenes.Clear()
      _scenes.Add("gfx_2way_box")
      _scenes.Add("gfx_bugs")
      _scenes.Add("gfx_Clock")
      _scenes.Add("gfx_crawl")
      _scenes.Add("gfx_Full_Frame")
      _scenes.Add("gfx_leftframer")
      _scenes.Add("gfx_Lower3rd")
      _scenes.Add("gfx_penalties")
      _scenes.Add("gfx_ScoreLine")

      'Add keys for graphics
      For Each myType As Type In GraphicGroup.GetMyAllSubclassesOf()
        Debug.Print(myType.Name)
        Dim instance As GraphicGroup = CType(Activator.CreateInstance(myType, _match), GraphicGroup)
        If Not instance.Scene Is Nothing Then
          If Not instance.Scene.SceneName Is Nothing AndAlso Not _scenes.Contains(instance.Scene.SceneName) Then
            _scenes.Add(instance.Scene.SceneName)
          End If
        End If
      Next
      Dim frm As New FormLoadScenes(_scenes, _vizControl.Config)
      frm.Show(Me)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub
#End Region

#Region "Main controls"
  Private Sub ButtonAwayGoal_Click(sender As Object, e As EventArgs) Handles ButtonAwayGoal.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.AwayTeam

      If frmWaitForInput.ShowWaitDialog(Me, "Do you want to set a goal to " & team.TeamAELCaption1Name & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps


        Dim gg As New ControlScoreSingleGoal(_match, _match.LastGoal)
        gg.IsLocalTeam = False
        gg.Goal = _match.AddGoal(False, Nothing, False, False)

        _dlgChoosWithPreview = New FormChoose(_vizControl, _previewControl, gg)
        _dlgChoosWithPreview.ShowPreview = False
        If _dlgChoosWithPreview.ShowDialog(Me) = DialogResult.Cancel Then
          _match.RemoveLastGoal()
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ButtonHomeGoal_Click(sender As Object, e As EventArgs) Handles ButtonHomeGoal.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.HomeTeam

      If frmWaitForInput.ShowWaitDialog(Me, "Do you want to set a goal to " & team.TeamAELCaption1Name & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps

        Dim gg As New ControlScoreSingleGoal(_match, _match.LastGoal)

        gg.IsLocalTeam = True
        gg.Goal = _match.AddGoal(True, Nothing, False, False)

        _dlgChoosWithPreview = New FormChoose(_vizControl, _previewControl, gg)
        _dlgChoosWithPreview.ShowPreview = False
        If _dlgChoosWithPreview.ShowDialog(Me) = DialogResult.Cancel Then
          _match.RemoveLastGoal()
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroButtonManageGoals_Click(sender As Object, e As EventArgs) Handles MetroButtonManageGoals.Click
    Try
      If _match Is Nothing Then Exit Sub

      Dim frm As New frmGoals
      frm.Match = _match
      If frm.ShowDialog(Me) = DialogResult.OK Then
        'do something
      End If
    Catch ex As Exception

    End Try
  End Sub


#End Region

#Region "Clock controls"

  Private Sub MetroButtonTimeControl_Click(sender As Object, e As EventArgs) Handles MetroButtonTimeControl.Click
    Try
      Dim frm As New FormPeriodControl()
      frm.Match = _match
      frm.Show(Me)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
    Try
      Dim labelColor As Color = Color.White
      Dim colorOn As Color = Color.LightGreen
      Dim colorOff As Color = Color.LightSalmon

      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then
        Me.MetroLabelPeriodTime.Text = "00:00"
        Me.MetroLabelPeriodName.Text = ""
        labelColor = colorOff
      Else
        Me.MetroLabelPeriodTime.Text = _match.MatchPeriods.TempsJocWithOffsetString
        Me.MetroLabelPeriodName.Text = _match.MatchPeriods.Nom

        If _match.MatchPeriods.ActivePeriod.Activa = False Then
          labelColor = Color.White
        ElseIf _match.MatchPeriods.ActivePeriod.IsPeriodDone Then
          labelColor = Color.LightSalmon
        Else
          labelColor = Color.LightGreen
        End If
      End If
      Me.MetroLabelPeriodTime.BackColor = labelColor
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub MetroButtonClockIN_Click(sender As Object, e As EventArgs) Handles MetroButtonClock.Click
    ToggleClockControl()
  End Sub

  Private Sub ToggleClockControl()
    _clockControl.ClockVisible = Not _clockControl.ClockVisible
    UpdateClockInterface()
  End Sub

  Private Sub SetClockControl(clockVisible As Boolean)
    _clockControl.ClockVisible = clockVisible
    UpdateClockInterface()
  End Sub

  Private Sub UpdateClockInterface()
    Try
      If _clockControl.ClockVisible Then
        Me.MetroButtonClock.Text = "HIDE CLOCK" & vbCrLf & "F10"
        Me.MetroButtonClock.BackColor = Color.LightSalmon
      Else
        Me.MetroButtonClock.Text = "SHOW CLOCK" & vbCrLf & "F10"
        Me.MetroButtonClock.BackColor = Color.LightGreen
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroButtonAddedTime_Click(sender As Object, e As EventArgs) Handles MetroButtonAddedTime.Click
    AddedTimeClick()
  End Sub

  Private Sub AddedTimeClick()
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub

      Dim frm As New FormAddedTime
      frm.Minutes = _match.MatchPeriods.ActivePeriod.ExtraTime
      If frm.ShowDialog(Me) = DialogResult.OK Then
        _match.MatchPeriods.UpdatePeriodExtraTime(_match.MatchPeriods.ActivePeriod, frm.Minutes)
        _clockControl.UpdateExraTimeVisibility()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _clockControl_Updated() Handles _clockControl.Updated
    Me.UpdateClockInterface()
  End Sub

#Region "Substitution"
  Private Sub MetroButtonClockSubstitutions_Click(sender As Object, e As EventArgs) Handles MetroButtonClockSubstitutions.Click
    'Me.StartGraphic(New ClockSubstitutes(_match))
    Dim dlgPre As New FormSubstitutionPreSelection
    dlgPre.ShowDialog(Me)
    If dlgPre.DialogResult = DialogResult.OK Then
      Select Case dlgPre.SubsitutitonType
        Case FormSubstitutionPreSelection.eSubstitutionType.Home
          Me.AddSubstitution(_match.HomeTeam)
        Case FormSubstitutionPreSelection.eSubstitutionType.Away
          Me.AddSubstitution(_match.AwayTeam)
        Case Else
          'nothing to do
      End Select

      Dim dlg As New FormSubstitutions()
      dlg.Match = _match
      dlg.Show(Me)
    End If

  End Sub

  Private Function AddSubstitution(team As Team) As Substitution
    Try
      Dim dlg As New FormSubstitution()
      dlg.Team = team
      If dlg.ShowDialog(Me) = DialogResult.OK Then
        Dim subs As New Substitution() With {.Team = team, .PlayerIn = dlg.PlayerIn, .PlayerOut = dlg.PlayerOut, .part = _match.MatchPeriods.ActivePeriod.Part, .timeInSeconds = _match.MatchPeriods.ActivePeriod.PlayingTime}
        Dim aux As Integer = subs.PlayerIn.Formation_Pos
        subs.PlayerIn.Formation_Pos = subs.PlayerOut.Formation_Pos
        subs.PlayerOut.Formation_Pos = aux
        team.AddSubstitution(subs)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Nothing
  End Function
#End Region


  Private Sub MetroButtonClockStats_Click(sender As Object, e As EventArgs) Handles MetroButtonClockStats.Click
    StartGraphic(ClockGenericStraps.Description)
  End Sub

  Private Sub MetroButtonClockStrapsWithIcon_Click(sender As Object, e As EventArgs) Handles MetroButtonClockStrapsWithIcon.Click
    StartGraphic(ClockStrapsWithIcon.Description)
  End Sub

  Private Sub MetroButtonClockOtherScores_Click(sender As Object, e As EventArgs) Handles MetroButtonClockOtherScores.Click
    StartGraphic(ClockOtherScores.Description)
  End Sub
  Private Sub ButtonClockCards_Click(sender As Object, e As EventArgs) Handles ButtonClockCards.Click
    Me.StartGraphic(ClockPlayerCard.Description)
  End Sub

  Private Sub MetroButtonClockPenalties_Click(sender As Object, e As EventArgs) Handles MetroButtonClockPenalties.Click
    StartGraphic(ClockPenalties.Description)
  End Sub

#End Region

#Region "Other Matches"
  Private WithEvents _frmMatchDay As frmMatchDay
  Public Sub ShowOtherMatches()
    Try
      Me.Cursor = Cursors.WaitCursor
      GlobalNotifier.Instance.AddInfoMessage("Initializing Other Matches form")
      _frmMatchDay = New frmMatchDay()
      GlobalNotifier.Instance.AddInfoMessage("Loading Competitions")
      Dim mps As New Competitions()
      mps.GetFromDB("")
      GlobalNotifier.Instance.AddInfoMessage("Assigning competition for current match")
      _frmMatchDay.Competition = mps.GetCompetition(_match.competition_id)
      '_frmMatchDay.OtherMatchDays = _otherMatchDays

      GlobalNotifier.Instance.AddInfoMessage("Showing dialog")
      If _frmMatchDay.ShowDialog(Me) = DialogResult.OK Then
        _otherMatchDays = _frmMatchDay.OtherMatchDays
      End If
      _frmMatchDay.Dispose()
      _frmMatchDay = Nothing
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.Cursor = Cursors.Default
  End Sub
#End Region

#Region "Team viewer"
  Private _homePlayerControls As New List(Of PlayerViewer)
  Private _awayPlayerControls As New List(Of PlayerViewer)

  Private Sub InitPlayerControls()
    _homePlayerControls.Add(Me.PlayerHomeViewer1)
    _homePlayerControls.Add(Me.PlayerHomeViewer2)
    _homePlayerControls.Add(Me.PlayerHomeViewer3)
    _homePlayerControls.Add(Me.PlayerHomeViewer4)
    _homePlayerControls.Add(Me.PlayerHomeViewer5)
    _homePlayerControls.Add(Me.PlayerHomeViewer6)
    _homePlayerControls.Add(Me.PlayerHomeViewer7)
    _homePlayerControls.Add(Me.PlayerHomeViewer8)
    _homePlayerControls.Add(Me.PlayerHomeViewer9)
    _homePlayerControls.Add(Me.PlayerHomeViewer10)
    _homePlayerControls.Add(Me.PlayerHomeViewer11)
    _homePlayerControls.Add(Me.PlayerHomeViewer12)
    _homePlayerControls.Add(Me.PlayerHomeViewer13)
    _homePlayerControls.Add(Me.PlayerHomeViewer14)
    _homePlayerControls.Add(Me.PlayerHomeViewer15)
    _homePlayerControls.Add(Me.PlayerHomeViewer16)
    _homePlayerControls.Add(Me.PlayerHomeViewer17)
    _homePlayerControls.Add(Me.PlayerHomeViewer18)

    _awayPlayerControls.Add(Me.PlayerAwayViewer1)
    _awayPlayerControls.Add(Me.PlayerAwayViewer2)
    _awayPlayerControls.Add(Me.PlayerAwayViewer3)
    _awayPlayerControls.Add(Me.PlayerAwayViewer4)
    _awayPlayerControls.Add(Me.PlayerAwayViewer5)
    _awayPlayerControls.Add(Me.PlayerAwayViewer6)
    _awayPlayerControls.Add(Me.PlayerAwayViewer7)
    _awayPlayerControls.Add(Me.PlayerAwayViewer8)
    _awayPlayerControls.Add(Me.PlayerAwayViewer9)
    _awayPlayerControls.Add(Me.PlayerAwayViewer10)
    _awayPlayerControls.Add(Me.PlayerAwayViewer11)
    _awayPlayerControls.Add(Me.PlayerAwayViewer12)
    _awayPlayerControls.Add(Me.PlayerAwayViewer13)
    _awayPlayerControls.Add(Me.PlayerAwayViewer14)
    _awayPlayerControls.Add(Me.PlayerAwayViewer15)
    _awayPlayerControls.Add(Me.PlayerAwayViewer16)
    _awayPlayerControls.Add(Me.PlayerAwayViewer17)
    _awayPlayerControls.Add(Me.PlayerAwayViewer18)

    For Each ctl As PlayerViewer In _homePlayerControls
      AddHandler ctl.GoalScored, AddressOf Me.PlayerHomeViewer_GoalScored
      AddHandler ctl.SelectionChanged, AddressOf Me.PlayerViewer_SelectionChanged
    Next

    For Each ctl As PlayerViewer In _awayPlayerControls
      AddHandler ctl.GoalScored, AddressOf Me.PlayerAwayViewer_GoalScored
      AddHandler ctl.SelectionChanged, AddressOf Me.PlayerViewer_SelectionChanged
    Next
  End Sub

  Private Sub PlayerViewer_SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
    If _updating Then Exit Sub
    _updating = True
    Try
      If _match Is Nothing Then Exit Sub
      Me._selectedPlayer = sender.Player
      Select Case _selectedPlayer.TeamID
        Case _match.HomeTeam.ID
          _selectedTeam = _match.HomeTeam
        Case _match.AwayTeam.ID
          _selectedTeam = _match.AwayTeam
      End Select
      For Each ctl As PlayerViewer In _homePlayerControls
        ctl.IsSelected = (ctl.Player.ID = sender.Player.ID)
      Next
      For Each ctl As PlayerViewer In _awayPlayerControls
        ctl.IsSelected = (ctl.Player.ID = sender.Player.ID)
      Next
      If Not _match Is Nothing And Not _selectedPlayer Is Nothing Then
        StartGraphic(GraphicsPlayerName.Description)
      End If
    Catch ex As Exception
    End Try
    _updating = False
  End Sub

  Private Sub PlayerHomeViewer_GoalScored(ByRef sender As PlayerViewer, add As Boolean)
    If _updating Then Exit Sub
    _updating = True

    Try
      If _match Is Nothing Then Exit Sub
      If add Then
        _match.AddGoal(True, sender.Player, False, False)
      Else
        _match.RemoveLastGoalByPlayer(sender.Player)
      End If
    Catch ex As Exception
    End Try
    _updating = False
  End Sub

  Private Sub PlayerAwayViewer_GoalScored(ByRef sender As PlayerViewer, add As Boolean)
    If _updating Then Exit Sub
    _updating = True

    Try
      If _match Is Nothing Then Exit Sub
      If add Then
        _match.AddGoal(False, sender.Player, False, False)
      Else
        _match.RemoveLastGoalByPlayer(sender.Player)
      End If

    Catch ex As Exception
    End Try

    _updating = False
  End Sub


  Private Sub InitTeamPlayerControls(team As Team, controls As List(Of PlayerViewer))
    Try
      If Not team Is Nothing Then
        For index As Integer = 1 To controls.Count
          Dim player As Player = team.MatchPlayers.GetPlayerByPosition(index)
          controls(index - 1).Player = player
          controls(index - 1).IsSubsitution = False
        Next
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub PlayerAwayViewer1_Load(sender As Object, e As EventArgs) Handles PlayerAwayViewer1.Load

  End Sub

  Private Sub _match_ActivePeriodStateChanged() Handles _match.ActivePeriodStateChanged

  End Sub

  Private Sub _match_ScoreChanged() Handles _match.ScoreChanged
    Try
      Me.LabelHomeTeamResult.Text = _match.home_goals
      Me.LabelAwayTeamResult.Text = _match.away_goals

      For Each ctl As PlayerViewer In _homePlayerControls
        ctl.UpdateStatInterface()
      Next
      For Each ctl As PlayerViewer In _awayPlayerControls
        ctl.UpdateStatInterface()
      Next
    Catch ex As Exception

    End Try
  End Sub
#End Region

#Region "Key capture"
  Private Sub InitializeKeyCapture()
    Try
      _keyCapture = New KeyCapture()
      _keyCapture.LlistaCombinations.Clear()

      'Add keys
      _keyCapture.LlistaCombinations.Add(New KeyCombination("ToggleClockControl", Keys.F10, False, False, False, False))

      'Add keys for graphics
      For Each myType As Type In GraphicGroup.GetMyAllSubclassesOf()
        Debug.Print(myType.Name)
        Dim instance As GraphicGroup = CType(Activator.CreateInstance(myType, _match), GraphicGroup)
        If Not instance.KeyCombination Is Nothing Then
          _keyCapture.LlistaCombinations.Add(instance.KeyCombination)
        End If
      Next
      _keyCapture.ParentHandle = Me.Handle

      _keyCapture.LlistaCombinations.Sort()

      For Each keyComb As KeyCombination In _keyCapture.LlistaCombinations
        Debug.Print(keyComb.ToString)
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub


  Private Sub _keyCapture_Keycaptured() Handles _keyCapture.Keycaptured
    Debug.Print("_keyCapture_Keycaptured ")
  End Sub

  Private Sub _keyCapture_KeyCombinationCaptured(CKeyCombination As KeyCombination) Handles _keyCapture.KeyCombinationCaptured
    Debug.Print("_keyCapture_KeyCombinationCaptured " & CKeyCombination.Name)
    Me.StartGraphic(CKeyCombination.Name)
  End Sub

  Private Sub _keyCapture_UndefinedKeyCombinationCaptured(CKeyCombination As KeyCombination) Handles _keyCapture.UndefinedKeyCombinationCaptured
    Debug.Print("_keyCapture_UndefinedKeyCombinationCaptured " & CKeyCombination.KeyCode & " ALT " & CKeyCombination.Alt.ToString & " - CONTROL " & CKeyCombination.Control.ToString & " - shift " & CKeyCombination.Shift.ToString)
    Try
      If _match Is Nothing Then Exit Sub
      Select Case CKeyCombination.KeyCode
        Case Keys.T
          If CKeyCombination.Alt = True And CKeyCombination.Control = False And CKeyCombination.Shift = False And CKeyCombination.Windows = False Then
            MetroButtonTimeControl_Click(Nothing, Nothing)
          End If
        Case Keys.D1
          If CKeyCombination.Alt = True And CKeyCombination.Control = False And CKeyCombination.Shift = False And CKeyCombination.Windows = False Then
            Me.ButtonHomeGoal_Click(Nothing, Nothing)
          End If
        Case Keys.D2
          If CKeyCombination.Alt = True And CKeyCombination.Control = False And CKeyCombination.Shift = False And CKeyCombination.Windows = False Then
            Me.ButtonAwayGoal_Click(Nothing, Nothing)
          End If
        Case Keys.F4
          MetroButtonClockSubstitutions_Click(Nothing, Nothing)
        Case Keys.F7
          StartGraphic(New GraphicsTeamStaff(_match, _match.HomeTeam))
        Case Keys.F8
          StartGraphic(New GraphicsTeamStaff(_match, _match.AwayTeam))
        Case Keys.F10
          If CKeyCombination.Alt = False And CKeyCombination.Control = False And CKeyCombination.Shift = False And CKeyCombination.Windows = False Then
            ToggleClockControl()
          End If
      End Select

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _match_TeamStatValueChanged(team As Team, stat As Stat) Handles _match.TeamStatValueChanged
    Try
      If stat.Name = "RCard" Then
        _clockControl.UpdateRedCards()
      End If
      UpdateStatLabels()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateStatLabels()
    If Me.Match Is Nothing Then Exit Sub


    lblInfoPosession.Text = Me.Match.HomeTeam.MatchStats.Possession.Value & "% - " & Me.Match.AwayTeam.MatchStats.Possession.Value & "%"
    lblInfoFoulsConc.Text = Me.Match.HomeTeam.MatchStats.Fouls.Value & " - " & Me.Match.AwayTeam.MatchStats.Fouls.Value
    lblInfoCorners.Text = Me.Match.HomeTeam.MatchStats.Corners.Value & " - " & Me.Match.AwayTeam.MatchStats.Corners.Value
    lblInfoOffsides.Text = Me.Match.HomeTeam.MatchStats.Offsides.Value & " - " & Me.Match.AwayTeam.MatchStats.Offsides.Value
    lblInfoShotsOn.Text = Me.Match.HomeTeam.MatchStats.ShotsOn.Value & " - " & Me.Match.AwayTeam.MatchStats.ShotsOn.Value
    lblInfoShots.Text = Me.Match.HomeTeam.MatchStats.Shots.Value & " - " & Me.Match.AwayTeam.MatchStats.Shots.Value
    lblInfoWoodHits.Text = Me.Match.HomeTeam.MatchStats.WoodHits.Value & " - " & Me.Match.AwayTeam.MatchStats.WoodHits.Value

    lblInfoYellowCards.Text = Me.Match.HomeTeam.MatchStats.YellowCards.Value & " - " & Me.Match.AwayTeam.MatchStats.YellowCards.Value
    lblInfoRedCards.Text = Me.Match.HomeTeam.MatchStats.RedCards.Value & " - " & Me.Match.AwayTeam.MatchStats.RedCards.Value
  End Sub

  Private Sub ButtonPANIC_Click(sender As Object, e As EventArgs) Handles ButtonPANIC.Click
    Try
      _vizControl.ActivateScene("", VizCommands.eRendererLayers.BackLayer)
      _vizControl.ActivateScene("", VizCommands.eRendererLayers.FrontLayer)
      _vizControl.ActivateScene("", VizCommands.eRendererLayers.MidleLayer)

      _previewControl.ClearOutput()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _asyncStatWriter_DataUpdated(dataToUpdate As Integer, lastUpdatedData As AsyncStatWriter.StatToUpdate) Handles _asyncStatWriter.DataUpdated
    'If dataToUpdate > 0 Then
    '  Me.LabelLog.Text = "Pending data to write: " & dataToUpdate & "  last updated " & lastUpdatedData.subject.ToString & "   " & lastUpdatedData.stat.Name & " = " & lastUpdatedData.stat.Value
    'Else
    '  Me.LabelLog.Text = ""
    '  Me.LabelLog.ForeColor = Color.Black
    'End If
  End Sub

  Private Sub _notifier_NewMessage(msg As GlobalNotifier.tyMessage) Handles _notifier.NewMessage
    Try

      Select Case msg.type
        Case GlobalNotifier.eMessageType.AppError
          Me.LabelLog.ForeColor = Color.DarkRed
          Me.LabelLog.Text = msg.text
        Case GlobalNotifier.eMessageType.Info
          Me.LabelLog.ForeColor = Color.Black
          Me.LabelLog.Text = msg.text
        Case GlobalNotifier.eMessageType.Warning
          Me.LabelLog.ForeColor = Color.DarkOrange
      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ToolStripStatusLabelGetLoggerData_Click(sender As Object, e As EventArgs)
    Try
      _loggerComm.GetTeamsStats(_match)
      Debug.Print("new data")
    Catch ex As Exception

    End Try
  End Sub

  Private Sub TimerRefreshStats_Tick(sender As Object, e As EventArgs) Handles TimerRefreshStats.Tick

    'Refrescamos las estadisticas básicas
    'Refresh the Match Info
    If AppSettings.Instance.UseLogger Then
      Dim StringSmallStats As String = _loggerComm.SendSocket("SMALSTATS|NadaMas")

      Dim AllStats As String() = StringSmallStats.Split("|"c)
      If AllStats.Length > 14 Then
        Me.Match.HomeTeam.MatchStats.Possession.Value = NoNullDecimal(AllStats(0))
        Me.Match.AwayTeam.MatchStats.Possession.Value = NoNullDecimal(AllStats(1))
        Me.Match.HomeTeam.MatchStats.Fouls.Value = NoNullDecimal(AllStats(2))
        Me.Match.AwayTeam.MatchStats.Fouls.Value = NoNullDecimal(AllStats(3))
        Me.Match.HomeTeam.MatchStats.ShotsOn.Value = NoNullDecimal(AllStats(4))
        Me.Match.AwayTeam.MatchStats.ShotsOn.Value = NoNullDecimal(AllStats(5))
        Me.Match.HomeTeam.MatchStats.Corners.Value = NoNullDecimal(AllStats(6))
        Me.Match.AwayTeam.MatchStats.Corners.Value = NoNullDecimal(AllStats(7))
        Me.Match.HomeTeam.MatchStats.Offsides.Value = NoNullDecimal(AllStats(8))
        Me.Match.AwayTeam.MatchStats.Offsides.Value = NoNullDecimal(AllStats(9))
        Me.Match.HomeTeam.MatchStats.WoodHits.Value = NoNullDecimal(AllStats(10))
        Me.Match.AwayTeam.MatchStats.WoodHits.Value = NoNullDecimal(AllStats(11))
        Me.Match.HomeTeam.MatchStats.Shots.Value = NoNullDecimal(AllStats(12))
        Me.Match.AwayTeam.MatchStats.Shots.Value = NoNullDecimal(AllStats(13))
        Me.Match.HomeTeam.MatchStats.Assis.Value = NoNullDecimal(AllStats(14))
        Me.Match.AwayTeam.MatchStats.Assis.Value = NoNullDecimal(AllStats(15))



        lblInfoPosession.Text = Me.Match.HomeTeam.MatchStats.Possession.Value & "% - " & Me.Match.AwayTeam.MatchStats.Possession.Value & "%"
        lblInfoFoulsConc.Text = Me.Match.HomeTeam.MatchStats.Fouls.Value & " - " & Me.Match.AwayTeam.MatchStats.Fouls.Value
        lblInfoCorners.Text = Me.Match.HomeTeam.MatchStats.Corners.Value & " - " & Me.Match.AwayTeam.MatchStats.Corners.Value
        lblInfoOffsides.Text = Me.Match.HomeTeam.MatchStats.Offsides.Value & " - " & Me.Match.AwayTeam.MatchStats.Offsides.Value
        lblInfoShotsOn.Text = Me.Match.HomeTeam.MatchStats.ShotsOn.Value & " - " & Me.Match.AwayTeam.MatchStats.ShotsOn.Value
        lblInfoShots.Text = Me.Match.HomeTeam.MatchStats.Shots.Value & " - " & Me.Match.AwayTeam.MatchStats.Shots.Value
        lblInfoWoodHits.Text = Me.Match.HomeTeam.MatchStats.WoodHits.Value & " - " & Me.Match.AwayTeam.MatchStats.WoodHits.Value

        lblInfoYellowCards.Text = Me.Match.HomeTeam.MatchStats.YellowCards.Value & " - " & Me.Match.AwayTeam.MatchStats.YellowCards.Value
        lblInfoRedCards.Text = Me.Match.HomeTeam.MatchStats.RedCards.Value & " - " & Me.Match.AwayTeam.MatchStats.RedCards.Value

        Dim Position As Integer = 16
        While AllStats.Length > Position & 1
          Dim myPlayer As Player = Me.Match.GetPlayerById(NoNullInt(AllStats(Position & 1)))
          Dim myPlayerStat As SubjectStats = myPlayer.MatchStats
          Dim myNewColor As Color = Color.White
          If AllStats(Position) = "YCard" Then
            myNewColor = Color.Yellow
            myPlayerStat.YellowCards.Value = 1
          ElseIf AllStats(Position) = "RCard" Then
            myNewColor = Color.Red
            myPlayerStat.RedCards.Value = 1
          End If
          'If myPlayer.TeamID = HomeTeam.TeamID Then
          '  'DirectCast(grpHomePlayers.Controls.Find("HomePlayerCard" & myPlayerStat.Formation_Pos, True)(0), Label).BackColor = myNewColor
          'Else
          '  'DirectCast(grpAwayPlayers.Controls.Find("AwayPlayerCard" & myPlayerStat.Formation_pos, True)(0), Label).BackColor = myNewColor
          'End If
          Position &= 2
        End While
      End If
    End If

  End Sub

  Private Sub LoggerConnect_Click(sender As Object, e As EventArgs) Handles LoggerConnect.Click
    Try
      Dim bUseLogger As Boolean = False

      bUseLogger = _loggerComm.StartClient()
      AppSettings.Instance.UseLogger = bUseLogger
      AppSettings.Instance.Save()

      If bUseLogger Then
        LoggerConnect.BackColor = Color.Green
        _loggerComm.SendTeamsInfo(_match)
      Else
        bUseLogger = False
        LoggerConnect.BackColor = Color.Red
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub _loggerComm_Connected() Handles _loggerComm.Connected
    LoggerConnect.BackColor = Color.Green
  End Sub

  Private Sub _loggerComm_Disconnected(msg As String) Handles _loggerComm.Disconnected
    LoggerConnect.BackColor = Color.Red
  End Sub

  Private Sub ButtonUndo_Click(sender As Object, e As EventArgs) Handles ButtonUndo.Click
    If _match Is Nothing Then Exit Sub
    Try
      If frmWaitForInput.ShowWaitDialog(Me, "Remove last goal?", _match.Description, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub

      _match.RemoveLastGoal()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Function GetControlForPlayer(player As Player) As PlayerViewer
    Dim res As PlayerViewer = Nothing
    Try
      For Each ctl As PlayerViewer In _homePlayerControls
        If ctl.Player.PlayerID = player.PlayerID Then
          res = ctl
        End If
      Next
      For Each ctl As PlayerViewer In _awayPlayerControls
        If ctl.Player.PlayerID = player.PlayerID Then
          res = ctl
        End If
      Next
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return res
  End Function

  Private Sub _match_Substitution(team As Team, substitution As Substitution) Handles _match.Substitution
    Try
      Dim ctlIn As PlayerViewer = Me.GetControlForPlayer(substitution.PlayerIn)
      Dim ctlOut As PlayerViewer = Me.GetControlForPlayer(substitution.PlayerOut)
      ctlIn.Player = substitution.PlayerOut
      ctlOut.Player = substitution.PlayerIn
      ctlIn.IsSubsitution = True
      ctlOut.IsSubsitution = True
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub _match_MatchReset() Handles _match.MatchReset
    'Match
    InitMatchInfo(_match)
  End Sub


#End Region

#Region "Match events"
  Private WithEvents _frmMatchEvents As FormMatchEvents = Nothing

  Private Sub ToolStripButtonMatchEvents_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMatchEvents.Click
    Try
      If _frmMatchEvents Is Nothing Then
        _frmMatchEvents = New FormMatchEvents
        _frmMatchEvents.Match = _match
        _frmMatchEvents.Show(Me)
      Else
        _frmMatchEvents.Close()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _frmMatchEvents_Closed(sender As Object, e As EventArgs) Handles _frmMatchEvents.Closed
    _frmMatchEvents = Nothing
  End Sub

  Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
    Debug.Print("Keypress " & e.KeyChar.ToString)
  End Sub

  Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    Debug.Print("KeyDown " & e.KeyCode.ToString)
  End Sub

#End Region

#Region "Check vizrt connection / reconnect"
  Private WithEvents _checkSocketConnection As VizCommands.CheckSocketConnection


  Private Sub TimerVizrtConnection_Tick(sender As Object, e As EventArgs) Handles TimerVizrtConnection.Tick
    Try
      ' Me.TimerVizrtConnection.Enabled = False
      _checkSocketConnection.CheckConnection(AppSettings.Instance.VizrtHost, AppSettings.Instance.VizrtPort)
      'Me.LabelVizEngine.BackColor = Color.Aqua
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _checkSocketConnection_ConnectionCheckStateChanged(host As String, port As Integer, state As CheckSocketConnection.eSocketCheckState) Handles _checkSocketConnection.ConnectionCheckStateChanged
    Select Case state
      Case CheckSocketConnection.eSocketCheckState.Idle

      Case CheckSocketConnection.eSocketCheckState.ResolvingAddress
        'Me.LabelVizEngine.BackColor = Color.Yellow
      Case CheckSocketConnection.eSocketCheckState.Connecting
        'Me.LabelVizEngine.BackColor = Color.Orange
      Case CheckSocketConnection.eSocketCheckState.Disconnected
        'Me.LabelVizEngine.BackColor = Color.Gray
      Case CheckSocketConnection.eSocketCheckState.Connected
        'Me.LabelVizEngine.BackColor = Color.LightGreen
        If _vizControl Is Nothing Then
          Me.InitRender()
        ElseIf _vizControl.SocketStateTCP <> eSocketState.Connected Then
          ' _vizControl.InitializeSockets()
          InitRender()
        End If
      Case CheckSocketConnection.eSocketCheckState.Error
        Me.LabelVizEngine.BackColor = Color.Red
        WriteToErrorLog("Unable to connect to VizEngine (0x" & Hex(_checkSocketConnection.LastErrorCode) & ": " & _checkSocketConnection.LasterrorDescription & ")")
        TimerVizrtConnection.Interval = 10000
        TimerVizrtConnection.Enabled = True
        _vizControl = Nothing
    End Select
  End Sub

#End Region

#Region "Clock control"
  Private WithEvents _dlgClockControl As FormClockControl


  Private Sub ButtonClockManagement_Click(sender As Object, e As EventArgs) Handles ButtonClockManagement.Click
    Try
      If _dlgClockControl Is Nothing Then
        _dlgClockControl = New FormClockControl
        _dlgClockControl.ClockControl = _clockControl
        _dlgClockControl.Show(Me)
      Else
        _dlgClockControl.BringToFront()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _dlgClockControl_Closed(sender As Object, e As EventArgs) Handles _dlgClockControl.Closed
    _dlgClockControl = Nothing
  End Sub

#End Region

#Region "OPTA"
  Private WithEvents _frmOptaMatchStats As frmOptaMatchStats

  'Private Sub FixturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixturesToolStripMenuItem.Click
  '  Try
  '    If _frmOptaMatchStats Is Nothing Then
  '      _frmOptaMatchStats = New frmOptaMatchStats
  '      _frmOptaMatchStats.Match = _match
  '      _frmOptaMatchStats.f9Helper = _F9Helper
  '      _frmOptaMatchStats.Show(Me)
  '    Else
  '      _frmOptaMatchStats.Close()
  '    End If

  '  Catch ex As Exception
  '    WriteToErrorLog(ex)
  '  End Try
  'End Sub

  Private Sub MatchDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatchDataToolStripMenuItem.Click
    Try
      If _frmOptaMatchStats Is Nothing Then
        _frmOptaMatchStats = New frmOptaMatchStats
        _frmOptaMatchStats.Match = _match
        _frmOptaMatchStats.f9Helper = _F9Helper
        _frmOptaMatchStats.Show(Me)
      Else
        _frmOptaMatchStats.Close()
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _frmOptaMatchStats_Closed(sender As Object, e As EventArgs) Handles _frmOptaMatchStats.Closed
    _frmOptaMatchStats = Nothing
  End Sub


  Private Sub SelectOptaStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectOptaStatsToolStripMenuItem.Click
    Try
      Dim dlg As New frmOptaStats
      If dlg.ShowDialog(Me) = DialogResult.OK Then

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private _externalOptaSync As Boolean = False

  Private WithEvents _frmOptaFTPSync As New frmOptaFTPSync


  Private Sub SyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyncToolStripMenuItem.Click
    Try
      _externalOptaSync = True
      _frmOptaFTPSync = New frmOptaFTPSync
      _frmOptaFTPSync.Show(Me)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub _frmOptaFTPSync_Closed(sender As Object, e As EventArgs) Handles _frmOptaFTPSync.Closed
    Try
      _externalOptaSync = False
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _ftpSyncManager_SyncStateChanged(syncState As FTPSyncManager.CThreadState) Handles _ftpSyncManager.SyncStateChanged
    Try
      If _externalOptaSync Then Exit Sub
      Dim down As New Download()
      For Each ftpFile As FTPFileInfo In syncState.NewFiles
        down = New Download
        down.URL = ftpFile.FullPathRemote
        down.File = ftpFile.FullPathLocal
        down.User = _ftpSyncManager.FTPUser
        down.Password = _ftpSyncManager.FTPPassword
        Me.MultiFileDownloaderFTP.Downloads.AddDownload(down)
      Next

      For Each ftpFile As FTPFileInfo In syncState.ChangedFiles
        down = New Download
        down.URL = ftpFile.FullPathRemote
        down.File = ftpFile.FullPathLocal
        down.User = _ftpSyncManager.FTPUser
        down.Password = _ftpSyncManager.FTPPassword
        Me.MultiFileDownloaderFTP.Downloads.AddDownload(down)
      Next
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
