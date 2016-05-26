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

  Private _init As Boolean = False

#Region "Graphic steps"
  Private Sub ShowNextGraphicSteps()
    Try

      With Me.MetroGridOptions
        .Rows.Clear()

        For Each gStep As GraphicStep In Me.GraphicStep.GraphicSteps
          Dim item As Integer = 0
          If gStep.IsSeparator Then
            item = .Rows.Add("-----")
          ElseIf gStep.IsTitleOnly Then
            item = .Rows.Add(gStep.Name & "---")
          Else
            item = .Rows.Add(gStep.UID, gStep.Name)
          End If
          .Rows(item).Selected = False
        Next
        .ClearSelection()
      End With
      _init = True
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
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
#End Region


End Class
