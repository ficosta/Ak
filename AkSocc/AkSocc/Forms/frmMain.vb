Imports AkSocc
Imports MatchInfo

Public Class frmMain
#Region "Properties and variables"
  Private WithEvents _match As MatchInfo.Match
  Private WithEvents _statGraphic As GraphicStep
  Private WithEvents _dlgChoosWithPreview As FormChoose
  Private WithEvents _vizControl As VizCommands.VizControl
  Private WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _clockControl As ClockControl = ClockControl.Instance
#End Region

#Region "Constructor"

#End Region

#Region "Interface functions"

#End Region

#Region "Form events"
  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      If My.Settings.ShowSettingsOnStartup Then
        ShowOptions(Me)
      End If
      InitControls()
      MatchSetup()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

#Region "Initialize functions"
  Private Sub InitControls()
    Try
      Me.UpdateStatusLabel()
      _vizControl = New VizCommands.VizControl
      _vizControl.Config = New VizCommands.tyConfigVizrt
      _vizControl.Config.TCPHost = My.Settings.VizrtHost
      _vizControl.Config.TCPPort = My.Settings.VizrtPort
      _vizControl.Config.SceneBasePath = My.Settings.ScenePath
      _vizControl.InitializeSockets()

      _previewControl = New VizCommands.PreviewControl(_vizControl.Config)
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
      ShowMatchDay()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ToolStripButtonClassification_Click(sender As Object, e As EventArgs) Handles ToolStripButtonClassification.Click

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
    Try

      If Not _match Is Nothing AndAlso _match.match_id <> match.match_id Then
        ReleaseDataBinding()
      End If

      _match = match
      If Not _match Is Nothing Then
        Me.LabelAwayTeamName.Text = _match.AwayTeam.ToString
        Me.LabelHomeTeamName.Text = _match.HomeTeam.ToString

        Me.LabelAwayTeamShortName.Text = _match.AwayTeam.TeamAELTinyName
        Me.LabelHomeTeamShortName.Text = _match.HomeTeam.TeamAELTinyName

        EngageDataBinding()

        Me.TeamViewer1.Team = _match.HomeTeam
        Me.TeamViewer2.Team = _match.AwayTeam
      Else
        Me.LabelAwayTeamName.Text = ""
        Me.LabelHomeTeamName.Text = ""

      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
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

  Private Sub TeamViewer1_SelectedPlayerChanged(sender As TeamViewer, player As Player) Handles TeamViewer1.SelectedPlayerChanged
    If _updating Then Exit Sub
    _updating = True

    TeamViewer2.SelectedPlayer = Nothing
    _updating = False

  End Sub

  Private Sub TeamViewer2_SelectedPlayerChanged(sender As TeamViewer, player As Player) Handles TeamViewer2.SelectedPlayerChanged
    If _updating Then Exit Sub
    _updating = True

    TeamViewer1.SelectedPlayer = Nothing
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

  End Sub

  Private Sub ButtonF3L3Subs_Click(sender As Object, e As EventArgs) Handles ButtonF3L3Subs.Click

  End Sub

  Private Sub ButtonF4ClockSubs_Click(sender As Object, e As EventArgs) Handles ButtonF4ClockSubs.Click

  End Sub

  Private Sub ButtonF5TeamMatchStats_Click(sender As Object, e As EventArgs) Handles ButtonF5TeamMatchStats.Click

  End Sub

  Private Sub ButtonF6PlayerName_Click(sender As Object, e As EventArgs) Handles ButtonF6PlayerName.Click

  End Sub

  Private Sub ButtonF7FirstTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF7FirstTeamStuff.Click

  End Sub

  Private Sub ButtonF8SecondTeamStuff_Click(sender As Object, e As EventArgs) Handles ButtonF8SecondTeamStuff.Click

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
    Me.StartGraphic(New GraphicGroupCtlF1FullFramers(_match))
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

  End Sub

  Private Sub ButtonShftF9OtherScores_Click(sender As Object, e As EventArgs) Handles ButtonShftF9OtherScores.Click

  End Sub

  Private Sub ButtonShftF10ClockCard_Click(sender As Object, e As EventArgs) Handles ButtonShftF10ClockCard.Click

  End Sub

  Private Sub ButtonShftF11ActionAreas_Click(sender As Object, e As EventArgs) Handles ButtonShftF11ActionAreas.Click

  End Sub

  Private Sub ButtonShftF12MatchScoresCrawl_Click(sender As Object, e As EventArgs) Handles ButtonShftF12MatchScoresCrawl.Click

  End Sub

  Private Sub ButtonAltF2FreeTextCrawl_Click(sender As Object, e As EventArgs) Handles ButtonAltF2FreeTextCrawl.Click

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

        StartGraphic(gg)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
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

  Private Sub MetroButtonMatchSubstitutions_Click(sender As Object, e As EventArgs) Handles MetroButtonMatchSubstitutions.Click

  End Sub
#End Region

#Region "Other Matches"
  Private WithEvents _frmMatchDay As frmMatchDay
  Public Sub ShowMatchDay()
    Try
      _frmMatchDay = New frmMatchDay()
      Dim mps As New Competitions()
      mps.GetFromDB("")
      _frmMatchDay.Competition = mps.GetCompetition(_match.competition_id)
      If _frmMatchDay.ShowDialog(Me) = DialogResult.OK Then

      End If
      _frmMatchDay.Dispose()
      _frmMatchDay = Nothing
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

End Class
