Imports System.Windows.Forms

Public Class DialogPreview
  Private WithEvents _vizControl As VizCommands.VizControl
  Public Property VizControl As VizCommands.VizControl
    Get
      Return _vizControl
    End Get
    Set(value As VizCommands.VizControl)
      _vizControl = value
      Me.UcPreview1.VizControl = value
    End Set
  End Property

  Private WithEvents _previewControl As VizCommands.PreviewControl


  Private _scene As VizCommands.Scene
  Public Property Scene As VizCommands.Scene
    Get
      Return _scene
    End Get
    Set(value As VizCommands.Scene)
      _scene = value
      _previewControl = New VizCommands.PreviewControl(_vizControl.Config)
      Me.UcPreview1.Scene = value
      ShowSceneInfo()
      GetPreview()
    End Set
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.GetPreview()
    Me.ShowSceneInfo()
  End Sub

#Region "Constructor"
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(vizControl As VizCommands.VizControl, scene As VizCommands.Scene)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.VizControl = vizControl
    _scene = scene
  End Sub

  Public Sub New(vizControl As VizCommands.VizControl)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.VizControl = vizControl
  End Sub
#End Region

#Region "Preview functions"
  Private WithEvents _previewAsset As VizCommands.PreviewAsset
  Public Sub GetPreview(scene As VizCommands.Scene)
    _scene = scene
    ShowSceneInfo()
    GetPreview()
  End Sub

  Private Sub GetPreview()
    Try
      _previewAsset = _previewControl.NewAsset(_scene)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowSceneInfo()
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonPreview_Click(sender As Object, e As EventArgs)
    _scene.SendSceneToEngine(_vizControl)
    _vizControl.DirectorStart(_scene.SceneDirector)
  End Sub

#End Region
End Class
