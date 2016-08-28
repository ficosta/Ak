Imports MatchInfo

Public Class frmMatchDay
#Region "Other matches"
  Private _matchDay As OtherMatchDay
  Public Property MatchDay As OtherMatchDay
    Get
      Return _matchDay
    End Get
    Set(value As OtherMatchDay)
      _matchDay = value
    End Set
  End Property

  Private _competition As Competition
  Public Property Competition As Competition
    Get
      Return _competition
    End Get
    Set(value As Competition)
      _competition = value

      For Each ctl As UCOtherMatch In _controls
        ctl.Competition = _competition
      Next

      Me.ComboBoxCompetitions.SelectedItem = _competition
    End Set
  End Property

  Private _competitions As Competitions
#End Region


  Private _otherMatchDays As OtherMatchDays
  Public Property OtherMatchDays As OtherMatchDays
    Get
      Return _otherMatchDays
    End Get
    Set(value As OtherMatchDays)
      _otherMatchDays = value
    End Set
  End Property

  Private _selectedMatchDay As OtherMatchDay = Nothing
  Private _controls As New List(Of UCOtherMatch)
  Private _initializing As Boolean = False

  Private Sub frmMatchDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      _initializing = True
      _controls.Clear()
      _controls.Add(Me.UcOtherMatch1)
      _controls.Add(Me.UcOtherMatch2)
      _controls.Add(Me.UcOtherMatch3)
      _controls.Add(Me.UcOtherMatch4)
      _controls.Add(Me.UcOtherMatch5)
      _controls.Add(Me.UcOtherMatch6)
      _controls.Add(Me.UcOtherMatch7)
      _controls.Add(Me.UcOtherMatch8)
      _controls.Add(Me.UcOtherMatch9)

      _competitions = New Competitions
      _competitions.GetFromDB("")
      For Each comp As Competition In _competitions
        Me.ComboBoxCompetitions.Items.Add(comp)
      Next

      Dim _matches As Matches = Nothing
      If Not _competition Is Nothing Then
        _matches = Matches.GetMatchesForCompetition(_competition.CompID)
        Me.ComboBoxCompetitions.SelectedIndex = Me.ComboBoxCompetitions.FindStringExact(_competition.ToString)
      End If

      For Each ctl As UCOtherMatch In _controls
        AddHandler ctl.MoveUp, AddressOf Me.UCOtherMatch_MoveUp
        AddHandler ctl.MoveDown, AddressOf Me.UCOtherMatch_MoveDown
        AddHandler ctl.Delete, AddressOf Me.UCOtherMatch_Delete
        AddHandler ctl.AddNew, AddressOf Me.UCOtherMatch_AddNew
        ctl.Matches = _matches
      Next
    Catch ex As Exception

    End Try
    _initializing = False
    _otherMatchDays = New OtherMatchDays
    ShowMatchDays()
  End Sub

  Public Sub ShowMatchDays()
    Try
      With Me.MetroGridMatchDay
        _initializing = True
        .Rows.Clear()
        _selectedMatchDay = Nothing
        For Each day As OtherMatchDay In _otherMatchDays
          If day.CompetitionID = _competition.CompID Then
            Dim itm As Integer = .Rows.Add(day.MatchDayID, day.MatchDayName)
            _selectedMatchDay = day
          End If
        Next
        If .Rows.Count > 0 Then
          .Rows(0).Selected = True
          For row As Integer = 1 To .Rows.Count - 1
            .Rows(row).Selected = False
          Next
        End If
        MostrarMatchDay()
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    _initializing = False
  End Sub

  Private Sub NewMatchDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMatchDayToolStripMenuItem.Click
    Try
      Dim newMatchDay As OtherMatchDay = New OtherMatchDay("New item")
      If Not _competition Is Nothing Then newMatchDay.CompetitionID = _competition.CompID
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .IsTable = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})

      _otherMatchDays.Add(newMatchDay)

      ShowMatchDays()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub DeleteMatchDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMatchDayToolStripMenuItem.Click
    Try
      If _selectedMatchDay Is Nothing Then Exit Sub
      If MsgBox("Delete match day " & _selectedMatchDay.Name & "?", MsgBoxStyle.YesNo, "Other match scores") = MsgBoxResult.Yes Then
        _otherMatchDays.Remove(_selectedMatchDay)
      End If
      _selectedMatchDay = Nothing
      ShowMatchDays()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridMatchDay_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridMatchDay.SelectionChanged
    If _initializing Then Exit Sub
    Try
      Dim id As String = MetroGridMatchDay.SelectedRows(0).Cells(Column1.Index).Value
      _selectedMatchDay = _otherMatchDays.GetMatchDay(id)
      MostrarMatchDay()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "OtherMatchDay"

  Private Sub MostrarMatchDay()
    Try
      ' Exit Sub
      'Me.TableLayoutPanelUCOtherMatches.SuspendLayout()
      'Me.TableLayoutPanelUCOtherMatches.Visible = False
      Try
        Dim maxItems As Integer

        If Not _selectedMatchDay Is Nothing Then
          maxItems = Math.Min(_controls.Count, _selectedMatchDay.OtherMatches.Count)
          For index As Integer = 0 To maxItems - 1
            _controls(index).OtherMatchInfo = _selectedMatchDay(index)
            _controls(index).ArrowUpVisible = (index > 0)
            _controls(index).ArrowDownVisible = (index < maxItems - 1)
            _controls(index).ButtonActionEnum = UCOtherMatch.eButtonAction.Delete
          Next
          For index As Integer = maxItems To _controls.Count - 1
            _controls(index).OtherMatchInfo = Nothing
            _controls(index).ArrowUpVisible = False
            _controls(index).ArrowDownVisible = False
            _controls(index).ButtonActionEnum = IIf(index = maxItems, UCOtherMatch.eButtonAction.AddNew, UCOtherMatch.eButtonAction.None)
          Next
        Else
          For index As Integer = 0 To _controls.Count - 1
            _controls(index).OtherMatchInfo = Nothing
            _controls(index).ArrowUpVisible = False
            _controls(index).ArrowDownVisible = False
            _controls(index).ButtonActionEnum = IIf(index = maxItems, UCOtherMatch.eButtonAction.AddNew, UCOtherMatch.eButtonAction.None)
          Next
        End If


      Catch ex As Exception

      End Try
      '  Me.TableLayoutPanelUCOtherMatches.ResumeLayout()
      'Me.TableLayoutPanelUCOtherMatches.Visible = True
    Catch ex As Exception

    End Try
  End Sub

  Private Function InsertPagina(ByRef CiPagina As OtherMatch, ByVal CiTableLayoutPanel As TableLayoutPanel) As UCOtherMatch
    Dim CControl As UCOtherMatch = Nothing
    Try
      For Each CAux As UCOtherMatch In CiTableLayoutPanel.Controls
        If (Not CAux.OtherMatchInfo Is Nothing AndAlso CAux.OtherMatchInfo.OtherMatchID = CiPagina.OtherMatchID) Or (CAux.OtherMatchInfo Is Nothing And CiPagina Is Nothing) Then
          CControl = CAux
        End If
      Next
      If CControl Is Nothing Then
        CControl = New UCOtherMatch
        CControl.OtherMatchInfo = CiPagina
        CiTableLayoutPanel.Controls.Add(CControl)
        CiTableLayoutPanel.RowStyles(CiTableLayoutPanel.Controls.Count - 1).SizeType = SizeType.AutoSize
        CControl.Margin = New Padding(0)
        CControl.Dock = DockStyle.Fill
        AddHandler CControl.Delete, AddressOf Me.UCOtherMatch_Delete
        AddHandler CControl.MoveUp, AddressOf Me.UCOtherMatch_MoveUp
        AddHandler CControl.MoveDown, AddressOf Me.UCOtherMatch_MoveDown

        CControl.ArrowUpVisible = False
        CControl.ArrowDownVisible = False
        If Not CiPagina Is Nothing Then
          If _controls.Count > 0 Then
            If Not _controls.Last.OtherMatchInfo Is Nothing Then
              CControl.ArrowUpVisible = True
              _controls.Last.ArrowDownVisible = True
            Else
              '_controls.Last.ArrowDownVisible = True

            End If
          End If
        End If
        _controls.Add(CControl)
        'AddHandler CControl.ValueChanged, AddressOf Me.ValueChanged
      End If
      CControl.OtherMatchInfo = CiPagina

    Catch ex As Exception

    End Try
    Return CControl

  End Function

  Public Sub UCOtherMatch_MoveUp(sender As UCOtherMatch)
    Try
      SwapPagines(sender.OtherMatchInfo.MatchIndex, sender.OtherMatchInfo.MatchIndex - 1)
    Catch ex As Exception
    End Try
  End Sub
  Public Sub UCOtherMatch_MoveDown(sender As UCOtherMatch)
    Try
      SwapPagines(sender.OtherMatchInfo.MatchIndex, sender.OtherMatchInfo.MatchIndex + 1)
    Catch ex As Exception
    End Try
  End Sub
  Public Sub UCOtherMatch_Delete(sender As UCOtherMatch)
    Try
      _selectedMatchDay.Remove(sender.OtherMatchInfo)
      MostrarMatchDay()
    Catch ex As Exception
    End Try
  End Sub

  Public Sub UCOtherMatch_AddNew(sender As UCOtherMatch)
    Try
      _selectedMatchDay.Add(New OtherMatch())
      MostrarMatchDay()
    Catch ex As Exception

    End Try
  End Sub


  Private Sub SwapPagines(ByVal index1 As Integer, ByVal index2 As Integer)
    Try
      If index1 >= 0 And index2 >= 0 And index1 < _selectedMatchDay.OtherMatches.Count And index2 < _selectedMatchDay.OtherMatches.Count And index1 <> index2 Then
        Dim aux As OtherMatch = _selectedMatchDay(index1)
        _selectedMatchDay(index1) = _selectedMatchDay(index2)
        _selectedMatchDay(index2) = aux
      End If
      _selectedMatchDay.UpdateIndexes()
      MostrarMatchDay()
    Catch ex As Exception

    End Try
  End Sub
#End Region

  Private Sub MetroGridMatchDay_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridMatchDay.CellValidated
    If _initializing Then Exit Sub
    If _selectedMatchDay Is Nothing Then Exit Sub
    Try
      If e.ColumnIndex = ColumnDescription.Index Then
        _selectedMatchDay.MatchDayName = MetroGridMatchDay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        _selectedMatchDay.Name = MetroGridMatchDay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Debug.Print("match day text changed " & _selectedMatchDay.MatchDayID & " " & _selectedMatchDay.Name)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridMatchDay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridMatchDay.CellContentClick
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    Try
      Me.Cursor = Cursors.WaitCursor
      ' SerializeObjectToFile(AppSettings.Instance.OtherMatchesPath, _otherMatchDays)
      _otherMatchDays.SaveXML()

      If MsgBox("Update data base?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        _otherMatchDays.SaveResultsToDataBase()
      End If

      Me.DialogResult = DialogResult.OK
      Me.Close()

    Catch ex As Exception

      WriteToErrorLog(ex)
    End Try
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Try
      Me.DialogResult = DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ComboBoxCompetitions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompetitions.SelectedIndexChanged
    If _initializing Then Exit Sub
    Try
      _competition = Me.ComboBoxCompetitions.SelectedItem
      Me.ShowMatchDays()
    Catch ex As Exception

    End Try
  End Sub
End Class