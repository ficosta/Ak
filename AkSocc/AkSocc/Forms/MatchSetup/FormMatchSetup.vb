Imports MatchInfo

Public Class FormMatchSetup
  Private _officials As New Officials


  Public Sub New(match As Match)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      DesserializeObjectFromString(AppSettings.Instance.TeamImageInfoList, TeamImageInfos)
      Me.Match = match
    Catch ex As Exception
    End Try
  End Sub

  Private _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      Me.ShowMatchInfo(_match)
    End Set
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Try
      Me.Cursor = Cursors.WaitCursor
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Match.Official1 = _officials.GetByName(Me.MetroComboBoxReferee1.Text)
      Me.Match.Official2 = _officials.GetByName(Me.MetroComboBoxReferee2.Text)
      Me.Match.Official3 = _officials.GetByName(Me.MetroComboBoxReferee3.Text)
      Config.Instance.AsyncDataWrites = True
      Me.UcTeamMatchSetupHome.Save()
      Me.UcTeamMatchSetupAway.Save()
      Me.Close()
    Catch ex As Exception

    End Try
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogMatchSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try

      Me.UcTeamMatchSetupHome.Color = Color.Turquoise
      Me.UcTeamMatchSetupHome.IsLocalTeam = True
      Me.UcTeamMatchSetupAway.Color = Color.SaddleBrown
      Me.UcTeamMatchSetupAway.IsLocalTeam = True

      For Each official As Official In _officials
        Me.MetroComboBoxReferee1.Items.Add(official)
        Me.MetroComboBoxReferee2.Items.Add(official)
        Me.MetroComboBoxReferee3.Items.Add(official)
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ShowMatchInfo(match As Match)
    Try
      If match Is Nothing Then
        Me.UcTeamMatchSetupHome.Team = Nothing
        Me.UcTeamMatchSetupAway.Team = Nothing
        Me.MetroLabelHomeTeam.Text = ""
        Me.MetroLabelAwayTeam.Text = ""
        Me.Text = "Match setup"
      Else
        Me.Text = "Match setup.  " & _match.ToString
        'match.GetMatch()

        'match.HomeTeam.GetFullMatchData()
        'match.AwayTeam.GetFullMatchData()
        'save referee

        Me.UcTeamMatchSetupHome.Team = match.HomeTeam
        Me.UcTeamMatchSetupAway.Team = match.AwayTeam

        Me.MetroLabelHomeTeam.Text = match.HomeTeam.TeamAELCaption1Name
        Me.MetroLabelAwayTeam.Text = match.AwayTeam.TeamAELCaption1Name

        LoadColors()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "Colors"


  Private Sub LoadColors()
    If _match Is Nothing Then Exit Sub
    Try
      Dim JerseysPicsPC As String = GraphicVersions.Instance.SelectedGraphicVersion.LocalPathTShirts
      If JerseysPicsPC = "" Then JerseysPicsPC = AppSettings.Instance.KitsDefaultPath

      _match.HomeTeam.TeamClockColour = TeamImageInfos.GetTeamColor(_match.HomeTeam.ID)
      If _match.HomeTeam.TeamClockColour <> "" Then
        imgHomeClockColour.Image = Image.FromFile(System.IO.Path.Combine(GraphicVersions.Instance.SelectedGraphicVersion.PathColors, _match.HomeTeam.TeamClockColour))
        'grpHomePlayers.BackgroundImage = Image.FromFile(_match.HomeTeam.TeamClockColour)
      End If
      _match.AwayTeam.TeamClockColour = TeamImageInfos.GetTeamColor(_match.AwayTeam.ID)
      If _match.AwayTeam.TeamClockColour <> "" Then
        imgAwayClockColour.Image = Image.FromFile(System.IO.Path.Combine(GraphicVersions.Instance.SelectedGraphicVersion.PathColors, _match.AwayTeam.TeamClockColour))
        'grpAwayPlayers.BackgroundImage = Image.FromFile(_match.AwayTeam.TeamClockColour)
      End If
      _match.HomeTeam.GoalKeeperJersey = TeamImageInfos.GetTeamJerseyGK(_match.HomeTeam.ID)
      If _match.HomeTeam.GoalKeeperJersey <> "" Then
        imgHomeGoalKeeperJersey.Image = Image.FromFile(System.IO.Path.Combine(JerseysPicsPC, _match.HomeTeam.GoalKeeperJersey + ".png"))
      End If
      _match.AwayTeam.GoalKeeperJersey = TeamImageInfos.GetTeamJerseyGK(_match.AwayTeam.ID)
      If _match.AwayTeam.GoalKeeperJersey <> "" Then
        imgAwayGoalKeeperJersey.Image = Image.FromFile(System.IO.Path.Combine(JerseysPicsPC, _match.AwayTeam.GoalKeeperJersey + ".png"))
      End If
      _match.HomeTeam.PlayerJersey = TeamImageInfos.GetTeamJersey(_match.HomeTeam.ID)
      If _match.HomeTeam.PlayerJersey <> "" Then
        imgHomePlayerJersey.Image = Image.FromFile(System.IO.Path.Combine(JerseysPicsPC, _match.HomeTeam.PlayerJersey + ".png"))
      End If
      _match.AwayTeam.PlayerJersey = TeamImageInfos.GetTeamJersey(_match.AwayTeam.ID)
      If _match.AwayTeam.PlayerJersey <> "" Then
        imgAwayPlayerJersey.Image = Image.FromFile(System.IO.Path.Combine(JerseysPicsPC, _match.AwayTeam.PlayerJersey + ".png"))
      End If
    Catch ex As Exception

    End Try
  End Sub


  Private Const imageFileFilter As String = "Image files|*.jpg;*.png;*.tga;*.jpeg;*.bmp;*.tif;*.tiff| JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png"
  Private TeamImageInfos As New SerializableMatchInfo.TeamImageInfos()



  Private Sub ResetColorsAndKits()
    Dim homeTeamID As Integer = 0
    Dim awayTeamID As Integer = 0
    Dim file As String = ""
    If _match IsNot Nothing Then
      homeTeamID = _match.HomeTeam.TeamID
      awayTeamID = _match.AwayTeam.TeamID
    End If

    TeamImageInfos.DesserializeFromString(AppSettings.Instance.TeamImageInfoList)

    My.Settings.HomeColor = TeamImageInfos.GetTeamColor(homeTeamID)
    imgHomeClockColour.Image = If(System.IO.File.Exists(My.Settings.HomeColor), Image.FromFile(My.Settings.HomeColor), Nothing)
    'grpHomePlayers.BackgroundImage = imgHomeClockColour.Image

    My.Settings.AwayColor = TeamImageInfos.GetTeamColor(awayTeamID)
    imgAwayClockColour.Image = If(System.IO.File.Exists(My.Settings.AwayColor), Image.FromFile(My.Settings.AwayColor), Nothing)
    ' grpAwayPlayers.BackgroundImage = imgAwayClockColour.Image

    file = TeamImageInfos.GetTeamJerseyGK(awayTeamID)
    imgAwayGoalKeeperJersey.Image = If(System.IO.File.Exists(file), Image.FromFile(file), Nothing)
    My.Settings.AwayGKJersey = System.IO.Path.GetFileNameWithoutExtension(file)

    file = TeamImageInfos.GetTeamJersey(awayTeamID)
    imgAwayPlayerJersey.Image = If(System.IO.File.Exists(file), Image.FromFile(file), Nothing)
    My.Settings.AwayPJersey = System.IO.Path.GetFileNameWithoutExtension(file)

    file = TeamImageInfos.GetTeamJerseyGK(homeTeamID)
    imgHomeGoalKeeperJersey.Image = If(System.IO.File.Exists(file), Image.FromFile(file), Nothing)
    My.Settings.HomeGKJersey = System.IO.Path.GetFileNameWithoutExtension(file)

    file = TeamImageInfos.GetTeamJersey(homeTeamID)
    imgHomePlayerJersey.Image = If(System.IO.File.Exists(file), Image.FromFile(file), Nothing)
    My.Settings.HomePJersey = System.IO.Path.GetFileNameWithoutExtension(file)

  End Sub

  Private Sub imgHomeClockColour_Click(sender As Object, e As EventArgs) Handles imgHomeClockColour.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.InitialDirectory = AppSettings.Instance.ColorsDefaultPath
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Color for Home Team"
    If _match.HomeTeam.TeamClockColour = "" Then
      ofdSelectFile.InitialDirectory = AppSettings.Instance.ColorsDefaultPath
    Else
      ofdSelectFile.FileName = _match.HomeTeam.TeamClockColour
    End If
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      _match.HomeTeam.TeamClockColour = ofdSelectFile.FileName
      imgHomeClockColour.Image = Image.FromFile(_match.HomeTeam.TeamClockColour)
      ' grpHomePlayers.BackgroundImage = Image.FromFile(ofdSelectFile.FileName)
      ' My.Settings.HomeColor = _match.HomeTeam.TeamClockColour
      'My.Settings.Save()
      TeamImageInfos.SetTeamColor(_match.HomeTeam.TeamID, System.IO.Path.GetFileNameWithoutExtension(_match.HomeTeam.TeamClockColour))
    End If
  End Sub

  Private Sub imgAwayClockColour_Click(sender As Object, e As EventArgs) Handles imgAwayClockColour.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.InitialDirectory = AppSettings.Instance.ColorsDefaultPath
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Color for Away Team"
    If _match.AwayTeam.TeamClockColour = "" Then
      ofdSelectFile.InitialDirectory = AppSettings.Instance.ColorsDefaultPath
    Else
      ofdSelectFile.FileName = _match.AwayTeam.TeamClockColour
    End If
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      _match.AwayTeam.TeamClockColour = ofdSelectFile.FileName
      imgAwayClockColour.Image = Image.FromFile(_match.AwayTeam.TeamClockColour)
      'grpAwayPlayers.BackgroundImage = Image.FromFile(ofdSelectFile.FileName)
      ' My.Settings.AwayColor = _match.AwayTeam.TeamClockColour
      'My.Settings.Save()
      TeamImageInfos.SetTeamColor(_match.AwayTeam.TeamID, _match.AwayTeam.TeamClockColour)
    End If
  End Sub

  Private Sub imgHomeGoalKeeperJersey_Click(sender As Object, e As EventArgs) Handles imgHomeGoalKeeperJersey.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Jersey for Home Goal Keeper"
    ofdSelectFile.InitialDirectory = AppSettings.Instance.KitsDefaultPath
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      imgHomeGoalKeeperJersey.Image = Image.FromFile(ofdSelectFile.FileName)
      _match.HomeTeam.GoalKeeperJersey = ofdSelectFile.FileName.Substring(ofdSelectFile.FileName.LastIndexOf("\") + 1)
      _match.HomeTeam.GoalKeeperJersey = _match.HomeTeam.GoalKeeperJersey.Substring(0, _match.HomeTeam.GoalKeeperJersey.LastIndexOf("."))
      ' My.Settings.HomeGKJersey = _match.HomeTeam.GoalKeeperJersey
      ' My.Settings.Save()
      TeamImageInfos.SetTeamJerseyGK(_match.HomeTeam.TeamID, _match.HomeTeam.GoalKeeperJersey)
    End If
  End Sub

  Private Sub imgAwayGoalKeeperJersey_Click(sender As Object, e As EventArgs) Handles imgAwayGoalKeeperJersey.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Jersey for Away Goal Keeper"
    ofdSelectFile.InitialDirectory = AppSettings.Instance.KitsDefaultPath
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      imgAwayGoalKeeperJersey.Image = Image.FromFile(ofdSelectFile.FileName)
      _match.AwayTeam.GoalKeeperJersey = ofdSelectFile.FileName.Substring(ofdSelectFile.FileName.LastIndexOf("\") + 1)
      _match.AwayTeam.GoalKeeperJersey = _match.AwayTeam.GoalKeeperJersey.Substring(0, _match.AwayTeam.GoalKeeperJersey.LastIndexOf("."))
      'My.Settings.AwayGKJersey = _match.AwayTeam.GoalKeeperJersey
      'My.Settings.Save()
      TeamImageInfos.SetTeamJerseyGK(_match.AwayTeam.TeamID, _match.AwayTeam.GoalKeeperJersey)
    End If
  End Sub

  Private Sub imgHomePlayerJersey_Click(sender As Object, e As EventArgs) Handles imgHomePlayerJersey.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Jersey for Home Players"
    ofdSelectFile.InitialDirectory = AppSettings.Instance.KitsDefaultPath
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      imgHomePlayerJersey.Image = Image.FromFile(ofdSelectFile.FileName)
      _match.HomeTeam.PlayerJersey = ofdSelectFile.FileName.Substring(ofdSelectFile.FileName.LastIndexOf("\") + 1)
      _match.HomeTeam.PlayerJersey = _match.HomeTeam.PlayerJersey.Substring(0, _match.HomeTeam.PlayerJersey.LastIndexOf("."))
      'My.Settings.HomePJersey = _match.HomeTeam.PlayerJersey
      'My.Settings.Save()
      TeamImageInfos.SetTeamJersey(_match.HomeTeam.TeamID, _match.HomeTeam.PlayerJersey)
    End If
  End Sub

  Private Sub imgAwayPlayerJersey_Click(sender As Object, e As EventArgs) Handles imgAwayPlayerJersey.Click
    ofdSelectFile.Filter = imageFileFilter
    ofdSelectFile.Multiselect = False
    ofdSelectFile.Title = "Select Viz Jersey for Away Players"
    ofdSelectFile.InitialDirectory = AppSettings.Instance.KitsDefaultPath
    If ofdSelectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      imgAwayPlayerJersey.Image = Image.FromFile(ofdSelectFile.FileName)
      _match.AwayTeam.PlayerJersey = ofdSelectFile.FileName.Substring(ofdSelectFile.FileName.LastIndexOf("\") + 1)
      _match.AwayTeam.PlayerJersey = _match.AwayTeam.PlayerJersey.Substring(0, _match.AwayTeam.PlayerJersey.LastIndexOf("."))
      'My.Settings.AwayPJersey = _match.AwayTeam.PlayerJersey
      'My.Settings.Save()
      TeamImageInfos.SetTeamJersey(_match.AwayTeam.TeamID, _match.AwayTeam.PlayerJersey)
    End If
  End Sub

#End Region
End Class