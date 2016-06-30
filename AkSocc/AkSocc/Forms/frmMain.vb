Imports AkSocc
Imports MatchInfo

Public Class frmMain
#Region "Properties and variables"
  Private WithEvents _match As MatchInfo.Match
  Private WithEvents _statGraphic As GraphicStep
  Private WithEvents _dlgChoosWithPreview As FormChoose
  Private WithEvents _vizControl As VizCommands.VizControl
  Private WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _otherMatchDays As New OtherMatchDays

  Private WithEvents _clockControl As ClockControl = ClockControl.Instance
#End Region

#Region "Constructor"

#End Region

#Region "Interface functions"

#End Region

#Region "Form events"
  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      If My.Settings.ShowSettingsOnStartup Then
        ShowOptions(Me)
      End If
      Me.Cursor = Cursors.WaitCursor
      DesserializeObjectFromFile(My.Settings.OtherMatchesPath, _otherMatchDays)
      InitControls()
      MatchSetup()
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

      Me.UpdateStatusLabel()
      _vizControl = New VizCommands.VizControl
      _vizControl.Config = New VizCommands.tyConfigVizrt
      _vizControl.Config.TCPHost = My.Settings.VizrtHost
      _vizControl.Config.TCPPort = My.Settings.VizrtPort
      _vizControl.Config.SceneBasePath = My.Settings.ScenePath
      _vizControl.InitializeSockets()

      Dim pvwConfig As New VizCommands.tyConfigVizrt
      pvwConfig.TCPHost = My.Settings.VizrtHost
      pvwConfig.TCPPort = My.Settings.VizrtPreviewPort
      pvwConfig.SceneBasePath = My.Settings.ScenePath

      _previewControl = New VizCommands.PreviewControl(pvwConfig)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.UpdateStatusLabel()
  End Sub
#End Region

#Region "Tool strip"
  Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click
    Try
      ShowOptions(Me)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
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
      If Not _otherMatchDays Is Nothing Then
        _otherMatchDays.ComputeClassification()
      End If

    Catch ex As Exception

    End Try

  End Sub

  Private Sub UpdateToolStrip()

  End Sub
#End Region

#Region "Match functions"
  Public Function MatchSetup() As Boolean
    Try
      Dim dlg As New FormMatchSetup
      Dim aux As MetroFramework.Forms.MetroForm = TryCast(Me, MetroFramework.Forms.MetroForm)
      If Not aux Is Nothing Then
        dlg.StyleManager = aux.StyleManager
      End If
      If dlg.ShowDialog(Me) = DialogResult.OK Then
        'match selected!
        InitMatchInfo(dlg.SelectedMatch)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return True
  End Function

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

        InitTeamPlayerControls(_match.HomeTeam, _homePlayerControls)
        InitTeamPlayerControls(_match.AwayTeam, _awayPlayerControls)

        Me.LabelAwayTeamName.Text = _match.AwayTeam.ToString
        Me.LabelHomeTeamName.Text = _match.HomeTeam.ToString

        Me.LabelAwayTeamShortName.Text = _match.AwayTeam.TeamAELTinyName
        Me.LabelHomeTeamShortName.Text = _match.HomeTeam.TeamAELTinyName

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
      Me.LabelHomeTeamResult.DataBindings.Clear()
      Me.LabelAwayTeamResult.DataBindings.Clear()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub EngageDataBinding()
    Try
      Me.LabelHomeTeamResult.DataBindings.Clear()
      Me.LabelAwayTeamResult.DataBindings.Clear()

      Me.LabelHomeTeamResult.DataBindings.Add("Text", _match.HomeTeam.MatchStats.GoalStat, "Value")
      Me.LabelAwayTeamResult.DataBindings.Add("Text", _match.AwayTeam.MatchStats.GoalStat, "Value")

      _clockControl = ClockControl.Instance
      _clockControl.VizControl = _vizControl
      _clockControl.Match = _match
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Status label"
  Private Sub ToolStripStatusLabelVizConnection_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabelVizConnection.Click

  End Sub

  Private Sub ToolStripStatusLabelLoggerConnection_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabelLoggerConnection.Click

  End Sub

  Private Sub UpdateStatusLabel()
    Try
      If _vizControl Is Nothing Then
        Me.ToolStripStatusLabelVizConnection.BackColor = Color.Red
      Else
        Select Case _vizControl.SocketStateTCP
          Case VizCommands.eSocketState.Connected
            Me.ToolStripStatusLabelVizConnection.BackColor = Color.Green
          Case VizCommands.eSocketState.Connecting
            Me.ToolStripStatusLabelVizConnection.BackColor = Color.Orange
          Case VizCommands.eSocketState.Disconnected
            Me.ToolStripStatusLabelVizConnection.BackColor = Color.Red
          Case VizCommands.eSocketState.ErrorState
            Me.ToolStripStatusLabelVizConnection.BackColor = Color.Red
        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Team / player"
  Private _updating As Boolean

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.StyleManager = msmMain
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
  Private Sub ButtonF1ScoreLine_Click(sender As Object, e As EventArgs) Handles ButtonF1ScoreLine.Click
    Me.StartGraphic(New GraphicGroupF1ScoreLine(_match))
  End Sub

  Private Sub ButtonF2NameReporter_Click(sender As Object, e As EventArgs) Handles ButtonF2NameReporter.Click
    Me.StartGraphic(New GraphicsF2Reporter(_match))
  End Sub

  Private Sub ButtonF3L3Subs_Click(sender As Object, e As EventArgs) Handles ButtonF3L3Subs.Click

  End Sub

  Private Sub ButtonF4ClockSubs_Click(sender As Object, e As EventArgs) Handles ButtonF4ClockSubs.Click

  End Sub

  Private Sub ButtonF5TeamMatchStats_Click(sender As Object, e As EventArgs) Handles ButtonF5TeamMatchStats.Click
    Me.StartGraphic(New GraphicsF5TeamStats(_match))
  End Sub

  Private Sub ButtonF6PlayerName_Click(sender As Object, e As EventArgs) Handles ButtonF6PlayerName.Click

  End Sub

  Private Sub ButtonF7FirstTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF7FirstTeamStuff.Click
    Me.StartGraphic(New GraphicsTeamStaff(_match, _match.HomeTeam))
  End Sub

  Private Sub ButtonF8SecondTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF8SecondTeamStuff.Click
    Me.StartGraphic(New GraphicsTeamStaff(_match, _match.AwayTeam))
  End Sub

  Private Sub ButtonF9TeamCaptions_Click(sender As Object, e As EventArgs) Handles ButtonF9TeamCaptions.Click

  End Sub

  Private Sub ButtonF10IdentClock_Click(sender As Object, e As EventArgs) Handles ButtonF10IdentClock.Click

  End Sub

  Private Sub ButtonF11OptaTop5_Click(sender As Object, e As EventArgs) Handles ButtonF11OptaTop5.Click

  End Sub

  Private Sub ButtonF12VideoTalkThroughts_Click(sender As Object, e As EventArgs) Handles ButtonF12VideoTalkThroughts.Click

  End Sub

  Private Sub ButtonCtlF1FullFramers_Click(sender As Object, e As EventArgs) Handles ButtonCtlF1FullFramers.Click
    Me.StartGraphic(New GraphicGroupCtlF1FullFramers(_match, _otherMatchDays))
  End Sub

  Private Sub ButtonCtlF2PlayerStatsCtrlF2_Click(sender As Object, e As EventArgs) Handles ButtonCtlF2PlayerStatsCtrlF2.Click

  End Sub

  Private Sub ButtonCtlF3ClockDropDown_Click(sender As Object, e As EventArgs) Handles ButtonCtlF3ClockDropDown.Click

  End Sub

  Private Sub ButtonCtlF4TwoWayBoxes_Click(sender As Object, e As EventArgs) Handles ButtonCtlF4TwoWayBoxes.Click

  End Sub

  Private Sub ButtonCtlF5PlayerBio_Click(sender As Object, e As EventArgs) Handles ButtonCtlF5PlayerBio.Click

  End Sub

  Private Sub ButtonCtlF6Referee_Click(sender As Object, e As EventArgs) Handles ButtonCtlF6Referee.Click

  End Sub

  Private Sub ButtonCtlF7ScoreBugs_Click(sender As Object, e As EventArgs) Handles ButtonCtlF7ScoreBugs.Click

  End Sub

  Private Sub ButtonCtlF8Bugs_Click(sender As Object, e As EventArgs) Handles ButtonCtlF8Bugs.Click

  End Sub

  Private Sub ButtonCtlF9AddedTree_Click(sender As Object, e As EventArgs) Handles ButtonCtlF9AddedTree.Click

  End Sub

  Private Sub ButtonCtlF10L3TeamStatsDb_Click(sender As Object, e As EventArgs) Handles ButtonCtlF10L3TeamStatsDb.Click

  End Sub

  Private Sub ButtonCtlF11AsItStands_Click(sender As Object, e As EventArgs) Handles ButtonCtlF11AsItStands.Click

  End Sub

  Private Sub ButtonCtlF12FFIdent_Click(sender As Object, e As EventArgs) Handles ButtonCtlF12FFIdent.Click
    Me.StartGraphic(New GraphicsCtlF12MatchIdent(_match))
  End Sub

  Private Sub ButtonShftF1PenaltyShootOut_Click(sender As Object, e As EventArgs) Handles ButtonShftF1PenaltyShootOut.Click

  End Sub

  Private Sub ButtonShftF2Interview_Click(sender As Object, e As EventArgs) Handles ButtonShftF2Interview.Click

  End Sub

  Private Sub ButtonShftF3NameNoNumber_Click(sender As Object, e As EventArgs) Handles ButtonShftF3NameNoNumber.Click

  End Sub

  Private Sub ButtonTeamListsCrawl_Click(sender As Object, e As EventArgs) Handles ButtonTeamListsCrawl.Click

  End Sub

  Private Sub ButtonShftF5TeamStatsMultiline_Click(sender As Object, e As EventArgs) Handles ButtonShftF5TeamStatsMultiline.Click

  End Sub

  Private Sub ButtonShftF7L3Commons_Click(sender As Object, e As EventArgs) Handles ButtonShftF7L3Commons.Click

  End Sub

  Private Sub ButtonShftF8TeamListsCrawlSF8_Click(sender As Object, e As EventArgs) Handles ButtonShftF8TeamListsCrawlSF8.Click
    Me.StartGraphic(New GraphicGroupCrawlTeams(_match))
  End Sub

  Private Sub ButtonShftF9OtherScores_Click(sender As Object, e As EventArgs) Handles ButtonShftF9OtherScores.Click

  End Sub

  Private Sub ButtonShftF10ClockCard_Click(sender As Object, e As EventArgs) Handles ButtonShftF10ClockCard.Click

  End Sub

  Private Sub ButtonShftF11ActionAreas_Click(sender As Object, e As EventArgs) Handles ButtonShftF11ActionAreas.Click

  End Sub

  Private Sub ButtonShftF12MatchScoresCrawl_Click(sender As Object, e As EventArgs) Handles ButtonShftF12MatchScoresCrawl.Click
    Me.StartGraphic(New GraphicsCrawlResults(_match, _otherMatchDays))
  End Sub

  Private Sub ButtonAltF2FreeTextCrawl_Click(sender As Object, e As EventArgs) Handles ButtonAltF2FreeTextCrawl.Click
    Me.StartGraphic(New GraphicsCrawlFreeText(_match))
  End Sub

  Private Sub ButtonAltF6HtFtBug_Click(sender As Object, e As EventArgs) Handles ButtonAltF6HtFtBug.Click

  End Sub

#End Region

#Region "Vizcontrol"
  Private Sub _vizControl_TCPSocketConnected() Handles _vizControl.TCPSocketConnected
    Me.UpdateStatusLabel()
  End Sub

  Private Sub _vizControl_TCPSocketDisconnected() Handles _vizControl.TCPSocketDisconnected
    Me.UpdateStatusLabel()
  End Sub
#End Region

#Region "Main controls"
  Private Sub ButtonAwayGoal_Click(sender As Object, e As EventArgs) Handles ButtonAwayGoal.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.AwayTeam

      If MetroFramework.MetroMessageBox.Show(Me, "Do you want to set a goal to " & team.ToString & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps
        Dim gg As New ControlScoreSingleGoal(_match)
        gg.IsLocalTeam = False

        _match.AddGoal(False, Nothing, False, False)

        '_match.away_goals += 1

        Me.StartGraphic(gg)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ButtonHomeGoal_Click(sender As Object, e As EventArgs) Handles ButtonHomeGoal.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.HomeTeam

      If MetroFramework.MetroMessageBox.Show(Me, "Do you want to set a goal to " & team.ToString & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps
        Dim gg As New ControlScoreSingleGoal(_match)
        gg.IsLocalTeam = True

        _match.AddGoal(True, Nothing, False, False)

        StartGraphic(gg)
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

        Dim XX As New MetroFramework.Components.MetroStyleManager()
        Me.MetroLabelPeriodTime.StyleManager = XX

        If _match.MatchPeriods.ActivePeriod.PlayingTime > _match.MatchPeriods.ActivePeriod.TotalTime Then
          labelColor = colorOn
          XX.Theme = MetroFramework.MetroThemeStyle.Dark
          Me.MetroLabelPeriodTime.Style = MetroFramework.MetroColorStyle.Red
          Me.MetroLabelPeriodTime.Invalidate()
        Else
          labelColor = colorOff
          XX.Theme = MetroFramework.MetroThemeStyle.Light

          Me.MetroLabelPeriodTime.Style = MetroFramework.MetroColorStyle.Blue
        End If
      End If
      Me.MetroLabelPeriodTime.BackColor = labelColor
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub MetroButtonClockIN_Click(sender As Object, e As EventArgs) Handles MetroButtonClockIN.Click
    _clockControl.ShowIdentClock()
  End Sub

  Private Sub MetroButtonClockOUT_Click(sender As Object, e As EventArgs) Handles MetroButtonClockOUT.Click
    _clockControl.HideIdentClock()
  End Sub

  Private Sub MetroButtonClockSubstitutions_Click(sender As Object, e As EventArgs) Handles MetroButtonClockSubstitutions.Click
    'Me.StartGraphic(New ClockSubstitutes(_match))
    Dim dlg As New FormSubstitutions()
    dlg.Match = _match
    dlg.Show(Me)
  End Sub

  Private Sub MetroButtonClockStats_Click(sender As Object, e As EventArgs) Handles MetroButtonClockStats.Click
    Me.StartGraphic(New ClockGenericStraps(_match))
  End Sub

  Private Sub MetroButtonClockStrapsWithIcon_Click(sender As Object, e As EventArgs) Handles MetroButtonClockStrapsWithIcon.Click
    Me.StartGraphic(New ClockStrapsWithIcon(_match))
  End Sub

  Private Sub MetroButtonClockOtherScores_Click(sender As Object, e As EventArgs) Handles MetroButtonClockOtherScores.Click
    Me.StartGraphic(New ClockOtherScores(_match))
  End Sub

  Private Sub MetroButtonClockPenalties_Click(sender As Object, e As EventArgs) Handles MetroButtonClockPenalties.Click
    Me.StartGraphic(New ClockPenalties(_match))
  End Sub

#End Region

#Region "Other Matches"
  Private WithEvents _frmMatchDay As frmMatchDay
  Public Sub ShowOtherMatches()
    Try
      _frmMatchDay = New frmMatchDay()
      Dim mps As New Competitions()
      mps.GetFromDB("")
      _frmMatchDay.Competition = mps.GetCompetition(_match.competition_id)
      _frmMatchDay.OtherMatchDays = _otherMatchDays
      If _frmMatchDay.ShowDialog(Me) = DialogResult.OK Then
        _otherMatchDays = _frmMatchDay.OtherMatchDays
      End If
      _frmMatchDay.Dispose()
      _frmMatchDay = Nothing
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Team viewer"
  Private _selectedPlayer As Player = Nothing
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

  Private Sub TeamViewerHome_GoalScored(team As Team, player As Player, add As Boolean)

  End Sub

  Private Sub TeamViewerAway_GoalScored(team As Team, player As Player, add As Boolean)

  End Sub

  Private Sub TeamViewerHome_Load(sender As Object, e As EventArgs)

  End Sub

  Private Sub TeamViewerAway_Load(sender As Object, e As EventArgs)

  End Sub

  Private Sub PlayerHomeViewer1_Load(sender As Object, e As EventArgs) ' Handles PlayerViewer1.Load

  End Sub
  Private Sub PlayerViewer_SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
    If _updating Then Exit Sub
    _updating = True
    Try
      If _match Is Nothing Then Exit Sub
      For Each ctl As PlayerViewer In _homePlayerControls
        ctl.IsSelected = (ctl.Player.ID = sender.Player.ID)
      Next
      For Each ctl As PlayerViewer In _awayPlayerControls
        ctl.IsSelected = (ctl.Player.ID = sender.Player.ID)
      Next

    Catch ex As Exception
    End Try
    _updating = False
  End Sub

  Private Sub PlayerHomeViewer_GoalScored(ByRef sender As PlayerViewer, add As Boolean)
    If _updating Then Exit Sub
    _updating = True

    Try
      If _match Is Nothing Then Exit Sub
      _match.AddGoal(True, sender.Player, False, False)
    Catch ex As Exception
    End Try
    _updating = False
  End Sub

  Private Sub PlayerAwayViewer_GoalScored(ByRef sender As PlayerViewer, add As Boolean)
    If _updating Then Exit Sub
    _updating = True

    Try
      If _match Is Nothing Then Exit Sub
      _match.AddGoal(False, sender.Player, False, False)
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
        Next
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub PlayerAwayViewer1_Load(sender As Object, e As EventArgs) Handles PlayerAwayViewer1.Load

  End Sub

#End Region
End Class
