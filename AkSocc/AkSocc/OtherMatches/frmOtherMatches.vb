Imports MatchInfo

Public Class frmMatchDay
#Region "Other matches"
  Private _matchDay As MatchDay
  Public Property OtherMatchas As MatchDay
    Get
      Return _matchDay
    End Get
    Set(value As MatchDay)
      _matchDay = value
    End Set
  End Property
#End Region

  Private _matchDays As OtherMatchDays
  Private _selectedMatchDay As MatchDay = Nothing
  Private _controls As New List(Of UCOtherMatch)

  Private _competition As Competition
  Public Property Competition As Competition
    Get
      Return _competition
    End Get
    Set(value As Competition)
      _competition = value

      For Each ctl As UCOtherMatch In _controls
        ctl.Competition = Me.Competition
      Next
    End Set
  End Property


  Private Sub frmMatchDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
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

      For Each ctl As UCOtherMatch In _controls
        AddHandler ctl.MoveUp, AddressOf Me.UCOtherMatch_MoveUp
        AddHandler ctl.MoveDown, AddressOf Me.UCOtherMatch_MoveDown
        AddHandler ctl.Delete, AddressOf Me.UCOtherMatch_Delete
        AddHandler ctl.AddNew, AddressOf Me.UCOtherMatch_AddNew
        ctl.Competition = Me.Competition
      Next
    Catch ex As Exception

    End Try
    _matchDays = New OtherMatchDays
    DesserializeObjectFromFile(My.Settings.OtherMatchesPath, _matchDays)
    ShowMatchDays()
  End Sub

  Public Sub ShowMatchDays()
    Try
      With Me.MetroGridMatchDay
        .Rows.Clear()
        For Each day As MatchDay In _matchDays
          Dim itm As Integer = .Rows.Add(day.MatchDayID, day.MatchDayName)

        Next
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub NewMatchDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMatchDayToolStripMenuItem.Click
    Try
      Dim newMatchDay As MatchDay = New MatchDay("New item")
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})
      newMatchDay.Add(New OtherMatch() With {.IsCrawl = True, .MatchStatus = OtherMatch.otherMatchStatus.HalfTime})

      _matchDays.Add(newMatchDay)

      ShowMatchDays()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub DeleteMatchDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMatchDayToolStripMenuItem.Click
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridMatchDay_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridMatchDay.SelectionChanged
    Try
      Dim id As String = MetroGridMatchDay.SelectedRows(0).Cells(Column1.Index).Value
      _selectedMatchDay = _matchDays.GetMatchDay(id)
      MostrarMatchDay()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "MatchDay"

  Private Sub MostrarMatchDay()
    Try
      Me.TableLayoutPanelUCOtherMatches.SuspendLayout()
      'Me.TableLayoutPanelUCOtherMatches.Visible = False
      Try
        Dim maxItems As Integer = Math.Min(_controls.Count, _selectedMatchDay.OtherMatches.Count)
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
      Catch ex As Exception

      End Try
      Me.TableLayoutPanelUCOtherMatches.ResumeLayout()
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

    Try
      If e.ColumnIndex = ColumnDescription.Index Then
        Dim matchDay As MatchDay = _matchDays.Item(e.RowIndex)
        matchDay.MatchDayName = MetroGridMatchDay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
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
      SerializeObjectToFile(My.Settings.OtherMatchesPath, _matchDays)
      Me.DialogResult = DialogResult.OK
      Me.Close()
    Catch ex As Exception

      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Try
      Me.DialogResult = DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
End Class