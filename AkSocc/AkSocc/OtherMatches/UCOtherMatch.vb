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
        Dim _matches As Matches = Matches.GetMatchesForCompetition(_competition.CompID)

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
  Private Sub UpdateControls()
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
        Select Case _otherMatch.LineType
          Case OtherMatch.eOtherMatchLineType.Blank
            Me.MetroTabControlLineType.SelectedTab = TabPageBlank
          Case OtherMatch.eOtherMatchLineType.Result
            Me.MetroTabControlLineType.SelectedTab = TabPageTitle
          Case OtherMatch.eOtherMatchLineType.Title
            Me.MetroTabControlLineType.SelectedTab = TabPageMatch
        End Select
        Me.MetroCheckBoxAddToCrawl.Checked = _otherMatch.IsCrawl
        Me.MetroCheckBoxAddToTable.Checked = _otherMatch.IsTable
        MetroTabControlLineType.SelectedIndex = CInt(_otherMatch.LineType)
        Me.MetroTextBoxTitle.Text = _otherMatch.MatchTitle
        Me.MetroTextBoxScoreHome.Text = _otherMatch.HomeScore
        Me.MetroTextBoxScoreAway.Text = _otherMatch.AwayScore
        If _otherMatch.Match Is Nothing Then
          Me.MetroComboBoxMatch.Text = ""
        Else
          Me.MetroComboBoxMatch.Text = _otherMatch.Match.Description
        End If
      End If
      TableLayoutPanelCheckboxes.Visible = MetroTabControlLineType.Visible
    Catch ex As Exception

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
        _otherMatch.Match = CType(MetroComboBoxMatch.SelectedItem, Match)
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
    Try
      If Not _otherMatch Is Nothing Then
        _otherMatch.HomeScore = MetroTextBoxScoreHome.Text
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroTextBoxScoreAway_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBoxScoreAway.TextChanged
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
        _otherMatch.MatchStatus = Me.MetroComboBoxMatchStatus.SelectedIndex
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region

End Class
