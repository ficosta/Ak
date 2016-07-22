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
          For Each gStep As GraphicStep In Me.GraphicStep.GraphicSteps
            Dim item As Integer = 0
            If gStep.IsSeparator Then
              item = .Rows.Add("-----")
            ElseIf gStep.IsTitleOnly Then
              item = .Rows.Add(gStep.Name & "---")
            Else
              item = .Rows.Add(gStep.UID, gStep.Name)
            End If
            '.Rows(item).Visible = Not (gStep.IsSeparator Or gStep.IsTitleOnly)
            .Rows(item).Frozen = Not (gStep.IsSeparator Or gStep.IsTitleOnly)
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
    If _init = False Then Exit Sub

    Dim gStep As GraphicStep = Nothing
    Try
      If MetroGridOptions.SelectedRows.Count > 0 Then

        gStep = Me.GraphicStep.GraphicSteps(MetroGridOptions.SelectedRows(0).Index)
        gStep.ParentGraphicStep.ChildGraphicStep = gStep
        RaiseEvent GraphicStepSelected(Me, gStep)

      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub SelectItemAtrow(row As Integer)
    Dim gStep As GraphicStep = Nothing
    Try
      Dim lastInit As Boolean = _init
      _init = False
      For i As Integer = 0 To MetroGridOptions.Rows.Count - 1
        '  MetroGridOptions.Rows(i).Selected = (i = row)
      Next
      _init = lastInit


      gStep = Me.GraphicStep.GraphicSteps(row)
      gStep.ParentGraphicStep.ChildGraphicStep = gStep
      RaiseEvent GraphicStepSelected(Me, gStep)


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

            'Dim gStep As GraphicStep = Nothing
            'gStep = Me.GraphicStep.GraphicSteps(MetroGridOptions.SelectedRows(0).Index)
            'gStep.ParentGraphicStep.ChildGraphicStep = gStep
            'RaiseEvent GraphicStepSelected(Me, gStep)
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
