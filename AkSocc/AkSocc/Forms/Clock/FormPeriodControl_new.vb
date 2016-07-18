Imports MatchInfo

Public Class FormPeriodControl_new

  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
      InitPeriod(_match, 1)
    End Set
  End Property

  Public Sub InitPeriod(match As MatchInfo.Match, part As Integer)
    Try
      _match = match
      Me.UcPeriod1.InitPeriod(_match, 1)
      Me.UcPeriod2.InitPeriod(_match, 2)
      Me.UcPeriod3.InitPeriod(_match, 3)
      Me.UcPeriod4.InitPeriod(_match, 4)

      PopulateGrid()
    Catch ex As Exception

    End Try
  End Sub

  Public Sub PopulateGrid()
    Try
      With Me.MetroGridPeriods
        .Rows.Clear()
        Dim itemIndex As Integer
        itemIndex = .Rows.Add("Reset")
        .Rows(itemIndex).Cells(ColumnType.Index).Value = "RESET"
        .Rows(itemIndex).Cells(ColumnID.Index).Value = "0"
        .Rows(itemIndex).Cells(ColumnText.Index).Value = "Reset"

        For i As Integer = 0 To _match.MatchPeriods.Count - 1

          itemIndex = .Rows.Add("separator")
          .Rows(itemIndex).Cells(ColumnText.Index).Value = "---------"
          .Rows(itemIndex).Frozen = True

          itemIndex = .Rows.Add("START:" & i)
          .Rows(itemIndex).Cells(ColumnType.Index).Value = "START"
          .Rows(itemIndex).Cells(ColumnID.Index).Value = CStr(i)
          .Rows(itemIndex).Cells(ColumnText.Index).Value = _match.MatchPeriods(i).Nom & " (start clock)"
          itemIndex = .Rows.Add("STOP:" & i)
          .Rows(itemIndex).Cells(ColumnType.Index).Value = "STOP"
          .Rows(itemIndex).Cells(ColumnID.Index).Value = CStr(i)
          .Rows(itemIndex).Cells(ColumnText.Index).Value = _match.MatchPeriods(i).Nom & " (stop clock)"
        Next
        itemIndex = .Rows.Add("Overwrite clock")
        .Rows(itemIndex).Cells(ColumnType.Index).Value = "OVERWRITE"
        .Rows(itemIndex).Cells(ColumnID.Index).Value = "0"
        .Rows(itemIndex).Cells(ColumnText.Index).Value = "Overwrite clock"
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub FormPeriodControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub MetroButtonResetMatch_Click(sender As Object, e As EventArgs) Handles MetroButtonResetMatch.Click
    ResetMatch()
  End Sub

  Private Sub MetroButtonOverwriteClock_Click(sender As Object, e As EventArgs) Handles MetroButtonOverwriteClock.Click
    OverWriteClock()
  End Sub

  Private Sub ResetMatch()

  End Sub

  Private Sub OverWriteClock()
    Dim dlg As New FormOvewriteClock()
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub
      dlg.Minutes = _match.MatchPeriods.ActivePeriod.PlayingTime \ 60
      dlg.Seconds = _match.MatchPeriods.ActivePeriod.PlayingTime Mod 60
      If dlg.ShowDialog(Me) Then
        Dim newTime As Integer = dlg.Minutes * 60 + dlg.Seconds

        _match.MatchPeriods.SetPlayingTime(newTime)

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "Grid"
  Private _selectedAction As String = ""
  Private _selectedIndex As Integer = 0

  Private Sub MetroGridPeriods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridPeriods.CellClick
    Try
      Debug.Print("Clock control " & Me.MetroGridPeriods.Rows(e.RowIndex).Cells(ColumnID.Index).Value)
      ExecuteSelectedAction()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridPeriods_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MetroGridPeriods.PreviewKeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Return
          Debug.Print("Return key")
          ExecuteSelectedAction()
      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridPeriods_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridPeriods.SelectionChanged
    Try
      If Me.MetroGridPeriods.SelectedRows.Count = 0 Then
        _selectedAction = ""
        _selectedIndex = 0
      Else
        _selectedAction = Me.MetroGridPeriods.SelectedRows(0).Cells(ColumnType.Index).Value
        _selectedIndex = CInt(Me.MetroGridPeriods.SelectedRows(0).Cells(ColumnID.Index).Value)
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ExecuteSelectedAction()
    Try
      Select Case _selectedAction
        Case "RESET"
        Case "OVERWRITE"
          OverWriteClock()
        Case "START"
          _match.MatchPeriods.StartPeriod(_match.MatchPeriods(_selectedIndex), 0)
        Case "STOP"
          _match.MatchPeriods.EndPeriod(_match.MatchPeriods(_selectedIndex), 0)
      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private _updating As Boolean = False
  Private Sub _match_ActivePeriodStateChanged(period As Period) Handles _match.ActivePeriodStateChanged
    Try
      If _updating Then Exit Sub
      _updating = True
      If period Is Nothing Then
        Me.NumericUpDownMinutes.Enabled = False
        Me.NumericUpDownMinutes.Value = 0
      Else
        Me.NumericUpDownMinutes.Enabled = True
        Me.NumericUpDownMinutes.Value = period.ExtraTime
      End If

    Catch ex As Exception

    End Try
    _updating = False
  End Sub

  Private Sub NumericUpDownMinutes_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownMinutes.ValueChanged
    If _updating Then Exit Sub
    If _match Is Nothing Then Exit Sub
    If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub
    _match.MatchPeriods.UpdatePeriodExtraTime(_match.MatchPeriods.ActivePeriod, Me.NumericUpDownMinutes.Value)
  End Sub


#End Region

End Class