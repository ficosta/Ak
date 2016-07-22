Public Class frmLoadScenes
  Public LlistaEscenes As New List(Of String)
  Public WithEvents CPuMultiEngine As ControlVIZ.MultiEngine
  Private nPiEscena() As Integer
  Private nPiID() As Integer

  Private nPiLastRow As Integer = 0

  Private Enum eColsEscenes
    Nom
    Estat
    Total
  End Enum

  Private Enum eFixedRowsEscenes
    Host
    Allocated
    Used
    Total
  End Enum

  Private Sub frmLoadScenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    IniciarControls()
  End Sub

  Private Sub IniciarControls()
    Dim CStyle As C1.Win.C1FlexGrid.CellStyle
    Try
      With Me.C1FlexGridEscenes
        .Rows.Fixed = eFixedRowsEscenes.Total
        .Rows.Count = .Rows.Fixed
        .Cols.Count = eColsEscenes.Estat + Me.CPuMultiEngine.LlistaEngines.Count
        .Cols.Fixed = 0
        .ExtendLastCol = True

        CStyle = .Styles.Add("Error", .Styles.Item("Normal"))
        CStyle.BackColor = Drawing.Color.Red
        CStyle = .Styles.Add("Idle", .Styles.Item("Normal"))
        CStyle.BackColor = Drawing.Color.LightYellow
        CStyle = .Styles.Add("Loading", .Styles.Item("Normal"))
        CStyle.BackColor = Drawing.Color.Orange
        CStyle = .Styles.Add("Activating", .Styles.Item("Normal"))
        CStyle.BackColor = Drawing.Color.Orange
        CStyle = .Styles.Add("Loaded", .Styles.Item("Normal"))
        CStyle.BackColor = Drawing.Color.LightGreen

        '.SetData(0, eColsEscenes.Nom, "Escena")
        .SetData(eFixedRowsEscenes.Allocated, eColsEscenes.Nom, "Reservada")
        .SetData(eFixedRowsEscenes.Used, eColsEscenes.Nom, "Usada")
        For nEngines As Integer = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
          .SetData(eFixedRowsEscenes.Host, eColsEscenes.Estat + nEngines, Me.CPuMultiEngine.LlistaEngines(nEngines).CControlViz.Config.TCPHost)
        Next
        .AutoSizeCols(0, .Cols.Count - 1, 5)
      End With

      ReDim nPiID(0 To Me.CPuMultiEngine.LlistaEngines.Count - 1)
      ReDim nPiEscena(0 To Me.CPuMultiEngine.LlistaEngines.Count - 1)

      MostrarEscenes()



      For nEngines As Integer = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
        With Me.CPuMultiEngine.LlistaEngines(nEngines)
          Select Case .CControlViz.SocketStateTCP
            Case eSocketState.Connected
              CarregarEscena(0, nEngines)
            Case eSocketState.Connecting
            Case eSocketState.Disconnected
            Case eSocketState.ErrorState
          End Select
        End With

      Next

    Catch ex As Exception

    End Try
  End Sub


  Private Sub MostrarEscenes()
    Dim CStyle As C1.Win.C1FlexGrid.CellStyle
    Dim CRange As C1.Win.C1FlexGrid.CellRange
    Try

      With Me.C1FlexGridEscenes
        .Rows.Count = .Rows.Fixed + Me.LlistaEscenes.Count

        CStyle = .Styles.Item("Idle")
        For nIndex As Integer = 0 To Me.LlistaEscenes.Count - 1
          .SetData(.Rows.Fixed + nIndex, eColsEscenes.Nom, Me.LlistaEscenes(nIndex))
          For nEngines As Integer = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
            .SetData(.Rows.Fixed + nIndex, eColsEscenes.Estat + nEngines, "Idle")
            CRange = .GetCellRange(.Rows.Fixed + nIndex, eColsEscenes.Estat)
            CRange.Style = CStyle
          Next
        Next
        .AutoSizeCols(0, .Cols.Count - 1, 5)
      End With
      If Me.CPuMultiEngine.LlistaEngines.Count > 0 Then
        Me.Label1.Text = Me.CPuMultiEngine.LlistaEngines(0).CControlViz.Config.SceneBasePath
      Else
        Me.Label1.Text = ""
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub CarregarEscena(ByVal niIndex As Integer, ByVal niEngine As Integer)
    Dim CStyle As C1.Win.C1FlexGrid.CellStyle
    Dim CRange As C1.Win.C1FlexGrid.CellRange
    Dim bDone As Boolean
    Try
      Me.nPiEscena(niEngine) = niIndex
      If Me.nPiEscena(niEngine) < Me.LlistaEscenes.Count Then
        Me.CPuMultiEngine.LlistaEngines(niEngine).CControlViz.GetMemoryStats()
        nPiID(niEngine) = Me.CPuMultiEngine.LlistaEngines(niEngine).CControlViz.LoadScene(Me.CPuMultiEngine.LlistaEngines(niEngine).CControlViz.Config.SceneBasePath & Me.LlistaEscenes(Me.nPiEscena(niEngine)))
        If Me.Visible = True Then
          With Me.C1FlexGridEscenes
            CStyle = .Styles("Loading")
            CRange = .GetCellRange(Me.nPiEscena(niEngine) + .Rows.Fixed, eColsEscenes.Estat + niEngine)
            CRange.Style = CStyle
            .SetData(Me.nPiEscena(niEngine) + .Rows.Fixed, eColsEscenes.Estat + niEngine, "Loading")
            .AutoSizeCols(0, .Cols.Count - 1, 5)
          End With
        End If
      Else
        Me.CPuMultiEngine.LlistaEngines(niEngine).CControlViz.ActivateScene("")
        bDone = True
        For nEngines As Integer = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
          If nPiEscena(nEngines) < Me.LlistaEscenes.Count Then
            bDone = False
          End If
        Next
        If Me.CheckBoxTancarAutomaticament.Checked And bDone Then
          Me.Close()
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

  Public Sub UpdateInfo(ByVal nEngine As Integer, ByVal diTotal As Double, ByVal diPixel As Double, ByVal diAllocated As Double, ByVal diSize As Double)
    Try
      If Me.Visible = False Then Exit Sub
      If nEngine = 0 Then

        'només mostrem el primer
        Me.LabelAllocated.Text = FormatSize(diAllocated)
        Me.LabelTotal.Text = FormatSize(diTotal)
        Me.LabelUsed.Text = FormatSize(diSize)

        If diTotal > 0 Then
          Me.LabelPercUsed.Text = Format(100 * diSize / diTotal, "0") & "%"
          If 100 * diSize / diTotal < 100 Then
            Me.ProgressBarTotal.Value = 100 * diSize / diTotal
          Else
            Me.ProgressBarTotal.Value = 100
          End If

          Me.LabelPercAllocated.Text = Format(100 * diAllocated / diTotal, "0") & "%"
          If 100 * diAllocated / diTotal < 100 Then
            Me.ProgressBarAllocated.Value = 100 * diAllocated / diTotal
          Else
            Me.ProgressBarAllocated.Value = 100
          End If
        Else
          Me.LabelPercUsed.Text = "0%"
          Me.ProgressBarTotal.Value = 0
        End If

        If diAllocated > diTotal Then
          Me.LabelAllocated.ForeColor = System.Drawing.Color.Red
        Else
          Me.LabelAllocated.ForeColor = System.Drawing.Color.Black
        End If
        If diSize > diTotal Then
          Me.LabelUsed.ForeColor = System.Drawing.Color.Red
        Else
          Me.LabelUsed.ForeColor = System.Drawing.Color.Black
        End If
        Me.LabelPercUsed.ForeColor = Me.LabelUsed.ForeColor
      End If

      With Me.C1FlexGridEscenes
        .SetData(Me.nPiLastRow, eColsEscenes.Estat + nEngine, "Loaded " & Me.LabelAllocated.Text)
        .SetData(eFixedRowsEscenes.Allocated, eColsEscenes.Estat + nEngine, FormatSize(diAllocated) & "/" & FormatSize(diTotal))
        .SetData(eFixedRowsEscenes.Used, eColsEscenes.Estat + nEngine, FormatSize(diSize) & "/" & FormatSize(diTotal))
      End With

    Catch ex As Exception

    End Try

  End Sub

  Private Function FormatSize(ByVal diSize As Double) As String
    Dim sAux As String = ""
    Try
      If diSize > 1024 * 1024 * 1024 Then
        sAux = Format(diSize / (1024 * 1024 * 1024), "0") & " GB"
      ElseIf diSize > 1024 * 1024 Then
        sAux = Format(diSize / (1024 * 1024), "0") & " MB"
      ElseIf diSize > 1024 Then
        sAux = Format(diSize / (1024), "0") & " KB"
      Else
        sAux = Format(diSize, "0") & " B"
      End If
    Catch ex As Exception

    End Try
    Return sAux
  End Function

  Private Sub CPuMultiEngine_VizConnected(ByVal Engine As EngineViz) Handles CPuMultiEngine.VizConnected
    Dim nEngine As Integer
    Dim bFound As Boolean
    Try
      bFound = False
      For nEngine = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
        If Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.Config.ID = Engine.CControlViz.Config.ID Then
          bFound = True
          Exit For
        End If
      Next
      If bFound = False Then Exit Sub
      Me.CarregarEscena(0, nEngine)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub CPuMultiEngine_VizMemoryStats(ByVal CEngine As EngineViz, ByVal dTotal As Double, ByVal dPixel As Double, ByVal dAllocated As Double, ByVal dSize As Double) Handles CPuMultiEngine.VizMemoryStats
    Dim nEngine As Integer
    Dim bFound As Boolean
    Try
      bFound = False
      For nEngine = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
        If Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.Config.ID = CEngine.CControlViz.Config.ID Then
          bFound = True
          Exit For
        End If
      Next
      If bFound = False Then Exit Sub
      Me.UpdateInfo(nEngine, dTotal, dPixel, dAllocated, dSize)
    Catch ex As Exception

    End Try
  End Sub


  Private Sub CPuMultiEngine_VizSceneDataArrival(ByVal CEngine As EngineViz, ByVal CCommand As Command) Handles CPuMultiEngine.VizSceneDataArrival
    Dim CStyle As C1.Win.C1FlexGrid.CellStyle
    Dim CRange As C1.Win.C1FlexGrid.CellRange
    Dim nEngine As Integer
    Dim bFound As Boolean
    Try
      bFound = False
      For nEngine = 0 To Me.CPuMultiEngine.LlistaEngines.Count - 1
        If Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.Config.ID = CEngine.CControlViz.Config.ID Then
          bFound = True
          Exit For
        End If
      Next

      If bFound = False Then Exit Sub
      If CCommand.ID = nPiID(nEngine) Then
        Select Case CCommand.VizrtCommand
          Case eVizrtCommands.LoadScene
            'activarla!
            If CCommand.BoolError = False Then
              Me.nPiID(nEngine) = Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.ActivateScene(Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.Config.SceneBasePath & Me.LlistaEscenes(Me.nPiEscena(nEngine)))
              Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.SetSceneBackgroundImageActive(False)
              Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.DirectorRewindAll()
              If Me.Visible Then
                With Me.C1FlexGridEscenes
                  CStyle = .Styles("Activating")
                  CRange = .GetCellRange(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine)
                  CRange.Style = CStyle
                  .SetData(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine, "Activating")
                  .AutoSizeCols(0, .Cols.Count - 1, 5)
                End With
              End If
            Else
              'Ha fallat!!!
              If Me.Visible Then
                With Me.C1FlexGridEscenes
                  CStyle = .Styles("Error")
                  CRange = .GetCellRange(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine)
                  CRange.Style = CStyle
                  .SetData(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine, "Error")
                  .AutoSizeCols(0, .Cols.Count - 1, 5)
                End With
                Me.CarregarEscena(Me.nPiEscena(nEngine) + 1, nEngine)
              End If
              End If
          Case eVizrtCommands.ActivateScene
            'passar a la següent!
            If Me.Visible Then
              With Me.C1FlexGridEscenes
                CStyle = .Styles("Loaded")
                CRange = .GetCellRange(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine)
                CRange.Style = CStyle
                .SetData(Me.nPiEscena(nEngine) + .Rows.Fixed, eColsEscenes.Estat + nEngine, "Loaded")
                nPiLastRow = Me.nPiEscena(nEngine) + .Rows.Fixed
                .AutoSizeCols(0, .Cols.Count - 1, 5)
              End With
              Me.CarregarEscena(Me.nPiEscena(nEngine) + 1, nEngine)
            End If
        End Select
      Else
        Select Case CCommand.VizrtCommand
          Case eVizrtCommands.ActivateScene
            ''escena activa!
            'With Me.C1FlexGridEscenes
            '  Dim nItem As Integer = -1
            '  Dim sAux As String = CCommand.Source.Replace(Me.CPuMultiEngine.LlistaEngines(nEngine).CControlViz.Config.SceneBasePath, "")
            '  For nIndex As Integer = 0 To Me.LlistaEscenes.Count - 1
            '    If Me.LlistaEscenes(nIndex) = sAux Then
            '      nItem = nIndex
            '      Exit For
            '    End If
            '  Next
            '  If nItem > -1 Then
            '    'CStyle = .Styles("Activating")
            '    'CRange = .GetCellRange(nItem + .Rows.Fixed, eColsEscenes.Estat + nEngine)
            '    'CRange.Style = CStyle
            '    .SetData(nItem + .Rows.Fixed, eColsEscenes.Estat + nEngine, "Active")
            '    .AutoSizeCols(0, .Cols.Count - 1, 5)
            '  End If
            'End With
        End Select
      End If

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub
End Class