﻿Imports MatchInfo

Public Class FormMatchSelector
  Private _matches As MatchInfo.Matches

  Public Property SelectedMatchId As Integer
  Public Property SelectedCompetitionId As Integer

  Public Property SelectedMatch As Match = Nothing
  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If SelectedMatchId = 0 Then
      frmWaitForInput.ShowWaitDialog(Me, "No match selected", "Options", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Else
      Dim version As GraphicVersion = CType(Me.ComboBoxSceneVersion.SelectedItem, GraphicVersion)
      GraphicVersions.Instance.SelectedGraphicVersion = version
      If Not version Is Nothing Then
        AppSettings.Instance.ScenePath = version.Path
      End If

      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogMatchSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      InitCompetitions(AppSettings.Instance.LastCompetitionId)
      Dim index As Integer = -1
      Me.ComboBoxSceneVersion.Items.Clear()

      For Each version As GraphicVersion In GraphicVersions.Instance
        Me.ComboBoxSceneVersion.Items.Add(version)
        If version.Path = AppSettings.Instance.ScenePath Then
          index = Me.ComboBoxSceneVersion.Items.Count - 1
        End If
      Next

      If index > -1 Then
        Me.ComboBoxSceneVersion.Text = GraphicVersions.Instance(index).Name
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub InitCompetitions(compID As Integer)
    Try
      cboCompetition.Items.Clear()

      'Fill Competition
      Dim myCompetitions As New Competitions()
      Dim index As Integer = 0
      myCompetitions.GetFromDB("")
      For Each myCompetition As Competition In myCompetitions
        cboCompetition.Items.Add(myCompetition)
        If myCompetition.CompID = compID Then index = cboCompetition.Items.Count - 1
      Next
      cboCompetition.SelectedIndex = index
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub cboCompetition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompetition.SelectedIndexChanged
    Try
      ShowMatches()
    Catch err As Exception
      WriteToErrorLog(err)
    End Try
  End Sub

  Private Sub ShowMatches()
    Try
      '      lblLeague.Text = cboCompetition.Text.ToUpper()
      '      GlobalCompetition = 
      Dim comp As Competition = DirectCast(cboCompetition.SelectedItem, Competition)
      Dim selectedIndex As Integer = -1
      'Fill The Matches
      With Me.MetroGridMatches
        .Rows.Clear()
        Dim index As Integer = 0
        'myMatches.GetFromDB("WHERE CompID = " + comp.CompID.ToString() + " ORDER BY MatchDate ASC")
        _matches = Matches.GetMatchesForCompetition(comp.CompID)
        For iMatch As Integer = _matches.Count - 1 To 0 Step -1
          Dim myMatch As Match = _matches(iMatch)
          Dim sResult As String = IIf(myMatch.away_goals >= 0 And myMatch.home_goals >= 0, myMatch.home_goals & "-" & myMatch.away_goals, "")
          .Rows.Add(myMatch.match_id, myMatch.match_date.ToShortDateString, myMatch.Description, sResult)
          'If myMatch.match_id = AppSettings.Instance.LastMatchId Then
          .Rows(.Rows.Count - 1).Cells(ColumnAwayTeam.Index).Value = myMatch.AwayTeam.TeamAELCaption1Name
          .Rows(.Rows.Count - 1).Cells(ColumnHomeTeam.Index).Value = myMatch.HomeTeam.TeamAELCaption1Name
          .Rows(.Rows.Count - 1).Cells(ColumnResult.Index).Value = sResult
          If Not SelectedMatch Is Nothing AndAlso SelectedMatch.match_id = myMatch.match_id Then
            .Rows(.Rows.Count - 1).Selected = True
          Else
            .Rows(.Rows.Count - 1).Selected = False
          End If
        Next
        If .Rows.Count > 0 Then
          selectedIndex = index
        End If
        '.Rows(selectedIndex).Selected = True
      End With


    Catch err As Exception
      WriteToErrorLog(err)
    End Try
  End Sub


  Private Sub InitMatches(matchID As Integer)
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub InitNewMatch()
    'Try
    '  HomeTeamMatchStat = New AcTeamMatchStat()
    '  AwayTeamMatchStat = New AcTeamMatchStat()

    '  MatchID.Text = GlobalMatch.MatchId.ToString()
    '  HomeTeam = GlobalMatch.Team1

    '  txtHomeName.Text = HomeTeam.TeamAELCaption1Name.ToUpper()
    '  HomeGoalPlus1.Text = HomeTeam.TeamAELCaption1Name.ToUpper() + " GOAL   ALT+1"
    '  FirstTeamStuff.Text = HomeTeam.TeamAELCaption1Name.ToUpper() + " STAFF   F7"
    '  txtHomeShortName.Text = HomeTeam.TeamAELTinyName
    '  HomeTeam.TeamClockColour = TeamImageInfos.GetTeamColor(HomeTeam.TeamID)

    '  AwayTeam = GlobalMatch.Team2
    '  txtAwayName.Text = AwayTeam.TeamAELCaption1Name.ToUpper()
    '  AwayGoalPlus1.Text = AwayTeam.TeamAELCaption1Name.ToUpper() + " GOAL   ALT+2"
    '  SecondTeamStuff.Text = AwayTeam.TeamAELCaption1Name.ToUpper() + " STAFF   F8"
    '  txtAwayShortName.Text = AwayTeam.TeamAELTinyName
    '  AwayTeam.TeamClockColour = TeamImageInfos.GetTeamColor(AwayTeam.TeamID)

    '  Try
    '    If System.IO.File.Exists(ShieldPathPC + HomeTeam.BadgeName + ".png") Then
    '      imgHomeTeamBadge.Image = Image.FromFile(ShieldPathPC + HomeTeam.BadgeName + ".png")
    '    End If
    '  Catch
    '    imgHomeTeamBadge.Image = Nothing
    '  End Try
    '  Try
    '    If System.IO.File.Exists(ShieldPathPC + AwayTeam.BadgeName + ".png") Then
    '      imgAwayTeamBadge.Image = Image.FromFile(ShieldPathPC + AwayTeam.BadgeName + ".png")
    '    End If
    '  Catch
    '    imgAwayTeamBadge.Image = Nothing
    '  End Try

    '  HomePlayers = New Players()
    '  HomePlayers.GetPlayers(GlobalMatch.TeamID1)

    '  AwayPlayers = New Players()
    '  AwayPlayers.GetPlayers(GlobalMatch.TeamID2)

    '  PlayerStats = New PlayerStats()
    '  PlayerStats.GetFromDB("WHERE MatchID = " + GlobalMatch.MatchId)

    '  'Get Goals
    '  MatchGoals = New AcMatchGoals()
    '  MatchGoals.GetMatchGoals(GlobalMatch.MatchId)
    '  Dim HomeGoal As Integer = 0, AwayGoal As Integer = 0
    '  For Each myGoal As AcMatchGoal In MatchGoals
    '    If myGoal.TeamGoalID = HomeTeam.TeamID Then
    '      HomeGoal += 1
    '    Else
    '      AwayGoal += 1
    '    End If
    '  Next
    '  HomeGoals.Text = HomeGoal.ToString()
    '  AwayGoals.Text = AwayGoal.ToString()


    '  'Get events
    '  MatchEvents = New AcMatchEvents()
    '  MatchEvents.GetMatchEvents(GlobalMatch.MatchId)
    '  'this.lsvEvents.Clear();
    '  For i As Integer = lsvEvents.Items.Count - 1 To 0 Step -1
    '    lsvEvents.Items.RemoveAt(0)
    '  Next
    '  For Each myEvent As AcMatchEvent In MatchEvents
    '    ShowEvent(myEvent, "")
    '  Next
    '  UpdateValuesFromMatchEvents()


    '  ResetColorsAndKits()

    '  SetBothPlayersFormation()

    '  If optFormTeamHome.Checked Then
    '    SetPlayersFormation()
    '  Else
    '    optFormTeamHome.Checked = True
    '  End If

    '  UpdateValuesFromMatchEvents()

    '  Dim SnapPath As New System.IO.DirectoryInfo(AppSettings.Instance.VizrtPreviewFile)
    '  For Each file As System.IO.FileInfo In SnapPath.GetFiles()
    '    file.Delete()
    '  Next
    'Catch err As Exception
    '  Log("ERROR! cboMatch_SelectedIndexChanged " + err.Message)
    'End Try
  End Sub


  Private Sub ShowMatchInfo(match As Match)
    Try
      If match Is Nothing Then
        Me.SelectedMatchId = 0
        Me.SelectedMatch = match
      Else
        match.GetMatch()

        match.HomeTeam.GetFullMatchData()
        match.AwayTeam.GetFullMatchData()


        Me.SelectedMatch = match
        Me.SelectedMatchId = match.match_id

        'Me.MetroLabelHomeTeam.Text = match.HomeTeam.TeamAELCaption1Name
        'Me.MetroLabelAwayTeam.Text = match.AwayTeam.TeamAELCaption1Name
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridMatches_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridMatches.SelectionChanged
    Exit Sub

    Dim selectedIndex As Integer = -1

    Try
      For i As Integer = 0 To MetroGridMatches.Rows.Count - 1
        If MetroGridMatches.Rows(i).Selected Then selectedIndex = i
      Next
      If selectedIndex >= 0 Then
        Dim id As Integer = CInt(MetroGridMatches.Rows(selectedIndex).Cells(ColumnID.Index).Value)
        SelectedMatch = _matches.GetMatch(id)
      Else
        SelectedMatch = Nothing
      End If
      ShowMatchInfo(SelectedMatch)

    Catch ex As Exception

    End Try
  End Sub


  Private Sub MetroGridMatches_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridMatches.CellClick
    Dim selectedIndex As Integer = -1
    Me.Cursor = Cursors.WaitCursor
    Try
      For i As Integer = 0 To MetroGridMatches.Rows.Count - 1
        If MetroGridMatches.Rows(i).Selected Then selectedIndex = i
      Next
      If selectedIndex >= 0 Then
        SelectedMatchId = CInt(MetroGridMatches.Rows(selectedIndex).Cells(ColumnID.Index).Value)
        ' SelectedMatch = _matches.GetMatch(id)
      Else
        'SelectedMatch = Nothing
      End If
      'ShowMatchInfo(SelectedMatch)

    Catch ex As Exception

    End Try
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub MetroGridMatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridMatches.CellContentClick

  End Sub

  Private Sub MetroGridMatches_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGridMatches.KeyDown
    Select Case e.KeyCode
      Case Keys.Return
        e.Handled = True
    End Select
  End Sub

  Private Sub MetroGridMatches_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MetroGridMatches.PreviewKeyDown

  End Sub
End Class