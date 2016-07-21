Imports VizCommands

Public Class frmMain
  Private WithEvents _vizcontrol As VizCommands.VizControl

  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub ButtonRW_Click(sender As Object, e As EventArgs) Handles ButtonRW.Click
    Try
      _vizcontrol.DirectorRewind(Me.ComboBoxAnimations.Text)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
    Try
      _vizcontrol.DirectorStart(Me.ComboBoxAnimations.Text)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonContinue_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click
    Try
      _vizcontrol.DirectorContinue(Me.ComboBoxAnimations.Text)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ReadConfig()
    _vizcontrol = New VizCommands.VizControl
    _vizcontrol.Config = gudtConfig.ConfigVizrt
    _vizcontrol.InitializeSockets()
  End Sub

  Private Sub _vizcontrol_DataArrivalGetActiveScene(sScene As String) Handles _vizcontrol.DataArrivalGetActiveScene
    Try
      Me.LabelSceneName.Text = sScene
      If Not _vizcontrol Is Nothing Then
        _vizcontrol.GetSceneDirectors()
        _vizcontrol.GetControlObjectFields("$object")
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _vizcontrol_CommandResponse(CCommand As Command) Handles _vizcontrol.CommandResponse
    Try
      Select Case CCommand.VizrtCommand
        Case eVizrtCommands.ActivateScene
          Debug.Print("Scene activated " & CCommand.Source)
        Case eVizrtCommands.GetScenePathFromID
          Me.LabelSceneName.Text = CCommand.ReceivedData
      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub LabelSceneName_Click(sender As Object, e As EventArgs) Handles LabelSceneName.Click
    Try
      If Not _vizcontrol Is Nothing Then _vizcontrol.GetActiveScene()
    Catch ex As Exception

    End Try
  End Sub


  Private Sub _vizcontrol_DataArrivalSceneAnimations(ListAnimations As List(Of String)) Handles _vizcontrol.DataArrivalSceneAnimations
    Try
      With Me.ComboBoxAnimations
        .Items.Clear()
        For Each anim As String In ListAnimations
          .Items.Add(anim)
        Next
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private _updating As Boolean = False

  Private Sub _vizcontrol_DataArrivalSceneControlObject(CControlObjecTree As ControlObjectTree) Handles _vizcontrol.DataArrivalSceneControlObject
    Try
      _updating = True
      With Me.MetroGridControlObjects
        .Rows.Clear()
        .Rows.Add(CControlObjecTree.NodeCount)
        For itm As Integer = 0 To CControlObjecTree.NodeCount - 1
          .Rows(itm).Cells(ColumnName.Index).Value = CControlObjecTree.Node(itm).Field
          .Rows(itm).Cells(ColumnType.Index).Value = CControlObjecTree.Node(itm).ControlType.ToString
          .Rows(itm).Cells(ColumnValue.Index).Value = ""
        Next
      End With

    Catch ex As Exception

    End Try
    _updating = False
  End Sub


  Private Sub MetroGridControlObjects_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridControlObjects.CellValueChanged
    If _updating Then Exit Sub
    Try
      _vizcontrol.SetControlObjectValue("$object", Me.MetroGridControlObjects.Rows(e.RowIndex).Cells(ColumnName.Index).Value, Me.MetroGridControlObjects.Rows(e.RowIndex).Cells(ColumnValue.Index).Value)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridControlObjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridControlObjects.CellContentClick
    Try
      Debug.Print("Selected index changed")

      Debug.Print(Me.MetroGridControlObjects.Rows(e.RowIndex).Cells(ColumnName.Index).Value)
      Dim aux As String = Me.MetroGridControlObjects.Rows(e.RowIndex).Cells(ColumnName.Index).Value
      Dim val As String = Me.MetroGridControlObjects.Rows(e.RowIndex).Cells(ColumnValue.Index).Value
      ' aux = """" & aux & """"
      aux = aux.Replace("Side_1", "Side_"" & gSide & """)
      aux = aux.Replace("Side_2", "Side_"" & gSide & """)

      aux = aux.Replace("Subject_01", "Subject_"" & Strings.Format(nSubject, ""00"") & """)

      aux = "scene.SceneParameters.Add(""" & aux & " "", """ & val & """)"

      Clipboard.SetText(aux)
    Catch ex As Exception

    End Try
  End Sub
End Class
