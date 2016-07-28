Imports System.ComponentModel
Imports MatchInfo

Public Class UCOtherMatch

  Public Event MoveUp(sender As UCOtherMatch)
  Public Event MoveDown(sender As UCOtherMatch)
  Public Event Delete(sender As UCOtherMatch)
  Public Event AddNew(sender As UCOtherMatch)

#Region "Properties"
  Private WithEvents _otherMatch As OtherMatch
  Public Property OtherMatchInfo As OtherMatch
    Get
      Return _otherMatch
    End Get
    Set(value As OtherMatch)
      _otherMatch = value
      Me.UpdateControls()
    End Set
  End Property

  Private _competition As Competition
  Public Property Competition As Competition
    Get
      Return _competition
    End Get
    Set(value As Competition)
      _competition = value
      Me.MetroComboBoxMatch.Items.Clear()
      If Not _competition Is Nothing Then
        'Dim _matches As Matches = Matches.GetMatchesForCompetition(_competition.CompID)

        'For Each match As Match In _matches
        '  Me.MetroComboBoxMatch.Items.Add(match)
        'Next
      End If
    End Set
  End Property

  Private _matches As Matches
  Public Property Matches As Matches
    Get
      Return _matches
    End Get
    Set(value As Matches)
      _matches = value
      Me.MetroComboBoxMatch.Items.Clear()

      Me.MetroComboBoxMatch.Items.Add("")

      If Not _matches Is Nothing Then
        For Each match As Match In _matches
          Me.MetroComboBoxMatch.Items.Add(match)
        Next
      End If
    End Set
  End Property

  Private _arrowUpVisible As Boolean = True
  Public Property ArrowUpVisible() As Boolean
    Get
      Return _arrowUpVisible
    End Get
    Set(ByVal value As Boolean)
      _arrowUpVisible = value
      Me.UpdateButtons()
    End Set
  End Property

  Private _arrowDownVisible As Boolean = True
  Public Property ArrowDownVisible() As Boolean
    Get
      Return _arrowDownVisible
    End Get
    Set(ByVal value As Boolean)
      _arrowDownVisible = value
      Me.UpdateButtons()
    End Set
  End Property

  Public Enum eButtonAction
    None
    AddNew
    Delete
  End Enum

  Private _buttonActionEnum As eButtonAction = eButtonAction.AddNew
  Public Property ButtonActionEnum As eButtonAction
    Get
      Return _buttonActionEnum
    End Get
    Set(value As eButtonAction)
      _buttonActionEnum = value
      Me.UpdateButtons()
    End Set
  End Property
#End Region

#Region "Buttons"
  Private Sub ButtonUP_Click(sender As Object, e As EventArgs) Handles ButtonUP.Click
    RaiseEvent MoveUp(Me)
  End Sub

  Private Sub ButtonDOWN_Click(sender As Object, e As EventArgs) Handles ButtonDOWN.Click
    RaiseEvent MoveDown(Me)
  End Sub

  Private Sub ButtonAction_Click(sender As Object, e As EventArgs) Handles ButtonAction.Click
    Select Case _buttonActionEnum
      Case eButtonAction.AddNew
        RaiseEvent AddNew(Me)
      Case eButtonAction.Delete
        RaiseEvent Delete(Me)
      Case Else
    End Select
  End Sub

  Private Sub UpdateButtons()
    Me.ButtonUP.Visible = _arrowUpVisible
    Me.ButtonDOWN.Visible = _arrowDownVisible
    Select Case _buttonActionEnum
      Case eButtonAction.AddNew
        Me.ButtonAction.Visible = True
        Me.ButtonAction.Text = "Add New"
      Case eButtonAction.Delete
        Me.ButtonAction.Visible = True
        Me.ButtonAction.Text = "Delete"
      Case Else
        Me.ButtonAction.Visible = False
        Me.ButtonAction.Text = "Action"
    End Select
  End Sub
#End Region

#Region "CheckBoxes"
  Private Sub MetroCheckBoxAddToCrawl_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBoxAddToCrawl.CheckedChanged
    If _initializing Then Exit Sub
    If Not _otherMatch Is Nothing Then
      _otherMatch.IsCrawl = MetroCheckBoxAddToCrawl.Checked
    End If
  End Sub

  Private Sub MetroCheckBoxAddToTable_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBoxAddToTable.CheckedChanged
    If _initializing Then Exit Sub
    If Not _otherMatch Is Nothing Then
      _otherMatch.IsTable = MetroCheckBoxAddToTable.Checked
    End If
  End Sub
#End Region

#Region "Controls"
  Private _initializing As Boolean = False

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.MetroComboBoxChannelLogo.Items.Clear()
    Me.MetroComboBoxChannelLogo.Items.Add("")
    For i As Integer = 1 To 10
      Me.MetroComboBoxChannelLogo.Items.Add("Logo " & i)
    Next

    Me.MetroComboBoxMatchStatus.Items.Clear()
    Me.MetroComboBoxMatchStatus.Items.Add("")
    Me.MetroComboBoxMatchStatus.Items.Add(OtherMatch.otherMatchStatus.HalfTime)
    Me.MetroComboBoxMatchStatus.Items.Add(OtherMatch.otherMatchStatus.FullTime)
    Me.MetroComboBoxMatchStatus.Items.Add(OtherMatch.otherMatchStatus.LatestResult)

  End Sub

  Private Sub UpdateControls()
    If _initializing Then Exit Sub
    _initializing = True

    Try
      If _otherMatch Is Nothing Then
        Me.MetroTabControlLineType.SelectedTab = TabPageBlank
        MetroTabControlLineType.Visible = False
        MetroTabControlLineType.SelectedIndex = OtherMatch.eOtherMatchLineType.Blank
        Me.MetroTextBoxTitle.Text = ""
        Me.MetroComboBoxMatch.Text = ""
        Me.MetroTextBoxScoreHome.Text = ""
        Me.MetroTextBoxScoreAway.Text = ""
      Else
        MetroTabControlLineType.Visible = True
        Dim tabPage As TabPage = Nothing
        Select Case _otherMatch.LineType
          Case OtherMatch.eOtherMatchLineType.Blank
            tabPage = TabPageBlank
          Case OtherMatch.eOtherMatchLineType.Result
            tabPage = TabPageMatch
          Case OtherMatch.eOtherMatchLineType.Title
            tabPage = TabPageTitle
        End Select
        If tabPage.Name <> Me.MetroTabControlLineType.SelectedTab.Name Then Me.MetroTabControlLineType.SelectedTab = tabPage
        Me.MetroCheckBoxAddToCrawl.Checked = _otherMatch.IsCrawl
        Me.MetroCheckBoxAddToTable.Checked = _otherMatch.IsTable
        MetroTabControlLineType.SelectedIndex = CInt(_otherMatch.LineType)
        Me.MetroTextBoxTitle.Text = _otherMatch.MatchTitle
        If _otherMatch.Match Is Nothing Then
          Me.MetroComboBoxMatch.Text = ""
          Me.MetroTextBoxScoreHome.Text = ""
          Me.MetroTextBoxScoreAway.Text = ""
          Me.MetroComboBoxChannelLogo.Text = ""
          Me.MetroComboBoxMatchStatus.Text = ""
        Else
          Me.MetroComboBoxMatch.Text = _otherMatch.Match.ToString
          Me.MetroTextBoxScoreHome.Text = _otherMatch.HomeScore
          Me.MetroTextBoxScoreAway.Text = _otherMatch.AwayScore

          If _otherMatch.LogoChannel = 0 Then
            Me.MetroComboBoxChannelLogo.Text = ""
          Else
            Me.MetroComboBoxChannelLogo.Text = "Logo " & _otherMatch.LogoChannel
          End If
          Select Case _otherMatch.MatchStatus
            Case OtherMatch.otherMatchStatus.Idle
              Me.MetroComboBoxMatchStatus.Text = ""
            Case Else
              Me.MetroComboBoxMatchStatus.Text = _otherMatch.MatchStatus.ToString
          End Select
          For index As Integer = 0 To Me.MetroComboBoxMatch.Items.Count - 1
            Dim obj As Object = Me.MetroComboBoxMatch.Items(index)
            If obj.GetType().ToString = "MatchInfo.Match" Then
              Dim aux As Match = Me.MetroComboBoxMatch.Items(index)
              If aux.match_id = _otherMatch.Match.match_id Then
                Me.MetroComboBoxMatch.SelectedItem = Me.MetroComboBoxMatch.Items(index)
              End If
            End If
          Next
        End If
      End If
      TableLayoutPanelCheckboxes.Visible = MetroTabControlLineType.Visible
    Catch ex As Exception
      WriteToErrorLog (ex)
    End Try
    _initializing = False
  End Sub

  Private Sub _otherMatch_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles _otherMatch.PropertyChanged
    UpdateControls()
  End Sub

  Private Sub MetroTabControlLineType_TabIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControlLineType.TabIndexChanged
    Try
      If _otherMatch Is Nothing Then Exit Sub
      Select Case MetroTabControlLineType.SelectedIndex
        Case 0
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Blank
        Case 1
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Result
        Case 2
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Title
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroTabControlLineType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControlLineType.SelectedIndexChanged
    Try
      If _initializing Then Exit Sub
      If _otherMatch Is Nothing Then Exit Sub
      Select Case MetroTabControlLineType.SelectedIndex
        Case 0
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Blank
        Case 1
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Result
        Case 2
          _otherMatch.LineType = OtherMatch.eOtherMatchLineType.Title
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroComboBoxMatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBoxMatch.SelectedIndexChanged
    Try
      If Not _otherMatch Is Nothing Then
        If MetroComboBoxMatch.Text = "" Then
          _otherMatch.Match = Nothing
        Else
          _otherMatch.Match = CType(MetroComboBoxMatch.SelectedItem, Match)
        End If
        If _otherMatch.Match Is Nothing Then
          Me.MetroTextBoxScoreHome.Text = ""
          Me.MetroTextBoxScoreAway.Text = ""
        Else
          Me.MetroTextBoxScoreHome.Text = _otherMatch.Match.home_goals
          Me.MetroTextBoxScoreAway.Text = _otherMatch.Match.away_goals
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroTextBoxTitle_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBoxTitle.TextChanged
    Try
      If Not _otherMatch Is Nothing Then
        _otherMatch.MatchTitle = MetroTextBoxTitle.Text
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroTextBoxScoreHome_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBoxScoreHome.TextChanged
    If _initializing Then Exit Sub
    Try
      If Not _otherMatch Is Nothing Then
        _otherMatch.HomeScore = MetroTextBoxScoreHome.Text
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroTextBoxScoreAway_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBoxScoreAway.TextChanged
    If _initializing Then Exit Sub
    Try
      If Not _otherMatch Is Nothing Then
        _otherMatch.AwayScore = MetroTextBoxScoreAway.Text
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroComboBoxChannelLogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBoxChannelLogo.SelectedIndexChanged
    Try
      If Not _otherMatch Is Nothing Then
        _otherMatch.LogoChannel = Me.MetroComboBoxChannelLogo.SelectedIndex
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroComboBoxMatchStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBoxMatchStatus.SelectedIndexChanged
    Try
      If Not _otherMatch Is Nothing Then
        Select Case Me.MetroComboBoxMatchStatus.Text
          Case OtherMatch.otherMatchStatus.HalfTime.ToString
            _otherMatch.MatchStatus = OtherMatch.otherMatchStatus.HalfTime
          Case OtherMatch.otherMatchStatus.FullTime.ToString
            _otherMatch.MatchStatus = OtherMatch.otherMatchStatus.FullTime
          Case OtherMatch.otherMatchStatus.LatestResult.ToString
            _otherMatch.MatchStatus = OtherMatch.otherMatchStatus.LatestResult
          Case Else
            _otherMatch.MatchStatus = OtherMatch.otherMatchStatus.Idle
        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

End Class
