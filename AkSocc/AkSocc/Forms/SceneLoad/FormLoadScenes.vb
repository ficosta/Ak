Imports VizCommands

Public Class FormLoadScenes
  Private WithEvents _vizControl As VizCommands.VizControl

  Public Property VizConfig As VizCommands.VizConfig

  Public Property SceneList As New List(Of String)

  Private _sceneIndex As Integer = -1

  Public Sub New(scenes As List(Of String), config As VizCommands.tyConfigVizrt)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.SceneList = scenes
    _vizControl = New VizCommands.VizControl()
    _vizControl.Config = config
    _vizControl.InitializeSockets(config)
  End Sub

  Private Sub FormLoadScenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub FormLoadScenes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ShowScenes()
    LoadNextScene()
  End Sub

  Private Sub LoadNextScene()
    _sceneIndex += 1
    If _sceneIndex < Me.SceneList.Count Then
      If _sceneIndex = -1 Then _sceneIndex = 0
      _vizControl.LoadScene(_vizControl.Config.SceneBasePath & Me.SceneList(_sceneIndex))
      Me.ShowScene(Me.SceneList(_sceneIndex), "loading scene", Color.Yellow)
      Debug.Print("loading scene " & Me.SceneList(_sceneIndex))
      GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " loading")
    Else
      _vizControl.ActivateScene("")
      If Me.MetroCheckBoxCloseWhenDone.Checked Then
        Me.Close()
      End If
    End If
  End Sub

  Private Sub ActivateScene()
    If _sceneIndex < Me.SceneList.Count Then
      If _sceneIndex = -1 Then _sceneIndex = 0
      _vizControl.ActivateScene(_vizControl.Config.SceneBasePath & Me.SceneList(_sceneIndex))
      _vizControl.DirectorRewindAll()
      '_vizControl.ActivateScene("")
      GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " activating")
      Me.ShowScene(Me.SceneList(_sceneIndex), "activating scene", Color.Orange)
      Debug.Print("activating scene " & Me.SceneList(_sceneIndex))
    Else
      _vizControl.ActivateScene("")
      If Me.MetroCheckBoxCloseWhenDone.Checked Then
        Me.Close()
      End If
    End If
  End Sub

  Private Sub _vizControl_CommandResponse(CCommand As Command) Handles _vizControl.CommandResponse
    Try
      If Me.SceneList.Count <= _sceneIndex Then Exit Sub
      Select Case CCommand.VizrtCommand
        Case eVizrtCommands.ActivateScene
          If CCommand.BoolError Then
            Me.ShowScene(Me.SceneList(_sceneIndex), "error activating scene", Color.Red)
            Debug.Print("error activating scene " & Me.SceneList(_sceneIndex))
          Else
            Me.ShowScene(Me.SceneList(_sceneIndex), "activated", Color.LightGreen)
            Debug.Print("activated scene " & Me.SceneList(_sceneIndex))
            GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " activated")
          End If
          LoadNextScene()
        Case eVizrtCommands.LoadScene
          If CCommand.BoolError Then
            Me.ShowScene(Me.SceneList(_sceneIndex), "error loading scene", Color.Red)
            Debug.Print("error loading scene " & Me.SceneList(_sceneIndex))
          Else
            GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " loaded")
            Me.ShowScene(Me.SceneList(_sceneIndex), "scene loaded", Color.LightGreen)
            Debug.Print("loaded scene " & Me.SceneList(_sceneIndex))
          End If
          ActivateScene()
      End Select
    Catch ex As Exception

    End Try

  End Sub

  Private Sub FormLoadScenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Try
      _vizControl.ActivateScene("")
    Catch ex As Exception

    End Try
  End Sub


  Private Sub ShowScenes()
    Try
      Me.MetroGridScenes.Rows.Clear()
      For Each scene As String In Me.SceneList
        ShowScene(scene, "", Color.White)
      Next
    Catch ex As Exception
    End Try
  End Sub

  Private Function GetSceneRow(scene As String) As Integer
    Dim res As Integer = -1
    Try
      For row As Integer = 0 To Me.MetroGridScenes.Rows.Count - 1
        If Me.MetroGridScenes.Rows(row).Cells(ColumnScenesName.Index).Value = scene Then
          res = row
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Private Sub ShowScene(scene As String, state As String, color As Color)
    Try
      Dim row As Integer = Me.GetSceneRow(scene)
      With Me.MetroGridScenes
        If row = -1 Then row = .Rows.Add(scene)
        .Rows(row).Cells(ColumnScenesName.Index).Value = scene
        .Rows(row).Cells(ColumnSceneState.Index).Value = state
        .Rows(row).Cells(ColumnSceneState.Index).Style.BackColor = color
      End With


    Catch ex As Exception

    End Try
  End Sub

End Class