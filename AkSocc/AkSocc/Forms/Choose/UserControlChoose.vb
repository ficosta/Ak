Public Class UserControlChoose
  Private _graphicStep As GraphicStep = Nothing
  Public Property GraphicStep As GraphicStep
    Get
      Return _graphicStep
    End Get
    Set(value As GraphicStep)
      _graphicStep = value
      ShowNextGraphicSteps()
    End Set
  End Property

  Public Property Index As Integer = 0

  Public Event GraphicStepSelected(sender As UserControlChoose, gs As GraphicStep)
  Public Event JumpToNext(sender As UserControlChoose)
  Public Event JumpToPrevious(sender As UserControlChoose)

  Private _init As Boolean = False

#Region "Graphic steps"
  Private Sub ShowNextGraphicSteps()
    Try
      _init = False
      With Me.MetroGridOptions
        .Rows.Clear()

        If Not Me.GraphicStep Is Nothing AndAlso Not Me.GraphicStep.GraphicSteps Is Nothing Then
          For Each gSide As GraphicStep In Me.GraphicStep.GraphicSteps
            Dim item As Integer = 0
            If gSide.IsSeparator Then
              item = .Rows.Add("-----")
            ElseIf gSide.IsTitleOnly Then
              item = .Rows.Add(gSide.Name & "---")
            Else
              item = .Rows.Add(gSide.UID, gSide.Name)
            End If
            '.Rows(item).Visible = Not (gSide.IsSeparator Or gSide.IsTitleOnly)
            .Rows(item).Frozen = Not (gSide.IsSeparator Or gSide.IsTitleOnly)
            .Rows(item).Selected = False
          Next
        End If
        ' .ClearSelection()
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    _init = True
  End Sub

  Public Sub SelectFirst(Optional forceSelection As Boolean = False)
    Try
      _init = False
      For row As Integer = 0 To Me.MetroGridOptions.Rows.Count - 1
        Me.MetroGridOptions.Rows(row).Selected = False
      Next
      If Me.MetroGridOptions.Rows.Count > 0 Then
        Me.MetroGridOptions.Rows(0).Selected = True
      End If
      'Me.MetroGridOptions.Invalidate()
      Me.MetroGridOptions.Focus()
      If forceSelection Then
        Me.SelectItemAtrow(0)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    _init = True
  End Sub

  Private Sub MetroGridOptions_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridOptions.SelectionChanged
    SelectionChanged()
  End Sub

  Private Sub MetroGridOptions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridOptions.CellContentClick
    SelectionChanged()
  End Sub

  Private Sub SelectionChanged()
    If _init = False Then Exit Sub

    Dim gSide As GraphicStep = Nothing
    Try
      If MetroGridOptions.SelectedRows.Count > 0 Then

        gSide = Me.GraphicStep.GraphicSteps(MetroGridOptions.SelectedRows(0).Index)
        gSide.ParentGraphicStep.ChildGraphicStep = gSide
        RaiseEvent GraphicStepSelected(Me, gSide)

      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub SelectItemAtrow(row As Integer)
    Dim gSide As GraphicStep = Nothing
    Try
      Dim lastInit As Boolean = _init
      _init = False
      For i As Integer = 0 To MetroGridOptions.Rows.Count - 1
        '  MetroGridOptions.Rows(i).Selected = (i = row)
      Next
      _init = lastInit


      gSide = Me.GraphicStep.GraphicSteps(row)
      gSide.ParentGraphicStep.ChildGraphicStep = gSide
      RaiseEvent GraphicStepSelected(Me, gSide)


    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridOptions_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGridOptions.KeyDown
    Try
      If _init = False Then Exit Sub
      Select Case e.KeyCode
        Case Keys.Return
          e.Handled = True
          If MetroGridOptions.SelectedRows.Count > 0 Then

            'Dim gSide As GraphicStep = Nothing
            'gSide = Me.GraphicStep.GraphicSteps(MetroGridOptions.SelectedRows(0).Index)
            'gSide.ParentGraphicStep.ChildGraphicStep = gSide
            'RaiseEvent GraphicStepSelected(Me, gSide)
            RaiseEvent JumpToNext(Me)
          End If
        Case Keys.Escape
          Me.MetroGridOptions.ClearSelection()
          RaiseEvent JumpToPrevious(Me)
      End Select

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#End Region


End Class
