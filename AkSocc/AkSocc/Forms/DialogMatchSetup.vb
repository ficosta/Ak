Imports System.Windows.Forms
Imports MatchInfo

Public Class DialogMatchSetup
  Private _matches As New MatchInfo.Matches

  Public Property SelectedMatchId As Integer
  Public Property SelectedCompetitionId As Integer

  Public Property SelectedMatch As Match = Nothing

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogMatchSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      InitCompetitions(My.Settings.LastCompetitionId)
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
      '      lblLeague.Text = cboCompetition.Text.ToUpper()
      '      GlobalCompetition = 
      Dim comp As Competition = DirectCast(cboCompetition.SelectedItem, Competition)
      'Fill The Matches
      cboMatch.Items.Clear()
      cboMatch.Text = ""
      'Dim myMatches As New Matches()
      Dim index As Integer = 0
      'myMatches.GetFromDB("WHERE CompID = " + comp.CompID.ToString() + " ORDER BY MatchDate ASC")
      For Each myMatch As Match In Matches.GetMatchesForCompetition(comp.CompID)
        cboMatch.Items.Add(myMatch)
        If myMatch.match_id = My.Settings.LastMatchId Then index = cboMatch.Items.Count - 1
      Next
      If cboMatch.Items.Count > 0 Then cboMatch.SelectedIndex = index
    Catch err As Exception
      WriteToErrorLog(err)
    End Try
  End Sub


  Private Sub InitMatches(matchID As Integer)
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub cboMatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMatch.SelectedIndexChanged
    Try
      Dim match As Match = DirectCast(cboMatch.SelectedItem, Match)

      match.GetMatch()

      match.HomeTeam.GetFullMatchData()
      match.AwayTeam.GetFullMatchData()
      ShowMatchInfo(match)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub cboMatch_SelectedIndexChangeld(sender As Object, e As EventArgs)

    Me.Cursor = Cursors.WaitCursor

    SelectedMatch = DirectCast(cboMatch.SelectedItem, Match)

    If SelectedMatch IsNot Nothing Then
      InitNewMatch()

      If SelectedMatch IsNot Nothing Then
        SelectedMatch.GetMatch()
        '  ResetColorsAndKits()
      End If
    End If
    Me.Cursor = Cursors.[Default]
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

    '  Dim SnapPath As New System.IO.DirectoryInfo(Properties.Settings.[Default].VizrtPreviewFile)
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
        Me.SelectedMatch = match
        Me.SelectedMatchId = match.match_id
      End If
    Catch ex As Exception

    End Try
  End Sub
End Class
