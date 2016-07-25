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
    Me.MetroLabelScene.Text = ""
    LoadNextScene()
  End Sub

  Private Sub LoadNextScene()
    _sceneIndex += 1
    If _sceneIndex < Me.SceneList.Count Then
      If _sceneIndex = -1 Then _sceneIndex = 0
      _vizControl.LoadScene(_vizControl.Config.SceneBasePath & Me.SceneList(_sceneIndex))
      Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " loading" & vbCrLf & MetroLabelScene.Text
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
      _vizControl.ActivateScene("")
      GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " activating")
      Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " activating" & vbCrLf & MetroLabelScene.Text
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
            Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " not activated " & CCommand.ReceivedData & vbCrLf & MetroLabelScene.Text
            Debug.Print("error activating scene " & Me.SceneList(_sceneIndex))
          Else
            Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " activated" & vbCrLf & MetroLabelScene.Text
            Debug.Print("activated scene " & Me.SceneList(_sceneIndex))
            GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " activated")
          End If
          LoadNextScene()
        Case eVizrtCommands.LoadScene
          If CCommand.BoolError Then
            Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " not loaded " & CCommand.ReceivedData & vbCrLf & MetroLabelScene.Text
            Debug.Print("error loading scene " & Me.SceneList(_sceneIndex))
          Else
            Me.MetroLabelScene.Text = Me.SceneList(_sceneIndex) & " loaded" & vbCrLf & MetroLabelScene.Text
            GlobalNotifier.Instance.AddInfoMessage(Me.SceneList(_sceneIndex) & " loaded")
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
End Class