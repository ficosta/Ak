Imports MatchInfo

Public Class FormPeriodControl

  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
      PopulateGrid()
    End Set
  End Property

  Public Sub PopulateGrid()
    Try
      With Me.MetroGridPeriods
        .Rows.Clear()
        .MultiSelect = False
        Dim itemIndex As Integer

        itemIndex = .Rows.Add("Reset")
        .Rows(itemIndex).Cells(ColumnType.Index).Value = "RESET"
        .Rows(itemIndex).Cells(ColumnID.Index).Value = "0"
        .Rows(itemIndex).Cells(ColumnText.Index).Value = "Reset"

        Dim periodToStart As Integer = 0
        Dim start As Boolean = True
        If _match.MatchPeriods.ActivePeriod Is Nothing Then
          periodToStart = 0
          start = True
        Else
          periodToStart = Math.Max(_match.MatchPeriods.ActivePeriod.Part - 1, 0)
          start = Not _match.MatchPeriods.ActivePeriod.Activa
        End If
        Dim itemToSelect As Integer = 2

        For i As Integer = 0 To _match.MatchPeriods.Count - 1

          itemIndex = .Rows.Add("separator")
          .Rows(itemIndex).Cells(ColumnText.Index).Value = "___________"
          '.Rows(itemIndex).Frozen = True

          itemIndex = .Rows.Add("START:" & i)
          If Not _match.MatchPeriods.ActivePeriod Is Nothing AndAlso _match.MatchPeriods.ActivePeriod.Part = _match.MatchPeriods(i).Part - 1 And _match.MatchPeriods.ActivePeriod.Activa = False Then itemToSelect = itemIndex
          .Rows(itemIndex).Cells(ColumnType.Index).Value = "START"
          .Rows(itemIndex).Cells(ColumnID.Index).Value = CStr(i)
          .Rows(itemIndex).Cells(ColumnText.Index).Value = _match.MatchPeriods(i).Nom & " (start clock)"
          .Rows(itemIndex).Selected = (i = periodToStart And start)

          itemIndex = .Rows.Add("STOP:" & i)
          If Not _match.MatchPeriods.ActivePeriod Is Nothing AndAlso _match.MatchPeriods.ActivePeriod.Part = _match.MatchPeriods(i).Part And _match.MatchPeriods.ActivePeriod.Activa = True Then itemToSelect = itemIndex
          .Rows(itemIndex).Cells(ColumnType.Index).Value = "STOP"
          .Rows(itemIndex).Cells(ColumnID.Index).Value = CStr(i)
          .Rows(itemIndex).Cells(ColumnText.Index).Value = _match.MatchPeriods(i).Nom & " (stop clock)"
          .Rows(itemIndex).Selected = (i = periodToStart And Not start)

        Next
        itemIndex = .Rows.Add("separator")
        .Rows(itemIndex).Cells(ColumnText.Index).Value = "___________"
        .Rows(itemIndex).Frozen = True
        itemIndex = .Rows.Add("Overwrite clock")
        .Rows(itemIndex).Cells(ColumnType.Index).Value = "OVERWRITE"
        .Rows(itemIndex).Cells(ColumnID.Index).Value = "0"
        .Rows(itemIndex).Cells(ColumnText.Index).Value = "Overwrite clock"

        .ClearSelection()

        For row As Integer = 0 To .Rows.Count - 1
          Me.MetroGridPeriods.Rows(row).Selected = False
        Next

        Me.MetroGridPeriods.Rows(itemToSelect).Selected = True
      End With

    Catch ex As Exception

    End Try
  End Sub

  Private Sub FormPeriodControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub


  Private Sub ResetMatch()
    Try
      If _match Is Nothing Then Exit Sub

      If frmWaitForInput.ShowWaitDialog(Me, "Reset match data?", _match.Description, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub

      _match.Reset()
      Me.Close()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub OverWriteClock()
    Dim dlg As New FormOvewriteClock()
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub
      dlg.Minutes = _match.MatchPeriods.TempsJocWithOffset \ 60
      dlg.Seconds = _match.MatchPeriods.TempsJocWithOffset Mod 60
      If dlg.ShowDialog(Me) Then
        Dim newTime As Integer = dlg.Minutes * 60 + dlg.Seconds

        _match.MatchPeriods.SetPlayingTime(newTime)
        Me.Close()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#Region "Grid"
  Private _selectedAction As String = ""
  Private _selectedIndex As Integer = 0

  Private Sub MetroGridPeriods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridPeriods.CellClick
    Debug.Print("Clock control " & Me.MetroGridPeriods.Rows(e.RowIndex).Cells(ColumnID.Index).Value)
    Try
      Select Case _selectedAction ' Me.MetroGridPeriods.Rows(e.RowIndex).Cells(ColumnID.Index).Value
        Case "RESET"
       '   ResetMatch()
        Case "OVERWRITE"
          '  OverWriteClock()
      End Select

      ' AcceptOption()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridPeriods_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGridPeriods.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Return
          e.Handled = True
          AcceptOption()
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

  Private Function ExecuteSelectedAction() As Boolean
    Dim res As Boolean = False
    Try
      Select Case _selectedAction
        Case "RESET"
          ResetMatch()
          res = True
        Case "OVERWRITE"
          OverWriteClock()
          res = True
        Case "START"
          If frmWaitForInput.ShowWaitDialog(Me, "Are you sure you want to start the selected period?", "Start period", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            res = True
            _match.MatchPeriods.StartPeriod(_match.MatchPeriods(_selectedIndex), 0)
          Else
            res = False
          End If
        Case "STOP"
          If frmWaitForInput.ShowWaitDialog(Me, "Are you sure you want to stop the selected period?", "Stop period", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            res = True
            _match.MatchPeriods.EndPeriod(_match.MatchPeriods(_selectedIndex), 0)
          Else
            res = False
          End If
      End Select
    Catch ex As Exception

    End Try
    Return res
  End Function

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

  Private Sub AcceptOption()
    Try
      Dim res As Boolean
      res = ExecuteSelectedAction()
      If res Then Me.Close()
      Me.DialogResult = DialogResult.OK
    Catch ex As Exception

    End Try
  End Sub

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    AcceptOption()
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Me.Close()
  End Sub

  Private Sub FormPeriodControl_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    PopulateGrid()
  End Sub

#End Region

End Class