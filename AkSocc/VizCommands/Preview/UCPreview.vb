Imports System.Windows.Forms
Imports VizCommands

Public Class UCPreview

#Region "Properties"
  Private WithEvents _vizControl As VizCommands.VizControl
  Public Property VizControl As VizCommands.VizControl
    Get
      Return _vizControl
    End Get
    Set(value As VizCommands.VizControl)
      _vizControl = value
    End Set
  End Property

  Private WithEvents _previewControl As VizCommands.PreviewControl
  Public Property PreviewControl As VizCommands.PreviewControl
    Get
      Return _previewControl
    End Get
    Set(value As VizCommands.PreviewControl)
      _previewControl = value
    End Set
  End Property


  Private _scene As VizCommands.Scene
  Public Property Scene As VizCommands.Scene
    Get
      Return _scene
    End Get
    Set(value As VizCommands.Scene)
      _scene = value
      If Not _vizControl Is Nothing Then
        _previewControl = New VizCommands.PreviewControl(_vizControl.Config)
      End If
      ShowSceneInfo()
      GetPreview()
    End Set
  End Property

  Private _showAdvancedControls As Boolean = True
  Public Property ShowAdvancedControls As Boolean
    Get
      Return _showAdvancedControls
    End Get
    Set(value As Boolean)
      _showAdvancedControls = value
      Me.SplitContainerPreview.Panel2Collapsed = Not _showAdvancedControls
    End Set
  End Property

  Private _title As String = "Title"
  Public Property Title As String
    Get
      Return _title
    End Get
    Set(value As String)
      _title = value
      Me.LabelTitle.Text = _title
    End Set
  End Property
#End Region

  Private Sub UCPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

#Region "Constructor"
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(vc As VizControl, pc As PreviewControl)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _vizControl = vc
    _previewControl = pc
  End Sub
#End Region

#Region "Preview functions"
  Private WithEvents _previewAsset As VizCommands.PreviewAsset
  Public Sub GetPreview(scene As VizCommands.Scene)
    'Me.pr.Scene = scene
    _scene = scene
    ShowSceneInfo()
    GetPreview()
  End Sub

  Private Sub GetPreview()
    Try
      'UCPreview.GetPreview()
      If _previewControl Is Nothing Then
        If Not _vizControl Is Nothing Then
          _previewControl = New PreviewControl(_vizControl.Config)
        End If
      End If
      If Not _previewControl Is Nothing Then
        _previewAsset = _previewControl.NewAsset(_scene)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowSceneInfo()
    Try
      Dim topItem As Integer = 0
      If Not Me.DataGridViewParameters.TopLeftHeaderCell Is Nothing Then topItem = Me.DataGridViewParameters.TopLeftHeaderCell.RowIndex

      Me.DataGridViewParameters.Rows.Clear()
      Me.DataGridViewParameters.Columns.Clear()
      Me.DataGridViewParameters.Columns.Add("name", "Name")
      Me.DataGridViewParameters.Columns(Me.DataGridViewParameters.ColumnCount - 1).ReadOnly = True
      Me.DataGridViewParameters.Columns.Add("value", "Value")
      Me.DataGridViewParameters.Columns(Me.DataGridViewParameters.ColumnCount - 1).ReadOnly = False


      If Not _scene Is Nothing Then
        For Each param As VizCommands.SceneParameter In _scene.SceneParameters
          Dim aux = Me.DataGridViewParameters.Rows.Add(param.Name, param.Value)
        Next
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub DataGridViewParameters_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewParameters.CellEndEdit
    Try
      Dim dr As DataGridViewRow = Me.DataGridViewParameters.Rows(e.RowIndex)

      _scene.SceneParameters.Add(dr.Cells("name").Value, dr.Cells("value").Value)

      Me.GetPreview()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click
    _scene.SendSceneToEngine(_vizControl)
    _scene.StartSceneDirectors(_vizControl, _scene.SceneDirectorsIn)
    '_vizControl.DirectorStart(_scene.SceneDirector)
  End Sub

#End Region

#Region "Preview events"

  Private Sub _previewControl_ActiveAssetChanged(asset As PreviewAsset, former_asset As PreviewAsset) Handles _previewControl.ActiveAssetChanged
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub _previewControl_AssetAdded(asset As PreviewAsset) Handles _previewControl.AssetAdded
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub _previewControl_AssetStateChanged(asset As PreviewAsset) Handles _previewControl.AssetStateChanged
    Try
      Select Case asset.AssetSate
        Case ePreviewAssetState.Idle
          Me.PictureBoxCanvas.Image = Nothing
        Case ePreviewAssetState.Rendering
          Me.PictureBoxCanvas.Image = Nothing
        Case ePreviewAssetState.Done
          Me.PictureBoxCanvas.Image = asset.AssetImage
      End Select
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class
