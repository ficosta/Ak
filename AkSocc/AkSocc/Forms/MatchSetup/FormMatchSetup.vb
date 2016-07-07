Imports MatchInfo

Public Class FormMatchSetup
  Private _officials As New Officials


  Public Sub New(match As Match)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.Match = match
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
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.UcTeamMatchSetupHome.Save()
    Me.UcTeamMatchSetupAway.Save()
    Me.Close()
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
      Else
        'match.GetMatch()

        'match.HomeTeam.GetFullMatchData()
        'match.AwayTeam.GetFullMatchData()

        Me.UcTeamMatchSetupHome.Team = match.HomeTeam
        Me.UcTeamMatchSetupAway.Team = match.AwayTeam

        Me.MetroLabelHomeTeam.Text = match.HomeTeam.TeamAELCaption1Name
        Me.MetroLabelAwayTeam.Text = match.AwayTeam.TeamAELCaption1Name
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
End Class